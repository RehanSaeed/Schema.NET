namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// A value indicating a special usage of a car, e.g. commercial rental, driving school, or as a taxi.
    /// </summary>
    public enum CarUsageType
    {
        /// <summary>
        /// Indicates the usage of the vehicle for driving school.
        /// </summary>
        [EnumMember(Value = "http://schema.org/DrivingSchoolVehicleUsage")]
        DrivingSchoolVehicleUsage,

        /// <summary>
        /// Indicates the usage of the vehicle as a rental car.
        /// </summary>
        [EnumMember(Value = "http://schema.org/RentalVehicleUsage")]
        RentalVehicleUsage,

        /// <summary>
        /// Indicates the usage of the car as a taxi.
        /// </summary>
        [EnumMember(Value = "http://schema.org/TaxiVehicleUsage")]
        TaxiVehicleUsage
    }
}
