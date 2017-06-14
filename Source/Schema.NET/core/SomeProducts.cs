namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A placeholder for multiple similar products of the same kind.
    /// </summary>
    [DataContract]
    public partial class SomeProducts : Product
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SomeProducts";

        /// <summary>
        /// The current approximate inventory level for the item or items.
        /// </summary>
        [DataMember(Name = "inventoryLevel", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? InventoryLevel { get; set; }
    }
}
