namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The most generic type of entity related to health and the practice of medicine.
    /// </summary>
    [DataContract]
    public partial class MedicalEntity : Thing
    {
        public interface IGuideline : IValue {}
        public interface IGuideline<T> : IGuideline { new T Value { get; } }
        public class OneOrManyGuideline : OneOrMany<IGuideline>
        {
            public OneOrManyGuideline(IGuideline item) : base(item) { }
            public OneOrManyGuideline(IEnumerable<IGuideline> items) : base(items) { }
            public static implicit operator OneOrManyGuideline (MedicalGuideline value) { return new OneOrManyGuideline (new GuidelineMedicalGuideline (value)); }
            public static implicit operator OneOrManyGuideline (MedicalGuideline[] values) { return new OneOrManyGuideline (values.Select(v => (IGuideline) new GuidelineMedicalGuideline (v))); }
            public static implicit operator OneOrManyGuideline (List<MedicalGuideline> values) { return new OneOrManyGuideline (values.Select(v => (IGuideline) new GuidelineMedicalGuideline (v))); }
        }
        public struct GuidelineMedicalGuideline : IGuideline<MedicalGuideline>
        {
            object IValue.Value => this.Value;
            public MedicalGuideline Value { get; }
            public GuidelineMedicalGuideline (MedicalGuideline value) { Value = value; }
            public static implicit operator GuidelineMedicalGuideline (MedicalGuideline value) { return new GuidelineMedicalGuideline (value); }
        }

        public interface ILegalStatus : IValue {}
        public interface ILegalStatus<T> : ILegalStatus { new T Value { get; } }
        public class OneOrManyLegalStatus : OneOrMany<ILegalStatus>
        {
            public OneOrManyLegalStatus(ILegalStatus item) : base(item) { }
            public OneOrManyLegalStatus(IEnumerable<ILegalStatus> items) : base(items) { }
            public static implicit operator OneOrManyLegalStatus (DrugLegalStatus value) { return new OneOrManyLegalStatus (new LegalStatusDrugLegalStatus (value)); }
            public static implicit operator OneOrManyLegalStatus (DrugLegalStatus[] values) { return new OneOrManyLegalStatus (values.Select(v => (ILegalStatus) new LegalStatusDrugLegalStatus (v))); }
            public static implicit operator OneOrManyLegalStatus (List<DrugLegalStatus> values) { return new OneOrManyLegalStatus (values.Select(v => (ILegalStatus) new LegalStatusDrugLegalStatus (v))); }
            public static implicit operator OneOrManyLegalStatus (MedicalEnumeration value) { return new OneOrManyLegalStatus (new LegalStatusMedicalEnumeration (value)); }
            public static implicit operator OneOrManyLegalStatus (MedicalEnumeration[] values) { return new OneOrManyLegalStatus (values.Select(v => (ILegalStatus) new LegalStatusMedicalEnumeration (v))); }
            public static implicit operator OneOrManyLegalStatus (List<MedicalEnumeration> values) { return new OneOrManyLegalStatus (values.Select(v => (ILegalStatus) new LegalStatusMedicalEnumeration (v))); }
            public static implicit operator OneOrManyLegalStatus (string value) { return new OneOrManyLegalStatus (new LegalStatusstring (value)); }
            public static implicit operator OneOrManyLegalStatus (string[] values) { return new OneOrManyLegalStatus (values.Select(v => (ILegalStatus) new LegalStatusstring (v))); }
            public static implicit operator OneOrManyLegalStatus (List<string> values) { return new OneOrManyLegalStatus (values.Select(v => (ILegalStatus) new LegalStatusstring (v))); }
        }
        public struct LegalStatusDrugLegalStatus : ILegalStatus<DrugLegalStatus>
        {
            object IValue.Value => this.Value;
            public DrugLegalStatus Value { get; }
            public LegalStatusDrugLegalStatus (DrugLegalStatus value) { Value = value; }
            public static implicit operator LegalStatusDrugLegalStatus (DrugLegalStatus value) { return new LegalStatusDrugLegalStatus (value); }
        }
        public struct LegalStatusMedicalEnumeration : ILegalStatus<MedicalEnumeration>
        {
            object IValue.Value => this.Value;
            public MedicalEnumeration Value { get; }
            public LegalStatusMedicalEnumeration (MedicalEnumeration value) { Value = value; }
            public static implicit operator LegalStatusMedicalEnumeration (MedicalEnumeration value) { return new LegalStatusMedicalEnumeration (value); }
        }
        public struct LegalStatusstring : ILegalStatus<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public LegalStatusstring (string value) { Value = value; }
            public static implicit operator LegalStatusstring (string value) { return new LegalStatusstring (value); }
        }

        public interface IMedicineSystem : IValue {}
        public interface IMedicineSystem<T> : IMedicineSystem { new T Value { get; } }
        public class OneOrManyMedicineSystem : OneOrMany<IMedicineSystem>
        {
            public OneOrManyMedicineSystem(IMedicineSystem item) : base(item) { }
            public OneOrManyMedicineSystem(IEnumerable<IMedicineSystem> items) : base(items) { }
            public static implicit operator OneOrManyMedicineSystem (MedicineSystem value) { return new OneOrManyMedicineSystem (new MedicineSystemMedicineSystem (value)); }
            public static implicit operator OneOrManyMedicineSystem (MedicineSystem[] values) { return new OneOrManyMedicineSystem (values.Select(v => (IMedicineSystem) new MedicineSystemMedicineSystem (v))); }
            public static implicit operator OneOrManyMedicineSystem (List<MedicineSystem> values) { return new OneOrManyMedicineSystem (values.Select(v => (IMedicineSystem) new MedicineSystemMedicineSystem (v))); }
        }
        public struct MedicineSystemMedicineSystem : IMedicineSystem<MedicineSystem>
        {
            object IValue.Value => this.Value;
            public MedicineSystem Value { get; }
            public MedicineSystemMedicineSystem (MedicineSystem value) { Value = value; }
            public static implicit operator MedicineSystemMedicineSystem (MedicineSystem value) { return new MedicineSystemMedicineSystem (value); }
        }

        public interface IRecognizingAuthority : IValue {}
        public interface IRecognizingAuthority<T> : IRecognizingAuthority { new T Value { get; } }
        public class OneOrManyRecognizingAuthority : OneOrMany<IRecognizingAuthority>
        {
            public OneOrManyRecognizingAuthority(IRecognizingAuthority item) : base(item) { }
            public OneOrManyRecognizingAuthority(IEnumerable<IRecognizingAuthority> items) : base(items) { }
            public static implicit operator OneOrManyRecognizingAuthority (Organization value) { return new OneOrManyRecognizingAuthority (new RecognizingAuthorityOrganization (value)); }
            public static implicit operator OneOrManyRecognizingAuthority (Organization[] values) { return new OneOrManyRecognizingAuthority (values.Select(v => (IRecognizingAuthority) new RecognizingAuthorityOrganization (v))); }
            public static implicit operator OneOrManyRecognizingAuthority (List<Organization> values) { return new OneOrManyRecognizingAuthority (values.Select(v => (IRecognizingAuthority) new RecognizingAuthorityOrganization (v))); }
        }
        public struct RecognizingAuthorityOrganization : IRecognizingAuthority<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public RecognizingAuthorityOrganization (Organization value) { Value = value; }
            public static implicit operator RecognizingAuthorityOrganization (Organization value) { return new RecognizingAuthorityOrganization (value); }
        }

        public interface IRelevantSpecialty : IValue {}
        public interface IRelevantSpecialty<T> : IRelevantSpecialty { new T Value { get; } }
        public class OneOrManyRelevantSpecialty : OneOrMany<IRelevantSpecialty>
        {
            public OneOrManyRelevantSpecialty(IRelevantSpecialty item) : base(item) { }
            public OneOrManyRelevantSpecialty(IEnumerable<IRelevantSpecialty> items) : base(items) { }
            public static implicit operator OneOrManyRelevantSpecialty (MedicalSpecialty value) { return new OneOrManyRelevantSpecialty (new RelevantSpecialtyMedicalSpecialty (value)); }
            public static implicit operator OneOrManyRelevantSpecialty (MedicalSpecialty[] values) { return new OneOrManyRelevantSpecialty (values.Select(v => (IRelevantSpecialty) new RelevantSpecialtyMedicalSpecialty (v))); }
            public static implicit operator OneOrManyRelevantSpecialty (List<MedicalSpecialty> values) { return new OneOrManyRelevantSpecialty (values.Select(v => (IRelevantSpecialty) new RelevantSpecialtyMedicalSpecialty (v))); }
        }
        public struct RelevantSpecialtyMedicalSpecialty : IRelevantSpecialty<MedicalSpecialty>
        {
            object IValue.Value => this.Value;
            public MedicalSpecialty Value { get; }
            public RelevantSpecialtyMedicalSpecialty (MedicalSpecialty value) { Value = value; }
            public static implicit operator RelevantSpecialtyMedicalSpecialty (MedicalSpecialty value) { return new RelevantSpecialtyMedicalSpecialty (value); }
        }

        public interface IStudy : IValue {}
        public interface IStudy<T> : IStudy { new T Value { get; } }
        public class OneOrManyStudy : OneOrMany<IStudy>
        {
            public OneOrManyStudy(IStudy item) : base(item) { }
            public OneOrManyStudy(IEnumerable<IStudy> items) : base(items) { }
            public static implicit operator OneOrManyStudy (MedicalStudy value) { return new OneOrManyStudy (new StudyMedicalStudy (value)); }
            public static implicit operator OneOrManyStudy (MedicalStudy[] values) { return new OneOrManyStudy (values.Select(v => (IStudy) new StudyMedicalStudy (v))); }
            public static implicit operator OneOrManyStudy (List<MedicalStudy> values) { return new OneOrManyStudy (values.Select(v => (IStudy) new StudyMedicalStudy (v))); }
        }
        public struct StudyMedicalStudy : IStudy<MedicalStudy>
        {
            object IValue.Value => this.Value;
            public MedicalStudy Value { get; }
            public StudyMedicalStudy (MedicalStudy value) { Value = value; }
            public static implicit operator StudyMedicalStudy (MedicalStudy value) { return new StudyMedicalStudy (value); }
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
        public OneOrManyGuideline Guideline { get; set; }

        /// <summary>
        /// The drug or supplement's legal status, including any controlled substance schedules that apply.
        /// </summary>
        [DataMember(Name = "legalStatus", Order = 107)]
        public virtual OneOrManyLegalStatus LegalStatus { get; set; }

        /// <summary>
        /// The system of medicine that includes this MedicalEntity, for example 'evidence-based', 'homeopathic', 'chiropractic', etc.
        /// </summary>
        [DataMember(Name = "medicineSystem", Order = 108)]
        public OneOrManyMedicineSystem MedicineSystem { get; set; }

        /// <summary>
        /// If applicable, the organization that officially recognizes this entity as part of its endorsed system of medicine.
        /// </summary>
        [DataMember(Name = "recognizingAuthority", Order = 109)]
        public OneOrManyRecognizingAuthority RecognizingAuthority { get; set; }

        /// <summary>
        /// If applicable, a medical specialty in which this entity is relevant.
        /// </summary>
        [DataMember(Name = "relevantSpecialty", Order = 110)]
        public OneOrManyRelevantSpecialty RelevantSpecialty { get; set; }

        /// <summary>
        /// A medical study or trial related to this entity.
        /// </summary>
        [DataMember(Name = "study", Order = 111)]
        public OneOrManyStudy Study { get; set; }
    }
}
