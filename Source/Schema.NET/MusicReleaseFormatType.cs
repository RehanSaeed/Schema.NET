namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Format of this release (the type of recording media used, ie. compact disc, digital media, LP, etc...
    /// </summary>
    [DataContract]
    public class MusicReleaseFormatType : Enumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MusicReleaseFormatType";
    }
}
