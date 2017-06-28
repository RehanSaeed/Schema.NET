namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An accommodation is a place that can accommodate human beings, e...
    /// </summary>
    [DataContract]
    public partial class Accommodation : Place
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Accommodation";

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [DataMember(Name = "amenityFeature", Order = 205)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<LocationFeatureSpecification>? AmenityFeature { get; set; }

        /// <summary>
        /// The size of the accommodation, e.g. in square meter or squarefoot.
        /// Typical unit code(s): MTK for square meter, FTK for square foot, or YDK for square yard
        /// </summary>
        [DataMember(Name = "floorSize", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? FloorSize { get; set; }

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the acccommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        [DataMember(Name = "numberOfRooms", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<int?, QuantitativeValue>? NumberOfRooms { get; set; }

        /// <summary>
        /// Indications regarding the permitted usage of the accommodation.
        /// </summary>
        [DataMember(Name = "permittedUsage", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PermittedUsage { get; set; }

        /// <summary>
        /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        [DataMember(Name = "petsAllowed", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, bool?>? PetsAllowed { get; set; }
    }
}
