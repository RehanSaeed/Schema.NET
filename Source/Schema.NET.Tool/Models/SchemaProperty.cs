namespace Schema.NET.Tool.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class SchemaProperty
    {
        public List<SchemaClass> Classes { get; set; } = new List<SchemaClass>();

        public List<string> ClassUrls { get; set; } = new List<string>();

        public string Description { get; set; }

        public bool IsClass => string.Equals(this.PropertyType, "rdfs:Class", StringComparison.OrdinalIgnoreCase);

        public bool IsEnumValue => !this.IsClass && !this.IsProperty;

        public bool IsProperty => string.Equals(this.PropertyType, "rdf:Property", StringComparison.OrdinalIgnoreCase);

        public string Url { get; set; }

        public string Name { get; set; }

        public List<SchemaType> Types { get; set; } = new List<SchemaType>();

        public List<string> Parents { get; set; } = new List<string>();

        public string PropertyType { get; set; }

        public void AppendIndentLine(StringBuilder stringBuilder, int indent, int order, SchemaClass schemaClass)
        {
            AppendCommentLine(stringBuilder, indent);

            var csharpName = GetCSharpName(this.Name);
            var distinctTypes = new List<SchemaType>();
            foreach (var type in this.Types)
            {
                SetCSharpType(csharpName, type);
                if (!distinctTypes.Any(x => string.Equals(x.CSharpTypeString, type.CSharpTypeString)))
                {
                    distinctTypes.Add(type);
                }
            }

            var isVirtual = schemaClass
                .Descendants
                .Any(x => x.Properties.Any(y => string.Equals(y.Name, this.Name, StringComparison.Ordinal)));
            var isOverride = schemaClass
                .Ancestors
                .Any(x => x.Properties.Any(y => string.Equals(y.Name, this.Name, StringComparison.Ordinal)));
            var modifier = isVirtual ? " virtual" : string.Empty;
            modifier = isOverride ? " override" : modifier;

            var adjustedTypes = string.Join(", ", distinctTypes.Select(x => x.CSharpTypeString));
            var typeString = $"Values<{adjustedTypes}>?";

            stringBuilder.AppendIndentLine(indent, $"[DataMember(Name = \"{this.Name}\", Order = {order})]");
            stringBuilder.AppendIndentLine(indent, "[JsonConverter(typeof(ValuesConverter))]");
            stringBuilder.AppendIndentLine(indent, $"public{modifier} {typeString} {csharpName} {{ get; set; }}");
        }

        private static string GetCSharpName(string name)
        {
            var stringBuilder = new StringBuilder();

            var upper = true;
            for (var i = 0; i < name.Length; ++i)
            {
                var character = name[i];

                if (upper && !char.IsUpper(character))
                {
                    stringBuilder.Append(char.ToUpper(character));
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

        private static void SetCSharpType(string name, SchemaType type)
        {
            switch (type.Name)
            {
                case "Boolean":
                    type.CSharpType = typeof(bool?);
                    type.CSharpTypeString = "bool?";
                    break;
                case "Date":
                case "DateTime":
                    type.CSharpType = typeof(DateTimeOffset?);
                    type.CSharpTypeString = "DateTimeOffset?";
                    break;
                case "Integer":
                case "Number" when name.Contains("NumberOf") || name.Contains("Year") || name.Contains("Count") || name.Contains("Age"):
                    type.CSharpType = typeof(int?);
                    type.CSharpTypeString = "int?";
                    break;
                case "Number" when name.Contains("Price") || name.Contains("Amount") || name.Contains("Salary") || name.Contains("Discount"):
                    type.CSharpType = typeof(decimal?);
                    type.CSharpTypeString = "decimal?";
                    break;
                case "Number":
                    type.CSharpType = typeof(double?);
                    type.CSharpTypeString = "double?";
                    break;
                case "Text":
                    type.CSharpType = typeof(string);
                    type.CSharpTypeString = "string";
                    break;
                case "Time":
                    type.CSharpType = typeof(TimeSpan?);
                    type.CSharpTypeString = "TimeSpan?";
                    break;
                case "URL":
                    type.CSharpType = typeof(Uri);
                    type.CSharpTypeString = "Uri";
                    break;
                default:
                    if (type.IsEnum)
                    {
                        type.CSharpTypeString = type.Name + "?";
                    }
                    else
                    {
                        type.CSharpTypeString = type.Name;
                    }
                    break;
            }
        }

        private void AppendCommentLine(StringBuilder stringBuilder, int count)
        {
            stringBuilder.AppendIndentLine(count, "/// <summary>");
            stringBuilder.AppendCommentLine(count, this.Description);
            stringBuilder.AppendIndentLine(count, "/// </summary>");
        }
    }
}
