namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A restaurant.
    /// </summary>
    public partial interface IRestaurant : IFoodEstablishment
    {
    }

    /// <summary>
    /// A restaurant.
    /// </summary>
    [DataContract]
    public partial class Restaurant : FoodEstablishment, IRestaurant, IEquatable<Restaurant>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Restaurant";

        /// <inheritdoc/>
        public bool Equals(Restaurant other)
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
        public override bool Equals(object obj) => this.Equals(obj as Restaurant);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
