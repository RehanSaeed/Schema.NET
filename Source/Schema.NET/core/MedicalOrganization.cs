using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A medical organization (physical or not), such as hospital, institution or clinic.
    /// </summary>
    [DataContract]
    public partial class MedicalOrganization : Organization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalOrganization";

        /// <summary>
        /// Name or unique ID of network. (Networks are often reused across different insurance plans).
        /// </summary>
        [DataMember(Name = "healthPlanNetworkId", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? HealthPlanNetworkId { get; set; } 

        /// <summary>
        /// Whether the provider is accepting new patients.
        /// </summary>
        [DataMember(Name = "isAcceptingNewPatients", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<bool>? IsAcceptingNewPatients { get; set; } 

        /// <summary>
        /// A medical specialty of the provider.
        /// </summary>
        [DataMember(Name = "medicalSpecialty", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<MedicalSpecialty>? MedicalSpecialty { get; set; } 
    }
}
