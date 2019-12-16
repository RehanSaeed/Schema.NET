namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A clothing store.
    /// </summary>
    public partial interface IClothingStore : IStore
    {
    }

    /// <summary>
    /// A clothing store.
    /// </summary>
    [DataContract]
    public partial class ClothingStore : Store, IClothingStore, IEquatable<ClothingStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ClothingStore";

        /// <inheritdoc/>
        public bool Equals(ClothingStore other)
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
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as ClothingStore);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
