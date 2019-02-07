namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of participating in an exchange of goods and services for monetary compensation. An agent trades an object, product or service with a participant in exchange for a one time or periodic payment.
    /// </summary>
    [DataContract]
    public partial class TradeAction : Action
    {
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

        public interface IPriceSpecification : IValue {}
        public interface IPriceSpecification<T> : IPriceSpecification { new T Value { get; } }
        public class OneOrManyPriceSpecification : OneOrMany<IPriceSpecification>
        {
            public OneOrManyPriceSpecification(IPriceSpecification item) : base(item) { }
            public OneOrManyPriceSpecification(IEnumerable<IPriceSpecification> items) : base(items) { }
            public static implicit operator OneOrManyPriceSpecification (PriceSpecification value) { return new OneOrManyPriceSpecification (new PriceSpecificationPriceSpecification (value)); }
            public static implicit operator OneOrManyPriceSpecification (PriceSpecification[] values) { return new OneOrManyPriceSpecification (values.Select(v => (IPriceSpecification) new PriceSpecificationPriceSpecification (v))); }
            public static implicit operator OneOrManyPriceSpecification (List<PriceSpecification> values) { return new OneOrManyPriceSpecification (values.Select(v => (IPriceSpecification) new PriceSpecificationPriceSpecification (v))); }
        }
        public struct PriceSpecificationPriceSpecification : IPriceSpecification<PriceSpecification>
        {
            object IValue.Value => this.Value;
            public PriceSpecification Value { get; }
            public PriceSpecificationPriceSpecification (PriceSpecification value) { Value = value; }
            public static implicit operator PriceSpecificationPriceSpecification (PriceSpecification value) { return new PriceSpecificationPriceSpecification (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TradeAction";

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
        [DataMember(Name = "price", Order = 206)]
        public OneOrManyPrice Price { get; set; }

        /// <summary>
        /// One or more detailed price specifications, indicating the unit price and delivery or payment charges.
        /// </summary>
        [DataMember(Name = "priceSpecification", Order = 207)]
        public OneOrManyPriceSpecification PriceSpecification { get; set; }
    }
}
