namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A short segment/part of a movie.
    /// </summary>
    [DataContract]
    public class MovieClip : Clip
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MovieClip";
    }
}
