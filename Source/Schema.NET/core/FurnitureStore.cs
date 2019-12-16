namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A furniture store.
    /// </summary>
    public partial interface IFurnitureStore : IStore
    {
    }

    /// <summary>
    /// A furniture store.
    /// </summary>
    [DataContract]
    public partial class FurnitureStore : Store, IFurnitureStore, IEquatable<FurnitureStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FurnitureStore";

        /// <inheritdoc/>
        public bool Equals(FurnitureStore other)
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
        public override bool Equals(object obj) => this.Equals(obj as FurnitureStore);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
