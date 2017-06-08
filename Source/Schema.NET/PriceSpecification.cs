namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup...
    /// </summary>
    [DataContract]
    public class PriceSpecification : StructuredValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PriceSpecification";

        /// <summary>
        /// The lowest price if the price is a range.
        /// </summary>
        [DataMember(Name = "minPrice")]
        public decimal MinPrice { get; set; }

        /// <summary>
        /// The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
        /// </summary>
        [DataMember(Name = "eligibleTransactionVolume")]
        public PriceSpecification EligibleTransactionVolume { get; set; }

        /// <summary>
        /// The highest price if the price is a range.
        /// </summary>
        [DataMember(Name = "maxPrice")]
        public decimal MaxPrice { get; set; }

        /// <summary>
        /// The currency (in 3-letter ISO 4217 format) of the price or a price component, when attached to &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.
        /// </summary>
        [DataMember(Name = "priceCurrency")]
        public string PriceCurrency { get; set; }

        /// <summary>
        /// The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
        /// </summary>
        [DataMember(Name = "eligibleQuantity")]
        public QuantitativeValue EligibleQuantity { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [DataMember(Name = "validFrom")]
        public DateTimeOffset ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough")]
        public DateTimeOffset ValidThrough { get; set; }

        /// <summary>
        /// &lt;p&gt;The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes.&lt;/p&gt;
        /// &lt;p&gt;Usage guidelines:&lt;/p&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Use the &lt;a class="localLink" href="http://schema.org/priceCurrency"&gt;priceCurrency&lt;/a&gt; property (with &lt;a href="http://en.wikipedia.org/wiki/ISO_4217#Active_codes"&gt;ISO 4217 codes&lt;/a&gt; e.g. "USD") instead of
        ///   including &lt;a href="http://en.wikipedia.org/wiki/Dollar_sign#Currencies_that_use_the_dollar_or_peso_sign"&gt;ambiguous symbols&lt;/a&gt; such as '$' in the value.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;li&gt;Note that both &lt;a href="http://www.w3.org/TR/xhtml-rdfa-primer/#using-the-content-attribute"&gt;RDFa&lt;/a&gt; and Microdata syntax allow the use of a "content=" attribute for publishing simple machine-readable values alongside more human-friendly formatting.&lt;/li&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "price")]
        public object Price { get; protected set; }

        /// <summary>
        /// &lt;p&gt;The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes.&lt;/p&gt;
        /// &lt;p&gt;Usage guidelines:&lt;/p&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Use the &lt;a class="localLink" href="http://schema.org/priceCurrency"&gt;priceCurrency&lt;/a&gt; property (with &lt;a href="http://en.wikipedia.org/wiki/ISO_4217#Active_codes"&gt;ISO 4217 codes&lt;/a&gt; e.g. "USD") instead of
        ///   including &lt;a href="http://en.wikipedia.org/wiki/Dollar_sign#Currencies_that_use_the_dollar_or_peso_sign"&gt;ambiguous symbols&lt;/a&gt; such as '$' in the value.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;li&gt;Note that both &lt;a href="http://www.w3.org/TR/xhtml-rdfa-primer/#using-the-content-attribute"&gt;RDFa&lt;/a&gt; and Microdata syntax allow the use of a "content=" attribute for publishing simple machine-readable values alongside more human-friendly formatting.&lt;/li&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [IgnoreDataMember]
        public string PriceText
        {
            get => this.Price as string;
            set => this.Price = value;
        }

        /// <summary>
        /// &lt;p&gt;The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes.&lt;/p&gt;
        /// &lt;p&gt;Usage guidelines:&lt;/p&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Use the &lt;a class="localLink" href="http://schema.org/priceCurrency"&gt;priceCurrency&lt;/a&gt; property (with &lt;a href="http://en.wikipedia.org/wiki/ISO_4217#Active_codes"&gt;ISO 4217 codes&lt;/a&gt; e.g. "USD") instead of
        ///   including &lt;a href="http://en.wikipedia.org/wiki/Dollar_sign#Currencies_that_use_the_dollar_or_peso_sign"&gt;ambiguous symbols&lt;/a&gt; such as '$' in the value.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;li&gt;Note that both &lt;a href="http://www.w3.org/TR/xhtml-rdfa-primer/#using-the-content-attribute"&gt;RDFa&lt;/a&gt; and Microdata syntax allow the use of a "content=" attribute for publishing simple machine-readable values alongside more human-friendly formatting.&lt;/li&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [IgnoreDataMember]
        public decimal? PriceNumber
        {
            get => this.Price as decimal?;
            set => this.Price = value;
        }

        /// <summary>
        /// Specifies whether the applicable value-added tax (VAT) is included in the price specification or not.
        /// </summary>
        [DataMember(Name = "valueAddedTaxIncluded")]
        public bool ValueAddedTaxIncluded { get; set; }
    }
}
