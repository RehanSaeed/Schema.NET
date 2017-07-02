namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// See MedicalBusiness, MedicalOrganization for more information.
    /// </summary>
    [DataContract]
    public abstract partial class MedicalBusinessAndMedicalOrganization : LocalBusinessAndOrganization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalBusinessAndMedicalOrganization";

        /// <summary>
        /// Name or unique ID of network. (Networks are often reused across different insurance plans).
        /// </summary>
        [DataMember(Name = "healthPlanNetworkId", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? HealthPlanNetworkId { get; set; }

        /// <summary>
        /// Whether the provider is accepting new patients.
        /// </summary>
        [DataMember(Name = "isAcceptingNewPatients", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<bool?>? IsAcceptingNewPatients { get; set; }

        /// <summary>
        /// A medical specialty of the provider.
        /// </summary>
        [DataMember(Name = "medicalSpecialty", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<MedicalSpecialty?>? MedicalSpecialty { get; set; }
    }
}
