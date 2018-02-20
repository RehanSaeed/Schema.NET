namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A doctor's office.
    /// </summary>
    [DataContract]
    public partial class Physician : MedicalOrganization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Physician";

        /// <summary>
        /// A medical service available from this provider.
        /// </summary>
        [DataMember(Name = "availableService", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalProcedure, MedicalTest, MedicalTherapy>? AvailableService { get; set; }

        /// <summary>
        /// A hospital with which the physician or office is affiliated.
        /// </summary>
        [DataMember(Name = "hospitalAffiliation", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Hospital>? HospitalAffiliation { get; set; }

        /// <summary>
        /// A medical specialty of the provider.
        /// </summary>
        [DataMember(Name = "medicalSpecialty", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public override OneOrMany<MedicalSpecialty?>? MedicalSpecialty { get; set; }
    }
}
