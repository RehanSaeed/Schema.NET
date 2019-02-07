namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any part of the human body, typically a component of an anatomical system. Organs, tissues, and cells are all anatomical structures.
    /// </summary>
    [DataContract]
    public partial class AnatomicalStructure : MedicalEntity
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

        public interface IConnectedTo : IValue {}
        public interface IConnectedTo<T> : IConnectedTo { new T Value { get; } }
        public class OneOrManyConnectedTo : OneOrMany<IConnectedTo>
        {
            public OneOrManyConnectedTo(IConnectedTo item) : base(item) { }
            public OneOrManyConnectedTo(IEnumerable<IConnectedTo> items) : base(items) { }
            public static implicit operator OneOrManyConnectedTo (AnatomicalStructure value) { return new OneOrManyConnectedTo (new ConnectedToAnatomicalStructure (value)); }
            public static implicit operator OneOrManyConnectedTo (AnatomicalStructure[] values) { return new OneOrManyConnectedTo (values.Select(v => (IConnectedTo) new ConnectedToAnatomicalStructure (v))); }
            public static implicit operator OneOrManyConnectedTo (List<AnatomicalStructure> values) { return new OneOrManyConnectedTo (values.Select(v => (IConnectedTo) new ConnectedToAnatomicalStructure (v))); }
        }
        public struct ConnectedToAnatomicalStructure : IConnectedTo<AnatomicalStructure>
        {
            object IValue.Value => this.Value;
            public AnatomicalStructure Value { get; }
            public ConnectedToAnatomicalStructure (AnatomicalStructure value) { Value = value; }
            public static implicit operator ConnectedToAnatomicalStructure (AnatomicalStructure value) { return new ConnectedToAnatomicalStructure (value); }
        }

        public interface IDiagram : IValue {}
        public interface IDiagram<T> : IDiagram { new T Value { get; } }
        public class OneOrManyDiagram : OneOrMany<IDiagram>
        {
            public OneOrManyDiagram(IDiagram item) : base(item) { }
            public OneOrManyDiagram(IEnumerable<IDiagram> items) : base(items) { }
            public static implicit operator OneOrManyDiagram (ImageObject value) { return new OneOrManyDiagram (new DiagramImageObject (value)); }
            public static implicit operator OneOrManyDiagram (ImageObject[] values) { return new OneOrManyDiagram (values.Select(v => (IDiagram) new DiagramImageObject (v))); }
            public static implicit operator OneOrManyDiagram (List<ImageObject> values) { return new OneOrManyDiagram (values.Select(v => (IDiagram) new DiagramImageObject (v))); }
        }
        public struct DiagramImageObject : IDiagram<ImageObject>
        {
            object IValue.Value => this.Value;
            public ImageObject Value { get; }
            public DiagramImageObject (ImageObject value) { Value = value; }
            public static implicit operator DiagramImageObject (ImageObject value) { return new DiagramImageObject (value); }
        }

        public interface IFunction : IValue {}
        public interface IFunction<T> : IFunction { new T Value { get; } }
        public class OneOrManyFunction : OneOrMany<IFunction>
        {
            public OneOrManyFunction(IFunction item) : base(item) { }
            public OneOrManyFunction(IEnumerable<IFunction> items) : base(items) { }
            public static implicit operator OneOrManyFunction (string value) { return new OneOrManyFunction (new Functionstring (value)); }
            public static implicit operator OneOrManyFunction (string[] values) { return new OneOrManyFunction (values.Select(v => (IFunction) new Functionstring (v))); }
            public static implicit operator OneOrManyFunction (List<string> values) { return new OneOrManyFunction (values.Select(v => (IFunction) new Functionstring (v))); }
        }
        public struct Functionstring : IFunction<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Functionstring (string value) { Value = value; }
            public static implicit operator Functionstring (string value) { return new Functionstring (value); }
        }

        public interface IPartOfSystem : IValue {}
        public interface IPartOfSystem<T> : IPartOfSystem { new T Value { get; } }
        public class OneOrManyPartOfSystem : OneOrMany<IPartOfSystem>
        {
            public OneOrManyPartOfSystem(IPartOfSystem item) : base(item) { }
            public OneOrManyPartOfSystem(IEnumerable<IPartOfSystem> items) : base(items) { }
            public static implicit operator OneOrManyPartOfSystem (AnatomicalSystem value) { return new OneOrManyPartOfSystem (new PartOfSystemAnatomicalSystem (value)); }
            public static implicit operator OneOrManyPartOfSystem (AnatomicalSystem[] values) { return new OneOrManyPartOfSystem (values.Select(v => (IPartOfSystem) new PartOfSystemAnatomicalSystem (v))); }
            public static implicit operator OneOrManyPartOfSystem (List<AnatomicalSystem> values) { return new OneOrManyPartOfSystem (values.Select(v => (IPartOfSystem) new PartOfSystemAnatomicalSystem (v))); }
        }
        public struct PartOfSystemAnatomicalSystem : IPartOfSystem<AnatomicalSystem>
        {
            object IValue.Value => this.Value;
            public AnatomicalSystem Value { get; }
            public PartOfSystemAnatomicalSystem (AnatomicalSystem value) { Value = value; }
            public static implicit operator PartOfSystemAnatomicalSystem (AnatomicalSystem value) { return new PartOfSystemAnatomicalSystem (value); }
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

        public interface ISubStructure : IValue {}
        public interface ISubStructure<T> : ISubStructure { new T Value { get; } }
        public class OneOrManySubStructure : OneOrMany<ISubStructure>
        {
            public OneOrManySubStructure(ISubStructure item) : base(item) { }
            public OneOrManySubStructure(IEnumerable<ISubStructure> items) : base(items) { }
            public static implicit operator OneOrManySubStructure (AnatomicalStructure value) { return new OneOrManySubStructure (new SubStructureAnatomicalStructure (value)); }
            public static implicit operator OneOrManySubStructure (AnatomicalStructure[] values) { return new OneOrManySubStructure (values.Select(v => (ISubStructure) new SubStructureAnatomicalStructure (v))); }
            public static implicit operator OneOrManySubStructure (List<AnatomicalStructure> values) { return new OneOrManySubStructure (values.Select(v => (ISubStructure) new SubStructureAnatomicalStructure (v))); }
        }
        public struct SubStructureAnatomicalStructure : ISubStructure<AnatomicalStructure>
        {
            object IValue.Value => this.Value;
            public AnatomicalStructure Value { get; }
            public SubStructureAnatomicalStructure (AnatomicalStructure value) { Value = value; }
            public static implicit operator SubStructureAnatomicalStructure (AnatomicalStructure value) { return new SubStructureAnatomicalStructure (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AnatomicalStructure";

        /// <summary>
        /// If applicable, a description of the pathophysiology associated with the anatomical system, including potential abnormal changes in the mechanical, physical, and biochemical functions of the system.
        /// </summary>
        [DataMember(Name = "associatedPathophysiology", Order = 206)]
        public OneOrManyAssociatedPathophysiology AssociatedPathophysiology { get; set; }

        /// <summary>
        /// Location in the body of the anatomical structure.
        /// </summary>
        [DataMember(Name = "bodyLocation", Order = 207)]
        public OneOrManyBodyLocation BodyLocation { get; set; }

        /// <summary>
        /// Other anatomical structures to which this structure is connected.
        /// </summary>
        [DataMember(Name = "connectedTo", Order = 208)]
        public OneOrManyConnectedTo ConnectedTo { get; set; }

        /// <summary>
        /// An image containing a diagram that illustrates the structure and/or its component substructures and/or connections with other structures.
        /// </summary>
        [DataMember(Name = "diagram", Order = 209)]
        public OneOrManyDiagram Diagram { get; set; }

        /// <summary>
        /// Function of the anatomical structure.
        /// </summary>
        [DataMember(Name = "function", Order = 210)]
        public OneOrManyFunction Function { get; set; }

        /// <summary>
        /// The anatomical or organ system that this structure is part of.
        /// </summary>
        [DataMember(Name = "partOfSystem", Order = 211)]
        public OneOrManyPartOfSystem PartOfSystem { get; set; }

        /// <summary>
        /// A medical condition associated with this anatomy.
        /// </summary>
        [DataMember(Name = "relatedCondition", Order = 212)]
        public OneOrManyRelatedCondition RelatedCondition { get; set; }

        /// <summary>
        /// A medical therapy related to this anatomy.
        /// </summary>
        [DataMember(Name = "relatedTherapy", Order = 213)]
        public OneOrManyRelatedTherapy RelatedTherapy { get; set; }

        /// <summary>
        /// Component (sub-)structure(s) that comprise this anatomical structure.
        /// </summary>
        [DataMember(Name = "subStructure", Order = 214)]
        public OneOrManySubStructure SubStructure { get; set; }
    }
}
