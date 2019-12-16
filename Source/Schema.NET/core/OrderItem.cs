namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An order item is a line of an order. It includes the quantity and shipping details of a bought offer.
    /// </summary>
    public partial interface IOrderItem : IIntangible
    {
        /// <summary>
        /// The delivery of the parcel related to this order or order item.
        /// </summary>
        OneOrMany<IParcelDelivery> OrderDelivery { get; set; }

        /// <summary>
        /// The item ordered.
        /// </summary>
        Values<IOrderItem, IProduct, IService> OrderedItem { get; set; }

        /// <summary>
        /// The identifier of the order item.
        /// </summary>
        OneOrMany<string> OrderItemNumber { get; set; }

        /// <summary>
        /// The current status of the order item.
        /// </summary>
        OneOrMany<OrderStatus?> OrderItemStatus { get; set; }

        /// <summary>
        /// The number of the item ordered. If the property is not set, assume the quantity is one.
        /// </summary>
        OneOrMany<double?> OrderQuantity { get; set; }
    }

    /// <summary>
    /// An order item is a line of an order. It includes the quantity and shipping details of a bought offer.
    /// </summary>
    [DataContract]
    public partial class OrderItem : Intangible, IOrderItem, IEquatable<OrderItem>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OrderItem";

        /// <summary>
        /// The delivery of the parcel related to this order or order item.
        /// </summary>
        [DataMember(Name = "orderDelivery", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IParcelDelivery> OrderDelivery { get; set; }

        /// <summary>
        /// The item ordered.
        /// </summary>
        [DataMember(Name = "orderedItem", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrderItem, IProduct, IService> OrderedItem { get; set; }

        /// <summary>
        /// The identifier of the order item.
        /// </summary>
        [DataMember(Name = "orderItemNumber", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> OrderItemNumber { get; set; }

        /// <summary>
        /// The current status of the order item.
        /// </summary>
        [DataMember(Name = "orderItemStatus", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<OrderStatus?> OrderItemStatus { get; set; }

        /// <summary>
        /// The number of the item ordered. If the property is not set, assume the quantity is one.
        /// </summary>
        [DataMember(Name = "orderQuantity", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> OrderQuantity { get; set; }

        /// <inheritdoc/>
        public bool Equals(OrderItem other)
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
                this.OrderDelivery == other.OrderDelivery &&
                this.OrderedItem == other.OrderedItem &&
                this.OrderItemNumber == other.OrderItemNumber &&
                this.OrderItemStatus == other.OrderItemStatus &&
                this.OrderQuantity == other.OrderQuantity &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as OrderItem);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.OrderDelivery)
            .And(this.OrderedItem)
            .And(this.OrderItemNumber)
            .And(this.OrderItemStatus)
            .And(this.OrderQuantity)
            .And(base.GetHashCode());
    }
}
