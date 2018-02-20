namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// </summary>
    [DataContract]
    public partial class BroadcastService : Service
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BroadcastService";

        /// <summary>
        /// The media network(s) whose content is broadcast on this station.
        /// </summary>
        [DataMember(Name = "broadcastAffiliateOf", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Organization>? BroadcastAffiliateOf { get; set; }

        /// <summary>
        /// The name displayed in the channel guide. For many US affiliates, it is the network name.
        /// </summary>
        [DataMember(Name = "broadcastDisplayName", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? BroadcastDisplayName { get; set; }

        /// <summary>
        /// The organization owning or operating the broadcast service.
        /// </summary>
        [DataMember(Name = "broadcaster", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Organization>? Broadcaster { get; set; }

        /// <summary>
        /// The frequency used for over-the-air broadcasts. Numeric values or simple ranges e.g. 87-99. In addition a shortcut idiom is supported for frequences of AM and FM radio channels, e.g. "87 FM".
        /// </summary>
        [DataMember(Name = "broadcastFrequency", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? BroadcastFrequency { get; set; }

        /// <summary>
        /// The timezone in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 format&lt;/a&gt; for which the service bases its broadcasts
        /// </summary>
        [DataMember(Name = "broadcastTimezone", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? BroadcastTimezone { get; set; }

        /// <summary>
        /// A broadcast channel of a broadcast service.
        /// </summary>
        [DataMember(Name = "hasBroadcastChannel", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<BroadcastChannel>? HasBroadcastChannel { get; set; }

        /// <summary>
        /// A broadcast service to which the broadcast service may belong to such as regional variations of a national channel.
        /// </summary>
        [DataMember(Name = "parentService", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<BroadcastService>? ParentService { get; set; }

        /// <summary>
        /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
        /// </summary>
        [DataMember(Name = "videoFormat", Order = 313)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? VideoFormat { get; set; }
    }
}
