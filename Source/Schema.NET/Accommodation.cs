namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An accommodation is a place that can accommodate human beings, e...
    /// </summary>
    [DataContract]
    public class Accommodation : Place
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Accommodation";

        /// <summary>
        /// The size of the accommodation, e.g. in square meter or squarefoot.
        /// Typical unit code(s): MTK for square meter, FTK for square foot, or YDK for square yard
        /// </summary>
        [DataMember(Name = "floorSize")]
        public QuantitativeValue FloorSize { get; set; }

        /// <summary>
        /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        [DataMember(Name = "petsAllowed")]
        public object PetsAllowed { get; protected set; }

        /// <summary>
        /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        [IgnoreDataMember]
        public string PetsAllowedText
        {
            get => this.PetsAllowed as string;
            set => this.PetsAllowed = value;
        }

        /// <summary>
        /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        [IgnoreDataMember]
        public bool? PetsAllowedBoolean
        {
            get => this.PetsAllowed as bool?;
            set => this.PetsAllowed = value;
        }

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [DataMember(Name = "amenityFeature")]
        public override LocationFeatureSpecification AmenityFeature { get; set; }

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the acccommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        [DataMember(Name = "numberOfRooms")]
        public virtual object NumberOfRooms { get; protected set; }

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the acccommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        [IgnoreDataMember]
        public virtual decimal? NumberOfRoomsNumber
        {
            get => this.NumberOfRooms as decimal?;
            set => this.NumberOfRooms = value;
        }

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the acccommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        [IgnoreDataMember]
        public virtual QuantitativeValue NumberOfRoomsQuantitativeValue
        {
            get => this.NumberOfRooms as QuantitativeValue;
            set => this.NumberOfRooms = value;
        }

        /// <summary>
        /// Indications regarding the permitted usage of the accommodation.
        /// </summary>
        [DataMember(Name = "permittedUsage")]
        public string PermittedUsage { get; set; }
    }
}
