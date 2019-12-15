namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An ice cream shop.
    /// </summary>
    public partial interface IIceCreamShop : IFoodEstablishment
    {
    }

    /// <summary>
    /// An ice cream shop.
    /// </summary>
    [DataContract]
    public partial class IceCreamShop : FoodEstablishment, IIceCreamShop, IEquatable<IceCreamShop>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "IceCreamShop";

        /// <inheritdoc/>
        public bool Equals(IceCreamShop other)
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
        public override bool Equals(object obj) => this.Equals(obj as IceCreamShop);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
