namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Web page type: Image gallery page.
    /// </summary>
    public partial interface IImageGallery : ICollectionPage
    {
    }

    /// <summary>
    /// Web page type: Image gallery page.
    /// </summary>
    [DataContract]
    public partial class ImageGallery : CollectionPage, IImageGallery
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ImageGallery";
    }
}
