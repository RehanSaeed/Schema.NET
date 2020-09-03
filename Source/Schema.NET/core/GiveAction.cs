namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of transferring ownership of an object to a destination. Reciprocal of TakeAction.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/TakeAction"&gt;TakeAction&lt;/a&gt;: Reciprocal of GiveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/SendAction"&gt;SendAction&lt;/a&gt;: Unlike SendAction, GiveAction implies that ownership is being transferred (e.g. I may send my laptop to you, but that doesn't mean I'm giving it to you).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IGiveAction : ITransferAction
    {
        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        Values<IAudience, IContactPoint, IOrganization, IPerson> Recipient { get; set; }
    }

    /// <summary>
    /// The act of transferring ownership of an object to a destination. Reciprocal of TakeAction.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/TakeAction"&gt;TakeAction&lt;/a&gt;: Reciprocal of GiveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/SendAction"&gt;SendAction&lt;/a&gt;: Unlike SendAction, GiveAction implies that ownership is being transferred (e.g. I may send my laptop to you, but that doesn't mean I'm giving it to you).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class GiveAction : TransferAction, IGiveAction, IEquatable<GiveAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GiveAction";

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [DataMember(Name = "recipient", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAudience, IContactPoint, IOrganization, IPerson> Recipient { get; set; }

        /// <inheritdoc/>
        public bool Equals(GiveAction other)
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
                this.Recipient == other.Recipient &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as GiveAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Recipient)
            .And(base.GetHashCode());
    }
}
