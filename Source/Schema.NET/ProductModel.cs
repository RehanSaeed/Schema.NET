namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A datasheet or vendor specification of a product (in the sense of a prototypical description).
    /// </summary>
    [DataContract]
    public class ProductModel : Product
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ProductModel";

        /// <summary>
        /// A pointer from a previous, often discontinued variant of the product to its newer variant.
        /// </summary>
        [DataMember(Name = "predecessorOf")]
        public ProductModel PredecessorOf { get; set; }

        /// <summary>
        /// A pointer from a newer variant of a product  to its previous, often discontinued predecessor.
        /// </summary>
        [DataMember(Name = "successorOf")]
        public ProductModel SuccessorOf { get; set; }

        /// <summary>
        /// A pointer to a base product from which this product is a variant. It is safe to infer that the variant inherits all product features from the base model, unless defined locally. This is not transitive.
        /// </summary>
        [DataMember(Name = "isVariantOf")]
        public ProductModel IsVariantOf { get; set; }
    }
}
