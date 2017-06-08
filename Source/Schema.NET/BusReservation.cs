namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A reservation for bus travel.
    /// Note: This type is for information about actual reservations, e...
    /// </summary>
    [DataContract]
    public class BusReservation : Reservation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "BusReservation";
    }
}
