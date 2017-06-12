namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A reservation for bus travel.
    /// Note: This type is for information about actual reservations, e...
    /// </summary>
    [DataContract]
    public partial class BusReservation : Reservation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BusReservation";
    }
}
