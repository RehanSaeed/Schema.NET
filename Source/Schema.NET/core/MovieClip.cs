namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A short segment/part of a movie.
    /// </summary>
    public partial interface IMovieClip : IClip
    {
    }

    /// <summary>
    /// A short segment/part of a movie.
    /// </summary>
    [DataContract]
    public partial class MovieClip : Clip, IMovieClip
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MovieClip";
    }
}
