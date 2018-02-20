namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A financial product for the loaning of an amount of money under agreed terms and charges.
    /// </summary>
    [DataContract]
    public partial class LoanOrCredit : FinancialProduct
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LoanOrCredit";

        /// <summary>
        /// The amount of money.
        /// </summary>
        [DataMember(Name = "amount", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MonetaryAmount, decimal?>? Amount { get; set; }

        /// <summary>
        /// The period of time after any due date that the borrower has to fulfil its obligations before a default (failure to pay) is deemed to have occurred.
        /// </summary>
        [DataMember(Name = "gracePeriod", Order = 407)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public OneOrMany<TimeSpan?>? GracePeriod { get; set; }

        /// <summary>
        /// The duration of the loan or credit agreement.
        /// </summary>
        [DataMember(Name = "loanTerm", Order = 408)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<QuantitativeValue>? LoanTerm { get; set; }

        /// <summary>
        /// The type of a loan or credit.
        /// </summary>
        [DataMember(Name = "loanType", Order = 409)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? LoanType { get; set; }

        /// <summary>
        /// The only way you get the money back in the event of default is the security. Recourse is where you still have the opportunity to go back to the borrower for the rest of the money.
        /// </summary>
        [DataMember(Name = "recourseLoan", Order = 410)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<bool?>? RecourseLoan { get; set; }

        /// <summary>
        /// Whether the terms for payment of interest can be renegotiated during the life of the loan.
        /// </summary>
        [DataMember(Name = "renegotiableLoan", Order = 411)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<bool?>? RenegotiableLoan { get; set; }

        /// <summary>
        /// Assets required to secure loan or credit repayments. It may take form of third party pledge, goods, financial instruments (cash, securities, etc.)
        /// </summary>
        [DataMember(Name = "requiredCollateral", Order = 412)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Thing>? RequiredCollateral { get; set; }
    }
}
