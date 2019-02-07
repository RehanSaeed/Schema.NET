namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A trip on a commercial train line.
    /// </summary>
    [DataContract]
    public partial class TrainTrip : Trip
    {
        public interface IArrivalPlatform : IValue {}
        public interface IArrivalPlatform<T> : IArrivalPlatform { new T Value { get; } }
        public class OneOrManyArrivalPlatform : OneOrMany<IArrivalPlatform>
        {
            public OneOrManyArrivalPlatform(IArrivalPlatform item) : base(item) { }
            public OneOrManyArrivalPlatform(IEnumerable<IArrivalPlatform> items) : base(items) { }
            public static implicit operator OneOrManyArrivalPlatform (string value) { return new OneOrManyArrivalPlatform (new ArrivalPlatformstring (value)); }
            public static implicit operator OneOrManyArrivalPlatform (string[] values) { return new OneOrManyArrivalPlatform (values.Select(v => (IArrivalPlatform) new ArrivalPlatformstring (v))); }
            public static implicit operator OneOrManyArrivalPlatform (List<string> values) { return new OneOrManyArrivalPlatform (values.Select(v => (IArrivalPlatform) new ArrivalPlatformstring (v))); }
        }
        public struct ArrivalPlatformstring : IArrivalPlatform<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ArrivalPlatformstring (string value) { Value = value; }
            public static implicit operator ArrivalPlatformstring (string value) { return new ArrivalPlatformstring (value); }
        }

        public interface IArrivalStation : IValue {}
        public interface IArrivalStation<T> : IArrivalStation { new T Value { get; } }
        public class OneOrManyArrivalStation : OneOrMany<IArrivalStation>
        {
            public OneOrManyArrivalStation(IArrivalStation item) : base(item) { }
            public OneOrManyArrivalStation(IEnumerable<IArrivalStation> items) : base(items) { }
            public static implicit operator OneOrManyArrivalStation (TrainStation value) { return new OneOrManyArrivalStation (new ArrivalStationTrainStation (value)); }
            public static implicit operator OneOrManyArrivalStation (TrainStation[] values) { return new OneOrManyArrivalStation (values.Select(v => (IArrivalStation) new ArrivalStationTrainStation (v))); }
            public static implicit operator OneOrManyArrivalStation (List<TrainStation> values) { return new OneOrManyArrivalStation (values.Select(v => (IArrivalStation) new ArrivalStationTrainStation (v))); }
        }
        public struct ArrivalStationTrainStation : IArrivalStation<TrainStation>
        {
            object IValue.Value => this.Value;
            public TrainStation Value { get; }
            public ArrivalStationTrainStation (TrainStation value) { Value = value; }
            public static implicit operator ArrivalStationTrainStation (TrainStation value) { return new ArrivalStationTrainStation (value); }
        }

        public interface IDeparturePlatform : IValue {}
        public interface IDeparturePlatform<T> : IDeparturePlatform { new T Value { get; } }
        public class OneOrManyDeparturePlatform : OneOrMany<IDeparturePlatform>
        {
            public OneOrManyDeparturePlatform(IDeparturePlatform item) : base(item) { }
            public OneOrManyDeparturePlatform(IEnumerable<IDeparturePlatform> items) : base(items) { }
            public static implicit operator OneOrManyDeparturePlatform (string value) { return new OneOrManyDeparturePlatform (new DeparturePlatformstring (value)); }
            public static implicit operator OneOrManyDeparturePlatform (string[] values) { return new OneOrManyDeparturePlatform (values.Select(v => (IDeparturePlatform) new DeparturePlatformstring (v))); }
            public static implicit operator OneOrManyDeparturePlatform (List<string> values) { return new OneOrManyDeparturePlatform (values.Select(v => (IDeparturePlatform) new DeparturePlatformstring (v))); }
        }
        public struct DeparturePlatformstring : IDeparturePlatform<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public DeparturePlatformstring (string value) { Value = value; }
            public static implicit operator DeparturePlatformstring (string value) { return new DeparturePlatformstring (value); }
        }

        public interface IDepartureStation : IValue {}
        public interface IDepartureStation<T> : IDepartureStation { new T Value { get; } }
        public class OneOrManyDepartureStation : OneOrMany<IDepartureStation>
        {
            public OneOrManyDepartureStation(IDepartureStation item) : base(item) { }
            public OneOrManyDepartureStation(IEnumerable<IDepartureStation> items) : base(items) { }
            public static implicit operator OneOrManyDepartureStation (TrainStation value) { return new OneOrManyDepartureStation (new DepartureStationTrainStation (value)); }
            public static implicit operator OneOrManyDepartureStation (TrainStation[] values) { return new OneOrManyDepartureStation (values.Select(v => (IDepartureStation) new DepartureStationTrainStation (v))); }
            public static implicit operator OneOrManyDepartureStation (List<TrainStation> values) { return new OneOrManyDepartureStation (values.Select(v => (IDepartureStation) new DepartureStationTrainStation (v))); }
        }
        public struct DepartureStationTrainStation : IDepartureStation<TrainStation>
        {
            object IValue.Value => this.Value;
            public TrainStation Value { get; }
            public DepartureStationTrainStation (TrainStation value) { Value = value; }
            public static implicit operator DepartureStationTrainStation (TrainStation value) { return new DepartureStationTrainStation (value); }
        }

        public interface ITrainName : IValue {}
        public interface ITrainName<T> : ITrainName { new T Value { get; } }
        public class OneOrManyTrainName : OneOrMany<ITrainName>
        {
            public OneOrManyTrainName(ITrainName item) : base(item) { }
            public OneOrManyTrainName(IEnumerable<ITrainName> items) : base(items) { }
            public static implicit operator OneOrManyTrainName (string value) { return new OneOrManyTrainName (new TrainNamestring (value)); }
            public static implicit operator OneOrManyTrainName (string[] values) { return new OneOrManyTrainName (values.Select(v => (ITrainName) new TrainNamestring (v))); }
            public static implicit operator OneOrManyTrainName (List<string> values) { return new OneOrManyTrainName (values.Select(v => (ITrainName) new TrainNamestring (v))); }
        }
        public struct TrainNamestring : ITrainName<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public TrainNamestring (string value) { Value = value; }
            public static implicit operator TrainNamestring (string value) { return new TrainNamestring (value); }
        }

        public interface ITrainNumber : IValue {}
        public interface ITrainNumber<T> : ITrainNumber { new T Value { get; } }
        public class OneOrManyTrainNumber : OneOrMany<ITrainNumber>
        {
            public OneOrManyTrainNumber(ITrainNumber item) : base(item) { }
            public OneOrManyTrainNumber(IEnumerable<ITrainNumber> items) : base(items) { }
            public static implicit operator OneOrManyTrainNumber (string value) { return new OneOrManyTrainNumber (new TrainNumberstring (value)); }
            public static implicit operator OneOrManyTrainNumber (string[] values) { return new OneOrManyTrainNumber (values.Select(v => (ITrainNumber) new TrainNumberstring (v))); }
            public static implicit operator OneOrManyTrainNumber (List<string> values) { return new OneOrManyTrainNumber (values.Select(v => (ITrainNumber) new TrainNumberstring (v))); }
        }
        public struct TrainNumberstring : ITrainNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public TrainNumberstring (string value) { Value = value; }
            public static implicit operator TrainNumberstring (string value) { return new TrainNumberstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TrainTrip";

        /// <summary>
        /// The platform where the train arrives.
        /// </summary>
        [DataMember(Name = "arrivalPlatform", Order = 306)]
        public OneOrManyArrivalPlatform ArrivalPlatform { get; set; }

        /// <summary>
        /// The station where the train trip ends.
        /// </summary>
        [DataMember(Name = "arrivalStation", Order = 307)]
        public OneOrManyArrivalStation ArrivalStation { get; set; }

        /// <summary>
        /// The platform from which the train departs.
        /// </summary>
        [DataMember(Name = "departurePlatform", Order = 308)]
        public OneOrManyDeparturePlatform DeparturePlatform { get; set; }

        /// <summary>
        /// The station from which the train departs.
        /// </summary>
        [DataMember(Name = "departureStation", Order = 309)]
        public OneOrManyDepartureStation DepartureStation { get; set; }

        /// <summary>
        /// The name of the train (e.g. The Orient Express).
        /// </summary>
        [DataMember(Name = "trainName", Order = 310)]
        public OneOrManyTrainName TrainName { get; set; }

        /// <summary>
        /// The unique identifier for the train.
        /// </summary>
        [DataMember(Name = "trainNumber", Order = 311)]
        public OneOrManyTrainNumber TrainNumber { get; set; }
    }
}
