namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A product taken by mouth that contains a dietary ingredient intended to supplement the diet. Dietary ingredients may include vitamins, minerals, herbs or other botanicals, amino acids, and substances such as enzymes, organ tissues, glandulars and metabolites.
    /// </summary>
    [DataContract]
    public partial class DietarySupplement : Substance
    {

        public interface IBackground : IValue {}
        public interface IBackground<T> : IBackground { new T Value { get; } }
        public class OneOrManyBackground : OneOrMany<IBackground>
        {
            public OneOrManyBackground(IBackground item) : base(item) { }
            public OneOrManyBackground(IEnumerable<IBackground> items) : base(items) { }
            public static implicit operator OneOrManyBackground (string value) { return new OneOrManyBackground (new Backgroundstring (value)); }
            public static implicit operator OneOrManyBackground (string[] values) { return new OneOrManyBackground (values.Select(v => (IBackground) new Backgroundstring (v))); }
            public static implicit operator OneOrManyBackground (List<string> values) { return new OneOrManyBackground (values.Select(v => (IBackground) new Backgroundstring (v))); }
        }
        public struct Backgroundstring : IBackground<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Backgroundstring (string value) { Value = value; }
            public static implicit operator Backgroundstring (string value) { return new Backgroundstring (value); }
        }

        public interface IIsProprietary : IValue {}
        public interface IIsProprietary<T> : IIsProprietary { new T Value { get; } }
        public class OneOrManyIsProprietary : OneOrMany<IIsProprietary>
        {
            public OneOrManyIsProprietary(IIsProprietary item) : base(item) { }
            public OneOrManyIsProprietary(IEnumerable<IIsProprietary> items) : base(items) { }
            public static implicit operator OneOrManyIsProprietary (bool value) { return new OneOrManyIsProprietary (new IsProprietarybool (value)); }
            public static implicit operator OneOrManyIsProprietary (bool[] values) { return new OneOrManyIsProprietary (values.Select(v => (IIsProprietary) new IsProprietarybool (v))); }
            public static implicit operator OneOrManyIsProprietary (List<bool> values) { return new OneOrManyIsProprietary (values.Select(v => (IIsProprietary) new IsProprietarybool (v))); }
        }
        public struct IsProprietarybool : IIsProprietary<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public IsProprietarybool (bool value) { Value = value; }
            public static implicit operator IsProprietarybool (bool value) { return new IsProprietarybool (value); }
        }



        public interface IMechanismOfAction : IValue {}
        public interface IMechanismOfAction<T> : IMechanismOfAction { new T Value { get; } }
        public class OneOrManyMechanismOfAction : OneOrMany<IMechanismOfAction>
        {
            public OneOrManyMechanismOfAction(IMechanismOfAction item) : base(item) { }
            public OneOrManyMechanismOfAction(IEnumerable<IMechanismOfAction> items) : base(items) { }
            public static implicit operator OneOrManyMechanismOfAction (string value) { return new OneOrManyMechanismOfAction (new MechanismOfActionstring (value)); }
            public static implicit operator OneOrManyMechanismOfAction (string[] values) { return new OneOrManyMechanismOfAction (values.Select(v => (IMechanismOfAction) new MechanismOfActionstring (v))); }
            public static implicit operator OneOrManyMechanismOfAction (List<string> values) { return new OneOrManyMechanismOfAction (values.Select(v => (IMechanismOfAction) new MechanismOfActionstring (v))); }
        }
        public struct MechanismOfActionstring : IMechanismOfAction<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public MechanismOfActionstring (string value) { Value = value; }
            public static implicit operator MechanismOfActionstring (string value) { return new MechanismOfActionstring (value); }
        }

        public interface INonProprietaryName : IValue {}
        public interface INonProprietaryName<T> : INonProprietaryName { new T Value { get; } }
        public class OneOrManyNonProprietaryName : OneOrMany<INonProprietaryName>
        {
            public OneOrManyNonProprietaryName(INonProprietaryName item) : base(item) { }
            public OneOrManyNonProprietaryName(IEnumerable<INonProprietaryName> items) : base(items) { }
            public static implicit operator OneOrManyNonProprietaryName (string value) { return new OneOrManyNonProprietaryName (new NonProprietaryNamestring (value)); }
            public static implicit operator OneOrManyNonProprietaryName (string[] values) { return new OneOrManyNonProprietaryName (values.Select(v => (INonProprietaryName) new NonProprietaryNamestring (v))); }
            public static implicit operator OneOrManyNonProprietaryName (List<string> values) { return new OneOrManyNonProprietaryName (values.Select(v => (INonProprietaryName) new NonProprietaryNamestring (v))); }
        }
        public struct NonProprietaryNamestring : INonProprietaryName<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public NonProprietaryNamestring (string value) { Value = value; }
            public static implicit operator NonProprietaryNamestring (string value) { return new NonProprietaryNamestring (value); }
        }

        public interface IProprietaryName : IValue {}
        public interface IProprietaryName<T> : IProprietaryName { new T Value { get; } }
        public class OneOrManyProprietaryName : OneOrMany<IProprietaryName>
        {
            public OneOrManyProprietaryName(IProprietaryName item) : base(item) { }
            public OneOrManyProprietaryName(IEnumerable<IProprietaryName> items) : base(items) { }
            public static implicit operator OneOrManyProprietaryName (string value) { return new OneOrManyProprietaryName (new ProprietaryNamestring (value)); }
            public static implicit operator OneOrManyProprietaryName (string[] values) { return new OneOrManyProprietaryName (values.Select(v => (IProprietaryName) new ProprietaryNamestring (v))); }
            public static implicit operator OneOrManyProprietaryName (List<string> values) { return new OneOrManyProprietaryName (values.Select(v => (IProprietaryName) new ProprietaryNamestring (v))); }
        }
        public struct ProprietaryNamestring : IProprietaryName<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ProprietaryNamestring (string value) { Value = value; }
            public static implicit operator ProprietaryNamestring (string value) { return new ProprietaryNamestring (value); }
        }

        public interface IRecommendedIntake : IValue {}
        public interface IRecommendedIntake<T> : IRecommendedIntake { new T Value { get; } }
        public class OneOrManyRecommendedIntake : OneOrMany<IRecommendedIntake>
        {
            public OneOrManyRecommendedIntake(IRecommendedIntake item) : base(item) { }
            public OneOrManyRecommendedIntake(IEnumerable<IRecommendedIntake> items) : base(items) { }
            public static implicit operator OneOrManyRecommendedIntake (RecommendedDoseSchedule value) { return new OneOrManyRecommendedIntake (new RecommendedIntakeRecommendedDoseSchedule (value)); }
            public static implicit operator OneOrManyRecommendedIntake (RecommendedDoseSchedule[] values) { return new OneOrManyRecommendedIntake (values.Select(v => (IRecommendedIntake) new RecommendedIntakeRecommendedDoseSchedule (v))); }
            public static implicit operator OneOrManyRecommendedIntake (List<RecommendedDoseSchedule> values) { return new OneOrManyRecommendedIntake (values.Select(v => (IRecommendedIntake) new RecommendedIntakeRecommendedDoseSchedule (v))); }
        }
        public struct RecommendedIntakeRecommendedDoseSchedule : IRecommendedIntake<RecommendedDoseSchedule>
        {
            object IValue.Value => this.Value;
            public RecommendedDoseSchedule Value { get; }
            public RecommendedIntakeRecommendedDoseSchedule (RecommendedDoseSchedule value) { Value = value; }
            public static implicit operator RecommendedIntakeRecommendedDoseSchedule (RecommendedDoseSchedule value) { return new RecommendedIntakeRecommendedDoseSchedule (value); }
        }

        public interface ISafetyConsideration : IValue {}
        public interface ISafetyConsideration<T> : ISafetyConsideration { new T Value { get; } }
        public class OneOrManySafetyConsideration : OneOrMany<ISafetyConsideration>
        {
            public OneOrManySafetyConsideration(ISafetyConsideration item) : base(item) { }
            public OneOrManySafetyConsideration(IEnumerable<ISafetyConsideration> items) : base(items) { }
            public static implicit operator OneOrManySafetyConsideration (string value) { return new OneOrManySafetyConsideration (new SafetyConsiderationstring (value)); }
            public static implicit operator OneOrManySafetyConsideration (string[] values) { return new OneOrManySafetyConsideration (values.Select(v => (ISafetyConsideration) new SafetyConsiderationstring (v))); }
            public static implicit operator OneOrManySafetyConsideration (List<string> values) { return new OneOrManySafetyConsideration (values.Select(v => (ISafetyConsideration) new SafetyConsiderationstring (v))); }
        }
        public struct SafetyConsiderationstring : ISafetyConsideration<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SafetyConsiderationstring (string value) { Value = value; }
            public static implicit operator SafetyConsiderationstring (string value) { return new SafetyConsiderationstring (value); }
        }

        public interface ITargetPopulation : IValue {}
        public interface ITargetPopulation<T> : ITargetPopulation { new T Value { get; } }
        public class OneOrManyTargetPopulation : OneOrMany<ITargetPopulation>
        {
            public OneOrManyTargetPopulation(ITargetPopulation item) : base(item) { }
            public OneOrManyTargetPopulation(IEnumerable<ITargetPopulation> items) : base(items) { }
            public static implicit operator OneOrManyTargetPopulation (string value) { return new OneOrManyTargetPopulation (new TargetPopulationstring (value)); }
            public static implicit operator OneOrManyTargetPopulation (string[] values) { return new OneOrManyTargetPopulation (values.Select(v => (ITargetPopulation) new TargetPopulationstring (v))); }
            public static implicit operator OneOrManyTargetPopulation (List<string> values) { return new OneOrManyTargetPopulation (values.Select(v => (ITargetPopulation) new TargetPopulationstring (v))); }
        }
        public struct TargetPopulationstring : ITargetPopulation<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public TargetPopulationstring (string value) { Value = value; }
            public static implicit operator TargetPopulationstring (string value) { return new TargetPopulationstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DietarySupplement";

        /// <summary>
        /// An active ingredient, typically chemical compounds and/or biologic substances.
        /// </summary>
        [DataMember(Name = "activeIngredient", Order = 306)]
        public override OneOrManyActiveIngredient ActiveIngredient { get; set; }

        /// <summary>
        /// Descriptive information establishing a historical perspective on the supplement. May include the rationale for the name, the population where the supplement first came to prominence, etc.
        /// </summary>
        [DataMember(Name = "background", Order = 307)]
        public OneOrManyBackground Background { get; set; }

        /// <summary>
        /// True if this item's name is a proprietary/brand name (vs. generic name).
        /// </summary>
        [DataMember(Name = "isProprietary", Order = 308)]
        public OneOrManyIsProprietary IsProprietary { get; set; }

        /// <summary>
        /// The drug or supplement's legal status, including any controlled substance schedules that apply.
        /// </summary>
        [DataMember(Name = "legalStatus", Order = 309)]
        public override OneOrManyLegalStatus LegalStatus { get; set; }

        /// <summary>
        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        /// </summary>
        [DataMember(Name = "maximumIntake", Order = 310)]
        public override OneOrManyMaximumIntake MaximumIntake { get; set; }

        /// <summary>
        /// The specific biochemical interaction through which this drug or supplement produces its pharmacological effect.
        /// </summary>
        [DataMember(Name = "mechanismOfAction", Order = 311)]
        public OneOrManyMechanismOfAction MechanismOfAction { get; set; }

        /// <summary>
        /// The generic name of this drug or supplement.
        /// </summary>
        [DataMember(Name = "nonProprietaryName", Order = 312)]
        public OneOrManyNonProprietaryName NonProprietaryName { get; set; }

        /// <summary>
        /// Proprietary name given to the diet plan, typically by its originator or creator.
        /// </summary>
        [DataMember(Name = "proprietaryName", Order = 313)]
        public OneOrManyProprietaryName ProprietaryName { get; set; }

        /// <summary>
        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        /// </summary>
        [DataMember(Name = "recommendedIntake", Order = 314)]
        public OneOrManyRecommendedIntake RecommendedIntake { get; set; }

        /// <summary>
        /// Any potential safety concern associated with the supplement. May include interactions with other drugs and foods, pregnancy, breastfeeding, known adverse reactions, and documented efficacy of the supplement.
        /// </summary>
        [DataMember(Name = "safetyConsideration", Order = 315)]
        public OneOrManySafetyConsideration SafetyConsideration { get; set; }

        /// <summary>
        /// Characteristics of the population for which this is intended, or which typically uses it, e.g. 'adults'.
        /// </summary>
        [DataMember(Name = "targetPopulation", Order = 316)]
        public OneOrManyTargetPopulation TargetPopulation { get; set; }
    }
}
