namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Web page type: Image gallery page.
    /// </summary>
    [DataContract]
    public class ImageGallery : CollectionPage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ImageGallery";
    }
}
