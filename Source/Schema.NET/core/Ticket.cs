namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

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
        [DataMember(Name = "dateIssued", Order = 2)]
        public DateTimeOffset? DateIssued { get; set; }

        /// <summary>
        /// The organization issuing the ticket or permit.
        /// </summary>
        [DataMember(Name = "issuedBy", Order = 3)]
        public Organization IssuedBy { get; set; }

        /// <summary>
        /// The currency (in 3-letter ISO 4217 format) of the price or a price component, when attached to &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.
        /// </summary>
        [DataMember(Name = "priceCurrency", Order = 4)]
        public string PriceCurrency { get; set; }

        /// <summary>
        /// The seat associated with the ticket.
        /// </summary>
        [DataMember(Name = "ticketedSeat", Order = 5)]
        public Seat TicketedSeat { get; set; }

        /// <summary>
        /// The unique identifier for the ticket.
        /// </summary>
        [DataMember(Name = "ticketNumber", Order = 6)]
        public string TicketNumber { get; set; }

        /// <summary>
        /// Reference to an asset (e.g., Barcode, QR code image or PDF) usable for entrance.
        /// </summary>
        [DataMember(Name = "ticketToken", Order = 7)]
        public object TicketToken { get; protected set; }

        /// <summary>
        /// Reference to an asset (e.g., Barcode, QR code image or PDF) usable for entrance.
        /// </summary>
        [IgnoreDataMember]
        public string TicketTokenText
        {
            get => this.TicketToken as string;
            set => this.TicketToken = value;
        }

        /// <summary>
        /// Reference to an asset (e.g., Barcode, QR code image or PDF) usable for entrance.
        /// </summary>
        [IgnoreDataMember]
        public Uri TicketTokenURL
        {
            get => this.TicketToken as Uri;
            set => this.TicketToken = value;
        }

        /// <summary>
        /// The total price for the reservation or ticket, including applicable taxes, shipping, etc.
        /// </summary>
        [DataMember(Name = "totalPrice", Order = 8)]
        public object TotalPrice { get; protected set; }

        /// <summary>
        /// The total price for the reservation or ticket, including applicable taxes, shipping, etc.
        /// </summary>
        [IgnoreDataMember]
        public decimal? TotalPriceNumber
        {
            get => this.TotalPrice as decimal?;
            set => this.TotalPrice = value;
        }

        /// <summary>
        /// The total price for the reservation or ticket, including applicable taxes, shipping, etc.
        /// </summary>
        [IgnoreDataMember]
        public PriceSpecification TotalPricePriceSpecification
        {
            get => this.TotalPrice as PriceSpecification;
            set => this.TotalPrice = value;
        }

        /// <summary>
        /// The total price for the reservation or ticket, including applicable taxes, shipping, etc.
        /// </summary>
        [IgnoreDataMember]
        public string TotalPriceText
        {
            get => this.TotalPrice as string;
            set => this.TotalPrice = value;
        }

        /// <summary>
        /// The person or organization the reservation or ticket is for.
        /// </summary>
        [DataMember(Name = "underName", Order = 9)]
        public object UnderName { get; protected set; }

        /// <summary>
        /// The person or organization the reservation or ticket is for.
        /// </summary>
        [IgnoreDataMember]
        public Person UnderNamePerson
        {
            get => this.UnderName as Person;
            set => this.UnderName = value;
        }

        /// <summary>
        /// The person or organization the reservation or ticket is for.
        /// </summary>
        [IgnoreDataMember]
        public Organization UnderNameOrganization
        {
            get => this.UnderName as Organization;
            set => this.UnderName = value;
        }
    }
}
