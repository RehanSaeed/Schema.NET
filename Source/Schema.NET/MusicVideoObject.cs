namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A music video file.
    /// </summary>
    [DataContract]
    public class MusicVideoObject : MediaObject
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MusicVideoObject";
    }
}
