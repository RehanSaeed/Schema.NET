namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
    [DataContract]
    public partial class Invoice : Intangible
    {
        public interface IAccountId : IValue {}
        public interface IAccountId<T> : IAccountId { new T Value { get; } }
        public class OneOrManyAccountId : OneOrMany<IAccountId>
        {
            public OneOrManyAccountId(IAccountId item) : base(item) { }
            public OneOrManyAccountId(IEnumerable<IAccountId> items) : base(items) { }
            public static implicit operator OneOrManyAccountId (string value) { return new OneOrManyAccountId (new AccountIdstring (value)); }
            public static implicit operator OneOrManyAccountId (string[] values) { return new OneOrManyAccountId (values.Select(v => (IAccountId) new AccountIdstring (v))); }
            public static implicit operator OneOrManyAccountId (List<string> values) { return new OneOrManyAccountId (values.Select(v => (IAccountId) new AccountIdstring (v))); }
        }
        public struct AccountIdstring : IAccountId<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AccountIdstring (string value) { Value = value; }
            public static implicit operator AccountIdstring (string value) { return new AccountIdstring (value); }
        }

        public interface IBillingPeriod : IValue {}
        public interface IBillingPeriod<T> : IBillingPeriod { new T Value { get; } }
        public class OneOrManyBillingPeriod : OneOrMany<IBillingPeriod>
        {
            public OneOrManyBillingPeriod(IBillingPeriod item) : base(item) { }
            public OneOrManyBillingPeriod(IEnumerable<IBillingPeriod> items) : base(items) { }
            public static implicit operator OneOrManyBillingPeriod (TimeSpan value) { return new OneOrManyBillingPeriod (new BillingPeriodTimeSpan (value)); }
            public static implicit operator OneOrManyBillingPeriod (TimeSpan[] values) { return new OneOrManyBillingPeriod (values.Select(v => (IBillingPeriod) new BillingPeriodTimeSpan (v))); }
            public static implicit operator OneOrManyBillingPeriod (List<TimeSpan> values) { return new OneOrManyBillingPeriod (values.Select(v => (IBillingPeriod) new BillingPeriodTimeSpan (v))); }
        }
        public struct BillingPeriodTimeSpan : IBillingPeriod<TimeSpan>
        {
            object IValue.Value => this.Value;
            public TimeSpan Value { get; }
            public BillingPeriodTimeSpan (TimeSpan value) { Value = value; }
            public static implicit operator BillingPeriodTimeSpan (TimeSpan value) { return new BillingPeriodTimeSpan (value); }
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

        public interface ICategory : IValue {}
        public interface ICategory<T> : ICategory { new T Value { get; } }
        public class OneOrManyCategory : OneOrMany<ICategory>
        {
            public OneOrManyCategory(ICategory item) : base(item) { }
            public OneOrManyCategory(IEnumerable<ICategory> items) : base(items) { }
            public static implicit operator OneOrManyCategory (string value) { return new OneOrManyCategory (new Categorystring (value)); }
            public static implicit operator OneOrManyCategory (string[] values) { return new OneOrManyCategory (values.Select(v => (ICategory) new Categorystring (v))); }
            public static implicit operator OneOrManyCategory (List<string> values) { return new OneOrManyCategory (values.Select(v => (ICategory) new Categorystring (v))); }
            public static implicit operator OneOrManyCategory (Thing value) { return new OneOrManyCategory (new CategoryThing (value)); }
            public static implicit operator OneOrManyCategory (Thing[] values) { return new OneOrManyCategory (values.Select(v => (ICategory) new CategoryThing (v))); }
            public static implicit operator OneOrManyCategory (List<Thing> values) { return new OneOrManyCategory (values.Select(v => (ICategory) new CategoryThing (v))); }
        }
        public struct Categorystring : ICategory<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Categorystring (string value) { Value = value; }
            public static implicit operator Categorystring (string value) { return new Categorystring (value); }
        }
        public struct CategoryThing : ICategory<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public CategoryThing (Thing value) { Value = value; }
            public static implicit operator CategoryThing (Thing value) { return new CategoryThing (value); }
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

        public interface IMinimumPaymentDue : IValue {}
        public interface IMinimumPaymentDue<T> : IMinimumPaymentDue { new T Value { get; } }
        public class OneOrManyMinimumPaymentDue : OneOrMany<IMinimumPaymentDue>
        {
            public OneOrManyMinimumPaymentDue(IMinimumPaymentDue item) : base(item) { }
            public OneOrManyMinimumPaymentDue(IEnumerable<IMinimumPaymentDue> items) : base(items) { }
            public static implicit operator OneOrManyMinimumPaymentDue (MonetaryAmount value) { return new OneOrManyMinimumPaymentDue (new MinimumPaymentDueMonetaryAmount (value)); }
            public static implicit operator OneOrManyMinimumPaymentDue (MonetaryAmount[] values) { return new OneOrManyMinimumPaymentDue (values.Select(v => (IMinimumPaymentDue) new MinimumPaymentDueMonetaryAmount (v))); }
            public static implicit operator OneOrManyMinimumPaymentDue (List<MonetaryAmount> values) { return new OneOrManyMinimumPaymentDue (values.Select(v => (IMinimumPaymentDue) new MinimumPaymentDueMonetaryAmount (v))); }
            public static implicit operator OneOrManyMinimumPaymentDue (PriceSpecification value) { return new OneOrManyMinimumPaymentDue (new MinimumPaymentDuePriceSpecification (value)); }
            public static implicit operator OneOrManyMinimumPaymentDue (PriceSpecification[] values) { return new OneOrManyMinimumPaymentDue (values.Select(v => (IMinimumPaymentDue) new MinimumPaymentDuePriceSpecification (v))); }
            public static implicit operator OneOrManyMinimumPaymentDue (List<PriceSpecification> values) { return new OneOrManyMinimumPaymentDue (values.Select(v => (IMinimumPaymentDue) new MinimumPaymentDuePriceSpecification (v))); }
        }
        public struct MinimumPaymentDueMonetaryAmount : IMinimumPaymentDue<MonetaryAmount>
        {
            object IValue.Value => this.Value;
            public MonetaryAmount Value { get; }
            public MinimumPaymentDueMonetaryAmount (MonetaryAmount value) { Value = value; }
            public static implicit operator MinimumPaymentDueMonetaryAmount (MonetaryAmount value) { return new MinimumPaymentDueMonetaryAmount (value); }
        }
        public struct MinimumPaymentDuePriceSpecification : IMinimumPaymentDue<PriceSpecification>
        {
            object IValue.Value => this.Value;
            public PriceSpecification Value { get; }
            public MinimumPaymentDuePriceSpecification (PriceSpecification value) { Value = value; }
            public static implicit operator MinimumPaymentDuePriceSpecification (PriceSpecification value) { return new MinimumPaymentDuePriceSpecification (value); }
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

        public interface IPaymentStatus : IValue {}
        public interface IPaymentStatus<T> : IPaymentStatus { new T Value { get; } }
        public class OneOrManyPaymentStatus : OneOrMany<IPaymentStatus>
        {
            public OneOrManyPaymentStatus(IPaymentStatus item) : base(item) { }
            public OneOrManyPaymentStatus(IEnumerable<IPaymentStatus> items) : base(items) { }
            public static implicit operator OneOrManyPaymentStatus (PaymentStatusType value) { return new OneOrManyPaymentStatus (new PaymentStatusPaymentStatusType (value)); }
            public static implicit operator OneOrManyPaymentStatus (PaymentStatusType[] values) { return new OneOrManyPaymentStatus (values.Select(v => (IPaymentStatus) new PaymentStatusPaymentStatusType (v))); }
            public static implicit operator OneOrManyPaymentStatus (List<PaymentStatusType> values) { return new OneOrManyPaymentStatus (values.Select(v => (IPaymentStatus) new PaymentStatusPaymentStatusType (v))); }
            public static implicit operator OneOrManyPaymentStatus (string value) { return new OneOrManyPaymentStatus (new PaymentStatusstring (value)); }
            public static implicit operator OneOrManyPaymentStatus (string[] values) { return new OneOrManyPaymentStatus (values.Select(v => (IPaymentStatus) new PaymentStatusstring (v))); }
            public static implicit operator OneOrManyPaymentStatus (List<string> values) { return new OneOrManyPaymentStatus (values.Select(v => (IPaymentStatus) new PaymentStatusstring (v))); }
        }
        public struct PaymentStatusPaymentStatusType : IPaymentStatus<PaymentStatusType>
        {
            object IValue.Value => this.Value;
            public PaymentStatusType Value { get; }
            public PaymentStatusPaymentStatusType (PaymentStatusType value) { Value = value; }
            public static implicit operator PaymentStatusPaymentStatusType (PaymentStatusType value) { return new PaymentStatusPaymentStatusType (value); }
        }
        public struct PaymentStatusstring : IPaymentStatus<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PaymentStatusstring (string value) { Value = value; }
            public static implicit operator PaymentStatusstring (string value) { return new PaymentStatusstring (value); }
        }

        public interface IProvider : IValue {}
        public interface IProvider<T> : IProvider { new T Value { get; } }
        public class OneOrManyProvider : OneOrMany<IProvider>
        {
            public OneOrManyProvider(IProvider item) : base(item) { }
            public OneOrManyProvider(IEnumerable<IProvider> items) : base(items) { }
            public static implicit operator OneOrManyProvider (Organization value) { return new OneOrManyProvider (new ProviderOrganization (value)); }
            public static implicit operator OneOrManyProvider (Organization[] values) { return new OneOrManyProvider (values.Select(v => (IProvider) new ProviderOrganization (v))); }
            public static implicit operator OneOrManyProvider (List<Organization> values) { return new OneOrManyProvider (values.Select(v => (IProvider) new ProviderOrganization (v))); }
            public static implicit operator OneOrManyProvider (Person value) { return new OneOrManyProvider (new ProviderPerson (value)); }
            public static implicit operator OneOrManyProvider (Person[] values) { return new OneOrManyProvider (values.Select(v => (IProvider) new ProviderPerson (v))); }
            public static implicit operator OneOrManyProvider (List<Person> values) { return new OneOrManyProvider (values.Select(v => (IProvider) new ProviderPerson (v))); }
        }
        public struct ProviderOrganization : IProvider<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public ProviderOrganization (Organization value) { Value = value; }
            public static implicit operator ProviderOrganization (Organization value) { return new ProviderOrganization (value); }
        }
        public struct ProviderPerson : IProvider<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ProviderPerson (Person value) { Value = value; }
            public static implicit operator ProviderPerson (Person value) { return new ProviderPerson (value); }
        }

        public interface IReferencesOrder : IValue {}
        public interface IReferencesOrder<T> : IReferencesOrder { new T Value { get; } }
        public class OneOrManyReferencesOrder : OneOrMany<IReferencesOrder>
        {
            public OneOrManyReferencesOrder(IReferencesOrder item) : base(item) { }
            public OneOrManyReferencesOrder(IEnumerable<IReferencesOrder> items) : base(items) { }
            public static implicit operator OneOrManyReferencesOrder (Order value) { return new OneOrManyReferencesOrder (new ReferencesOrderOrder (value)); }
            public static implicit operator OneOrManyReferencesOrder (Order[] values) { return new OneOrManyReferencesOrder (values.Select(v => (IReferencesOrder) new ReferencesOrderOrder (v))); }
            public static implicit operator OneOrManyReferencesOrder (List<Order> values) { return new OneOrManyReferencesOrder (values.Select(v => (IReferencesOrder) new ReferencesOrderOrder (v))); }
        }
        public struct ReferencesOrderOrder : IReferencesOrder<Order>
        {
            object IValue.Value => this.Value;
            public Order Value { get; }
            public ReferencesOrderOrder (Order value) { Value = value; }
            public static implicit operator ReferencesOrderOrder (Order value) { return new ReferencesOrderOrder (value); }
        }

        public interface IScheduledPaymentDate : IValue {}
        public interface IScheduledPaymentDate<T> : IScheduledPaymentDate { new T Value { get; } }
        public class OneOrManyScheduledPaymentDate : OneOrMany<IScheduledPaymentDate>
        {
            public OneOrManyScheduledPaymentDate(IScheduledPaymentDate item) : base(item) { }
            public OneOrManyScheduledPaymentDate(IEnumerable<IScheduledPaymentDate> items) : base(items) { }
            public static implicit operator OneOrManyScheduledPaymentDate (DateTimeOffset value) { return new OneOrManyScheduledPaymentDate (new ScheduledPaymentDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyScheduledPaymentDate (DateTimeOffset[] values) { return new OneOrManyScheduledPaymentDate (values.Select(v => (IScheduledPaymentDate) new ScheduledPaymentDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyScheduledPaymentDate (List<DateTimeOffset> values) { return new OneOrManyScheduledPaymentDate (values.Select(v => (IScheduledPaymentDate) new ScheduledPaymentDateDateTimeOffset (v))); }
        }
        public struct ScheduledPaymentDateDateTimeOffset : IScheduledPaymentDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public ScheduledPaymentDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator ScheduledPaymentDateDateTimeOffset (DateTimeOffset value) { return new ScheduledPaymentDateDateTimeOffset (value); }
        }

        public interface ITotalPaymentDue : IValue {}
        public interface ITotalPaymentDue<T> : ITotalPaymentDue { new T Value { get; } }
        public class OneOrManyTotalPaymentDue : OneOrMany<ITotalPaymentDue>
        {
            public OneOrManyTotalPaymentDue(ITotalPaymentDue item) : base(item) { }
            public OneOrManyTotalPaymentDue(IEnumerable<ITotalPaymentDue> items) : base(items) { }
            public static implicit operator OneOrManyTotalPaymentDue (MonetaryAmount value) { return new OneOrManyTotalPaymentDue (new TotalPaymentDueMonetaryAmount (value)); }
            public static implicit operator OneOrManyTotalPaymentDue (MonetaryAmount[] values) { return new OneOrManyTotalPaymentDue (values.Select(v => (ITotalPaymentDue) new TotalPaymentDueMonetaryAmount (v))); }
            public static implicit operator OneOrManyTotalPaymentDue (List<MonetaryAmount> values) { return new OneOrManyTotalPaymentDue (values.Select(v => (ITotalPaymentDue) new TotalPaymentDueMonetaryAmount (v))); }
            public static implicit operator OneOrManyTotalPaymentDue (PriceSpecification value) { return new OneOrManyTotalPaymentDue (new TotalPaymentDuePriceSpecification (value)); }
            public static implicit operator OneOrManyTotalPaymentDue (PriceSpecification[] values) { return new OneOrManyTotalPaymentDue (values.Select(v => (ITotalPaymentDue) new TotalPaymentDuePriceSpecification (v))); }
            public static implicit operator OneOrManyTotalPaymentDue (List<PriceSpecification> values) { return new OneOrManyTotalPaymentDue (values.Select(v => (ITotalPaymentDue) new TotalPaymentDuePriceSpecification (v))); }
        }
        public struct TotalPaymentDueMonetaryAmount : ITotalPaymentDue<MonetaryAmount>
        {
            object IValue.Value => this.Value;
            public MonetaryAmount Value { get; }
            public TotalPaymentDueMonetaryAmount (MonetaryAmount value) { Value = value; }
            public static implicit operator TotalPaymentDueMonetaryAmount (MonetaryAmount value) { return new TotalPaymentDueMonetaryAmount (value); }
        }
        public struct TotalPaymentDuePriceSpecification : ITotalPaymentDue<PriceSpecification>
        {
            object IValue.Value => this.Value;
            public PriceSpecification Value { get; }
            public TotalPaymentDuePriceSpecification (PriceSpecification value) { Value = value; }
            public static implicit operator TotalPaymentDuePriceSpecification (PriceSpecification value) { return new TotalPaymentDuePriceSpecification (value); }
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
        public OneOrManyAccountId AccountId { get; set; }

        /// <summary>
        /// The time interval used to compute the invoice.
        /// </summary>
        [DataMember(Name = "billingPeriod", Order = 207)]
        public OneOrManyBillingPeriod BillingPeriod { get; set; }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [DataMember(Name = "broker", Order = 208)]
        public OneOrManyBroker Broker { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [DataMember(Name = "category", Order = 209)]
        public OneOrManyCategory Category { get; set; }

        /// <summary>
        /// A number that confirms the given order or payment has been received.
        /// </summary>
        [DataMember(Name = "confirmationNumber", Order = 210)]
        public OneOrManyConfirmationNumber ConfirmationNumber { get; set; }

        /// <summary>
        /// Party placing the order or paying the invoice.
        /// </summary>
        [DataMember(Name = "customer", Order = 211)]
        public OneOrManyCustomer Customer { get; set; }

        /// <summary>
        /// The minimum payment required at this time.
        /// </summary>
        [DataMember(Name = "minimumPaymentDue", Order = 212)]
        public OneOrManyMinimumPaymentDue MinimumPaymentDue { get; set; }

        /// <summary>
        /// The date that payment is due.
        /// </summary>
        [DataMember(Name = "paymentDueDate", Order = 213)]
        public OneOrManyPaymentDueDate PaymentDueDate { get; set; }

        /// <summary>
        /// The name of the credit card or other method of payment for the order.
        /// </summary>
        [DataMember(Name = "paymentMethod", Order = 214)]
        public OneOrManyPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// An identifier for the method of payment used (e.g. the last 4 digits of the credit card).
        /// </summary>
        [DataMember(Name = "paymentMethodId", Order = 215)]
        public OneOrManyPaymentMethodId PaymentMethodId { get; set; }

        /// <summary>
        /// The status of payment; whether the invoice has been paid or not.
        /// </summary>
        [DataMember(Name = "paymentStatus", Order = 216)]
        public OneOrManyPaymentStatus PaymentStatus { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 217)]
        public OneOrManyProvider Provider { get; set; }

        /// <summary>
        /// The Order(s) related to this Invoice. One or more Orders may be combined into a single Invoice.
        /// </summary>
        [DataMember(Name = "referencesOrder", Order = 218)]
        public OneOrManyReferencesOrder ReferencesOrder { get; set; }

        /// <summary>
        /// The date the invoice is scheduled to be paid.
        /// </summary>
        [DataMember(Name = "scheduledPaymentDate", Order = 219)]
        public OneOrManyScheduledPaymentDate ScheduledPaymentDate { get; set; }

        /// <summary>
        /// The total amount due.
        /// </summary>
        [DataMember(Name = "totalPaymentDue", Order = 220)]
        public OneOrManyTotalPaymentDue TotalPaymentDue { get; set; }
    }
}
