namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A collection of items e.g. creative works or products.
    /// </summary>
    public partial interface ICollection : ICreativeWork
    {
        /// <summary>
        /// The number of items in the &lt;a class="localLink" href="https://schema.org/Collection"&gt;Collection&lt;/a&gt;.
        /// </summary>
        OneOrMany<int?> CollectionSize { get; set; }
    }

    /// <summary>
    /// A collection of items e.g. creative works or products.
    /// </summary>
    [DataContract]
    public partial class Collection : CreativeWork, ICollection, IEquatable<Collection>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Collection";

        /// <summary>
        /// The number of items in the &lt;a class="localLink" href="https://schema.org/Collection"&gt;Collection&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "collectionSize", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> CollectionSize { get; set; }

        /// <inheritdoc/>
        public bool Equals(Collection other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.CollectionSize == other.CollectionSize &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Collection);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.CollectionSize)
            .And(base.GetHashCode());
    }
}
