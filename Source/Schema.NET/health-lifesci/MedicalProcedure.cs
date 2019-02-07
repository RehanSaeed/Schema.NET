namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A process of care used in either a diagnostic, therapeutic, preventive or palliative capacity that relies on invasive (surgical), non-invasive, or other techniques.
    /// </summary>
    [DataContract]
    public partial class MedicalProcedure : MedicalEntity
    {
        public interface IBodyLocation : IValue {}
        public interface IBodyLocation<T> : IBodyLocation { new T Value { get; } }
        public class OneOrManyBodyLocation : OneOrMany<IBodyLocation>
        {
            public OneOrManyBodyLocation(IBodyLocation item) : base(item) { }
            public OneOrManyBodyLocation(IEnumerable<IBodyLocation> items) : base(items) { }
            public static implicit operator OneOrManyBodyLocation (string value) { return new OneOrManyBodyLocation (new BodyLocationstring (value)); }
            public static implicit operator OneOrManyBodyLocation (string[] values) { return new OneOrManyBodyLocation (values.Select(v => (IBodyLocation) new BodyLocationstring (v))); }
            public static implicit operator OneOrManyBodyLocation (List<string> values) { return new OneOrManyBodyLocation (values.Select(v => (IBodyLocation) new BodyLocationstring (v))); }
        }
        public struct BodyLocationstring : IBodyLocation<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public BodyLocationstring (string value) { Value = value; }
            public static implicit operator BodyLocationstring (string value) { return new BodyLocationstring (value); }
        }

        public interface IFollowup : IValue {}
        public interface IFollowup<T> : IFollowup { new T Value { get; } }
        public class OneOrManyFollowup : OneOrMany<IFollowup>
        {
            public OneOrManyFollowup(IFollowup item) : base(item) { }
            public OneOrManyFollowup(IEnumerable<IFollowup> items) : base(items) { }
            public static implicit operator OneOrManyFollowup (string value) { return new OneOrManyFollowup (new Followupstring (value)); }
            public static implicit operator OneOrManyFollowup (string[] values) { return new OneOrManyFollowup (values.Select(v => (IFollowup) new Followupstring (v))); }
            public static implicit operator OneOrManyFollowup (List<string> values) { return new OneOrManyFollowup (values.Select(v => (IFollowup) new Followupstring (v))); }
        }
        public struct Followupstring : IFollowup<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Followupstring (string value) { Value = value; }
            public static implicit operator Followupstring (string value) { return new Followupstring (value); }
        }

        public interface IHowPerformed : IValue {}
        public interface IHowPerformed<T> : IHowPerformed { new T Value { get; } }
        public class OneOrManyHowPerformed : OneOrMany<IHowPerformed>
        {
            public OneOrManyHowPerformed(IHowPerformed item) : base(item) { }
            public OneOrManyHowPerformed(IEnumerable<IHowPerformed> items) : base(items) { }
            public static implicit operator OneOrManyHowPerformed (string value) { return new OneOrManyHowPerformed (new HowPerformedstring (value)); }
            public static implicit operator OneOrManyHowPerformed (string[] values) { return new OneOrManyHowPerformed (values.Select(v => (IHowPerformed) new HowPerformedstring (v))); }
            public static implicit operator OneOrManyHowPerformed (List<string> values) { return new OneOrManyHowPerformed (values.Select(v => (IHowPerformed) new HowPerformedstring (v))); }
        }
        public struct HowPerformedstring : IHowPerformed<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public HowPerformedstring (string value) { Value = value; }
            public static implicit operator HowPerformedstring (string value) { return new HowPerformedstring (value); }
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

        public interface IOutcome : IValue {}
        public interface IOutcome<T> : IOutcome { new T Value { get; } }
        public class OneOrManyOutcome : OneOrMany<IOutcome>
        {
            public OneOrManyOutcome(IOutcome item) : base(item) { }
            public OneOrManyOutcome(IEnumerable<IOutcome> items) : base(items) { }
            public static implicit operator OneOrManyOutcome (MedicalEntity value) { return new OneOrManyOutcome (new OutcomeMedicalEntity (value)); }
            public static implicit operator OneOrManyOutcome (MedicalEntity[] values) { return new OneOrManyOutcome (values.Select(v => (IOutcome) new OutcomeMedicalEntity (v))); }
            public static implicit operator OneOrManyOutcome (List<MedicalEntity> values) { return new OneOrManyOutcome (values.Select(v => (IOutcome) new OutcomeMedicalEntity (v))); }
            public static implicit operator OneOrManyOutcome (string value) { return new OneOrManyOutcome (new Outcomestring (value)); }
            public static implicit operator OneOrManyOutcome (string[] values) { return new OneOrManyOutcome (values.Select(v => (IOutcome) new Outcomestring (v))); }
            public static implicit operator OneOrManyOutcome (List<string> values) { return new OneOrManyOutcome (values.Select(v => (IOutcome) new Outcomestring (v))); }
        }
        public struct OutcomeMedicalEntity : IOutcome<MedicalEntity>
        {
            object IValue.Value => this.Value;
            public MedicalEntity Value { get; }
            public OutcomeMedicalEntity (MedicalEntity value) { Value = value; }
            public static implicit operator OutcomeMedicalEntity (MedicalEntity value) { return new OutcomeMedicalEntity (value); }
        }
        public struct Outcomestring : IOutcome<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Outcomestring (string value) { Value = value; }
            public static implicit operator Outcomestring (string value) { return new Outcomestring (value); }
        }

        public interface IPreparation : IValue {}
        public interface IPreparation<T> : IPreparation { new T Value { get; } }
        public class OneOrManyPreparation : OneOrMany<IPreparation>
        {
            public OneOrManyPreparation(IPreparation item) : base(item) { }
            public OneOrManyPreparation(IEnumerable<IPreparation> items) : base(items) { }
            public static implicit operator OneOrManyPreparation (MedicalEntity value) { return new OneOrManyPreparation (new PreparationMedicalEntity (value)); }
            public static implicit operator OneOrManyPreparation (MedicalEntity[] values) { return new OneOrManyPreparation (values.Select(v => (IPreparation) new PreparationMedicalEntity (v))); }
            public static implicit operator OneOrManyPreparation (List<MedicalEntity> values) { return new OneOrManyPreparation (values.Select(v => (IPreparation) new PreparationMedicalEntity (v))); }
            public static implicit operator OneOrManyPreparation (string value) { return new OneOrManyPreparation (new Preparationstring (value)); }
            public static implicit operator OneOrManyPreparation (string[] values) { return new OneOrManyPreparation (values.Select(v => (IPreparation) new Preparationstring (v))); }
            public static implicit operator OneOrManyPreparation (List<string> values) { return new OneOrManyPreparation (values.Select(v => (IPreparation) new Preparationstring (v))); }
        }
        public struct PreparationMedicalEntity : IPreparation<MedicalEntity>
        {
            object IValue.Value => this.Value;
            public MedicalEntity Value { get; }
            public PreparationMedicalEntity (MedicalEntity value) { Value = value; }
            public static implicit operator PreparationMedicalEntity (MedicalEntity value) { return new PreparationMedicalEntity (value); }
        }
        public struct Preparationstring : IPreparation<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Preparationstring (string value) { Value = value; }
            public static implicit operator Preparationstring (string value) { return new Preparationstring (value); }
        }

        public interface IProcedureType : IValue {}
        public interface IProcedureType<T> : IProcedureType { new T Value { get; } }
        public class OneOrManyProcedureType : OneOrMany<IProcedureType>
        {
            public OneOrManyProcedureType(IProcedureType item) : base(item) { }
            public OneOrManyProcedureType(IEnumerable<IProcedureType> items) : base(items) { }
            public static implicit operator OneOrManyProcedureType (MedicalProcedureType value) { return new OneOrManyProcedureType (new ProcedureTypeMedicalProcedureType (value)); }
            public static implicit operator OneOrManyProcedureType (MedicalProcedureType[] values) { return new OneOrManyProcedureType (values.Select(v => (IProcedureType) new ProcedureTypeMedicalProcedureType (v))); }
            public static implicit operator OneOrManyProcedureType (List<MedicalProcedureType> values) { return new OneOrManyProcedureType (values.Select(v => (IProcedureType) new ProcedureTypeMedicalProcedureType (v))); }
        }
        public struct ProcedureTypeMedicalProcedureType : IProcedureType<MedicalProcedureType>
        {
            object IValue.Value => this.Value;
            public MedicalProcedureType Value { get; }
            public ProcedureTypeMedicalProcedureType (MedicalProcedureType value) { Value = value; }
            public static implicit operator ProcedureTypeMedicalProcedureType (MedicalProcedureType value) { return new ProcedureTypeMedicalProcedureType (value); }
        }

        public interface IStatus : IValue {}
        public interface IStatus<T> : IStatus { new T Value { get; } }
        public class OneOrManyStatus : OneOrMany<IStatus>
        {
            public OneOrManyStatus(IStatus item) : base(item) { }
            public OneOrManyStatus(IEnumerable<IStatus> items) : base(items) { }
            public static implicit operator OneOrManyStatus (EventStatusType value) { return new OneOrManyStatus (new StatusEventStatusType (value)); }
            public static implicit operator OneOrManyStatus (EventStatusType[] values) { return new OneOrManyStatus (values.Select(v => (IStatus) new StatusEventStatusType (v))); }
            public static implicit operator OneOrManyStatus (List<EventStatusType> values) { return new OneOrManyStatus (values.Select(v => (IStatus) new StatusEventStatusType (v))); }
            public static implicit operator OneOrManyStatus (MedicalStudyStatus value) { return new OneOrManyStatus (new StatusMedicalStudyStatus (value)); }
            public static implicit operator OneOrManyStatus (MedicalStudyStatus[] values) { return new OneOrManyStatus (values.Select(v => (IStatus) new StatusMedicalStudyStatus (v))); }
            public static implicit operator OneOrManyStatus (List<MedicalStudyStatus> values) { return new OneOrManyStatus (values.Select(v => (IStatus) new StatusMedicalStudyStatus (v))); }
            public static implicit operator OneOrManyStatus (string value) { return new OneOrManyStatus (new Statusstring (value)); }
            public static implicit operator OneOrManyStatus (string[] values) { return new OneOrManyStatus (values.Select(v => (IStatus) new Statusstring (v))); }
            public static implicit operator OneOrManyStatus (List<string> values) { return new OneOrManyStatus (values.Select(v => (IStatus) new Statusstring (v))); }
        }
        public struct StatusEventStatusType : IStatus<EventStatusType>
        {
            object IValue.Value => this.Value;
            public EventStatusType Value { get; }
            public StatusEventStatusType (EventStatusType value) { Value = value; }
            public static implicit operator StatusEventStatusType (EventStatusType value) { return new StatusEventStatusType (value); }
        }
        public struct StatusMedicalStudyStatus : IStatus<MedicalStudyStatus>
        {
            object IValue.Value => this.Value;
            public MedicalStudyStatus Value { get; }
            public StatusMedicalStudyStatus (MedicalStudyStatus value) { Value = value; }
            public static implicit operator StatusMedicalStudyStatus (MedicalStudyStatus value) { return new StatusMedicalStudyStatus (value); }
        }
        public struct Statusstring : IStatus<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Statusstring (string value) { Value = value; }
            public static implicit operator Statusstring (string value) { return new Statusstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalProcedure";

        /// <summary>
        /// Location in the body of the anatomical structure.
        /// </summary>
        [DataMember(Name = "bodyLocation", Order = 206)]
        public OneOrManyBodyLocation BodyLocation { get; set; }

        /// <summary>
        /// Typical or recommended followup care after the procedure is performed.
        /// </summary>
        [DataMember(Name = "followup", Order = 207)]
        public OneOrManyFollowup Followup { get; set; }

        /// <summary>
        /// How the procedure is performed.
        /// </summary>
        [DataMember(Name = "howPerformed", Order = 208)]
        public OneOrManyHowPerformed HowPerformed { get; set; }

        /// <summary>
        /// A factor that indicates use of this therapy for treatment and/or prevention of a condition, symptom, etc. For therapies such as drugs, indications can include both officially-approved indications as well as off-label uses. These can be distinguished by using the ApprovedIndication subtype of MedicalIndication.
        /// </summary>
        [DataMember(Name = "indication", Order = 209)]
        public virtual OneOrManyIndication Indication { get; set; }

        /// <summary>
        /// Expected or actual outcomes of the study.
        /// </summary>
        [DataMember(Name = "outcome", Order = 210)]
        public OneOrManyOutcome Outcome { get; set; }

        /// <summary>
        /// Typical preparation that a patient must undergo before having the procedure performed.
        /// </summary>
        [DataMember(Name = "preparation", Order = 211)]
        public OneOrManyPreparation Preparation { get; set; }

        /// <summary>
        /// The type of procedure, for example Surgical, Noninvasive, or Percutaneous.
        /// </summary>
        [DataMember(Name = "procedureType", Order = 212)]
        public OneOrManyProcedureType ProcedureType { get; set; }

        /// <summary>
        /// The status of the study (enumerated).
        /// </summary>
        [DataMember(Name = "status", Order = 213)]
        public OneOrManyStatus Status { get; set; }
    }
}
