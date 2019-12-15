﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A placeholder for multiple similar products of the same kind.
    /// </summary>
    public partial interface ISomeProducts : IProduct
    {
        /// <summary>
        /// The current approximate inventory level for the item or items.
        /// </summary>
        OneOrMany<IQuantitativeValue> InventoryLevel { get; set; }
    }

    /// <summary>
    /// A placeholder for multiple similar products of the same kind.
    /// </summary>
    [DataContract]
    public partial class SomeProducts : Product, ISomeProducts, IEquatable<SomeProducts>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SomeProducts";

        /// <summary>
        /// The current approximate inventory level for the item or items.
        /// </summary>
        [DataMember(Name = "inventoryLevel", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> InventoryLevel { get; set; }

        /// <inheritdoc/>
        public bool Equals(SomeProducts other)
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
                this.InventoryLevel == other.InventoryLevel &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as SomeProducts);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.InventoryLevel)
            .And(base.GetHashCode());
    }
}
