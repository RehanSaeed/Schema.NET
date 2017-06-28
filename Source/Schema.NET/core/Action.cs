namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object...
    /// </summary>
    [DataContract]
    public partial class Action : Thing
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Action";

        /// <summary>
        /// Indicates the current disposition of the Action.
        /// </summary>
        [DataMember(Name = "actionStatus", Order = 105)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ActionStatusType?>? ActionStatus { get; set; }

        /// <summary>
        /// The direct performer or driver of the action (animate or inanimate). e.g. &lt;em&gt;John&lt;/em&gt; wrote a book.
        /// </summary>
        [DataMember(Name = "agent", Order = 106)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Agent { get; set; }

        /// <summary>
        /// The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to end. For actions that span a period of time, when the action was performed. e.g. John wrote a book from January to &lt;em&gt;December&lt;/em&gt;.&lt;/p&gt;
        /// &lt;p&gt;Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        [DataMember(Name = "endTime", Order = 107)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? EndTime { get; set; }

        /// <summary>
        /// For failed actions, more information on the cause of the failure.
        /// </summary>
        [DataMember(Name = "error", Order = 108)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? Error { get; set; }

        /// <summary>
        /// The object that helped the agent perform the action. e.g. John wrote a book with &lt;em&gt;a pen&lt;/em&gt;.
        /// </summary>
        [DataMember(Name = "instrument", Order = 109)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? Instrument { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [DataMember(Name = "location", Order = 110)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place, string, PostalAddress>? Location { get; set; }

        /// <summary>
        /// The object upon which the action is carried out, whose state is kept intact or changed. Also known as the semantic roles patient, affected or undergoer (which change their state) or theme (which doesn't). e.g. John read &lt;em&gt;a book&lt;/em&gt;.
        /// </summary>
        [DataMember(Name = "object", Order = 111)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? Object { get; set; }

        /// <summary>
        /// Other co-agents that participated in the action indirectly. e.g. John wrote a book with &lt;em&gt;Steve&lt;/em&gt;.
        /// </summary>
        [DataMember(Name = "participant", Order = 112)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Participant { get; set; }

        /// <summary>
        /// The result produced in the action. e.g. John wrote &lt;em&gt;a book&lt;/em&gt;.
        /// </summary>
        [DataMember(Name = "result", Order = 113)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? Result { get; set; }

        /// <summary>
        /// The startTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to start. For actions that span a period of time, when the action was performed. e.g. John wrote a book from &lt;em&gt;January&lt;/em&gt; to December.&lt;/p&gt;
        /// &lt;p&gt;Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        [DataMember(Name = "startTime", Order = 114)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? StartTime { get; set; }

        /// <summary>
        /// Indicates a target EntryPoint for an Action.
        /// </summary>
        [DataMember(Name = "target", Order = 115)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<EntryPoint, Uri>? Target { get; set; }
    }
}
