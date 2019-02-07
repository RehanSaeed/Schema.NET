namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of ingesting information/resources/food.
    /// </summary>
    [DataContract]
    public partial class ConsumeAction : Action
    {
        public interface IExpectsAcceptanceOf : IValue {}
        public interface IExpectsAcceptanceOf<T> : IExpectsAcceptanceOf { new T Value { get; } }
        public class OneOrManyExpectsAcceptanceOf : OneOrMany<IExpectsAcceptanceOf>
        {
            public OneOrManyExpectsAcceptanceOf(IExpectsAcceptanceOf item) : base(item) { }
            public OneOrManyExpectsAcceptanceOf(IEnumerable<IExpectsAcceptanceOf> items) : base(items) { }
            public static implicit operator OneOrManyExpectsAcceptanceOf (Offer value) { return new OneOrManyExpectsAcceptanceOf (new ExpectsAcceptanceOfOffer (value)); }
            public static implicit operator OneOrManyExpectsAcceptanceOf (Offer[] values) { return new OneOrManyExpectsAcceptanceOf (values.Select(v => (IExpectsAcceptanceOf) new ExpectsAcceptanceOfOffer (v))); }
            public static implicit operator OneOrManyExpectsAcceptanceOf (List<Offer> values) { return new OneOrManyExpectsAcceptanceOf (values.Select(v => (IExpectsAcceptanceOf) new ExpectsAcceptanceOfOffer (v))); }
        }
        public struct ExpectsAcceptanceOfOffer : IExpectsAcceptanceOf<Offer>
        {
            object IValue.Value => this.Value;
            public Offer Value { get; }
            public ExpectsAcceptanceOfOffer (Offer value) { Value = value; }
            public static implicit operator ExpectsAcceptanceOfOffer (Offer value) { return new ExpectsAcceptanceOfOffer (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ConsumeAction";

        /// <summary>
        /// An Offer which must be accepted before the user can perform the Action. For example, the user may need to buy a movie before being able to watch it.
        /// </summary>
        [DataMember(Name = "expectsAcceptanceOf", Order = 206)]
        public OneOrManyExpectsAcceptanceOf ExpectsAcceptanceOf { get; set; }
    }
}
