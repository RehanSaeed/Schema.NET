namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An apartment (in American English) or flat (in British English) is a self-contained housing unit (a type of residential real estate) that occupies only part of a building (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Apartment"&gt;http://en.wikipedia.org/wiki/Apartment&lt;/a&gt;).
    /// </summary>
    [DataContract]
    public partial class Apartment : Accommodation
    {

        public interface IOccupancy : IValue {}
        public interface IOccupancy<T> : IOccupancy { new T Value { get; } }
        public class OneOrManyOccupancy : OneOrMany<IOccupancy>
        {
            public OneOrManyOccupancy(IOccupancy item) : base(item) { }
            public OneOrManyOccupancy(IEnumerable<IOccupancy> items) : base(items) { }
            public static implicit operator OneOrManyOccupancy (QuantitativeValue value) { return new OneOrManyOccupancy (new OccupancyQuantitativeValue (value)); }
            public static implicit operator OneOrManyOccupancy (QuantitativeValue[] values) { return new OneOrManyOccupancy (values.Select(v => (IOccupancy) new OccupancyQuantitativeValue (v))); }
            public static implicit operator OneOrManyOccupancy (List<QuantitativeValue> values) { return new OneOrManyOccupancy (values.Select(v => (IOccupancy) new OccupancyQuantitativeValue (v))); }
        }
        public struct OccupancyQuantitativeValue : IOccupancy<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public OccupancyQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator OccupancyQuantitativeValue (QuantitativeValue value) { return new OccupancyQuantitativeValue (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Apartment";

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the accommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        [DataMember(Name = "numberOfRooms", Order = 306)]
        public override OneOrManyNumberOfRooms NumberOfRooms { get; set; }

        /// <summary>
        /// The allowed total occupancy for the accommodation in persons (including infants etc). For individual accommodations, this is not necessarily the legal maximum but defines the permitted usage as per the contractual agreement (e.g. a double room used by a single person).
        /// Typical unit code(s): C62 for person
        /// </summary>
        [DataMember(Name = "occupancy", Order = 307)]
        public OneOrManyOccupancy Occupancy { get; set; }
    }
}
