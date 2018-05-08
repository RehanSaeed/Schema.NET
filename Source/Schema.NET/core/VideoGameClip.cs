namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A short segment/part of a video game.
    /// </summary>
    public partial interface IVideoGameClip : IClip
    {
    }

    /// <summary>
    /// A short segment/part of a video game.
    /// </summary>
    [DataContract]
    public partial class VideoGameClip : Clip, IVideoGameClip
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "VideoGameClip";
    }
}
