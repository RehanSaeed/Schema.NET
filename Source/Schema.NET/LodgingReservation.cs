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
        [DataMember(Name = "@type")]
        public override string Type => "LodgingReservation";

        /// <summary>
        /// A full description of the lodging unit.
        /// </summary>
        [DataMember(Name = "lodgingUnitDescription")]
        public string LodgingUnitDescription { get; set; }

        /// <summary>
        /// The earliest someone may check into a lodging establishment.
        /// </summary>
        [DataMember(Name = "checkinTime")]
        public DateTimeOffset CheckinTime { get; set; }

        /// <summary>
        /// The number of children staying in the unit.
        /// </summary>
        [DataMember(Name = "numChildren")]
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

        /// <summary>
        /// The latest someone may check out of a lodging establishment.
        /// </summary>
        [DataMember(Name = "checkoutTime")]
        public DateTimeOffset CheckoutTime { get; set; }

        /// <summary>
        /// Textual description of the unit type (including suite vs. room, size of bed, etc.).
        /// </summary>
        [DataMember(Name = "lodgingUnitType")]
        public object LodgingUnitType { get; protected set; }

        /// <summary>
        /// Textual description of the unit type (including suite vs. room, size of bed, etc.).
        /// </summary>
        [IgnoreDataMember]
        public string LodgingUnitTypeText
        {
            get => this.LodgingUnitType as string;
            set => this.LodgingUnitType = value;
        }

        /// <summary>
        /// Textual description of the unit type (including suite vs. room, size of bed, etc.).
        /// </summary>
        [IgnoreDataMember]
        public QualitativeValue LodgingUnitTypeQualitativeValue
        {
            get => this.LodgingUnitType as QualitativeValue;
            set => this.LodgingUnitType = value;
        }

        /// <summary>
        /// The number of adults staying in the unit.
        /// </summary>
        [DataMember(Name = "numAdults")]
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
    }
}
