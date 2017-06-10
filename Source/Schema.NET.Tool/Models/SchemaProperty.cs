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

            if (distinctTypes.Count == 1)
            {
                var adjustedType = distinctTypes.First();
                stringBuilder.AppendIndentLine(indent, $"[DataMember(Name = \"{this.Name}\", Order = {order})]");
                stringBuilder.AppendIndentLine(indent, $"public{modifier} {adjustedType.CSharpTypeString} {csharpName} {{ get; set; }}");
            }
            else
            {
                stringBuilder.AppendIndentLine(indent, $"[DataMember(Name = \"{this.Name}\", Order = {order})]");
                stringBuilder.AppendIndentLine(indent, $"public{modifier} object {csharpName} {{ get; protected set; }}");
                stringBuilder.AppendLine();

                var i = 0;
                foreach (var type in distinctTypes)
                {
                    var isLastType = i == (distinctTypes.Count - 1);
                    var isStruct = !(type.CSharpType == null || type.CSharpType.GetTypeInfo().IsClass);

                    AppendCommentLine(stringBuilder, indent);

                    stringBuilder.AppendIndentLine(indent, "[IgnoreDataMember]");
                    stringBuilder.AppendIndentLine(indent, $"public{modifier} {type.CSharpTypeString} {csharpName}{type.Name}");
                    stringBuilder.AppendIndentLine(indent, "{");
                    stringBuilder.AppendIndentLine(indent + 4, $"get => this.{csharpName} as {type.CSharpTypeString};");
                    stringBuilder.AppendIndentLine(indent + 4, $"set => this.{csharpName} = value;");
                    stringBuilder.AppendIndentLine(indent, "}");
                    if (!isLastType)
                    {
                        stringBuilder.AppendLine();
                    }

                    ++i;
                }
            }
        }

        private static string GetCSharpName(string name)
        {
            var firstChar = name[0];
            if (!char.IsUpper(firstChar))
            {
                var upper = char.ToUpper(firstChar);
                name = upper + name.Substring(1, name.Length - 1);
            }

            return name;
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
                    type.CSharpTypeString = type.Name;
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
