using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A process of care used in either a diagnostic, therapeutic, preventive or palliative capacity that relies on invasive (surgical), non-invasive, or other techniques.
    /// </summary>
    [DataContract]
    public partial class MedicalProcedure : MedicalEntity
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


        public interface IPreparation : IWrapper { }
        public interface IPreparation<T> : IPreparation { new T Data { get; set; } }
        public class PreparationMedicalEntity : IPreparation<MedicalEntity>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MedicalEntity) value; } }
            public virtual MedicalEntity Data { get; set; }
            public PreparationMedicalEntity () { }
            public PreparationMedicalEntity (MedicalEntity data) { Data = data; }
            public static implicit operator PreparationMedicalEntity (MedicalEntity data) { return new PreparationMedicalEntity (data); }
        }

        public class Preparationstring : IPreparation<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Preparationstring () { }
            public Preparationstring (string data) { Data = data; }
            public static implicit operator Preparationstring (string data) { return new Preparationstring (data); }
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
        public override string Type => "MedicalProcedure";

        /// <summary>
        /// Location in the body of the anatomical structure.
        /// </summary>
        [DataMember(Name = "bodyLocation", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? BodyLocation { get; set; } 

        /// <summary>
        /// Typical or recommended followup care after the procedure is performed.
        /// </summary>
        [DataMember(Name = "followup", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Followup { get; set; } 

        /// <summary>
        /// How the procedure is performed.
        /// </summary>
        [DataMember(Name = "howPerformed", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? HowPerformed { get; set; } 

        /// <summary>
        /// A factor that indicates use of this therapy for treatment and/or prevention of a condition, symptom, etc. For therapies such as drugs, indications can include both officially-approved indications as well as off-label uses. These can be distinguished by using the ApprovedIndication subtype of MedicalIndication.
        /// </summary>
        [DataMember(Name = "indication", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<MedicalIndication>? Indication { get; set; } 

        /// <summary>
        /// Expected or actual outcomes of the study.
        /// </summary>
        [DataMember(Name = "outcome", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IOutcome>? Outcome { get; set; } //MedicalEntity, string

        /// <summary>
        /// Typical preparation that a patient must undergo before having the procedure performed.
        /// </summary>
        [DataMember(Name = "preparation", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPreparation>? Preparation { get; set; } //MedicalEntity, string

        /// <summary>
        /// The type of procedure, for example Surgical, Noninvasive, or Percutaneous.
        /// </summary>
        [DataMember(Name = "procedureType", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalProcedureType>? ProcedureType { get; set; } 

        /// <summary>
        /// The status of the study (enumerated).
        /// </summary>
        [DataMember(Name = "status", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IStatus>? Status { get; set; } //EventStatusType?, MedicalStudyStatus?, string
    }
}
