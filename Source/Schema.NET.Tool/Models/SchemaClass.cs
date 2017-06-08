namespace Schema.NET.Tool.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Xml;

    [DataContract]
    public class SchemaClass
    {
        public IEnumerable<SchemaClass> Ancestors
        {
            get
            {
                for (var x = this.Parent; x != null; x = x.Parent)
                {
                    yield return x;
                }
            }
        }

        [DataMember]
        public List<SchemaClass> Children { get; set; } = new List<SchemaClass>();

        public IEnumerable<SchemaClass> Descendants => EnumerableExtensions
            .Traverse(this, x => x.Children)
            .Where(x => x != this);

        [DataMember]
        public string Description { get; set; }

        [DataMember(Name = "@id")]
        public string Id { get; set; }

        [DataMember]
        public string Layer { get; set; }

        [DataMember]
        public string Name { get; set; }

        public SchemaClass Parent { get; set; }

        [DataMember(Name = "rdfs:subClassOf")]
        public string ParentId { get; set; }

        public List<SchemaProperty> Properties { get; set; } = new List<SchemaProperty>();

        [DataMember(Name = "@type")]
        public string Type { get; set; }

        public string Url => $"http://schema.org/{this.Name}";

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            // Namespace
            stringBuilder.AppendLine("namespace Schema.NET");
            stringBuilder.AppendLine("{");

            // Using statements
            stringBuilder.AppendIndentLine(4, "using System;");
            stringBuilder.AppendIndentLine(4, "using System.Runtime.Serialization;");
            stringBuilder.AppendLine();

            // Comment
            stringBuilder.AppendIndentLine(4, "/// <summary>");
            stringBuilder.AppendCommentLine(4, this.Description);
            stringBuilder.AppendIndentLine(4, "/// </summary>");

            // Class
            stringBuilder.AppendIndentLine(4, "[DataContract]");
            stringBuilder.AppendIndent(4, $"public class {this.Name}");
            stringBuilder.AppendLine(this.Parent == null ? null : $" : {this.Parent.Name}");

            stringBuilder.AppendIndentLine(4, "{");

            var isThing = string.Equals(this.Name, "Thing", StringComparison.Ordinal);
            var modifier = isThing ? "virtual" : "override";
            if (isThing)
            {
                // Context Property
                stringBuilder.AppendIndentLine(8, "/// <summary>");
                stringBuilder.AppendIndentLine(8, "/// Gets the context for the object, specifying that it comes from schema.org.");
                stringBuilder.AppendIndentLine(8, "/// </summary>");
                stringBuilder.AppendIndentLine(8, "[DataMember(Name = \"@context\")]");
                stringBuilder.AppendIndentLine(8, $"public string Context => \"http://schema.org\";");
                stringBuilder.AppendLine();
            }

            // Type Property
            stringBuilder.AppendIndentLine(8, "/// <summary>");
            stringBuilder.AppendIndentLine(8, "/// Gets the name of the type as specified by schema.org.");
            stringBuilder.AppendIndentLine(8, "/// </summary>");
            stringBuilder.AppendIndentLine(8, "[DataMember(Name = \"@type\")]");
            stringBuilder.AppendIndentLine(8, $"public {modifier} string Type => \"{this.Name}\";");
            if (this.Properties.Count > 0)
            {
                stringBuilder.AppendLine();
            }

            // Properties
            foreach (var property in this.Properties)
            {
                property.AppendIndentLine(stringBuilder, 8, this.Properties.Last() == property, this);
            }

            stringBuilder.AppendIndentLine(4, "}");
            stringBuilder.AppendLine("}");

            return stringBuilder.ToString();
        }
    }
}
