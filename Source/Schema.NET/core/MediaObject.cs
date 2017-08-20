namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A media object, such as an image, video, or audio object embedded in a web page or a downloadable dataset i.e. DataDownload. Note that a creative work may have many media objects associated with it on the same web page. For example, a page about a single song (MusicRecording) may have a music video (VideoObject), and a high and low bandwidth audio stream (2 AudioObject's).
    /// </summary>
    [DataContract]
    public partial class MediaObject : CreativeWork
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<NewsArticle>? AssociatedArticle { get; set; }

        /// <summary>
        /// The bitrate of the media object.
        /// </summary>
        [DataMember(Name = "bitrate", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Bitrate { get; set; }

        /// <summary>
        /// File size in (mega/kilo) bytes.
        /// </summary>
        [DataMember(Name = "contentSize", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ContentSize { get; set; }

        /// <summary>
        /// Actual bytes of the media object, for example the image file or video file.
        /// </summary>
        [DataMember(Name = "contentUrl", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? ContentUrl { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration", Order = 210)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan?>? Duration { get; set; }

        /// <summary>
        /// A URL pointing to a player for a specific video. In general, this is the information in the &lt;code&gt;src&lt;/code&gt; element of an &lt;code&gt;embed&lt;/code&gt; tag and should not be the same as the content of the &lt;code&gt;loc&lt;/code&gt; tag.
        /// </summary>
        [DataMember(Name = "embedUrl", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? EmbedUrl { get; set; }

        /// <summary>
        /// The CreativeWork encoded by this media object.
        /// </summary>
        [DataMember(Name = "encodesCreativeWork", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? EncodesCreativeWork { get; set; }

        /// <summary>
        /// mp3, mpeg4, etc.
        /// </summary>
        [DataMember(Name = "encodingFormat", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? EncodingFormat { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [DataMember(Name = "height", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, QuantitativeValue, int>? Height { get; set; }

        /// <summary>
        /// Player type required&amp;#x2014;for example, Flash or Silverlight.
        /// </summary>
        [DataMember(Name = "playerType", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PlayerType { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany", Order = 216)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? ProductionCompany { get; set; }

        /// <summary>
        /// The regions where the media is allowed. If not specified, then it's assumed to be allowed everywhere. Specify the countries in &lt;a href="http://en.wikipedia.org/wiki/ISO_3166"&gt;ISO 3166 format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "regionsAllowed", Order = 217)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? RegionsAllowed { get; set; }

        /// <summary>
        /// Indicates if use of the media require a subscription  (either paid or free). Allowed values are &lt;code&gt;true&lt;/code&gt; or &lt;code&gt;false&lt;/code&gt; (note that an earlier version had 'yes', 'no').
        /// </summary>
        [DataMember(Name = "requiresSubscription", Order = 218)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<bool?>? RequiresSubscription { get; set; }

        /// <summary>
        /// Date when this media object was uploaded to this site.
        /// </summary>
        [DataMember(Name = "uploadDate", Order = 219)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? UploadDate { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        [DataMember(Name = "width", Order = 220)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, QuantitativeValue, int>? Width { get; set; }
    }
}
