namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A type of blood vessel that specifically carries blood to the heart.
    /// </summary>
    [DataContract]
    public partial class Vein : Vessel
    {
        public interface IDrainsTo : IValue {}
        public interface IDrainsTo<T> : IDrainsTo { new T Value { get; } }
        public class OneOrManyDrainsTo : OneOrMany<IDrainsTo>
        {
            public OneOrManyDrainsTo(IDrainsTo item) : base(item) { }
            public OneOrManyDrainsTo(IEnumerable<IDrainsTo> items) : base(items) { }
            public static implicit operator OneOrManyDrainsTo (Vessel value) { return new OneOrManyDrainsTo (new DrainsToVessel (value)); }
            public static implicit operator OneOrManyDrainsTo (Vessel[] values) { return new OneOrManyDrainsTo (values.Select(v => (IDrainsTo) new DrainsToVessel (v))); }
            public static implicit operator OneOrManyDrainsTo (List<Vessel> values) { return new OneOrManyDrainsTo (values.Select(v => (IDrainsTo) new DrainsToVessel (v))); }
        }
        public struct DrainsToVessel : IDrainsTo<Vessel>
        {
            object IValue.Value => this.Value;
            public Vessel Value { get; }
            public DrainsToVessel (Vessel value) { Value = value; }
            public static implicit operator DrainsToVessel (Vessel value) { return new DrainsToVessel (value); }
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

        public interface ITributary : IValue {}
        public interface ITributary<T> : ITributary { new T Value { get; } }
        public class OneOrManyTributary : OneOrMany<ITributary>
        {
            public OneOrManyTributary(ITributary item) : base(item) { }
            public OneOrManyTributary(IEnumerable<ITributary> items) : base(items) { }
            public static implicit operator OneOrManyTributary (AnatomicalStructure value) { return new OneOrManyTributary (new TributaryAnatomicalStructure (value)); }
            public static implicit operator OneOrManyTributary (AnatomicalStructure[] values) { return new OneOrManyTributary (values.Select(v => (ITributary) new TributaryAnatomicalStructure (v))); }
            public static implicit operator OneOrManyTributary (List<AnatomicalStructure> values) { return new OneOrManyTributary (values.Select(v => (ITributary) new TributaryAnatomicalStructure (v))); }
        }
        public struct TributaryAnatomicalStructure : ITributary<AnatomicalStructure>
        {
            object IValue.Value => this.Value;
            public AnatomicalStructure Value { get; }
            public TributaryAnatomicalStructure (AnatomicalStructure value) { Value = value; }
            public static implicit operator TributaryAnatomicalStructure (AnatomicalStructure value) { return new TributaryAnatomicalStructure (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Vein";

        /// <summary>
        /// The vasculature that the vein drains into.
        /// </summary>
        [DataMember(Name = "drainsTo", Order = 406)]
        public OneOrManyDrainsTo DrainsTo { get; set; }

        /// <summary>
        /// The anatomical or organ system drained by this vessel; generally refers to a specific part of an organ.
        /// </summary>
        [DataMember(Name = "regionDrained", Order = 407)]
        public OneOrManyRegionDrained RegionDrained { get; set; }

        /// <summary>
        /// The anatomical or organ system that the vein flows into; a larger structure that the vein connects to.
        /// </summary>
        [DataMember(Name = "tributary", Order = 408)]
        public OneOrManyTributary Tributary { get; set; }
    }
}
