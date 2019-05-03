namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A supply consumed when performing the instructions for how to achieve a result.
    /// </summary>
    [DataContract]
    public partial class HowToSupply : HowToItem
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HowToSupply";

        /// <summary>
        /// The estimated cost of the supply or supplies consumed when performing instructions.
        /// </summary>
        [DataMember(Name = "estimatedCost", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MonetaryAmount, string>? EstimatedCost { get; set; }
    }
}
