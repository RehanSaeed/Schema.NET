namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An order item is a line of an order. It includes the quantity and shipping details of a bought offer.
    /// </summary>
    [DataContract]
    public class OrderItem : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OrderItem";

        /// <summary>
        /// The delivery of the parcel related to this order or order item.
        /// </summary>
        [DataMember(Name = "orderDelivery", Order = 2)]
        public ParcelDelivery OrderDelivery { get; set; }

        /// <summary>
        /// The item ordered.
        /// </summary>
        [DataMember(Name = "orderedItem", Order = 3)]
        public object OrderedItem { get; protected set; }

        /// <summary>
        /// The item ordered.
        /// </summary>
        [IgnoreDataMember]
        public OrderItem OrderedItemOrderItem
        {
            get => this.OrderedItem as OrderItem;
            set => this.OrderedItem = value;
        }

        /// <summary>
        /// The item ordered.
        /// </summary>
        [IgnoreDataMember]
        public Product OrderedItemProduct
        {
            get => this.OrderedItem as Product;
            set => this.OrderedItem = value;
        }

        /// <summary>
        /// The identifier of the order item.
        /// </summary>
        [DataMember(Name = "orderItemNumber", Order = 4)]
        public string OrderItemNumber { get; set; }

        /// <summary>
        /// The current status of the order item.
        /// </summary>
        [DataMember(Name = "orderItemStatus", Order = 5)]
        public OrderStatus OrderItemStatus { get; set; }

        /// <summary>
        /// The number of the item ordered. If the property is not set, assume the quantity is one.
        /// </summary>
        [DataMember(Name = "orderQuantity", Order = 6)]
        public double? OrderQuantity { get; set; }
    }
}
