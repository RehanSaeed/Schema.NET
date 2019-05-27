namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The frequency in MHz and the modulation used for a particular BroadcastService.
    /// </summary>
    public partial interface IBroadcastFrequencySpecification : IIntangible
    {
        /// <summary>
        /// The frequency in MHz for a particular broadcast.
        /// </summary>
        Values<double?, IQuantitativeValue> BroadcastFrequencyValue { get; set; }

        /// <summary>
        /// The modulation (e.g. FM, AM, etc) used by a particular broadcast service
        /// </summary>
        OneOrMany<string> BroadcastSignalModulation { get; set; }

        /// <summary>
        /// The subchannel used for the broadcast.
        /// </summary>
        OneOrMany<string> BroadcastSubChannel { get; set; }
    }

    /// <summary>
    /// The frequency in MHz and the modulation used for a particular BroadcastService.
    /// </summary>
    [DataContract]
    public partial class BroadcastFrequencySpecification : Intangible, IBroadcastFrequencySpecification
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, IQuantitativeValue> BroadcastFrequencyValue { get; set; }

        /// <summary>
        /// The modulation (e.g. FM, AM, etc) used by a particular broadcast service
        /// </summary>
        [DataMember(Name = "broadcastSignalModulation", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BroadcastSignalModulation { get; set; }

        /// <summary>
        /// The subchannel used for the broadcast.
        /// </summary>
        [DataMember(Name = "broadcastSubChannel", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BroadcastSubChannel { get; set; }
    }
}
