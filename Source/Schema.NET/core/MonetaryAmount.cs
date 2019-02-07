namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A monetary value or range. This type can be used to describe an amount of money such as $50 USD, or a range as in describing a bank account being suitable for a balance between £1,000 and £1,000,000 GBP, or the value of a salary, etc. It is recommended to use &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; Types to describe the price of an Offer, Invoice, etc.
    /// </summary>
    [DataContract]
    public partial class MonetaryAmount : StructuredValue
    {
        public interface ICurrency : IValue {}
        public interface ICurrency<T> : ICurrency { new T Value { get; } }
        public class OneOrManyCurrency : OneOrMany<ICurrency>
        {
            public OneOrManyCurrency(ICurrency item) : base(item) { }
            public OneOrManyCurrency(IEnumerable<ICurrency> items) : base(items) { }
            public static implicit operator OneOrManyCurrency (string value) { return new OneOrManyCurrency (new Currencystring (value)); }
            public static implicit operator OneOrManyCurrency (string[] values) { return new OneOrManyCurrency (values.Select(v => (ICurrency) new Currencystring (v))); }
            public static implicit operator OneOrManyCurrency (List<string> values) { return new OneOrManyCurrency (values.Select(v => (ICurrency) new Currencystring (v))); }
        }
        public struct Currencystring : ICurrency<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Currencystring (string value) { Value = value; }
            public static implicit operator Currencystring (string value) { return new Currencystring (value); }
        }

        public interface IMaxValue : IValue {}
        public interface IMaxValue<T> : IMaxValue { new T Value { get; } }
        public class OneOrManyMaxValue : OneOrMany<IMaxValue>
        {
            public OneOrManyMaxValue(IMaxValue item) : base(item) { }
            public OneOrManyMaxValue(IEnumerable<IMaxValue> items) : base(items) { }
            public static implicit operator OneOrManyMaxValue (double value) { return new OneOrManyMaxValue (new MaxValuedouble (value)); }
            public static implicit operator OneOrManyMaxValue (double[] values) { return new OneOrManyMaxValue (values.Select(v => (IMaxValue) new MaxValuedouble (v))); }
            public static implicit operator OneOrManyMaxValue (List<double> values) { return new OneOrManyMaxValue (values.Select(v => (IMaxValue) new MaxValuedouble (v))); }
        }
        public struct MaxValuedouble : IMaxValue<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public MaxValuedouble (double value) { Value = value; }
            public static implicit operator MaxValuedouble (double value) { return new MaxValuedouble (value); }
        }

        public interface IMinValue : IValue {}
        public interface IMinValue<T> : IMinValue { new T Value { get; } }
        public class OneOrManyMinValue : OneOrMany<IMinValue>
        {
            public OneOrManyMinValue(IMinValue item) : base(item) { }
            public OneOrManyMinValue(IEnumerable<IMinValue> items) : base(items) { }
            public static implicit operator OneOrManyMinValue (double value) { return new OneOrManyMinValue (new MinValuedouble (value)); }
            public static implicit operator OneOrManyMinValue (double[] values) { return new OneOrManyMinValue (values.Select(v => (IMinValue) new MinValuedouble (v))); }
            public static implicit operator OneOrManyMinValue (List<double> values) { return new OneOrManyMinValue (values.Select(v => (IMinValue) new MinValuedouble (v))); }
        }
        public struct MinValuedouble : IMinValue<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public MinValuedouble (double value) { Value = value; }
            public static implicit operator MinValuedouble (double value) { return new MinValuedouble (value); }
        }

        public interface IValidFrom : IValue {}
        public interface IValidFrom<T> : IValidFrom { new T Value { get; } }
        public class OneOrManyValidFrom : OneOrMany<IValidFrom>
        {
            public OneOrManyValidFrom(IValidFrom item) : base(item) { }
            public OneOrManyValidFrom(IEnumerable<IValidFrom> items) : base(items) { }
            public static implicit operator OneOrManyValidFrom (DateTimeOffset value) { return new OneOrManyValidFrom (new ValidFromDateTimeOffset (value)); }
            public static implicit operator OneOrManyValidFrom (DateTimeOffset[] values) { return new OneOrManyValidFrom (values.Select(v => (IValidFrom) new ValidFromDateTimeOffset (v))); }
            public static implicit operator OneOrManyValidFrom (List<DateTimeOffset> values) { return new OneOrManyValidFrom (values.Select(v => (IValidFrom) new ValidFromDateTimeOffset (v))); }
        }
        public struct ValidFromDateTimeOffset : IValidFrom<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public ValidFromDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator ValidFromDateTimeOffset (DateTimeOffset value) { return new ValidFromDateTimeOffset (value); }
        }

        public interface IValidThrough : IValue {}
        public interface IValidThrough<T> : IValidThrough { new T Value { get; } }
        public class OneOrManyValidThrough : OneOrMany<IValidThrough>
        {
            public OneOrManyValidThrough(IValidThrough item) : base(item) { }
            public OneOrManyValidThrough(IEnumerable<IValidThrough> items) : base(items) { }
            public static implicit operator OneOrManyValidThrough (DateTimeOffset value) { return new OneOrManyValidThrough (new ValidThroughDateTimeOffset (value)); }
            public static implicit operator OneOrManyValidThrough (DateTimeOffset[] values) { return new OneOrManyValidThrough (values.Select(v => (IValidThrough) new ValidThroughDateTimeOffset (v))); }
            public static implicit operator OneOrManyValidThrough (List<DateTimeOffset> values) { return new OneOrManyValidThrough (values.Select(v => (IValidThrough) new ValidThroughDateTimeOffset (v))); }
        }
        public struct ValidThroughDateTimeOffset : IValidThrough<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public ValidThroughDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator ValidThroughDateTimeOffset (DateTimeOffset value) { return new ValidThroughDateTimeOffset (value); }
        }

        public interface IAValue : IValue {}
        public interface IAValue<T> : IAValue { new T Value { get; } }
        public class OneOrManyAValue : OneOrMany<IAValue>
        {
            public OneOrManyAValue(IAValue item) : base(item) { }
            public OneOrManyAValue(IEnumerable<IAValue> items) : base(items) { }
            public static implicit operator OneOrManyAValue (bool value) { return new OneOrManyAValue (new AValuebool (value)); }
            public static implicit operator OneOrManyAValue (bool[] values) { return new OneOrManyAValue (values.Select(v => (IAValue) new AValuebool (v))); }
            public static implicit operator OneOrManyAValue (List<bool> values) { return new OneOrManyAValue (values.Select(v => (IAValue) new AValuebool (v))); }
            public static implicit operator OneOrManyAValue (double value) { return new OneOrManyAValue (new AValuedouble (value)); }
            public static implicit operator OneOrManyAValue (double[] values) { return new OneOrManyAValue (values.Select(v => (IAValue) new AValuedouble (v))); }
            public static implicit operator OneOrManyAValue (List<double> values) { return new OneOrManyAValue (values.Select(v => (IAValue) new AValuedouble (v))); }
            public static implicit operator OneOrManyAValue (StructuredValue value) { return new OneOrManyAValue (new AValueStructuredValue (value)); }
            public static implicit operator OneOrManyAValue (StructuredValue[] values) { return new OneOrManyAValue (values.Select(v => (IAValue) new AValueStructuredValue (v))); }
            public static implicit operator OneOrManyAValue (List<StructuredValue> values) { return new OneOrManyAValue (values.Select(v => (IAValue) new AValueStructuredValue (v))); }
            public static implicit operator OneOrManyAValue (string value) { return new OneOrManyAValue (new AValuestring (value)); }
            public static implicit operator OneOrManyAValue (string[] values) { return new OneOrManyAValue (values.Select(v => (IAValue) new AValuestring (v))); }
            public static implicit operator OneOrManyAValue (List<string> values) { return new OneOrManyAValue (values.Select(v => (IAValue) new AValuestring (v))); }
        }
        public struct AValuebool : IAValue<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public AValuebool (bool value) { Value = value; }
            public static implicit operator AValuebool (bool value) { return new AValuebool (value); }
        }
        public struct AValuedouble : IAValue<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public AValuedouble (double value) { Value = value; }
            public static implicit operator AValuedouble (double value) { return new AValuedouble (value); }
        }
        public struct AValueStructuredValue : IAValue<StructuredValue>
        {
            object IValue.Value => this.Value;
            public StructuredValue Value { get; }
            public AValueStructuredValue (StructuredValue value) { Value = value; }
            public static implicit operator AValueStructuredValue (StructuredValue value) { return new AValueStructuredValue (value); }
        }
        public struct AValuestring : IAValue<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AValuestring (string value) { Value = value; }
            public static implicit operator AValuestring (string value) { return new AValuestring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MonetaryAmount";

        /// <summary>
        /// The currency in which the monetary amount is expressed.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        [DataMember(Name = "currency", Order = 306)]
        public OneOrManyCurrency Currency { get; set; }

        /// <summary>
        /// The upper value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "maxValue", Order = 307)]
        public OneOrManyMaxValue MaxValue { get; set; }

        /// <summary>
        /// The lower value of some characteristic or property.
        /// </summary>
        [DataMember(Name = "minValue", Order = 308)]
        public OneOrManyMinValue MinValue { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [DataMember(Name = "validFrom", Order = 309)]
        public OneOrManyValidFrom ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough", Order = 310)]
        public OneOrManyValidThrough ValidThrough { get; set; }

        /// <summary>
        /// The value of the quantitative value or property value node.&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;For &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt;, the recommended type for values is 'Number'.&lt;/li&gt;
        /// &lt;li&gt;For &lt;a class="localLink" href="http://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt;, it can be 'Text;', 'Number', 'Boolean', or 'StructuredValue'.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "value", Order = 311)]
        public OneOrManyAValue Value { get; set; }
    }
}
