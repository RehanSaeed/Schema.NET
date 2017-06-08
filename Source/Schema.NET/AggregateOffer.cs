namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// When a single product is associated with multiple offers (for example, the same pair of shoes is offered by different merchants), then AggregateOffer can be used.
    /// </summary>
    [DataContract]
    public class AggregateOffer : Offer
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "AggregateOffer";

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers")]
        public Offer Offers { get; set; }

        /// <summary>
        /// The number of offers for the product.
        /// </summary>
        [DataMember(Name = "offerCount")]
        public int OfferCount { get; set; }

        /// <summary>
        /// The lowest price of all offers available.
        /// </summary>
        [DataMember(Name = "lowPrice")]
        public object LowPrice { get; protected set; }

        /// <summary>
        /// The lowest price of all offers available.
        /// </summary>
        [IgnoreDataMember]
        public string LowPriceText
        {
            get => this.LowPrice as string;
            set => this.LowPrice = value;
        }

        /// <summary>
        /// The lowest price of all offers available.
        /// </summary>
        [IgnoreDataMember]
        public decimal? LowPriceNumber
        {
            get => this.LowPrice as decimal?;
            set => this.LowPrice = value;
        }

        /// <summary>
        /// The highest price of all offers available.
        /// </summary>
        [DataMember(Name = "highPrice")]
        public object HighPrice { get; protected set; }

        /// <summary>
        /// The highest price of all offers available.
        /// </summary>
        [IgnoreDataMember]
        public string HighPriceText
        {
            get => this.HighPrice as string;
            set => this.HighPrice = value;
        }

        /// <summary>
        /// The highest price of all offers available.
        /// </summary>
        [IgnoreDataMember]
        public decimal? HighPriceNumber
        {
            get => this.HighPrice as decimal?;
            set => this.HighPrice = value;
        }
    }
}
