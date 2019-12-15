﻿namespace Schema.NET
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
        Values<IAudience, IContactPoint, IOrganization, IPerson> Recipient { get; set; }
    }

    /// <summary>
    /// The act of giving money voluntarily to a beneficiary in recognition of services rendered.
    /// </summary>
    [DataContract]
    public partial class TipAction : TradeAction, ITipAction, IEquatable<TipAction>
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAudience, IContactPoint, IOrganization, IPerson> Recipient { get; set; }

        /// <inheritdoc/>
        public bool Equals(TipAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as TipAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Recipient)
            .And(base.GetHashCode());
    }
}
