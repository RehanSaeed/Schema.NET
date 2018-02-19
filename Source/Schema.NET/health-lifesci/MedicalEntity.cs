using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// The most generic type of entity related to health and the practice of medicine.
    /// </summary>
    [DataContract]
    public partial class MedicalEntity : Thing
    {
        public interface ILegalStatus : IWrapper { }
        public interface ILegalStatus<T> : ILegalStatus { new T Data { get; set; } }
        public class LegalStatusDrugLegalStatus : ILegalStatus<DrugLegalStatus>
        {
            object IWrapper.Data { get { return Data; } set { Data = (DrugLegalStatus) value; } }
            public virtual DrugLegalStatus Data { get; set; }
            public LegalStatusDrugLegalStatus () { }
            public LegalStatusDrugLegalStatus (DrugLegalStatus data) { Data = data; }
            public static implicit operator LegalStatusDrugLegalStatus (DrugLegalStatus data) { return new LegalStatusDrugLegalStatus (data); }
        }

        public class LegalStatusMedicalEnumeration : ILegalStatus<MedicalEnumeration>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MedicalEnumeration) value; } }
            public virtual MedicalEnumeration Data { get; set; }
            public LegalStatusMedicalEnumeration () { }
            public LegalStatusMedicalEnumeration (MedicalEnumeration data) { Data = data; }
            public static implicit operator LegalStatusMedicalEnumeration (MedicalEnumeration data) { return new LegalStatusMedicalEnumeration (data); }
        }

        public class LegalStatusstring : ILegalStatus<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public LegalStatusstring () { }
            public LegalStatusstring (string data) { Data = data; }
            public static implicit operator LegalStatusstring (string data) { return new LegalStatusstring (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalEntity";

        /// <summary>
        /// A medical guideline related to this entity.
        /// </summary>
        [DataMember(Name = "guideline", Order = 106)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalGuideline>? Guideline { get; set; } 

        /// <summary>
        /// The drug or supplement's legal status, including any controlled substance schedules that apply.
        /// </summary>
        [DataMember(Name = "legalStatus", Order = 107)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<ILegalStatus>? LegalStatus { get; set; } //DrugLegalStatus, MedicalEnumeration?, string

        /// <summary>
        /// The system of medicine that includes this MedicalEntity, for example 'evidence-based', 'homeopathic', 'chiropractic', etc.
        /// </summary>
        [DataMember(Name = "medicineSystem", Order = 108)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicineSystem>? MedicineSystem { get; set; } 

        /// <summary>
        /// If applicable, the organization that officially recognizes this entity as part of its endorsed system of medicine.
        /// </summary>
        [DataMember(Name = "recognizingAuthority", Order = 109)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? RecognizingAuthority { get; set; } 

        /// <summary>
        /// If applicable, a medical specialty in which this entity is relevant.
        /// </summary>
        [DataMember(Name = "relevantSpecialty", Order = 110)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalSpecialty>? RelevantSpecialty { get; set; } 

        /// <summary>
        /// A medical study or trial related to this entity.
        /// </summary>
        [DataMember(Name = "study", Order = 111)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalStudy>? Study { get; set; } 
    }
}
