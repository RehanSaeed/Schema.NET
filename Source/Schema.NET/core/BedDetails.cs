namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An entity holding detailed information about the available bed types, e...
    /// </summary>
    [DataContract]
    public partial class BedDetails : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BedDetails";

        /// <summary>
        /// The quantity of the given bed type available in the HotelRoom, Suite, House, or Apartment.
        /// </summary>
        [DataMember(Name = "numberOfBeds", Order = 205)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?>? NumberOfBeds { get; set; }

        /// <summary>
        /// The type of bed to which the BedDetail refers, i.e. the type of bed available in the quantity indicated by quantity.
        /// </summary>
        [DataMember(Name = "typeOfBed", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? TypeOfBed { get; set; }
    }
}
