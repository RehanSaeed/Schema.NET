namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.&lt;br/&gt;&lt;br/&gt;
    /// See also &lt;a href="http://blog.schema.org/2014/04/announcing-schemaorg-actions.html"&gt;blog post&lt;/a&gt; and &lt;a href="https://schema.org/docs/actions.html"&gt;Actions overview document&lt;/a&gt;.
    /// </summary>
    public partial interface IAction : IThing
    {
        /// <summary>
        /// Indicates the current disposition of the Action.
        /// </summary>
        OneOrMany<ActionStatusType?> ActionStatus { get; set; }

        /// <summary>
        /// The direct performer or driver of the action (animate or inanimate). e.g. &lt;em&gt;John&lt;/em&gt; wrote a book.
        /// </summary>
        Values<IOrganization, IPerson> Agent { get; set; }

        /// <summary>
        /// The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to end. For actions that span a period of time, when the action was performed. e.g. John wrote a book from January to &lt;em&gt;December&lt;/em&gt;. For media, including audio and video, it's the time offset of the end of a clip within a larger file.&lt;br/&gt;&lt;br/&gt;
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        Values<DateTimeOffset?, TimeSpan?> EndTime { get; set; }

        /// <summary>
        /// For failed actions, more information on the cause of the failure.
        /// </summary>
        OneOrMany<IThing> Error { get; set; }

        /// <summary>
        /// The object that helped the agent perform the action. e.g. John wrote a book with &lt;em&gt;a pen&lt;/em&gt;.
        /// </summary>
        OneOrMany<IThing> Instrument { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        Values<IPlace, IPostalAddress, string> Location { get; set; }

        /// <summary>
        /// The object upon which the action is carried out, whose state is kept intact or changed. Also known as the semantic roles patient, affected or undergoer (which change their state) or theme (which doesn't). e.g. John read &lt;em&gt;a book&lt;/em&gt;.
        /// </summary>
        OneOrMany<IThing> Object { get; set; }

        /// <summary>
        /// Other co-agents that participated in the action indirectly. e.g. John wrote a book with &lt;em&gt;Steve&lt;/em&gt;.
        /// </summary>
        Values<IOrganization, IPerson> Participant { get; set; }

        /// <summary>
        /// The result produced in the action. e.g. John wrote &lt;em&gt;a book&lt;/em&gt;.
        /// </summary>
        OneOrMany<IThing> Result { get; set; }

        /// <summary>
        /// The startTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to start. For actions that span a period of time, when the action was performed. e.g. John wrote a book from &lt;em&gt;January&lt;/em&gt; to December. For media, including audio and video, it's the time offset of the start of a clip within a larger file.&lt;br/&gt;&lt;br/&gt;
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        Values<DateTimeOffset?, TimeSpan?> StartTime { get; set; }

        /// <summary>
        /// Indicates a target EntryPoint for an Action.
        /// </summary>
        Values<IEntryPoint, Uri> Target { get; set; }
    }

    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.&lt;br/&gt;&lt;br/&gt;
    /// See also &lt;a href="http://blog.schema.org/2014/04/announcing-schemaorg-actions.html"&gt;blog post&lt;/a&gt; and &lt;a href="https://schema.org/docs/actions.html"&gt;Actions overview document&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class Action : Thing, IAction, IEquatable<Action>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Action";

        /// <summary>
        /// Indicates the current disposition of the Action.
        /// </summary>
        [DataMember(Name = "actionStatus", Order = 106)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ActionStatusType?> ActionStatus { get; set; }

        /// <summary>
        /// The direct performer or driver of the action (animate or inanimate). e.g. &lt;em&gt;John&lt;/em&gt; wrote a book.
        /// </summary>
        [DataMember(Name = "agent", Order = 107)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Agent { get; set; }

        /// <summary>
        /// The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to end. For actions that span a period of time, when the action was performed. e.g. John wrote a book from January to &lt;em&gt;December&lt;/em&gt;. For media, including audio and video, it's the time offset of the end of a clip within a larger file.&lt;br/&gt;&lt;br/&gt;
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        [DataMember(Name = "endTime", Order = 108)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<DateTimeOffset?, TimeSpan?> EndTime { get; set; }

        /// <summary>
        /// For failed actions, more information on the cause of the failure.
        /// </summary>
        [DataMember(Name = "error", Order = 109)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> Error { get; set; }

        /// <summary>
        /// The object that helped the agent perform the action. e.g. John wrote a book with &lt;em&gt;a pen&lt;/em&gt;.
        /// </summary>
        [DataMember(Name = "instrument", Order = 110)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> Instrument { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [DataMember(Name = "location", Order = 111)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPlace, IPostalAddress, string> Location { get; set; }

        /// <summary>
        /// The object upon which the action is carried out, whose state is kept intact or changed. Also known as the semantic roles patient, affected or undergoer (which change their state) or theme (which doesn't). e.g. John read &lt;em&gt;a book&lt;/em&gt;.
        /// </summary>
        [DataMember(Name = "object", Order = 112)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> Object { get; set; }

        /// <summary>
        /// Other co-agents that participated in the action indirectly. e.g. John wrote a book with &lt;em&gt;Steve&lt;/em&gt;.
        /// </summary>
        [DataMember(Name = "participant", Order = 113)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Participant { get; set; }

        /// <summary>
        /// The result produced in the action. e.g. John wrote &lt;em&gt;a book&lt;/em&gt;.
        /// </summary>
        [DataMember(Name = "result", Order = 114)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> Result { get; set; }

        /// <summary>
        /// The startTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to start. For actions that span a period of time, when the action was performed. e.g. John wrote a book from &lt;em&gt;January&lt;/em&gt; to December. For media, including audio and video, it's the time offset of the start of a clip within a larger file.&lt;br/&gt;&lt;br/&gt;
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        [DataMember(Name = "startTime", Order = 115)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<DateTimeOffset?, TimeSpan?> StartTime { get; set; }

        /// <summary>
        /// Indicates a target EntryPoint for an Action.
        /// </summary>
        [DataMember(Name = "target", Order = 116)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IEntryPoint, Uri> Target { get; set; }

        /// <inheritdoc/>
        public bool Equals(Action other)
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
                this.ActionStatus == other.ActionStatus &&
                this.Agent == other.Agent &&
                this.EndTime == other.EndTime &&
                this.Error == other.Error &&
                this.Instrument == other.Instrument &&
                this.Location == other.Location &&
                this.Object == other.Object &&
                this.Participant == other.Participant &&
                this.Result == other.Result &&
                this.StartTime == other.StartTime &&
                this.Target == other.Target &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Action);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ActionStatus)
            .And(this.Agent)
            .And(this.EndTime)
            .And(this.Error)
            .And(this.Instrument)
            .And(this.Location)
            .And(this.Object)
            .And(this.Participant)
            .And(this.Result)
            .And(this.StartTime)
            .And(this.Target)
            .And(base.GetHashCode());
    }
}
