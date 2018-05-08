namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An entity holding detailed information about the available bed types, e.g. the quantity of twin beds for a hotel room. For the single case of just one bed of a certain type, you can use bed directly with a text. See also &lt;a class="localLink" href="http://schema.org/BedType"&gt;BedType&lt;/a&gt; (under development).
    /// </summary>
    public partial interface IBedDetails : IIntangible
    {
        /// <summary>
        /// The quantity of the given bed type available in the HotelRoom, Suite, House, or Apartment.
        /// </summary>
        OneOrMany<int?>? NumberOfBeds { get; set; }

        /// <summary>
        /// The type of bed to which the BedDetail refers, i.e. the type of bed available in the quantity indicated by quantity.
        /// </summary>
        OneOrMany<string>? TypeOfBed { get; set; }
    }

    /// <summary>
    /// An entity holding detailed information about the available bed types, e.g. the quantity of twin beds for a hotel room. For the single case of just one bed of a certain type, you can use bed directly with a text. See also &lt;a class="localLink" href="http://schema.org/BedType"&gt;BedType&lt;/a&gt; (under development).
    /// </summary>
    [DataContract]
    public partial class BedDetails : Intangible, IBedDetails
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
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<int?>? NumberOfBeds { get; set; }

        /// <summary>
        /// The type of bed to which the BedDetail refers, i.e. the type of bed available in the quantity indicated by quantity.
        /// </summary>
        [DataMember(Name = "typeOfBed", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? TypeOfBed { get; set; }
    }
}
