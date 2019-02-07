namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
    [DataContract]
    public partial class Order : Intangible
    {
        public interface IAcceptedOffer : IValue {}
        public interface IAcceptedOffer<T> : IAcceptedOffer { new T Value { get; } }
        public class OneOrManyAcceptedOffer : OneOrMany<IAcceptedOffer>
        {
            public OneOrManyAcceptedOffer(IAcceptedOffer item) : base(item) { }
            public OneOrManyAcceptedOffer(IEnumerable<IAcceptedOffer> items) : base(items) { }
            public static implicit operator OneOrManyAcceptedOffer (Offer value) { return new OneOrManyAcceptedOffer (new AcceptedOfferOffer (value)); }
            public static implicit operator OneOrManyAcceptedOffer (Offer[] values) { return new OneOrManyAcceptedOffer (values.Select(v => (IAcceptedOffer) new AcceptedOfferOffer (v))); }
            public static implicit operator OneOrManyAcceptedOffer (List<Offer> values) { return new OneOrManyAcceptedOffer (values.Select(v => (IAcceptedOffer) new AcceptedOfferOffer (v))); }
        }
        public struct AcceptedOfferOffer : IAcceptedOffer<Offer>
        {
            object IValue.Value => this.Value;
            public Offer Value { get; }
            public AcceptedOfferOffer (Offer value) { Value = value; }
            public static implicit operator AcceptedOfferOffer (Offer value) { return new AcceptedOfferOffer (value); }
        }

        public interface IBillingAddress : IValue {}
        public interface IBillingAddress<T> : IBillingAddress { new T Value { get; } }
        public class OneOrManyBillingAddress : OneOrMany<IBillingAddress>
        {
            public OneOrManyBillingAddress(IBillingAddress item) : base(item) { }
            public OneOrManyBillingAddress(IEnumerable<IBillingAddress> items) : base(items) { }
            public static implicit operator OneOrManyBillingAddress (PostalAddress value) { return new OneOrManyBillingAddress (new BillingAddressPostalAddress (value)); }
            public static implicit operator OneOrManyBillingAddress (PostalAddress[] values) { return new OneOrManyBillingAddress (values.Select(v => (IBillingAddress) new BillingAddressPostalAddress (v))); }
            public static implicit operator OneOrManyBillingAddress (List<PostalAddress> values) { return new OneOrManyBillingAddress (values.Select(v => (IBillingAddress) new BillingAddressPostalAddress (v))); }
        }
        public struct BillingAddressPostalAddress : IBillingAddress<PostalAddress>
        {
            object IValue.Value => this.Value;
            public PostalAddress Value { get; }
            public BillingAddressPostalAddress (PostalAddress value) { Value = value; }
            public static implicit operator BillingAddressPostalAddress (PostalAddress value) { return new BillingAddressPostalAddress (value); }
        }

        public interface IBroker : IValue {}
        public interface IBroker<T> : IBroker { new T Value { get; } }
        public class OneOrManyBroker : OneOrMany<IBroker>
        {
            public OneOrManyBroker(IBroker item) : base(item) { }
            public OneOrManyBroker(IEnumerable<IBroker> items) : base(items) { }
            public static implicit operator OneOrManyBroker (Organization value) { return new OneOrManyBroker (new BrokerOrganization (value)); }
            public static implicit operator OneOrManyBroker (Organization[] values) { return new OneOrManyBroker (values.Select(v => (IBroker) new BrokerOrganization (v))); }
            public static implicit operator OneOrManyBroker (List<Organization> values) { return new OneOrManyBroker (values.Select(v => (IBroker) new BrokerOrganization (v))); }
            public static implicit operator OneOrManyBroker (Person value) { return new OneOrManyBroker (new BrokerPerson (value)); }
            public static implicit operator OneOrManyBroker (Person[] values) { return new OneOrManyBroker (values.Select(v => (IBroker) new BrokerPerson (v))); }
            public static implicit operator OneOrManyBroker (List<Person> values) { return new OneOrManyBroker (values.Select(v => (IBroker) new BrokerPerson (v))); }
        }
        public struct BrokerOrganization : IBroker<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public BrokerOrganization (Organization value) { Value = value; }
            public static implicit operator BrokerOrganization (Organization value) { return new BrokerOrganization (value); }
        }
        public struct BrokerPerson : IBroker<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public BrokerPerson (Person value) { Value = value; }
            public static implicit operator BrokerPerson (Person value) { return new BrokerPerson (value); }
        }

        public interface IConfirmationNumber : IValue {}
        public interface IConfirmationNumber<T> : IConfirmationNumber { new T Value { get; } }
        public class OneOrManyConfirmationNumber : OneOrMany<IConfirmationNumber>
        {
            public OneOrManyConfirmationNumber(IConfirmationNumber item) : base(item) { }
            public OneOrManyConfirmationNumber(IEnumerable<IConfirmationNumber> items) : base(items) { }
            public static implicit operator OneOrManyConfirmationNumber (string value) { return new OneOrManyConfirmationNumber (new ConfirmationNumberstring (value)); }
            public static implicit operator OneOrManyConfirmationNumber (string[] values) { return new OneOrManyConfirmationNumber (values.Select(v => (IConfirmationNumber) new ConfirmationNumberstring (v))); }
            public static implicit operator OneOrManyConfirmationNumber (List<string> values) { return new OneOrManyConfirmationNumber (values.Select(v => (IConfirmationNumber) new ConfirmationNumberstring (v))); }
        }
        public struct ConfirmationNumberstring : IConfirmationNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ConfirmationNumberstring (string value) { Value = value; }
            public static implicit operator ConfirmationNumberstring (string value) { return new ConfirmationNumberstring (value); }
        }

        public interface ICustomer : IValue {}
        public interface ICustomer<T> : ICustomer { new T Value { get; } }
        public class OneOrManyCustomer : OneOrMany<ICustomer>
        {
            public OneOrManyCustomer(ICustomer item) : base(item) { }
            public OneOrManyCustomer(IEnumerable<ICustomer> items) : base(items) { }
            public static implicit operator OneOrManyCustomer (Organization value) { return new OneOrManyCustomer (new CustomerOrganization (value)); }
            public static implicit operator OneOrManyCustomer (Organization[] values) { return new OneOrManyCustomer (values.Select(v => (ICustomer) new CustomerOrganization (v))); }
            public static implicit operator OneOrManyCustomer (List<Organization> values) { return new OneOrManyCustomer (values.Select(v => (ICustomer) new CustomerOrganization (v))); }
            public static implicit operator OneOrManyCustomer (Person value) { return new OneOrManyCustomer (new CustomerPerson (value)); }
            public static implicit operator OneOrManyCustomer (Person[] values) { return new OneOrManyCustomer (values.Select(v => (ICustomer) new CustomerPerson (v))); }
            public static implicit operator OneOrManyCustomer (List<Person> values) { return new OneOrManyCustomer (values.Select(v => (ICustomer) new CustomerPerson (v))); }
        }
        public struct CustomerOrganization : ICustomer<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public CustomerOrganization (Organization value) { Value = value; }
            public static implicit operator CustomerOrganization (Organization value) { return new CustomerOrganization (value); }
        }
        public struct CustomerPerson : ICustomer<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public CustomerPerson (Person value) { Value = value; }
            public static implicit operator CustomerPerson (Person value) { return new CustomerPerson (value); }
        }

        public interface IDiscount : IValue {}
        public interface IDiscount<T> : IDiscount { new T Value { get; } }
        public class OneOrManyDiscount : OneOrMany<IDiscount>
        {
            public OneOrManyDiscount(IDiscount item) : base(item) { }
            public OneOrManyDiscount(IEnumerable<IDiscount> items) : base(items) { }
            public static implicit operator OneOrManyDiscount (decimal value) { return new OneOrManyDiscount (new Discountdecimal (value)); }
            public static implicit operator OneOrManyDiscount (decimal[] values) { return new OneOrManyDiscount (values.Select(v => (IDiscount) new Discountdecimal (v))); }
            public static implicit operator OneOrManyDiscount (List<decimal> values) { return new OneOrManyDiscount (values.Select(v => (IDiscount) new Discountdecimal (v))); }
            public static implicit operator OneOrManyDiscount (string value) { return new OneOrManyDiscount (new Discountstring (value)); }
            public static implicit operator OneOrManyDiscount (string[] values) { return new OneOrManyDiscount (values.Select(v => (IDiscount) new Discountstring (v))); }
            public static implicit operator OneOrManyDiscount (List<string> values) { return new OneOrManyDiscount (values.Select(v => (IDiscount) new Discountstring (v))); }
        }
        public struct Discountdecimal : IDiscount<decimal>
        {
            object IValue.Value => this.Value;
            public decimal Value { get; }
            public Discountdecimal (decimal value) { Value = value; }
            public static implicit operator Discountdecimal (decimal value) { return new Discountdecimal (value); }
        }
        public struct Discountstring : IDiscount<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Discountstring (string value) { Value = value; }
            public static implicit operator Discountstring (string value) { return new Discountstring (value); }
        }

        public interface IDiscountCode : IValue {}
        public interface IDiscountCode<T> : IDiscountCode { new T Value { get; } }
        public class OneOrManyDiscountCode : OneOrMany<IDiscountCode>
        {
            public OneOrManyDiscountCode(IDiscountCode item) : base(item) { }
            public OneOrManyDiscountCode(IEnumerable<IDiscountCode> items) : base(items) { }
            public static implicit operator OneOrManyDiscountCode (string value) { return new OneOrManyDiscountCode (new DiscountCodestring (value)); }
            public static implicit operator OneOrManyDiscountCode (string[] values) { return new OneOrManyDiscountCode (values.Select(v => (IDiscountCode) new DiscountCodestring (v))); }
            public static implicit operator OneOrManyDiscountCode (List<string> values) { return new OneOrManyDiscountCode (values.Select(v => (IDiscountCode) new DiscountCodestring (v))); }
        }
        public struct DiscountCodestring : IDiscountCode<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public DiscountCodestring (string value) { Value = value; }
            public static implicit operator DiscountCodestring (string value) { return new DiscountCodestring (value); }
        }

        public interface IDiscountCurrency : IValue {}
        public interface IDiscountCurrency<T> : IDiscountCurrency { new T Value { get; } }
        public class OneOrManyDiscountCurrency : OneOrMany<IDiscountCurrency>
        {
            public OneOrManyDiscountCurrency(IDiscountCurrency item) : base(item) { }
            public OneOrManyDiscountCurrency(IEnumerable<IDiscountCurrency> items) : base(items) { }
            public static implicit operator OneOrManyDiscountCurrency (string value) { return new OneOrManyDiscountCurrency (new DiscountCurrencystring (value)); }
            public static implicit operator OneOrManyDiscountCurrency (string[] values) { return new OneOrManyDiscountCurrency (values.Select(v => (IDiscountCurrency) new DiscountCurrencystring (v))); }
            public static implicit operator OneOrManyDiscountCurrency (List<string> values) { return new OneOrManyDiscountCurrency (values.Select(v => (IDiscountCurrency) new DiscountCurrencystring (v))); }
        }
        public struct DiscountCurrencystring : IDiscountCurrency<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public DiscountCurrencystring (string value) { Value = value; }
            public static implicit operator DiscountCurrencystring (string value) { return new DiscountCurrencystring (value); }
        }

        public interface IIsGift : IValue {}
        public interface IIsGift<T> : IIsGift { new T Value { get; } }
        public class OneOrManyIsGift : OneOrMany<IIsGift>
        {
            public OneOrManyIsGift(IIsGift item) : base(item) { }
            public OneOrManyIsGift(IEnumerable<IIsGift> items) : base(items) { }
            public static implicit operator OneOrManyIsGift (bool value) { return new OneOrManyIsGift (new IsGiftbool (value)); }
            public static implicit operator OneOrManyIsGift (bool[] values) { return new OneOrManyIsGift (values.Select(v => (IIsGift) new IsGiftbool (v))); }
            public static implicit operator OneOrManyIsGift (List<bool> values) { return new OneOrManyIsGift (values.Select(v => (IIsGift) new IsGiftbool (v))); }
        }
        public struct IsGiftbool : IIsGift<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public IsGiftbool (bool value) { Value = value; }
            public static implicit operator IsGiftbool (bool value) { return new IsGiftbool (value); }
        }

        public interface IOrderDate : IValue {}
        public interface IOrderDate<T> : IOrderDate { new T Value { get; } }
        public class OneOrManyOrderDate : OneOrMany<IOrderDate>
        {
            public OneOrManyOrderDate(IOrderDate item) : base(item) { }
            public OneOrManyOrderDate(IEnumerable<IOrderDate> items) : base(items) { }
            public static implicit operator OneOrManyOrderDate (DateTimeOffset value) { return new OneOrManyOrderDate (new OrderDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyOrderDate (DateTimeOffset[] values) { return new OneOrManyOrderDate (values.Select(v => (IOrderDate) new OrderDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyOrderDate (List<DateTimeOffset> values) { return new OneOrManyOrderDate (values.Select(v => (IOrderDate) new OrderDateDateTimeOffset (v))); }
        }
        public struct OrderDateDateTimeOffset : IOrderDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public OrderDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator OrderDateDateTimeOffset (DateTimeOffset value) { return new OrderDateDateTimeOffset (value); }
        }

        public interface IOrderDelivery : IValue {}
        public interface IOrderDelivery<T> : IOrderDelivery { new T Value { get; } }
        public class OneOrManyOrderDelivery : OneOrMany<IOrderDelivery>
        {
            public OneOrManyOrderDelivery(IOrderDelivery item) : base(item) { }
            public OneOrManyOrderDelivery(IEnumerable<IOrderDelivery> items) : base(items) { }
            public static implicit operator OneOrManyOrderDelivery (ParcelDelivery value) { return new OneOrManyOrderDelivery (new OrderDeliveryParcelDelivery (value)); }
            public static implicit operator OneOrManyOrderDelivery (ParcelDelivery[] values) { return new OneOrManyOrderDelivery (values.Select(v => (IOrderDelivery) new OrderDeliveryParcelDelivery (v))); }
            public static implicit operator OneOrManyOrderDelivery (List<ParcelDelivery> values) { return new OneOrManyOrderDelivery (values.Select(v => (IOrderDelivery) new OrderDeliveryParcelDelivery (v))); }
        }
        public struct OrderDeliveryParcelDelivery : IOrderDelivery<ParcelDelivery>
        {
            object IValue.Value => this.Value;
            public ParcelDelivery Value { get; }
            public OrderDeliveryParcelDelivery (ParcelDelivery value) { Value = value; }
            public static implicit operator OrderDeliveryParcelDelivery (ParcelDelivery value) { return new OrderDeliveryParcelDelivery (value); }
        }

        public interface IOrderedItem : IValue {}
        public interface IOrderedItem<T> : IOrderedItem { new T Value { get; } }
        public class OneOrManyOrderedItem : OneOrMany<IOrderedItem>
        {
            public OneOrManyOrderedItem(IOrderedItem item) : base(item) { }
            public OneOrManyOrderedItem(IEnumerable<IOrderedItem> items) : base(items) { }
            public static implicit operator OneOrManyOrderedItem (OrderItem value) { return new OneOrManyOrderedItem (new OrderedItemOrderItem (value)); }
            public static implicit operator OneOrManyOrderedItem (OrderItem[] values) { return new OneOrManyOrderedItem (values.Select(v => (IOrderedItem) new OrderedItemOrderItem (v))); }
            public static implicit operator OneOrManyOrderedItem (List<OrderItem> values) { return new OneOrManyOrderedItem (values.Select(v => (IOrderedItem) new OrderedItemOrderItem (v))); }
            public static implicit operator OneOrManyOrderedItem (Product value) { return new OneOrManyOrderedItem (new OrderedItemProduct (value)); }
            public static implicit operator OneOrManyOrderedItem (Product[] values) { return new OneOrManyOrderedItem (values.Select(v => (IOrderedItem) new OrderedItemProduct (v))); }
            public static implicit operator OneOrManyOrderedItem (List<Product> values) { return new OneOrManyOrderedItem (values.Select(v => (IOrderedItem) new OrderedItemProduct (v))); }
        }
        public struct OrderedItemOrderItem : IOrderedItem<OrderItem>
        {
            object IValue.Value => this.Value;
            public OrderItem Value { get; }
            public OrderedItemOrderItem (OrderItem value) { Value = value; }
            public static implicit operator OrderedItemOrderItem (OrderItem value) { return new OrderedItemOrderItem (value); }
        }
        public struct OrderedItemProduct : IOrderedItem<Product>
        {
            object IValue.Value => this.Value;
            public Product Value { get; }
            public OrderedItemProduct (Product value) { Value = value; }
            public static implicit operator OrderedItemProduct (Product value) { return new OrderedItemProduct (value); }
        }

        public interface IOrderNumber : IValue {}
        public interface IOrderNumber<T> : IOrderNumber { new T Value { get; } }
        public class OneOrManyOrderNumber : OneOrMany<IOrderNumber>
        {
            public OneOrManyOrderNumber(IOrderNumber item) : base(item) { }
            public OneOrManyOrderNumber(IEnumerable<IOrderNumber> items) : base(items) { }
            public static implicit operator OneOrManyOrderNumber (string value) { return new OneOrManyOrderNumber (new OrderNumberstring (value)); }
            public static implicit operator OneOrManyOrderNumber (string[] values) { return new OneOrManyOrderNumber (values.Select(v => (IOrderNumber) new OrderNumberstring (v))); }
            public static implicit operator OneOrManyOrderNumber (List<string> values) { return new OneOrManyOrderNumber (values.Select(v => (IOrderNumber) new OrderNumberstring (v))); }
        }
        public struct OrderNumberstring : IOrderNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public OrderNumberstring (string value) { Value = value; }
            public static implicit operator OrderNumberstring (string value) { return new OrderNumberstring (value); }
        }

        public interface IOrderStatus : IValue {}
        public interface IOrderStatus<T> : IOrderStatus { new T Value { get; } }
        public class OneOrManyOrderStatus : OneOrMany<IOrderStatus>
        {
            public OneOrManyOrderStatus(IOrderStatus item) : base(item) { }
            public OneOrManyOrderStatus(IEnumerable<IOrderStatus> items) : base(items) { }
            public static implicit operator OneOrManyOrderStatus (OrderStatus value) { return new OneOrManyOrderStatus (new OrderStatusOrderStatus (value)); }
            public static implicit operator OneOrManyOrderStatus (OrderStatus[] values) { return new OneOrManyOrderStatus (values.Select(v => (IOrderStatus) new OrderStatusOrderStatus (v))); }
            public static implicit operator OneOrManyOrderStatus (List<OrderStatus> values) { return new OneOrManyOrderStatus (values.Select(v => (IOrderStatus) new OrderStatusOrderStatus (v))); }
        }
        public struct OrderStatusOrderStatus : IOrderStatus<OrderStatus>
        {
            object IValue.Value => this.Value;
            public OrderStatus Value { get; }
            public OrderStatusOrderStatus (OrderStatus value) { Value = value; }
            public static implicit operator OrderStatusOrderStatus (OrderStatus value) { return new OrderStatusOrderStatus (value); }
        }

        public interface IPartOfInvoice : IValue {}
        public interface IPartOfInvoice<T> : IPartOfInvoice { new T Value { get; } }
        public class OneOrManyPartOfInvoice : OneOrMany<IPartOfInvoice>
        {
            public OneOrManyPartOfInvoice(IPartOfInvoice item) : base(item) { }
            public OneOrManyPartOfInvoice(IEnumerable<IPartOfInvoice> items) : base(items) { }
            public static implicit operator OneOrManyPartOfInvoice (Invoice value) { return new OneOrManyPartOfInvoice (new PartOfInvoiceInvoice (value)); }
            public static implicit operator OneOrManyPartOfInvoice (Invoice[] values) { return new OneOrManyPartOfInvoice (values.Select(v => (IPartOfInvoice) new PartOfInvoiceInvoice (v))); }
            public static implicit operator OneOrManyPartOfInvoice (List<Invoice> values) { return new OneOrManyPartOfInvoice (values.Select(v => (IPartOfInvoice) new PartOfInvoiceInvoice (v))); }
        }
        public struct PartOfInvoiceInvoice : IPartOfInvoice<Invoice>
        {
            object IValue.Value => this.Value;
            public Invoice Value { get; }
            public PartOfInvoiceInvoice (Invoice value) { Value = value; }
            public static implicit operator PartOfInvoiceInvoice (Invoice value) { return new PartOfInvoiceInvoice (value); }
        }

        public interface IPaymentDueDate : IValue {}
        public interface IPaymentDueDate<T> : IPaymentDueDate { new T Value { get; } }
        public class OneOrManyPaymentDueDate : OneOrMany<IPaymentDueDate>
        {
            public OneOrManyPaymentDueDate(IPaymentDueDate item) : base(item) { }
            public OneOrManyPaymentDueDate(IEnumerable<IPaymentDueDate> items) : base(items) { }
            public static implicit operator OneOrManyPaymentDueDate (DateTimeOffset value) { return new OneOrManyPaymentDueDate (new PaymentDueDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyPaymentDueDate (DateTimeOffset[] values) { return new OneOrManyPaymentDueDate (values.Select(v => (IPaymentDueDate) new PaymentDueDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyPaymentDueDate (List<DateTimeOffset> values) { return new OneOrManyPaymentDueDate (values.Select(v => (IPaymentDueDate) new PaymentDueDateDateTimeOffset (v))); }
        }
        public struct PaymentDueDateDateTimeOffset : IPaymentDueDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public PaymentDueDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator PaymentDueDateDateTimeOffset (DateTimeOffset value) { return new PaymentDueDateDateTimeOffset (value); }
        }

        public interface IPaymentMethod : IValue {}
        public interface IPaymentMethod<T> : IPaymentMethod { new T Value { get; } }
        public class OneOrManyPaymentMethod : OneOrMany<IPaymentMethod>
        {
            public OneOrManyPaymentMethod(IPaymentMethod item) : base(item) { }
            public OneOrManyPaymentMethod(IEnumerable<IPaymentMethod> items) : base(items) { }
            public static implicit operator OneOrManyPaymentMethod (PaymentMethod value) { return new OneOrManyPaymentMethod (new PaymentMethodPaymentMethod (value)); }
            public static implicit operator OneOrManyPaymentMethod (PaymentMethod[] values) { return new OneOrManyPaymentMethod (values.Select(v => (IPaymentMethod) new PaymentMethodPaymentMethod (v))); }
            public static implicit operator OneOrManyPaymentMethod (List<PaymentMethod> values) { return new OneOrManyPaymentMethod (values.Select(v => (IPaymentMethod) new PaymentMethodPaymentMethod (v))); }
        }
        public struct PaymentMethodPaymentMethod : IPaymentMethod<PaymentMethod>
        {
            object IValue.Value => this.Value;
            public PaymentMethod Value { get; }
            public PaymentMethodPaymentMethod (PaymentMethod value) { Value = value; }
            public static implicit operator PaymentMethodPaymentMethod (PaymentMethod value) { return new PaymentMethodPaymentMethod (value); }
        }

        public interface IPaymentMethodId : IValue {}
        public interface IPaymentMethodId<T> : IPaymentMethodId { new T Value { get; } }
        public class OneOrManyPaymentMethodId : OneOrMany<IPaymentMethodId>
        {
            public OneOrManyPaymentMethodId(IPaymentMethodId item) : base(item) { }
            public OneOrManyPaymentMethodId(IEnumerable<IPaymentMethodId> items) : base(items) { }
            public static implicit operator OneOrManyPaymentMethodId (string value) { return new OneOrManyPaymentMethodId (new PaymentMethodIdstring (value)); }
            public static implicit operator OneOrManyPaymentMethodId (string[] values) { return new OneOrManyPaymentMethodId (values.Select(v => (IPaymentMethodId) new PaymentMethodIdstring (v))); }
            public static implicit operator OneOrManyPaymentMethodId (List<string> values) { return new OneOrManyPaymentMethodId (values.Select(v => (IPaymentMethodId) new PaymentMethodIdstring (v))); }
        }
        public struct PaymentMethodIdstring : IPaymentMethodId<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PaymentMethodIdstring (string value) { Value = value; }
            public static implicit operator PaymentMethodIdstring (string value) { return new PaymentMethodIdstring (value); }
        }

        public interface IPaymentUrl : IValue {}
        public interface IPaymentUrl<T> : IPaymentUrl { new T Value { get; } }
        public class OneOrManyPaymentUrl : OneOrMany<IPaymentUrl>
        {
            public OneOrManyPaymentUrl(IPaymentUrl item) : base(item) { }
            public OneOrManyPaymentUrl(IEnumerable<IPaymentUrl> items) : base(items) { }
            public static implicit operator OneOrManyPaymentUrl (Uri value) { return new OneOrManyPaymentUrl (new PaymentUrlUri (value)); }
            public static implicit operator OneOrManyPaymentUrl (Uri[] values) { return new OneOrManyPaymentUrl (values.Select(v => (IPaymentUrl) new PaymentUrlUri (v))); }
            public static implicit operator OneOrManyPaymentUrl (List<Uri> values) { return new OneOrManyPaymentUrl (values.Select(v => (IPaymentUrl) new PaymentUrlUri (v))); }
        }
        public struct PaymentUrlUri : IPaymentUrl<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public PaymentUrlUri (Uri value) { Value = value; }
            public static implicit operator PaymentUrlUri (Uri value) { return new PaymentUrlUri (value); }
        }

        public interface ISeller : IValue {}
        public interface ISeller<T> : ISeller { new T Value { get; } }
        public class OneOrManySeller : OneOrMany<ISeller>
        {
            public OneOrManySeller(ISeller item) : base(item) { }
            public OneOrManySeller(IEnumerable<ISeller> items) : base(items) { }
            public static implicit operator OneOrManySeller (Organization value) { return new OneOrManySeller (new SellerOrganization (value)); }
            public static implicit operator OneOrManySeller (Organization[] values) { return new OneOrManySeller (values.Select(v => (ISeller) new SellerOrganization (v))); }
            public static implicit operator OneOrManySeller (List<Organization> values) { return new OneOrManySeller (values.Select(v => (ISeller) new SellerOrganization (v))); }
            public static implicit operator OneOrManySeller (Person value) { return new OneOrManySeller (new SellerPerson (value)); }
            public static implicit operator OneOrManySeller (Person[] values) { return new OneOrManySeller (values.Select(v => (ISeller) new SellerPerson (v))); }
            public static implicit operator OneOrManySeller (List<Person> values) { return new OneOrManySeller (values.Select(v => (ISeller) new SellerPerson (v))); }
        }
        public struct SellerOrganization : ISeller<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public SellerOrganization (Organization value) { Value = value; }
            public static implicit operator SellerOrganization (Organization value) { return new SellerOrganization (value); }
        }
        public struct SellerPerson : ISeller<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public SellerPerson (Person value) { Value = value; }
            public static implicit operator SellerPerson (Person value) { return new SellerPerson (value); }
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
        public OneOrManyAcceptedOffer AcceptedOffer { get; set; }

        /// <summary>
        /// The billing address for the order.
        /// </summary>
        [DataMember(Name = "billingAddress", Order = 207)]
        public OneOrManyBillingAddress BillingAddress { get; set; }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [DataMember(Name = "broker", Order = 208)]
        public OneOrManyBroker Broker { get; set; }

        /// <summary>
        /// A number that confirms the given order or payment has been received.
        /// </summary>
        [DataMember(Name = "confirmationNumber", Order = 209)]
        public OneOrManyConfirmationNumber ConfirmationNumber { get; set; }

        /// <summary>
        /// Party placing the order or paying the invoice.
        /// </summary>
        [DataMember(Name = "customer", Order = 210)]
        public OneOrManyCustomer Customer { get; set; }

        /// <summary>
        /// Any discount applied (to an Order).
        /// </summary>
        [DataMember(Name = "discount", Order = 211)]
        public OneOrManyDiscount Discount { get; set; }

        /// <summary>
        /// Code used to redeem a discount.
        /// </summary>
        [DataMember(Name = "discountCode", Order = 212)]
        public OneOrManyDiscountCode DiscountCode { get; set; }

        /// <summary>
        /// The currency of the discount.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        [DataMember(Name = "discountCurrency", Order = 213)]
        public OneOrManyDiscountCurrency DiscountCurrency { get; set; }

        /// <summary>
        /// Was the offer accepted as a gift for someone other than the buyer.
        /// </summary>
        [DataMember(Name = "isGift", Order = 214)]
        public OneOrManyIsGift IsGift { get; set; }

        /// <summary>
        /// Date order was placed.
        /// </summary>
        [DataMember(Name = "orderDate", Order = 215)]
        public OneOrManyOrderDate OrderDate { get; set; }

        /// <summary>
        /// The delivery of the parcel related to this order or order item.
        /// </summary>
        [DataMember(Name = "orderDelivery", Order = 216)]
        public OneOrManyOrderDelivery OrderDelivery { get; set; }

        /// <summary>
        /// The item ordered.
        /// </summary>
        [DataMember(Name = "orderedItem", Order = 217)]
        public OneOrManyOrderedItem OrderedItem { get; set; }

        /// <summary>
        /// The identifier of the transaction.
        /// </summary>
        [DataMember(Name = "orderNumber", Order = 218)]
        public OneOrManyOrderNumber OrderNumber { get; set; }

        /// <summary>
        /// The current status of the order.
        /// </summary>
        [DataMember(Name = "orderStatus", Order = 219)]
        public OneOrManyOrderStatus OrderStatus { get; set; }

        /// <summary>
        /// The order is being paid as part of the referenced Invoice.
        /// </summary>
        [DataMember(Name = "partOfInvoice", Order = 220)]
        public OneOrManyPartOfInvoice PartOfInvoice { get; set; }

        /// <summary>
        /// The date that payment is due.
        /// </summary>
        [DataMember(Name = "paymentDueDate", Order = 221)]
        public OneOrManyPaymentDueDate PaymentDueDate { get; set; }

        /// <summary>
        /// The name of the credit card or other method of payment for the order.
        /// </summary>
        [DataMember(Name = "paymentMethod", Order = 222)]
        public OneOrManyPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// An identifier for the method of payment used (e.g. the last 4 digits of the credit card).
        /// </summary>
        [DataMember(Name = "paymentMethodId", Order = 223)]
        public OneOrManyPaymentMethodId PaymentMethodId { get; set; }

        /// <summary>
        /// The URL for sending a payment.
        /// </summary>
        [DataMember(Name = "paymentUrl", Order = 224)]
        public OneOrManyPaymentUrl PaymentUrl { get; set; }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [DataMember(Name = "seller", Order = 225)]
        public OneOrManySeller Seller { get; set; }
    }
}
