namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A house is a building or structure that has the ability to be occupied for habitation by humans or other creatures (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/House"&gt;http://en.wikipedia.org/wiki/House&lt;/a&gt;).
    /// </summary>
    [DataContract]
    public partial class House : Accommodation
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
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<int?, QuantitativeValue>? NumberOfRooms { get; set; }
    }
}
