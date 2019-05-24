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
    public partial class FastFoodRestaurant : FoodEstablishment, IFastFoodRestaurant
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FastFoodRestaurant";
    }
}
