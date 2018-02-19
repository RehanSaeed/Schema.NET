using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// Anatomical features that can be observed by sight (without dissection), including the form and proportions of the human body as well as surface landmarks that correspond to deeper subcutaneous structures. Superficial anatomy plays an important role in sports medicine, phlebotomy, and other medical specialties as underlying anatomical structures can be identified through surface palpation. For example, during back surgery, superficial anatomy can be used to palpate and count vertebrae to find the site of incision. Or in phlebotomy, superficial anatomy can be used to locate an underlying vein; for example, the median cubital vein can be located by palpating the borders of the cubital fossa (such as the epicondyles of the humerus) and then looking for the superficial signs of the vein, such as size, prominence, ability to refill after depression, and feel of surrounding tissue support. As another example, in a subluxation (dislocation) of the glenohumeral joint, the bony structure becomes pronounced with the deltoid muscle failing to cover the glenohumeral joint allowing the edges of the scapula to be superficially visible. Here, the superficial anatomy is the visible edges of the scapula, implying the underlying dislocation of the joint (the related anatomical structure).
    /// </summary>
    [DataContract]
    public partial class SuperficialAnatomy : MedicalEntity
    {
        public interface IRelatedAnatomy : IWrapper { }
        public interface IRelatedAnatomy<T> : IRelatedAnatomy { new T Data { get; set; } }
        public class RelatedAnatomyAnatomicalStructure : IRelatedAnatomy<AnatomicalStructure>
        {
            object IWrapper.Data { get { return Data; } set { Data = (AnatomicalStructure) value; } }
            public virtual AnatomicalStructure Data { get; set; }
            public RelatedAnatomyAnatomicalStructure () { }
            public RelatedAnatomyAnatomicalStructure (AnatomicalStructure data) { Data = data; }
            public static implicit operator RelatedAnatomyAnatomicalStructure (AnatomicalStructure data) { return new RelatedAnatomyAnatomicalStructure (data); }
        }

        public class RelatedAnatomyAnatomicalSystem : IRelatedAnatomy<AnatomicalSystem>
        {
            object IWrapper.Data { get { return Data; } set { Data = (AnatomicalSystem) value; } }
            public virtual AnatomicalSystem Data { get; set; }
            public RelatedAnatomyAnatomicalSystem () { }
            public RelatedAnatomyAnatomicalSystem (AnatomicalSystem data) { Data = data; }
            public static implicit operator RelatedAnatomyAnatomicalSystem (AnatomicalSystem data) { return new RelatedAnatomyAnatomicalSystem (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SuperficialAnatomy";

        /// <summary>
        /// If applicable, a description of the pathophysiology associated with the anatomical system, including potential abnormal changes in the mechanical, physical, and biochemical functions of the system.
        /// </summary>
        [DataMember(Name = "associatedPathophysiology", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AssociatedPathophysiology { get; set; } 

        /// <summary>
        /// Anatomical systems or structures that relate to the superficial anatomy.
        /// </summary>
        [DataMember(Name = "relatedAnatomy", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IRelatedAnatomy>? RelatedAnatomy { get; set; } //AnatomicalStructure, AnatomicalSystem

        /// <summary>
        /// A medical condition associated with this anatomy.
        /// </summary>
        [DataMember(Name = "relatedCondition", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalCondition>? RelatedCondition { get; set; } 

        /// <summary>
        /// A medical therapy related to this anatomy.
        /// </summary>
        [DataMember(Name = "relatedTherapy", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalTherapy>? RelatedTherapy { get; set; } 

        /// <summary>
        /// The significance associated with the superficial anatomy; as an example, how characteristics of the superficial anatomy can suggest underlying medical conditions or courses of treatment.
        /// </summary>
        [DataMember(Name = "significance", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Significance { get; set; } 
    }
}
