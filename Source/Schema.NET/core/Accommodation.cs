namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An accommodation is a place that can accommodate human beings, e.g. a hotel room, a camping pitch, or a meeting room. Many accommodations are for overnight stays, but this is not a mandatory requirement.
    /// For more specific types of accommodations not defined in schema.org, one can use additionalType with external vocabularies.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// </summary>
    public partial interface IAccommodation : IPlace
    {
        /// <summary>
        /// The size of the accommodation, e.g. in square meter or squarefoot.
        /// Typical unit code(s): MTK for square meter, FTK for square foot, or YDK for square yard
        /// </summary>
        OneOrMany<IQuantitativeValue> FloorSize { get; set; }

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the accommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        Values<int?, IQuantitativeValue> NumberOfRooms { get; set; }

        /// <summary>
        /// Indications regarding the permitted usage of the accommodation.
        /// </summary>
        OneOrMany<string> PermittedUsage { get; set; }

        /// <summary>
        /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        Values<bool?, string> PetsAllowed { get; set; }
    }

    /// <summary>
    /// An accommodation is a place that can accommodate human beings, e.g. a hotel room, a camping pitch, or a meeting room. Many accommodations are for overnight stays, but this is not a mandatory requirement.
    /// For more specific types of accommodations not defined in schema.org, one can use additionalType with external vocabularies.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class Accommodation : Place, IAccommodation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Accommodation";

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [DataMember(Name = "amenityFeature", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<ILocationFeatureSpecification> AmenityFeature { get; set; }

        /// <summary>
        /// The size of the accommodation, e.g. in square meter or squarefoot.
        /// Typical unit code(s): MTK for square meter, FTK for square foot, or YDK for square yard
        /// </summary>
        [DataMember(Name = "floorSize", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> FloorSize { get; set; }

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the accommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        [DataMember(Name = "numberOfRooms", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<int?, IQuantitativeValue> NumberOfRooms { get; set; }

        /// <summary>
        /// Indications regarding the permitted usage of the accommodation.
        /// </summary>
        [DataMember(Name = "permittedUsage", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PermittedUsage { get; set; }

        /// <summary>
        /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        [DataMember(Name = "petsAllowed", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<bool?, string> PetsAllowed { get; set; }
    }
}
