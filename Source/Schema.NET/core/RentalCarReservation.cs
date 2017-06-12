namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A reservation for a rental car.
    /// Note: This type is for information about actual reservations, e...
    /// </summary>
    [DataContract]
    public class RentalCarReservation : Reservation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RentalCarReservation";

        /// <summary>
        /// Where a rental car can be dropped off.
        /// </summary>
        [DataMember(Name = "dropoffLocation", Order = 2)]
        public Place DropoffLocation { get; set; }

        /// <summary>
        /// When a rental car can be dropped off.
        /// </summary>
        [DataMember(Name = "dropoffTime", Order = 3)]
        public DateTimeOffset? DropoffTime { get; set; }

        /// <summary>
        /// Where a taxi will pick up a passenger or a rental car can be picked up.
        /// </summary>
        [DataMember(Name = "pickupLocation", Order = 4)]
        public Place PickupLocation { get; set; }

        /// <summary>
        /// When a taxi will pickup a passenger or a rental car can be picked up.
        /// </summary>
        [DataMember(Name = "pickupTime", Order = 5)]
        public DateTimeOffset? PickupTime { get; set; }
    }
}
