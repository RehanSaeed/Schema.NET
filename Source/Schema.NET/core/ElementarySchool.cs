namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An elementary school.
    /// </summary>
    public partial interface IElementarySchool : IEducationalOrganization
    {
    }

    /// <summary>
    /// An elementary school.
    /// </summary>
    [DataContract]
    public partial class ElementarySchool : EducationalOrganization, IElementarySchool, IEquatable<ElementarySchool>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ElementarySchool";
    }
}
