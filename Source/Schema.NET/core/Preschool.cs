namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A preschool.
    /// </summary>
    public partial interface IPreschool : IEducationalOrganization
    {
    }

    /// <summary>
    /// A preschool.
    /// </summary>
    [DataContract]
    public partial class Preschool : EducationalOrganization, IPreschool
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Preschool";
    }
}
