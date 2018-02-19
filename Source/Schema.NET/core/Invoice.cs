using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
    [DataContract]
    public partial class Invoice : Intangible
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


        public interface ICategory : IWrapper { }
        public interface ICategory<T> : ICategory { new T Data { get; set; } }
        public class Categorystring : ICategory<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Categorystring () { }
            public Categorystring (string data) { Data = data; }
            public static implicit operator Categorystring (string data) { return new Categorystring (data); }
        }

        public class CategoryThing : ICategory<Thing>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Thing) value; } }
            public virtual Thing Data { get; set; }
            public CategoryThing () { }
            public CategoryThing (Thing data) { Data = data; }
            public static implicit operator CategoryThing (Thing data) { return new CategoryThing (data); }
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


        public interface IMinimumPaymentDue : IWrapper { }
        public interface IMinimumPaymentDue<T> : IMinimumPaymentDue { new T Data { get; set; } }
        public class MinimumPaymentDueMonetaryAmount : IMinimumPaymentDue<MonetaryAmount>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MonetaryAmount) value; } }
            public virtual MonetaryAmount Data { get; set; }
            public MinimumPaymentDueMonetaryAmount () { }
            public MinimumPaymentDueMonetaryAmount (MonetaryAmount data) { Data = data; }
            public static implicit operator MinimumPaymentDueMonetaryAmount (MonetaryAmount data) { return new MinimumPaymentDueMonetaryAmount (data); }
        }

        public class MinimumPaymentDuePriceSpecification : IMinimumPaymentDue<PriceSpecification>
        {
            object IWrapper.Data { get { return Data; } set { Data = (PriceSpecification) value; } }
            public virtual PriceSpecification Data { get; set; }
            public MinimumPaymentDuePriceSpecification () { }
            public MinimumPaymentDuePriceSpecification (PriceSpecification data) { Data = data; }
            public static implicit operator MinimumPaymentDuePriceSpecification (PriceSpecification data) { return new MinimumPaymentDuePriceSpecification (data); }
        }


        public interface IPaymentStatus : IWrapper { }
        public interface IPaymentStatus<T> : IPaymentStatus { new T Data { get; set; } }
        public class PaymentStatusPaymentStatusType : IPaymentStatus<PaymentStatusType>
        {
            object IWrapper.Data { get { return Data; } set { Data = (PaymentStatusType) value; } }
            public virtual PaymentStatusType Data { get; set; }
            public PaymentStatusPaymentStatusType () { }
            public PaymentStatusPaymentStatusType (PaymentStatusType data) { Data = data; }
            public static implicit operator PaymentStatusPaymentStatusType (PaymentStatusType data) { return new PaymentStatusPaymentStatusType (data); }
        }

        public class PaymentStatusstring : IPaymentStatus<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public PaymentStatusstring () { }
            public PaymentStatusstring (string data) { Data = data; }
            public static implicit operator PaymentStatusstring (string data) { return new PaymentStatusstring (data); }
        }


        public interface IProvider : IWrapper { }
        public interface IProvider<T> : IProvider { new T Data { get; set; } }
        public class ProviderOrganization : IProvider<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public ProviderOrganization () { }
            public ProviderOrganization (Organization data) { Data = data; }
            public static implicit operator ProviderOrganization (Organization data) { return new ProviderOrganization (data); }
        }

        public class ProviderPerson : IProvider<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public ProviderPerson () { }
            public ProviderPerson (Person data) { Data = data; }
            public static implicit operator ProviderPerson (Person data) { return new ProviderPerson (data); }
        }


        public interface ITotalPaymentDue : IWrapper { }
        public interface ITotalPaymentDue<T> : ITotalPaymentDue { new T Data { get; set; } }
        public class TotalPaymentDueMonetaryAmount : ITotalPaymentDue<MonetaryAmount>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MonetaryAmount) value; } }
            public virtual MonetaryAmount Data { get; set; }
            public TotalPaymentDueMonetaryAmount () { }
            public TotalPaymentDueMonetaryAmount (MonetaryAmount data) { Data = data; }
            public static implicit operator TotalPaymentDueMonetaryAmount (MonetaryAmount data) { return new TotalPaymentDueMonetaryAmount (data); }
        }

        public class TotalPaymentDuePriceSpecification : ITotalPaymentDue<PriceSpecification>
        {
            object IWrapper.Data { get { return Data; } set { Data = (PriceSpecification) value; } }
            public virtual PriceSpecification Data { get; set; }
            public TotalPaymentDuePriceSpecification () { }
            public TotalPaymentDuePriceSpecification (PriceSpecification data) { Data = data; }
            public static implicit operator TotalPaymentDuePriceSpecification (PriceSpecification data) { return new TotalPaymentDuePriceSpecification (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Invoice";

        /// <summary>
        /// The identifier for the account the payment will be applied to.
        /// </summary>
        [DataMember(Name = "accountId", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AccountId { get; set; } 

        /// <summary>
        /// The time interval used to compute the invoice.
        /// </summary>
        [DataMember(Name = "billingPeriod", Order = 207)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan>? BillingPeriod { get; set; } 

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [DataMember(Name = "broker", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IBroker>? Broker { get; set; } //Organization, Person

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [DataMember(Name = "category", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ICategory>? Category { get; set; } //string, Thing

        /// <summary>
        /// A number that confirms the given order or payment has been received.
        /// </summary>
        [DataMember(Name = "confirmationNumber", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ConfirmationNumber { get; set; } 

        /// <summary>
        /// Party placing the order or paying the invoice.
        /// </summary>
        [DataMember(Name = "customer", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ICustomer>? Customer { get; set; } //Organization, Person

        /// <summary>
        /// The minimum payment required at this time.
        /// </summary>
        [DataMember(Name = "minimumPaymentDue", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IMinimumPaymentDue>? MinimumPaymentDue { get; set; } //MonetaryAmount, PriceSpecification

        /// <summary>
        /// The date that payment is due.
        /// </summary>
        [DataMember(Name = "paymentDueDate", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? PaymentDueDate { get; set; } 

        /// <summary>
        /// The name of the credit card or other method of payment for the order.
        /// </summary>
        [DataMember(Name = "paymentMethod", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PaymentMethod>? PaymentMethod { get; set; } 

        /// <summary>
        /// An identifier for the method of payment used (e.g. the last 4 digits of the credit card).
        /// </summary>
        [DataMember(Name = "paymentMethodId", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PaymentMethodId { get; set; } 

        /// <summary>
        /// The status of payment; whether the invoice has been paid or not.
        /// </summary>
        [DataMember(Name = "paymentStatus", Order = 216)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPaymentStatus>? PaymentStatus { get; set; } //PaymentStatusType?, string

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 217)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IProvider>? Provider { get; set; } //Organization, Person

        /// <summary>
        /// The Order(s) related to this Invoice. One or more Orders may be combined into a single Invoice.
        /// </summary>
        [DataMember(Name = "referencesOrder", Order = 218)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Order>? ReferencesOrder { get; set; } 

        /// <summary>
        /// The date the invoice is scheduled to be paid.
        /// </summary>
        [DataMember(Name = "scheduledPaymentDate", Order = 219)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? ScheduledPaymentDate { get; set; } 

        /// <summary>
        /// The total amount due.
        /// </summary>
        [DataMember(Name = "totalPaymentDue", Order = 220)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ITotalPaymentDue>? TotalPaymentDue { get; set; } //MonetaryAmount, PriceSpecification
    }
}
