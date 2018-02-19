using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.&lt;/p&gt;
    /// &lt;p&gt;See also &lt;a href="http://blog.schema.org/2014/04/announcing-schemaorg-actions.html"&gt;blog post&lt;/a&gt; and &lt;a href="http://schema.org/docs/actions.html"&gt;Actions overview document&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class Action : Thing
    {
        public interface IAgent : IWrapper { }
        public interface IAgent<T> : IAgent { new T Data { get; set; } }
        public class AgentOrganization : IAgent<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public AgentOrganization () { }
            public AgentOrganization (Organization data) { Data = data; }
            public static implicit operator AgentOrganization (Organization data) { return new AgentOrganization (data); }
        }

        public class AgentPerson : IAgent<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public AgentPerson () { }
            public AgentPerson (Person data) { Data = data; }
            public static implicit operator AgentPerson (Person data) { return new AgentPerson (data); }
        }


        public interface ILocation : IWrapper { }
        public interface ILocation<T> : ILocation { new T Data { get; set; } }
        public class LocationPlace : ILocation<Place>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Place) value; } }
            public virtual Place Data { get; set; }
            public LocationPlace () { }
            public LocationPlace (Place data) { Data = data; }
            public static implicit operator LocationPlace (Place data) { return new LocationPlace (data); }
        }

        public class LocationPostalAddress : ILocation<PostalAddress>
        {
            object IWrapper.Data { get { return Data; } set { Data = (PostalAddress) value; } }
            public virtual PostalAddress Data { get; set; }
            public LocationPostalAddress () { }
            public LocationPostalAddress (PostalAddress data) { Data = data; }
            public static implicit operator LocationPostalAddress (PostalAddress data) { return new LocationPostalAddress (data); }
        }

        public class Locationstring : ILocation<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Locationstring () { }
            public Locationstring (string data) { Data = data; }
            public static implicit operator Locationstring (string data) { return new Locationstring (data); }
        }


        public interface IParticipant : IWrapper { }
        public interface IParticipant<T> : IParticipant { new T Data { get; set; } }
        public class ParticipantOrganization : IParticipant<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public ParticipantOrganization () { }
            public ParticipantOrganization (Organization data) { Data = data; }
            public static implicit operator ParticipantOrganization (Organization data) { return new ParticipantOrganization (data); }
        }

        public class ParticipantPerson : IParticipant<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public ParticipantPerson () { }
            public ParticipantPerson (Person data) { Data = data; }
            public static implicit operator ParticipantPerson (Person data) { return new ParticipantPerson (data); }
        }


        public interface ITarget : IWrapper { }
        public interface ITarget<T> : ITarget { new T Data { get; set; } }
        public class TargetEntryPoint : ITarget<EntryPoint>
        {
            object IWrapper.Data { get { return Data; } set { Data = (EntryPoint) value; } }
            public virtual EntryPoint Data { get; set; }
            public TargetEntryPoint () { }
            public TargetEntryPoint (EntryPoint data) { Data = data; }
            public static implicit operator TargetEntryPoint (EntryPoint data) { return new TargetEntryPoint (data); }
        }

        public class TargetUri : ITarget<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public TargetUri () { }
            public TargetUri (Uri data) { Data = data; }
            public static implicit operator TargetUri (Uri data) { return new TargetUri (data); }
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ActionStatusType>? ActionStatus { get; set; } 

        /// <summary>
        /// The direct performer or driver of the action (animate or inanimate). e.g. &lt;em&gt;John&lt;/em&gt; wrote a book.
        /// </summary>
        [DataMember(Name = "agent", Order = 107)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAgent>? Agent { get; set; } //Organization, Person

        /// <summary>
        /// The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to end. For actions that span a period of time, when the action was performed. e.g. John wrote a book from January to &lt;em&gt;December&lt;/em&gt;.&lt;/p&gt;
        /// &lt;p&gt;Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        [DataMember(Name = "endTime", Order = 108)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? EndTime { get; set; } 

        /// <summary>
        /// For failed actions, more information on the cause of the failure.
        /// </summary>
        [DataMember(Name = "error", Order = 109)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? Error { get; set; } 

        /// <summary>
        /// The object that helped the agent perform the action. e.g. John wrote a book with &lt;em&gt;a pen&lt;/em&gt;.
        /// </summary>
        [DataMember(Name = "instrument", Order = 110)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? Instrument { get; set; } 

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [DataMember(Name = "location", Order = 111)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ILocation>? Location { get; set; } //Place, PostalAddress, string

        /// <summary>
        /// The object upon which the action is carried out, whose state is kept intact or changed. Also known as the semantic roles patient, affected or undergoer (which change their state) or theme (which doesn't). e.g. John read &lt;em&gt;a book&lt;/em&gt;.
        /// </summary>
        [DataMember(Name = "object", Order = 112)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? Object { get; set; } 

        /// <summary>
        /// Other co-agents that participated in the action indirectly. e.g. John wrote a book with &lt;em&gt;Steve&lt;/em&gt;.
        /// </summary>
        [DataMember(Name = "participant", Order = 113)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IParticipant>? Participant { get; set; } //Organization, Person

        /// <summary>
        /// The result produced in the action. e.g. John wrote &lt;em&gt;a book&lt;/em&gt;.
        /// </summary>
        [DataMember(Name = "result", Order = 114)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? Result { get; set; } 

        /// <summary>
        /// The startTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to start. For actions that span a period of time, when the action was performed. e.g. John wrote a book from &lt;em&gt;January&lt;/em&gt; to December.&lt;/p&gt;
        /// &lt;p&gt;Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        [DataMember(Name = "startTime", Order = 115)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? StartTime { get; set; } 

        /// <summary>
        /// Indicates a target EntryPoint for an Action.
        /// </summary>
        [DataMember(Name = "target", Order = 116)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ITarget>? Target { get; set; } //EntryPoint, Uri
    }
}
