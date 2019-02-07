namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An order item is a line of an order. It includes the quantity and shipping details of a bought offer.
    /// </summary>
    [DataContract]
    public partial class OrderItem : Intangible
    {
        public interface IOrderDelivery : IValue {}
        public interface IOrderDelivery<T> : IOrderDelivery { new T Value { get; } }
        public class OneOrManyOrderDelivery : OneOrMany<IOrderDelivery>
        {
            public OneOrManyOrderDelivery(IOrderDelivery item) : base(item) { }
            public OneOrManyOrderDelivery(IEnumerable<IOrderDelivery> items) : base(items) { }
            public static implicit operator OneOrManyOrderDelivery (ParcelDelivery value) { return new OneOrManyOrderDelivery (new OrderDeliveryParcelDelivery (value)); }
            public static implicit operator OneOrManyOrderDelivery (ParcelDelivery[] values) { return new OneOrManyOrderDelivery (values.Select(v => (IOrderDelivery) new OrderDeliveryParcelDelivery (v))); }
            public static implicit operator OneOrManyOrderDelivery (List<ParcelDelivery> values) { return new OneOrManyOrderDelivery (values.Select(v => (IOrderDelivery) new OrderDeliveryParcelDelivery (v))); }
        }
        public struct OrderDeliveryParcelDelivery : IOrderDelivery<ParcelDelivery>
        {
            object IValue.Value => this.Value;
            public ParcelDelivery Value { get; }
            public OrderDeliveryParcelDelivery (ParcelDelivery value) { Value = value; }
            public static implicit operator OrderDeliveryParcelDelivery (ParcelDelivery value) { return new OrderDeliveryParcelDelivery (value); }
        }

        public interface IOrderedItem : IValue {}
        public interface IOrderedItem<T> : IOrderedItem { new T Value { get; } }
        public class OneOrManyOrderedItem : OneOrMany<IOrderedItem>
        {
            public OneOrManyOrderedItem(IOrderedItem item) : base(item) { }
            public OneOrManyOrderedItem(IEnumerable<IOrderedItem> items) : base(items) { }
            public static implicit operator OneOrManyOrderedItem (OrderItem value) { return new OneOrManyOrderedItem (new OrderedItemOrderItem (value)); }
            public static implicit operator OneOrManyOrderedItem (OrderItem[] values) { return new OneOrManyOrderedItem (values.Select(v => (IOrderedItem) new OrderedItemOrderItem (v))); }
            public static implicit operator OneOrManyOrderedItem (List<OrderItem> values) { return new OneOrManyOrderedItem (values.Select(v => (IOrderedItem) new OrderedItemOrderItem (v))); }
            public static implicit operator OneOrManyOrderedItem (Product value) { return new OneOrManyOrderedItem (new OrderedItemProduct (value)); }
            public static implicit operator OneOrManyOrderedItem (Product[] values) { return new OneOrManyOrderedItem (values.Select(v => (IOrderedItem) new OrderedItemProduct (v))); }
            public static implicit operator OneOrManyOrderedItem (List<Product> values) { return new OneOrManyOrderedItem (values.Select(v => (IOrderedItem) new OrderedItemProduct (v))); }
        }
        public struct OrderedItemOrderItem : IOrderedItem<OrderItem>
        {
            object IValue.Value => this.Value;
            public OrderItem Value { get; }
            public OrderedItemOrderItem (OrderItem value) { Value = value; }
            public static implicit operator OrderedItemOrderItem (OrderItem value) { return new OrderedItemOrderItem (value); }
        }
        public struct OrderedItemProduct : IOrderedItem<Product>
        {
            object IValue.Value => this.Value;
            public Product Value { get; }
            public OrderedItemProduct (Product value) { Value = value; }
            public static implicit operator OrderedItemProduct (Product value) { return new OrderedItemProduct (value); }
        }

        public interface IOrderItemNumber : IValue {}
        public interface IOrderItemNumber<T> : IOrderItemNumber { new T Value { get; } }
        public class OneOrManyOrderItemNumber : OneOrMany<IOrderItemNumber>
        {
            public OneOrManyOrderItemNumber(IOrderItemNumber item) : base(item) { }
            public OneOrManyOrderItemNumber(IEnumerable<IOrderItemNumber> items) : base(items) { }
            public static implicit operator OneOrManyOrderItemNumber (string value) { return new OneOrManyOrderItemNumber (new OrderItemNumberstring (value)); }
            public static implicit operator OneOrManyOrderItemNumber (string[] values) { return new OneOrManyOrderItemNumber (values.Select(v => (IOrderItemNumber) new OrderItemNumberstring (v))); }
            public static implicit operator OneOrManyOrderItemNumber (List<string> values) { return new OneOrManyOrderItemNumber (values.Select(v => (IOrderItemNumber) new OrderItemNumberstring (v))); }
        }
        public struct OrderItemNumberstring : IOrderItemNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public OrderItemNumberstring (string value) { Value = value; }
            public static implicit operator OrderItemNumberstring (string value) { return new OrderItemNumberstring (value); }
        }

        public interface IOrderItemStatus : IValue {}
        public interface IOrderItemStatus<T> : IOrderItemStatus { new T Value { get; } }
        public class OneOrManyOrderItemStatus : OneOrMany<IOrderItemStatus>
        {
            public OneOrManyOrderItemStatus(IOrderItemStatus item) : base(item) { }
            public OneOrManyOrderItemStatus(IEnumerable<IOrderItemStatus> items) : base(items) { }
            public static implicit operator OneOrManyOrderItemStatus (OrderStatus value) { return new OneOrManyOrderItemStatus (new OrderItemStatusOrderStatus (value)); }
            public static implicit operator OneOrManyOrderItemStatus (OrderStatus[] values) { return new OneOrManyOrderItemStatus (values.Select(v => (IOrderItemStatus) new OrderItemStatusOrderStatus (v))); }
            public static implicit operator OneOrManyOrderItemStatus (List<OrderStatus> values) { return new OneOrManyOrderItemStatus (values.Select(v => (IOrderItemStatus) new OrderItemStatusOrderStatus (v))); }
        }
        public struct OrderItemStatusOrderStatus : IOrderItemStatus<OrderStatus>
        {
            object IValue.Value => this.Value;
            public OrderStatus Value { get; }
            public OrderItemStatusOrderStatus (OrderStatus value) { Value = value; }
            public static implicit operator OrderItemStatusOrderStatus (OrderStatus value) { return new OrderItemStatusOrderStatus (value); }
        }

        public interface IOrderQuantity : IValue {}
        public interface IOrderQuantity<T> : IOrderQuantity { new T Value { get; } }
        public class OneOrManyOrderQuantity : OneOrMany<IOrderQuantity>
        {
            public OneOrManyOrderQuantity(IOrderQuantity item) : base(item) { }
            public OneOrManyOrderQuantity(IEnumerable<IOrderQuantity> items) : base(items) { }
            public static implicit operator OneOrManyOrderQuantity (double value) { return new OneOrManyOrderQuantity (new OrderQuantitydouble (value)); }
            public static implicit operator OneOrManyOrderQuantity (double[] values) { return new OneOrManyOrderQuantity (values.Select(v => (IOrderQuantity) new OrderQuantitydouble (v))); }
            public static implicit operator OneOrManyOrderQuantity (List<double> values) { return new OneOrManyOrderQuantity (values.Select(v => (IOrderQuantity) new OrderQuantitydouble (v))); }
        }
        public struct OrderQuantitydouble : IOrderQuantity<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public OrderQuantitydouble (double value) { Value = value; }
            public static implicit operator OrderQuantitydouble (double value) { return new OrderQuantitydouble (value); }
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
        public OneOrManyOrderDelivery OrderDelivery { get; set; }

        /// <summary>
        /// The item ordered.
        /// </summary>
        [DataMember(Name = "orderedItem", Order = 207)]
        public OneOrManyOrderedItem OrderedItem { get; set; }

        /// <summary>
        /// The identifier of the order item.
        /// </summary>
        [DataMember(Name = "orderItemNumber", Order = 208)]
        public OneOrManyOrderItemNumber OrderItemNumber { get; set; }

        /// <summary>
        /// The current status of the order item.
        /// </summary>
        [DataMember(Name = "orderItemStatus", Order = 209)]
        public OneOrManyOrderItemStatus OrderItemStatus { get; set; }

        /// <summary>
        /// The number of the item ordered. If the property is not set, assume the quantity is one.
        /// </summary>
        [DataMember(Name = "orderQuantity", Order = 210)]
        public OneOrManyOrderQuantity OrderQuantity { get; set; }
    }
}
