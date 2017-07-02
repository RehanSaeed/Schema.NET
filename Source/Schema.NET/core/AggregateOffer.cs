namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// When a single product is associated with multiple offers (for example, the same pair of shoes is offered by different merchants), then AggregateOffer can be used.
    /// </summary>
    [DataContract]
    public partial class AggregateOffer : Offer
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AggregateOffer";

        /// <summary>
        /// The highest price of all offers available.
        /// </summary>
        [DataMember(Name = "highPrice", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<decimal?, string>? HighPrice { get; set; }

        /// <summary>
        /// The lowest price of all offers available.
        /// </summary>
        [DataMember(Name = "lowPrice", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<decimal?, string>? LowPrice { get; set; }

        /// <summary>
        /// The number of offers for the product.
        /// </summary>
        [DataMember(Name = "offerCount", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?>? OfferCount { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Offer>? Offers { get; set; }
    }
}
