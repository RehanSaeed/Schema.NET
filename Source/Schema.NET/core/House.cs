namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A house is a building or structure that has the ability to be occupied for habitation by humans or other creatures (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/House"&gt;http://en.wikipedia.org/wiki/House&lt;/a&gt;).
    /// </summary>
    public partial interface IHouse : IAccommodation
    {
    }

    /// <summary>
    /// A house is a building or structure that has the ability to be occupied for habitation by humans or other creatures (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/House"&gt;http://en.wikipedia.org/wiki/House&lt;/a&gt;).
    /// </summary>
    [DataContract]
    public partial class House : Accommodation, IHouse, IEquatable<House>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "House";

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the accommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        [DataMember(Name = "numberOfRooms", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<int?, IQuantitativeValue> NumberOfRooms { get; set; }

        /// <inheritdoc/>
        public bool Equals(House other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.NumberOfRooms == other.NumberOfRooms &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as House);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.NumberOfRooms)
            .And(base.GetHashCode());
    }
}
