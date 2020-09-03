namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// </summary>
    public partial interface IBroadcastService : IService
    {
        /// <summary>
        /// The media network(s) whose content is broadcast on this station.
        /// </summary>
        OneOrMany<IOrganization> BroadcastAffiliateOf { get; set; }

        /// <summary>
        /// The name displayed in the channel guide. For many US affiliates, it is the network name.
        /// </summary>
        OneOrMany<string> BroadcastDisplayName { get; set; }

        /// <summary>
        /// The organization owning or operating the broadcast service.
        /// </summary>
        OneOrMany<IOrganization> Broadcaster { get; set; }

        /// <summary>
        /// The frequency used for over-the-air broadcasts. Numeric values or simple ranges e.g. 87-99. In addition a shortcut idiom is supported for frequences of AM and FM radio channels, e.g. "87 FM".
        /// </summary>
        Values<IBroadcastFrequencySpecification, string> BroadcastFrequency { get; set; }

        /// <summary>
        /// The timezone in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 format&lt;/a&gt; for which the service bases its broadcasts
        /// </summary>
        OneOrMany<string> BroadcastTimezone { get; set; }

        /// <summary>
        /// A &lt;a href="https://en.wikipedia.org/wiki/Call_sign"&gt;callsign&lt;/a&gt;, as used in broadcasting and radio communications to identify people, radio and TV stations, or vehicles.
        /// </summary>
        OneOrMany<string> CallSign { get; set; }

        /// <summary>
        /// A broadcast channel of a broadcast service.
        /// </summary>
        OneOrMany<IBroadcastChannel> HasBroadcastChannel { get; set; }

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="https://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        Values<ILanguage, string> InLanguage { get; set; }

        /// <summary>
        /// A broadcast service to which the broadcast service may belong to such as regional variations of a national channel.
        /// </summary>
        OneOrMany<IBroadcastService> ParentService { get; set; }

        /// <summary>
        /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
        /// </summary>
        OneOrMany<string> VideoFormat { get; set; }
    }

    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// </summary>
    [DataContract]
    public partial class BroadcastService : Service, IBroadcastService, IEquatable<BroadcastService>
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> BroadcastAffiliateOf { get; set; }

        /// <summary>
        /// The name displayed in the channel guide. For many US affiliates, it is the network name.
        /// </summary>
        [DataMember(Name = "broadcastDisplayName", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BroadcastDisplayName { get; set; }

        /// <summary>
        /// The organization owning or operating the broadcast service.
        /// </summary>
        [DataMember(Name = "broadcaster", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> Broadcaster { get; set; }

        /// <summary>
        /// The frequency used for over-the-air broadcasts. Numeric values or simple ranges e.g. 87-99. In addition a shortcut idiom is supported for frequences of AM and FM radio channels, e.g. "87 FM".
        /// </summary>
        [DataMember(Name = "broadcastFrequency", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IBroadcastFrequencySpecification, string> BroadcastFrequency { get; set; }

        /// <summary>
        /// The timezone in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 format&lt;/a&gt; for which the service bases its broadcasts
        /// </summary>
        [DataMember(Name = "broadcastTimezone", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BroadcastTimezone { get; set; }

        /// <summary>
        /// A &lt;a href="https://en.wikipedia.org/wiki/Call_sign"&gt;callsign&lt;/a&gt;, as used in broadcasting and radio communications to identify people, radio and TV stations, or vehicles.
        /// </summary>
        [DataMember(Name = "callSign", Order = 311)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CallSign { get; set; }

        /// <summary>
        /// A broadcast channel of a broadcast service.
        /// </summary>
        [DataMember(Name = "hasBroadcastChannel", Order = 312)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IBroadcastChannel> HasBroadcastChannel { get; set; }

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="https://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "inLanguage", Order = 313)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ILanguage, string> InLanguage { get; set; }

        /// <summary>
        /// A broadcast service to which the broadcast service may belong to such as regional variations of a national channel.
        /// </summary>
        [DataMember(Name = "parentService", Order = 314)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IBroadcastService> ParentService { get; set; }

        /// <summary>
        /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
        /// </summary>
        [DataMember(Name = "videoFormat", Order = 315)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> VideoFormat { get; set; }

        /// <inheritdoc/>
        public bool Equals(BroadcastService other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.BroadcastAffiliateOf == other.BroadcastAffiliateOf &&
                this.BroadcastDisplayName == other.BroadcastDisplayName &&
                this.Broadcaster == other.Broadcaster &&
                this.BroadcastFrequency == other.BroadcastFrequency &&
                this.BroadcastTimezone == other.BroadcastTimezone &&
                this.CallSign == other.CallSign &&
                this.HasBroadcastChannel == other.HasBroadcastChannel &&
                this.InLanguage == other.InLanguage &&
                this.ParentService == other.ParentService &&
                this.VideoFormat == other.VideoFormat &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as BroadcastService);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.BroadcastAffiliateOf)
            .And(this.BroadcastDisplayName)
            .And(this.Broadcaster)
            .And(this.BroadcastFrequency)
            .And(this.BroadcastTimezone)
            .And(this.CallSign)
            .And(this.HasBroadcastChannel)
            .And(this.InLanguage)
            .And(this.ParentService)
            .And(this.VideoFormat)
            .And(base.GetHashCode());
    }
}
