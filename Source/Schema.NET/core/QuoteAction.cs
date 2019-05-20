namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An agent quotes/estimates/appraises an object/product/service with a price at a location/store.
    /// </summary>
    public partial interface IQuoteAction : ITradeAction
    {
    }

    /// <summary>
    /// An agent quotes/estimates/appraises an object/product/service with a price at a location/store.
    /// </summary>
    [DataContract]
    public partial class QuoteAction : TradeAction, IQuoteAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "QuoteAction";
    }
}
