namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A medical organization (physical or not), such as hospital, institution or clinic.
    /// </summary>
    [DataContract]
    public class MedicalOrganization : Organization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalOrganization";
    }
}
