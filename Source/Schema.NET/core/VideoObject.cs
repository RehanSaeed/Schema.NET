namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A video file.
    /// </summary>
    public partial interface IVideoObject : IMediaObject
    {
        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson> Actor { get; set; }

        /// <summary>
        /// The caption for this object. For downloadable machine formats (closed caption, subtitles etc.) use MediaObject and indicate the &lt;a class="localLink" href="https://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt;.
        /// </summary>
        Values<IMediaObject, string> Caption { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson> Director { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        Values<IMusicGroup, IPerson> MusicBy { get; set; }

        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        OneOrMany<IImageObject> Thumbnail { get; set; }

        /// <summary>
        /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
        /// </summary>
        OneOrMany<string> Transcript { get; set; }

        /// <summary>
        /// The frame size of the video.
        /// </summary>
        OneOrMany<string> VideoFrameSize { get; set; }

        /// <summary>
        /// The quality of the video.
        /// </summary>
        OneOrMany<string> VideoQuality { get; set; }
    }

    /// <summary>
    /// A video file.
    /// </summary>
    [DataContract]
    public partial class VideoObject : MediaObject, IVideoObject, IEquatable<VideoObject>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "VideoObject";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Actor { get; set; }

        /// <summary>
        /// The caption for this object. For downloadable machine formats (closed caption, subtitles etc.) use MediaObject and indicate the &lt;a class="localLink" href="https://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "caption", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMediaObject, string> Caption { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Director { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMusicGroup, IPerson> MusicBy { get; set; }

        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        [DataMember(Name = "thumbnail", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IImageObject> Thumbnail { get; set; }

        /// <summary>
        /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
        /// </summary>
        [DataMember(Name = "transcript", Order = 311)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Transcript { get; set; }

        /// <summary>
        /// The frame size of the video.
        /// </summary>
        [DataMember(Name = "videoFrameSize", Order = 312)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> VideoFrameSize { get; set; }

        /// <summary>
        /// The quality of the video.
        /// </summary>
        [DataMember(Name = "videoQuality", Order = 313)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> VideoQuality { get; set; }

        /// <inheritdoc/>
        public bool Equals(VideoObject other)
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
                this.Actor == other.Actor &&
                this.Caption == other.Caption &&
                this.Director == other.Director &&
                this.MusicBy == other.MusicBy &&
                this.Thumbnail == other.Thumbnail &&
                this.Transcript == other.Transcript &&
                this.VideoFrameSize == other.VideoFrameSize &&
                this.VideoQuality == other.VideoQuality &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as VideoObject);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Actor)
            .And(this.Caption)
            .And(this.Director)
            .And(this.MusicBy)
            .And(this.Thumbnail)
            .And(this.Transcript)
            .And(this.VideoFrameSize)
            .And(this.VideoQuality)
            .And(base.GetHashCode());
    }
}
