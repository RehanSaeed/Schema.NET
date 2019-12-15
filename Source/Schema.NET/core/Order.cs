namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
    public partial interface IOrder : IIntangible
    {
        /// <summary>
        /// The offer(s) -- e.g., product, quantity and price combinations -- included in the order.
        /// </summary>
        OneOrMany<IOffer> AcceptedOffer { get; set; }

        /// <summary>
        /// The billing address for the order.
        /// </summary>
        OneOrMany<IPostalAddress> BillingAddress { get; set; }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        Values<IOrganization, IPerson> Broker { get; set; }

        /// <summary>
        /// A number that confirms the given order or payment has been received.
        /// </summary>
        OneOrMany<string> ConfirmationNumber { get; set; }

        /// <summary>
        /// Party placing the order or paying the invoice.
        /// </summary>
        Values<IOrganization, IPerson> Customer { get; set; }

        /// <summary>
        /// Any discount applied (to an Order).
        /// </summary>
        Values<decimal?, string> Discount { get; set; }

        /// <summary>
        /// Code used to redeem a discount.
        /// </summary>
        OneOrMany<string> DiscountCode { get; set; }

        /// <summary>
        /// The currency of the discount.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        OneOrMany<string> DiscountCurrency { get; set; }

        /// <summary>
        /// Was the offer accepted as a gift for someone other than the buyer.
        /// </summary>
        OneOrMany<bool?> IsGift { get; set; }

        /// <summary>
        /// Date order was placed.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> OrderDate { get; set; }

        /// <summary>
        /// The delivery of the parcel related to this order or order item.
        /// </summary>
        OneOrMany<IParcelDelivery> OrderDelivery { get; set; }

        /// <summary>
        /// The item ordered.
        /// </summary>
        Values<IOrderItem, IProduct, IService> OrderedItem { get; set; }

        /// <summary>
        /// The identifier of the transaction.
        /// </summary>
        OneOrMany<string> OrderNumber { get; set; }

        /// <summary>
        /// The current status of the order.
        /// </summary>
        OneOrMany<OrderStatus?> OrderStatus { get; set; }

        /// <summary>
        /// The order is being paid as part of the referenced Invoice.
        /// </summary>
        OneOrMany<IInvoice> PartOfInvoice { get; set; }

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
        /// The URL for sending a payment.
        /// </summary>
        OneOrMany<Uri> PaymentUrl { get; set; }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        Values<IOrganization, IPerson> Seller { get; set; }
    }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
    [DataContract]
    public partial class Order : Intangible, IOrder, IEquatable<Order>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Order";

        /// <summary>
        /// The offer(s) -- e.g., product, quantity and price combinations -- included in the order.
        /// </summary>
        [DataMember(Name = "acceptedOffer", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOffer> AcceptedOffer { get; set; }

        /// <summary>
        /// The billing address for the order.
        /// </summary>
        [DataMember(Name = "billingAddress", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPostalAddress> BillingAddress { get; set; }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [DataMember(Name = "broker", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Broker { get; set; }

        /// <summary>
        /// A number that confirms the given order or payment has been received.
        /// </summary>
        [DataMember(Name = "confirmationNumber", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ConfirmationNumber { get; set; }

        /// <summary>
        /// Party placing the order or paying the invoice.
        /// </summary>
        [DataMember(Name = "customer", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Customer { get; set; }

        /// <summary>
        /// Any discount applied (to an Order).
        /// </summary>
        [DataMember(Name = "discount", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<decimal?, string> Discount { get; set; }

        /// <summary>
        /// Code used to redeem a discount.
        /// </summary>
        [DataMember(Name = "discountCode", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> DiscountCode { get; set; }

        /// <summary>
        /// The currency of the discount.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        [DataMember(Name = "discountCurrency", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> DiscountCurrency { get; set; }

        /// <summary>
        /// Was the offer accepted as a gift for someone other than the buyer.
        /// </summary>
        [DataMember(Name = "isGift", Order = 214)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> IsGift { get; set; }

        /// <summary>
        /// Date order was placed.
        /// </summary>
        [DataMember(Name = "orderDate", Order = 215)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> OrderDate { get; set; }

        /// <summary>
        /// The delivery of the parcel related to this order or order item.
        /// </summary>
        [DataMember(Name = "orderDelivery", Order = 216)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IParcelDelivery> OrderDelivery { get; set; }

        /// <summary>
        /// The item ordered.
        /// </summary>
        [DataMember(Name = "orderedItem", Order = 217)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrderItem, IProduct, IService> OrderedItem { get; set; }

        /// <summary>
        /// The identifier of the transaction.
        /// </summary>
        [DataMember(Name = "orderNumber", Order = 218)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> OrderNumber { get; set; }

        /// <summary>
        /// The current status of the order.
        /// </summary>
        [DataMember(Name = "orderStatus", Order = 219)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<OrderStatus?> OrderStatus { get; set; }

        /// <summary>
        /// The order is being paid as part of the referenced Invoice.
        /// </summary>
        [DataMember(Name = "partOfInvoice", Order = 220)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IInvoice> PartOfInvoice { get; set; }

        /// <summary>
        /// The date that payment is due.
        /// </summary>
        [DataMember(Name = "paymentDueDate", Order = 221)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> PaymentDueDate { get; set; }

        /// <summary>
        /// The name of the credit card or other method of payment for the order.
        /// </summary>
        [DataMember(Name = "paymentMethod", Order = 222)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<PaymentMethod?> PaymentMethod { get; set; }

        /// <summary>
        /// An identifier for the method of payment used (e.g. the last 4 digits of the credit card).
        /// </summary>
        [DataMember(Name = "paymentMethodId", Order = 223)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PaymentMethodId { get; set; }

        /// <summary>
        /// The URL for sending a payment.
        /// </summary>
        [DataMember(Name = "paymentUrl", Order = 224)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> PaymentUrl { get; set; }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [DataMember(Name = "seller", Order = 225)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Seller { get; set; }

        /// <inheritdoc/>
        public bool Equals(Order other)
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
                this.AcceptedOffer == other.AcceptedOffer &&
                this.BillingAddress == other.BillingAddress &&
                this.Broker == other.Broker &&
                this.ConfirmationNumber == other.ConfirmationNumber &&
                this.Customer == other.Customer &&
                this.Discount == other.Discount &&
                this.DiscountCode == other.DiscountCode &&
                this.DiscountCurrency == other.DiscountCurrency &&
                this.IsGift == other.IsGift &&
                this.OrderDate == other.OrderDate &&
                this.OrderDelivery == other.OrderDelivery &&
                this.OrderedItem == other.OrderedItem &&
                this.OrderNumber == other.OrderNumber &&
                this.OrderStatus == other.OrderStatus &&
                this.PartOfInvoice == other.PartOfInvoice &&
                this.PaymentDueDate == other.PaymentDueDate &&
                this.PaymentMethod == other.PaymentMethod &&
                this.PaymentMethodId == other.PaymentMethodId &&
                this.PaymentUrl == other.PaymentUrl &&
                this.Seller == other.Seller &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Order);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AcceptedOffer)
            .And(this.BillingAddress)
            .And(this.Broker)
            .And(this.ConfirmationNumber)
            .And(this.Customer)
            .And(this.Discount)
            .And(this.DiscountCode)
            .And(this.DiscountCurrency)
            .And(this.IsGift)
            .And(this.OrderDate)
            .And(this.OrderDelivery)
            .And(this.OrderedItem)
            .And(this.OrderNumber)
            .And(this.OrderStatus)
            .And(this.PartOfInvoice)
            .And(this.PaymentDueDate)
            .And(this.PaymentMethod)
            .And(this.PaymentMethodId)
            .And(this.PaymentUrl)
            .And(this.Seller)
            .And(base.GetHashCode());
    }
}
