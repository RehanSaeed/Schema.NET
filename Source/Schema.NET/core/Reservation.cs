namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. &lt;/p&gt;
    /// &lt;p&gt;Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class Reservation : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Reservation";

        /// <summary>
        /// The date and time the reservation was booked.
        /// </summary>
        [DataMember(Name = "bookingTime", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? BookingTime { get; set; }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [DataMember(Name = "broker", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Broker { get; set; }

        /// <summary>
        /// The date and time the reservation was modified.
        /// </summary>
        [DataMember(Name = "modifiedTime", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? ModifiedTime { get; set; }

        /// <summary>
        /// The currency (in 3-letter ISO 4217 format) of the price or a price component, when attached to &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.
        /// </summary>
        [DataMember(Name = "priceCurrency", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PriceCurrency { get; set; }

        /// <summary>
        /// Any membership in a frequent flyer, hotel loyalty program, etc. being applied to the reservation.
        /// </summary>
        [DataMember(Name = "programMembershipUsed", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ProgramMembership>? ProgramMembershipUsed { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Provider { get; set; }

        /// <summary>
        /// The thing -- flight, event, restaurant,etc. being reserved.
        /// </summary>
        [DataMember(Name = "reservationFor", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? ReservationFor { get; set; }

        /// <summary>
        /// A unique identifier for the reservation.
        /// </summary>
        [DataMember(Name = "reservationId", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ReservationId { get; set; }

        /// <summary>
        /// The current status of the reservation.
        /// </summary>
        [DataMember(Name = "reservationStatus", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ReservationStatusType?>? ReservationStatus { get; set; }

        /// <summary>
        /// A ticket associated with the reservation.
        /// </summary>
        [DataMember(Name = "reservedTicket", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Ticket>? ReservedTicket { get; set; }

        /// <summary>
        /// The total price for the reservation or ticket, including applicable taxes, shipping, etc.
        /// </summary>
        [DataMember(Name = "totalPrice", Order = 216)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<decimal?, PriceSpecification, string>? TotalPrice { get; set; }

        /// <summary>
        /// The person or organization the reservation or ticket is for.
        /// </summary>
        [DataMember(Name = "underName", Order = 217)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? UnderName { get; set; }
    }
}
