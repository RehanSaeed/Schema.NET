namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of giving money in return for temporary use, but not ownership, of an object such as a vehicle or property. For example, an agent rents a property from a landlord in exchange for a periodic payment.
    /// </summary>
    public partial interface IRentAction : ITradeAction
    {
        /// <summary>
        /// A sub property of participant. The owner of the real estate property.
        /// </summary>
        Values<IOrganization, IPerson>? Landlord { get; set; }

        /// <summary>
        /// A sub property of participant. The real estate agent involved in the action.
        /// </summary>
        OneOrMany<IRealEstateAgent>? RealEstateAgent { get; set; }
    }

    /// <summary>
    /// The act of giving money in return for temporary use, but not ownership, of an object such as a vehicle or property. For example, an agent rents a property from a landlord in exchange for a periodic payment.
    /// </summary>
    [DataContract]
    public partial class RentAction : TradeAction, IRentAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RentAction";

        /// <summary>
        /// A sub property of participant. The owner of the real estate property.
        /// </summary>
        [DataMember(Name = "landlord", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IOrganization, IPerson>? Landlord { get; set; }

        /// <summary>
        /// A sub property of participant. The real estate agent involved in the action.
        /// </summary>
        [DataMember(Name = "realEstateAgent", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IRealEstateAgent>? RealEstateAgent { get; set; }
    }
}
