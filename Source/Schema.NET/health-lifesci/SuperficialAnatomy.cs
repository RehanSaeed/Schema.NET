namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Anatomical features that can be observed by sight (without dissection), including the form and proportions of the human body as well as surface landmarks that correspond to deeper subcutaneous structures. Superficial anatomy plays an important role in sports medicine, phlebotomy, and other medical specialties as underlying anatomical structures can be identified through surface palpation. For example, during back surgery, superficial anatomy can be used to palpate and count vertebrae to find the site of incision. Or in phlebotomy, superficial anatomy can be used to locate an underlying vein; for example, the median cubital vein can be located by palpating the borders of the cubital fossa (such as the epicondyles of the humerus) and then looking for the superficial signs of the vein, such as size, prominence, ability to refill after depression, and feel of surrounding tissue support. As another example, in a subluxation (dislocation) of the glenohumeral joint, the bony structure becomes pronounced with the deltoid muscle failing to cover the glenohumeral joint allowing the edges of the scapula to be superficially visible. Here, the superficial anatomy is the visible edges of the scapula, implying the underlying dislocation of the joint (the related anatomical structure).
    /// </summary>
    [DataContract]
    public partial class SuperficialAnatomy : MedicalEntity
    {
        public interface IAssociatedPathophysiology : IValue {}
        public interface IAssociatedPathophysiology<T> : IAssociatedPathophysiology { new T Value { get; } }
        public class OneOrManyAssociatedPathophysiology : OneOrMany<IAssociatedPathophysiology>
        {
            public OneOrManyAssociatedPathophysiology(IAssociatedPathophysiology item) : base(item) { }
            public OneOrManyAssociatedPathophysiology(IEnumerable<IAssociatedPathophysiology> items) : base(items) { }
            public static implicit operator OneOrManyAssociatedPathophysiology (string value) { return new OneOrManyAssociatedPathophysiology (new AssociatedPathophysiologystring (value)); }
            public static implicit operator OneOrManyAssociatedPathophysiology (string[] values) { return new OneOrManyAssociatedPathophysiology (values.Select(v => (IAssociatedPathophysiology) new AssociatedPathophysiologystring (v))); }
            public static implicit operator OneOrManyAssociatedPathophysiology (List<string> values) { return new OneOrManyAssociatedPathophysiology (values.Select(v => (IAssociatedPathophysiology) new AssociatedPathophysiologystring (v))); }
        }
        public struct AssociatedPathophysiologystring : IAssociatedPathophysiology<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AssociatedPathophysiologystring (string value) { Value = value; }
            public static implicit operator AssociatedPathophysiologystring (string value) { return new AssociatedPathophysiologystring (value); }
        }

        public interface IRelatedAnatomy : IValue {}
        public interface IRelatedAnatomy<T> : IRelatedAnatomy { new T Value { get; } }
        public class OneOrManyRelatedAnatomy : OneOrMany<IRelatedAnatomy>
        {
            public OneOrManyRelatedAnatomy(IRelatedAnatomy item) : base(item) { }
            public OneOrManyRelatedAnatomy(IEnumerable<IRelatedAnatomy> items) : base(items) { }
            public static implicit operator OneOrManyRelatedAnatomy (AnatomicalStructure value) { return new OneOrManyRelatedAnatomy (new RelatedAnatomyAnatomicalStructure (value)); }
            public static implicit operator OneOrManyRelatedAnatomy (AnatomicalStructure[] values) { return new OneOrManyRelatedAnatomy (values.Select(v => (IRelatedAnatomy) new RelatedAnatomyAnatomicalStructure (v))); }
            public static implicit operator OneOrManyRelatedAnatomy (List<AnatomicalStructure> values) { return new OneOrManyRelatedAnatomy (values.Select(v => (IRelatedAnatomy) new RelatedAnatomyAnatomicalStructure (v))); }
            public static implicit operator OneOrManyRelatedAnatomy (AnatomicalSystem value) { return new OneOrManyRelatedAnatomy (new RelatedAnatomyAnatomicalSystem (value)); }
            public static implicit operator OneOrManyRelatedAnatomy (AnatomicalSystem[] values) { return new OneOrManyRelatedAnatomy (values.Select(v => (IRelatedAnatomy) new RelatedAnatomyAnatomicalSystem (v))); }
            public static implicit operator OneOrManyRelatedAnatomy (List<AnatomicalSystem> values) { return new OneOrManyRelatedAnatomy (values.Select(v => (IRelatedAnatomy) new RelatedAnatomyAnatomicalSystem (v))); }
        }
        public struct RelatedAnatomyAnatomicalStructure : IRelatedAnatomy<AnatomicalStructure>
        {
            object IValue.Value => this.Value;
            public AnatomicalStructure Value { get; }
            public RelatedAnatomyAnatomicalStructure (AnatomicalStructure value) { Value = value; }
            public static implicit operator RelatedAnatomyAnatomicalStructure (AnatomicalStructure value) { return new RelatedAnatomyAnatomicalStructure (value); }
        }
        public struct RelatedAnatomyAnatomicalSystem : IRelatedAnatomy<AnatomicalSystem>
        {
            object IValue.Value => this.Value;
            public AnatomicalSystem Value { get; }
            public RelatedAnatomyAnatomicalSystem (AnatomicalSystem value) { Value = value; }
            public static implicit operator RelatedAnatomyAnatomicalSystem (AnatomicalSystem value) { return new RelatedAnatomyAnatomicalSystem (value); }
        }

        public interface IRelatedCondition : IValue {}
        public interface IRelatedCondition<T> : IRelatedCondition { new T Value { get; } }
        public class OneOrManyRelatedCondition : OneOrMany<IRelatedCondition>
        {
            public OneOrManyRelatedCondition(IRelatedCondition item) : base(item) { }
            public OneOrManyRelatedCondition(IEnumerable<IRelatedCondition> items) : base(items) { }
            public static implicit operator OneOrManyRelatedCondition (MedicalCondition value) { return new OneOrManyRelatedCondition (new RelatedConditionMedicalCondition (value)); }
            public static implicit operator OneOrManyRelatedCondition (MedicalCondition[] values) { return new OneOrManyRelatedCondition (values.Select(v => (IRelatedCondition) new RelatedConditionMedicalCondition (v))); }
            public static implicit operator OneOrManyRelatedCondition (List<MedicalCondition> values) { return new OneOrManyRelatedCondition (values.Select(v => (IRelatedCondition) new RelatedConditionMedicalCondition (v))); }
        }
        public struct RelatedConditionMedicalCondition : IRelatedCondition<MedicalCondition>
        {
            object IValue.Value => this.Value;
            public MedicalCondition Value { get; }
            public RelatedConditionMedicalCondition (MedicalCondition value) { Value = value; }
            public static implicit operator RelatedConditionMedicalCondition (MedicalCondition value) { return new RelatedConditionMedicalCondition (value); }
        }

        public interface IRelatedTherapy : IValue {}
        public interface IRelatedTherapy<T> : IRelatedTherapy { new T Value { get; } }
        public class OneOrManyRelatedTherapy : OneOrMany<IRelatedTherapy>
        {
            public OneOrManyRelatedTherapy(IRelatedTherapy item) : base(item) { }
            public OneOrManyRelatedTherapy(IEnumerable<IRelatedTherapy> items) : base(items) { }
            public static implicit operator OneOrManyRelatedTherapy (MedicalTherapy value) { return new OneOrManyRelatedTherapy (new RelatedTherapyMedicalTherapy (value)); }
            public static implicit operator OneOrManyRelatedTherapy (MedicalTherapy[] values) { return new OneOrManyRelatedTherapy (values.Select(v => (IRelatedTherapy) new RelatedTherapyMedicalTherapy (v))); }
            public static implicit operator OneOrManyRelatedTherapy (List<MedicalTherapy> values) { return new OneOrManyRelatedTherapy (values.Select(v => (IRelatedTherapy) new RelatedTherapyMedicalTherapy (v))); }
        }
        public struct RelatedTherapyMedicalTherapy : IRelatedTherapy<MedicalTherapy>
        {
            object IValue.Value => this.Value;
            public MedicalTherapy Value { get; }
            public RelatedTherapyMedicalTherapy (MedicalTherapy value) { Value = value; }
            public static implicit operator RelatedTherapyMedicalTherapy (MedicalTherapy value) { return new RelatedTherapyMedicalTherapy (value); }
        }

        public interface ISignificance : IValue {}
        public interface ISignificance<T> : ISignificance { new T Value { get; } }
        public class OneOrManySignificance : OneOrMany<ISignificance>
        {
            public OneOrManySignificance(ISignificance item) : base(item) { }
            public OneOrManySignificance(IEnumerable<ISignificance> items) : base(items) { }
            public static implicit operator OneOrManySignificance (string value) { return new OneOrManySignificance (new Significancestring (value)); }
            public static implicit operator OneOrManySignificance (string[] values) { return new OneOrManySignificance (values.Select(v => (ISignificance) new Significancestring (v))); }
            public static implicit operator OneOrManySignificance (List<string> values) { return new OneOrManySignificance (values.Select(v => (ISignificance) new Significancestring (v))); }
        }
        public struct Significancestring : ISignificance<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Significancestring (string value) { Value = value; }
            public static implicit operator Significancestring (string value) { return new Significancestring (value); }
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
        public OneOrManyAssociatedPathophysiology AssociatedPathophysiology { get; set; }

        /// <summary>
        /// Anatomical systems or structures that relate to the superficial anatomy.
        /// </summary>
        [DataMember(Name = "relatedAnatomy", Order = 207)]
        public OneOrManyRelatedAnatomy RelatedAnatomy { get; set; }

        /// <summary>
        /// A medical condition associated with this anatomy.
        /// </summary>
        [DataMember(Name = "relatedCondition", Order = 208)]
        public OneOrManyRelatedCondition RelatedCondition { get; set; }

        /// <summary>
        /// A medical therapy related to this anatomy.
        /// </summary>
        [DataMember(Name = "relatedTherapy", Order = 209)]
        public OneOrManyRelatedTherapy RelatedTherapy { get; set; }

        /// <summary>
        /// The significance associated with the superficial anatomy; as an example, how characteristics of the superficial anatomy can suggest underlying medical conditions or courses of treatment.
        /// </summary>
        [DataMember(Name = "significance", Order = 210)]
        public OneOrManySignificance Significance { get; set; }
    }
}
