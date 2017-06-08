namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An audio file.
    /// </summary>
    [DataContract]
    public class AudioObject : MediaObject
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "AudioObject";

        /// <summary>
        /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
        /// </summary>
        [DataMember(Name = "transcript")]
        public string Transcript { get; set; }
    }
}
