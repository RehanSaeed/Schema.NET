namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A type of blood vessel that specifically carries lymph fluid unidirectionally toward the heart.
    /// </summary>
    [DataContract]
    public partial class LymphaticVessel : Vessel
    {
        public interface IOriginatesFrom : IValue {}
        public interface IOriginatesFrom<T> : IOriginatesFrom { new T Value { get; } }
        public class OneOrManyOriginatesFrom : OneOrMany<IOriginatesFrom>
        {
            public OneOrManyOriginatesFrom(IOriginatesFrom item) : base(item) { }
            public OneOrManyOriginatesFrom(IEnumerable<IOriginatesFrom> items) : base(items) { }
            public static implicit operator OneOrManyOriginatesFrom (Vessel value) { return new OneOrManyOriginatesFrom (new OriginatesFromVessel (value)); }
            public static implicit operator OneOrManyOriginatesFrom (Vessel[] values) { return new OneOrManyOriginatesFrom (values.Select(v => (IOriginatesFrom) new OriginatesFromVessel (v))); }
            public static implicit operator OneOrManyOriginatesFrom (List<Vessel> values) { return new OneOrManyOriginatesFrom (values.Select(v => (IOriginatesFrom) new OriginatesFromVessel (v))); }
        }
        public struct OriginatesFromVessel : IOriginatesFrom<Vessel>
        {
            object IValue.Value => this.Value;
            public Vessel Value { get; }
            public OriginatesFromVessel (Vessel value) { Value = value; }
            public static implicit operator OriginatesFromVessel (Vessel value) { return new OriginatesFromVessel (value); }
        }

        public interface IRegionDrained : IValue {}
        public interface IRegionDrained<T> : IRegionDrained { new T Value { get; } }
        public class OneOrManyRegionDrained : OneOrMany<IRegionDrained>
        {
            public OneOrManyRegionDrained(IRegionDrained item) : base(item) { }
            public OneOrManyRegionDrained(IEnumerable<IRegionDrained> items) : base(items) { }
            public static implicit operator OneOrManyRegionDrained (AnatomicalStructure value) { return new OneOrManyRegionDrained (new RegionDrainedAnatomicalStructure (value)); }
            public static implicit operator OneOrManyRegionDrained (AnatomicalStructure[] values) { return new OneOrManyRegionDrained (values.Select(v => (IRegionDrained) new RegionDrainedAnatomicalStructure (v))); }
            public static implicit operator OneOrManyRegionDrained (List<AnatomicalStructure> values) { return new OneOrManyRegionDrained (values.Select(v => (IRegionDrained) new RegionDrainedAnatomicalStructure (v))); }
            public static implicit operator OneOrManyRegionDrained (AnatomicalSystem value) { return new OneOrManyRegionDrained (new RegionDrainedAnatomicalSystem (value)); }
            public static implicit operator OneOrManyRegionDrained (AnatomicalSystem[] values) { return new OneOrManyRegionDrained (values.Select(v => (IRegionDrained) new RegionDrainedAnatomicalSystem (v))); }
            public static implicit operator OneOrManyRegionDrained (List<AnatomicalSystem> values) { return new OneOrManyRegionDrained (values.Select(v => (IRegionDrained) new RegionDrainedAnatomicalSystem (v))); }
        }
        public struct RegionDrainedAnatomicalStructure : IRegionDrained<AnatomicalStructure>
        {
            object IValue.Value => this.Value;
            public AnatomicalStructure Value { get; }
            public RegionDrainedAnatomicalStructure (AnatomicalStructure value) { Value = value; }
            public static implicit operator RegionDrainedAnatomicalStructure (AnatomicalStructure value) { return new RegionDrainedAnatomicalStructure (value); }
        }
        public struct RegionDrainedAnatomicalSystem : IRegionDrained<AnatomicalSystem>
        {
            object IValue.Value => this.Value;
            public AnatomicalSystem Value { get; }
            public RegionDrainedAnatomicalSystem (AnatomicalSystem value) { Value = value; }
            public static implicit operator RegionDrainedAnatomicalSystem (AnatomicalSystem value) { return new RegionDrainedAnatomicalSystem (value); }
        }

        public interface IRunsTo : IValue {}
        public interface IRunsTo<T> : IRunsTo { new T Value { get; } }
        public class OneOrManyRunsTo : OneOrMany<IRunsTo>
        {
            public OneOrManyRunsTo(IRunsTo item) : base(item) { }
            public OneOrManyRunsTo(IEnumerable<IRunsTo> items) : base(items) { }
            public static implicit operator OneOrManyRunsTo (Vessel value) { return new OneOrManyRunsTo (new RunsToVessel (value)); }
            public static implicit operator OneOrManyRunsTo (Vessel[] values) { return new OneOrManyRunsTo (values.Select(v => (IRunsTo) new RunsToVessel (v))); }
            public static implicit operator OneOrManyRunsTo (List<Vessel> values) { return new OneOrManyRunsTo (values.Select(v => (IRunsTo) new RunsToVessel (v))); }
        }
        public struct RunsToVessel : IRunsTo<Vessel>
        {
            object IValue.Value => this.Value;
            public Vessel Value { get; }
            public RunsToVessel (Vessel value) { Value = value; }
            public static implicit operator RunsToVessel (Vessel value) { return new RunsToVessel (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LymphaticVessel";

        /// <summary>
        /// The vasculature the lymphatic structure originates, or afferents, from.
        /// </summary>
        [DataMember(Name = "originatesFrom", Order = 406)]
        public OneOrManyOriginatesFrom OriginatesFrom { get; set; }

        /// <summary>
        /// The anatomical or organ system drained by this vessel; generally refers to a specific part of an organ.
        /// </summary>
        [DataMember(Name = "regionDrained", Order = 407)]
        public OneOrManyRegionDrained RegionDrained { get; set; }

        /// <summary>
        /// The vasculature the lymphatic structure runs, or efferents, to.
        /// </summary>
        [DataMember(Name = "runsTo", Order = 408)]
        public OneOrManyRunsTo RunsTo { get; set; }
    }
}
