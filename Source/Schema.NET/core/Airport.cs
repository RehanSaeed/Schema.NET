namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An airport.
    /// </summary>
    [DataContract]
    public partial class Airport : CivicStructure
    {
        public interface IIataCode : IValue {}
        public interface IIataCode<T> : IIataCode { new T Value { get; } }
        public class OneOrManyIataCode : OneOrMany<IIataCode>
        {
            public OneOrManyIataCode(IIataCode item) : base(item) { }
            public OneOrManyIataCode(IEnumerable<IIataCode> items) : base(items) { }
            public static implicit operator OneOrManyIataCode (string value) { return new OneOrManyIataCode (new IataCodestring (value)); }
            public static implicit operator OneOrManyIataCode (string[] values) { return new OneOrManyIataCode (values.Select(v => (IIataCode) new IataCodestring (v))); }
            public static implicit operator OneOrManyIataCode (List<string> values) { return new OneOrManyIataCode (values.Select(v => (IIataCode) new IataCodestring (v))); }
        }
        public struct IataCodestring : IIataCode<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public IataCodestring (string value) { Value = value; }
            public static implicit operator IataCodestring (string value) { return new IataCodestring (value); }
        }

        public interface IIcaoCode : IValue {}
        public interface IIcaoCode<T> : IIcaoCode { new T Value { get; } }
        public class OneOrManyIcaoCode : OneOrMany<IIcaoCode>
        {
            public OneOrManyIcaoCode(IIcaoCode item) : base(item) { }
            public OneOrManyIcaoCode(IEnumerable<IIcaoCode> items) : base(items) { }
            public static implicit operator OneOrManyIcaoCode (string value) { return new OneOrManyIcaoCode (new IcaoCodestring (value)); }
            public static implicit operator OneOrManyIcaoCode (string[] values) { return new OneOrManyIcaoCode (values.Select(v => (IIcaoCode) new IcaoCodestring (v))); }
            public static implicit operator OneOrManyIcaoCode (List<string> values) { return new OneOrManyIcaoCode (values.Select(v => (IIcaoCode) new IcaoCodestring (v))); }
        }
        public struct IcaoCodestring : IIcaoCode<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public IcaoCodestring (string value) { Value = value; }
            public static implicit operator IcaoCodestring (string value) { return new IcaoCodestring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Airport";

        /// <summary>
        /// IATA identifier for an airline or airport.
        /// </summary>
        [DataMember(Name = "iataCode", Order = 306)]
        public OneOrManyIataCode IataCode { get; set; }

        /// <summary>
        /// ICAO identifier for an airport.
        /// </summary>
        [DataMember(Name = "icaoCode", Order = 307)]
        public OneOrManyIcaoCode IcaoCode { get; set; }
    }
}
