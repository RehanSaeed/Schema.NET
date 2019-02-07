namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of adding at a specific location in an ordered collection.
    /// </summary>
    [DataContract]
    public partial class InsertAction : AddAction
    {
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
        public override string Type => "InsertAction";

        /// <summary>
        /// A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        [DataMember(Name = "toLocation", Order = 406)]
        public OneOrManyToLocation ToLocation { get; set; }
    }
}
