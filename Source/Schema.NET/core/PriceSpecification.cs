namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup. It is recommended to use &lt;a class="localLink" href="http://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt; to describe independent amounts of money such as a salary, credit card limits, etc.
    /// </summary>
    [DataContract]
    public partial class PriceSpecification : StructuredValue
    {
        public interface IEligibleQuantity : IValue {}
        public interface IEligibleQuantity<T> : IEligibleQuantity { new T Value { get; } }
        public class OneOrManyEligibleQuantity : OneOrMany<IEligibleQuantity>
        {
            public OneOrManyEligibleQuantity(IEligibleQuantity item) : base(item) { }
            public OneOrManyEligibleQuantity(IEnumerable<IEligibleQuantity> items) : base(items) { }
            public static implicit operator OneOrManyEligibleQuantity (QuantitativeValue value) { return new OneOrManyEligibleQuantity (new EligibleQuantityQuantitativeValue (value)); }
            public static implicit operator OneOrManyEligibleQuantity (QuantitativeValue[] values) { return new OneOrManyEligibleQuantity (values.Select(v => (IEligibleQuantity) new EligibleQuantityQuantitativeValue (v))); }
            public static implicit operator OneOrManyEligibleQuantity (List<QuantitativeValue> values) { return new OneOrManyEligibleQuantity (values.Select(v => (IEligibleQuantity) new EligibleQuantityQuantitativeValue (v))); }
        }
        public struct EligibleQuantityQuantitativeValue : IEligibleQuantity<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public EligibleQuantityQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator EligibleQuantityQuantitativeValue (QuantitativeValue value) { return new EligibleQuantityQuantitativeValue (value); }
        }

        public interface IEligibleTransactionVolume : IValue {}
        public interface IEligibleTransactionVolume<T> : IEligibleTransactionVolume { new T Value { get; } }
        public class OneOrManyEligibleTransactionVolume : OneOrMany<IEligibleTransactionVolume>
        {
            public OneOrManyEligibleTransactionVolume(IEligibleTransactionVolume item) : base(item) { }
            public OneOrManyEligibleTransactionVolume(IEnumerable<IEligibleTransactionVolume> items) : base(items) { }
            public static implicit operator OneOrManyEligibleTransactionVolume (PriceSpecification value) { return new OneOrManyEligibleTransactionVolume (new EligibleTransactionVolumePriceSpecification (value)); }
            public static implicit operator OneOrManyEligibleTransactionVolume (PriceSpecification[] values) { return new OneOrManyEligibleTransactionVolume (values.Select(v => (IEligibleTransactionVolume) new EligibleTransactionVolumePriceSpecification (v))); }
            public static implicit operator OneOrManyEligibleTransactionVolume (List<PriceSpecification> values) { return new OneOrManyEligibleTransactionVolume (values.Select(v => (IEligibleTransactionVolume) new EligibleTransactionVolumePriceSpecification (v))); }
        }
        public struct EligibleTransactionVolumePriceSpecification : IEligibleTransactionVolume<PriceSpecification>
        {
            object IValue.Value => this.Value;
            public PriceSpecification Value { get; }
            public EligibleTransactionVolumePriceSpecification (PriceSpecification value) { Value = value; }
            public static implicit operator EligibleTransactionVolumePriceSpecification (PriceSpecification value) { return new EligibleTransactionVolumePriceSpecification (value); }
        }

        public interface IMaxPrice : IValue {}
        public interface IMaxPrice<T> : IMaxPrice { new T Value { get; } }
        public class OneOrManyMaxPrice : OneOrMany<IMaxPrice>
        {
            public OneOrManyMaxPrice(IMaxPrice item) : base(item) { }
            public OneOrManyMaxPrice(IEnumerable<IMaxPrice> items) : base(items) { }
            public static implicit operator OneOrManyMaxPrice (decimal value) { return new OneOrManyMaxPrice (new MaxPricedecimal (value)); }
            public static implicit operator OneOrManyMaxPrice (decimal[] values) { return new OneOrManyMaxPrice (values.Select(v => (IMaxPrice) new MaxPricedecimal (v))); }
            public static implicit operator OneOrManyMaxPrice (List<decimal> values) { return new OneOrManyMaxPrice (values.Select(v => (IMaxPrice) new MaxPricedecimal (v))); }
        }
        public struct MaxPricedecimal : IMaxPrice<decimal>
        {
            object IValue.Value => this.Value;
            public decimal Value { get; }
            public MaxPricedecimal (decimal value) { Value = value; }
            public static implicit operator MaxPricedecimal (decimal value) { return new MaxPricedecimal (value); }
        }

        public interface IMinPrice : IValue {}
        public interface IMinPrice<T> : IMinPrice { new T Value { get; } }
        public class OneOrManyMinPrice : OneOrMany<IMinPrice>
        {
            public OneOrManyMinPrice(IMinPrice item) : base(item) { }
            public OneOrManyMinPrice(IEnumerable<IMinPrice> items) : base(items) { }
            public static implicit operator OneOrManyMinPrice (decimal value) { return new OneOrManyMinPrice (new MinPricedecimal (value)); }
            public static implicit operator OneOrManyMinPrice (decimal[] values) { return new OneOrManyMinPrice (values.Select(v => (IMinPrice) new MinPricedecimal (v))); }
            public static implicit operator OneOrManyMinPrice (List<decimal> values) { return new OneOrManyMinPrice (values.Select(v => (IMinPrice) new MinPricedecimal (v))); }
        }
        public struct MinPricedecimal : IMinPrice<decimal>
        {
            object IValue.Value => this.Value;
            public decimal Value { get; }
            public MinPricedecimal (decimal value) { Value = value; }
            public static implicit operator MinPricedecimal (decimal value) { return new MinPricedecimal (value); }
        }

        public interface IPrice : IValue {}
        public interface IPrice<T> : IPrice { new T Value { get; } }
        public class OneOrManyPrice : OneOrMany<IPrice>
        {
            public OneOrManyPrice(IPrice item) : base(item) { }
            public OneOrManyPrice(IEnumerable<IPrice> items) : base(items) { }
            public static implicit operator OneOrManyPrice (decimal value) { return new OneOrManyPrice (new Pricedecimal (value)); }
            public static implicit operator OneOrManyPrice (decimal[] values) { return new OneOrManyPrice (values.Select(v => (IPrice) new Pricedecimal (v))); }
            public static implicit operator OneOrManyPrice (List<decimal> values) { return new OneOrManyPrice (values.Select(v => (IPrice) new Pricedecimal (v))); }
            public static implicit operator OneOrManyPrice (string value) { return new OneOrManyPrice (new Pricestring (value)); }
            public static implicit operator OneOrManyPrice (string[] values) { return new OneOrManyPrice (values.Select(v => (IPrice) new Pricestring (v))); }
            public static implicit operator OneOrManyPrice (List<string> values) { return new OneOrManyPrice (values.Select(v => (IPrice) new Pricestring (v))); }
        }
        public struct Pricedecimal : IPrice<decimal>
        {
            object IValue.Value => this.Value;
            public decimal Value { get; }
            public Pricedecimal (decimal value) { Value = value; }
            public static implicit operator Pricedecimal (decimal value) { return new Pricedecimal (value); }
        }
        public struct Pricestring : IPrice<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Pricestring (string value) { Value = value; }
            public static implicit operator Pricestring (string value) { return new Pricestring (value); }
        }

        public interface IPriceCurrency : IValue {}
        public interface IPriceCurrency<T> : IPriceCurrency { new T Value { get; } }
        public class OneOrManyPriceCurrency : OneOrMany<IPriceCurrency>
        {
            public OneOrManyPriceCurrency(IPriceCurrency item) : base(item) { }
            public OneOrManyPriceCurrency(IEnumerable<IPriceCurrency> items) : base(items) { }
            public static implicit operator OneOrManyPriceCurrency (string value) { return new OneOrManyPriceCurrency (new PriceCurrencystring (value)); }
            public static implicit operator OneOrManyPriceCurrency (string[] values) { return new OneOrManyPriceCurrency (values.Select(v => (IPriceCurrency) new PriceCurrencystring (v))); }
            public static implicit operator OneOrManyPriceCurrency (List<string> values) { return new OneOrManyPriceCurrency (values.Select(v => (IPriceCurrency) new PriceCurrencystring (v))); }
        }
        public struct PriceCurrencystring : IPriceCurrency<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PriceCurrencystring (string value) { Value = value; }
            public static implicit operator PriceCurrencystring (string value) { return new PriceCurrencystring (value); }
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

        public interface IValueAddedTaxIncluded : IValue {}
        public interface IValueAddedTaxIncluded<T> : IValueAddedTaxIncluded { new T Value { get; } }
        public class OneOrManyValueAddedTaxIncluded : OneOrMany<IValueAddedTaxIncluded>
        {
            public OneOrManyValueAddedTaxIncluded(IValueAddedTaxIncluded item) : base(item) { }
            public OneOrManyValueAddedTaxIncluded(IEnumerable<IValueAddedTaxIncluded> items) : base(items) { }
            public static implicit operator OneOrManyValueAddedTaxIncluded (bool value) { return new OneOrManyValueAddedTaxIncluded (new ValueAddedTaxIncludedbool (value)); }
            public static implicit operator OneOrManyValueAddedTaxIncluded (bool[] values) { return new OneOrManyValueAddedTaxIncluded (values.Select(v => (IValueAddedTaxIncluded) new ValueAddedTaxIncludedbool (v))); }
            public static implicit operator OneOrManyValueAddedTaxIncluded (List<bool> values) { return new OneOrManyValueAddedTaxIncluded (values.Select(v => (IValueAddedTaxIncluded) new ValueAddedTaxIncludedbool (v))); }
        }
        public struct ValueAddedTaxIncludedbool : IValueAddedTaxIncluded<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public ValueAddedTaxIncludedbool (bool value) { Value = value; }
            public static implicit operator ValueAddedTaxIncludedbool (bool value) { return new ValueAddedTaxIncludedbool (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PriceSpecification";

        /// <summary>
        /// The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
        /// </summary>
        [DataMember(Name = "eligibleQuantity", Order = 306)]
        public OneOrManyEligibleQuantity EligibleQuantity { get; set; }

        /// <summary>
        /// The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
        /// </summary>
        [DataMember(Name = "eligibleTransactionVolume", Order = 307)]
        public OneOrManyEligibleTransactionVolume EligibleTransactionVolume { get; set; }

        /// <summary>
        /// The highest price if the price is a range.
        /// </summary>
        [DataMember(Name = "maxPrice", Order = 308)]
        public OneOrManyMaxPrice MaxPrice { get; set; }

        /// <summary>
        /// The lowest price if the price is a range.
        /// </summary>
        [DataMember(Name = "minPrice", Order = 309)]
        public OneOrManyMinPrice MinPrice { get; set; }

        /// <summary>
        /// The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes.&lt;br/&gt;&lt;br/&gt;
        /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Use the &lt;a class="localLink" href="http://schema.org/priceCurrency"&gt;priceCurrency&lt;/a&gt; property (with standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR") instead of including &lt;a href="http://en.wikipedia.org/wiki/Dollar_sign#Currencies_that_use_the_dollar_or_peso_sign"&gt;ambiguous symbols&lt;/a&gt; such as '$' in the value.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;li&gt;Note that both &lt;a href="http://www.w3.org/TR/xhtml-rdfa-primer/#using-the-content-attribute"&gt;RDFa&lt;/a&gt; and Microdata syntax allow the use of a "content=" attribute for publishing simple machine-readable values alongside more human-friendly formatting.&lt;/li&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "price", Order = 310)]
        public OneOrManyPrice Price { get; set; }

        /// <summary>
        /// The currency of the price, or a price component when attached to &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        [DataMember(Name = "priceCurrency", Order = 311)]
        public OneOrManyPriceCurrency PriceCurrency { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [DataMember(Name = "validFrom", Order = 312)]
        public OneOrManyValidFrom ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough", Order = 313)]
        public OneOrManyValidThrough ValidThrough { get; set; }

        /// <summary>
        /// Specifies whether the applicable value-added tax (VAT) is included in the price specification or not.
        /// </summary>
        [DataMember(Name = "valueAddedTaxIncluded", Order = 314)]
        public OneOrManyValueAddedTaxIncluded ValueAddedTaxIncluded { get; set; }
    }
}
