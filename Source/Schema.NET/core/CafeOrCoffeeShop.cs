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
    }
}
