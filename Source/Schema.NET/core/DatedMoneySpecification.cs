namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A DatedMoneySpecification represents monetary values with optional start and end dates...
    /// </summary>
    [DataContract]
    public partial class DatedMoneySpecification : StructuredValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DatedMoneySpecification";

        /// <summary>
        /// The amount of money.
        /// </summary>
        [DataMember(Name = "amount", Order = 2)]
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
        /// The currency in which the monetary amount is expressed (in 3-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; format).
        /// </summary>
        [DataMember(Name = "currency", Order = 3)]
        public string Currency { get; set; }

        /// <summary>
        /// The end date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "endDate", Order = 4)]
        public DateTimeOffset? EndDate { get; set; }

        /// <summary>
        /// The start date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "startDate", Order = 5)]
        public DateTimeOffset? StartDate { get; set; }
    }
}
