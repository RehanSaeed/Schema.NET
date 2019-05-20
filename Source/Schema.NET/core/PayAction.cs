namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An agent pays a price to a participant.
    /// </summary>
    public partial interface IPayAction : ITradeAction
    {
        /// <summary>
        /// A goal towards an action is taken. Can be concrete or abstract.
        /// </summary>
        Values<MedicalDevicePurpose?, IThing>? Purpose { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        Values<IAudience, IContactPoint, IOrganization, IPerson>? Recipient { get; set; }
    }

    /// <summary>
    /// An agent pays a price to a participant.
    /// </summary>
    [DataContract]
    public partial class PayAction : TradeAction, IPayAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PayAction";

        /// <summary>
        /// A goal towards an action is taken. Can be concrete or abstract.
        /// </summary>
        [DataMember(Name = "purpose", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalDevicePurpose?, IThing>? Purpose { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [DataMember(Name = "recipient", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAudience, IContactPoint, IOrganization, IPerson>? Recipient { get; set; }
    }
}
