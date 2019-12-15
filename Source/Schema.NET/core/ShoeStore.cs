namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A shoe store.
    /// </summary>
    public partial interface IShoeStore : IStore
    {
    }

    /// <summary>
    /// A shoe store.
    /// </summary>
    [DataContract]
    public partial class ShoeStore : Store, IShoeStore, IEquatable<ShoeStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ShoeStore";

        /// <inheritdoc/>
        public bool Equals(ShoeStore other)
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
        public override bool Equals(object obj) => this.Equals(obj as ShoeStore);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
