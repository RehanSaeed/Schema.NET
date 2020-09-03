namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A media object, such as an image, video, or audio object embedded in a web page or a downloadable dataset i.e. DataDownload. Note that a creative work may have many media objects associated with it on the same web page. For example, a page about a single song (MusicRecording) may have a music video (VideoObject), and a high and low bandwidth audio stream (2 AudioObject's).
    /// </summary>
    public partial interface IMediaObject : ICreativeWork
    {
        /// <summary>
        /// A NewsArticle associated with the Media Object.
        /// </summary>
        OneOrMany<INewsArticle> AssociatedArticle { get; set; }

        /// <summary>
        /// The bitrate of the media object.
        /// </summary>
        OneOrMany<string> Bitrate { get; set; }

        /// <summary>
        /// File size in (mega/kilo) bytes.
        /// </summary>
        OneOrMany<string> ContentSize { get; set; }

        /// <summary>
        /// Actual bytes of the media object, for example the image file or video file.
        /// </summary>
        OneOrMany<Uri> ContentUrl { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        OneOrMany<TimeSpan?> Duration { get; set; }

        /// <summary>
        /// A URL pointing to a player for a specific video. In general, this is the information in the &lt;code&gt;src&lt;/code&gt; element of an &lt;code&gt;embed&lt;/code&gt; tag and should not be the same as the content of the &lt;code&gt;loc&lt;/code&gt; tag.
        /// </summary>
        OneOrMany<Uri> EmbedUrl { get; set; }

        /// <summary>
        /// The CreativeWork encoded by this media object.
        /// </summary>
        OneOrMany<ICreativeWork> EncodesCreativeWork { get; set; }

        /// <summary>
        /// The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to end. For actions that span a period of time, when the action was performed. e.g. John wrote a book from January to &lt;em&gt;December&lt;/em&gt;. For media, including audio and video, it's the time offset of the end of a clip within a larger file.&lt;br/&gt;&lt;br/&gt;
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        Values<DateTimeOffset?, TimeSpan?> EndTime { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        Values<string, IQuantitativeValue, int> Height { get; set; }

        /// <summary>
        /// Player type required&amp;#x2014;for example, Flash or Silverlight.
        /// </summary>
        OneOrMany<string> PlayerType { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        OneOrMany<IOrganization> ProductionCompany { get; set; }

        /// <summary>
        /// The regions where the media is allowed. If not specified, then it's assumed to be allowed everywhere. Specify the countries in &lt;a href="http://en.wikipedia.org/wiki/ISO_3166"&gt;ISO 3166 format&lt;/a&gt;.
        /// </summary>
        OneOrMany<IPlace> RegionsAllowed { get; set; }

        /// <summary>
        /// Indicates if use of the media require a subscription  (either paid or free). Allowed values are &lt;code&gt;true&lt;/code&gt; or &lt;code&gt;false&lt;/code&gt; (note that an earlier version had 'yes', 'no').
        /// </summary>
        Values<bool?, IMediaSubscription> RequiresSubscription { get; set; }

        /// <summary>
        /// The startTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to start. For actions that span a period of time, when the action was performed. e.g. John wrote a book from &lt;em&gt;January&lt;/em&gt; to December. For media, including audio and video, it's the time offset of the start of a clip within a larger file.&lt;br/&gt;&lt;br/&gt;
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        Values<DateTimeOffset?, TimeSpan?> StartTime { get; set; }

        /// <summary>
        /// Date when this media object was uploaded to this site.
        /// </summary>
        Values<int?, DateTime?> UploadDate { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        Values<string, IQuantitativeValue, int> Width { get; set; }
    }

    /// <summary>
    /// A media object, such as an image, video, or audio object embedded in a web page or a downloadable dataset i.e. DataDownload. Note that a creative work may have many media objects associated with it on the same web page. For example, a page about a single song (MusicRecording) may have a music video (VideoObject), and a high and low bandwidth audio stream (2 AudioObject's).
    /// </summary>
    [DataContract]
    public partial class MediaObject : CreativeWork, IMediaObject, IEquatable<MediaObject>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MediaObject";

        /// <summary>
        /// A NewsArticle associated with the Media Object.
        /// </summary>
        [DataMember(Name = "associatedArticle", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<INewsArticle> AssociatedArticle { get; set; }

        /// <summary>
        /// The bitrate of the media object.
        /// </summary>
        [DataMember(Name = "bitrate", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Bitrate { get; set; }

        /// <summary>
        /// File size in (mega/kilo) bytes.
        /// </summary>
        [DataMember(Name = "contentSize", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ContentSize { get; set; }

        /// <summary>
        /// Actual bytes of the media object, for example the image file or video file.
        /// </summary>
        [DataMember(Name = "contentUrl", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> ContentUrl { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration", Order = 210)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public virtual OneOrMany<TimeSpan?> Duration { get; set; }

        /// <summary>
        /// A URL pointing to a player for a specific video. In general, this is the information in the &lt;code&gt;src&lt;/code&gt; element of an &lt;code&gt;embed&lt;/code&gt; tag and should not be the same as the content of the &lt;code&gt;loc&lt;/code&gt; tag.
        /// </summary>
        [DataMember(Name = "embedUrl", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> EmbedUrl { get; set; }

        /// <summary>
        /// The CreativeWork encoded by this media object.
        /// </summary>
        [DataMember(Name = "encodesCreativeWork", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> EncodesCreativeWork { get; set; }

        /// <summary>
        /// Media type typically expressed using a MIME format (see &lt;a href="http://www.iana.org/assignments/media-types/media-types.xhtml"&gt;IANA site&lt;/a&gt; and &lt;a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types"&gt;MDN reference&lt;/a&gt;) e.g. application/zip for a SoftwareApplication binary, audio/mpeg for .mp3 etc.).&lt;br/&gt;&lt;br/&gt;
        /// In cases where a &lt;a class="localLink" href="https://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; has several media type representations, &lt;a class="localLink" href="https://schema.org/encoding"&gt;encoding&lt;/a&gt; can be used to indicate each &lt;a class="localLink" href="https://schema.org/MediaObject"&gt;MediaObject&lt;/a&gt; alongside particular &lt;a class="localLink" href="https://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt; information.&lt;br/&gt;&lt;br/&gt;
        /// Unregistered or niche encoding and file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia/Wikidata entry.
        /// </summary>
        [DataMember(Name = "encodingFormat", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<string, Uri> EncodingFormat { get; set; }

        /// <summary>
        /// The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to end. For actions that span a period of time, when the action was performed. e.g. John wrote a book from January to &lt;em&gt;December&lt;/em&gt;. For media, including audio and video, it's the time offset of the end of a clip within a larger file.&lt;br/&gt;&lt;br/&gt;
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        [DataMember(Name = "endTime", Order = 214)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<DateTimeOffset?, TimeSpan?> EndTime { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [DataMember(Name = "height", Order = 215)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IQuantitativeValue, int> Height { get; set; }

        /// <summary>
        /// Player type required&amp;#x2014;for example, Flash or Silverlight.
        /// </summary>
        [DataMember(Name = "playerType", Order = 216)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PlayerType { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany", Order = 217)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> ProductionCompany { get; set; }

        /// <summary>
        /// The regions where the media is allowed. If not specified, then it's assumed to be allowed everywhere. Specify the countries in &lt;a href="http://en.wikipedia.org/wiki/ISO_3166"&gt;ISO 3166 format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "regionsAllowed", Order = 218)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> RegionsAllowed { get; set; }

        /// <summary>
        /// Indicates if use of the media require a subscription  (either paid or free). Allowed values are &lt;code&gt;true&lt;/code&gt; or &lt;code&gt;false&lt;/code&gt; (note that an earlier version had 'yes', 'no').
        /// </summary>
        [DataMember(Name = "requiresSubscription", Order = 219)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<bool?, IMediaSubscription> RequiresSubscription { get; set; }

        /// <summary>
        /// The startTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to start. For actions that span a period of time, when the action was performed. e.g. John wrote a book from &lt;em&gt;January&lt;/em&gt; to December. For media, including audio and video, it's the time offset of the start of a clip within a larger file.&lt;br/&gt;&lt;br/&gt;
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        [DataMember(Name = "startTime", Order = 220)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<DateTimeOffset?, TimeSpan?> StartTime { get; set; }

        /// <summary>
        /// Date when this media object was uploaded to this site.
        /// </summary>
        [DataMember(Name = "uploadDate", Order = 221)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> UploadDate { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        [DataMember(Name = "width", Order = 222)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IQuantitativeValue, int> Width { get; set; }

        /// <inheritdoc/>
        public bool Equals(MediaObject other)
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
                this.AssociatedArticle == other.AssociatedArticle &&
                this.Bitrate == other.Bitrate &&
                this.ContentSize == other.ContentSize &&
                this.ContentUrl == other.ContentUrl &&
                this.Duration == other.Duration &&
                this.EmbedUrl == other.EmbedUrl &&
                this.EncodesCreativeWork == other.EncodesCreativeWork &&
                this.EncodingFormat == other.EncodingFormat &&
                this.EndTime == other.EndTime &&
                this.Height == other.Height &&
                this.PlayerType == other.PlayerType &&
                this.ProductionCompany == other.ProductionCompany &&
                this.RegionsAllowed == other.RegionsAllowed &&
                this.RequiresSubscription == other.RequiresSubscription &&
                this.StartTime == other.StartTime &&
                this.UploadDate == other.UploadDate &&
                this.Width == other.Width &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MediaObject);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AssociatedArticle)
            .And(this.Bitrate)
            .And(this.ContentSize)
            .And(this.ContentUrl)
            .And(this.Duration)
            .And(this.EmbedUrl)
            .And(this.EncodesCreativeWork)
            .And(this.EncodingFormat)
            .And(this.EndTime)
            .And(this.Height)
            .And(this.PlayerType)
            .And(this.ProductionCompany)
            .And(this.RegionsAllowed)
            .And(this.RequiresSubscription)
            .And(this.StartTime)
            .And(this.UploadDate)
            .And(this.Width)
            .And(base.GetHashCode());
    }
}
