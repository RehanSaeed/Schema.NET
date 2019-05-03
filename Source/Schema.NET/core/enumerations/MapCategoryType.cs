namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// An enumeration of several kinds of Map.
    /// </summary>
    public enum MapCategoryType
    {
        /// <summary>
        /// A parking map.
        /// </summary>
        [EnumMember(Value = "http://schema.org/ParkingMap")]
        ParkingMap,

        /// <summary>
        /// A seating map.
        /// </summary>
        [EnumMember(Value = "http://schema.org/SeatingMap")]
        SeatingMap,

        /// <summary>
        /// A transit map.
        /// </summary>
        [EnumMember(Value = "http://schema.org/TransitMap")]
        TransitMap,

        /// <summary>
        /// A venue map (e.g. for malls, auditoriums, museums, etc.).
        /// </summary>
        [EnumMember(Value = "http://schema.org/VenueMap")]
        VenueMap
    }
}
