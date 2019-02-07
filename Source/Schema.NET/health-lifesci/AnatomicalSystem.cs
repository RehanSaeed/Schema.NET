namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An anatomical system is a group of anatomical structures that work together to perform a certain task. Anatomical systems, such as organ systems, are one organizing principle of anatomy, and can includes circulatory, digestive, endocrine, integumentary, immune, lymphatic, muscular, nervous, reproductive, respiratory, skeletal, urinary, vestibular, and other systems.
    /// </summary>
    [DataContract]
    public partial class AnatomicalSystem : MedicalEntity
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

        public interface IComprisedOf : IValue {}
        public interface IComprisedOf<T> : IComprisedOf { new T Value { get; } }
        public class OneOrManyComprisedOf : OneOrMany<IComprisedOf>
        {
            public OneOrManyComprisedOf(IComprisedOf item) : base(item) { }
            public OneOrManyComprisedOf(IEnumerable<IComprisedOf> items) : base(items) { }
            public static implicit operator OneOrManyComprisedOf (AnatomicalStructure value) { return new OneOrManyComprisedOf (new ComprisedOfAnatomicalStructure (value)); }
            public static implicit operator OneOrManyComprisedOf (AnatomicalStructure[] values) { return new OneOrManyComprisedOf (values.Select(v => (IComprisedOf) new ComprisedOfAnatomicalStructure (v))); }
            public static implicit operator OneOrManyComprisedOf (List<AnatomicalStructure> values) { return new OneOrManyComprisedOf (values.Select(v => (IComprisedOf) new ComprisedOfAnatomicalStructure (v))); }
            public static implicit operator OneOrManyComprisedOf (AnatomicalSystem value) { return new OneOrManyComprisedOf (new ComprisedOfAnatomicalSystem (value)); }
            public static implicit operator OneOrManyComprisedOf (AnatomicalSystem[] values) { return new OneOrManyComprisedOf (values.Select(v => (IComprisedOf) new ComprisedOfAnatomicalSystem (v))); }
            public static implicit operator OneOrManyComprisedOf (List<AnatomicalSystem> values) { return new OneOrManyComprisedOf (values.Select(v => (IComprisedOf) new ComprisedOfAnatomicalSystem (v))); }
        }
        public struct ComprisedOfAnatomicalStructure : IComprisedOf<AnatomicalStructure>
        {
            object IValue.Value => this.Value;
            public AnatomicalStructure Value { get; }
            public ComprisedOfAnatomicalStructure (AnatomicalStructure value) { Value = value; }
            public static implicit operator ComprisedOfAnatomicalStructure (AnatomicalStructure value) { return new ComprisedOfAnatomicalStructure (value); }
        }
        public struct ComprisedOfAnatomicalSystem : IComprisedOf<AnatomicalSystem>
        {
            object IValue.Value => this.Value;
            public AnatomicalSystem Value { get; }
            public ComprisedOfAnatomicalSystem (AnatomicalSystem value) { Value = value; }
            public static implicit operator ComprisedOfAnatomicalSystem (AnatomicalSystem value) { return new ComprisedOfAnatomicalSystem (value); }
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

        public interface IRelatedStructure : IValue {}
        public interface IRelatedStructure<T> : IRelatedStructure { new T Value { get; } }
        public class OneOrManyRelatedStructure : OneOrMany<IRelatedStructure>
        {
            public OneOrManyRelatedStructure(IRelatedStructure item) : base(item) { }
            public OneOrManyRelatedStructure(IEnumerable<IRelatedStructure> items) : base(items) { }
            public static implicit operator OneOrManyRelatedStructure (AnatomicalStructure value) { return new OneOrManyRelatedStructure (new RelatedStructureAnatomicalStructure (value)); }
            public static implicit operator OneOrManyRelatedStructure (AnatomicalStructure[] values) { return new OneOrManyRelatedStructure (values.Select(v => (IRelatedStructure) new RelatedStructureAnatomicalStructure (v))); }
            public static implicit operator OneOrManyRelatedStructure (List<AnatomicalStructure> values) { return new OneOrManyRelatedStructure (values.Select(v => (IRelatedStructure) new RelatedStructureAnatomicalStructure (v))); }
        }
        public struct RelatedStructureAnatomicalStructure : IRelatedStructure<AnatomicalStructure>
        {
            object IValue.Value => this.Value;
            public AnatomicalStructure Value { get; }
            public RelatedStructureAnatomicalStructure (AnatomicalStructure value) { Value = value; }
            public static implicit operator RelatedStructureAnatomicalStructure (AnatomicalStructure value) { return new RelatedStructureAnatomicalStructure (value); }
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

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AnatomicalSystem";

        /// <summary>
        /// If applicable, a description of the pathophysiology associated with the anatomical system, including potential abnormal changes in the mechanical, physical, and biochemical functions of the system.
        /// </summary>
        [DataMember(Name = "associatedPathophysiology", Order = 206)]
        public OneOrManyAssociatedPathophysiology AssociatedPathophysiology { get; set; }

        /// <summary>
        /// Specifying something physically contained by something else. Typically used here for the underlying anatomical structures, such as organs, that comprise the anatomical system.
        /// </summary>
        [DataMember(Name = "comprisedOf", Order = 207)]
        public OneOrManyComprisedOf ComprisedOf { get; set; }

        /// <summary>
        /// A medical condition associated with this anatomy.
        /// </summary>
        [DataMember(Name = "relatedCondition", Order = 208)]
        public OneOrManyRelatedCondition RelatedCondition { get; set; }

        /// <summary>
        /// Related anatomical structure(s) that are not part of the system but relate or connect to it, such as vascular bundles associated with an organ system.
        /// </summary>
        [DataMember(Name = "relatedStructure", Order = 209)]
        public OneOrManyRelatedStructure RelatedStructure { get; set; }

        /// <summary>
        /// A medical therapy related to this anatomy.
        /// </summary>
        [DataMember(Name = "relatedTherapy", Order = 210)]
        public OneOrManyRelatedTherapy RelatedTherapy { get; set; }
    }
}
