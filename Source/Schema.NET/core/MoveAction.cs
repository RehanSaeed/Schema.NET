namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of an agent relocating to a place.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/TransferAction"&gt;TransferAction&lt;/a&gt;: Unlike TransferAction, the subject of the move is a living Person or Organization rather than an inanimate object.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class MoveAction : Action
    {
        public interface IFromLocation : IValue {}
        public interface IFromLocation<T> : IFromLocation { new T Value { get; } }
        public class OneOrManyFromLocation : OneOrMany<IFromLocation>
        {
            public OneOrManyFromLocation(IFromLocation item) : base(item) { }
            public OneOrManyFromLocation(IEnumerable<IFromLocation> items) : base(items) { }
            public static implicit operator OneOrManyFromLocation (Place value) { return new OneOrManyFromLocation (new FromLocationPlace (value)); }
            public static implicit operator OneOrManyFromLocation (Place[] values) { return new OneOrManyFromLocation (values.Select(v => (IFromLocation) new FromLocationPlace (v))); }
            public static implicit operator OneOrManyFromLocation (List<Place> values) { return new OneOrManyFromLocation (values.Select(v => (IFromLocation) new FromLocationPlace (v))); }
        }
        public struct FromLocationPlace : IFromLocation<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public FromLocationPlace (Place value) { Value = value; }
            public static implicit operator FromLocationPlace (Place value) { return new FromLocationPlace (value); }
        }

        public interface IToLocation : IValue {}
        public interface IToLocation<T> : IToLocation { new T Value { get; } }
        public class OneOrManyToLocation : OneOrMany<IToLocation>
        {
            public OneOrManyToLocation(IToLocation item) : base(item) { }
            public OneOrManyToLocation(IEnumerable<IToLocation> items) : base(items) { }
            public static implicit operator OneOrManyToLocation (Place value) { return new OneOrManyToLocation (new ToLocationPlace (value)); }
            public static implicit operator OneOrManyToLocation (Place[] values) { return new OneOrManyToLocation (values.Select(v => (IToLocation) new ToLocationPlace (v))); }
            public static implicit operator OneOrManyToLocation (List<Place> values) { return new OneOrManyToLocation (values.Select(v => (IToLocation) new ToLocationPlace (v))); }
        }
        public struct ToLocationPlace : IToLocation<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public ToLocationPlace (Place value) { Value = value; }
            public static implicit operator ToLocationPlace (Place value) { return new ToLocationPlace (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MoveAction";

        /// <summary>
        /// A sub property of location. The original location of the object or the agent before the action.
        /// </summary>
        [DataMember(Name = "fromLocation", Order = 206)]
        public OneOrManyFromLocation FromLocation { get; set; }

        /// <summary>
        /// A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        [DataMember(Name = "toLocation", Order = 207)]
        public OneOrManyToLocation ToLocation { get; set; }
    }
}
