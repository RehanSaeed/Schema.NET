namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of editing a recipient by replacing an old object with a new object.
    /// </summary>
    [DataContract]
    public partial class ReplaceAction : UpdateAction
    {
        public interface IReplacee : IValue {}
        public interface IReplacee<T> : IReplacee { new T Value { get; } }
        public class OneOrManyReplacee : OneOrMany<IReplacee>
        {
            public OneOrManyReplacee(IReplacee item) : base(item) { }
            public OneOrManyReplacee(IEnumerable<IReplacee> items) : base(items) { }
            public static implicit operator OneOrManyReplacee (Thing value) { return new OneOrManyReplacee (new ReplaceeThing (value)); }
            public static implicit operator OneOrManyReplacee (Thing[] values) { return new OneOrManyReplacee (values.Select(v => (IReplacee) new ReplaceeThing (v))); }
            public static implicit operator OneOrManyReplacee (List<Thing> values) { return new OneOrManyReplacee (values.Select(v => (IReplacee) new ReplaceeThing (v))); }
        }
        public struct ReplaceeThing : IReplacee<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public ReplaceeThing (Thing value) { Value = value; }
            public static implicit operator ReplaceeThing (Thing value) { return new ReplaceeThing (value); }
        }

        public interface IReplacer : IValue {}
        public interface IReplacer<T> : IReplacer { new T Value { get; } }
        public class OneOrManyReplacer : OneOrMany<IReplacer>
        {
            public OneOrManyReplacer(IReplacer item) : base(item) { }
            public OneOrManyReplacer(IEnumerable<IReplacer> items) : base(items) { }
            public static implicit operator OneOrManyReplacer (Thing value) { return new OneOrManyReplacer (new ReplacerThing (value)); }
            public static implicit operator OneOrManyReplacer (Thing[] values) { return new OneOrManyReplacer (values.Select(v => (IReplacer) new ReplacerThing (v))); }
            public static implicit operator OneOrManyReplacer (List<Thing> values) { return new OneOrManyReplacer (values.Select(v => (IReplacer) new ReplacerThing (v))); }
        }
        public struct ReplacerThing : IReplacer<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public ReplacerThing (Thing value) { Value = value; }
            public static implicit operator ReplacerThing (Thing value) { return new ReplacerThing (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReplaceAction";

        /// <summary>
        /// A sub property of object. The object that is being replaced.
        /// </summary>
        [DataMember(Name = "replacee", Order = 306)]
        public OneOrManyReplacee Replacee { get; set; }

        /// <summary>
        /// A sub property of object. The object that replaces.
        /// </summary>
        [DataMember(Name = "replacer", Order = 307)]
        public OneOrManyReplacer Replacer { get; set; }
    }
}
