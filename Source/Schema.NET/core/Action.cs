namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.&lt;br/&gt;&lt;br/&gt;
    /// See also &lt;a href="http://blog.schema.org/2014/04/announcing-schemaorg-actions.html"&gt;blog post&lt;/a&gt; and &lt;a href="http://schema.org/docs/actions.html"&gt;Actions overview document&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class Action : Thing
    {
        public interface IActionStatus : IValue {}
        public interface IActionStatus<T> : IActionStatus { new T Value { get; } }
        public class OneOrManyActionStatus : OneOrMany<IActionStatus>
        {
            public OneOrManyActionStatus(IActionStatus item) : base(item) { }
            public OneOrManyActionStatus(IEnumerable<IActionStatus> items) : base(items) { }
            public static implicit operator OneOrManyActionStatus (ActionStatusType value) { return new OneOrManyActionStatus (new ActionStatusActionStatusType (value)); }
            public static implicit operator OneOrManyActionStatus (ActionStatusType[] values) { return new OneOrManyActionStatus (values.Select(v => (IActionStatus) new ActionStatusActionStatusType (v))); }
            public static implicit operator OneOrManyActionStatus (List<ActionStatusType> values) { return new OneOrManyActionStatus (values.Select(v => (IActionStatus) new ActionStatusActionStatusType (v))); }
        }
        public struct ActionStatusActionStatusType : IActionStatus<ActionStatusType>
        {
            object IValue.Value => this.Value;
            public ActionStatusType Value { get; }
            public ActionStatusActionStatusType (ActionStatusType value) { Value = value; }
            public static implicit operator ActionStatusActionStatusType (ActionStatusType value) { return new ActionStatusActionStatusType (value); }
        }

        public interface IAgent : IValue {}
        public interface IAgent<T> : IAgent { new T Value { get; } }
        public class OneOrManyAgent : OneOrMany<IAgent>
        {
            public OneOrManyAgent(IAgent item) : base(item) { }
            public OneOrManyAgent(IEnumerable<IAgent> items) : base(items) { }
            public static implicit operator OneOrManyAgent (Organization value) { return new OneOrManyAgent (new AgentOrganization (value)); }
            public static implicit operator OneOrManyAgent (Organization[] values) { return new OneOrManyAgent (values.Select(v => (IAgent) new AgentOrganization (v))); }
            public static implicit operator OneOrManyAgent (List<Organization> values) { return new OneOrManyAgent (values.Select(v => (IAgent) new AgentOrganization (v))); }
            public static implicit operator OneOrManyAgent (Person value) { return new OneOrManyAgent (new AgentPerson (value)); }
            public static implicit operator OneOrManyAgent (Person[] values) { return new OneOrManyAgent (values.Select(v => (IAgent) new AgentPerson (v))); }
            public static implicit operator OneOrManyAgent (List<Person> values) { return new OneOrManyAgent (values.Select(v => (IAgent) new AgentPerson (v))); }
        }
        public struct AgentOrganization : IAgent<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public AgentOrganization (Organization value) { Value = value; }
            public static implicit operator AgentOrganization (Organization value) { return new AgentOrganization (value); }
        }
        public struct AgentPerson : IAgent<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public AgentPerson (Person value) { Value = value; }
            public static implicit operator AgentPerson (Person value) { return new AgentPerson (value); }
        }

        public interface IEndTime : IValue {}
        public interface IEndTime<T> : IEndTime { new T Value { get; } }
        public class OneOrManyEndTime : OneOrMany<IEndTime>
        {
            public OneOrManyEndTime(IEndTime item) : base(item) { }
            public OneOrManyEndTime(IEnumerable<IEndTime> items) : base(items) { }
            public static implicit operator OneOrManyEndTime (DateTimeOffset value) { return new OneOrManyEndTime (new EndTimeDateTimeOffset (value)); }
            public static implicit operator OneOrManyEndTime (DateTimeOffset[] values) { return new OneOrManyEndTime (values.Select(v => (IEndTime) new EndTimeDateTimeOffset (v))); }
            public static implicit operator OneOrManyEndTime (List<DateTimeOffset> values) { return new OneOrManyEndTime (values.Select(v => (IEndTime) new EndTimeDateTimeOffset (v))); }
        }
        public struct EndTimeDateTimeOffset : IEndTime<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public EndTimeDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator EndTimeDateTimeOffset (DateTimeOffset value) { return new EndTimeDateTimeOffset (value); }
        }

        public interface IError : IValue {}
        public interface IError<T> : IError { new T Value { get; } }
        public class OneOrManyError : OneOrMany<IError>
        {
            public OneOrManyError(IError item) : base(item) { }
            public OneOrManyError(IEnumerable<IError> items) : base(items) { }
            public static implicit operator OneOrManyError (Thing value) { return new OneOrManyError (new ErrorThing (value)); }
            public static implicit operator OneOrManyError (Thing[] values) { return new OneOrManyError (values.Select(v => (IError) new ErrorThing (v))); }
            public static implicit operator OneOrManyError (List<Thing> values) { return new OneOrManyError (values.Select(v => (IError) new ErrorThing (v))); }
        }
        public struct ErrorThing : IError<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public ErrorThing (Thing value) { Value = value; }
            public static implicit operator ErrorThing (Thing value) { return new ErrorThing (value); }
        }

        public interface IInstrument : IValue {}
        public interface IInstrument<T> : IInstrument { new T Value { get; } }
        public class OneOrManyInstrument : OneOrMany<IInstrument>
        {
            public OneOrManyInstrument(IInstrument item) : base(item) { }
            public OneOrManyInstrument(IEnumerable<IInstrument> items) : base(items) { }
            public static implicit operator OneOrManyInstrument (Thing value) { return new OneOrManyInstrument (new InstrumentThing (value)); }
            public static implicit operator OneOrManyInstrument (Thing[] values) { return new OneOrManyInstrument (values.Select(v => (IInstrument) new InstrumentThing (v))); }
            public static implicit operator OneOrManyInstrument (List<Thing> values) { return new OneOrManyInstrument (values.Select(v => (IInstrument) new InstrumentThing (v))); }
        }
        public struct InstrumentThing : IInstrument<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public InstrumentThing (Thing value) { Value = value; }
            public static implicit operator InstrumentThing (Thing value) { return new InstrumentThing (value); }
        }

        public interface ILocation : IValue {}
        public interface ILocation<T> : ILocation { new T Value { get; } }
        public class OneOrManyLocation : OneOrMany<ILocation>
        {
            public OneOrManyLocation(ILocation item) : base(item) { }
            public OneOrManyLocation(IEnumerable<ILocation> items) : base(items) { }
            public static implicit operator OneOrManyLocation (Place value) { return new OneOrManyLocation (new LocationPlace (value)); }
            public static implicit operator OneOrManyLocation (Place[] values) { return new OneOrManyLocation (values.Select(v => (ILocation) new LocationPlace (v))); }
            public static implicit operator OneOrManyLocation (List<Place> values) { return new OneOrManyLocation (values.Select(v => (ILocation) new LocationPlace (v))); }
            public static implicit operator OneOrManyLocation (PostalAddress value) { return new OneOrManyLocation (new LocationPostalAddress (value)); }
            public static implicit operator OneOrManyLocation (PostalAddress[] values) { return new OneOrManyLocation (values.Select(v => (ILocation) new LocationPostalAddress (v))); }
            public static implicit operator OneOrManyLocation (List<PostalAddress> values) { return new OneOrManyLocation (values.Select(v => (ILocation) new LocationPostalAddress (v))); }
            public static implicit operator OneOrManyLocation (string value) { return new OneOrManyLocation (new Locationstring (value)); }
            public static implicit operator OneOrManyLocation (string[] values) { return new OneOrManyLocation (values.Select(v => (ILocation) new Locationstring (v))); }
            public static implicit operator OneOrManyLocation (List<string> values) { return new OneOrManyLocation (values.Select(v => (ILocation) new Locationstring (v))); }
        }
        public struct LocationPlace : ILocation<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public LocationPlace (Place value) { Value = value; }
            public static implicit operator LocationPlace (Place value) { return new LocationPlace (value); }
        }
        public struct LocationPostalAddress : ILocation<PostalAddress>
        {
            object IValue.Value => this.Value;
            public PostalAddress Value { get; }
            public LocationPostalAddress (PostalAddress value) { Value = value; }
            public static implicit operator LocationPostalAddress (PostalAddress value) { return new LocationPostalAddress (value); }
        }
        public struct Locationstring : ILocation<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Locationstring (string value) { Value = value; }
            public static implicit operator Locationstring (string value) { return new Locationstring (value); }
        }

        public interface IObject : IValue {}
        public interface IObject<T> : IObject { new T Value { get; } }
        public class OneOrManyObject : OneOrMany<IObject>
        {
            public OneOrManyObject(IObject item) : base(item) { }
            public OneOrManyObject(IEnumerable<IObject> items) : base(items) { }
            public static implicit operator OneOrManyObject (Thing value) { return new OneOrManyObject (new ObjectThing (value)); }
            public static implicit operator OneOrManyObject (Thing[] values) { return new OneOrManyObject (values.Select(v => (IObject) new ObjectThing (v))); }
            public static implicit operator OneOrManyObject (List<Thing> values) { return new OneOrManyObject (values.Select(v => (IObject) new ObjectThing (v))); }
        }
        public struct ObjectThing : IObject<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public ObjectThing (Thing value) { Value = value; }
            public static implicit operator ObjectThing (Thing value) { return new ObjectThing (value); }
        }

        public interface IParticipant : IValue {}
        public interface IParticipant<T> : IParticipant { new T Value { get; } }
        public class OneOrManyParticipant : OneOrMany<IParticipant>
        {
            public OneOrManyParticipant(IParticipant item) : base(item) { }
            public OneOrManyParticipant(IEnumerable<IParticipant> items) : base(items) { }
            public static implicit operator OneOrManyParticipant (Organization value) { return new OneOrManyParticipant (new ParticipantOrganization (value)); }
            public static implicit operator OneOrManyParticipant (Organization[] values) { return new OneOrManyParticipant (values.Select(v => (IParticipant) new ParticipantOrganization (v))); }
            public static implicit operator OneOrManyParticipant (List<Organization> values) { return new OneOrManyParticipant (values.Select(v => (IParticipant) new ParticipantOrganization (v))); }
            public static implicit operator OneOrManyParticipant (Person value) { return new OneOrManyParticipant (new ParticipantPerson (value)); }
            public static implicit operator OneOrManyParticipant (Person[] values) { return new OneOrManyParticipant (values.Select(v => (IParticipant) new ParticipantPerson (v))); }
            public static implicit operator OneOrManyParticipant (List<Person> values) { return new OneOrManyParticipant (values.Select(v => (IParticipant) new ParticipantPerson (v))); }
        }
        public struct ParticipantOrganization : IParticipant<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public ParticipantOrganization (Organization value) { Value = value; }
            public static implicit operator ParticipantOrganization (Organization value) { return new ParticipantOrganization (value); }
        }
        public struct ParticipantPerson : IParticipant<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ParticipantPerson (Person value) { Value = value; }
            public static implicit operator ParticipantPerson (Person value) { return new ParticipantPerson (value); }
        }

        public interface IResult : IValue {}
        public interface IResult<T> : IResult { new T Value { get; } }
        public class OneOrManyResult : OneOrMany<IResult>
        {
            public OneOrManyResult(IResult item) : base(item) { }
            public OneOrManyResult(IEnumerable<IResult> items) : base(items) { }
            public static implicit operator OneOrManyResult (Thing value) { return new OneOrManyResult (new ResultThing (value)); }
            public static implicit operator OneOrManyResult (Thing[] values) { return new OneOrManyResult (values.Select(v => (IResult) new ResultThing (v))); }
            public static implicit operator OneOrManyResult (List<Thing> values) { return new OneOrManyResult (values.Select(v => (IResult) new ResultThing (v))); }
        }
        public struct ResultThing : IResult<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public ResultThing (Thing value) { Value = value; }
            public static implicit operator ResultThing (Thing value) { return new ResultThing (value); }
        }

        public interface IStartTime : IValue {}
        public interface IStartTime<T> : IStartTime { new T Value { get; } }
        public class OneOrManyStartTime : OneOrMany<IStartTime>
        {
            public OneOrManyStartTime(IStartTime item) : base(item) { }
            public OneOrManyStartTime(IEnumerable<IStartTime> items) : base(items) { }
            public static implicit operator OneOrManyStartTime (DateTimeOffset value) { return new OneOrManyStartTime (new StartTimeDateTimeOffset (value)); }
            public static implicit operator OneOrManyStartTime (DateTimeOffset[] values) { return new OneOrManyStartTime (values.Select(v => (IStartTime) new StartTimeDateTimeOffset (v))); }
            public static implicit operator OneOrManyStartTime (List<DateTimeOffset> values) { return new OneOrManyStartTime (values.Select(v => (IStartTime) new StartTimeDateTimeOffset (v))); }
        }
        public struct StartTimeDateTimeOffset : IStartTime<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public StartTimeDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator StartTimeDateTimeOffset (DateTimeOffset value) { return new StartTimeDateTimeOffset (value); }
        }

        public interface ITarget : IValue {}
        public interface ITarget<T> : ITarget { new T Value { get; } }
        public class OneOrManyTarget : OneOrMany<ITarget>
        {
            public OneOrManyTarget(ITarget item) : base(item) { }
            public OneOrManyTarget(IEnumerable<ITarget> items) : base(items) { }
            public static implicit operator OneOrManyTarget (EntryPoint value) { return new OneOrManyTarget (new TargetEntryPoint (value)); }
            public static implicit operator OneOrManyTarget (EntryPoint[] values) { return new OneOrManyTarget (values.Select(v => (ITarget) new TargetEntryPoint (v))); }
            public static implicit operator OneOrManyTarget (List<EntryPoint> values) { return new OneOrManyTarget (values.Select(v => (ITarget) new TargetEntryPoint (v))); }
            public static implicit operator OneOrManyTarget (Uri value) { return new OneOrManyTarget (new TargetUri (value)); }
            public static implicit operator OneOrManyTarget (Uri[] values) { return new OneOrManyTarget (values.Select(v => (ITarget) new TargetUri (v))); }
            public static implicit operator OneOrManyTarget (List<Uri> values) { return new OneOrManyTarget (values.Select(v => (ITarget) new TargetUri (v))); }
        }
        public struct TargetEntryPoint : ITarget<EntryPoint>
        {
            object IValue.Value => this.Value;
            public EntryPoint Value { get; }
            public TargetEntryPoint (EntryPoint value) { Value = value; }
            public static implicit operator TargetEntryPoint (EntryPoint value) { return new TargetEntryPoint (value); }
        }
        public struct TargetUri : ITarget<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public TargetUri (Uri value) { Value = value; }
            public static implicit operator TargetUri (Uri value) { return new TargetUri (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Action";

        /// <summary>
        /// Indicates the current disposition of the Action.
        /// </summary>
        [DataMember(Name = "actionStatus", Order = 106)]
        public OneOrManyActionStatus ActionStatus { get; set; }

        /// <summary>
        /// The direct performer or driver of the action (animate or inanimate). e.g. &lt;em&gt;John&lt;/em&gt; wrote a book.
        /// </summary>
        [DataMember(Name = "agent", Order = 107)]
        public OneOrManyAgent Agent { get; set; }

        /// <summary>
        /// The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to end. For actions that span a period of time, when the action was performed. e.g. John wrote a book from January to &lt;em&gt;December&lt;/em&gt;.&lt;br/&gt;&lt;br/&gt;
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        [DataMember(Name = "endTime", Order = 108)]
        public OneOrManyEndTime EndTime { get; set; }

        /// <summary>
        /// For failed actions, more information on the cause of the failure.
        /// </summary>
        [DataMember(Name = "error", Order = 109)]
        public OneOrManyError Error { get; set; }

        /// <summary>
        /// The object that helped the agent perform the action. e.g. John wrote a book with &lt;em&gt;a pen&lt;/em&gt;.
        /// </summary>
        [DataMember(Name = "instrument", Order = 110)]
        public OneOrManyInstrument Instrument { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [DataMember(Name = "location", Order = 111)]
        public OneOrManyLocation Location { get; set; }

        /// <summary>
        /// The object upon which the action is carried out, whose state is kept intact or changed. Also known as the semantic roles patient, affected or undergoer (which change their state) or theme (which doesn't). e.g. John read &lt;em&gt;a book&lt;/em&gt;.
        /// </summary>
        [DataMember(Name = "object", Order = 112)]
        public OneOrManyObject Object { get; set; }

        /// <summary>
        /// Other co-agents that participated in the action indirectly. e.g. John wrote a book with &lt;em&gt;Steve&lt;/em&gt;.
        /// </summary>
        [DataMember(Name = "participant", Order = 113)]
        public OneOrManyParticipant Participant { get; set; }

        /// <summary>
        /// The result produced in the action. e.g. John wrote &lt;em&gt;a book&lt;/em&gt;.
        /// </summary>
        [DataMember(Name = "result", Order = 114)]
        public OneOrManyResult Result { get; set; }

        /// <summary>
        /// The startTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to start. For actions that span a period of time, when the action was performed. e.g. John wrote a book from &lt;em&gt;January&lt;/em&gt; to December.&lt;br/&gt;&lt;br/&gt;
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        [DataMember(Name = "startTime", Order = 115)]
        public OneOrManyStartTime StartTime { get; set; }

        /// <summary>
        /// Indicates a target EntryPoint for an Action.
        /// </summary>
        [DataMember(Name = "target", Order = 116)]
        public OneOrManyTarget Target { get; set; }
    }
}
