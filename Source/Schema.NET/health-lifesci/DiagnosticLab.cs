namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A medical laboratory that offers on-site or off-site diagnostic services.
    /// </summary>
    [DataContract]
    public class DiagnosticLab : MedicalOrganization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DiagnosticLab";
    }
}
