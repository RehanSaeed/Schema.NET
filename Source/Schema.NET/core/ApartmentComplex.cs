namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Residence type: Apartment complex.
    /// </summary>
    public partial interface IApartmentComplex : IResidence
    {
        /// <summary>
        /// Indicates the total (available plus unavailable) number of accommodation units in an &lt;a class="localLink" href="https://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt;, or the number of accommodation units for a specific &lt;a class="localLink" href="https://schema.org/FloorPlan"&gt;FloorPlan&lt;/a&gt; (within its specific &lt;a class="localLink" href="https://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt;). See also &lt;a class="localLink" href="https://schema.org/numberOfAvailableAccommodationUnits"&gt;numberOfAvailableAccommodationUnits&lt;/a&gt;.
        /// </summary>
        OneOrMany<IQuantitativeValue> NumberOfAccommodationUnits { get; set; }

        /// <summary>
        /// Indicates the number of available accommodation units in an &lt;a class="localLink" href="https://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt;, or the number of accommodation units for a specific &lt;a class="localLink" href="https://schema.org/FloorPlan"&gt;FloorPlan&lt;/a&gt; (within its specific &lt;a class="localLink" href="https://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt;). See also &lt;a class="localLink" href="https://schema.org/numberOfAccommodationUnits"&gt;numberOfAccommodationUnits&lt;/a&gt;.
        /// </summary>
        OneOrMany<IQuantitativeValue> NumberOfAvailableAccommodationUnits { get; set; }

        /// <summary>
        /// The total integer number of bedrooms in a some &lt;a class="localLink" href="https://schema.org/Accommodation"&gt;Accommodation&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/FloorPlan"&gt;FloorPlan&lt;/a&gt;.
        /// </summary>
        Values<int?, IQuantitativeValue> NumberOfBedrooms { get; set; }

        /// <summary>
        /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        Values<bool?, string> PetsAllowed { get; set; }
    }

    /// <summary>
    /// Residence type: Apartment complex.
    /// </summary>
    [DataContract]
    public partial class ApartmentComplex : Residence, IApartmentComplex, IEquatable<ApartmentComplex>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ApartmentComplex";

        /// <summary>
        /// Indicates the total (available plus unavailable) number of accommodation units in an &lt;a class="localLink" href="https://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt;, or the number of accommodation units for a specific &lt;a class="localLink" href="https://schema.org/FloorPlan"&gt;FloorPlan&lt;/a&gt; (within its specific &lt;a class="localLink" href="https://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt;). See also &lt;a class="localLink" href="https://schema.org/numberOfAvailableAccommodationUnits"&gt;numberOfAvailableAccommodationUnits&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "numberOfAccommodationUnits", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> NumberOfAccommodationUnits { get; set; }

        /// <summary>
        /// Indicates the number of available accommodation units in an &lt;a class="localLink" href="https://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt;, or the number of accommodation units for a specific &lt;a class="localLink" href="https://schema.org/FloorPlan"&gt;FloorPlan&lt;/a&gt; (within its specific &lt;a class="localLink" href="https://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt;). See also &lt;a class="localLink" href="https://schema.org/numberOfAccommodationUnits"&gt;numberOfAccommodationUnits&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "numberOfAvailableAccommodationUnits", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> NumberOfAvailableAccommodationUnits { get; set; }

        /// <summary>
        /// The total integer number of bedrooms in a some &lt;a class="localLink" href="https://schema.org/Accommodation"&gt;Accommodation&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/FloorPlan"&gt;FloorPlan&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "numberOfBedrooms", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, IQuantitativeValue> NumberOfBedrooms { get; set; }

        /// <summary>
        /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        [DataMember(Name = "petsAllowed", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<bool?, string> PetsAllowed { get; set; }

        /// <summary>
        /// A page providing information on how to book a tour of some &lt;a class="localLink" href="https://schema.org/Place"&gt;Place&lt;/a&gt;, such as an &lt;a class="localLink" href="https://schema.org/Accommodation"&gt;Accommodation&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt; in a real estate setting, as well as other kinds of tours as appropriate.
        /// </summary>
        [DataMember(Name = "tourBookingPage", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<Uri> TourBookingPage { get; set; }

        /// <inheritdoc/>
        public bool Equals(ApartmentComplex other)
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
                this.NumberOfAccommodationUnits == other.NumberOfAccommodationUnits &&
                this.NumberOfAvailableAccommodationUnits == other.NumberOfAvailableAccommodationUnits &&
                this.NumberOfBedrooms == other.NumberOfBedrooms &&
                this.PetsAllowed == other.PetsAllowed &&
                this.TourBookingPage == other.TourBookingPage &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as ApartmentComplex);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.NumberOfAccommodationUnits)
            .And(this.NumberOfAvailableAccommodationUnits)
            .And(this.NumberOfBedrooms)
            .And(this.PetsAllowed)
            .And(this.TourBookingPage)
            .And(base.GetHashCode());
    }
}
