namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A common pathway for the electrochemical nerve impulses that are transmitted along each of the axons.
    /// </summary>
    [DataContract]
    public partial class Nerve : AnatomicalStructure
    {
        public interface INerveMotor : IValue {}
        public interface INerveMotor<T> : INerveMotor { new T Value { get; } }
        public class OneOrManyNerveMotor : OneOrMany<INerveMotor>
        {
            public OneOrManyNerveMotor(INerveMotor item) : base(item) { }
            public OneOrManyNerveMotor(IEnumerable<INerveMotor> items) : base(items) { }
            public static implicit operator OneOrManyNerveMotor (Muscle value) { return new OneOrManyNerveMotor (new NerveMotorMuscle (value)); }
            public static implicit operator OneOrManyNerveMotor (Muscle[] values) { return new OneOrManyNerveMotor (values.Select(v => (INerveMotor) new NerveMotorMuscle (v))); }
            public static implicit operator OneOrManyNerveMotor (List<Muscle> values) { return new OneOrManyNerveMotor (values.Select(v => (INerveMotor) new NerveMotorMuscle (v))); }
        }
        public struct NerveMotorMuscle : INerveMotor<Muscle>
        {
            object IValue.Value => this.Value;
            public Muscle Value { get; }
            public NerveMotorMuscle (Muscle value) { Value = value; }
            public static implicit operator NerveMotorMuscle (Muscle value) { return new NerveMotorMuscle (value); }
        }

        public interface ISensoryUnit : IValue {}
        public interface ISensoryUnit<T> : ISensoryUnit { new T Value { get; } }
        public class OneOrManySensoryUnit : OneOrMany<ISensoryUnit>
        {
            public OneOrManySensoryUnit(ISensoryUnit item) : base(item) { }
            public OneOrManySensoryUnit(IEnumerable<ISensoryUnit> items) : base(items) { }
            public static implicit operator OneOrManySensoryUnit (AnatomicalStructure value) { return new OneOrManySensoryUnit (new SensoryUnitAnatomicalStructure (value)); }
            public static implicit operator OneOrManySensoryUnit (AnatomicalStructure[] values) { return new OneOrManySensoryUnit (values.Select(v => (ISensoryUnit) new SensoryUnitAnatomicalStructure (v))); }
            public static implicit operator OneOrManySensoryUnit (List<AnatomicalStructure> values) { return new OneOrManySensoryUnit (values.Select(v => (ISensoryUnit) new SensoryUnitAnatomicalStructure (v))); }
            public static implicit operator OneOrManySensoryUnit (SuperficialAnatomy value) { return new OneOrManySensoryUnit (new SensoryUnitSuperficialAnatomy (value)); }
            public static implicit operator OneOrManySensoryUnit (SuperficialAnatomy[] values) { return new OneOrManySensoryUnit (values.Select(v => (ISensoryUnit) new SensoryUnitSuperficialAnatomy (v))); }
            public static implicit operator OneOrManySensoryUnit (List<SuperficialAnatomy> values) { return new OneOrManySensoryUnit (values.Select(v => (ISensoryUnit) new SensoryUnitSuperficialAnatomy (v))); }
        }
        public struct SensoryUnitAnatomicalStructure : ISensoryUnit<AnatomicalStructure>
        {
            object IValue.Value => this.Value;
            public AnatomicalStructure Value { get; }
            public SensoryUnitAnatomicalStructure (AnatomicalStructure value) { Value = value; }
            public static implicit operator SensoryUnitAnatomicalStructure (AnatomicalStructure value) { return new SensoryUnitAnatomicalStructure (value); }
        }
        public struct SensoryUnitSuperficialAnatomy : ISensoryUnit<SuperficialAnatomy>
        {
            object IValue.Value => this.Value;
            public SuperficialAnatomy Value { get; }
            public SensoryUnitSuperficialAnatomy (SuperficialAnatomy value) { Value = value; }
            public static implicit operator SensoryUnitSuperficialAnatomy (SuperficialAnatomy value) { return new SensoryUnitSuperficialAnatomy (value); }
        }

        public interface ISourcedFrom : IValue {}
        public interface ISourcedFrom<T> : ISourcedFrom { new T Value { get; } }
        public class OneOrManySourcedFrom : OneOrMany<ISourcedFrom>
        {
            public OneOrManySourcedFrom(ISourcedFrom item) : base(item) { }
            public OneOrManySourcedFrom(IEnumerable<ISourcedFrom> items) : base(items) { }
            public static implicit operator OneOrManySourcedFrom (BrainStructure value) { return new OneOrManySourcedFrom (new SourcedFromBrainStructure (value)); }
            public static implicit operator OneOrManySourcedFrom (BrainStructure[] values) { return new OneOrManySourcedFrom (values.Select(v => (ISourcedFrom) new SourcedFromBrainStructure (v))); }
            public static implicit operator OneOrManySourcedFrom (List<BrainStructure> values) { return new OneOrManySourcedFrom (values.Select(v => (ISourcedFrom) new SourcedFromBrainStructure (v))); }
        }
        public struct SourcedFromBrainStructure : ISourcedFrom<BrainStructure>
        {
            object IValue.Value => this.Value;
            public BrainStructure Value { get; }
            public SourcedFromBrainStructure (BrainStructure value) { Value = value; }
            public static implicit operator SourcedFromBrainStructure (BrainStructure value) { return new SourcedFromBrainStructure (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Nerve";

        /// <summary>
        /// The neurological pathway extension that involves muscle control.
        /// </summary>
        [DataMember(Name = "nerveMotor", Order = 306)]
        public OneOrManyNerveMotor NerveMotor { get; set; }

        /// <summary>
        /// The neurological pathway extension that inputs and sends information to the brain or spinal cord.
        /// </summary>
        [DataMember(Name = "sensoryUnit", Order = 307)]
        public OneOrManySensoryUnit SensoryUnit { get; set; }

        /// <summary>
        /// The neurological pathway that originates the neurons.
        /// </summary>
        [DataMember(Name = "sourcedFrom", Order = 308)]
        public OneOrManySourcedFrom SourcedFrom { get; set; }
    }
}
