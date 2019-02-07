namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Used to describe a ticket to an event, a flight, a bus ride, etc.
    /// </summary>
    [DataContract]
    public partial class Ticket : Intangible
    {
        public interface IDateIssued : IValue {}
        public interface IDateIssued<T> : IDateIssued { new T Value { get; } }
        public class OneOrManyDateIssued : OneOrMany<IDateIssued>
        {
            public OneOrManyDateIssued(IDateIssued item) : base(item) { }
            public OneOrManyDateIssued(IEnumerable<IDateIssued> items) : base(items) { }
            public static implicit operator OneOrManyDateIssued (DateTimeOffset value) { return new OneOrManyDateIssued (new DateIssuedDateTimeOffset (value)); }
            public static implicit operator OneOrManyDateIssued (DateTimeOffset[] values) { return new OneOrManyDateIssued (values.Select(v => (IDateIssued) new DateIssuedDateTimeOffset (v))); }
            public static implicit operator OneOrManyDateIssued (List<DateTimeOffset> values) { return new OneOrManyDateIssued (values.Select(v => (IDateIssued) new DateIssuedDateTimeOffset (v))); }
        }
        public struct DateIssuedDateTimeOffset : IDateIssued<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public DateIssuedDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator DateIssuedDateTimeOffset (DateTimeOffset value) { return new DateIssuedDateTimeOffset (value); }
        }

        public interface IIssuedBy : IValue {}
        public interface IIssuedBy<T> : IIssuedBy { new T Value { get; } }
        public class OneOrManyIssuedBy : OneOrMany<IIssuedBy>
        {
            public OneOrManyIssuedBy(IIssuedBy item) : base(item) { }
            public OneOrManyIssuedBy(IEnumerable<IIssuedBy> items) : base(items) { }
            public static implicit operator OneOrManyIssuedBy (Organization value) { return new OneOrManyIssuedBy (new IssuedByOrganization (value)); }
            public static implicit operator OneOrManyIssuedBy (Organization[] values) { return new OneOrManyIssuedBy (values.Select(v => (IIssuedBy) new IssuedByOrganization (v))); }
            public static implicit operator OneOrManyIssuedBy (List<Organization> values) { return new OneOrManyIssuedBy (values.Select(v => (IIssuedBy) new IssuedByOrganization (v))); }
        }
        public struct IssuedByOrganization : IIssuedBy<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public IssuedByOrganization (Organization value) { Value = value; }
            public static implicit operator IssuedByOrganization (Organization value) { return new IssuedByOrganization (value); }
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

        public interface ITicketedSeat : IValue {}
        public interface ITicketedSeat<T> : ITicketedSeat { new T Value { get; } }
        public class OneOrManyTicketedSeat : OneOrMany<ITicketedSeat>
        {
            public OneOrManyTicketedSeat(ITicketedSeat item) : base(item) { }
            public OneOrManyTicketedSeat(IEnumerable<ITicketedSeat> items) : base(items) { }
            public static implicit operator OneOrManyTicketedSeat (Seat value) { return new OneOrManyTicketedSeat (new TicketedSeatSeat (value)); }
            public static implicit operator OneOrManyTicketedSeat (Seat[] values) { return new OneOrManyTicketedSeat (values.Select(v => (ITicketedSeat) new TicketedSeatSeat (v))); }
            public static implicit operator OneOrManyTicketedSeat (List<Seat> values) { return new OneOrManyTicketedSeat (values.Select(v => (ITicketedSeat) new TicketedSeatSeat (v))); }
        }
        public struct TicketedSeatSeat : ITicketedSeat<Seat>
        {
            object IValue.Value => this.Value;
            public Seat Value { get; }
            public TicketedSeatSeat (Seat value) { Value = value; }
            public static implicit operator TicketedSeatSeat (Seat value) { return new TicketedSeatSeat (value); }
        }

        public interface ITicketNumber : IValue {}
        public interface ITicketNumber<T> : ITicketNumber { new T Value { get; } }
        public class OneOrManyTicketNumber : OneOrMany<ITicketNumber>
        {
            public OneOrManyTicketNumber(ITicketNumber item) : base(item) { }
            public OneOrManyTicketNumber(IEnumerable<ITicketNumber> items) : base(items) { }
            public static implicit operator OneOrManyTicketNumber (string value) { return new OneOrManyTicketNumber (new TicketNumberstring (value)); }
            public static implicit operator OneOrManyTicketNumber (string[] values) { return new OneOrManyTicketNumber (values.Select(v => (ITicketNumber) new TicketNumberstring (v))); }
            public static implicit operator OneOrManyTicketNumber (List<string> values) { return new OneOrManyTicketNumber (values.Select(v => (ITicketNumber) new TicketNumberstring (v))); }
        }
        public struct TicketNumberstring : ITicketNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public TicketNumberstring (string value) { Value = value; }
            public static implicit operator TicketNumberstring (string value) { return new TicketNumberstring (value); }
        }

        public interface ITicketToken : IValue {}
        public interface ITicketToken<T> : ITicketToken { new T Value { get; } }
        public class OneOrManyTicketToken : OneOrMany<ITicketToken>
        {
            public OneOrManyTicketToken(ITicketToken item) : base(item) { }
            public OneOrManyTicketToken(IEnumerable<ITicketToken> items) : base(items) { }
            public static implicit operator OneOrManyTicketToken (string value) { return new OneOrManyTicketToken (new TicketTokenstring (value)); }
            public static implicit operator OneOrManyTicketToken (string[] values) { return new OneOrManyTicketToken (values.Select(v => (ITicketToken) new TicketTokenstring (v))); }
            public static implicit operator OneOrManyTicketToken (List<string> values) { return new OneOrManyTicketToken (values.Select(v => (ITicketToken) new TicketTokenstring (v))); }
            public static implicit operator OneOrManyTicketToken (Uri value) { return new OneOrManyTicketToken (new TicketTokenUri (value)); }
            public static implicit operator OneOrManyTicketToken (Uri[] values) { return new OneOrManyTicketToken (values.Select(v => (ITicketToken) new TicketTokenUri (v))); }
            public static implicit operator OneOrManyTicketToken (List<Uri> values) { return new OneOrManyTicketToken (values.Select(v => (ITicketToken) new TicketTokenUri (v))); }
        }
        public struct TicketTokenstring : ITicketToken<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public TicketTokenstring (string value) { Value = value; }
            public static implicit operator TicketTokenstring (string value) { return new TicketTokenstring (value); }
        }
        public struct TicketTokenUri : ITicketToken<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public TicketTokenUri (Uri value) { Value = value; }
            public static implicit operator TicketTokenUri (Uri value) { return new TicketTokenUri (value); }
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
        public override string Type => "Ticket";

        /// <summary>
        /// The date the ticket was issued.
        /// </summary>
        [DataMember(Name = "dateIssued", Order = 206)]
        public OneOrManyDateIssued DateIssued { get; set; }

        /// <summary>
        /// The organization issuing the ticket or permit.
        /// </summary>
        [DataMember(Name = "issuedBy", Order = 207)]
        public OneOrManyIssuedBy IssuedBy { get; set; }

        /// <summary>
        /// The currency of the price, or a price component when attached to &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        [DataMember(Name = "priceCurrency", Order = 208)]
        public OneOrManyPriceCurrency PriceCurrency { get; set; }

        /// <summary>
        /// The seat associated with the ticket.
        /// </summary>
        [DataMember(Name = "ticketedSeat", Order = 209)]
        public OneOrManyTicketedSeat TicketedSeat { get; set; }

        /// <summary>
        /// The unique identifier for the ticket.
        /// </summary>
        [DataMember(Name = "ticketNumber", Order = 210)]
        public OneOrManyTicketNumber TicketNumber { get; set; }

        /// <summary>
        /// Reference to an asset (e.g., Barcode, QR code image or PDF) usable for entrance.
        /// </summary>
        [DataMember(Name = "ticketToken", Order = 211)]
        public OneOrManyTicketToken TicketToken { get; set; }

        /// <summary>
        /// The total price for the reservation or ticket, including applicable taxes, shipping, etc.
        /// </summary>
        [DataMember(Name = "totalPrice", Order = 212)]
        public OneOrManyTotalPrice TotalPrice { get; set; }

        /// <summary>
        /// The person or organization the reservation or ticket is for.
        /// </summary>
        [DataMember(Name = "underName", Order = 213)]
        public OneOrManyUnderName UnderName { get; set; }
    }
}
