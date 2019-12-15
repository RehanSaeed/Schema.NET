namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An agent orders an object/product/service to be delivered/sent.
    /// </summary>
    public partial interface IOrderAction : ITradeAction
    {
        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        OneOrMany<DeliveryMethod?> DeliveryMethod { get; set; }
    }

    /// <summary>
    /// An agent orders an object/product/service to be delivered/sent.
    /// </summary>
    [DataContract]
    public partial class OrderAction : TradeAction, IOrderAction, IEquatable<OrderAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OrderAction";

        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        [DataMember(Name = "deliveryMethod", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DeliveryMethod?> DeliveryMethod { get; set; }

        /// <inheritdoc/>
        public bool Equals(OrderAction other)
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
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as OrderAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.DeliveryMethod)
            .And(base.GetHashCode());
    }
}
