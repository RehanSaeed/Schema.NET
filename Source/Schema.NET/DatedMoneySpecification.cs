namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A DatedMoneySpecification represents monetary values with optional start and end dates...
    /// </summary>
    [DataContract]
    public class DatedMoneySpecification : StructuredValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "DatedMoneySpecification";

        /// <summary>
        /// The end date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "endDate")]
        public DateTimeOffset EndDate { get; set; }

        /// <summary>
        /// The currency in which the monetary amount is expressed (in 3-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; format).
        /// </summary>
        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The amount of money.
        /// </summary>
        [DataMember(Name = "amount")]
        public object Amount { get; protected set; }

        /// <summary>
        /// The amount of money.
        /// </summary>
        [IgnoreDataMember]
        public MonetaryAmount AmountMonetaryAmount
        {
            get => this.Amount as MonetaryAmount;
            set => this.Amount = value;
        }

        /// <summary>
        /// The amount of money.
        /// </summary>
        [IgnoreDataMember]
        public decimal? AmountNumber
        {
            get => this.Amount as decimal?;
            set => this.Amount = value;
        }

        /// <summary>
        /// The start date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "startDate")]
        public DateTimeOffset StartDate { get; set; }
    }
}
