namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A house is a building or structure that has the ability to be occupied for habitation by humans or other creatures (Source: Wikipedia, the free encyclopedia, see http://en...
    /// </summary>
    [DataContract]
    public class House : Accommodation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "House";

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the acccommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        [DataMember(Name = "numberOfRooms")]
        public override object NumberOfRooms { get; protected set; }

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the acccommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        [IgnoreDataMember]
        public override decimal? NumberOfRoomsNumber
        {
            get => this.NumberOfRooms as decimal?;
            set => this.NumberOfRooms = value;
        }

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the acccommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        [IgnoreDataMember]
        public override QuantitativeValue NumberOfRoomsQuantitativeValue
        {
            get => this.NumberOfRooms as QuantitativeValue;
            set => this.NumberOfRooms = value;
        }
    }
}
