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
        /// Indicates the total (available plus unavailable) number of accommodation units in an &lt;a class="localLink" href="http://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt;, or the number of accommodation units for a specific &lt;a class="localLink" href="http://schema.org/FloorPlan"&gt;FloorPlan&lt;/a&gt; (within its specific &lt;a class="localLink" href="http://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt;). See also &lt;a class="localLink" href="http://schema.org/numberOfAvailableAccommodationUnits"&gt;numberOfAvailableAccommodationUnits&lt;/a&gt;.
        /// </summary>
        OneOrMany<IQuantitativeValue> NumberOfAccommodationUnits { get; set; }

        /// <summary>
        /// Indicates the number of available accommodation units in an &lt;a class="localLink" href="http://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt;, or the number of accommodation units for a specific &lt;a class="localLink" href="http://schema.org/FloorPlan"&gt;FloorPlan&lt;/a&gt; (within its specific &lt;a class="localLink" href="http://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt;). See also &lt;a class="localLink" href="http://schema.org/numberOfAccommodationUnits"&gt;numberOfAccommodationUnits&lt;/a&gt;.
        /// </summary>
        OneOrMany<IQuantitativeValue> NumberOfAvailableAccommodationUnits { get; set; }
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
        /// Indicates the total (available plus unavailable) number of accommodation units in an &lt;a class="localLink" href="http://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt;, or the number of accommodation units for a specific &lt;a class="localLink" href="http://schema.org/FloorPlan"&gt;FloorPlan&lt;/a&gt; (within its specific &lt;a class="localLink" href="http://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt;). See also &lt;a class="localLink" href="http://schema.org/numberOfAvailableAccommodationUnits"&gt;numberOfAvailableAccommodationUnits&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "numberOfAccommodationUnits", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> NumberOfAccommodationUnits { get; set; }

        /// <summary>
        /// Indicates the number of available accommodation units in an &lt;a class="localLink" href="http://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt;, or the number of accommodation units for a specific &lt;a class="localLink" href="http://schema.org/FloorPlan"&gt;FloorPlan&lt;/a&gt; (within its specific &lt;a class="localLink" href="http://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt;). See also &lt;a class="localLink" href="http://schema.org/numberOfAccommodationUnits"&gt;numberOfAccommodationUnits&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "numberOfAvailableAccommodationUnits", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> NumberOfAvailableAccommodationUnits { get; set; }

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
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as ApartmentComplex);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.NumberOfAccommodationUnits)
            .And(this.NumberOfAvailableAccommodationUnits)
            .And(base.GetHashCode());
    }
}
