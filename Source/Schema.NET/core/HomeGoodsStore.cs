namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A home goods store.
    /// </summary>
    public partial interface IHomeGoodsStore : IStore
    {
    }

    /// <summary>
    /// A home goods store.
    /// </summary>
    [DataContract]
    public partial class HomeGoodsStore : Store, IHomeGoodsStore, IEquatable<HomeGoodsStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HomeGoodsStore";

        /// <inheritdoc/>
        public bool Equals(HomeGoodsStore other)
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
        public override bool Equals(object obj) => this.Equals(obj as HomeGoodsStore);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
