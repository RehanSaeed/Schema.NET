using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
    [DataContract]
    public partial class Order : Intangible
    {
        public interface IBroker : IWrapper { }
        public interface IBroker<T> : IBroker { new T Data { get; set; } }
        public class BrokerOrganization : IBroker<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public BrokerOrganization () { }
            public BrokerOrganization (Organization data) { Data = data; }
            public static implicit operator BrokerOrganization (Organization data) { return new BrokerOrganization (data); }
        }

        public class BrokerPerson : IBroker<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public BrokerPerson () { }
            public BrokerPerson (Person data) { Data = data; }
            public static implicit operator BrokerPerson (Person data) { return new BrokerPerson (data); }
        }


        public interface ICustomer : IWrapper { }
        public interface ICustomer<T> : ICustomer { new T Data { get; set; } }
        public class CustomerOrganization : ICustomer<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public CustomerOrganization () { }
            public CustomerOrganization (Organization data) { Data = data; }
            public static implicit operator CustomerOrganization (Organization data) { return new CustomerOrganization (data); }
        }

        public class CustomerPerson : ICustomer<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public CustomerPerson () { }
            public CustomerPerson (Person data) { Data = data; }
            public static implicit operator CustomerPerson (Person data) { return new CustomerPerson (data); }
        }


        public interface IDiscount : IWrapper { }
        public interface IDiscount<T> : IDiscount { new T Data { get; set; } }
        public class Discountdecimal : IDiscount<decimal>
        {
            object IWrapper.Data { get { return Data; } set { Data = (decimal) value; } }
            public virtual decimal Data { get; set; }
            public Discountdecimal () { }
            public Discountdecimal (decimal data) { Data = data; }
            public static implicit operator Discountdecimal (decimal data) { return new Discountdecimal (data); }
        }

        public class Discountstring : IDiscount<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Discountstring () { }
            public Discountstring (string data) { Data = data; }
            public static implicit operator Discountstring (string data) { return new Discountstring (data); }
        }


        public interface IOrderedItem : IWrapper { }
        public interface IOrderedItem<T> : IOrderedItem { new T Data { get; set; } }
        public class OrderedItemOrderItem : IOrderedItem<OrderItem>
        {
            object IWrapper.Data { get { return Data; } set { Data = (OrderItem) value; } }
            public virtual OrderItem Data { get; set; }
            public OrderedItemOrderItem () { }
            public OrderedItemOrderItem (OrderItem data) { Data = data; }
            public static implicit operator OrderedItemOrderItem (OrderItem data) { return new OrderedItemOrderItem (data); }
        }

        public class OrderedItemProduct : IOrderedItem<Product>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Product) value; } }
            public virtual Product Data { get; set; }
            public OrderedItemProduct () { }
            public OrderedItemProduct (Product data) { Data = data; }
            public static implicit operator OrderedItemProduct (Product data) { return new OrderedItemProduct (data); }
        }


        public interface ISeller : IWrapper { }
        public interface ISeller<T> : ISeller { new T Data { get; set; } }
        public class SellerOrganization : ISeller<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public SellerOrganization () { }
            public SellerOrganization (Organization data) { Data = data; }
            public static implicit operator SellerOrganization (Organization data) { return new SellerOrganization (data); }
        }

        public class SellerPerson : ISeller<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public SellerPerson () { }
            public SellerPerson (Person data) { Data = data; }
            public static implicit operator SellerPerson (Person data) { return new SellerPerson (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Order";

        /// <summary>
        /// The offer(s) -- e.g., product, quantity and price combinations -- included in the order.
        /// </summary>
        [DataMember(Name = "acceptedOffer", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Offer>? AcceptedOffer { get; set; } 

        /// <summary>
        /// The billing address for the order.
        /// </summary>
        [DataMember(Name = "billingAddress", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PostalAddress>? BillingAddress { get; set; } 

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [DataMember(Name = "broker", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IBroker>? Broker { get; set; } //Organization, Person

        /// <summary>
        /// A number that confirms the given order or payment has been received.
        /// </summary>
        [DataMember(Name = "confirmationNumber", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ConfirmationNumber { get; set; } 

        /// <summary>
        /// Party placing the order or paying the invoice.
        /// </summary>
        [DataMember(Name = "customer", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ICustomer>? Customer { get; set; } //Organization, Person

        /// <summary>
        /// Any discount applied (to an Order).
        /// </summary>
        [DataMember(Name = "discount", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IDiscount>? Discount { get; set; } //decimal?, string

        /// <summary>
        /// Code used to redeem a discount.
        /// </summary>
        [DataMember(Name = "discountCode", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? DiscountCode { get; set; } 

        /// <summary>
        /// The currency (in 3-letter ISO 4217 format) of the discount.
        /// </summary>
        [DataMember(Name = "discountCurrency", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? DiscountCurrency { get; set; } 

        /// <summary>
        /// Was the offer accepted as a gift for someone other than the buyer.
        /// </summary>
        [DataMember(Name = "isGift", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<bool>? IsGift { get; set; } 

        /// <summary>
        /// Date order was placed.
        /// </summary>
        [DataMember(Name = "orderDate", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? OrderDate { get; set; } 

        /// <summary>
        /// The delivery of the parcel related to this order or order item.
        /// </summary>
        [DataMember(Name = "orderDelivery", Order = 216)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ParcelDelivery>? OrderDelivery { get; set; } 

        /// <summary>
        /// The item ordered.
        /// </summary>
        [DataMember(Name = "orderedItem", Order = 217)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IOrderedItem>? OrderedItem { get; set; } //OrderItem, Product

        /// <summary>
        /// The identifier of the transaction.
        /// </summary>
        [DataMember(Name = "orderNumber", Order = 218)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? OrderNumber { get; set; } 

        /// <summary>
        /// The current status of the order.
        /// </summary>
        [DataMember(Name = "orderStatus", Order = 219)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<OrderStatus>? OrderStatus { get; set; } 

        /// <summary>
        /// The order is being paid as part of the referenced Invoice.
        /// </summary>
        [DataMember(Name = "partOfInvoice", Order = 220)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Invoice>? PartOfInvoice { get; set; } 

        /// <summary>
        /// The date that payment is due.
        /// </summary>
        [DataMember(Name = "paymentDueDate", Order = 221)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? PaymentDueDate { get; set; } 

        /// <summary>
        /// The name of the credit card or other method of payment for the order.
        /// </summary>
        [DataMember(Name = "paymentMethod", Order = 222)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PaymentMethod>? PaymentMethod { get; set; } 

        /// <summary>
        /// An identifier for the method of payment used (e.g. the last 4 digits of the credit card).
        /// </summary>
        [DataMember(Name = "paymentMethodId", Order = 223)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PaymentMethodId { get; set; } 

        /// <summary>
        /// The URL for sending a payment.
        /// </summary>
        [DataMember(Name = "paymentUrl", Order = 224)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? PaymentUrl { get; set; } 

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [DataMember(Name = "seller", Order = 225)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ISeller>? Seller { get; set; } //Organization, Person
    }
}
