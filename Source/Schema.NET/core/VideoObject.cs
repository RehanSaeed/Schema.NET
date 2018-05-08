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
        OneOrMany<IPerson>? Actor { get; set; }

        /// <summary>
        /// The caption for this object.
        /// </summary>
        OneOrMany<string>? Caption { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson>? Director { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        Values<IMusicGroup, IPerson>? MusicBy { get; set; }

        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        OneOrMany<IImageObject>? Thumbnail { get; set; }

        /// <summary>
        /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
        /// </summary>
        OneOrMany<string>? Transcript { get; set; }

        /// <summary>
        /// The frame size of the video.
        /// </summary>
        OneOrMany<string>? VideoFrameSize { get; set; }

        /// <summary>
        /// The quality of the video.
        /// </summary>
        OneOrMany<string>? VideoQuality { get; set; }
    }

    /// <summary>
    /// A video file.
    /// </summary>
    [DataContract]
    public partial class VideoObject : MediaObject, IVideoObject
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
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? Actor { get; set; }

        /// <summary>
        /// The caption for this object.
        /// </summary>
        [DataMember(Name = "caption", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Caption { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? Director { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IMusicGroup, IPerson>? MusicBy { get; set; }

        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        [DataMember(Name = "thumbnail", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IImageObject>? Thumbnail { get; set; }

        /// <summary>
        /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
        /// </summary>
        [DataMember(Name = "transcript", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Transcript { get; set; }

        /// <summary>
        /// The frame size of the video.
        /// </summary>
        [DataMember(Name = "videoFrameSize", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? VideoFrameSize { get; set; }

        /// <summary>
        /// The quality of the video.
        /// </summary>
        [DataMember(Name = "videoQuality", Order = 313)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? VideoQuality { get; set; }
    }
}
