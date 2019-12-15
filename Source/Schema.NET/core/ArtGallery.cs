namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An art gallery.
    /// </summary>
    public partial interface IArtGallery : IEntertainmentBusiness
    {
    }

    /// <summary>
    /// An art gallery.
    /// </summary>
    [DataContract]
    public partial class ArtGallery : EntertainmentBusiness, IArtGallery, IEquatable<ArtGallery>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ArtGallery";
    }
}
