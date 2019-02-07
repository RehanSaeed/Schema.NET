namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any medical intervention designed to prevent, treat, and cure human diseases and medical conditions, including both curative and palliative therapies. Medical therapies are typically processes of care relying upon pharmacotherapy, behavioral therapy, supportive therapy (with fluid or nutrition for example), or detoxification (e.g. hemodialysis) aimed at improving or preventing a health condition.
    /// </summary>
    [DataContract]
    public partial class MedicalTherapy : TherapeuticProcedure
    {
        public interface IContraindication : IValue {}
        public interface IContraindication<T> : IContraindication { new T Value { get; } }
        public class OneOrManyContraindication : OneOrMany<IContraindication>
        {
            public OneOrManyContraindication(IContraindication item) : base(item) { }
            public OneOrManyContraindication(IEnumerable<IContraindication> items) : base(items) { }
            public static implicit operator OneOrManyContraindication (MedicalContraindication value) { return new OneOrManyContraindication (new ContraindicationMedicalContraindication (value)); }
            public static implicit operator OneOrManyContraindication (MedicalContraindication[] values) { return new OneOrManyContraindication (values.Select(v => (IContraindication) new ContraindicationMedicalContraindication (v))); }
            public static implicit operator OneOrManyContraindication (List<MedicalContraindication> values) { return new OneOrManyContraindication (values.Select(v => (IContraindication) new ContraindicationMedicalContraindication (v))); }
            public static implicit operator OneOrManyContraindication (string value) { return new OneOrManyContraindication (new Contraindicationstring (value)); }
            public static implicit operator OneOrManyContraindication (string[] values) { return new OneOrManyContraindication (values.Select(v => (IContraindication) new Contraindicationstring (v))); }
            public static implicit operator OneOrManyContraindication (List<string> values) { return new OneOrManyContraindication (values.Select(v => (IContraindication) new Contraindicationstring (v))); }
        }
        public struct ContraindicationMedicalContraindication : IContraindication<MedicalContraindication>
        {
            object IValue.Value => this.Value;
            public MedicalContraindication Value { get; }
            public ContraindicationMedicalContraindication (MedicalContraindication value) { Value = value; }
            public static implicit operator ContraindicationMedicalContraindication (MedicalContraindication value) { return new ContraindicationMedicalContraindication (value); }
        }
        public struct Contraindicationstring : IContraindication<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Contraindicationstring (string value) { Value = value; }
            public static implicit operator Contraindicationstring (string value) { return new Contraindicationstring (value); }
        }

        public interface IDuplicateTherapy : IValue {}
        public interface IDuplicateTherapy<T> : IDuplicateTherapy { new T Value { get; } }
        public class OneOrManyDuplicateTherapy : OneOrMany<IDuplicateTherapy>
        {
            public OneOrManyDuplicateTherapy(IDuplicateTherapy item) : base(item) { }
            public OneOrManyDuplicateTherapy(IEnumerable<IDuplicateTherapy> items) : base(items) { }
            public static implicit operator OneOrManyDuplicateTherapy (MedicalTherapy value) { return new OneOrManyDuplicateTherapy (new DuplicateTherapyMedicalTherapy (value)); }
            public static implicit operator OneOrManyDuplicateTherapy (MedicalTherapy[] values) { return new OneOrManyDuplicateTherapy (values.Select(v => (IDuplicateTherapy) new DuplicateTherapyMedicalTherapy (v))); }
            public static implicit operator OneOrManyDuplicateTherapy (List<MedicalTherapy> values) { return new OneOrManyDuplicateTherapy (values.Select(v => (IDuplicateTherapy) new DuplicateTherapyMedicalTherapy (v))); }
        }
        public struct DuplicateTherapyMedicalTherapy : IDuplicateTherapy<MedicalTherapy>
        {
            object IValue.Value => this.Value;
            public MedicalTherapy Value { get; }
            public DuplicateTherapyMedicalTherapy (MedicalTherapy value) { Value = value; }
            public static implicit operator DuplicateTherapyMedicalTherapy (MedicalTherapy value) { return new DuplicateTherapyMedicalTherapy (value); }
        }

        public interface ISeriousAdverseOutcome : IValue {}
        public interface ISeriousAdverseOutcome<T> : ISeriousAdverseOutcome { new T Value { get; } }
        public class OneOrManySeriousAdverseOutcome : OneOrMany<ISeriousAdverseOutcome>
        {
            public OneOrManySeriousAdverseOutcome(ISeriousAdverseOutcome item) : base(item) { }
            public OneOrManySeriousAdverseOutcome(IEnumerable<ISeriousAdverseOutcome> items) : base(items) { }
            public static implicit operator OneOrManySeriousAdverseOutcome (MedicalEntity value) { return new OneOrManySeriousAdverseOutcome (new SeriousAdverseOutcomeMedicalEntity (value)); }
            public static implicit operator OneOrManySeriousAdverseOutcome (MedicalEntity[] values) { return new OneOrManySeriousAdverseOutcome (values.Select(v => (ISeriousAdverseOutcome) new SeriousAdverseOutcomeMedicalEntity (v))); }
            public static implicit operator OneOrManySeriousAdverseOutcome (List<MedicalEntity> values) { return new OneOrManySeriousAdverseOutcome (values.Select(v => (ISeriousAdverseOutcome) new SeriousAdverseOutcomeMedicalEntity (v))); }
        }
        public struct SeriousAdverseOutcomeMedicalEntity : ISeriousAdverseOutcome<MedicalEntity>
        {
            object IValue.Value => this.Value;
            public MedicalEntity Value { get; }
            public SeriousAdverseOutcomeMedicalEntity (MedicalEntity value) { Value = value; }
            public static implicit operator SeriousAdverseOutcomeMedicalEntity (MedicalEntity value) { return new SeriousAdverseOutcomeMedicalEntity (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalTherapy";

        /// <summary>
        /// A contraindication for this therapy.
        /// </summary>
        [DataMember(Name = "contraindication", Order = 406)]
        public OneOrManyContraindication Contraindication { get; set; }

        /// <summary>
        /// A therapy that duplicates or overlaps this one.
        /// </summary>
        [DataMember(Name = "duplicateTherapy", Order = 407)]
        public OneOrManyDuplicateTherapy DuplicateTherapy { get; set; }

        /// <summary>
        /// A possible serious complication and/or serious side effect of this therapy. Serious adverse outcomes include those that are life-threatening; result in death, disability, or permanent damage; require hospitalization or prolong existing hospitalization; cause congenital anomalies or birth defects; or jeopardize the patient and may require medical or surgical intervention to prevent one of the outcomes in this definition.
        /// </summary>
        [DataMember(Name = "seriousAdverseOutcome", Order = 408)]
        public OneOrManySeriousAdverseOutcome SeriousAdverseOutcome { get; set; }
    }
}
