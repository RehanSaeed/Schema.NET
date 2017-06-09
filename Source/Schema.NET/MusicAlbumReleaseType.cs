namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The kind of release which this album is: single, EP or album.
    /// </summary>
    [DataContract]
    public class MusicAlbumReleaseType : Enumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicAlbumReleaseType";
    }
}
