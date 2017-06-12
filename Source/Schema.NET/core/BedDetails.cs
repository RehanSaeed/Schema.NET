namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An entity holding detailed information about the available bed types, e...
    /// </summary>
    [DataContract]
    public class BedDetails : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BedDetails";

        /// <summary>
        /// The quantity of the given bed type available in the HotelRoom, Suite, House, or Apartment.
        /// </summary>
        [DataMember(Name = "numberOfBeds", Order = 2)]
        public int? NumberOfBeds { get; set; }

        /// <summary>
        /// The type of bed to which the BedDetail refers, i.e. the type of bed available in the quantity indicated by quantity.
        /// </summary>
        [DataMember(Name = "typeOfBed", Order = 3)]
        public string TypeOfBed { get; set; }
    }
}
