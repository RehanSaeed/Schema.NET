namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The frequency in MHz and the modulation used for a particular BroadcastService.
    /// </summary>
    [DataContract]
    public partial class BroadcastFrequencySpecification : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BroadcastFrequencySpecification";

        /// <summary>
        /// The frequency in MHz for a particular broadcast.
        /// </summary>
        [DataMember(Name = "broadcastFrequencyValue", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<double?, QuantitativeValue>? BroadcastFrequencyValue { get; set; }

        /// <summary>
        /// The modulation (e.g. FM, AM, etc) used by a particular broadcast service
        /// </summary>
        [DataMember(Name = "broadcastSignalModulation", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? BroadcastSignalModulation { get; set; }

        /// <summary>
        /// The subchannel used for the broadcast.
        /// </summary>
        [DataMember(Name = "broadcastSubChannel", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? BroadcastSubChannel { get; set; }
    }
}
