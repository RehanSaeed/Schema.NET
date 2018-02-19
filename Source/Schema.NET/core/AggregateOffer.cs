using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// When a single product is associated with multiple offers (for example, the same pair of shoes is offered by different merchants), then AggregateOffer can be used.
    /// </summary>
    [DataContract]
    public partial class AggregateOffer : Offer
    {
        public interface IHighPrice : IWrapper { }
        public interface IHighPrice<T> : IHighPrice { new T Data { get; set; } }
        public class HighPricedecimal : IHighPrice<decimal>
        {
            object IWrapper.Data { get { return Data; } set { Data = (decimal) value; } }
            public virtual decimal Data { get; set; }
            public HighPricedecimal () { }
            public HighPricedecimal (decimal data) { Data = data; }
            public static implicit operator HighPricedecimal (decimal data) { return new HighPricedecimal (data); }
        }

        public class HighPricestring : IHighPrice<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public HighPricestring () { }
            public HighPricestring (string data) { Data = data; }
            public static implicit operator HighPricestring (string data) { return new HighPricestring (data); }
        }


        public interface ILowPrice : IWrapper { }
        public interface ILowPrice<T> : ILowPrice { new T Data { get; set; } }
        public class LowPricedecimal : ILowPrice<decimal>
        {
            object IWrapper.Data { get { return Data; } set { Data = (decimal) value; } }
            public virtual decimal Data { get; set; }
            public LowPricedecimal () { }
            public LowPricedecimal (decimal data) { Data = data; }
            public static implicit operator LowPricedecimal (decimal data) { return new LowPricedecimal (data); }
        }

        public class LowPricestring : ILowPrice<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public LowPricestring () { }
            public LowPricestring (string data) { Data = data; }
            public static implicit operator LowPricestring (string data) { return new LowPricestring (data); }
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IHighPrice>? HighPrice { get; set; } //decimal?, string

        /// <summary>
        /// The lowest price of all offers available.
        /// </summary>
        [DataMember(Name = "lowPrice", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ILowPrice>? LowPrice { get; set; } //decimal?, string

        /// <summary>
        /// The number of offers for the product.
        /// </summary>
        [DataMember(Name = "offerCount", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int>? OfferCount { get; set; } 

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Offer>? Offers { get; set; } 
    }
}
