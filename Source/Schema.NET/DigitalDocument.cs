namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An electronic file or document.
    /// </summary>
    [DataContract]
    public class DigitalDocument : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "DigitalDocument";

        /// <summary>
        /// A permission related to the access to this document (e.g. permission to read or write an electronic document). For a public document, specify a grantee with an Audience with audienceType equal to "public".
        /// </summary>
        [DataMember(Name = "hasDigitalDocumentPermission")]
        public DigitalDocumentPermission HasDigitalDocumentPermission { get; set; }
    }
}
