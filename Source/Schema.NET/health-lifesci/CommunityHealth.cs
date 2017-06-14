namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A field of public health focusing on improving health characteristics of a defined population in relation with their geographical or environment areas
    /// </summary>
    [DataContract]
    public partial class CommunityHealth : MedicalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CommunityHealth";
    }
}
