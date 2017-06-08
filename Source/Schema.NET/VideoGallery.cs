namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Web page type: Video gallery page.
    /// </summary>
    [DataContract]
    public class VideoGallery : CollectionPage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "VideoGallery";
    }
}
