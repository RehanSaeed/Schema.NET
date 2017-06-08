namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A video file.
    /// </summary>
    [DataContract]
    public class VideoObject : MediaObject
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "VideoObject";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor")]
        public Person Actor { get; set; }

        /// <summary>
        /// The frame size of the video.
        /// </summary>
        [DataMember(Name = "videoFrameSize")]
        public string VideoFrameSize { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy")]
        public object MusicBy { get; protected set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [IgnoreDataMember]
        public Person MusicByPerson
        {
            get => this.MusicBy as Person;
            set => this.MusicBy = value;
        }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [IgnoreDataMember]
        public MusicGroup MusicByMusicGroup
        {
            get => this.MusicBy as MusicGroup;
            set => this.MusicBy = value;
        }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director")]
        public Person Director { get; set; }

        /// <summary>
        /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
        /// </summary>
        [DataMember(Name = "transcript")]
        public string Transcript { get; set; }

        /// <summary>
        /// The quality of the video.
        /// </summary>
        [DataMember(Name = "videoQuality")]
        public string VideoQuality { get; set; }

        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        [DataMember(Name = "thumbnail")]
        public ImageObject Thumbnail { get; set; }

        /// <summary>
        /// The caption for this object.
        /// </summary>
        [DataMember(Name = "caption")]
        public string Caption { get; set; }
    }
}
