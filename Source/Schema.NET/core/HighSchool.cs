namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A high school.
    /// </summary>
    public partial interface IHighSchool : IEducationalOrganization
    {
    }

    /// <summary>
    /// A high school.
    /// </summary>
    [DataContract]
    public partial class HighSchool : EducationalOrganization, IHighSchool
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HighSchool";
    }
}
