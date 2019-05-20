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
    public partial class IceCreamShop : FoodEstablishment, IIceCreamShop
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "IceCreamShop";
    }
}
