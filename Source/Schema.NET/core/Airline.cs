namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An organization that provides flights for passengers.
    /// </summary>
    [DataContract]
    public partial class Airline : Organization
    {
        public interface IBoardingPolicy : IValue {}
        public interface IBoardingPolicy<T> : IBoardingPolicy { new T Value { get; } }
        public class OneOrManyBoardingPolicy : OneOrMany<IBoardingPolicy>
        {
            public OneOrManyBoardingPolicy(IBoardingPolicy item) : base(item) { }
            public OneOrManyBoardingPolicy(IEnumerable<IBoardingPolicy> items) : base(items) { }
            public static implicit operator OneOrManyBoardingPolicy (BoardingPolicyType value) { return new OneOrManyBoardingPolicy (new BoardingPolicyBoardingPolicyType (value)); }
            public static implicit operator OneOrManyBoardingPolicy (BoardingPolicyType[] values) { return new OneOrManyBoardingPolicy (values.Select(v => (IBoardingPolicy) new BoardingPolicyBoardingPolicyType (v))); }
            public static implicit operator OneOrManyBoardingPolicy (List<BoardingPolicyType> values) { return new OneOrManyBoardingPolicy (values.Select(v => (IBoardingPolicy) new BoardingPolicyBoardingPolicyType (v))); }
        }
        public struct BoardingPolicyBoardingPolicyType : IBoardingPolicy<BoardingPolicyType>
        {
            object IValue.Value => this.Value;
            public BoardingPolicyType Value { get; }
            public BoardingPolicyBoardingPolicyType (BoardingPolicyType value) { Value = value; }
            public static implicit operator BoardingPolicyBoardingPolicyType (BoardingPolicyType value) { return new BoardingPolicyBoardingPolicyType (value); }
        }

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

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Airline";

        /// <summary>
        /// The type of boarding policy used by the airline (e.g. zone-based or group-based).
        /// </summary>
        [DataMember(Name = "boardingPolicy", Order = 206)]
        public OneOrManyBoardingPolicy BoardingPolicy { get; set; }

        /// <summary>
        /// IATA identifier for an airline or airport.
        /// </summary>
        [DataMember(Name = "iataCode", Order = 207)]
        public OneOrManyIataCode IataCode { get; set; }
    }
}
