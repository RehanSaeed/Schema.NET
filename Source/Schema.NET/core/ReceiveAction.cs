namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of physically/electronically taking delivery of an object thathas been transferred from an origin to a destination. Reciprocal of SendAction.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/SendAction"&gt;SendAction&lt;/a&gt;: The reciprocal of ReceiveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/TakeAction"&gt;TakeAction&lt;/a&gt;: Unlike TakeAction, ReceiveAction does not imply that the ownership has been transfered (e.g. I can receive a package, but it does not mean the package is now mine).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IReceiveAction : ITransferAction
    {
        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        OneOrMany<DeliveryMethod?> DeliveryMethod { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the sending end of the action.
        /// </summary>
        Values<IAudience, IOrganization, IPerson> Sender { get; set; }
    }

    /// <summary>
    /// The act of physically/electronically taking delivery of an object thathas been transferred from an origin to a destination. Reciprocal of SendAction.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/SendAction"&gt;SendAction&lt;/a&gt;: The reciprocal of ReceiveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/TakeAction"&gt;TakeAction&lt;/a&gt;: Unlike TakeAction, ReceiveAction does not imply that the ownership has been transfered (e.g. I can receive a package, but it does not mean the package is now mine).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class ReceiveAction : TransferAction, IReceiveAction, IEquatable<ReceiveAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReceiveAction";

        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        [DataMember(Name = "deliveryMethod", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DeliveryMethod?> DeliveryMethod { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the sending end of the action.
        /// </summary>
        [DataMember(Name = "sender", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAudience, IOrganization, IPerson> Sender { get; set; }

        /// <inheritdoc/>
        public bool Equals(ReceiveAction other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.DeliveryMethod == other.DeliveryMethod &&
                this.Sender == other.Sender &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as ReceiveAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.DeliveryMethod)
            .And(this.Sender)
            .And(base.GetHashCode());
    }
}
