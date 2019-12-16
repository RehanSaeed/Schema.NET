namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A sporting goods store.
    /// </summary>
    public partial interface ISportingGoodsStore : IStore
    {
    }

    /// <summary>
    /// A sporting goods store.
    /// </summary>
    [DataContract]
    public partial class SportingGoodsStore : Store, ISportingGoodsStore, IEquatable<SportingGoodsStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SportingGoodsStore";

        /// <inheritdoc/>
        public bool Equals(SportingGoodsStore other)
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
        public override bool Equals(object obj) => this.Equals(obj as SportingGoodsStore);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
