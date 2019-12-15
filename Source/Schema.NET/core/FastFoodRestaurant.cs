namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A fast-food restaurant.
    /// </summary>
    public partial interface IFastFoodRestaurant : IFoodEstablishment
    {
    }

    /// <summary>
    /// A fast-food restaurant.
    /// </summary>
    [DataContract]
    public partial class FastFoodRestaurant : FoodEstablishment, IFastFoodRestaurant, IEquatable<FastFoodRestaurant>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FastFoodRestaurant";

        /// <inheritdoc/>
        public bool Equals(FastFoodRestaurant other)
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
        public override bool Equals(object obj) => this.Equals(obj as FastFoodRestaurant);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
