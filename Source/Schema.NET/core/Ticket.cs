using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// Used to describe a ticket to an event, a flight, a bus ride, etc.
    /// </summary>
    [DataContract]
    public partial class Ticket : Intangible
    {
        public interface ITicketToken : IWrapper { }
        public interface ITicketToken<T> : ITicketToken { new T Data { get; set; } }
        public class TicketTokenstring : ITicketToken<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public TicketTokenstring () { }
            public TicketTokenstring (string data) { Data = data; }
            public static implicit operator TicketTokenstring (string data) { return new TicketTokenstring (data); }
        }

        public class TicketTokenUri : ITicketToken<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public TicketTokenUri () { }
            public TicketTokenUri (Uri data) { Data = data; }
            public static implicit operator TicketTokenUri (Uri data) { return new TicketTokenUri (data); }
        }


        public interface ITotalPrice : IWrapper { }
        public interface ITotalPrice<T> : ITotalPrice { new T Data { get; set; } }
        public class TotalPricedecimal : ITotalPrice<decimal>
        {
            object IWrapper.Data { get { return Data; } set { Data = (decimal) value; } }
            public virtual decimal Data { get; set; }
            public TotalPricedecimal () { }
            public TotalPricedecimal (decimal data) { Data = data; }
            public static implicit operator TotalPricedecimal (decimal data) { return new TotalPricedecimal (data); }
        }

        public class TotalPricePriceSpecification : ITotalPrice<PriceSpecification>
        {
            object IWrapper.Data { get { return Data; } set { Data = (PriceSpecification) value; } }
            public virtual PriceSpecification Data { get; set; }
            public TotalPricePriceSpecification () { }
            public TotalPricePriceSpecification (PriceSpecification data) { Data = data; }
            public static implicit operator TotalPricePriceSpecification (PriceSpecification data) { return new TotalPricePriceSpecification (data); }
        }

        public class TotalPricestring : ITotalPrice<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public TotalPricestring () { }
            public TotalPricestring (string data) { Data = data; }
            public static implicit operator TotalPricestring (string data) { return new TotalPricestring (data); }
        }


        public interface IUnderName : IWrapper { }
        public interface IUnderName<T> : IUnderName { new T Data { get; set; } }
        public class UnderNameOrganization : IUnderName<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public UnderNameOrganization () { }
            public UnderNameOrganization (Organization data) { Data = data; }
            public static implicit operator UnderNameOrganization (Organization data) { return new UnderNameOrganization (data); }
        }

        public class UnderNamePerson : IUnderName<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public UnderNamePerson () { }
            public UnderNamePerson (Person data) { Data = data; }
            public static implicit operator UnderNamePerson (Person data) { return new UnderNamePerson (data); }
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? DateIssued { get; set; } 

        /// <summary>
        /// The organization issuing the ticket or permit.
        /// </summary>
        [DataMember(Name = "issuedBy", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? IssuedBy { get; set; } 

        /// <summary>
        /// The currency (in 3-letter ISO 4217 format) of the price or a price component, when attached to &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.
        /// </summary>
        [DataMember(Name = "priceCurrency", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PriceCurrency { get; set; } 

        /// <summary>
        /// The seat associated with the ticket.
        /// </summary>
        [DataMember(Name = "ticketedSeat", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Seat>? TicketedSeat { get; set; } 

        /// <summary>
        /// The unique identifier for the ticket.
        /// </summary>
        [DataMember(Name = "ticketNumber", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? TicketNumber { get; set; } 

        /// <summary>
        /// Reference to an asset (e.g., Barcode, QR code image or PDF) usable for entrance.
        /// </summary>
        [DataMember(Name = "ticketToken", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ITicketToken>? TicketToken { get; set; } //string, Uri

        /// <summary>
        /// The total price for the reservation or ticket, including applicable taxes, shipping, etc.
        /// </summary>
        [DataMember(Name = "totalPrice", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ITotalPrice>? TotalPrice { get; set; } //decimal?, PriceSpecification, string

        /// <summary>
        /// The person or organization the reservation or ticket is for.
        /// </summary>
        [DataMember(Name = "underName", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IUnderName>? UnderName { get; set; } //Organization, Person
    }
}
