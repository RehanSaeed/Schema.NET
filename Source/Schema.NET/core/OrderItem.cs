using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// An order item is a line of an order. It includes the quantity and shipping details of a bought offer.
    /// </summary>
    [DataContract]
    public partial class OrderItem : Intangible
    {
        public interface IOrderedItem : IWrapper { }
        public interface IOrderedItem<T> : IOrderedItem { new T Data { get; set; } }
        public class OrderedItemOrderItem : IOrderedItem<OrderItem>
        {
            object IWrapper.Data { get { return Data; } set { Data = (OrderItem) value; } }
            public virtual OrderItem Data { get; set; }
            public OrderedItemOrderItem () { }
            public OrderedItemOrderItem (OrderItem data) { Data = data; }
            public static implicit operator OrderedItemOrderItem (OrderItem data) { return new OrderedItemOrderItem (data); }
        }

        public class OrderedItemProduct : IOrderedItem<Product>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Product) value; } }
            public virtual Product Data { get; set; }
            public OrderedItemProduct () { }
            public OrderedItemProduct (Product data) { Data = data; }
            public static implicit operator OrderedItemProduct (Product data) { return new OrderedItemProduct (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OrderItem";

        /// <summary>
        /// The delivery of the parcel related to this order or order item.
        /// </summary>
        [DataMember(Name = "orderDelivery", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ParcelDelivery>? OrderDelivery { get; set; } 

        /// <summary>
        /// The item ordered.
        /// </summary>
        [DataMember(Name = "orderedItem", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IOrderedItem>? OrderedItem { get; set; } //OrderItem, Product

        /// <summary>
        /// The identifier of the order item.
        /// </summary>
        [DataMember(Name = "orderItemNumber", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? OrderItemNumber { get; set; } 

        /// <summary>
        /// The current status of the order item.
        /// </summary>
        [DataMember(Name = "orderItemStatus", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<OrderStatus>? OrderItemStatus { get; set; } 

        /// <summary>
        /// The number of the item ordered. If the property is not set, assume the quantity is one.
        /// </summary>
        [DataMember(Name = "orderQuantity", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<double>? OrderQuantity { get; set; } 
    }
}
