namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of traveling from an fromLocation to a destination by a specified mode of transport, optionally with participants.
    /// </summary>
    [DataContract]
    public partial class TravelAction : MoveAction
    {
        public interface IDistance : IValue {}
        public interface IDistance<T> : IDistance { new T Value { get; } }
        public class OneOrManyDistance : OneOrMany<IDistance>
        {
            public OneOrManyDistance(IDistance item) : base(item) { }
            public OneOrManyDistance(IEnumerable<IDistance> items) : base(items) { }
            public static implicit operator OneOrManyDistance (string value) { return new OneOrManyDistance (new Distancestring (value)); }
            public static implicit operator OneOrManyDistance (string[] values) { return new OneOrManyDistance (values.Select(v => (IDistance) new Distancestring (v))); }
            public static implicit operator OneOrManyDistance (List<string> values) { return new OneOrManyDistance (values.Select(v => (IDistance) new Distancestring (v))); }
        }
        public struct Distancestring : IDistance<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Distancestring (string value) { Value = value; }
            public static implicit operator Distancestring (string value) { return new Distancestring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TravelAction";

        /// <summary>
        /// The distance travelled, e.g. exercising or travelling.
        /// </summary>
        [DataMember(Name = "distance", Order = 306)]
        public OneOrManyDistance Distance { get; set; }
    }
}
