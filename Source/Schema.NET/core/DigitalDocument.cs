namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An electronic file or document.
    /// </summary>
    public partial interface IDigitalDocument : ICreativeWork
    {
        /// <summary>
        /// A permission related to the access to this document (e.g. permission to read or write an electronic document). For a public document, specify a grantee with an Audience with audienceType equal to "public".
        /// </summary>
        OneOrMany<IDigitalDocumentPermission, DigitalDocumentPermission> HasDigitalDocumentPermission { get; set; }
    }

    /// <summary>
    /// An electronic file or document.
    /// </summary>
    [DataContract]
    public partial class DigitalDocument : CreativeWork, IDigitalDocument
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DigitalDocument";

        /// <summary>
        /// A permission related to the access to this document (e.g. permission to read or write an electronic document). For a public document, specify a grantee with an Audience with audienceType equal to "public".
        /// </summary>
        [DataMember(Name = "hasDigitalDocumentPermission", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDigitalDocumentPermission, DigitalDocumentPermission> HasDigitalDocumentPermission { get; set; }
    }
}
