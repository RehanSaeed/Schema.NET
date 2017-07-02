namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A datasheet or vendor specification of a product (in the sense of a prototypical description).
    /// </summary>
    [DataContract]
    public partial class ProductModel : Product
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ProductModel>? IsVariantOf { get; set; }

        /// <summary>
        /// A pointer from a previous, often discontinued variant of the product to its newer variant.
        /// </summary>
        [DataMember(Name = "predecessorOf", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ProductModel>? PredecessorOf { get; set; }

        /// <summary>
        /// A pointer from a newer variant of a product  to its previous, often discontinued predecessor.
        /// </summary>
        [DataMember(Name = "successorOf", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ProductModel>? SuccessorOf { get; set; }
    }
}
