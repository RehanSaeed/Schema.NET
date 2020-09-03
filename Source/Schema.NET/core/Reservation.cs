namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. &lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use &lt;a class="localLink" href="https://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// </summary>
    public partial interface IReservation : IIntangible
    {
        /// <summary>
        /// The date and time the reservation was booked.
        /// </summary>
        OneOrMany<DateTimeOffset?> BookingTime { get; set; }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        Values<IOrganization, IPerson> Broker { get; set; }

        /// <summary>
        /// The date and time the reservation was modified.
        /// </summary>
        OneOrMany<DateTimeOffset?> ModifiedTime { get; set; }

        /// <summary>
        /// The currency of the price, or a price component when attached to &lt;a class="localLink" href="https://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        OneOrMany<string> PriceCurrency { get; set; }

        /// <summary>
        /// Any membership in a frequent flyer, hotel loyalty program, etc. being applied to the reservation.
        /// </summary>
        OneOrMany<IProgramMembership> ProgramMembershipUsed { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        Values<IOrganization, IPerson> Provider { get; set; }

        /// <summary>
        /// The thing -- flight, event, restaurant,etc. being reserved.
        /// </summary>
        OneOrMany<IThing> ReservationFor { get; set; }

        /// <summary>
        /// A unique identifier for the reservation.
        /// </summary>
        OneOrMany<string> ReservationId { get; set; }

        /// <summary>
        /// The current status of the reservation.
        /// </summary>
        OneOrMany<ReservationStatusType?> ReservationStatus { get; set; }

        /// <summary>
        /// A ticket associated with the reservation.
        /// </summary>
        OneOrMany<ITicket> ReservedTicket { get; set; }

        /// <summary>
        /// The total price for the reservation or ticket, including applicable taxes, shipping, etc.&lt;br/&gt;&lt;br/&gt;
        /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        Values<decimal?, IPriceSpecification, string> TotalPrice { get; set; }

        /// <summary>
        /// The person or organization the reservation or ticket is for.
        /// </summary>
        Values<IOrganization, IPerson> UnderName { get; set; }
    }

    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. &lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use &lt;a class="localLink" href="https://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class Reservation : Intangible, IReservation, IEquatable<Reservation>
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> BookingTime { get; set; }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [DataMember(Name = "broker", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Broker { get; set; }

        /// <summary>
        /// The date and time the reservation was modified.
        /// </summary>
        [DataMember(Name = "modifiedTime", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> ModifiedTime { get; set; }

        /// <summary>
        /// The currency of the price, or a price component when attached to &lt;a class="localLink" href="https://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        [DataMember(Name = "priceCurrency", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PriceCurrency { get; set; }

        /// <summary>
        /// Any membership in a frequent flyer, hotel loyalty program, etc. being applied to the reservation.
        /// </summary>
        [DataMember(Name = "programMembershipUsed", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IProgramMembership> ProgramMembershipUsed { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Provider { get; set; }

        /// <summary>
        /// The thing -- flight, event, restaurant,etc. being reserved.
        /// </summary>
        [DataMember(Name = "reservationFor", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> ReservationFor { get; set; }

        /// <summary>
        /// A unique identifier for the reservation.
        /// </summary>
        [DataMember(Name = "reservationId", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ReservationId { get; set; }

        /// <summary>
        /// The current status of the reservation.
        /// </summary>
        [DataMember(Name = "reservationStatus", Order = 214)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ReservationStatusType?> ReservationStatus { get; set; }

        /// <summary>
        /// A ticket associated with the reservation.
        /// </summary>
        [DataMember(Name = "reservedTicket", Order = 215)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ITicket> ReservedTicket { get; set; }

        /// <summary>
        /// The total price for the reservation or ticket, including applicable taxes, shipping, etc.&lt;br/&gt;&lt;br/&gt;
        /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "totalPrice", Order = 216)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<decimal?, IPriceSpecification, string> TotalPrice { get; set; }

        /// <summary>
        /// The person or organization the reservation or ticket is for.
        /// </summary>
        [DataMember(Name = "underName", Order = 217)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> UnderName { get; set; }

        /// <inheritdoc/>
        public bool Equals(Reservation other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.BookingTime == other.BookingTime &&
                this.Broker == other.Broker &&
                this.ModifiedTime == other.ModifiedTime &&
                this.PriceCurrency == other.PriceCurrency &&
                this.ProgramMembershipUsed == other.ProgramMembershipUsed &&
                this.Provider == other.Provider &&
                this.ReservationFor == other.ReservationFor &&
                this.ReservationId == other.ReservationId &&
                this.ReservationStatus == other.ReservationStatus &&
                this.ReservedTicket == other.ReservedTicket &&
                this.TotalPrice == other.TotalPrice &&
                this.UnderName == other.UnderName &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Reservation);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.BookingTime)
            .And(this.Broker)
            .And(this.ModifiedTime)
            .And(this.PriceCurrency)
            .And(this.ProgramMembershipUsed)
            .And(this.Provider)
            .And(this.ReservationFor)
            .And(this.ReservationId)
            .And(this.ReservationStatus)
            .And(this.ReservedTicket)
            .And(this.TotalPrice)
            .And(this.UnderName)
            .And(base.GetHashCode());
    }
}
