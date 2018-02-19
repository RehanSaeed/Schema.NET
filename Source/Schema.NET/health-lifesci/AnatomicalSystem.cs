using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// An anatomical system is a group of anatomical structures that work together to perform a certain task. Anatomical systems, such as organ systems, are one organizing principle of anatomy, and can includes circulatory, digestive, endocrine, integumentary, immune, lymphatic, muscular, nervous, reproductive, respiratory, skeletal, urinary, vestibular, and other systems.
    /// </summary>
    [DataContract]
    public partial class AnatomicalSystem : MedicalEntity
    {
        public interface IComprisedOf : IWrapper { }
        public interface IComprisedOf<T> : IComprisedOf { new T Data { get; set; } }
        public class ComprisedOfAnatomicalStructure : IComprisedOf<AnatomicalStructure>
        {
            object IWrapper.Data { get { return Data; } set { Data = (AnatomicalStructure) value; } }
            public virtual AnatomicalStructure Data { get; set; }
            public ComprisedOfAnatomicalStructure () { }
            public ComprisedOfAnatomicalStructure (AnatomicalStructure data) { Data = data; }
            public static implicit operator ComprisedOfAnatomicalStructure (AnatomicalStructure data) { return new ComprisedOfAnatomicalStructure (data); }
        }

        public class ComprisedOfAnatomicalSystem : IComprisedOf<AnatomicalSystem>
        {
            object IWrapper.Data { get { return Data; } set { Data = (AnatomicalSystem) value; } }
            public virtual AnatomicalSystem Data { get; set; }
            public ComprisedOfAnatomicalSystem () { }
            public ComprisedOfAnatomicalSystem (AnatomicalSystem data) { Data = data; }
            public static implicit operator ComprisedOfAnatomicalSystem (AnatomicalSystem data) { return new ComprisedOfAnatomicalSystem (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AnatomicalSystem";

        /// <summary>
        /// If applicable, a description of the pathophysiology associated with the anatomical system, including potential abnormal changes in the mechanical, physical, and biochemical functions of the system.
        /// </summary>
        [DataMember(Name = "associatedPathophysiology", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AssociatedPathophysiology { get; set; } 

        /// <summary>
        /// Specifying something physically contained by something else. Typically used here for the underlying anatomical structures, such as organs, that comprise the anatomical system.
        /// </summary>
        [DataMember(Name = "comprisedOf", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IComprisedOf>? ComprisedOf { get; set; } //AnatomicalStructure, AnatomicalSystem

        /// <summary>
        /// A medical condition associated with this anatomy.
        /// </summary>
        [DataMember(Name = "relatedCondition", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalCondition>? RelatedCondition { get; set; } 

        /// <summary>
        /// Related anatomical structure(s) that are not part of the system but relate or connect to it, such as vascular bundles associated with an organ system.
        /// </summary>
        [DataMember(Name = "relatedStructure", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AnatomicalStructure>? RelatedStructure { get; set; } 

        /// <summary>
        /// A medical therapy related to this anatomy.
        /// </summary>
        [DataMember(Name = "relatedTherapy", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalTherapy>? RelatedTherapy { get; set; } 
    }
}
