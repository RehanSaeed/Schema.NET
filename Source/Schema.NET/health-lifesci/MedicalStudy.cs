namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A medical study is an umbrella type covering all kinds of research studies relating to human medicine or health, including observational studies and interventional trials and registries, randomized, controlled or not. When the specific type of study is known, use one of the extensions of this type, such as MedicalTrial or MedicalObservationalStudy. Also, note that this type should be used to mark up data that describes the study itself; to tag an article that publishes the results of a study, use MedicalScholarlyArticle. Note: use the code property of MedicalEntity to store study IDs, e.g. clinicaltrials.gov ID.
    /// </summary>
    [DataContract]
    public partial class MedicalStudy : MedicalEntity
    {
        public interface IHealthCondition : IValue {}
        public interface IHealthCondition<T> : IHealthCondition { new T Value { get; } }
        public class OneOrManyHealthCondition : OneOrMany<IHealthCondition>
        {
            public OneOrManyHealthCondition(IHealthCondition item) : base(item) { }
            public OneOrManyHealthCondition(IEnumerable<IHealthCondition> items) : base(items) { }
            public static implicit operator OneOrManyHealthCondition (MedicalCondition value) { return new OneOrManyHealthCondition (new HealthConditionMedicalCondition (value)); }
            public static implicit operator OneOrManyHealthCondition (MedicalCondition[] values) { return new OneOrManyHealthCondition (values.Select(v => (IHealthCondition) new HealthConditionMedicalCondition (v))); }
            public static implicit operator OneOrManyHealthCondition (List<MedicalCondition> values) { return new OneOrManyHealthCondition (values.Select(v => (IHealthCondition) new HealthConditionMedicalCondition (v))); }
        }
        public struct HealthConditionMedicalCondition : IHealthCondition<MedicalCondition>
        {
            object IValue.Value => this.Value;
            public MedicalCondition Value { get; }
            public HealthConditionMedicalCondition (MedicalCondition value) { Value = value; }
            public static implicit operator HealthConditionMedicalCondition (MedicalCondition value) { return new HealthConditionMedicalCondition (value); }
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

        public interface IPopulation : IValue {}
        public interface IPopulation<T> : IPopulation { new T Value { get; } }
        public class OneOrManyPopulation : OneOrMany<IPopulation>
        {
            public OneOrManyPopulation(IPopulation item) : base(item) { }
            public OneOrManyPopulation(IEnumerable<IPopulation> items) : base(items) { }
            public static implicit operator OneOrManyPopulation (string value) { return new OneOrManyPopulation (new Populationstring (value)); }
            public static implicit operator OneOrManyPopulation (string[] values) { return new OneOrManyPopulation (values.Select(v => (IPopulation) new Populationstring (v))); }
            public static implicit operator OneOrManyPopulation (List<string> values) { return new OneOrManyPopulation (values.Select(v => (IPopulation) new Populationstring (v))); }
        }
        public struct Populationstring : IPopulation<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Populationstring (string value) { Value = value; }
            public static implicit operator Populationstring (string value) { return new Populationstring (value); }
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

        public interface IStudyLocation : IValue {}
        public interface IStudyLocation<T> : IStudyLocation { new T Value { get; } }
        public class OneOrManyStudyLocation : OneOrMany<IStudyLocation>
        {
            public OneOrManyStudyLocation(IStudyLocation item) : base(item) { }
            public OneOrManyStudyLocation(IEnumerable<IStudyLocation> items) : base(items) { }
            public static implicit operator OneOrManyStudyLocation (AdministrativeArea value) { return new OneOrManyStudyLocation (new StudyLocationAdministrativeArea (value)); }
            public static implicit operator OneOrManyStudyLocation (AdministrativeArea[] values) { return new OneOrManyStudyLocation (values.Select(v => (IStudyLocation) new StudyLocationAdministrativeArea (v))); }
            public static implicit operator OneOrManyStudyLocation (List<AdministrativeArea> values) { return new OneOrManyStudyLocation (values.Select(v => (IStudyLocation) new StudyLocationAdministrativeArea (v))); }
        }
        public struct StudyLocationAdministrativeArea : IStudyLocation<AdministrativeArea>
        {
            object IValue.Value => this.Value;
            public AdministrativeArea Value { get; }
            public StudyLocationAdministrativeArea (AdministrativeArea value) { Value = value; }
            public static implicit operator StudyLocationAdministrativeArea (AdministrativeArea value) { return new StudyLocationAdministrativeArea (value); }
        }

        public interface IStudySubject : IValue {}
        public interface IStudySubject<T> : IStudySubject { new T Value { get; } }
        public class OneOrManyStudySubject : OneOrMany<IStudySubject>
        {
            public OneOrManyStudySubject(IStudySubject item) : base(item) { }
            public OneOrManyStudySubject(IEnumerable<IStudySubject> items) : base(items) { }
            public static implicit operator OneOrManyStudySubject (MedicalEntity value) { return new OneOrManyStudySubject (new StudySubjectMedicalEntity (value)); }
            public static implicit operator OneOrManyStudySubject (MedicalEntity[] values) { return new OneOrManyStudySubject (values.Select(v => (IStudySubject) new StudySubjectMedicalEntity (v))); }
            public static implicit operator OneOrManyStudySubject (List<MedicalEntity> values) { return new OneOrManyStudySubject (values.Select(v => (IStudySubject) new StudySubjectMedicalEntity (v))); }
        }
        public struct StudySubjectMedicalEntity : IStudySubject<MedicalEntity>
        {
            object IValue.Value => this.Value;
            public MedicalEntity Value { get; }
            public StudySubjectMedicalEntity (MedicalEntity value) { Value = value; }
            public static implicit operator StudySubjectMedicalEntity (MedicalEntity value) { return new StudySubjectMedicalEntity (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalStudy";

        /// <summary>
        /// Specifying the health condition(s) of a patient, medical study, or other target audience.
        /// </summary>
        [DataMember(Name = "healthCondition", Order = 206)]
        public OneOrManyHealthCondition HealthCondition { get; set; }

        /// <summary>
        /// Expected or actual outcomes of the study.
        /// </summary>
        [DataMember(Name = "outcome", Order = 207)]
        public OneOrManyOutcome Outcome { get; set; }

        /// <summary>
        /// Any characteristics of the population used in the study, e.g. 'males under 65'.
        /// </summary>
        [DataMember(Name = "population", Order = 208)]
        public OneOrManyPopulation Population { get; set; }

        /// <summary>
        /// The status of the study (enumerated).
        /// </summary>
        [DataMember(Name = "status", Order = 209)]
        public OneOrManyStatus Status { get; set; }

        /// <summary>
        /// The location in which the study is taking/took place.
        /// </summary>
        [DataMember(Name = "studyLocation", Order = 210)]
        public OneOrManyStudyLocation StudyLocation { get; set; }

        /// <summary>
        /// A subject of the study, i.e. one of the medical conditions, therapies, devices, drugs, etc. investigated by the study.
        /// </summary>
        [DataMember(Name = "studySubject", Order = 211)]
        public OneOrManyStudySubject StudySubject { get; set; }
    }
}
