namespace Schema.NET.Tool.GeneratorModels
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using Schema.NET.Tool.Constants;

    [DebuggerDisplay("{Name}")]
    public class GeneratorSchemaClass : GeneratorSchemaObject
    {
        public GeneratorSchemaClass(Uri id)
            : this(layer: string.Empty, id, name: string.Empty, description: string.Empty)
        {
        }

        public GeneratorSchemaClass(string layer, Uri id, string name, string description, bool isCombined = false)
            : base(layer, name, description)
        {
            this.Id = id;
            this.IsCombined = isCombined;
        }

        public IEnumerable<GeneratorSchemaClass> Ancestors => EnumerableExtensions
            .Traverse(this, x => x.Parents)
            .Where(x => x != this);

        public ICollection<GeneratorSchemaClass> Children { get; } = new List<GeneratorSchemaClass>();

        public ICollection<GeneratorSchemaClass> CombinationOf { get; } = new List<GeneratorSchemaClass>();

        public IEnumerable<GeneratorSchemaClass> Descendants => EnumerableExtensions
            .Traverse(this, x => x.Children)
            .Where(x => x != this);

        public Uri Id { get; }

        public bool IsArchived => EnumerableExtensions
            .Traverse(this, x => x.Parents)
            .Any(x => string.Equals(x.Layer, LayerName.Archived, StringComparison.Ordinal));

        public bool IsCombined { get; }

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

        public ICollection<GeneratorSchemaClass> Parents { get; } = new List<GeneratorSchemaClass>();

        public ICollection<GeneratorSchemaProperty> Properties { get; } = new List<GeneratorSchemaProperty>();
    }
}
