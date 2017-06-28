namespace Schema.NET.Tool.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

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

        public bool IsClass => !this.IsEnum;

        public bool IsEnum => EnumerableExtensions
            .Traverse(this, x => x.Parent)
            .Any(x => string.Equals(x.Name, "Enumeration", StringComparison.Ordinal));

        public bool IsPrimitive => new string[] { "QualitativeValue", "Enumeration", "Boolean", "Date", "DateTime", "Number", "Text", "Quantity", "Mass", "Energy", "Distance", "Duration", "Time" }.Contains(this.Name);

        public bool IsThingClass => string.Equals(this.Name, "Thing", StringComparison.Ordinal);

        public bool IsPending => EnumerableExtensions
            .Traverse(this, x => x.Parent)
            .Any(x => string.Equals(x.Layer, "pending", StringComparison.Ordinal));

        public bool IsMeta => string.Equals(this.Layer, "meta", StringComparison.Ordinal);

        public bool IsArchived => string.Equals(this.Layer, "attic", StringComparison.Ordinal);

        [DataMember]
        public string Layer { get; set; }

        [DataMember]
        public string Name { get; set; }

        public SchemaClass Parent { get; set; }

        [DataMember(Name = "rdfs:subClassOf")]
        public string ParentUrl { get; set; }

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

            if (!this.IsEnum)
            {
                // Using statements
                stringBuilder.AppendIndentLine(4, "using System;");
                stringBuilder.AppendIndentLine(4, "using System.Runtime.Serialization;");
                stringBuilder.AppendIndentLine(4, "using Newtonsoft.Json;");
                stringBuilder.AppendLine();
            }

            // Comment
            stringBuilder.AppendIndentLine(4, "/// <summary>");
            stringBuilder.AppendCommentLine(4, this.Description);
            stringBuilder.AppendIndentLine(4, "/// </summary>");

            if (this.IsEnum)
            {
                stringBuilder.AppendIndentLine(4, $"public enum {this.Name}");
                stringBuilder.AppendIndentLine(4, "{");

                // Properties
                if (this.Properties.Count > 0)
                {
                    var i = 0;
                    foreach (var property in this.Properties.OrderBy(x => x.Name))
                    {
                        var isLast = i == (this.Properties.Count - 1);

                        stringBuilder.AppendIndentLine(8, "/// <summary>");
                        stringBuilder.AppendCommentLine(8, property.Description);
                        stringBuilder.AppendIndentLine(8, "/// </summary>");
                        stringBuilder.AppendIndent(8, property.Name);
                        if (!isLast)
                        {
                            stringBuilder.AppendLine(",");
                        }

                        stringBuilder.AppendLine();

                        ++i;
                    }
                }

                stringBuilder.AppendIndentLine(4, "}");
            }
            else
            {
                // Class
                stringBuilder.AppendIndentLine(4, "[DataContract]");
                stringBuilder.AppendIndent(4, $"public partial class {this.Name}");
                stringBuilder.AppendLine(this.Parent == null ? null : $" : {this.Parent.Name}");

                stringBuilder.AppendIndentLine(4, "{");

                if (this.IsThingClass)
                {
                    // Context Property
                    stringBuilder.AppendIndentLine(8, "/// <summary>");
                    stringBuilder.AppendIndentLine(8, "/// Gets the context for the object, specifying that it comes from schema.org.");
                    stringBuilder.AppendIndentLine(8, "/// </summary>");
                    stringBuilder.AppendIndentLine(8, "[DataMember(Name = \"@context\", Order = 0)]");
                    stringBuilder.AppendIndentLine(8, $"public override string Context => \"http://schema.org\";");
                    stringBuilder.AppendLine();
                }

                // Type Property
                stringBuilder.AppendIndentLine(8, "/// <summary>");
                stringBuilder.AppendIndentLine(8, "/// Gets the name of the type as specified by schema.org.");
                stringBuilder.AppendIndentLine(8, "/// </summary>");
                stringBuilder.AppendIndentLine(8, "[DataMember(Name = \"@type\", Order = 1)]");
                stringBuilder.AppendIndentLine(8, $"public override string Type => \"{this.Name}\";");

                // Properties
                var props = this.Properties.Where(x => x.IsProperty).OrderBy(x => x.Name, new SchemaPropertyNameComparer()).ToList();
                if (props.Count > 0)
                {
                    stringBuilder.AppendLine();
                    var i = 0;
                    var order = ((SchemaPropertyNameComparer.KnownPropertyNameOrders.Values.Max() + 1) + (this.Ancestors.Count() * 100));
                    foreach (var property in props)
                    {
                        var jsonOrder = order;
                        var lowerPropertyName = property.Name.ToLower();
                        if (SchemaPropertyNameComparer.KnownPropertyNameOrders.ContainsKey(lowerPropertyName))
                        {
                            jsonOrder = SchemaPropertyNameComparer.KnownPropertyNameOrders[lowerPropertyName];
                        }

                        var isLast = i == (props.Count - 1);
                        property.AppendIndentLine(stringBuilder, 8, jsonOrder, this);
                        if (!isLast)
                        {
                            stringBuilder.AppendLine();
                        }

                        ++i;
                        ++order;
                    }
                }

                stringBuilder.AppendIndentLine(4, "}");
            }

            stringBuilder.AppendLine("}");

            return stringBuilder.ToString();
        }
    }
}
