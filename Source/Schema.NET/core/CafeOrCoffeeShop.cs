namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A cafe or coffee shop.
    /// </summary>
    public partial interface ICafeOrCoffeeShop : IFoodEstablishment
    {
    }

    /// <summary>
    /// A cafe or coffee shop.
    /// </summary>
    [DataContract]
    public partial class CafeOrCoffeeShop : FoodEstablishment, ICafeOrCoffeeShop, IEquatable<CafeOrCoffeeShop>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CafeOrCoffeeShop";

        /// <inheritdoc/>
        public bool Equals(CafeOrCoffeeShop other)
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
        public override bool Equals(object obj) => this.Equals(obj as CafeOrCoffeeShop);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
