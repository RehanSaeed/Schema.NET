namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any object used in a medical capacity, such as to diagnose or treat a patient.
    /// </summary>
    [DataContract]
    public partial class MedicalDevice : MedicalEntity
    {
        public interface IAdverseOutcome : IValue {}
        public interface IAdverseOutcome<T> : IAdverseOutcome { new T Value { get; } }
        public class OneOrManyAdverseOutcome : OneOrMany<IAdverseOutcome>
        {
            public OneOrManyAdverseOutcome(IAdverseOutcome item) : base(item) { }
            public OneOrManyAdverseOutcome(IEnumerable<IAdverseOutcome> items) : base(items) { }
            public static implicit operator OneOrManyAdverseOutcome (MedicalEntity value) { return new OneOrManyAdverseOutcome (new AdverseOutcomeMedicalEntity (value)); }
            public static implicit operator OneOrManyAdverseOutcome (MedicalEntity[] values) { return new OneOrManyAdverseOutcome (values.Select(v => (IAdverseOutcome) new AdverseOutcomeMedicalEntity (v))); }
            public static implicit operator OneOrManyAdverseOutcome (List<MedicalEntity> values) { return new OneOrManyAdverseOutcome (values.Select(v => (IAdverseOutcome) new AdverseOutcomeMedicalEntity (v))); }
        }
        public struct AdverseOutcomeMedicalEntity : IAdverseOutcome<MedicalEntity>
        {
            object IValue.Value => this.Value;
            public MedicalEntity Value { get; }
            public AdverseOutcomeMedicalEntity (MedicalEntity value) { Value = value; }
            public static implicit operator AdverseOutcomeMedicalEntity (MedicalEntity value) { return new AdverseOutcomeMedicalEntity (value); }
        }

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

        public interface IIndication : IValue {}
        public interface IIndication<T> : IIndication { new T Value { get; } }
        public class OneOrManyIndication : OneOrMany<IIndication>
        {
            public OneOrManyIndication(IIndication item) : base(item) { }
            public OneOrManyIndication(IEnumerable<IIndication> items) : base(items) { }
            public static implicit operator OneOrManyIndication (MedicalIndication value) { return new OneOrManyIndication (new IndicationMedicalIndication (value)); }
            public static implicit operator OneOrManyIndication (MedicalIndication[] values) { return new OneOrManyIndication (values.Select(v => (IIndication) new IndicationMedicalIndication (v))); }
            public static implicit operator OneOrManyIndication (List<MedicalIndication> values) { return new OneOrManyIndication (values.Select(v => (IIndication) new IndicationMedicalIndication (v))); }
        }
        public struct IndicationMedicalIndication : IIndication<MedicalIndication>
        {
            object IValue.Value => this.Value;
            public MedicalIndication Value { get; }
            public IndicationMedicalIndication (MedicalIndication value) { Value = value; }
            public static implicit operator IndicationMedicalIndication (MedicalIndication value) { return new IndicationMedicalIndication (value); }
        }

        public interface IPostOp : IValue {}
        public interface IPostOp<T> : IPostOp { new T Value { get; } }
        public class OneOrManyPostOp : OneOrMany<IPostOp>
        {
            public OneOrManyPostOp(IPostOp item) : base(item) { }
            public OneOrManyPostOp(IEnumerable<IPostOp> items) : base(items) { }
            public static implicit operator OneOrManyPostOp (string value) { return new OneOrManyPostOp (new PostOpstring (value)); }
            public static implicit operator OneOrManyPostOp (string[] values) { return new OneOrManyPostOp (values.Select(v => (IPostOp) new PostOpstring (v))); }
            public static implicit operator OneOrManyPostOp (List<string> values) { return new OneOrManyPostOp (values.Select(v => (IPostOp) new PostOpstring (v))); }
        }
        public struct PostOpstring : IPostOp<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PostOpstring (string value) { Value = value; }
            public static implicit operator PostOpstring (string value) { return new PostOpstring (value); }
        }

        public interface IPreOp : IValue {}
        public interface IPreOp<T> : IPreOp { new T Value { get; } }
        public class OneOrManyPreOp : OneOrMany<IPreOp>
        {
            public OneOrManyPreOp(IPreOp item) : base(item) { }
            public OneOrManyPreOp(IEnumerable<IPreOp> items) : base(items) { }
            public static implicit operator OneOrManyPreOp (string value) { return new OneOrManyPreOp (new PreOpstring (value)); }
            public static implicit operator OneOrManyPreOp (string[] values) { return new OneOrManyPreOp (values.Select(v => (IPreOp) new PreOpstring (v))); }
            public static implicit operator OneOrManyPreOp (List<string> values) { return new OneOrManyPreOp (values.Select(v => (IPreOp) new PreOpstring (v))); }
        }
        public struct PreOpstring : IPreOp<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PreOpstring (string value) { Value = value; }
            public static implicit operator PreOpstring (string value) { return new PreOpstring (value); }
        }

        public interface IProcedure : IValue {}
        public interface IProcedure<T> : IProcedure { new T Value { get; } }
        public class OneOrManyProcedure : OneOrMany<IProcedure>
        {
            public OneOrManyProcedure(IProcedure item) : base(item) { }
            public OneOrManyProcedure(IEnumerable<IProcedure> items) : base(items) { }
            public static implicit operator OneOrManyProcedure (string value) { return new OneOrManyProcedure (new Procedurestring (value)); }
            public static implicit operator OneOrManyProcedure (string[] values) { return new OneOrManyProcedure (values.Select(v => (IProcedure) new Procedurestring (v))); }
            public static implicit operator OneOrManyProcedure (List<string> values) { return new OneOrManyProcedure (values.Select(v => (IProcedure) new Procedurestring (v))); }
        }
        public struct Procedurestring : IProcedure<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Procedurestring (string value) { Value = value; }
            public static implicit operator Procedurestring (string value) { return new Procedurestring (value); }
        }

        public interface IPurpose : IValue {}
        public interface IPurpose<T> : IPurpose { new T Value { get; } }
        public class OneOrManyPurpose : OneOrMany<IPurpose>
        {
            public OneOrManyPurpose(IPurpose item) : base(item) { }
            public OneOrManyPurpose(IEnumerable<IPurpose> items) : base(items) { }
            public static implicit operator OneOrManyPurpose (MedicalDevicePurpose value) { return new OneOrManyPurpose (new PurposeMedicalDevicePurpose (value)); }
            public static implicit operator OneOrManyPurpose (MedicalDevicePurpose[] values) { return new OneOrManyPurpose (values.Select(v => (IPurpose) new PurposeMedicalDevicePurpose (v))); }
            public static implicit operator OneOrManyPurpose (List<MedicalDevicePurpose> values) { return new OneOrManyPurpose (values.Select(v => (IPurpose) new PurposeMedicalDevicePurpose (v))); }
            public static implicit operator OneOrManyPurpose (Thing value) { return new OneOrManyPurpose (new PurposeThing (value)); }
            public static implicit operator OneOrManyPurpose (Thing[] values) { return new OneOrManyPurpose (values.Select(v => (IPurpose) new PurposeThing (v))); }
            public static implicit operator OneOrManyPurpose (List<Thing> values) { return new OneOrManyPurpose (values.Select(v => (IPurpose) new PurposeThing (v))); }
        }
        public struct PurposeMedicalDevicePurpose : IPurpose<MedicalDevicePurpose>
        {
            object IValue.Value => this.Value;
            public MedicalDevicePurpose Value { get; }
            public PurposeMedicalDevicePurpose (MedicalDevicePurpose value) { Value = value; }
            public static implicit operator PurposeMedicalDevicePurpose (MedicalDevicePurpose value) { return new PurposeMedicalDevicePurpose (value); }
        }
        public struct PurposeThing : IPurpose<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public PurposeThing (Thing value) { Value = value; }
            public static implicit operator PurposeThing (Thing value) { return new PurposeThing (value); }
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
        public override string Type => "MedicalDevice";

        /// <summary>
        /// A possible complication and/or side effect of this therapy. If it is known that an adverse outcome is serious (resulting in death, disability, or permanent damage; requiring hospitalization; or is otherwise life-threatening or requires immediate medical attention), tag it as a seriouseAdverseOutcome instead.
        /// </summary>
        [DataMember(Name = "adverseOutcome", Order = 206)]
        public OneOrManyAdverseOutcome AdverseOutcome { get; set; }

        /// <summary>
        /// A contraindication for this therapy.
        /// </summary>
        [DataMember(Name = "contraindication", Order = 207)]
        public OneOrManyContraindication Contraindication { get; set; }

        /// <summary>
        /// A factor that indicates use of this therapy for treatment and/or prevention of a condition, symptom, etc. For therapies such as drugs, indications can include both officially-approved indications as well as off-label uses. These can be distinguished by using the ApprovedIndication subtype of MedicalIndication.
        /// </summary>
        [DataMember(Name = "indication", Order = 208)]
        public OneOrManyIndication Indication { get; set; }

        /// <summary>
        /// A description of the postoperative procedures, care, and/or followups for this device.
        /// </summary>
        [DataMember(Name = "postOp", Order = 209)]
        public OneOrManyPostOp PostOp { get; set; }

        /// <summary>
        /// A description of the workup, testing, and other preparations required before implanting this device.
        /// </summary>
        [DataMember(Name = "preOp", Order = 210)]
        public OneOrManyPreOp PreOp { get; set; }

        /// <summary>
        /// A description of the procedure involved in setting up, using, and/or installing the device.
        /// </summary>
        [DataMember(Name = "procedure", Order = 211)]
        public OneOrManyProcedure Procedure { get; set; }

        /// <summary>
        /// A goal towards an action is taken. Can be concrete or abstract.
        /// </summary>
        [DataMember(Name = "purpose", Order = 212)]
        public OneOrManyPurpose Purpose { get; set; }

        /// <summary>
        /// A possible serious complication and/or serious side effect of this therapy. Serious adverse outcomes include those that are life-threatening; result in death, disability, or permanent damage; require hospitalization or prolong existing hospitalization; cause congenital anomalies or birth defects; or jeopardize the patient and may require medical or surgical intervention to prevent one of the outcomes in this definition.
        /// </summary>
        [DataMember(Name = "seriousAdverseOutcome", Order = 213)]
        public OneOrManySeriousAdverseOutcome SeriousAdverseOutcome { get; set; }
    }
}
