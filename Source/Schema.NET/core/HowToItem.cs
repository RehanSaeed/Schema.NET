namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An item used as either a tool or supply when performing the instructions for how to to achieve a result.
    /// </summary>
    [DataContract]
    public partial class HowToItem : ListItem
    {
        public interface IRequiredQuantity : IValue {}
        public interface IRequiredQuantity<T> : IRequiredQuantity { new T Value { get; } }
        public class OneOrManyRequiredQuantity : OneOrMany<IRequiredQuantity>
        {
            public OneOrManyRequiredQuantity(IRequiredQuantity item) : base(item) { }
            public OneOrManyRequiredQuantity(IEnumerable<IRequiredQuantity> items) : base(items) { }
            public static implicit operator OneOrManyRequiredQuantity (double value) { return new OneOrManyRequiredQuantity (new RequiredQuantitydouble (value)); }
            public static implicit operator OneOrManyRequiredQuantity (double[] values) { return new OneOrManyRequiredQuantity (values.Select(v => (IRequiredQuantity) new RequiredQuantitydouble (v))); }
            public static implicit operator OneOrManyRequiredQuantity (List<double> values) { return new OneOrManyRequiredQuantity (values.Select(v => (IRequiredQuantity) new RequiredQuantitydouble (v))); }
            public static implicit operator OneOrManyRequiredQuantity (QuantitativeValue value) { return new OneOrManyRequiredQuantity (new RequiredQuantityQuantitativeValue (value)); }
            public static implicit operator OneOrManyRequiredQuantity (QuantitativeValue[] values) { return new OneOrManyRequiredQuantity (values.Select(v => (IRequiredQuantity) new RequiredQuantityQuantitativeValue (v))); }
            public static implicit operator OneOrManyRequiredQuantity (List<QuantitativeValue> values) { return new OneOrManyRequiredQuantity (values.Select(v => (IRequiredQuantity) new RequiredQuantityQuantitativeValue (v))); }
            public static implicit operator OneOrManyRequiredQuantity (string value) { return new OneOrManyRequiredQuantity (new RequiredQuantitystring (value)); }
            public static implicit operator OneOrManyRequiredQuantity (string[] values) { return new OneOrManyRequiredQuantity (values.Select(v => (IRequiredQuantity) new RequiredQuantitystring (v))); }
            public static implicit operator OneOrManyRequiredQuantity (List<string> values) { return new OneOrManyRequiredQuantity (values.Select(v => (IRequiredQuantity) new RequiredQuantitystring (v))); }
        }
        public struct RequiredQuantitydouble : IRequiredQuantity<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public RequiredQuantitydouble (double value) { Value = value; }
            public static implicit operator RequiredQuantitydouble (double value) { return new RequiredQuantitydouble (value); }
        }
        public struct RequiredQuantityQuantitativeValue : IRequiredQuantity<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public RequiredQuantityQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator RequiredQuantityQuantitativeValue (QuantitativeValue value) { return new RequiredQuantityQuantitativeValue (value); }
        }
        public struct RequiredQuantitystring : IRequiredQuantity<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public RequiredQuantitystring (string value) { Value = value; }
            public static implicit operator RequiredQuantitystring (string value) { return new RequiredQuantitystring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HowToItem";

        /// <summary>
        /// The required quantity of the item(s).
        /// </summary>
        [DataMember(Name = "requiredQuantity", Order = 306)]
        public OneOrManyRequiredQuantity RequiredQuantity { get; set; }
    }
}
