namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of giving money voluntarily to a beneficiary in recognition of services rendered.
    /// </summary>
    public partial interface ITipAction : ITradeAction
    {
        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        Values<IAudience, IContactPoint, IOrganization, IPerson>? Recipient { get; set; }
    }

    /// <summary>
    /// The act of giving money voluntarily to a beneficiary in recognition of services rendered.
    /// </summary>
    [DataContract]
    public partial class TipAction : TradeAction, ITipAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TipAction";

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [DataMember(Name = "recipient", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAudience, IContactPoint, IOrganization, IPerson>? Recipient { get; set; }
    }
}
