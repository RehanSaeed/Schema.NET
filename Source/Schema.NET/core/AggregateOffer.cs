namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// When a single product is associated with multiple offers (for example, the same pair of shoes is offered by different merchants), then AggregateOffer can be used.
    /// </summary>
    [DataContract]
    public partial class AggregateOffer : Offer
    {
        public interface IHighPrice : IValue {}
        public interface IHighPrice<T> : IHighPrice { new T Value { get; } }
        public class OneOrManyHighPrice : OneOrMany<IHighPrice>
        {
            public OneOrManyHighPrice(IHighPrice item) : base(item) { }
            public OneOrManyHighPrice(IEnumerable<IHighPrice> items) : base(items) { }
            public static implicit operator OneOrManyHighPrice (decimal value) { return new OneOrManyHighPrice (new HighPricedecimal (value)); }
            public static implicit operator OneOrManyHighPrice (decimal[] values) { return new OneOrManyHighPrice (values.Select(v => (IHighPrice) new HighPricedecimal (v))); }
            public static implicit operator OneOrManyHighPrice (List<decimal> values) { return new OneOrManyHighPrice (values.Select(v => (IHighPrice) new HighPricedecimal (v))); }
            public static implicit operator OneOrManyHighPrice (string value) { return new OneOrManyHighPrice (new HighPricestring (value)); }
            public static implicit operator OneOrManyHighPrice (string[] values) { return new OneOrManyHighPrice (values.Select(v => (IHighPrice) new HighPricestring (v))); }
            public static implicit operator OneOrManyHighPrice (List<string> values) { return new OneOrManyHighPrice (values.Select(v => (IHighPrice) new HighPricestring (v))); }
        }
        public struct HighPricedecimal : IHighPrice<decimal>
        {
            object IValue.Value => this.Value;
            public decimal Value { get; }
            public HighPricedecimal (decimal value) { Value = value; }
            public static implicit operator HighPricedecimal (decimal value) { return new HighPricedecimal (value); }
        }
        public struct HighPricestring : IHighPrice<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public HighPricestring (string value) { Value = value; }
            public static implicit operator HighPricestring (string value) { return new HighPricestring (value); }
        }

        public interface ILowPrice : IValue {}
        public interface ILowPrice<T> : ILowPrice { new T Value { get; } }
        public class OneOrManyLowPrice : OneOrMany<ILowPrice>
        {
            public OneOrManyLowPrice(ILowPrice item) : base(item) { }
            public OneOrManyLowPrice(IEnumerable<ILowPrice> items) : base(items) { }
            public static implicit operator OneOrManyLowPrice (decimal value) { return new OneOrManyLowPrice (new LowPricedecimal (value)); }
            public static implicit operator OneOrManyLowPrice (decimal[] values) { return new OneOrManyLowPrice (values.Select(v => (ILowPrice) new LowPricedecimal (v))); }
            public static implicit operator OneOrManyLowPrice (List<decimal> values) { return new OneOrManyLowPrice (values.Select(v => (ILowPrice) new LowPricedecimal (v))); }
            public static implicit operator OneOrManyLowPrice (string value) { return new OneOrManyLowPrice (new LowPricestring (value)); }
            public static implicit operator OneOrManyLowPrice (string[] values) { return new OneOrManyLowPrice (values.Select(v => (ILowPrice) new LowPricestring (v))); }
            public static implicit operator OneOrManyLowPrice (List<string> values) { return new OneOrManyLowPrice (values.Select(v => (ILowPrice) new LowPricestring (v))); }
        }
        public struct LowPricedecimal : ILowPrice<decimal>
        {
            object IValue.Value => this.Value;
            public decimal Value { get; }
            public LowPricedecimal (decimal value) { Value = value; }
            public static implicit operator LowPricedecimal (decimal value) { return new LowPricedecimal (value); }
        }
        public struct LowPricestring : ILowPrice<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public LowPricestring (string value) { Value = value; }
            public static implicit operator LowPricestring (string value) { return new LowPricestring (value); }
        }

        public interface IOfferCount : IValue {}
        public interface IOfferCount<T> : IOfferCount { new T Value { get; } }
        public class OneOrManyOfferCount : OneOrMany<IOfferCount>
        {
            public OneOrManyOfferCount(IOfferCount item) : base(item) { }
            public OneOrManyOfferCount(IEnumerable<IOfferCount> items) : base(items) { }
            public static implicit operator OneOrManyOfferCount (int value) { return new OneOrManyOfferCount (new OfferCountint (value)); }
            public static implicit operator OneOrManyOfferCount (int[] values) { return new OneOrManyOfferCount (values.Select(v => (IOfferCount) new OfferCountint (v))); }
            public static implicit operator OneOrManyOfferCount (List<int> values) { return new OneOrManyOfferCount (values.Select(v => (IOfferCount) new OfferCountint (v))); }
        }
        public struct OfferCountint : IOfferCount<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public OfferCountint (int value) { Value = value; }
            public static implicit operator OfferCountint (int value) { return new OfferCountint (value); }
        }

        public interface IOffers : IValue {}
        public interface IOffers<T> : IOffers { new T Value { get; } }
        public class OneOrManyOffers : OneOrMany<IOffers>
        {
            public OneOrManyOffers(IOffers item) : base(item) { }
            public OneOrManyOffers(IEnumerable<IOffers> items) : base(items) { }
            public static implicit operator OneOrManyOffers (Offer value) { return new OneOrManyOffers (new OffersOffer (value)); }
            public static implicit operator OneOrManyOffers (Offer[] values) { return new OneOrManyOffers (values.Select(v => (IOffers) new OffersOffer (v))); }
            public static implicit operator OneOrManyOffers (List<Offer> values) { return new OneOrManyOffers (values.Select(v => (IOffers) new OffersOffer (v))); }
        }
        public struct OffersOffer : IOffers<Offer>
        {
            object IValue.Value => this.Value;
            public Offer Value { get; }
            public OffersOffer (Offer value) { Value = value; }
            public static implicit operator OffersOffer (Offer value) { return new OffersOffer (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AggregateOffer";

        /// <summary>
        /// The highest price of all offers available.
        /// </summary>
        [DataMember(Name = "highPrice", Order = 306)]
        public OneOrManyHighPrice HighPrice { get; set; }

        /// <summary>
        /// The lowest price of all offers available.
        /// </summary>
        [DataMember(Name = "lowPrice", Order = 307)]
        public OneOrManyLowPrice LowPrice { get; set; }

        /// <summary>
        /// The number of offers for the product.
        /// </summary>
        [DataMember(Name = "offerCount", Order = 308)]
        public OneOrManyOfferCount OfferCount { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers", Order = 309)]
        public OneOrManyOffers Offers { get; set; }
    }
}
