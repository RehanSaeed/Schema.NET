namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Web page type: Video gallery page.
    /// </summary>
    public partial interface IVideoGallery : ICollectionPage
    {
    }

    /// <summary>
    /// Web page type: Video gallery page.
    /// </summary>
    [DataContract]
    public partial class VideoGallery : CollectionPage, IVideoGallery, IEquatable<VideoGallery>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "VideoGallery";
    }
}
