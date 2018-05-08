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
    public partial class Restaurant : FoodEstablishment, IRestaurant
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Restaurant";
    }
}
