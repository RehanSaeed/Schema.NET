namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. &lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class Reservation : Intangible
    {
        public interface IBookingTime : IValue {}
        public interface IBookingTime<T> : IBookingTime { new T Value { get; } }
        public class OneOrManyBookingTime : OneOrMany<IBookingTime>
        {
            public OneOrManyBookingTime(IBookingTime item) : base(item) { }
            public OneOrManyBookingTime(IEnumerable<IBookingTime> items) : base(items) { }
            public static implicit operator OneOrManyBookingTime (DateTimeOffset value) { return new OneOrManyBookingTime (new BookingTimeDateTimeOffset (value)); }
            public static implicit operator OneOrManyBookingTime (DateTimeOffset[] values) { return new OneOrManyBookingTime (values.Select(v => (IBookingTime) new BookingTimeDateTimeOffset (v))); }
            public static implicit operator OneOrManyBookingTime (List<DateTimeOffset> values) { return new OneOrManyBookingTime (values.Select(v => (IBookingTime) new BookingTimeDateTimeOffset (v))); }
        }
        public struct BookingTimeDateTimeOffset : IBookingTime<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public BookingTimeDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator BookingTimeDateTimeOffset (DateTimeOffset value) { return new BookingTimeDateTimeOffset (value); }
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

        public interface IModifiedTime : IValue {}
        public interface IModifiedTime<T> : IModifiedTime { new T Value { get; } }
        public class OneOrManyModifiedTime : OneOrMany<IModifiedTime>
        {
            public OneOrManyModifiedTime(IModifiedTime item) : base(item) { }
            public OneOrManyModifiedTime(IEnumerable<IModifiedTime> items) : base(items) { }
            public static implicit operator OneOrManyModifiedTime (DateTimeOffset value) { return new OneOrManyModifiedTime (new ModifiedTimeDateTimeOffset (value)); }
            public static implicit operator OneOrManyModifiedTime (DateTimeOffset[] values) { return new OneOrManyModifiedTime (values.Select(v => (IModifiedTime) new ModifiedTimeDateTimeOffset (v))); }
            public static implicit operator OneOrManyModifiedTime (List<DateTimeOffset> values) { return new OneOrManyModifiedTime (values.Select(v => (IModifiedTime) new ModifiedTimeDateTimeOffset (v))); }
        }
        public struct ModifiedTimeDateTimeOffset : IModifiedTime<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public ModifiedTimeDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator ModifiedTimeDateTimeOffset (DateTimeOffset value) { return new ModifiedTimeDateTimeOffset (value); }
        }

        public interface IPriceCurrency : IValue {}
        public interface IPriceCurrency<T> : IPriceCurrency { new T Value { get; } }
        public class OneOrManyPriceCurrency : OneOrMany<IPriceCurrency>
        {
            public OneOrManyPriceCurrency(IPriceCurrency item) : base(item) { }
            public OneOrManyPriceCurrency(IEnumerable<IPriceCurrency> items) : base(items) { }
            public static implicit operator OneOrManyPriceCurrency (string value) { return new OneOrManyPriceCurrency (new PriceCurrencystring (value)); }
            public static implicit operator OneOrManyPriceCurrency (string[] values) { return new OneOrManyPriceCurrency (values.Select(v => (IPriceCurrency) new PriceCurrencystring (v))); }
            public static implicit operator OneOrManyPriceCurrency (List<string> values) { return new OneOrManyPriceCurrency (values.Select(v => (IPriceCurrency) new PriceCurrencystring (v))); }
        }
        public struct PriceCurrencystring : IPriceCurrency<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PriceCurrencystring (string value) { Value = value; }
            public static implicit operator PriceCurrencystring (string value) { return new PriceCurrencystring (value); }
        }

        public interface IProgramMembershipUsed : IValue {}
        public interface IProgramMembershipUsed<T> : IProgramMembershipUsed { new T Value { get; } }
        public class OneOrManyProgramMembershipUsed : OneOrMany<IProgramMembershipUsed>
        {
            public OneOrManyProgramMembershipUsed(IProgramMembershipUsed item) : base(item) { }
            public OneOrManyProgramMembershipUsed(IEnumerable<IProgramMembershipUsed> items) : base(items) { }
            public static implicit operator OneOrManyProgramMembershipUsed (ProgramMembership value) { return new OneOrManyProgramMembershipUsed (new ProgramMembershipUsedProgramMembership (value)); }
            public static implicit operator OneOrManyProgramMembershipUsed (ProgramMembership[] values) { return new OneOrManyProgramMembershipUsed (values.Select(v => (IProgramMembershipUsed) new ProgramMembershipUsedProgramMembership (v))); }
            public static implicit operator OneOrManyProgramMembershipUsed (List<ProgramMembership> values) { return new OneOrManyProgramMembershipUsed (values.Select(v => (IProgramMembershipUsed) new ProgramMembershipUsedProgramMembership (v))); }
        }
        public struct ProgramMembershipUsedProgramMembership : IProgramMembershipUsed<ProgramMembership>
        {
            object IValue.Value => this.Value;
            public ProgramMembership Value { get; }
            public ProgramMembershipUsedProgramMembership (ProgramMembership value) { Value = value; }
            public static implicit operator ProgramMembershipUsedProgramMembership (ProgramMembership value) { return new ProgramMembershipUsedProgramMembership (value); }
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

        public interface IReservationFor : IValue {}
        public interface IReservationFor<T> : IReservationFor { new T Value { get; } }
        public class OneOrManyReservationFor : OneOrMany<IReservationFor>
        {
            public OneOrManyReservationFor(IReservationFor item) : base(item) { }
            public OneOrManyReservationFor(IEnumerable<IReservationFor> items) : base(items) { }
            public static implicit operator OneOrManyReservationFor (Thing value) { return new OneOrManyReservationFor (new ReservationForThing (value)); }
            public static implicit operator OneOrManyReservationFor (Thing[] values) { return new OneOrManyReservationFor (values.Select(v => (IReservationFor) new ReservationForThing (v))); }
            public static implicit operator OneOrManyReservationFor (List<Thing> values) { return new OneOrManyReservationFor (values.Select(v => (IReservationFor) new ReservationForThing (v))); }
        }
        public struct ReservationForThing : IReservationFor<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public ReservationForThing (Thing value) { Value = value; }
            public static implicit operator ReservationForThing (Thing value) { return new ReservationForThing (value); }
        }

        public interface IReservationId : IValue {}
        public interface IReservationId<T> : IReservationId { new T Value { get; } }
        public class OneOrManyReservationId : OneOrMany<IReservationId>
        {
            public OneOrManyReservationId(IReservationId item) : base(item) { }
            public OneOrManyReservationId(IEnumerable<IReservationId> items) : base(items) { }
            public static implicit operator OneOrManyReservationId (string value) { return new OneOrManyReservationId (new ReservationIdstring (value)); }
            public static implicit operator OneOrManyReservationId (string[] values) { return new OneOrManyReservationId (values.Select(v => (IReservationId) new ReservationIdstring (v))); }
            public static implicit operator OneOrManyReservationId (List<string> values) { return new OneOrManyReservationId (values.Select(v => (IReservationId) new ReservationIdstring (v))); }
        }
        public struct ReservationIdstring : IReservationId<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ReservationIdstring (string value) { Value = value; }
            public static implicit operator ReservationIdstring (string value) { return new ReservationIdstring (value); }
        }

        public interface IReservationStatus : IValue {}
        public interface IReservationStatus<T> : IReservationStatus { new T Value { get; } }
        public class OneOrManyReservationStatus : OneOrMany<IReservationStatus>
        {
            public OneOrManyReservationStatus(IReservationStatus item) : base(item) { }
            public OneOrManyReservationStatus(IEnumerable<IReservationStatus> items) : base(items) { }
            public static implicit operator OneOrManyReservationStatus (ReservationStatusType value) { return new OneOrManyReservationStatus (new ReservationStatusReservationStatusType (value)); }
            public static implicit operator OneOrManyReservationStatus (ReservationStatusType[] values) { return new OneOrManyReservationStatus (values.Select(v => (IReservationStatus) new ReservationStatusReservationStatusType (v))); }
            public static implicit operator OneOrManyReservationStatus (List<ReservationStatusType> values) { return new OneOrManyReservationStatus (values.Select(v => (IReservationStatus) new ReservationStatusReservationStatusType (v))); }
        }
        public struct ReservationStatusReservationStatusType : IReservationStatus<ReservationStatusType>
        {
            object IValue.Value => this.Value;
            public ReservationStatusType Value { get; }
            public ReservationStatusReservationStatusType (ReservationStatusType value) { Value = value; }
            public static implicit operator ReservationStatusReservationStatusType (ReservationStatusType value) { return new ReservationStatusReservationStatusType (value); }
        }

        public interface IReservedTicket : IValue {}
        public interface IReservedTicket<T> : IReservedTicket { new T Value { get; } }
        public class OneOrManyReservedTicket : OneOrMany<IReservedTicket>
        {
            public OneOrManyReservedTicket(IReservedTicket item) : base(item) { }
            public OneOrManyReservedTicket(IEnumerable<IReservedTicket> items) : base(items) { }
            public static implicit operator OneOrManyReservedTicket (Ticket value) { return new OneOrManyReservedTicket (new ReservedTicketTicket (value)); }
            public static implicit operator OneOrManyReservedTicket (Ticket[] values) { return new OneOrManyReservedTicket (values.Select(v => (IReservedTicket) new ReservedTicketTicket (v))); }
            public static implicit operator OneOrManyReservedTicket (List<Ticket> values) { return new OneOrManyReservedTicket (values.Select(v => (IReservedTicket) new ReservedTicketTicket (v))); }
        }
        public struct ReservedTicketTicket : IReservedTicket<Ticket>
        {
            object IValue.Value => this.Value;
            public Ticket Value { get; }
            public ReservedTicketTicket (Ticket value) { Value = value; }
            public static implicit operator ReservedTicketTicket (Ticket value) { return new ReservedTicketTicket (value); }
        }

        public interface ITotalPrice : IValue {}
        public interface ITotalPrice<T> : ITotalPrice { new T Value { get; } }
        public class OneOrManyTotalPrice : OneOrMany<ITotalPrice>
        {
            public OneOrManyTotalPrice(ITotalPrice item) : base(item) { }
            public OneOrManyTotalPrice(IEnumerable<ITotalPrice> items) : base(items) { }
            public static implicit operator OneOrManyTotalPrice (decimal value) { return new OneOrManyTotalPrice (new TotalPricedecimal (value)); }
            public static implicit operator OneOrManyTotalPrice (decimal[] values) { return new OneOrManyTotalPrice (values.Select(v => (ITotalPrice) new TotalPricedecimal (v))); }
            public static implicit operator OneOrManyTotalPrice (List<decimal> values) { return new OneOrManyTotalPrice (values.Select(v => (ITotalPrice) new TotalPricedecimal (v))); }
            public static implicit operator OneOrManyTotalPrice (PriceSpecification value) { return new OneOrManyTotalPrice (new TotalPricePriceSpecification (value)); }
            public static implicit operator OneOrManyTotalPrice (PriceSpecification[] values) { return new OneOrManyTotalPrice (values.Select(v => (ITotalPrice) new TotalPricePriceSpecification (v))); }
            public static implicit operator OneOrManyTotalPrice (List<PriceSpecification> values) { return new OneOrManyTotalPrice (values.Select(v => (ITotalPrice) new TotalPricePriceSpecification (v))); }
            public static implicit operator OneOrManyTotalPrice (string value) { return new OneOrManyTotalPrice (new TotalPricestring (value)); }
            public static implicit operator OneOrManyTotalPrice (string[] values) { return new OneOrManyTotalPrice (values.Select(v => (ITotalPrice) new TotalPricestring (v))); }
            public static implicit operator OneOrManyTotalPrice (List<string> values) { return new OneOrManyTotalPrice (values.Select(v => (ITotalPrice) new TotalPricestring (v))); }
        }
        public struct TotalPricedecimal : ITotalPrice<decimal>
        {
            object IValue.Value => this.Value;
            public decimal Value { get; }
            public TotalPricedecimal (decimal value) { Value = value; }
            public static implicit operator TotalPricedecimal (decimal value) { return new TotalPricedecimal (value); }
        }
        public struct TotalPricePriceSpecification : ITotalPrice<PriceSpecification>
        {
            object IValue.Value => this.Value;
            public PriceSpecification Value { get; }
            public TotalPricePriceSpecification (PriceSpecification value) { Value = value; }
            public static implicit operator TotalPricePriceSpecification (PriceSpecification value) { return new TotalPricePriceSpecification (value); }
        }
        public struct TotalPricestring : ITotalPrice<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public TotalPricestring (string value) { Value = value; }
            public static implicit operator TotalPricestring (string value) { return new TotalPricestring (value); }
        }

        public interface IUnderName : IValue {}
        public interface IUnderName<T> : IUnderName { new T Value { get; } }
        public class OneOrManyUnderName : OneOrMany<IUnderName>
        {
            public OneOrManyUnderName(IUnderName item) : base(item) { }
            public OneOrManyUnderName(IEnumerable<IUnderName> items) : base(items) { }
            public static implicit operator OneOrManyUnderName (Organization value) { return new OneOrManyUnderName (new UnderNameOrganization (value)); }
            public static implicit operator OneOrManyUnderName (Organization[] values) { return new OneOrManyUnderName (values.Select(v => (IUnderName) new UnderNameOrganization (v))); }
            public static implicit operator OneOrManyUnderName (List<Organization> values) { return new OneOrManyUnderName (values.Select(v => (IUnderName) new UnderNameOrganization (v))); }
            public static implicit operator OneOrManyUnderName (Person value) { return new OneOrManyUnderName (new UnderNamePerson (value)); }
            public static implicit operator OneOrManyUnderName (Person[] values) { return new OneOrManyUnderName (values.Select(v => (IUnderName) new UnderNamePerson (v))); }
            public static implicit operator OneOrManyUnderName (List<Person> values) { return new OneOrManyUnderName (values.Select(v => (IUnderName) new UnderNamePerson (v))); }
        }
        public struct UnderNameOrganization : IUnderName<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public UnderNameOrganization (Organization value) { Value = value; }
            public static implicit operator UnderNameOrganization (Organization value) { return new UnderNameOrganization (value); }
        }
        public struct UnderNamePerson : IUnderName<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public UnderNamePerson (Person value) { Value = value; }
            public static implicit operator UnderNamePerson (Person value) { return new UnderNamePerson (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Reservation";

        /// <summary>
        /// The date and time the reservation was booked.
        /// </summary>
        [DataMember(Name = "bookingTime", Order = 206)]
        public OneOrManyBookingTime BookingTime { get; set; }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [DataMember(Name = "broker", Order = 207)]
        public OneOrManyBroker Broker { get; set; }

        /// <summary>
        /// The date and time the reservation was modified.
        /// </summary>
        [DataMember(Name = "modifiedTime", Order = 208)]
        public OneOrManyModifiedTime ModifiedTime { get; set; }

        /// <summary>
        /// The currency of the price, or a price component when attached to &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        [DataMember(Name = "priceCurrency", Order = 209)]
        public OneOrManyPriceCurrency PriceCurrency { get; set; }

        /// <summary>
        /// Any membership in a frequent flyer, hotel loyalty program, etc. being applied to the reservation.
        /// </summary>
        [DataMember(Name = "programMembershipUsed", Order = 210)]
        public OneOrManyProgramMembershipUsed ProgramMembershipUsed { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 211)]
        public OneOrManyProvider Provider { get; set; }

        /// <summary>
        /// The thing -- flight, event, restaurant,etc. being reserved.
        /// </summary>
        [DataMember(Name = "reservationFor", Order = 212)]
        public OneOrManyReservationFor ReservationFor { get; set; }

        /// <summary>
        /// A unique identifier for the reservation.
        /// </summary>
        [DataMember(Name = "reservationId", Order = 213)]
        public OneOrManyReservationId ReservationId { get; set; }

        /// <summary>
        /// The current status of the reservation.
        /// </summary>
        [DataMember(Name = "reservationStatus", Order = 214)]
        public OneOrManyReservationStatus ReservationStatus { get; set; }

        /// <summary>
        /// A ticket associated with the reservation.
        /// </summary>
        [DataMember(Name = "reservedTicket", Order = 215)]
        public OneOrManyReservedTicket ReservedTicket { get; set; }

        /// <summary>
        /// The total price for the reservation or ticket, including applicable taxes, shipping, etc.
        /// </summary>
        [DataMember(Name = "totalPrice", Order = 216)]
        public OneOrManyTotalPrice TotalPrice { get; set; }

        /// <summary>
        /// The person or organization the reservation or ticket is for.
        /// </summary>
        [DataMember(Name = "underName", Order = 217)]
        public OneOrManyUnderName UnderName { get; set; }
    }
}
