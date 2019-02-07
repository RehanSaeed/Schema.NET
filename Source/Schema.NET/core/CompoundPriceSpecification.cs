namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A compound price specification is one that bundles multiple prices that all apply in combination for different dimensions of consumption. Use the name property of the attached unit price specification for indicating the dimension of a price component (e.g. "electricity" or "final cleaning").
    /// </summary>
    [DataContract]
    public partial class CompoundPriceSpecification : PriceSpecification
    {
        public interface IPriceComponent : IValue {}
        public interface IPriceComponent<T> : IPriceComponent { new T Value { get; } }
        public class OneOrManyPriceComponent : OneOrMany<IPriceComponent>
        {
            public OneOrManyPriceComponent(IPriceComponent item) : base(item) { }
            public OneOrManyPriceComponent(IEnumerable<IPriceComponent> items) : base(items) { }
            public static implicit operator OneOrManyPriceComponent (UnitPriceSpecification value) { return new OneOrManyPriceComponent (new PriceComponentUnitPriceSpecification (value)); }
            public static implicit operator OneOrManyPriceComponent (UnitPriceSpecification[] values) { return new OneOrManyPriceComponent (values.Select(v => (IPriceComponent) new PriceComponentUnitPriceSpecification (v))); }
            public static implicit operator OneOrManyPriceComponent (List<UnitPriceSpecification> values) { return new OneOrManyPriceComponent (values.Select(v => (IPriceComponent) new PriceComponentUnitPriceSpecification (v))); }
        }
        public struct PriceComponentUnitPriceSpecification : IPriceComponent<UnitPriceSpecification>
        {
            object IValue.Value => this.Value;
            public UnitPriceSpecification Value { get; }
            public PriceComponentUnitPriceSpecification (UnitPriceSpecification value) { Value = value; }
            public static implicit operator PriceComponentUnitPriceSpecification (UnitPriceSpecification value) { return new PriceComponentUnitPriceSpecification (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CompoundPriceSpecification";

        /// <summary>
        /// This property links to all &lt;a class="localLink" href="http://schema.org/UnitPriceSpecification"&gt;UnitPriceSpecification&lt;/a&gt; nodes that apply in parallel for the &lt;a class="localLink" href="http://schema.org/CompoundPriceSpecification"&gt;CompoundPriceSpecification&lt;/a&gt; node.
        /// </summary>
        [DataMember(Name = "priceComponent", Order = 406)]
        public OneOrManyPriceComponent PriceComponent { get; set; }
    }
}
