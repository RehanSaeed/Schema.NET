namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A doctor's office.
    /// </summary>
    public partial interface IPhysician : IMedicalBusinessAndMedicalOrganization
    {
        /// <summary>
        /// A medical service available from this provider.
        /// </summary>
        Values<IMedicalProcedure, IMedicalTest, IMedicalTherapy>? AvailableService { get; set; }

        /// <summary>
        /// A hospital with which the physician or office is affiliated.
        /// </summary>
        OneOrMany<IHospital, Hospital> HospitalAffiliation { get; set; }
    }

    /// <summary>
    /// A doctor's office.
    /// </summary>
    [DataContract]
    public partial class Physician : MedicalBusinessAndMedicalOrganization, IPhysician
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Physician";

        /// <summary>
        /// A medical service available from this provider.
        /// </summary>
        [DataMember(Name = "availableService", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMedicalProcedure, IMedicalTest, IMedicalTherapy>? AvailableService { get; set; }

        /// <summary>
        /// A hospital with which the physician or office is affiliated.
        /// </summary>
        [DataMember(Name = "hospitalAffiliation", Order = 407)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IHospital, Hospital> HospitalAffiliation { get; set; }

        /// <summary>
        /// A medical specialty of the provider.
        /// </summary>
        [DataMember(Name = "medicalSpecialty", Order = 408)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<MedicalSpecialty?> MedicalSpecialty { get; set; }
    }
}
