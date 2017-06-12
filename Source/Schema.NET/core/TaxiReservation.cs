namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A reservation for a taxi.
    /// Note: This type is for information about actual reservations, e...
    /// </summary>
    [DataContract]
    public partial class TaxiReservation : Reservation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TaxiReservation";

        /// <summary>
        /// Number of people the reservation should accommodate.
        /// </summary>
        [DataMember(Name = "partySize", Order = 2)]
        public object PartySize { get; protected set; }

        /// <summary>
        /// Number of people the reservation should accommodate.
        /// </summary>
        [IgnoreDataMember]
        public QuantitativeValue PartySizeQuantitativeValue
        {
            get => this.PartySize as QuantitativeValue;
            set => this.PartySize = value;
        }

        /// <summary>
        /// Number of people the reservation should accommodate.
        /// </summary>
        [IgnoreDataMember]
        public int? PartySizeInteger
        {
            get => this.PartySize as int?;
            set => this.PartySize = value;
        }

        /// <summary>
        /// Where a taxi will pick up a passenger or a rental car can be picked up.
        /// </summary>
        [DataMember(Name = "pickupLocation", Order = 3)]
        public Place PickupLocation { get; set; }

        /// <summary>
        /// When a taxi will pickup a passenger or a rental car can be picked up.
        /// </summary>
        [DataMember(Name = "pickupTime", Order = 4)]
        public DateTimeOffset? PickupTime { get; set; }
    }
}
