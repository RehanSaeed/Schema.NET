namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Used to describe a ticket to an event, a flight, a bus ride, etc.
    /// </summary>
    [DataContract]
    public partial class Ticket : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Ticket";

        /// <summary>
        /// The date the ticket was issued.
        /// </summary>
        [DataMember(Name = "dateIssued", Order = 205)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? DateIssued { get; set; }

        /// <summary>
        /// The organization issuing the ticket or permit.
        /// </summary>
        [DataMember(Name = "issuedBy", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? IssuedBy { get; set; }

        /// <summary>
        /// The currency (in 3-letter ISO 4217 format) of the price or a price component, when attached to &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.
        /// </summary>
        [DataMember(Name = "priceCurrency", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PriceCurrency { get; set; }

        /// <summary>
        /// The seat associated with the ticket.
        /// </summary>
        [DataMember(Name = "ticketedSeat", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Seat>? TicketedSeat { get; set; }

        /// <summary>
        /// The unique identifier for the ticket.
        /// </summary>
        [DataMember(Name = "ticketNumber", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? TicketNumber { get; set; }

        /// <summary>
        /// Reference to an asset (e.g., Barcode, QR code image or PDF) usable for entrance.
        /// </summary>
        [DataMember(Name = "ticketToken", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? TicketToken { get; set; }

        /// <summary>
        /// The total price for the reservation or ticket, including applicable taxes, shipping, etc.
        /// </summary>
        [DataMember(Name = "totalPrice", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<decimal?, PriceSpecification, string>? TotalPrice { get; set; }

        /// <summary>
        /// The person or organization the reservation or ticket is for.
        /// </summary>
        [DataMember(Name = "underName", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person, Organization>? UnderName { get; set; }
    }
}
