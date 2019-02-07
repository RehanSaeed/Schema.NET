namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A datasheet or vendor specification of a product (in the sense of a prototypical description).
    /// </summary>
    [DataContract]
    public partial class ProductModel : Product
    {
        public interface IIsVariantOf : IValue {}
        public interface IIsVariantOf<T> : IIsVariantOf { new T Value { get; } }
        public class OneOrManyIsVariantOf : OneOrMany<IIsVariantOf>
        {
            public OneOrManyIsVariantOf(IIsVariantOf item) : base(item) { }
            public OneOrManyIsVariantOf(IEnumerable<IIsVariantOf> items) : base(items) { }
            public static implicit operator OneOrManyIsVariantOf (ProductModel value) { return new OneOrManyIsVariantOf (new IsVariantOfProductModel (value)); }
            public static implicit operator OneOrManyIsVariantOf (ProductModel[] values) { return new OneOrManyIsVariantOf (values.Select(v => (IIsVariantOf) new IsVariantOfProductModel (v))); }
            public static implicit operator OneOrManyIsVariantOf (List<ProductModel> values) { return new OneOrManyIsVariantOf (values.Select(v => (IIsVariantOf) new IsVariantOfProductModel (v))); }
        }
        public struct IsVariantOfProductModel : IIsVariantOf<ProductModel>
        {
            object IValue.Value => this.Value;
            public ProductModel Value { get; }
            public IsVariantOfProductModel (ProductModel value) { Value = value; }
            public static implicit operator IsVariantOfProductModel (ProductModel value) { return new IsVariantOfProductModel (value); }
        }

        public interface IPredecessorOf : IValue {}
        public interface IPredecessorOf<T> : IPredecessorOf { new T Value { get; } }
        public class OneOrManyPredecessorOf : OneOrMany<IPredecessorOf>
        {
            public OneOrManyPredecessorOf(IPredecessorOf item) : base(item) { }
            public OneOrManyPredecessorOf(IEnumerable<IPredecessorOf> items) : base(items) { }
            public static implicit operator OneOrManyPredecessorOf (ProductModel value) { return new OneOrManyPredecessorOf (new PredecessorOfProductModel (value)); }
            public static implicit operator OneOrManyPredecessorOf (ProductModel[] values) { return new OneOrManyPredecessorOf (values.Select(v => (IPredecessorOf) new PredecessorOfProductModel (v))); }
            public static implicit operator OneOrManyPredecessorOf (List<ProductModel> values) { return new OneOrManyPredecessorOf (values.Select(v => (IPredecessorOf) new PredecessorOfProductModel (v))); }
        }
        public struct PredecessorOfProductModel : IPredecessorOf<ProductModel>
        {
            object IValue.Value => this.Value;
            public ProductModel Value { get; }
            public PredecessorOfProductModel (ProductModel value) { Value = value; }
            public static implicit operator PredecessorOfProductModel (ProductModel value) { return new PredecessorOfProductModel (value); }
        }

        public interface ISuccessorOf : IValue {}
        public interface ISuccessorOf<T> : ISuccessorOf { new T Value { get; } }
        public class OneOrManySuccessorOf : OneOrMany<ISuccessorOf>
        {
            public OneOrManySuccessorOf(ISuccessorOf item) : base(item) { }
            public OneOrManySuccessorOf(IEnumerable<ISuccessorOf> items) : base(items) { }
            public static implicit operator OneOrManySuccessorOf (ProductModel value) { return new OneOrManySuccessorOf (new SuccessorOfProductModel (value)); }
            public static implicit operator OneOrManySuccessorOf (ProductModel[] values) { return new OneOrManySuccessorOf (values.Select(v => (ISuccessorOf) new SuccessorOfProductModel (v))); }
            public static implicit operator OneOrManySuccessorOf (List<ProductModel> values) { return new OneOrManySuccessorOf (values.Select(v => (ISuccessorOf) new SuccessorOfProductModel (v))); }
        }
        public struct SuccessorOfProductModel : ISuccessorOf<ProductModel>
        {
            object IValue.Value => this.Value;
            public ProductModel Value { get; }
            public SuccessorOfProductModel (ProductModel value) { Value = value; }
            public static implicit operator SuccessorOfProductModel (ProductModel value) { return new SuccessorOfProductModel (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ProductModel";

        /// <summary>
        /// A pointer to a base product from which this product is a variant. It is safe to infer that the variant inherits all product features from the base model, unless defined locally. This is not transitive.
        /// </summary>
        [DataMember(Name = "isVariantOf", Order = 206)]
        public OneOrManyIsVariantOf IsVariantOf { get; set; }

        /// <summary>
        /// A pointer from a previous, often discontinued variant of the product to its newer variant.
        /// </summary>
        [DataMember(Name = "predecessorOf", Order = 207)]
        public OneOrManyPredecessorOf PredecessorOf { get; set; }

        /// <summary>
        /// A pointer from a newer variant of a product  to its previous, often discontinued predecessor.
        /// </summary>
        [DataMember(Name = "successorOf", Order = 208)]
        public OneOrManySuccessorOf SuccessorOf { get; set; }
    }
}
