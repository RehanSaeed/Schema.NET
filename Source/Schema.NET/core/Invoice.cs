namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
    [DataContract]
    public partial class Invoice : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Invoice";

        /// <summary>
        /// The identifier for the account the payment will be applied to.
        /// </summary>
        [DataMember(Name = "accountId", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AccountId { get; set; }

        /// <summary>
        /// The time interval used to compute the invoice.
        /// </summary>
        [DataMember(Name = "billingPeriod", Order = 3)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan?>? BillingPeriod { get; set; }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [DataMember(Name = "broker", Order = 4)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Broker { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [DataMember(Name = "category", Order = 5)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing, string>? Category { get; set; }

        /// <summary>
        /// A number that confirms the given order or payment has been received.
        /// </summary>
        [DataMember(Name = "confirmationNumber", Order = 6)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ConfirmationNumber { get; set; }

        /// <summary>
        /// Party placing the order or paying the invoice.
        /// </summary>
        [DataMember(Name = "customer", Order = 7)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person, Organization>? Customer { get; set; }

        /// <summary>
        /// The minimum payment required at this time.
        /// </summary>
        [DataMember(Name = "minimumPaymentDue", Order = 8)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MonetaryAmount, PriceSpecification>? MinimumPaymentDue { get; set; }

        /// <summary>
        /// The date that payment is due.
        /// </summary>
        [DataMember(Name = "paymentDueDate", Order = 9)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? PaymentDueDate { get; set; }

        /// <summary>
        /// The name of the credit card or other method of payment for the order.
        /// </summary>
        [DataMember(Name = "paymentMethod", Order = 10)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PaymentMethod?>? PaymentMethod { get; set; }

        /// <summary>
        /// An identifier for the method of payment used (e.g. the last 4 digits of the credit card).
        /// </summary>
        [DataMember(Name = "paymentMethodId", Order = 11)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PaymentMethodId { get; set; }

        /// <summary>
        /// The status of payment; whether the invoice has been paid or not.
        /// </summary>
        [DataMember(Name = "paymentStatus", Order = 12)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PaymentStatusType?, string>? PaymentStatus { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 13)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Provider { get; set; }

        /// <summary>
        /// The Order(s) related to this Invoice. One or more Orders may be combined into a single Invoice.
        /// </summary>
        [DataMember(Name = "referencesOrder", Order = 14)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Order>? ReferencesOrder { get; set; }

        /// <summary>
        /// The date the invoice is scheduled to be paid.
        /// </summary>
        [DataMember(Name = "scheduledPaymentDate", Order = 15)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? ScheduledPaymentDate { get; set; }

        /// <summary>
        /// The total amount due.
        /// </summary>
        [DataMember(Name = "totalPaymentDue", Order = 16)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PriceSpecification, MonetaryAmount>? TotalPaymentDue { get; set; }
    }
}
