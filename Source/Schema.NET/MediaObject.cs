namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A media object, such as an image, video, or audio object embedded in a web page or a downloadable dataset i...
    /// </summary>
    [DataContract]
    public class MediaObject : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MediaObject";

        /// <summary>
        /// Date when this media object was uploaded to this site.
        /// </summary>
        [DataMember(Name = "uploadDate")]
        public DateTimeOffset UploadDate { get; set; }

        /// <summary>
        /// Player type required&amp;#x2014;for example, Flash or Silverlight.
        /// </summary>
        [DataMember(Name = "playerType")]
        public string PlayerType { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [DataMember(Name = "height")]
        public object Height { get; protected set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [IgnoreDataMember]
        public Distance HeightDistance
        {
            get => this.Height as Distance;
            set => this.Height = value;
        }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [IgnoreDataMember]
        public QuantitativeValue HeightQuantitativeValue
        {
            get => this.Height as QuantitativeValue;
            set => this.Height = value;
        }

        /// <summary>
        /// The bitrate of the media object.
        /// </summary>
        [DataMember(Name = "bitrate")]
        public string Bitrate { get; set; }

        /// <summary>
        /// Indicates if use of the media require a subscription  (either paid or free). Allowed values are &lt;code&gt;true&lt;/code&gt; or &lt;code&gt;false&lt;/code&gt; (note that an earlier version had 'yes', 'no').
        /// </summary>
        [DataMember(Name = "requiresSubscription")]
        public bool RequiresSubscription { get; set; }

        /// <summary>
        /// The regions where the media is allowed. If not specified, then it's assumed to be allowed everywhere. Specify the countries in &lt;a href="http://en.wikipedia.org/wiki/ISO_3166"&gt;ISO 3166 format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "regionsAllowed")]
        public Place RegionsAllowed { get; set; }

        /// <summary>
        /// Date the content expires and is no longer useful or available. Useful for videos.
        /// </summary>
        [DataMember(Name = "expires")]
        public DateTimeOffset Expires { get; set; }

        /// <summary>
        /// File size in (mega/kilo) bytes.
        /// </summary>
        [DataMember(Name = "contentSize")]
        public string ContentSize { get; set; }

        /// <summary>
        /// A URL pointing to a player for a specific video. In general, this is the information in the &lt;code&gt;src&lt;/code&gt; element of an &lt;code&gt;embed&lt;/code&gt; tag and should not be the same as the content of the &lt;code&gt;loc&lt;/code&gt; tag.
        /// </summary>
        [DataMember(Name = "embedUrl")]
        public Uri EmbedUrl { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        [DataMember(Name = "width")]
        public object Width { get; protected set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        [IgnoreDataMember]
        public Distance WidthDistance
        {
            get => this.Width as Distance;
            set => this.Width = value;
        }

        /// <summary>
        /// The width of the item.
        /// </summary>
        [IgnoreDataMember]
        public QuantitativeValue WidthQuantitativeValue
        {
            get => this.Width as QuantitativeValue;
            set => this.Width = value;
        }

        /// <summary>
        /// Actual bytes of the media object, for example the image file or video file.
        /// </summary>
        [DataMember(Name = "contentUrl")]
        public Uri ContentUrl { get; set; }

        /// <summary>
        /// A NewsArticle associated with the Media Object.
        /// </summary>
        [DataMember(Name = "associatedArticle")]
        public NewsArticle AssociatedArticle { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany")]
        public Organization ProductionCompany { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration")]
        public Duration Duration { get; set; }

        /// <summary>
        /// The CreativeWork encoded by this media object.
        /// </summary>
        [DataMember(Name = "encodesCreativeWork")]
        public CreativeWork EncodesCreativeWork { get; set; }

        /// <summary>
        /// mp3, mpeg4, etc.
        /// </summary>
        [DataMember(Name = "encodingFormat")]
        public string EncodingFormat { get; set; }
    }
}
