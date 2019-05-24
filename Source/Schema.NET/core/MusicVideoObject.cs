namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A music video file.
    /// </summary>
    public partial interface IMusicVideoObject : IMediaObject
    {
    }

    /// <summary>
    /// A music video file.
    /// </summary>
    [DataContract]
    public partial class MusicVideoObject : MediaObject, IMusicVideoObject
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicVideoObject";
    }
}
