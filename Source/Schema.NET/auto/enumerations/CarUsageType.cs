namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// A value indicating a special usage of a car, e.g. commercial rental, driving school, or as a taxi.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CarUsageType
    {
        /// <summary>
        /// Indicates the usage of the vehicle for driving school.
        /// </summary>
        [EnumMember(Value = "https://schema.org/DrivingSchoolVehicleUsage")]
        DrivingSchoolVehicleUsage,

        /// <summary>
        /// Indicates the usage of the vehicle as a rental car.
        /// </summary>
        [EnumMember(Value = "https://schema.org/RentalVehicleUsage")]
        RentalVehicleUsage,

        /// <summary>
        /// Indicates the usage of the car as a taxi.
        /// </summary>
        [EnumMember(Value = "https://schema.org/TaxiVehicleUsage")]
        TaxiVehicleUsage
    }
}
