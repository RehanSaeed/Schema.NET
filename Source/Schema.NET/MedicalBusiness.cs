namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A particular physical or virtual business of an organization for medical purposes...
    /// </summary>
    [DataContract]
    public class MedicalBusiness : LocalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicalBusiness";
    }
}
