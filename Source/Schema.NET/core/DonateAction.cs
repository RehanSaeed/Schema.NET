namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of providing goods, services, or money without compensation, often for philanthropic reasons.
    /// </summary>
    public partial interface IDonateAction : ITradeAction
    {
        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        Values<IAudience, IContactPoint, IOrganization, IPerson>? Recipient { get; set; }
    }

    /// <summary>
    /// The act of providing goods, services, or money without compensation, often for philanthropic reasons.
    /// </summary>
    [DataContract]
    public partial class DonateAction : TradeAction, IDonateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DonateAction";

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [DataMember(Name = "recipient", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAudience, IContactPoint, IOrganization, IPerson>? Recipient { get; set; }
    }
}
