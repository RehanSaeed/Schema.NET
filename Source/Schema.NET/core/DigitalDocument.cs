namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An electronic file or document.
    /// </summary>
    [DataContract]
    public partial class DigitalDocument : CreativeWork
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
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DigitalDocumentPermission>? HasDigitalDocumentPermission { get; set; }
    }
}
