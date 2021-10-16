namespace Schema.NET.Tool.Services
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using Schema.NET.Tool.CustomOverrides;
    using Schema.NET.Tool.GeneratorModels;
    using Schema.NET.Tool.Repositories;

    public class SchemaService
    {
        private static readonly Regex StartsWithNumber = new("^[0-9]", RegexOptions.Compiled);

        private readonly IEnumerable<IClassOverride> classOverrides;
        private readonly IEnumerable<IEnumerationOverride> enumerationOverrides;
        private readonly ISchemaRepository schemaRepository;
        private readonly bool includePending;

        public SchemaService(
            IEnumerable<IClassOverride> classOverrides,
            IEnumerable<IEnumerationOverride> enumerationOverrides,
            ISchemaRepository schemaRepository,
            bool includePending)
        {
            this.classOverrides = classOverrides;
            this.enumerationOverrides = enumerationOverrides;
            this.schemaRepository = schemaRepository;
            this.includePending = includePending;
        }

        public async Task<IEnumerable<GeneratorSchemaObject>> GetObjectsAsync()
        {
            var (schemaClasses, schemaProperties, schemaValues) = await this.schemaRepository
                .GetObjectsAsync()
                .ConfigureAwait(false);

            var isEnumMap = new HashSet<string>(
                schemaClasses.Where(c => c.IsEnum).Select(c => c.Label),
                StringComparer.Ordinal);

            var knownSchemaClasses = new HashSet<Uri>(
                schemaClasses.Where(c => this.includePending || !c.IsPending).Select(c => c.Id));

            var classPropertyMap = schemaProperties
                .Where(p => !p.IsArchived && !p.IsMeta && (this.includePending || !p.IsPending))
                .SelectMany(p => p.DomainIncludes.Select(i => (Id: i, Property: p)))
                .GroupBy(x => x.Id)
                .ToDictionary(g => g.Key, g => g.Select(p => p.Property).ToArray());

            var enumerations = new List<GeneratorSchemaEnumeration>();
            var classes = new List<GeneratorSchemaClass>();
            foreach (var schemaClass in schemaClasses
                .Where(x => !x.IsPrimitive && !x.IsArchived && !x.IsMeta && (this.includePending || !x.IsPending)))
            {
                if (schemaClass.IsEnum)
                {
                    var enumeration = TranslateEnumeration(schemaClass, schemaValues);
                    enumerations.Add(enumeration);
                }
                else
                {
                    if (!classPropertyMap.TryGetValue(schemaClass.Id, out var classProperties))
                    {
                        classProperties = Array.Empty<Models.SchemaProperty>();
                    }

                    var @class = TranslateClass(schemaClass, schemaClasses, classProperties, isEnumMap, knownSchemaClasses, this.includePending);
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
                foreach (var @class in classes.Where(x => x.Parents.Count > 1 && x.Parents.Any(y => y.IsThingType)).ToArray())
                {
                    var thingParent = @class.Parents.First(x => x.IsThingType);
                    @class.Parents.Remove(thingParent);
                    thingParent.Children.Remove(@class);
                }

                foreach (var @class in classes.Where(x => x.Parents.Count > 1).ToArray())
                {
                    foreach (var parent in @class.Parents.ToArray())
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

                foreach (var @class in classes.Where(x => x.Parents.Count > 1).ToArray())
                {
                    var className = string.Join("And", @class.Parents.Select(x => x.Name).OrderBy(x => x));

                    var combinedClass = classes.FirstOrDefault(x => string.Equals(x.Name, className, StringComparison.Ordinal));
                    if (combinedClass is null)
                    {
                        var classDescription = "See " + string.Join(", ", @class.Parents.Select(x => x.Name).OrderBy(x => x)) + " for more information.";
                        var parents = @class.Parents.SelectMany(x => x.Parents).GroupBy(x => x.Name).Select(x => x.First()).ToArray();
                        var layerName = @class.IsCombined ? @class.Layer : $"{@class.Layer}.combined";
                        combinedClass = new GeneratorSchemaClass(layerName, new Uri($"https://CombinedClass/{className}"), className, classDescription, isCombined: true);
                        combinedClass.CombinationOf.AddRange(@class.Parents);
                        combinedClass.Properties.AddRange(@class
                            .Parents
                            .SelectMany(x => x.Properties)
                            .Select(x => x.Clone(combinedClass))
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
                foreach (var parentClassId in @class.Parents.Select(x => x.Id).Distinct().ToArray())
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
            IEnumerable<Models.SchemaEnumerationValue> schemaValues)
        {
            var enumeration = new GeneratorSchemaEnumeration($"{schemaClass.Layer}.enumerations", schemaClass.Label, schemaClass.Comment);
            enumeration.Values.AddRange(schemaValues
                .Where(x => x.Types.Contains(schemaClass.Id.ToString()))
                .Select(x => new GeneratorSchemaEnumerationValue(x.Label, x.Id, x.Comment))
                .OrderBy(x => x.Name, new EnumerationValueComparer()));
            return enumeration;
        }

        private static GeneratorSchemaClass TranslateClass(
            Models.SchemaClass schemaClass,
            IEnumerable<Models.SchemaClass> schemaClasses,
            IEnumerable<Models.SchemaProperty> schemaProperties,
            HashSet<string> isEnumMap,
            HashSet<Uri> knownSchemaClasses,
            bool includePending)
        {
            var className = StartsWithNumber.IsMatch(schemaClass.Label) ? $"Type{schemaClass.Label}" : schemaClass.Label;
            var @class = new GeneratorSchemaClass(schemaClass.Layer, schemaClass.Id, className, schemaClass.Comment);

            @class.Parents.AddRange(schemaClass.SubClassOfIds
                .Where(id => knownSchemaClasses.Contains(id))
                .Select(id => new GeneratorSchemaClass(id)));

            var properties = schemaProperties
                .Select(x =>
                {
                    var propertyName = GetPropertyName(x.Label);
                    var property = new GeneratorSchemaProperty(@class, CamelCase(propertyName), propertyName, x.Comment);
                    property.Types.AddRange(x.RangeIncludes
                        .Where(id =>
                        {
                            var propertyTypeClass = schemaClasses.FirstOrDefault(z => z.Id == id);
                            return propertyTypeClass is null || (!propertyTypeClass.IsArchived && !propertyTypeClass.IsMeta && (includePending || !propertyTypeClass.IsPending));
                        })
                        .Select(id =>
                        {
#if NETSTANDARD2_0
                            var propertyTypeName = id.ToString().Replace("https://schema.org/", string.Empty);
#else
                            var propertyTypeName = id.ToString().Replace("https://schema.org/", string.Empty, StringComparison.Ordinal);
#endif
                            var isPropertyTypeEnum = isEnumMap.Contains(propertyTypeName);
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
#if NETSTANDARD2_0
                    propertyName.Contains("NumberOf") ||
                    propertyName.Contains("Year") ||
                    propertyName.Contains("Count") ||
                    propertyName.Contains("Age"):
#else
                    propertyName.Contains("NumberOf", StringComparison.Ordinal) ||
                    propertyName.Contains("Year", StringComparison.Ordinal) ||
                    propertyName.Contains("Count", StringComparison.Ordinal) ||
                    propertyName.Contains("Age", StringComparison.Ordinal):
#endif
                    return new string[] { "int?" };
                case "Number" when
#if NETSTANDARD2_0
                    propertyName.Contains("Price") ||
                    propertyName.Contains("Amount") ||
                    propertyName.Contains("Salary") ||
                    propertyName.Contains("Discount"):
#else
                    propertyName.Contains("Price", StringComparison.Ordinal) ||
                    propertyName.Contains("Amount", StringComparison.Ordinal) ||
                    propertyName.Contains("Salary", StringComparison.Ordinal) ||
                    propertyName.Contains("Discount", StringComparison.Ordinal):
#endif
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
