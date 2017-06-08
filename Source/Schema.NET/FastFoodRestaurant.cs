namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A fast-food restaurant.
    /// </summary>
    [DataContract]
    public class FastFoodRestaurant : FoodEstablishment
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "FastFoodRestaurant";
    }
}
