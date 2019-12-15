﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A datasheet or vendor specification of a product (in the sense of a prototypical description).
    /// </summary>
    public partial interface IProductModel : IProduct
    {
        /// <summary>
        /// A pointer to a base product from which this product is a variant. It is safe to infer that the variant inherits all product features from the base model, unless defined locally. This is not transitive.
        /// </summary>
        OneOrMany<IProductModel> IsVariantOf { get; set; }

        /// <summary>
        /// A pointer from a previous, often discontinued variant of the product to its newer variant.
        /// </summary>
        OneOrMany<IProductModel> PredecessorOf { get; set; }

        /// <summary>
        /// A pointer from a newer variant of a product  to its previous, often discontinued predecessor.
        /// </summary>
        OneOrMany<IProductModel> SuccessorOf { get; set; }
    }

    /// <summary>
    /// A datasheet or vendor specification of a product (in the sense of a prototypical description).
    /// </summary>
    [DataContract]
    public partial class ProductModel : Product, IProductModel, IEquatable<ProductModel>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ProductModel";

        /// <summary>
        /// A pointer to a base product from which this product is a variant. It is safe to infer that the variant inherits all product features from the base model, unless defined locally. This is not transitive.
        /// </summary>
        [DataMember(Name = "isVariantOf", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IProductModel> IsVariantOf { get; set; }

        /// <summary>
        /// A pointer from a previous, often discontinued variant of the product to its newer variant.
        /// </summary>
        [DataMember(Name = "predecessorOf", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IProductModel> PredecessorOf { get; set; }

        /// <summary>
        /// A pointer from a newer variant of a product  to its previous, often discontinued predecessor.
        /// </summary>
        [DataMember(Name = "successorOf", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IProductModel> SuccessorOf { get; set; }

        /// <inheritdoc/>
        public bool Equals(ProductModel other)
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
                this.IsVariantOf == other.IsVariantOf &&
                this.PredecessorOf == other.PredecessorOf &&
                this.SuccessorOf == other.SuccessorOf &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as ProductModel);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.IsVariantOf)
            .And(this.PredecessorOf)
            .And(this.SuccessorOf)
            .And(base.GetHashCode());
    }
}
