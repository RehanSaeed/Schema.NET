namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An audio file.
    /// </summary>
    public partial interface IAudioObject : IMediaObject
    {
        /// <summary>
        /// The caption for this object. For downloadable machine formats (closed caption, subtitles etc.) use MediaObject and indicate the &lt;a class="localLink" href="http://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt;.
        /// </summary>
        Values<IMediaObject, string> Caption { get; set; }

        /// <summary>
        /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
        /// </summary>
        OneOrMany<string> Transcript { get; set; }
    }

    /// <summary>
    /// An audio file.
    /// </summary>
    [DataContract]
    public partial class AudioObject : MediaObject, IAudioObject
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AudioObject";

        /// <summary>
        /// The caption for this object. For downloadable machine formats (closed caption, subtitles etc.) use MediaObject and indicate the &lt;a class="localLink" href="http://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "caption", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMediaObject, string> Caption { get; set; }

        /// <summary>
        /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
        /// </summary>
        [DataMember(Name = "transcript", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Transcript { get; set; }
    }
}
