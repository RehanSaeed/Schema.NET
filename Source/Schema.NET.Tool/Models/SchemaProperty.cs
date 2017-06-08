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

        public string Comment { get; set; }

        public string Url { get; set; }

        public string Name { get; set; }

        public List<SchemaType> Types { get; set; } = new List<SchemaType>();

        public List<string> Parents { get; set; } = new List<string>();

        public string PropertyType { get; set; }

        public void AppendIndentLine(StringBuilder stringBuilder, int count, bool isLast, SchemaClass schemaClass)
        {
            AppendCommentLine(stringBuilder, count);

            var csharpName = GetCSharpName(this.Name);
            var distinctTypes = new List<SchemaType>();
            foreach (var type in this.Types)
            {
                SetCSharpType(type);
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
                stringBuilder.AppendIndentLine(count, $"[DataMember(Name = \"{this.Name}\")]");
                stringBuilder.AppendIndentLine(count, $"public{modifier} {adjustedType.CSharpTypeString} {csharpName} {{ get; set; }}");
                if (!isLast)
                {
                    stringBuilder.AppendLine();
                }
            }
            else
            {
                stringBuilder.AppendIndentLine(count, $"[DataMember(Name = \"{this.Name}\")]");
                stringBuilder.AppendIndentLine(count, $"public{modifier} object {csharpName} {{ get; protected set; }}");
                stringBuilder.AppendLine();

                foreach (var type in distinctTypes)
                {
                    var isLastType = type == distinctTypes.Last();
                    var isStruct = !(type.CSharpType == null || type.CSharpType.GetTypeInfo().IsClass);
                    var nullable = isStruct ? "?" : string.Empty;

                    AppendCommentLine(stringBuilder, count);

                    stringBuilder.AppendIndentLine(count, "[IgnoreDataMember]");
                    stringBuilder.AppendIndentLine(count, $"public{modifier} {type.CSharpTypeString}{nullable} {csharpName}{type.Name}");
                    stringBuilder.AppendIndentLine(count, "{");
                    stringBuilder.AppendIndentLine(count + 4, $"get => this.{csharpName} as {type.CSharpTypeString}{nullable};");
                    stringBuilder.AppendIndentLine(count + 4, $"set => this.{csharpName} = value;");
                    stringBuilder.AppendIndentLine(count, "}");
                    if (!(isLast && isLastType))
                    {
                        stringBuilder.AppendLine();
                    }
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

        private static void SetCSharpType(SchemaType type)
        {
            switch (type.Name)
            {
                case "Boolean":
                    type.CSharpType = typeof(bool);
                    type.CSharpTypeString = "bool";
                    break;
                case "Date":
                case "DateTime":
                    type.CSharpType = typeof(DateTimeOffset);
                    type.CSharpTypeString = "DateTimeOffset";
                    break;
                case "Integer":
                    type.CSharpType = typeof(int);
                    type.CSharpTypeString = "int";
                    break;
                case "Number":
                    type.CSharpType = typeof(decimal);
                    type.CSharpTypeString = "decimal";
                    break;
                case "Text":
                    type.CSharpType = typeof(string);
                    type.CSharpTypeString = "string";
                    break;
                case "Time":
                    type.CSharpType = typeof(TimeSpan);
                    type.CSharpTypeString = "TimeSpan";
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
            stringBuilder.AppendCommentLine(count, this.Comment);
            stringBuilder.AppendIndentLine(count, "/// </summary>");
        }
    }
}
