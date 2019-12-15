namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A statistical distribution of monetary amounts.
    /// </summary>
    public partial interface IMonetaryAmountDistribution : IQuantitativeValueDistribution
    {
        /// <summary>
        /// The currency in which the monetary amount is expressed.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        OneOrMany<string> Currency { get; set; }
    }

    /// <summary>
    /// A statistical distribution of monetary amounts.
    /// </summary>
    [DataContract]
    public partial class MonetaryAmountDistribution : QuantitativeValueDistribution, IMonetaryAmountDistribution, IEquatable<MonetaryAmountDistribution>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MonetaryAmountDistribution";

        /// <summary>
        /// The currency in which the monetary amount is expressed.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        [DataMember(Name = "currency", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Currency { get; set; }

        /// <inheritdoc/>
        public bool Equals(MonetaryAmountDistribution other)
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
                this.Currency == other.Currency &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MonetaryAmountDistribution);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Currency)
            .And(base.GetHashCode());
    }
}
