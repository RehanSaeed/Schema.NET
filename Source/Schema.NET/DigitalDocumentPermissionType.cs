namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A type of permission which can be granted for accessing a digital document.
    /// </summary>
    [DataContract]
    public class DigitalDocumentPermissionType : Enumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "DigitalDocumentPermissionType";
    }
}
