namespace Schema.NET.Tool.ViewModels
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;

    [DebuggerDisplay("{Name}")]
    public class Enumeration : SchemaObject
    {
        public string Description { get; set; }

        public List<EnumerationValue> Values { get; set; } = new List<EnumerationValue>();

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            // Namespace
            stringBuilder.AppendLine("namespace Schema.NET");
            stringBuilder.AppendLine("{");

            // Using statements
            stringBuilder.AppendIndentLine(4, "using System.Runtime.Serialization;");
            stringBuilder.AppendLine();

            // Comment
            stringBuilder.AppendIndentLine(4, "/// <summary>");
            stringBuilder.AppendCommentLine(4, this.Description);
            stringBuilder.AppendIndentLine(4, "/// </summary>");

            // Enum
            stringBuilder.AppendIndentLine(4, $"public enum {this.Name}");
            stringBuilder.AppendIndentLine(4, "{");

            // Values
            if (this.Values.Count > 0)
            {
                var i = 0;
                foreach (var value in this.Values)
                {
                    var isLast = i == (this.Values.Count - 1);

                    stringBuilder.AppendCommentSummary(8, value.Description);
                    stringBuilder.AppendIndentLine(8, $"[EnumMember(Value = \"{value.Uri}\")]");
                    stringBuilder.AppendIndent(8, value.Name);
                    if (!isLast)
                    {
                        stringBuilder.AppendLine(",");
                    }

                    stringBuilder.AppendLine();

                    ++i;
                }
            }

            stringBuilder.AppendIndentLine(4, "}");
            stringBuilder.AppendLine("}");

            return stringBuilder.ToString();
        }
    }
}
