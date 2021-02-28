namespace Schema.NET.Tool.Services
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using Schema.NET.Tool.CustomOverrides;
    using Schema.NET.Tool.Repositories;
    using Schema.NET.Tool.GeneratorModels;

    public class SchemaService
    {
        private static readonly Regex StartsWithNumber = new Regex("^[0-9]", RegexOptions.Compiled);

        private readonly IEnumerable<IClassOverride> classOverrides;
        private readonly IEnumerable<IEnumerationOverride> enumerationOverrides;
        private readonly ISchemaRepository schemaRepository;

        public SchemaService(
            IEnumerable<IClassOverride> classOverrides,
            IEnumerable<IEnumerationOverride> enumerationOverrides,
            ISchemaRepository schemaRepository)
        {
            this.classOverrides = classOverrides;
            this.enumerationOverrides = enumerationOverrides;
            this.schemaRepository = schemaRepository;
        }

        public async Task<IEnumerable<GeneratorSchemaObject>> GetObjectsAsync()
        {
            var (schemaClasses, schemaProperties, schemaValues) = await this.schemaRepository
                .GetObjectsAsync()
                .ConfigureAwait(false);

            var enumerations = new List<GeneratorSchemaEnumeration>();
            var classes = new List<GeneratorSchemaClass>();
            foreach (var schemaClass in schemaClasses
                .Where(x => !x.IsPrimitive && !x.IsArchived && !x.IsMeta && !x.IsPending))
            {
                if (schemaClass.IsEnum)
                {
                    var enumeration = TranslateEnumeration(schemaClass, schemaValues);
                    enumerations.Add(enumeration);
                }
                else
                {
                    var @class = TranslateClass(schemaClass, schemaClasses, schemaProperties);
                    classes.Add(@class);
                }
            }

            SetParentAndChildren(classes);
            CombineMultipleParentsIntoCombinedClass(classes);

            this.ApplyEnumerationOverrides(enumerations);
            this.ApplyClassOverrides(classes);

            SetPropertyOrder(classes);

            return (enumerations as IEnumerable<GeneratorSchemaObject>).Concat(classes);
        }

        private static void CombineMultipleParentsIntoCombinedClass(List<GeneratorSchemaClass> classes)
        {
            while (classes.Any(x => x.Parents.Count > 1))
            {
                // Remove Thing types from classes with multiple parents.
                foreach (var @class in classes.Where(x => x.Parents.Count > 1 && x.Parents.Any(y => y.IsThingType)).ToList())
                {
                    var thingParent = @class.Parents.First(x => x.IsThingType);
                    @class.Parents.Remove(thingParent);
                    thingParent.Children.Remove(@class);
                }

                foreach (var @class in classes.Where(x => x.Parents.Count > 1).ToList())
                {
                    foreach (var parent in @class.Parents.ToList())
                    {
                        if (@class.Parents.Where(x => x != parent).Any(x => x.Ancestors.Any(y => y.Id == parent.Id)))
                        {
                            @class.Parents.Remove(parent);
                            parent.Children.Remove(@class);
                        }

                        if (@class.Parents.Where(x => x != parent && x.IsCombined).Any(x => x.CombinationOf.Any(y => y.Id == parent.Id)))
                        {
                            @class.Parents.Remove(parent);
                            parent.Children.Remove(@class);
                        }
                    }
                }

                foreach (var @class in classes.Where(x => x.Parents.Count > 1).ToList())
                {
                    var className = string.Join("And", @class.Parents.Select(x => x.Name).OrderBy(x => x));

                    var combinedClass = classes.FirstOrDefault(x => string.Equals(x.Name, className, StringComparison.Ordinal));
                    if (combinedClass is null)
                    {
                        var classDescription = "See " + string.Join(", ", @class.Parents.Select(x => x.Name).OrderBy(x => x)) + " for more information.";
                        var parents = @class.Parents.SelectMany(x => x.Parents).GroupBy(x => x.Name).Select(x => x.First()).ToList();
                        combinedClass = new GeneratorSchemaClass()
                        {
                            Description = classDescription,
                            Id = new Uri($"https://CombinedClass/{className}"),
                            IsCombined = true,
                            Layer = @class.IsCombined ? @class.Layer : $"{@class.Layer}{Path.DirectorySeparatorChar}combined",
                            Name = className,
                        };
                        combinedClass.CombinationOf.AddRange(@class.Parents);
                        combinedClass.Properties.AddRange(@class
                            .Parents
                            .SelectMany(x => x.Properties)
                            .Select(x =>
                            {
                                var property = x.Clone();
                                property.Class = combinedClass;
                                return property;
                            })
                            .GroupBy(x => x.Name)
                            .Select(x => x.First())
                            .OrderBy(x => x.Name));
                        foreach (var parent in parents)
                        {
                            parent.Children.Add(combinedClass);
                            combinedClass.Parents.Add(parent);
                        }

                        classes.Add(combinedClass);
                    }

                    @class.Parents.Clear();
                    @class.Parents.Add(combinedClass);
                    combinedClass.Children.Add(@class);
                }
            }
        }

        private static void SetPropertyOrder(List<GeneratorSchemaClass> classes)
        {
            foreach (var @class in classes)
            {
                var propertyOrder = PropertyNameComparer.KnownPropertyNameOrders.Values.Max() + 1 +
                    (@class.Ancestors.Count() * 100);
                foreach (var property in @class.Properties)
                {
                    property.Order = propertyOrder;

                    var upperPropertyName = property.Name.ToUpperInvariant();
                    if (PropertyNameComparer.KnownPropertyNameOrders.ContainsKey(upperPropertyName))
                    {
                        property.Order = PropertyNameComparer.KnownPropertyNameOrders[upperPropertyName];
                    }

                    ++propertyOrder;
                }
            }
        }

        private static string CamelCase(string value)
        {
            var stringBuilder = new StringBuilder(value);
            stringBuilder[0] = char.ToLower(stringBuilder[0], CultureInfo.InvariantCulture);
            return stringBuilder.ToString();
        }

        private static void SetParentAndChildren(List<GeneratorSchemaClass> classes)
        {
            foreach (var @class in classes)
            {
                foreach (var parentClassId in @class.Parents.Select(x => x.Id).Distinct().ToList())
                {
                    var parentClass = classes.FirstOrDefault(x => x.Id == parentClassId);
                    if (parentClass is null)
                    {
#pragma warning disable CA2201 // Do not raise reserved exception types
                        throw new Exception(Resources.CheckThatNewPrimitiveTypeNotAdded);
#pragma warning restore CA2201 // Do not raise reserved exception types
                    }
                    else
                    {
                        parentClass.Children.Add(@class);
                        @class.Parents.Remove(@class.Parents.First(x => x.Id == parentClassId));
                        @class.Parents.Add(parentClass);
                    }
                }
            }
        }

        private static GeneratorSchemaEnumeration TranslateEnumeration(
            Models.SchemaClass schemaClass,
            List<Models.SchemaEnumerationValue> schemaValues)
        {
            var enumeration = new GeneratorSchemaEnumeration()
            {
                Description = schemaClass.Comment,
                Layer = $"{schemaClass.Layer}{Path.DirectorySeparatorChar}enumerations",
                Name = schemaClass.Label,
            };
            enumeration.Values.AddRange(schemaValues
                .Where(x => x.Types.Contains(schemaClass.Id.ToString()))
                .Select(
                    x => new GeneratorSchemaEnumerationValue()
                    {
                        Description = x.Comment,
                        Name = x.Label,
                        Uri = x.Id,
                    })
                .OrderBy(x => x.Name, new EnumerationValueComparer()));
            return enumeration;
        }

        private static GeneratorSchemaClass TranslateClass(
            Models.SchemaClass schemaClass,
            List<Models.SchemaClass> schemaClasses,
            List<Models.SchemaProperty> schemaProperties)
        {
            var @class = new GeneratorSchemaClass()
            {
                Description = schemaClass.Comment,
                Id = schemaClass.Id,
                Layer = schemaClass.Layer,
                Name = StartsWithNumber.IsMatch(schemaClass.Label) ? $"_{schemaClass.Label}" : schemaClass.Label,
            };

            @class.Parents.AddRange(schemaClasses
                .Where(x => schemaClass.SubClassOfIds.Contains(x.Id))
                .Where(x => !x.IsPending)
                .Select(x => new GeneratorSchemaClass() { Id = x.Id }));

            var properties = schemaProperties
                .Where(x => x.DomainIncludes.Contains(schemaClass.Id) && !x.IsArchived && !x.IsMeta && !x.IsPending)
                .Select(x =>
                {
                    var propertyName = GetPropertyName(x.Label);
                    var property = new GeneratorSchemaProperty()
                    {
                        Class = @class,
                        Description = x.Comment,
                        JsonName = CamelCase(propertyName),
                        Name = propertyName,
                    };
                    property.Types.AddRange(x.RangeIncludes
                        .Where(y =>
                        {
                            var propertyTypeName = y.ToString().Replace("schema:", string.Empty);
                            var propertyTypeClass = schemaClasses
                                .FirstOrDefault(z => string.Equals(z.Label, propertyTypeName, StringComparison.Ordinal));
                            return propertyTypeClass is null || (!propertyTypeClass.IsArchived && !propertyTypeClass.IsMeta && !propertyTypeClass.IsPending);
                        })
                        .Select(y =>
                        {
                            var propertyTypeName = y.ToString().Replace("schema:", string.Empty);
                            var isPropertyTypeEnum = schemaClasses
                                .Any(z => z.IsEnum && string.Equals(z.Label, propertyTypeName, StringComparison.Ordinal));
                            var csharpTypeStrings = GetCSharpTypeStrings(
                                propertyName,
                                propertyTypeName,
                                isPropertyTypeEnum);
                            return new GeneratorSchemaPropertyType(propertyTypeName, csharpTypeStrings);
                        })
                        .Where(y => !string.Equals(y.Name, "Enumeration", StringComparison.Ordinal) &&
                            !string.Equals(y.Name, "QualitativeValue", StringComparison.Ordinal))
                        .GroupBy(y => y.CSharpTypeStrings)
                        .Select(y => y.First())
                        .OrderBy(y => y.Name));
                    return property;
                })
                .Where(x => x.Types.Count > 0)
                .OrderBy(x => x.Name, new PropertyNameComparer())
                .GroupBy(x => x.Name) // Remove duplicates.
                .Select(x => x.First())
                .ToList();
            @class.Properties.AddRange(properties);
            return @class;
        }

        private static string GetPropertyName(string name)
        {
            var stringBuilder = new StringBuilder();

            var upper = true;
            for (var i = 0; i < name.Length; ++i)
            {
                var character = name[i];

                if (upper && !char.IsUpper(character))
                {
                    stringBuilder.Append(char.ToUpper(character, CultureInfo.InvariantCulture));
                    upper = false;
                }
                else if (character == '-')
                {
                    upper = true;
                }
                else
                {
                    stringBuilder.Append(character);
                    upper = false;
                }
            }

            return stringBuilder.ToString();
        }

        private static IEnumerable<string> GetCSharpTypeStrings(string propertyName, string typeName, bool isTypeEnum)
        {
            switch (typeName)
            {
                case "Boolean":
                    return new string[] { "bool?" };
                case "DataType":
                    return new string[] { "bool?", "int?", "decimal?", "double?", "DateTime?", "TimeSpan?", "string" };
                case "Date":
                    return new string[] { "int?", "DateTime?" };
                case "DateTime":
                    return new string[] { "DateTimeOffset?" };
                case "Integer":
                case "Number" when
                    propertyName.Contains("NumberOf") ||
                    propertyName.Contains("Year") ||
                    propertyName.Contains("Count") ||
                    propertyName.Contains("Age"):
                    return new string[] { "int?" };
                case "Number" when
                    propertyName.Contains("Price") ||
                    propertyName.Contains("Amount") ||
                    propertyName.Contains("Salary") ||
                    propertyName.Contains("Discount"):
                    return new string[] { "decimal?" };
                case "Number":
                    return new string[] { "double?" };
                case "Text":
                case "Distance":
                case "Energy":
                case "Mass":
                case "XPathType":
                case "CssSelectorType":
                case "PronounceableText":
                    return new string[] { "string" };
                case "Time":
                case "Duration":
                    return new string[] { "TimeSpan?" };
                case "URL":
                    return new string[] { "Uri" };
                default:
                    if (isTypeEnum)
                    {
                        return new string[] { typeName + "?" };
                    }
                    else
                    {
                        return new string[] { "I" + typeName };
                    }
            }
        }

        private void ApplyClassOverrides(IEnumerable<GeneratorSchemaClass> classes)
        {
            foreach (var @class in classes)
            {
                foreach (var classOverride in this.classOverrides)
                {
                    if (classOverride.CanOverride(@class))
                    {
                        classOverride.Override(@class);
                    }
                }
            }
        }

        private void ApplyEnumerationOverrides(IEnumerable<GeneratorSchemaEnumeration> enumerations)
        {
            foreach (var enumeration in enumerations)
            {
                foreach (var enumerationOverride in this.enumerationOverrides)
                {
                    if (enumerationOverride.CanOverride(enumeration))
                    {
                        enumerationOverride.Override(enumeration);
                    }
                }
            }
        }
    }
}
