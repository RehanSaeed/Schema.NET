namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
    public partial interface IInvoice : IIntangible
    {
        /// <summary>
        /// The identifier for the account the payment will be applied to.
        /// </summary>
        OneOrMany<string> AccountId { get; set; }

        /// <summary>
        /// The time interval used to compute the invoice.
        /// </summary>
        OneOrMany<TimeSpan?> BillingPeriod { get; set; }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        Values<IOrganization, IPerson> Broker { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        Values<PhysicalActivityCategory?, string, IThing, Uri> Category { get; set; }

        /// <summary>
        /// A number that confirms the given order or payment has been received.
        /// </summary>
        OneOrMany<string> ConfirmationNumber { get; set; }

        /// <summary>
        /// Party placing the order or paying the invoice.
        /// </summary>
        Values<IOrganization, IPerson> Customer { get; set; }

        /// <summary>
        /// The minimum payment required at this time.
        /// </summary>
        Values<IMonetaryAmount, IPriceSpecification> MinimumPaymentDue { get; set; }

        /// <summary>
        /// The date that payment is due.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> PaymentDueDate { get; set; }

        /// <summary>
        /// The name of the credit card or other method of payment for the order.
        /// </summary>
        OneOrMany<PaymentMethod?> PaymentMethod { get; set; }

        /// <summary>
        /// An identifier for the method of payment used (e.g. the last 4 digits of the credit card).
        /// </summary>
        OneOrMany<string> PaymentMethodId { get; set; }

        /// <summary>
        /// The status of payment; whether the invoice has been paid or not.
        /// </summary>
        Values<PaymentStatusType?, string> PaymentStatus { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        Values<IOrganization, IPerson> Provider { get; set; }

        /// <summary>
        /// The Order(s) related to this Invoice. One or more Orders may be combined into a single Invoice.
        /// </summary>
        OneOrMany<IOrder> ReferencesOrder { get; set; }

        /// <summary>
        /// The date the invoice is scheduled to be paid.
        /// </summary>
        Values<int?, DateTime?> ScheduledPaymentDate { get; set; }

        /// <summary>
        /// The total amount due.
        /// </summary>
        Values<IMonetaryAmount, IPriceSpecification> TotalPaymentDue { get; set; }
    }

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
    [DataContract]
    public partial class Invoice : Intangible, IInvoice, IEquatable<Invoice>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Invoice";

        /// <summary>
        /// The identifier for the account the payment will be applied to.
        /// </summary>
        [DataMember(Name = "accountId", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AccountId { get; set; }

        /// <summary>
        /// The time interval used to compute the invoice.
        /// </summary>
        [DataMember(Name = "billingPeriod", Order = 207)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public OneOrMany<TimeSpan?> BillingPeriod { get; set; }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [DataMember(Name = "broker", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Broker { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [DataMember(Name = "category", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<PhysicalActivityCategory?, string, IThing, Uri> Category { get; set; }

        /// <summary>
        /// A number that confirms the given order or payment has been received.
        /// </summary>
        [DataMember(Name = "confirmationNumber", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ConfirmationNumber { get; set; }

        /// <summary>
        /// Party placing the order or paying the invoice.
        /// </summary>
        [DataMember(Name = "customer", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Customer { get; set; }

        /// <summary>
        /// The minimum payment required at this time.
        /// </summary>
        [DataMember(Name = "minimumPaymentDue", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMonetaryAmount, IPriceSpecification> MinimumPaymentDue { get; set; }

        /// <summary>
        /// The date that payment is due.
        /// </summary>
        [DataMember(Name = "paymentDueDate", Order = 213)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> PaymentDueDate { get; set; }

        /// <summary>
        /// The name of the credit card or other method of payment for the order.
        /// </summary>
        [DataMember(Name = "paymentMethod", Order = 214)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<PaymentMethod?> PaymentMethod { get; set; }

        /// <summary>
        /// An identifier for the method of payment used (e.g. the last 4 digits of the credit card).
        /// </summary>
        [DataMember(Name = "paymentMethodId", Order = 215)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PaymentMethodId { get; set; }

        /// <summary>
        /// The status of payment; whether the invoice has been paid or not.
        /// </summary>
        [DataMember(Name = "paymentStatus", Order = 216)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<PaymentStatusType?, string> PaymentStatus { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 217)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Provider { get; set; }

        /// <summary>
        /// The Order(s) related to this Invoice. One or more Orders may be combined into a single Invoice.
        /// </summary>
        [DataMember(Name = "referencesOrder", Order = 218)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrder> ReferencesOrder { get; set; }

        /// <summary>
        /// The date the invoice is scheduled to be paid.
        /// </summary>
        [DataMember(Name = "scheduledPaymentDate", Order = 219)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> ScheduledPaymentDate { get; set; }

        /// <summary>
        /// The total amount due.
        /// </summary>
        [DataMember(Name = "totalPaymentDue", Order = 220)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMonetaryAmount, IPriceSpecification> TotalPaymentDue { get; set; }

        /// <inheritdoc/>
        public bool Equals(Invoice other)
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
                this.AccountId == other.AccountId &&
                this.BillingPeriod == other.BillingPeriod &&
                this.Broker == other.Broker &&
                this.Category == other.Category &&
                this.ConfirmationNumber == other.ConfirmationNumber &&
                this.Customer == other.Customer &&
                this.MinimumPaymentDue == other.MinimumPaymentDue &&
                this.PaymentDueDate == other.PaymentDueDate &&
                this.PaymentMethod == other.PaymentMethod &&
                this.PaymentMethodId == other.PaymentMethodId &&
                this.PaymentStatus == other.PaymentStatus &&
                this.Provider == other.Provider &&
                this.ReferencesOrder == other.ReferencesOrder &&
                this.ScheduledPaymentDate == other.ScheduledPaymentDate &&
                this.TotalPaymentDue == other.TotalPaymentDue &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Invoice);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AccountId)
            .And(this.BillingPeriod)
            .And(this.Broker)
            .And(this.Category)
            .And(this.ConfirmationNumber)
            .And(this.Customer)
            .And(this.MinimumPaymentDue)
            .And(this.PaymentDueDate)
            .And(this.PaymentMethod)
            .And(this.PaymentMethodId)
            .And(this.PaymentStatus)
            .And(this.Provider)
            .And(this.ReferencesOrder)
            .And(this.ScheduledPaymentDate)
            .And(this.TotalPaymentDue)
            .And(base.GetHashCode());
    }
}
