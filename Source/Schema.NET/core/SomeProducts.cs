namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A placeholder for multiple similar products of the same kind.
    /// </summary>
    [DataContract]
    public partial class SomeProducts : Product
    {
        public interface IInventoryLevel : IValue {}
        public interface IInventoryLevel<T> : IInventoryLevel { new T Value { get; } }
        public class OneOrManyInventoryLevel : OneOrMany<IInventoryLevel>
        {
            public OneOrManyInventoryLevel(IInventoryLevel item) : base(item) { }
            public OneOrManyInventoryLevel(IEnumerable<IInventoryLevel> items) : base(items) { }
            public static implicit operator OneOrManyInventoryLevel (QuantitativeValue value) { return new OneOrManyInventoryLevel (new InventoryLevelQuantitativeValue (value)); }
            public static implicit operator OneOrManyInventoryLevel (QuantitativeValue[] values) { return new OneOrManyInventoryLevel (values.Select(v => (IInventoryLevel) new InventoryLevelQuantitativeValue (v))); }
            public static implicit operator OneOrManyInventoryLevel (List<QuantitativeValue> values) { return new OneOrManyInventoryLevel (values.Select(v => (IInventoryLevel) new InventoryLevelQuantitativeValue (v))); }
        }
        public struct InventoryLevelQuantitativeValue : IInventoryLevel<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public InventoryLevelQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator InventoryLevelQuantitativeValue (QuantitativeValue value) { return new InventoryLevelQuantitativeValue (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SomeProducts";

        /// <summary>
        /// The current approximate inventory level for the item or items.
        /// </summary>
        [DataMember(Name = "inventoryLevel", Order = 206)]
        public OneOrManyInventoryLevel InventoryLevel { get; set; }
    }
}
