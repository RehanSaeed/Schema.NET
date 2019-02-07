namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A strategy of regulating the intake of food to achieve or maintain a specific health-related goal.
    /// </summary>
    [DataContract]
    public partial class Diet : CreativeWorkAndLifestyleModification
    {
        public interface IDietFeatures : IValue {}
        public interface IDietFeatures<T> : IDietFeatures { new T Value { get; } }
        public class OneOrManyDietFeatures : OneOrMany<IDietFeatures>
        {
            public OneOrManyDietFeatures(IDietFeatures item) : base(item) { }
            public OneOrManyDietFeatures(IEnumerable<IDietFeatures> items) : base(items) { }
            public static implicit operator OneOrManyDietFeatures (string value) { return new OneOrManyDietFeatures (new DietFeaturesstring (value)); }
            public static implicit operator OneOrManyDietFeatures (string[] values) { return new OneOrManyDietFeatures (values.Select(v => (IDietFeatures) new DietFeaturesstring (v))); }
            public static implicit operator OneOrManyDietFeatures (List<string> values) { return new OneOrManyDietFeatures (values.Select(v => (IDietFeatures) new DietFeaturesstring (v))); }
        }
        public struct DietFeaturesstring : IDietFeatures<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public DietFeaturesstring (string value) { Value = value; }
            public static implicit operator DietFeaturesstring (string value) { return new DietFeaturesstring (value); }
        }

        public interface IEndorsers : IValue {}
        public interface IEndorsers<T> : IEndorsers { new T Value { get; } }
        public class OneOrManyEndorsers : OneOrMany<IEndorsers>
        {
            public OneOrManyEndorsers(IEndorsers item) : base(item) { }
            public OneOrManyEndorsers(IEnumerable<IEndorsers> items) : base(items) { }
            public static implicit operator OneOrManyEndorsers (Organization value) { return new OneOrManyEndorsers (new EndorsersOrganization (value)); }
            public static implicit operator OneOrManyEndorsers (Organization[] values) { return new OneOrManyEndorsers (values.Select(v => (IEndorsers) new EndorsersOrganization (v))); }
            public static implicit operator OneOrManyEndorsers (List<Organization> values) { return new OneOrManyEndorsers (values.Select(v => (IEndorsers) new EndorsersOrganization (v))); }
            public static implicit operator OneOrManyEndorsers (Person value) { return new OneOrManyEndorsers (new EndorsersPerson (value)); }
            public static implicit operator OneOrManyEndorsers (Person[] values) { return new OneOrManyEndorsers (values.Select(v => (IEndorsers) new EndorsersPerson (v))); }
            public static implicit operator OneOrManyEndorsers (List<Person> values) { return new OneOrManyEndorsers (values.Select(v => (IEndorsers) new EndorsersPerson (v))); }
        }
        public struct EndorsersOrganization : IEndorsers<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public EndorsersOrganization (Organization value) { Value = value; }
            public static implicit operator EndorsersOrganization (Organization value) { return new EndorsersOrganization (value); }
        }
        public struct EndorsersPerson : IEndorsers<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public EndorsersPerson (Person value) { Value = value; }
            public static implicit operator EndorsersPerson (Person value) { return new EndorsersPerson (value); }
        }

        public interface IExpertConsiderations : IValue {}
        public interface IExpertConsiderations<T> : IExpertConsiderations { new T Value { get; } }
        public class OneOrManyExpertConsiderations : OneOrMany<IExpertConsiderations>
        {
            public OneOrManyExpertConsiderations(IExpertConsiderations item) : base(item) { }
            public OneOrManyExpertConsiderations(IEnumerable<IExpertConsiderations> items) : base(items) { }
            public static implicit operator OneOrManyExpertConsiderations (string value) { return new OneOrManyExpertConsiderations (new ExpertConsiderationsstring (value)); }
            public static implicit operator OneOrManyExpertConsiderations (string[] values) { return new OneOrManyExpertConsiderations (values.Select(v => (IExpertConsiderations) new ExpertConsiderationsstring (v))); }
            public static implicit operator OneOrManyExpertConsiderations (List<string> values) { return new OneOrManyExpertConsiderations (values.Select(v => (IExpertConsiderations) new ExpertConsiderationsstring (v))); }
        }
        public struct ExpertConsiderationsstring : IExpertConsiderations<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ExpertConsiderationsstring (string value) { Value = value; }
            public static implicit operator ExpertConsiderationsstring (string value) { return new ExpertConsiderationsstring (value); }
        }

        public interface IOverview : IValue {}
        public interface IOverview<T> : IOverview { new T Value { get; } }
        public class OneOrManyOverview : OneOrMany<IOverview>
        {
            public OneOrManyOverview(IOverview item) : base(item) { }
            public OneOrManyOverview(IEnumerable<IOverview> items) : base(items) { }
            public static implicit operator OneOrManyOverview (string value) { return new OneOrManyOverview (new Overviewstring (value)); }
            public static implicit operator OneOrManyOverview (string[] values) { return new OneOrManyOverview (values.Select(v => (IOverview) new Overviewstring (v))); }
            public static implicit operator OneOrManyOverview (List<string> values) { return new OneOrManyOverview (values.Select(v => (IOverview) new Overviewstring (v))); }
        }
        public struct Overviewstring : IOverview<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Overviewstring (string value) { Value = value; }
            public static implicit operator Overviewstring (string value) { return new Overviewstring (value); }
        }

        public interface IPhysiologicalBenefits : IValue {}
        public interface IPhysiologicalBenefits<T> : IPhysiologicalBenefits { new T Value { get; } }
        public class OneOrManyPhysiologicalBenefits : OneOrMany<IPhysiologicalBenefits>
        {
            public OneOrManyPhysiologicalBenefits(IPhysiologicalBenefits item) : base(item) { }
            public OneOrManyPhysiologicalBenefits(IEnumerable<IPhysiologicalBenefits> items) : base(items) { }
            public static implicit operator OneOrManyPhysiologicalBenefits (string value) { return new OneOrManyPhysiologicalBenefits (new PhysiologicalBenefitsstring (value)); }
            public static implicit operator OneOrManyPhysiologicalBenefits (string[] values) { return new OneOrManyPhysiologicalBenefits (values.Select(v => (IPhysiologicalBenefits) new PhysiologicalBenefitsstring (v))); }
            public static implicit operator OneOrManyPhysiologicalBenefits (List<string> values) { return new OneOrManyPhysiologicalBenefits (values.Select(v => (IPhysiologicalBenefits) new PhysiologicalBenefitsstring (v))); }
        }
        public struct PhysiologicalBenefitsstring : IPhysiologicalBenefits<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PhysiologicalBenefitsstring (string value) { Value = value; }
            public static implicit operator PhysiologicalBenefitsstring (string value) { return new PhysiologicalBenefitsstring (value); }
        }

        public interface IRisks : IValue {}
        public interface IRisks<T> : IRisks { new T Value { get; } }
        public class OneOrManyRisks : OneOrMany<IRisks>
        {
            public OneOrManyRisks(IRisks item) : base(item) { }
            public OneOrManyRisks(IEnumerable<IRisks> items) : base(items) { }
            public static implicit operator OneOrManyRisks (string value) { return new OneOrManyRisks (new Risksstring (value)); }
            public static implicit operator OneOrManyRisks (string[] values) { return new OneOrManyRisks (values.Select(v => (IRisks) new Risksstring (v))); }
            public static implicit operator OneOrManyRisks (List<string> values) { return new OneOrManyRisks (values.Select(v => (IRisks) new Risksstring (v))); }
        }
        public struct Risksstring : IRisks<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Risksstring (string value) { Value = value; }
            public static implicit operator Risksstring (string value) { return new Risksstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Diet";

        /// <summary>
        /// Nutritional information specific to the dietary plan. May include dietary recommendations on what foods to avoid, what foods to consume, and specific alterations/deviations from the USDA or other regulatory body's approved dietary guidelines.
        /// </summary>
        [DataMember(Name = "dietFeatures", Order = 306)]
        public OneOrManyDietFeatures DietFeatures { get; set; }

        /// <summary>
        /// People or organizations that endorse the plan.
        /// </summary>
        [DataMember(Name = "endorsers", Order = 307)]
        public OneOrManyEndorsers Endorsers { get; set; }

        /// <summary>
        /// Medical expert advice related to the plan.
        /// </summary>
        [DataMember(Name = "expertConsiderations", Order = 308)]
        public OneOrManyExpertConsiderations ExpertConsiderations { get; set; }

        /// <summary>
        /// Descriptive information establishing the overarching theory/philosophy of the plan. May include the rationale for the name, the population where the plan first came to prominence, etc.
        /// </summary>
        [DataMember(Name = "overview", Order = 309)]
        public OneOrManyOverview Overview { get; set; }

        /// <summary>
        /// Specific physiologic benefits associated to the plan.
        /// </summary>
        [DataMember(Name = "physiologicalBenefits", Order = 310)]
        public OneOrManyPhysiologicalBenefits PhysiologicalBenefits { get; set; }

        /// <summary>
        /// Specific physiologic risks associated to the diet plan.
        /// </summary>
        [DataMember(Name = "risks", Order = 311)]
        public OneOrManyRisks Risks { get; set; }
    }
}
