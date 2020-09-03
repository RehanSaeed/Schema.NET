namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An entity holding detailed information about the available bed types, e.g. the quantity of twin beds for a hotel room. For the single case of just one bed of a certain type, you can use bed directly with a text. See also &lt;a class="localLink" href="https://schema.org/BedType"&gt;BedType&lt;/a&gt; (under development).
    /// </summary>
    public partial interface IBedDetails : IIntangible
    {
        /// <summary>
        /// The quantity of the given bed type available in the HotelRoom, Suite, House, or Apartment.
        /// </summary>
        OneOrMany<int?> NumberOfBeds { get; set; }

        /// <summary>
        /// The type of bed to which the BedDetail refers, i.e. the type of bed available in the quantity indicated by quantity.
        /// </summary>
        Values<BedType?, string> TypeOfBed { get; set; }
    }

    /// <summary>
    /// An entity holding detailed information about the available bed types, e.g. the quantity of twin beds for a hotel room. For the single case of just one bed of a certain type, you can use bed directly with a text. See also &lt;a class="localLink" href="https://schema.org/BedType"&gt;BedType&lt;/a&gt; (under development).
    /// </summary>
    [DataContract]
    public partial class BedDetails : Intangible, IBedDetails, IEquatable<BedDetails>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BedDetails";

        /// <summary>
        /// The quantity of the given bed type available in the HotelRoom, Suite, House, or Apartment.
        /// </summary>
        [DataMember(Name = "numberOfBeds", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> NumberOfBeds { get; set; }

        /// <summary>
        /// The type of bed to which the BedDetail refers, i.e. the type of bed available in the quantity indicated by quantity.
        /// </summary>
        [DataMember(Name = "typeOfBed", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<BedType?, string> TypeOfBed { get; set; }

        /// <inheritdoc/>
        public bool Equals(BedDetails other)
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
                this.NumberOfBeds == other.NumberOfBeds &&
                this.TypeOfBed == other.TypeOfBed &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as BedDetails);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.NumberOfBeds)
            .And(this.TypeOfBed)
            .And(base.GetHashCode());
    }
}
