namespace Schema.NET.Tool.GeneratorModels
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using Schema.NET.Tool.Constants;

    [DebuggerDisplay("{Name}")]
#pragma warning disable CA1716 // Identifiers should not match keywords
    public class GeneratorSchemaClass : GeneratorSchemaObject
#pragma warning restore CA1716 // Identifiers should not match keywords
    {
        public IEnumerable<GeneratorSchemaClass> Ancestors => EnumerableExtensions
            .Traverse(this, x => x.Parents)
            .Where(x => x != this);

        public List<GeneratorSchemaClass> Children { get; } = new List<GeneratorSchemaClass>();

        public List<GeneratorSchemaClass> CombinationOf { get; } = new List<GeneratorSchemaClass>();

        public IEnumerable<GeneratorSchemaClass> Descendants => EnumerableExtensions
            .Traverse(this, x => x.Children)
            .Where(x => x != this);

        public string? Description { get; set; }

        public Uri? Id { get; set; }

        public bool IsArchived => EnumerableExtensions
            .Traverse(this, x => x.Parents)
            .Any(x => string.Equals(x.Layer, LayerName.Archived, StringComparison.Ordinal));

        public bool IsCombined { get; set; }

        public IEnumerable<GeneratorSchemaProperty> DeclaredProperties
        {
            get
            {
                var ancestorProps = this.Ancestors.SelectMany(ancestor => ancestor.Properties)
                    .Select(prop => prop.Name);
                var declaredProperties = this.Properties.Where(classProp => !ancestorProps.Contains(classProp.Name))
                    .OrderBy(x => x.Order);

                return declaredProperties;
            }
        }

        public bool IsMeta => EnumerableExtensions
            .Traverse(this, x => x.Parents)
            .Any(x => string.Equals(x.Layer, LayerName.Meta, StringComparison.Ordinal));

        public bool IsPending => EnumerableExtensions
            .Traverse(this, x => x.Parents)
            .Any(x => string.Equals(x.Layer, LayerName.Pending, StringComparison.Ordinal));

        public bool IsThingType => string.Equals(this.Name, "Thing", StringComparison.Ordinal);

        public List<GeneratorSchemaClass> Parents { get; } = new List<GeneratorSchemaClass>();

        public List<GeneratorSchemaProperty> Properties { get; } = new List<GeneratorSchemaProperty>();
    }
}
