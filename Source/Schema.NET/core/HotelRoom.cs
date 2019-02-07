namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A hotel room is a single room in a hotel.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class HotelRoom : Room
    {
        public interface IBed : IValue {}
        public interface IBed<T> : IBed { new T Value { get; } }
        public class OneOrManyBed : OneOrMany<IBed>
        {
            public OneOrManyBed(IBed item) : base(item) { }
            public OneOrManyBed(IEnumerable<IBed> items) : base(items) { }
            public static implicit operator OneOrManyBed (BedDetails value) { return new OneOrManyBed (new BedBedDetails (value)); }
            public static implicit operator OneOrManyBed (BedDetails[] values) { return new OneOrManyBed (values.Select(v => (IBed) new BedBedDetails (v))); }
            public static implicit operator OneOrManyBed (List<BedDetails> values) { return new OneOrManyBed (values.Select(v => (IBed) new BedBedDetails (v))); }
            public static implicit operator OneOrManyBed (string value) { return new OneOrManyBed (new Bedstring (value)); }
            public static implicit operator OneOrManyBed (string[] values) { return new OneOrManyBed (values.Select(v => (IBed) new Bedstring (v))); }
            public static implicit operator OneOrManyBed (List<string> values) { return new OneOrManyBed (values.Select(v => (IBed) new Bedstring (v))); }
        }
        public struct BedBedDetails : IBed<BedDetails>
        {
            object IValue.Value => this.Value;
            public BedDetails Value { get; }
            public BedBedDetails (BedDetails value) { Value = value; }
            public static implicit operator BedBedDetails (BedDetails value) { return new BedBedDetails (value); }
        }
        public struct Bedstring : IBed<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Bedstring (string value) { Value = value; }
            public static implicit operator Bedstring (string value) { return new Bedstring (value); }
        }

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
        public override string Type => "HotelRoom";

        /// <summary>
        /// The type of bed or beds included in the accommodation. For the single case of just one bed of a certain type, you use bed directly with a text.
        ///       If you want to indicate the quantity of a certain kind of bed, use an instance of BedDetails. For more detailed information, use the amenityFeature property.
        /// </summary>
        [DataMember(Name = "bed", Order = 406)]
        public OneOrManyBed Bed { get; set; }

        /// <summary>
        /// The allowed total occupancy for the accommodation in persons (including infants etc). For individual accommodations, this is not necessarily the legal maximum but defines the permitted usage as per the contractual agreement (e.g. a double room used by a single person).
        /// Typical unit code(s): C62 for person
        /// </summary>
        [DataMember(Name = "occupancy", Order = 407)]
        public OneOrManyOccupancy Occupancy { get; set; }
    }
}
