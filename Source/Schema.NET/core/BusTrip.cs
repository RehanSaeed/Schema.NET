namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A trip on a commercial bus line.
    /// </summary>
    [DataContract]
    public partial class BusTrip : Trip
    {
        public interface IArrivalBusStop : IValue {}
        public interface IArrivalBusStop<T> : IArrivalBusStop { new T Value { get; } }
        public class OneOrManyArrivalBusStop : OneOrMany<IArrivalBusStop>
        {
            public OneOrManyArrivalBusStop(IArrivalBusStop item) : base(item) { }
            public OneOrManyArrivalBusStop(IEnumerable<IArrivalBusStop> items) : base(items) { }
            public static implicit operator OneOrManyArrivalBusStop (BusStation value) { return new OneOrManyArrivalBusStop (new ArrivalBusStopBusStation (value)); }
            public static implicit operator OneOrManyArrivalBusStop (BusStation[] values) { return new OneOrManyArrivalBusStop (values.Select(v => (IArrivalBusStop) new ArrivalBusStopBusStation (v))); }
            public static implicit operator OneOrManyArrivalBusStop (List<BusStation> values) { return new OneOrManyArrivalBusStop (values.Select(v => (IArrivalBusStop) new ArrivalBusStopBusStation (v))); }
            public static implicit operator OneOrManyArrivalBusStop (BusStop value) { return new OneOrManyArrivalBusStop (new ArrivalBusStopBusStop (value)); }
            public static implicit operator OneOrManyArrivalBusStop (BusStop[] values) { return new OneOrManyArrivalBusStop (values.Select(v => (IArrivalBusStop) new ArrivalBusStopBusStop (v))); }
            public static implicit operator OneOrManyArrivalBusStop (List<BusStop> values) { return new OneOrManyArrivalBusStop (values.Select(v => (IArrivalBusStop) new ArrivalBusStopBusStop (v))); }
        }
        public struct ArrivalBusStopBusStation : IArrivalBusStop<BusStation>
        {
            object IValue.Value => this.Value;
            public BusStation Value { get; }
            public ArrivalBusStopBusStation (BusStation value) { Value = value; }
            public static implicit operator ArrivalBusStopBusStation (BusStation value) { return new ArrivalBusStopBusStation (value); }
        }
        public struct ArrivalBusStopBusStop : IArrivalBusStop<BusStop>
        {
            object IValue.Value => this.Value;
            public BusStop Value { get; }
            public ArrivalBusStopBusStop (BusStop value) { Value = value; }
            public static implicit operator ArrivalBusStopBusStop (BusStop value) { return new ArrivalBusStopBusStop (value); }
        }

        public interface IBusName : IValue {}
        public interface IBusName<T> : IBusName { new T Value { get; } }
        public class OneOrManyBusName : OneOrMany<IBusName>
        {
            public OneOrManyBusName(IBusName item) : base(item) { }
            public OneOrManyBusName(IEnumerable<IBusName> items) : base(items) { }
            public static implicit operator OneOrManyBusName (string value) { return new OneOrManyBusName (new BusNamestring (value)); }
            public static implicit operator OneOrManyBusName (string[] values) { return new OneOrManyBusName (values.Select(v => (IBusName) new BusNamestring (v))); }
            public static implicit operator OneOrManyBusName (List<string> values) { return new OneOrManyBusName (values.Select(v => (IBusName) new BusNamestring (v))); }
        }
        public struct BusNamestring : IBusName<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public BusNamestring (string value) { Value = value; }
            public static implicit operator BusNamestring (string value) { return new BusNamestring (value); }
        }

        public interface IBusNumber : IValue {}
        public interface IBusNumber<T> : IBusNumber { new T Value { get; } }
        public class OneOrManyBusNumber : OneOrMany<IBusNumber>
        {
            public OneOrManyBusNumber(IBusNumber item) : base(item) { }
            public OneOrManyBusNumber(IEnumerable<IBusNumber> items) : base(items) { }
            public static implicit operator OneOrManyBusNumber (string value) { return new OneOrManyBusNumber (new BusNumberstring (value)); }
            public static implicit operator OneOrManyBusNumber (string[] values) { return new OneOrManyBusNumber (values.Select(v => (IBusNumber) new BusNumberstring (v))); }
            public static implicit operator OneOrManyBusNumber (List<string> values) { return new OneOrManyBusNumber (values.Select(v => (IBusNumber) new BusNumberstring (v))); }
        }
        public struct BusNumberstring : IBusNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public BusNumberstring (string value) { Value = value; }
            public static implicit operator BusNumberstring (string value) { return new BusNumberstring (value); }
        }

        public interface IDepartureBusStop : IValue {}
        public interface IDepartureBusStop<T> : IDepartureBusStop { new T Value { get; } }
        public class OneOrManyDepartureBusStop : OneOrMany<IDepartureBusStop>
        {
            public OneOrManyDepartureBusStop(IDepartureBusStop item) : base(item) { }
            public OneOrManyDepartureBusStop(IEnumerable<IDepartureBusStop> items) : base(items) { }
            public static implicit operator OneOrManyDepartureBusStop (BusStation value) { return new OneOrManyDepartureBusStop (new DepartureBusStopBusStation (value)); }
            public static implicit operator OneOrManyDepartureBusStop (BusStation[] values) { return new OneOrManyDepartureBusStop (values.Select(v => (IDepartureBusStop) new DepartureBusStopBusStation (v))); }
            public static implicit operator OneOrManyDepartureBusStop (List<BusStation> values) { return new OneOrManyDepartureBusStop (values.Select(v => (IDepartureBusStop) new DepartureBusStopBusStation (v))); }
            public static implicit operator OneOrManyDepartureBusStop (BusStop value) { return new OneOrManyDepartureBusStop (new DepartureBusStopBusStop (value)); }
            public static implicit operator OneOrManyDepartureBusStop (BusStop[] values) { return new OneOrManyDepartureBusStop (values.Select(v => (IDepartureBusStop) new DepartureBusStopBusStop (v))); }
            public static implicit operator OneOrManyDepartureBusStop (List<BusStop> values) { return new OneOrManyDepartureBusStop (values.Select(v => (IDepartureBusStop) new DepartureBusStopBusStop (v))); }
        }
        public struct DepartureBusStopBusStation : IDepartureBusStop<BusStation>
        {
            object IValue.Value => this.Value;
            public BusStation Value { get; }
            public DepartureBusStopBusStation (BusStation value) { Value = value; }
            public static implicit operator DepartureBusStopBusStation (BusStation value) { return new DepartureBusStopBusStation (value); }
        }
        public struct DepartureBusStopBusStop : IDepartureBusStop<BusStop>
        {
            object IValue.Value => this.Value;
            public BusStop Value { get; }
            public DepartureBusStopBusStop (BusStop value) { Value = value; }
            public static implicit operator DepartureBusStopBusStop (BusStop value) { return new DepartureBusStopBusStop (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BusTrip";

        /// <summary>
        /// The stop or station from which the bus arrives.
        /// </summary>
        [DataMember(Name = "arrivalBusStop", Order = 306)]
        public OneOrManyArrivalBusStop ArrivalBusStop { get; set; }

        /// <summary>
        /// The name of the bus (e.g. Bolt Express).
        /// </summary>
        [DataMember(Name = "busName", Order = 307)]
        public OneOrManyBusName BusName { get; set; }

        /// <summary>
        /// The unique identifier for the bus.
        /// </summary>
        [DataMember(Name = "busNumber", Order = 308)]
        public OneOrManyBusNumber BusNumber { get; set; }

        /// <summary>
        /// The stop or station from which the bus departs.
        /// </summary>
        [DataMember(Name = "departureBusStop", Order = 309)]
        public OneOrManyDepartureBusStop DepartureBusStop { get; set; }
    }
}
