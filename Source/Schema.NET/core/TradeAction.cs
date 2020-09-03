namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of participating in an exchange of goods and services for monetary compensation. An agent trades an object, product or service with a participant in exchange for a one time or periodic payment.
    /// </summary>
    public partial interface ITradeAction : IAction
    {
        /// <summary>
        /// The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes.&lt;br/&gt;&lt;br/&gt;
        /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Use the &lt;a class="localLink" href="https://schema.org/priceCurrency"&gt;priceCurrency&lt;/a&gt; property (with standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR") instead of including &lt;a href="http://en.wikipedia.org/wiki/Dollar_sign#Currencies_that_use_the_dollar_or_peso_sign"&gt;ambiguous symbols&lt;/a&gt; such as '$' in the value.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;li&gt;Note that both &lt;a href="http://www.w3.org/TR/xhtml-rdfa-primer/#using-the-content-attribute"&gt;RDFa&lt;/a&gt; and Microdata syntax allow the use of a "content=" attribute for publishing simple machine-readable values alongside more human-friendly formatting.&lt;/li&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        Values<decimal?, string> Price { get; set; }

        /// <summary>
        /// The currency of the price, or a price component when attached to &lt;a class="localLink" href="https://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        OneOrMany<string> PriceCurrency { get; set; }

        /// <summary>
        /// One or more detailed price specifications, indicating the unit price and delivery or payment charges.
        /// </summary>
        OneOrMany<IPriceSpecification> PriceSpecification { get; set; }
    }

    /// <summary>
    /// The act of participating in an exchange of goods and services for monetary compensation. An agent trades an object, product or service with a participant in exchange for a one time or periodic payment.
    /// </summary>
    [DataContract]
    public partial class TradeAction : Action, ITradeAction, IEquatable<TradeAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TradeAction";

        /// <summary>
        /// The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes.&lt;br/&gt;&lt;br/&gt;
        /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Use the &lt;a class="localLink" href="https://schema.org/priceCurrency"&gt;priceCurrency&lt;/a&gt; property (with standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR") instead of including &lt;a href="http://en.wikipedia.org/wiki/Dollar_sign#Currencies_that_use_the_dollar_or_peso_sign"&gt;ambiguous symbols&lt;/a&gt; such as '$' in the value.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;li&gt;Note that both &lt;a href="http://www.w3.org/TR/xhtml-rdfa-primer/#using-the-content-attribute"&gt;RDFa&lt;/a&gt; and Microdata syntax allow the use of a "content=" attribute for publishing simple machine-readable values alongside more human-friendly formatting.&lt;/li&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "price", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<decimal?, string> Price { get; set; }

        /// <summary>
        /// The currency of the price, or a price component when attached to &lt;a class="localLink" href="https://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        [DataMember(Name = "priceCurrency", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PriceCurrency { get; set; }

        /// <summary>
        /// One or more detailed price specifications, indicating the unit price and delivery or payment charges.
        /// </summary>
        [DataMember(Name = "priceSpecification", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPriceSpecification> PriceSpecification { get; set; }

        /// <inheritdoc/>
        public bool Equals(TradeAction other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.Price == other.Price &&
                this.PriceCurrency == other.PriceCurrency &&
                this.PriceSpecification == other.PriceSpecification &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as TradeAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Price)
            .And(this.PriceCurrency)
            .And(this.PriceSpecification)
            .And(base.GetHashCode());
    }
}
