namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
    [DataContract]
    public partial class Order : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Order";

        /// <summary>
        /// The offer(s) -- e.g., product, quantity and price combinations -- included in the order.
        /// </summary>
        [DataMember(Name = "acceptedOffer", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Offer>? AcceptedOffer { get; set; }

        /// <summary>
        /// The billing address for the order.
        /// </summary>
        [DataMember(Name = "billingAddress", Order = 3)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PostalAddress>? BillingAddress { get; set; }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [DataMember(Name = "broker", Order = 4)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Broker { get; set; }

        /// <summary>
        /// A number that confirms the given order or payment has been received.
        /// </summary>
        [DataMember(Name = "confirmationNumber", Order = 5)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ConfirmationNumber { get; set; }

        /// <summary>
        /// Party placing the order or paying the invoice.
        /// </summary>
        [DataMember(Name = "customer", Order = 6)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person, Organization>? Customer { get; set; }

        /// <summary>
        /// Any discount applied (to an Order).
        /// </summary>
        [DataMember(Name = "discount", Order = 7)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, decimal?>? Discount { get; set; }

        /// <summary>
        /// Code used to redeem a discount.
        /// </summary>
        [DataMember(Name = "discountCode", Order = 8)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? DiscountCode { get; set; }

        /// <summary>
        /// The currency (in 3-letter ISO 4217 format) of the discount.
        /// </summary>
        [DataMember(Name = "discountCurrency", Order = 9)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? DiscountCurrency { get; set; }

        /// <summary>
        /// Was the offer accepted as a gift for someone other than the buyer.
        /// </summary>
        [DataMember(Name = "isGift", Order = 10)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<bool?>? IsGift { get; set; }

        /// <summary>
        /// Date order was placed.
        /// </summary>
        [DataMember(Name = "orderDate", Order = 11)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? OrderDate { get; set; }

        /// <summary>
        /// The delivery of the parcel related to this order or order item.
        /// </summary>
        [DataMember(Name = "orderDelivery", Order = 12)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ParcelDelivery>? OrderDelivery { get; set; }

        /// <summary>
        /// The item ordered.
        /// </summary>
        [DataMember(Name = "orderedItem", Order = 13)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<OrderItem, Product>? OrderedItem { get; set; }

        /// <summary>
        /// The identifier of the transaction.
        /// </summary>
        [DataMember(Name = "orderNumber", Order = 14)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? OrderNumber { get; set; }

        /// <summary>
        /// The current status of the order.
        /// </summary>
        [DataMember(Name = "orderStatus", Order = 15)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<OrderStatus?>? OrderStatus { get; set; }

        /// <summary>
        /// The order is being paid as part of the referenced Invoice.
        /// </summary>
        [DataMember(Name = "partOfInvoice", Order = 16)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Invoice>? PartOfInvoice { get; set; }

        /// <summary>
        /// The date that payment is due.
        /// </summary>
        [DataMember(Name = "paymentDueDate", Order = 17)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? PaymentDueDate { get; set; }

        /// <summary>
        /// The name of the credit card or other method of payment for the order.
        /// </summary>
        [DataMember(Name = "paymentMethod", Order = 18)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PaymentMethod?>? PaymentMethod { get; set; }

        /// <summary>
        /// An identifier for the method of payment used (e.g. the last 4 digits of the credit card).
        /// </summary>
        [DataMember(Name = "paymentMethodId", Order = 19)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PaymentMethodId { get; set; }

        /// <summary>
        /// The URL for sending a payment.
        /// </summary>
        [DataMember(Name = "paymentUrl", Order = 20)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? PaymentUrl { get; set; }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [DataMember(Name = "seller", Order = 21)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Seller { get; set; }
    }
}
