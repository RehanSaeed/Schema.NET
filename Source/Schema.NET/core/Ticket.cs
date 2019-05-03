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
        [DataMember(Name = "dateIssued", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? DateIssued { get; set; }

        /// <summary>
        /// The organization issuing the ticket or permit.
        /// </summary>
        [DataMember(Name = "issuedBy", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Organization>? IssuedBy { get; set; }

        /// <summary>
        /// The currency of the price, or a price component when attached to &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        [DataMember(Name = "priceCurrency", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? PriceCurrency { get; set; }

        /// <summary>
        /// The seat associated with the ticket.
        /// </summary>
        [DataMember(Name = "ticketedSeat", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Seat>? TicketedSeat { get; set; }

        /// <summary>
        /// The unique identifier for the ticket.
        /// </summary>
        [DataMember(Name = "ticketNumber", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? TicketNumber { get; set; }

        /// <summary>
        /// Reference to an asset (e.g., Barcode, QR code image or PDF) usable for entrance.
        /// </summary>
        [DataMember(Name = "ticketToken", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? TicketToken { get; set; }

        /// <summary>
        /// The total price for the reservation or ticket, including applicable taxes, shipping, etc.&lt;br/&gt;&lt;br/&gt;
        /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "totalPrice", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<decimal?, PriceSpecification, string>? TotalPrice { get; set; }

        /// <summary>
        /// The person or organization the reservation or ticket is for.
        /// </summary>
        [DataMember(Name = "underName", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? UnderName { get; set; }
    }
}
