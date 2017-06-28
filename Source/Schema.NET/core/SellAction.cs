namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of taking money from a buyer in exchange for goods or services rendered...
    /// </summary>
    [DataContract]
    public partial class SellAction : TradeAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SellAction";

        /// <summary>
        /// A sub property of participant. The participant/person/organization that bought the object.
        /// </summary>
        [DataMember(Name = "buyer", Order = 304)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Buyer { get; set; }
    }
}
