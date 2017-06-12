namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A reservation for lodging at a hotel, motel, inn, etc.
    /// Note: This type is for information about actual reservations, e...
    /// </summary>
    [DataContract]
    public class LodgingReservation : Reservation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LodgingReservation";

        /// <summary>
        /// The earliest someone may check into a lodging establishment.
        /// </summary>
        [DataMember(Name = "checkinTime", Order = 2)]
        public DateTimeOffset? CheckinTime { get; set; }

        /// <summary>
        /// The latest someone may check out of a lodging establishment.
        /// </summary>
        [DataMember(Name = "checkoutTime", Order = 3)]
        public DateTimeOffset? CheckoutTime { get; set; }

        /// <summary>
        /// A full description of the lodging unit.
        /// </summary>
        [DataMember(Name = "lodgingUnitDescription", Order = 4)]
        public string LodgingUnitDescription { get; set; }

        /// <summary>
        /// Textual description of the unit type (including suite vs. room, size of bed, etc.).
        /// </summary>
        [DataMember(Name = "lodgingUnitType", Order = 5)]
        public string LodgingUnitType { get; set; }

        /// <summary>
        /// The number of adults staying in the unit.
        /// </summary>
        [DataMember(Name = "numAdults", Order = 6)]
        public object NumAdults { get; protected set; }

        /// <summary>
        /// The number of adults staying in the unit.
        /// </summary>
        [IgnoreDataMember]
        public QuantitativeValue NumAdultsQuantitativeValue
        {
            get => this.NumAdults as QuantitativeValue;
            set => this.NumAdults = value;
        }

        /// <summary>
        /// The number of adults staying in the unit.
        /// </summary>
        [IgnoreDataMember]
        public int? NumAdultsInteger
        {
            get => this.NumAdults as int?;
            set => this.NumAdults = value;
        }

        /// <summary>
        /// The number of children staying in the unit.
        /// </summary>
        [DataMember(Name = "numChildren", Order = 7)]
        public object NumChildren { get; protected set; }

        /// <summary>
        /// The number of children staying in the unit.
        /// </summary>
        [IgnoreDataMember]
        public int? NumChildrenInteger
        {
            get => this.NumChildren as int?;
            set => this.NumChildren = value;
        }

        /// <summary>
        /// The number of children staying in the unit.
        /// </summary>
        [IgnoreDataMember]
        public QuantitativeValue NumChildrenQuantitativeValue
        {
            get => this.NumChildren as QuantitativeValue;
            set => this.NumChildren = value;
        }
    }
}
