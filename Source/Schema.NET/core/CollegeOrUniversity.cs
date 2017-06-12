namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A college, university, or other third-level educational institution.
    /// </summary>
    [DataContract]
    public partial class CollegeOrUniversity : EducationalOrganization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CollegeOrUniversity";
    }
}
