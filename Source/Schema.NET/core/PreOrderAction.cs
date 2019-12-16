namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An agent orders a (not yet released) object/product/service to be delivered/sent.
    /// </summary>
    public partial interface IPreOrderAction : ITradeAction
    {
    }

    /// <summary>
    /// An agent orders a (not yet released) object/product/service to be delivered/sent.
    /// </summary>
    [DataContract]
    public partial class PreOrderAction : TradeAction, IPreOrderAction, IEquatable<PreOrderAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PreOrderAction";

        /// <inheritdoc/>
        public bool Equals(PreOrderAction other)
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
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as PreOrderAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
