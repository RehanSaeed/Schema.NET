namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup. It is recommended to use &lt;a class="localLink" href="https://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt; to describe independent amounts of money such as a salary, credit card limits, etc.
    /// </summary>
    public partial interface IPriceSpecification : IStructuredValue
    {
        /// <summary>
        /// The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
        /// </summary>
        OneOrMany<IQuantitativeValue> EligibleQuantity { get; set; }

        /// <summary>
        /// The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
        /// </summary>
        OneOrMany<IPriceSpecification> EligibleTransactionVolume { get; set; }

        /// <summary>
        /// The highest price if the price is a range.
        /// </summary>
        OneOrMany<decimal?> MaxPrice { get; set; }

        /// <summary>
        /// The lowest price if the price is a range.
        /// </summary>
        OneOrMany<decimal?> MinPrice { get; set; }

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
        /// The date when the item becomes valid.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }

        /// <summary>
        /// Specifies whether the applicable value-added tax (VAT) is included in the price specification or not.
        /// </summary>
        OneOrMany<bool?> ValueAddedTaxIncluded { get; set; }
    }

    /// <summary>
    /// A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup. It is recommended to use &lt;a class="localLink" href="https://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt; to describe independent amounts of money such as a salary, credit card limits, etc.
    /// </summary>
    [DataContract]
    public partial class PriceSpecification : StructuredValue, IPriceSpecification, IEquatable<PriceSpecification>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PriceSpecification";

        /// <summary>
        /// The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
        /// </summary>
        [DataMember(Name = "eligibleQuantity", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> EligibleQuantity { get; set; }

        /// <summary>
        /// The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
        /// </summary>
        [DataMember(Name = "eligibleTransactionVolume", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPriceSpecification> EligibleTransactionVolume { get; set; }

        /// <summary>
        /// The highest price if the price is a range.
        /// </summary>
        [DataMember(Name = "maxPrice", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<decimal?> MaxPrice { get; set; }

        /// <summary>
        /// The lowest price if the price is a range.
        /// </summary>
        [DataMember(Name = "minPrice", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<decimal?> MinPrice { get; set; }

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
        [DataMember(Name = "price", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<decimal?, string> Price { get; set; }

        /// <summary>
        /// The currency of the price, or a price component when attached to &lt;a class="localLink" href="https://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        [DataMember(Name = "priceCurrency", Order = 311)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PriceCurrency { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [DataMember(Name = "validFrom", Order = 312)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough", Order = 313)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }

        /// <summary>
        /// Specifies whether the applicable value-added tax (VAT) is included in the price specification or not.
        /// </summary>
        [DataMember(Name = "valueAddedTaxIncluded", Order = 314)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> ValueAddedTaxIncluded { get; set; }

        /// <inheritdoc/>
        public bool Equals(PriceSpecification other)
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
                this.EligibleQuantity == other.EligibleQuantity &&
                this.EligibleTransactionVolume == other.EligibleTransactionVolume &&
                this.MaxPrice == other.MaxPrice &&
                this.MinPrice == other.MinPrice &&
                this.Price == other.Price &&
                this.PriceCurrency == other.PriceCurrency &&
                this.ValidFrom == other.ValidFrom &&
                this.ValidThrough == other.ValidThrough &&
                this.ValueAddedTaxIncluded == other.ValueAddedTaxIncluded &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as PriceSpecification);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.EligibleQuantity)
            .And(this.EligibleTransactionVolume)
            .And(this.MaxPrice)
            .And(this.MinPrice)
            .And(this.Price)
            .And(this.PriceCurrency)
            .And(this.ValidFrom)
            .And(this.ValidThrough)
            .And(this.ValueAddedTaxIncluded)
            .And(base.GetHashCode());
    }
}
