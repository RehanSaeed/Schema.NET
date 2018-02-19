using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// Organization: A business corporation.
    /// </summary>
    [DataContract]
    public partial class Corporation : Organization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Corporation";

        /// <summary>
        /// The exchange traded instrument associated with a Corporation object. The tickerSymbol is expressed as an exchange and an instrument name separated by a space character. For the exchange component of the tickerSymbol attribute, we reccommend using the controlled vocaulary of Market Identifier Codes (MIC) specified in ISO15022.
        /// </summary>
        [DataMember(Name = "tickerSymbol", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? TickerSymbol { get; set; } 
    }
}
