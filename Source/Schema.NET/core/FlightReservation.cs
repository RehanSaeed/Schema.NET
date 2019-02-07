namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A reservation for air travel.&lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class FlightReservation : Reservation
    {
        public interface IBoardingGroup : IValue {}
        public interface IBoardingGroup<T> : IBoardingGroup { new T Value { get; } }
        public class OneOrManyBoardingGroup : OneOrMany<IBoardingGroup>
        {
            public OneOrManyBoardingGroup(IBoardingGroup item) : base(item) { }
            public OneOrManyBoardingGroup(IEnumerable<IBoardingGroup> items) : base(items) { }
            public static implicit operator OneOrManyBoardingGroup (string value) { return new OneOrManyBoardingGroup (new BoardingGroupstring (value)); }
            public static implicit operator OneOrManyBoardingGroup (string[] values) { return new OneOrManyBoardingGroup (values.Select(v => (IBoardingGroup) new BoardingGroupstring (v))); }
            public static implicit operator OneOrManyBoardingGroup (List<string> values) { return new OneOrManyBoardingGroup (values.Select(v => (IBoardingGroup) new BoardingGroupstring (v))); }
        }
        public struct BoardingGroupstring : IBoardingGroup<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public BoardingGroupstring (string value) { Value = value; }
            public static implicit operator BoardingGroupstring (string value) { return new BoardingGroupstring (value); }
        }

        public interface IPassengerPriorityStatus : IValue {}
        public interface IPassengerPriorityStatus<T> : IPassengerPriorityStatus { new T Value { get; } }
        public class OneOrManyPassengerPriorityStatus : OneOrMany<IPassengerPriorityStatus>
        {
            public OneOrManyPassengerPriorityStatus(IPassengerPriorityStatus item) : base(item) { }
            public OneOrManyPassengerPriorityStatus(IEnumerable<IPassengerPriorityStatus> items) : base(items) { }
            public static implicit operator OneOrManyPassengerPriorityStatus (string value) { return new OneOrManyPassengerPriorityStatus (new PassengerPriorityStatusstring (value)); }
            public static implicit operator OneOrManyPassengerPriorityStatus (string[] values) { return new OneOrManyPassengerPriorityStatus (values.Select(v => (IPassengerPriorityStatus) new PassengerPriorityStatusstring (v))); }
            public static implicit operator OneOrManyPassengerPriorityStatus (List<string> values) { return new OneOrManyPassengerPriorityStatus (values.Select(v => (IPassengerPriorityStatus) new PassengerPriorityStatusstring (v))); }
        }
        public struct PassengerPriorityStatusstring : IPassengerPriorityStatus<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PassengerPriorityStatusstring (string value) { Value = value; }
            public static implicit operator PassengerPriorityStatusstring (string value) { return new PassengerPriorityStatusstring (value); }
        }

        public interface IPassengerSequenceNumber : IValue {}
        public interface IPassengerSequenceNumber<T> : IPassengerSequenceNumber { new T Value { get; } }
        public class OneOrManyPassengerSequenceNumber : OneOrMany<IPassengerSequenceNumber>
        {
            public OneOrManyPassengerSequenceNumber(IPassengerSequenceNumber item) : base(item) { }
            public OneOrManyPassengerSequenceNumber(IEnumerable<IPassengerSequenceNumber> items) : base(items) { }
            public static implicit operator OneOrManyPassengerSequenceNumber (string value) { return new OneOrManyPassengerSequenceNumber (new PassengerSequenceNumberstring (value)); }
            public static implicit operator OneOrManyPassengerSequenceNumber (string[] values) { return new OneOrManyPassengerSequenceNumber (values.Select(v => (IPassengerSequenceNumber) new PassengerSequenceNumberstring (v))); }
            public static implicit operator OneOrManyPassengerSequenceNumber (List<string> values) { return new OneOrManyPassengerSequenceNumber (values.Select(v => (IPassengerSequenceNumber) new PassengerSequenceNumberstring (v))); }
        }
        public struct PassengerSequenceNumberstring : IPassengerSequenceNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PassengerSequenceNumberstring (string value) { Value = value; }
            public static implicit operator PassengerSequenceNumberstring (string value) { return new PassengerSequenceNumberstring (value); }
        }

        public interface ISecurityScreening : IValue {}
        public interface ISecurityScreening<T> : ISecurityScreening { new T Value { get; } }
        public class OneOrManySecurityScreening : OneOrMany<ISecurityScreening>
        {
            public OneOrManySecurityScreening(ISecurityScreening item) : base(item) { }
            public OneOrManySecurityScreening(IEnumerable<ISecurityScreening> items) : base(items) { }
            public static implicit operator OneOrManySecurityScreening (string value) { return new OneOrManySecurityScreening (new SecurityScreeningstring (value)); }
            public static implicit operator OneOrManySecurityScreening (string[] values) { return new OneOrManySecurityScreening (values.Select(v => (ISecurityScreening) new SecurityScreeningstring (v))); }
            public static implicit operator OneOrManySecurityScreening (List<string> values) { return new OneOrManySecurityScreening (values.Select(v => (ISecurityScreening) new SecurityScreeningstring (v))); }
        }
        public struct SecurityScreeningstring : ISecurityScreening<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SecurityScreeningstring (string value) { Value = value; }
            public static implicit operator SecurityScreeningstring (string value) { return new SecurityScreeningstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FlightReservation";

        /// <summary>
        /// The airline-specific indicator of boarding order / preference.
        /// </summary>
        [DataMember(Name = "boardingGroup", Order = 306)]
        public OneOrManyBoardingGroup BoardingGroup { get; set; }

        /// <summary>
        /// The priority status assigned to a passenger for security or boarding (e.g. FastTrack or Priority).
        /// </summary>
        [DataMember(Name = "passengerPriorityStatus", Order = 307)]
        public OneOrManyPassengerPriorityStatus PassengerPriorityStatus { get; set; }

        /// <summary>
        /// The passenger's sequence number as assigned by the airline.
        /// </summary>
        [DataMember(Name = "passengerSequenceNumber", Order = 308)]
        public OneOrManyPassengerSequenceNumber PassengerSequenceNumber { get; set; }

        /// <summary>
        /// The type of security screening the passenger is subject to.
        /// </summary>
        [DataMember(Name = "securityScreening", Order = 309)]
        public OneOrManySecurityScreening SecurityScreening { get; set; }
    }
}
