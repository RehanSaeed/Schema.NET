namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An EducationalAudience.
    /// </summary>
    [DataContract]
    public partial class EducationalAudience : Audience
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EducationalAudience";

        /// <summary>
        /// An educationalRole of an EducationalAudience.
        /// </summary>
        [DataMember(Name = "educationalRole", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? EducationalRole { get; set; }
    }
}
