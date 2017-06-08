namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets...
    /// </summary>
    [DataContract]
    public class Reservation : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Reservation";

        /// <summary>
        /// The current status of the reservation.
        /// </summary>
        [DataMember(Name = "reservationStatus")]
        public ReservationStatusType ReservationStatus { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider")]
        public object Provider { get; protected set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [IgnoreDataMember]
        public Organization ProviderOrganization
        {
            get => this.Provider as Organization;
            set => this.Provider = value;
        }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [IgnoreDataMember]
        public Person ProviderPerson
        {
            get => this.Provider as Person;
            set => this.Provider = value;
        }

        /// <summary>
        /// Any membership in a frequent flyer, hotel loyalty program, etc. being applied to the reservation.
        /// </summary>
        [DataMember(Name = "programMembershipUsed")]
        public ProgramMembership ProgramMembershipUsed { get; set; }

        /// <summary>
        /// The person or organization the reservation or ticket is for.
        /// </summary>
        [DataMember(Name = "underName")]
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

        /// <summary>
        /// The total price for the reservation or ticket, including applicable taxes, shipping, etc.
        /// </summary>
        [DataMember(Name = "totalPrice")]
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
        /// The thing -- flight, event, restaurant,etc. being reserved.
        /// </summary>
        [DataMember(Name = "reservationFor")]
        public Thing ReservationFor { get; set; }

        /// <summary>
        /// The currency (in 3-letter ISO 4217 format) of the price or a price component, when attached to &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.
        /// </summary>
        [DataMember(Name = "priceCurrency")]
        public string PriceCurrency { get; set; }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [DataMember(Name = "broker")]
        public object Broker { get; protected set; }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [IgnoreDataMember]
        public Organization BrokerOrganization
        {
            get => this.Broker as Organization;
            set => this.Broker = value;
        }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [IgnoreDataMember]
        public Person BrokerPerson
        {
            get => this.Broker as Person;
            set => this.Broker = value;
        }

        /// <summary>
        /// The date and time the reservation was modified.
        /// </summary>
        [DataMember(Name = "modifiedTime")]
        public DateTimeOffset ModifiedTime { get; set; }

        /// <summary>
        /// The date and time the reservation was booked.
        /// </summary>
        [DataMember(Name = "bookingTime")]
        public DateTimeOffset BookingTime { get; set; }

        /// <summary>
        /// A unique identifier for the reservation.
        /// </summary>
        [DataMember(Name = "reservationId")]
        public string ReservationId { get; set; }

        /// <summary>
        /// A ticket associated with the reservation.
        /// </summary>
        [DataMember(Name = "reservedTicket")]
        public Ticket ReservedTicket { get; set; }
    }
}
