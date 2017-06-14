namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of giving money in return for temporary use, but not ownership, of an object such as a vehicle or property...
    /// </summary>
    [DataContract]
    public partial class RentAction : TradeAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RentAction";

        /// <summary>
        /// A sub property of participant. The owner of the real estate property.
        /// </summary>
        [DataMember(Name = "landlord", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person, Organization>? Landlord { get; set; }

        /// <summary>
        /// A sub property of participant. The real estate agent involved in the action.
        /// </summary>
        [DataMember(Name = "realEstateAgent", Order = 3)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<RealEstateAgent>? RealEstateAgent { get; set; }
    }
}
