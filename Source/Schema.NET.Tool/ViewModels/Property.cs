namespace Schema.NET.Tool.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;

    [DebuggerDisplay("{Name}")]
    public class Property : ICloneable<Property>
    {
        public Class Class { get; set; }

        public string Description { get; set; }

        public string JsonName { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public List<PropertyType> Types { get; set; } = new List<PropertyType>();

        /// <summary>
        /// generate the interface so we can define the fixed number of types a property can hold
        /// </summary>
        /// <param name="stringBuilder"></param>
        /// <param name="indent"></param>
        public void AppendIndentInterface(StringBuilder stringBuilder, int indent)
        {
            if (this
                .Class
                .Ancestors
                .Any(x => x.Properties.Any(y => string.Equals(y.Name, this.Name, StringComparison.Ordinal))))
            {
                return;
            }


            var interfaceName = this.Name;
            if (interfaceName == "Value")
            {
                interfaceName = "AValue";
            }
            stringBuilder.AppendIndentLine(indent, $"public interface I{interfaceName} : IValue {{}}");
            stringBuilder.AppendIndentLine(indent, $"public interface I{interfaceName}<T> : I{interfaceName} {{ new T Value {{ get; }} }}");
            stringBuilder.AppendIndentLine(indent, $"public class OneOrMany{interfaceName} : OneOrMany<I{interfaceName}>");
            stringBuilder.AppendIndentLine(indent, "{");
            stringBuilder.AppendIndentLine(indent + 4, $"public OneOrMany{interfaceName}(I{interfaceName} item) : base(item) {{ }}");
            stringBuilder.AppendIndentLine(indent + 4, $"public OneOrMany{interfaceName}(IEnumerable<I{interfaceName}> items) : base(items) {{ }}");
            foreach (var t in this.Types)
            {
                var csharpType = t.CSharpTypeString;
                stringBuilder.AppendIndentLine(indent + 4, $"public static implicit operator OneOrMany{interfaceName} ({csharpType} value) {{ return new OneOrMany{interfaceName} (new {interfaceName}{csharpType} (value)); }}");
                stringBuilder.AppendIndentLine(indent + 4, $"public static implicit operator OneOrMany{interfaceName} ({csharpType}[] values) {{ return new OneOrMany{interfaceName} (values.Select(v => (I{interfaceName}) new {interfaceName}{csharpType} (v))); }}");
                stringBuilder.AppendIndentLine(indent + 4, $"public static implicit operator OneOrMany{interfaceName} (List<{csharpType}> values) {{ return new OneOrMany{interfaceName} (values.Select(v => (I{interfaceName}) new {interfaceName}{csharpType} (v))); }}");
            }
            stringBuilder.AppendIndentLine(indent, "}");

            foreach (var t in this.Types)
            {
                var csharpType = t.CSharpTypeString;
                stringBuilder.AppendIndentLine(indent, $"public struct {interfaceName}{csharpType} : I{interfaceName}<{csharpType}>");
                stringBuilder.AppendIndentLine(indent, "{");
                stringBuilder.AppendIndentLine(indent + 4, "object IValue.Value => this.Value;");
                stringBuilder.AppendIndentLine(indent + 4, $"public {csharpType} Value {{ get; }}");
                stringBuilder.AppendIndentLine(indent + 4, $"public {interfaceName}{csharpType} ({csharpType} value) {{ Value = value; }}");
                stringBuilder.AppendIndentLine(indent + 4, $"public static implicit operator {interfaceName}{csharpType} ({csharpType} value) {{ return new {interfaceName}{csharpType} (value); }}");
                stringBuilder.AppendIndentLine(indent, "}");
            }
        }

        public void AppendIndentLine(StringBuilder stringBuilder, int indent)
        {
            stringBuilder.AppendCommentSummary(indent, this.Description);

            var isVirtual = this
                .Class
                .Descendants
                .Any(x => x.Properties.Any(y => string.Equals(y.Name, this.Name, StringComparison.Ordinal)));
            var isOverride = this
                .Class
                .Ancestors
                .Any(x => x.Properties.Any(y => string.Equals(y.Name, this.Name, StringComparison.Ordinal)));
            var modifier = isVirtual ? " virtual" : string.Empty;
            modifier = isOverride ? " override" : modifier;

            var csharpType = this.Name;
            if (csharpType == "Value")
            {
                csharpType = "AValue";
            }
            var typeString = $"OneOrMany{csharpType}";

            stringBuilder.AppendIndentLine(indent, $"[DataMember(Name = \"{this.JsonName}\", Order = {this.Order})]");
            stringBuilder.AppendIndentLine(indent, $"public{modifier} {typeString} {this.Name} {{ get; set; }}");
        }

        public Property Clone() =>
            new Property()
            {
                Description = this.Description,
                JsonName = this.JsonName,
                Name = this.Name,
                Order = this.Order,
                Types = this.Types.Select(x => x.Clone()).ToList()
            };
    }
}
