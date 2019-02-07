namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The anatomical location at which two or more bones make contact.
    /// </summary>
    [DataContract]
    public partial class Joint : AnatomicalStructure
    {
        public interface IBiomechnicalClass : IValue {}
        public interface IBiomechnicalClass<T> : IBiomechnicalClass { new T Value { get; } }
        public class OneOrManyBiomechnicalClass : OneOrMany<IBiomechnicalClass>
        {
            public OneOrManyBiomechnicalClass(IBiomechnicalClass item) : base(item) { }
            public OneOrManyBiomechnicalClass(IEnumerable<IBiomechnicalClass> items) : base(items) { }
            public static implicit operator OneOrManyBiomechnicalClass (string value) { return new OneOrManyBiomechnicalClass (new BiomechnicalClassstring (value)); }
            public static implicit operator OneOrManyBiomechnicalClass (string[] values) { return new OneOrManyBiomechnicalClass (values.Select(v => (IBiomechnicalClass) new BiomechnicalClassstring (v))); }
            public static implicit operator OneOrManyBiomechnicalClass (List<string> values) { return new OneOrManyBiomechnicalClass (values.Select(v => (IBiomechnicalClass) new BiomechnicalClassstring (v))); }
        }
        public struct BiomechnicalClassstring : IBiomechnicalClass<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public BiomechnicalClassstring (string value) { Value = value; }
            public static implicit operator BiomechnicalClassstring (string value) { return new BiomechnicalClassstring (value); }
        }

        public interface IFunctionalClass : IValue {}
        public interface IFunctionalClass<T> : IFunctionalClass { new T Value { get; } }
        public class OneOrManyFunctionalClass : OneOrMany<IFunctionalClass>
        {
            public OneOrManyFunctionalClass(IFunctionalClass item) : base(item) { }
            public OneOrManyFunctionalClass(IEnumerable<IFunctionalClass> items) : base(items) { }
            public static implicit operator OneOrManyFunctionalClass (MedicalEntity value) { return new OneOrManyFunctionalClass (new FunctionalClassMedicalEntity (value)); }
            public static implicit operator OneOrManyFunctionalClass (MedicalEntity[] values) { return new OneOrManyFunctionalClass (values.Select(v => (IFunctionalClass) new FunctionalClassMedicalEntity (v))); }
            public static implicit operator OneOrManyFunctionalClass (List<MedicalEntity> values) { return new OneOrManyFunctionalClass (values.Select(v => (IFunctionalClass) new FunctionalClassMedicalEntity (v))); }
            public static implicit operator OneOrManyFunctionalClass (string value) { return new OneOrManyFunctionalClass (new FunctionalClassstring (value)); }
            public static implicit operator OneOrManyFunctionalClass (string[] values) { return new OneOrManyFunctionalClass (values.Select(v => (IFunctionalClass) new FunctionalClassstring (v))); }
            public static implicit operator OneOrManyFunctionalClass (List<string> values) { return new OneOrManyFunctionalClass (values.Select(v => (IFunctionalClass) new FunctionalClassstring (v))); }
        }
        public struct FunctionalClassMedicalEntity : IFunctionalClass<MedicalEntity>
        {
            object IValue.Value => this.Value;
            public MedicalEntity Value { get; }
            public FunctionalClassMedicalEntity (MedicalEntity value) { Value = value; }
            public static implicit operator FunctionalClassMedicalEntity (MedicalEntity value) { return new FunctionalClassMedicalEntity (value); }
        }
        public struct FunctionalClassstring : IFunctionalClass<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public FunctionalClassstring (string value) { Value = value; }
            public static implicit operator FunctionalClassstring (string value) { return new FunctionalClassstring (value); }
        }

        public interface IStructuralClass : IValue {}
        public interface IStructuralClass<T> : IStructuralClass { new T Value { get; } }
        public class OneOrManyStructuralClass : OneOrMany<IStructuralClass>
        {
            public OneOrManyStructuralClass(IStructuralClass item) : base(item) { }
            public OneOrManyStructuralClass(IEnumerable<IStructuralClass> items) : base(items) { }
            public static implicit operator OneOrManyStructuralClass (string value) { return new OneOrManyStructuralClass (new StructuralClassstring (value)); }
            public static implicit operator OneOrManyStructuralClass (string[] values) { return new OneOrManyStructuralClass (values.Select(v => (IStructuralClass) new StructuralClassstring (v))); }
            public static implicit operator OneOrManyStructuralClass (List<string> values) { return new OneOrManyStructuralClass (values.Select(v => (IStructuralClass) new StructuralClassstring (v))); }
        }
        public struct StructuralClassstring : IStructuralClass<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public StructuralClassstring (string value) { Value = value; }
            public static implicit operator StructuralClassstring (string value) { return new StructuralClassstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Joint";

        /// <summary>
        /// The biomechanical properties of the bone.
        /// </summary>
        [DataMember(Name = "biomechnicalClass", Order = 306)]
        public OneOrManyBiomechnicalClass BiomechnicalClass { get; set; }

        /// <summary>
        /// The degree of mobility the joint allows.
        /// </summary>
        [DataMember(Name = "functionalClass", Order = 307)]
        public OneOrManyFunctionalClass FunctionalClass { get; set; }

        /// <summary>
        /// The name given to how bone physically connects to each other.
        /// </summary>
        [DataMember(Name = "structuralClass", Order = 308)]
        public OneOrManyStructuralClass StructuralClass { get; set; }
    }
}
