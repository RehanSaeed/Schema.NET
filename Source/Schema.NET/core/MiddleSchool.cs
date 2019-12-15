namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A middle school (typically for children aged around 11-14, although this varies somewhat).
    /// </summary>
    public partial interface IMiddleSchool : IEducationalOrganization
    {
    }

    /// <summary>
    /// A middle school (typically for children aged around 11-14, although this varies somewhat).
    /// </summary>
    [DataContract]
    public partial class MiddleSchool : EducationalOrganization, IMiddleSchool, IEquatable<MiddleSchool>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MiddleSchool";
    }
}
