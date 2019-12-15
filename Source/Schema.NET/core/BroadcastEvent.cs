﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An over the air or online broadcast event.
    /// </summary>
    public partial interface IBroadcastEvent : IPublicationEvent
    {
        /// <summary>
        /// The event being broadcast such as a sporting event or awards ceremony.
        /// </summary>
        OneOrMany<IEvent> BroadcastOfEvent { get; set; }

        /// <summary>
        /// True is the broadcast is of a live event.
        /// </summary>
        OneOrMany<bool?> IsLiveBroadcast { get; set; }

        /// <summary>
        /// Languages in which subtitles/captions are available, in &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard format&lt;/a&gt;.
        /// </summary>
        Values<ILanguage, string> SubtitleLanguage { get; set; }

        /// <summary>
        /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
        /// </summary>
        OneOrMany<string> VideoFormat { get; set; }
    }

    /// <summary>
    /// An over the air or online broadcast event.
    /// </summary>
    [DataContract]
    public partial class BroadcastEvent : PublicationEvent, IBroadcastEvent, IEquatable<BroadcastEvent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BroadcastEvent";

        /// <summary>
        /// The event being broadcast such as a sporting event or awards ceremony.
        /// </summary>
        [DataMember(Name = "broadcastOfEvent", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEvent> BroadcastOfEvent { get; set; }

        /// <summary>
        /// True is the broadcast is of a live event.
        /// </summary>
        [DataMember(Name = "isLiveBroadcast", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> IsLiveBroadcast { get; set; }

        /// <summary>
        /// Languages in which subtitles/captions are available, in &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "subtitleLanguage", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ILanguage, string> SubtitleLanguage { get; set; }

        /// <summary>
        /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
        /// </summary>
        [DataMember(Name = "videoFormat", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> VideoFormat { get; set; }

        /// <inheritdoc/>
        public bool Equals(BroadcastEvent other)
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
                this.BroadcastOfEvent == other.BroadcastOfEvent &&
                this.IsLiveBroadcast == other.IsLiveBroadcast &&
                this.SubtitleLanguage == other.SubtitleLanguage &&
                this.VideoFormat == other.VideoFormat &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as BroadcastEvent);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.BroadcastOfEvent)
            .And(this.IsLiveBroadcast)
            .And(this.SubtitleLanguage)
            .And(this.VideoFormat)
            .And(base.GetHashCode());
    }
}
