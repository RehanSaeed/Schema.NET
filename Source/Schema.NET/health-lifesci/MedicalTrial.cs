namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A medical trial is a type of medical study that uses scientific process used to compare the safety and efficacy of medical therapies or medical procedures. In general, medical trials are controlled and subjects are allocated at random to the different treatment and/or control groups.
    /// </summary>
    [DataContract]
    public partial class MedicalTrial : MedicalStudy
    {
        public interface IPhase : IValue {}
        public interface IPhase<T> : IPhase { new T Value { get; } }
        public class OneOrManyPhase : OneOrMany<IPhase>
        {
            public OneOrManyPhase(IPhase item) : base(item) { }
            public OneOrManyPhase(IEnumerable<IPhase> items) : base(items) { }
            public static implicit operator OneOrManyPhase (string value) { return new OneOrManyPhase (new Phasestring (value)); }
            public static implicit operator OneOrManyPhase (string[] values) { return new OneOrManyPhase (values.Select(v => (IPhase) new Phasestring (v))); }
            public static implicit operator OneOrManyPhase (List<string> values) { return new OneOrManyPhase (values.Select(v => (IPhase) new Phasestring (v))); }
        }
        public struct Phasestring : IPhase<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Phasestring (string value) { Value = value; }
            public static implicit operator Phasestring (string value) { return new Phasestring (value); }
        }

        public interface ITrialDesign : IValue {}
        public interface ITrialDesign<T> : ITrialDesign { new T Value { get; } }
        public class OneOrManyTrialDesign : OneOrMany<ITrialDesign>
        {
            public OneOrManyTrialDesign(ITrialDesign item) : base(item) { }
            public OneOrManyTrialDesign(IEnumerable<ITrialDesign> items) : base(items) { }
            public static implicit operator OneOrManyTrialDesign (MedicalTrialDesign value) { return new OneOrManyTrialDesign (new TrialDesignMedicalTrialDesign (value)); }
            public static implicit operator OneOrManyTrialDesign (MedicalTrialDesign[] values) { return new OneOrManyTrialDesign (values.Select(v => (ITrialDesign) new TrialDesignMedicalTrialDesign (v))); }
            public static implicit operator OneOrManyTrialDesign (List<MedicalTrialDesign> values) { return new OneOrManyTrialDesign (values.Select(v => (ITrialDesign) new TrialDesignMedicalTrialDesign (v))); }
        }
        public struct TrialDesignMedicalTrialDesign : ITrialDesign<MedicalTrialDesign>
        {
            object IValue.Value => this.Value;
            public MedicalTrialDesign Value { get; }
            public TrialDesignMedicalTrialDesign (MedicalTrialDesign value) { Value = value; }
            public static implicit operator TrialDesignMedicalTrialDesign (MedicalTrialDesign value) { return new TrialDesignMedicalTrialDesign (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalTrial";

        /// <summary>
        /// The phase of the clinical trial.
        /// </summary>
        [DataMember(Name = "phase", Order = 306)]
        public OneOrManyPhase Phase { get; set; }

        /// <summary>
        /// Specifics about the trial design (enumerated).
        /// </summary>
        [DataMember(Name = "trialDesign", Order = 307)]
        public OneOrManyTrialDesign TrialDesign { get; set; }
    }
}
