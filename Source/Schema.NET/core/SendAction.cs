namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of physically/electronically dispatching an object for transfer from an origin to a destination.Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReceiveAction"&gt;ReceiveAction&lt;/a&gt;: The reciprocal of SendAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/GiveAction"&gt;GiveAction&lt;/a&gt;: Unlike GiveAction, SendAction does not imply the transfer of ownership (e.g. I can send you my laptop, but I'm not necessarily giving it to you).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface ISendAction : ITransferAction
    {
        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        OneOrMany<DeliveryMethod?> DeliveryMethod { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        Values<IAudience, IContactPoint, IOrganization, IPerson> Recipient { get; set; }
    }

    /// <summary>
    /// The act of physically/electronically dispatching an object for transfer from an origin to a destination.Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReceiveAction"&gt;ReceiveAction&lt;/a&gt;: The reciprocal of SendAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/GiveAction"&gt;GiveAction&lt;/a&gt;: Unlike GiveAction, SendAction does not imply the transfer of ownership (e.g. I can send you my laptop, but I'm not necessarily giving it to you).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class SendAction : TransferAction, ISendAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SendAction";

        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        [DataMember(Name = "deliveryMethod", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DeliveryMethod?> DeliveryMethod { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [DataMember(Name = "recipient", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAudience, IContactPoint, IOrganization, IPerson> Recipient { get; set; }
    }
}
