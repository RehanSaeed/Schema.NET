namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An apartment (in American English) or flat (in British English) is a self-contained housing unit (a type of residential real estate) that occupies only part of a building (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Apartment"&gt;http://en.wikipedia.org/wiki/Apartment&lt;/a&gt;).
    /// </summary>
    public partial interface IApartment : IAccommodation
    {
        /// <summary>
        /// The allowed total occupancy for the accommodation in persons (including infants etc). For individual accommodations, this is not necessarily the legal maximum but defines the permitted usage as per the contractual agreement (e.g. a double room used by a single person).
        /// Typical unit code(s): C62 for person
        /// </summary>
        OneOrMany<IQuantitativeValue> Occupancy { get; set; }
    }

    /// <summary>
    /// An apartment (in American English) or flat (in British English) is a self-contained housing unit (a type of residential real estate) that occupies only part of a building (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Apartment"&gt;http://en.wikipedia.org/wiki/Apartment&lt;/a&gt;).
    /// </summary>
    [DataContract]
    public partial class Apartment : Accommodation, IApartment, IEquatable<Apartment>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Apartment";

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the accommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        [DataMember(Name = "numberOfRooms", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<int?, IQuantitativeValue> NumberOfRooms { get; set; }

        /// <summary>
        /// The allowed total occupancy for the accommodation in persons (including infants etc). For individual accommodations, this is not necessarily the legal maximum but defines the permitted usage as per the contractual agreement (e.g. a double room used by a single person).
        /// Typical unit code(s): C62 for person
        /// </summary>
        [DataMember(Name = "occupancy", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> Occupancy { get; set; }

        /// <inheritdoc/>
        public bool Equals(Apartment other)
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
                this.Occupancy == other.Occupancy &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Apartment);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.NumberOfRooms)
            .And(this.Occupancy)
            .And(base.GetHashCode());
    }
}
