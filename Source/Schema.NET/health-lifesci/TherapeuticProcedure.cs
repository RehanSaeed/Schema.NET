namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A medical procedure intended primarily for therapeutic purposes, aimed at improving a health condition.
    /// </summary>
    [DataContract]
    public partial class TherapeuticProcedure : MedicalProcedure
    {
        public interface IAdverseOutcome : IValue {}
        public interface IAdverseOutcome<T> : IAdverseOutcome { new T Value { get; } }
        public class OneOrManyAdverseOutcome : OneOrMany<IAdverseOutcome>
        {
            public OneOrManyAdverseOutcome(IAdverseOutcome item) : base(item) { }
            public OneOrManyAdverseOutcome(IEnumerable<IAdverseOutcome> items) : base(items) { }
            public static implicit operator OneOrManyAdverseOutcome (MedicalEntity value) { return new OneOrManyAdverseOutcome (new AdverseOutcomeMedicalEntity (value)); }
            public static implicit operator OneOrManyAdverseOutcome (MedicalEntity[] values) { return new OneOrManyAdverseOutcome (values.Select(v => (IAdverseOutcome) new AdverseOutcomeMedicalEntity (v))); }
            public static implicit operator OneOrManyAdverseOutcome (List<MedicalEntity> values) { return new OneOrManyAdverseOutcome (values.Select(v => (IAdverseOutcome) new AdverseOutcomeMedicalEntity (v))); }
        }
        public struct AdverseOutcomeMedicalEntity : IAdverseOutcome<MedicalEntity>
        {
            object IValue.Value => this.Value;
            public MedicalEntity Value { get; }
            public AdverseOutcomeMedicalEntity (MedicalEntity value) { Value = value; }
            public static implicit operator AdverseOutcomeMedicalEntity (MedicalEntity value) { return new AdverseOutcomeMedicalEntity (value); }
        }

        public interface IDoseSchedule : IValue {}
        public interface IDoseSchedule<T> : IDoseSchedule { new T Value { get; } }
        public class OneOrManyDoseSchedule : OneOrMany<IDoseSchedule>
        {
            public OneOrManyDoseSchedule(IDoseSchedule item) : base(item) { }
            public OneOrManyDoseSchedule(IEnumerable<IDoseSchedule> items) : base(items) { }
            public static implicit operator OneOrManyDoseSchedule (DoseSchedule value) { return new OneOrManyDoseSchedule (new DoseScheduleDoseSchedule (value)); }
            public static implicit operator OneOrManyDoseSchedule (DoseSchedule[] values) { return new OneOrManyDoseSchedule (values.Select(v => (IDoseSchedule) new DoseScheduleDoseSchedule (v))); }
            public static implicit operator OneOrManyDoseSchedule (List<DoseSchedule> values) { return new OneOrManyDoseSchedule (values.Select(v => (IDoseSchedule) new DoseScheduleDoseSchedule (v))); }
        }
        public struct DoseScheduleDoseSchedule : IDoseSchedule<DoseSchedule>
        {
            object IValue.Value => this.Value;
            public DoseSchedule Value { get; }
            public DoseScheduleDoseSchedule (DoseSchedule value) { Value = value; }
            public static implicit operator DoseScheduleDoseSchedule (DoseSchedule value) { return new DoseScheduleDoseSchedule (value); }
        }

        public interface IDrug : IValue {}
        public interface IDrug<T> : IDrug { new T Value { get; } }
        public class OneOrManyDrug : OneOrMany<IDrug>
        {
            public OneOrManyDrug(IDrug item) : base(item) { }
            public OneOrManyDrug(IEnumerable<IDrug> items) : base(items) { }
            public static implicit operator OneOrManyDrug (Drug value) { return new OneOrManyDrug (new DrugDrug (value)); }
            public static implicit operator OneOrManyDrug (Drug[] values) { return new OneOrManyDrug (values.Select(v => (IDrug) new DrugDrug (v))); }
            public static implicit operator OneOrManyDrug (List<Drug> values) { return new OneOrManyDrug (values.Select(v => (IDrug) new DrugDrug (v))); }
        }
        public struct DrugDrug : IDrug<Drug>
        {
            object IValue.Value => this.Value;
            public Drug Value { get; }
            public DrugDrug (Drug value) { Value = value; }
            public static implicit operator DrugDrug (Drug value) { return new DrugDrug (value); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TherapeuticProcedure";

        /// <summary>
        /// A possible complication and/or side effect of this therapy. If it is known that an adverse outcome is serious (resulting in death, disability, or permanent damage; requiring hospitalization; or is otherwise life-threatening or requires immediate medical attention), tag it as a seriouseAdverseOutcome instead.
        /// </summary>
        [DataMember(Name = "adverseOutcome", Order = 306)]
        public OneOrManyAdverseOutcome AdverseOutcome { get; set; }

        /// <summary>
        /// A dosing schedule for the drug for a given population, either observed, recommended, or maximum dose based on the type used.
        /// </summary>
        [DataMember(Name = "doseSchedule", Order = 307)]
        public OneOrManyDoseSchedule DoseSchedule { get; set; }

        /// <summary>
        /// Specifying a drug or medicine used in a medication procedure
        /// </summary>
        [DataMember(Name = "drug", Order = 308)]
        public OneOrManyDrug Drug { get; set; }

        /// <summary>
        /// A factor that indicates use of this therapy for treatment and/or prevention of a condition, symptom, etc. For therapies such as drugs, indications can include both officially-approved indications as well as off-label uses. These can be distinguished by using the ApprovedIndication subtype of MedicalIndication.
        /// </summary>
        [DataMember(Name = "indication", Order = 309)]
        public override OneOrManyIndication Indication { get; set; }
    }
}
