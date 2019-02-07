namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A type of blood vessel that specifically carries blood away from the heart.
    /// </summary>
    [DataContract]
    public partial class Artery : Vessel
    {
        public interface IArterialBranch : IValue {}
        public interface IArterialBranch<T> : IArterialBranch { new T Value { get; } }
        public class OneOrManyArterialBranch : OneOrMany<IArterialBranch>
        {
            public OneOrManyArterialBranch(IArterialBranch item) : base(item) { }
            public OneOrManyArterialBranch(IEnumerable<IArterialBranch> items) : base(items) { }
            public static implicit operator OneOrManyArterialBranch (AnatomicalStructure value) { return new OneOrManyArterialBranch (new ArterialBranchAnatomicalStructure (value)); }
            public static implicit operator OneOrManyArterialBranch (AnatomicalStructure[] values) { return new OneOrManyArterialBranch (values.Select(v => (IArterialBranch) new ArterialBranchAnatomicalStructure (v))); }
            public static implicit operator OneOrManyArterialBranch (List<AnatomicalStructure> values) { return new OneOrManyArterialBranch (values.Select(v => (IArterialBranch) new ArterialBranchAnatomicalStructure (v))); }
        }
        public struct ArterialBranchAnatomicalStructure : IArterialBranch<AnatomicalStructure>
        {
            object IValue.Value => this.Value;
            public AnatomicalStructure Value { get; }
            public ArterialBranchAnatomicalStructure (AnatomicalStructure value) { Value = value; }
            public static implicit operator ArterialBranchAnatomicalStructure (AnatomicalStructure value) { return new ArterialBranchAnatomicalStructure (value); }
        }

        public interface ISource : IValue {}
        public interface ISource<T> : ISource { new T Value { get; } }
        public class OneOrManySource : OneOrMany<ISource>
        {
            public OneOrManySource(ISource item) : base(item) { }
            public OneOrManySource(IEnumerable<ISource> items) : base(items) { }
            public static implicit operator OneOrManySource (AnatomicalStructure value) { return new OneOrManySource (new SourceAnatomicalStructure (value)); }
            public static implicit operator OneOrManySource (AnatomicalStructure[] values) { return new OneOrManySource (values.Select(v => (ISource) new SourceAnatomicalStructure (v))); }
            public static implicit operator OneOrManySource (List<AnatomicalStructure> values) { return new OneOrManySource (values.Select(v => (ISource) new SourceAnatomicalStructure (v))); }
        }
        public struct SourceAnatomicalStructure : ISource<AnatomicalStructure>
        {
            object IValue.Value => this.Value;
            public AnatomicalStructure Value { get; }
            public SourceAnatomicalStructure (AnatomicalStructure value) { Value = value; }
            public static implicit operator SourceAnatomicalStructure (AnatomicalStructure value) { return new SourceAnatomicalStructure (value); }
        }

        public interface ISupplyTo : IValue {}
        public interface ISupplyTo<T> : ISupplyTo { new T Value { get; } }
        public class OneOrManySupplyTo : OneOrMany<ISupplyTo>
        {
            public OneOrManySupplyTo(ISupplyTo item) : base(item) { }
            public OneOrManySupplyTo(IEnumerable<ISupplyTo> items) : base(items) { }
            public static implicit operator OneOrManySupplyTo (AnatomicalStructure value) { return new OneOrManySupplyTo (new SupplyToAnatomicalStructure (value)); }
            public static implicit operator OneOrManySupplyTo (AnatomicalStructure[] values) { return new OneOrManySupplyTo (values.Select(v => (ISupplyTo) new SupplyToAnatomicalStructure (v))); }
            public static implicit operator OneOrManySupplyTo (List<AnatomicalStructure> values) { return new OneOrManySupplyTo (values.Select(v => (ISupplyTo) new SupplyToAnatomicalStructure (v))); }
        }
        public struct SupplyToAnatomicalStructure : ISupplyTo<AnatomicalStructure>
        {
            object IValue.Value => this.Value;
            public AnatomicalStructure Value { get; }
            public SupplyToAnatomicalStructure (AnatomicalStructure value) { Value = value; }
            public static implicit operator SupplyToAnatomicalStructure (AnatomicalStructure value) { return new SupplyToAnatomicalStructure (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Artery";

        /// <summary>
        /// The branches that comprise the arterial structure.
        /// </summary>
        [DataMember(Name = "arterialBranch", Order = 406)]
        public OneOrManyArterialBranch ArterialBranch { get; set; }

        /// <summary>
        /// The anatomical or organ system that the artery originates from.
        /// </summary>
        [DataMember(Name = "source", Order = 407)]
        public OneOrManySource Source { get; set; }

        /// <summary>
        /// The area to which the artery supplies blood.
        /// </summary>
        [DataMember(Name = "supplyTo", Order = 408)]
        public OneOrManySupplyTo SupplyTo { get; set; }
    }
}
