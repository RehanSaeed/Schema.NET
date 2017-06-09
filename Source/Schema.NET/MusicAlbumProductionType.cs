namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Classification of the album by it's type of content: soundtrack, live album, studio album, etc.
    /// </summary>
    [DataContract]
    public class MusicAlbumProductionType : Enumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicAlbumProductionType";
    }
}
