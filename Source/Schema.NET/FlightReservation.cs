namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A reservation for air travel.
    /// Note: This type is for information about actual reservations, e...
    /// </summary>
    [DataContract]
    public class FlightReservation : Reservation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "FlightReservation";

        /// <summary>
        /// The airline-specific indicator of boarding order / preference.
        /// </summary>
        [DataMember(Name = "boardingGroup")]
        public string BoardingGroup { get; set; }

        /// <summary>
        /// The passenger's sequence number as assigned by the airline.
        /// </summary>
        [DataMember(Name = "passengerSequenceNumber")]
        public string PassengerSequenceNumber { get; set; }

        /// <summary>
        /// The type of security screening the passenger is subject to.
        /// </summary>
        [DataMember(Name = "securityScreening")]
        public string SecurityScreening { get; set; }

        /// <summary>
        /// The priority status assigned to a passenger for security or boarding (e.g. FastTrack or Priority).
        /// </summary>
        [DataMember(Name = "passengerPriorityStatus")]
        public object PassengerPriorityStatus { get; protected set; }

        /// <summary>
        /// The priority status assigned to a passenger for security or boarding (e.g. FastTrack or Priority).
        /// </summary>
        [IgnoreDataMember]
        public QualitativeValue PassengerPriorityStatusQualitativeValue
        {
            get => this.PassengerPriorityStatus as QualitativeValue;
            set => this.PassengerPriorityStatus = value;
        }

        /// <summary>
        /// The priority status assigned to a passenger for security or boarding (e.g. FastTrack or Priority).
        /// </summary>
        [IgnoreDataMember]
        public string PassengerPriorityStatusText
        {
            get => this.PassengerPriorityStatus as string;
            set => this.PassengerPriorityStatus = value;
        }
    }
}
