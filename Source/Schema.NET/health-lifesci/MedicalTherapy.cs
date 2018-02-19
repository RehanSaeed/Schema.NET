using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// Any medical intervention designed to prevent, treat, and cure human diseases and medical conditions, including both curative and palliative therapies. Medical therapies are typically processes of care relying upon pharmacotherapy, behavioral therapy, supportive therapy (with fluid or nutrition for example), or detoxification (e.g. hemodialysis) aimed at improving or preventing a health condition.
    /// </summary>
    [DataContract]
    public partial class MedicalTherapy : TherapeuticProcedure
    {
        public interface IContraindication : IWrapper { }
        public interface IContraindication<T> : IContraindication { new T Data { get; set; } }
        public class ContraindicationMedicalContraindication : IContraindication<MedicalContraindication>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MedicalContraindication) value; } }
            public virtual MedicalContraindication Data { get; set; }
            public ContraindicationMedicalContraindication () { }
            public ContraindicationMedicalContraindication (MedicalContraindication data) { Data = data; }
            public static implicit operator ContraindicationMedicalContraindication (MedicalContraindication data) { return new ContraindicationMedicalContraindication (data); }
        }

        public class Contraindicationstring : IContraindication<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Contraindicationstring () { }
            public Contraindicationstring (string data) { Data = data; }
            public static implicit operator Contraindicationstring (string data) { return new Contraindicationstring (data); }
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IContraindication>? Contraindication { get; set; } //MedicalContraindication, string

        /// <summary>
        /// A therapy that duplicates or overlaps this one.
        /// </summary>
        [DataMember(Name = "duplicateTherapy", Order = 407)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalTherapy>? DuplicateTherapy { get; set; } 

        /// <summary>
        /// A possible serious complication and/or serious side effect of this therapy. Serious adverse outcomes include those that are life-threatening; result in death, disability, or permanent damage; require hospitalization or prolong existing hospitalization; cause congenital anomalies or birth defects; or jeopardize the patient and may require medical or surgical intervention to prevent one of the outcomes in this definition.
        /// </summary>
        [DataMember(Name = "seriousAdverseOutcome", Order = 408)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalEntity>? SeriousAdverseOutcome { get; set; } 
    }
}
