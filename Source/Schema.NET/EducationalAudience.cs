namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An EducationalAudience.
    /// </summary>
    [DataContract]
    public class EducationalAudience : Audience
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "EducationalAudience";

        /// <summary>
        /// An educationalRole of an EducationalAudience.
        /// </summary>
        [DataMember(Name = "educationalRole")]
        public string EducationalRole { get; set; }
    }
}
