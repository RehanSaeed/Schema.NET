namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A supply consumed when performing the instructions for how to achieve a result.
    /// </summary>
    [DataContract]
    public partial class HowToSupply : HowToItem
    {
        public interface IEstimatedCost : IValue {}
        public interface IEstimatedCost<T> : IEstimatedCost { new T Value { get; } }
        public class OneOrManyEstimatedCost : OneOrMany<IEstimatedCost>
        {
            public OneOrManyEstimatedCost(IEstimatedCost item) : base(item) { }
            public OneOrManyEstimatedCost(IEnumerable<IEstimatedCost> items) : base(items) { }
            public static implicit operator OneOrManyEstimatedCost (MonetaryAmount value) { return new OneOrManyEstimatedCost (new EstimatedCostMonetaryAmount (value)); }
            public static implicit operator OneOrManyEstimatedCost (MonetaryAmount[] values) { return new OneOrManyEstimatedCost (values.Select(v => (IEstimatedCost) new EstimatedCostMonetaryAmount (v))); }
            public static implicit operator OneOrManyEstimatedCost (List<MonetaryAmount> values) { return new OneOrManyEstimatedCost (values.Select(v => (IEstimatedCost) new EstimatedCostMonetaryAmount (v))); }
            public static implicit operator OneOrManyEstimatedCost (string value) { return new OneOrManyEstimatedCost (new EstimatedCoststring (value)); }
            public static implicit operator OneOrManyEstimatedCost (string[] values) { return new OneOrManyEstimatedCost (values.Select(v => (IEstimatedCost) new EstimatedCoststring (v))); }
            public static implicit operator OneOrManyEstimatedCost (List<string> values) { return new OneOrManyEstimatedCost (values.Select(v => (IEstimatedCost) new EstimatedCoststring (v))); }
        }
        public struct EstimatedCostMonetaryAmount : IEstimatedCost<MonetaryAmount>
        {
            object IValue.Value => this.Value;
            public MonetaryAmount Value { get; }
            public EstimatedCostMonetaryAmount (MonetaryAmount value) { Value = value; }
            public static implicit operator EstimatedCostMonetaryAmount (MonetaryAmount value) { return new EstimatedCostMonetaryAmount (value); }
        }
        public struct EstimatedCoststring : IEstimatedCost<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public EstimatedCoststring (string value) { Value = value; }
            public static implicit operator EstimatedCoststring (string value) { return new EstimatedCoststring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HowToSupply";

        /// <summary>
        /// The estimated cost of the supply or supplies consumed when performing instructions.
        /// </summary>
        [DataMember(Name = "estimatedCost", Order = 406)]
        public OneOrManyEstimatedCost EstimatedCost { get; set; }
    }
}
