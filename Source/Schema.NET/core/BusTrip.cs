namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A trip on a commercial bus line.
    /// </summary>
    public partial interface IBusTrip : ITrip
    {
        /// <summary>
        /// The stop or station from which the bus arrives.
        /// </summary>
        Values<IBusStation, IBusStop> ArrivalBusStop { get; set; }

        /// <summary>
        /// The name of the bus (e.g. Bolt Express).
        /// </summary>
        OneOrMany<string> BusName { get; set; }

        /// <summary>
        /// The unique identifier for the bus.
        /// </summary>
        OneOrMany<string> BusNumber { get; set; }

        /// <summary>
        /// The stop or station from which the bus departs.
        /// </summary>
        Values<IBusStation, IBusStop> DepartureBusStop { get; set; }
    }

    /// <summary>
    /// A trip on a commercial bus line.
    /// </summary>
    [DataContract]
    public partial class BusTrip : Trip, IBusTrip, IEquatable<BusTrip>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BusTrip";

        /// <summary>
        /// The stop or station from which the bus arrives.
        /// </summary>
        [DataMember(Name = "arrivalBusStop", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IBusStation, IBusStop> ArrivalBusStop { get; set; }

        /// <summary>
        /// The name of the bus (e.g. Bolt Express).
        /// </summary>
        [DataMember(Name = "busName", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BusName { get; set; }

        /// <summary>
        /// The unique identifier for the bus.
        /// </summary>
        [DataMember(Name = "busNumber", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BusNumber { get; set; }

        /// <summary>
        /// The stop or station from which the bus departs.
        /// </summary>
        [DataMember(Name = "departureBusStop", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IBusStation, IBusStop> DepartureBusStop { get; set; }

        /// <inheritdoc/>
        public bool Equals(BusTrip other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.ArrivalBusStop == other.ArrivalBusStop &&
                this.BusName == other.BusName &&
                this.BusNumber == other.BusNumber &&
                this.DepartureBusStop == other.DepartureBusStop &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as BusTrip);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ArrivalBusStop)
            .And(this.BusName)
            .And(this.BusNumber)
            .And(this.DepartureBusStop)
            .And(base.GetHashCode());
    }
}
