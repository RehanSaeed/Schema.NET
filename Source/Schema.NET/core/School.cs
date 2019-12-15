namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A school.
    /// </summary>
    public partial interface ISchool : IEducationalOrganization
    {
    }

    /// <summary>
    /// A school.
    /// </summary>
    [DataContract]
    public partial class School : EducationalOrganization, ISchool, IEquatable<School>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "School";
    }
}
