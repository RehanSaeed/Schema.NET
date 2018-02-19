using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A medical study is an umbrella type covering all kinds of research studies relating to human medicine or health, including observational studies and interventional trials and registries, randomized, controlled or not. When the specific type of study is known, use one of the extensions of this type, such as MedicalTrial or MedicalObservationalStudy. Also, note that this type should be used to mark up data that describes the study itself; to tag an article that publishes the results of a study, use MedicalScholarlyArticle. Note: use the code property of MedicalEntity to store study IDs, e.g. clinicaltrials.gov ID.
    /// </summary>
    [DataContract]
    public partial class MedicalStudy : MedicalEntity
    {
        public interface IOutcome : IWrapper { }
        public interface IOutcome<T> : IOutcome { new T Data { get; set; } }
        public class OutcomeMedicalEntity : IOutcome<MedicalEntity>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MedicalEntity) value; } }
            public virtual MedicalEntity Data { get; set; }
            public OutcomeMedicalEntity () { }
            public OutcomeMedicalEntity (MedicalEntity data) { Data = data; }
            public static implicit operator OutcomeMedicalEntity (MedicalEntity data) { return new OutcomeMedicalEntity (data); }
        }

        public class Outcomestring : IOutcome<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Outcomestring () { }
            public Outcomestring (string data) { Data = data; }
            public static implicit operator Outcomestring (string data) { return new Outcomestring (data); }
        }


        public interface IStatus : IWrapper { }
        public interface IStatus<T> : IStatus { new T Data { get; set; } }
        public class StatusEventStatusType : IStatus<EventStatusType>
        {
            object IWrapper.Data { get { return Data; } set { Data = (EventStatusType) value; } }
            public virtual EventStatusType Data { get; set; }
            public StatusEventStatusType () { }
            public StatusEventStatusType (EventStatusType data) { Data = data; }
            public static implicit operator StatusEventStatusType (EventStatusType data) { return new StatusEventStatusType (data); }
        }

        public class StatusMedicalStudyStatus : IStatus<MedicalStudyStatus>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MedicalStudyStatus) value; } }
            public virtual MedicalStudyStatus Data { get; set; }
            public StatusMedicalStudyStatus () { }
            public StatusMedicalStudyStatus (MedicalStudyStatus data) { Data = data; }
            public static implicit operator StatusMedicalStudyStatus (MedicalStudyStatus data) { return new StatusMedicalStudyStatus (data); }
        }

        public class Statusstring : IStatus<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Statusstring () { }
            public Statusstring (string data) { Data = data; }
            public static implicit operator Statusstring (string data) { return new Statusstring (data); }
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalCondition>? HealthCondition { get; set; } 

        /// <summary>
        /// Expected or actual outcomes of the study.
        /// </summary>
        [DataMember(Name = "outcome", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IOutcome>? Outcome { get; set; } //MedicalEntity, string

        /// <summary>
        /// Any characteristics of the population used in the study, e.g. 'males under 65'.
        /// </summary>
        [DataMember(Name = "population", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Population { get; set; } 

        /// <summary>
        /// The status of the study (enumerated).
        /// </summary>
        [DataMember(Name = "status", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IStatus>? Status { get; set; } //EventStatusType?, MedicalStudyStatus?, string

        /// <summary>
        /// The location in which the study is taking/took place.
        /// </summary>
        [DataMember(Name = "studyLocation", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AdministrativeArea>? StudyLocation { get; set; } 

        /// <summary>
        /// A subject of the study, i.e. one of the medical conditions, therapies, devices, drugs, etc. investigated by the study.
        /// </summary>
        [DataMember(Name = "studySubject", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalEntity>? StudySubject { get; set; } 
    }
}
