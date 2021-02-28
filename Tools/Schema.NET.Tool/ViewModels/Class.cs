namespace Schema.NET.Tool.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using Schema.NET.Tool.Constants;

    [DebuggerDisplay("{Name}")]
#pragma warning disable CA1716 // Identifiers should not match keywords
    public class Class : SchemaObject
#pragma warning restore CA1716 // Identifiers should not match keywords
    {
        public IEnumerable<Class> Ancestors => EnumerableExtensions
            .Traverse(this, x => x.Parents)
            .Where(x => x != this);

        public List<Class> Children { get; } = new List<Class>();

        public List<Class> CombinationOf { get; } = new List<Class>();

        public IEnumerable<Class> Descendants => EnumerableExtensions
            .Traverse(this, x => x.Children)
            .Where(x => x != this);

        public string Description { get; set; }

        public Uri Id { get; set; }

        public bool IsArchived => EnumerableExtensions
            .Traverse(this, x => x.Parents)
            .Any(x => string.Equals(x.Layer, LayerName.Archived, StringComparison.Ordinal));

        public bool IsCombined { get; set; }

        public IEnumerable<Property> DeclaredProperties
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

        public List<Class> Parents { get; } = new List<Class>();

        public List<Property> Properties { get; } = new List<Property>();
    }
}
