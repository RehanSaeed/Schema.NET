namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of managing by changing/editing the state of the object.
    /// </summary>
    [DataContract]
    public partial class UpdateAction : Action
    {
        public interface ITargetCollection : IValue {}
        public interface ITargetCollection<T> : ITargetCollection { new T Value { get; } }
        public class OneOrManyTargetCollection : OneOrMany<ITargetCollection>
        {
            public OneOrManyTargetCollection(ITargetCollection item) : base(item) { }
            public OneOrManyTargetCollection(IEnumerable<ITargetCollection> items) : base(items) { }
            public static implicit operator OneOrManyTargetCollection (Thing value) { return new OneOrManyTargetCollection (new TargetCollectionThing (value)); }
            public static implicit operator OneOrManyTargetCollection (Thing[] values) { return new OneOrManyTargetCollection (values.Select(v => (ITargetCollection) new TargetCollectionThing (v))); }
            public static implicit operator OneOrManyTargetCollection (List<Thing> values) { return new OneOrManyTargetCollection (values.Select(v => (ITargetCollection) new TargetCollectionThing (v))); }
        }
        public struct TargetCollectionThing : ITargetCollection<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public TargetCollectionThing (Thing value) { Value = value; }
            public static implicit operator TargetCollectionThing (Thing value) { return new TargetCollectionThing (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "UpdateAction";

        /// <summary>
        /// A sub property of object. The collection target of the action.
        /// </summary>
        [DataMember(Name = "targetCollection", Order = 206)]
        public OneOrManyTargetCollection TargetCollection { get; set; }
    }
}
