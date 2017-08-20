namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An item used as either a tool or supply when performing the instructions for how to to achieve a result.
    /// </summary>
    [DataContract]
    public partial class HowToItem : ListItem
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HowToItem";

        /// <summary>
        /// The required quantity of the item(s).
        /// </summary>
        [DataMember(Name = "requiredQuantity", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<double?, QuantitativeValue, string>? RequiredQuantity { get; set; }
    }
}
