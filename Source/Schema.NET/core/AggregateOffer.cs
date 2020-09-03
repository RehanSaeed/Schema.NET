namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// When a single product is associated with multiple offers (for example, the same pair of shoes is offered by different merchants), then AggregateOffer can be used.&lt;br/&gt;&lt;br/&gt;
    /// Note: AggregateOffers are normally expected to associate multiple offers that all share the same defined &lt;a class="localLink" href="https://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; value, or default to http://purl.org/goodrelations/v1#Sell if businessFunction is not explicitly defined.
    /// </summary>
    public partial interface IAggregateOffer : IOffer
    {
        /// <summary>
        /// The highest price of all offers available.&lt;br/&gt;&lt;br/&gt;
        /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        Values<decimal?, string> HighPrice { get; set; }

        /// <summary>
        /// The lowest price of all offers available.&lt;br/&gt;&lt;br/&gt;
        /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        Values<decimal?, string> LowPrice { get; set; }

        /// <summary>
        /// The number of offers for the product.
        /// </summary>
        OneOrMany<int?> OfferCount { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event. Use &lt;a class="localLink" href="https://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; to indicate the kind of transaction offered, i.e. sell, lease, etc. This property can also be used to describe a &lt;a class="localLink" href="https://schema.org/Demand"&gt;Demand&lt;/a&gt;. While this property is listed as expected on a number of common types, it can be used in others. In that case, using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.
        /// </summary>
        Values<IDemand, IOffer> Offers { get; set; }
    }

    /// <summary>
    /// When a single product is associated with multiple offers (for example, the same pair of shoes is offered by different merchants), then AggregateOffer can be used.&lt;br/&gt;&lt;br/&gt;
    /// Note: AggregateOffers are normally expected to associate multiple offers that all share the same defined &lt;a class="localLink" href="https://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; value, or default to http://purl.org/goodrelations/v1#Sell if businessFunction is not explicitly defined.
    /// </summary>
    [DataContract]
    public partial class AggregateOffer : Offer, IAggregateOffer, IEquatable<AggregateOffer>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AggregateOffer";

        /// <summary>
        /// The highest price of all offers available.&lt;br/&gt;&lt;br/&gt;
        /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "highPrice", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<decimal?, string> HighPrice { get; set; }

        /// <summary>
        /// The lowest price of all offers available.&lt;br/&gt;&lt;br/&gt;
        /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "lowPrice", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<decimal?, string> LowPrice { get; set; }

        /// <summary>
        /// The number of offers for the product.
        /// </summary>
        [DataMember(Name = "offerCount", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> OfferCount { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event. Use &lt;a class="localLink" href="https://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; to indicate the kind of transaction offered, i.e. sell, lease, etc. This property can also be used to describe a &lt;a class="localLink" href="https://schema.org/Demand"&gt;Demand&lt;/a&gt;. While this property is listed as expected on a number of common types, it can be used in others. In that case, using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.
        /// </summary>
        [DataMember(Name = "offers", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IDemand, IOffer> Offers { get; set; }

        /// <inheritdoc/>
        public bool Equals(AggregateOffer other)
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
                this.HighPrice == other.HighPrice &&
                this.LowPrice == other.LowPrice &&
                this.OfferCount == other.OfferCount &&
                this.Offers == other.Offers &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as AggregateOffer);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.HighPrice)
            .And(this.LowPrice)
            .And(this.OfferCount)
            .And(this.Offers)
            .And(base.GetHashCode());
    }
}
