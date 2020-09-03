namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the &lt;a class="localLink" href="https://schema.org/offers"&gt;offers&lt;/a&gt; property. Repeated events may be structured as separate Event objects.
    /// </summary>
    public partial interface IEvent : IThing
    {
        /// <summary>
        /// The subject matter of the content.
        /// </summary>
        OneOrMany<IThing> About { get; set; }

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson> Actor { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        OneOrMany<IAggregateRating> AggregateRating { get; set; }

        /// <summary>
        /// A person or organization attending the event.
        /// </summary>
        Values<IOrganization, IPerson> Attendee { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        OneOrMany<IAudience> Audience { get; set; }

        /// <summary>
        /// The person or organization who wrote a composition, or who is the composer of a work performed at some event.
        /// </summary>
        Values<IOrganization, IPerson> Composer { get; set; }

        /// <summary>
        /// A secondary contributor to the CreativeWork or Event.
        /// </summary>
        Values<IOrganization, IPerson> Contributor { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson> Director { get; set; }

        /// <summary>
        /// The time admission will commence.
        /// </summary>
        Values<DateTimeOffset?, TimeSpan?> DoorTime { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        OneOrMany<TimeSpan?> Duration { get; set; }

        /// <summary>
        /// An eventStatus of an event represents its status; particularly useful when an event is cancelled or rescheduled.
        /// </summary>
        OneOrMany<EventStatusType?> EventStatus { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        Values<IOrganization, IPerson> Funder { get; set; }

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="https://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        Values<ILanguage, string> InLanguage { get; set; }

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        OneOrMany<bool?> IsAccessibleForFree { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        Values<IPlace, IPostalAddress, string> Location { get; set; }

        /// <summary>
        /// The total number of individuals that may attend an event or venue.
        /// </summary>
        OneOrMany<int?> MaximumAttendeeCapacity { get; set; }

        /// <summary>
        /// The maximum physical attendee capacity of an &lt;a class="localLink" href="https://schema.org/Event"&gt;Event&lt;/a&gt; whose &lt;a class="localLink" href="https://schema.org/eventAttendanceMode"&gt;eventAttendanceMode&lt;/a&gt; is &lt;a class="localLink" href="https://schema.org/OfflineEventAttendanceMode"&gt;OfflineEventAttendanceMode&lt;/a&gt; (or the offline aspects, in the case of a &lt;a class="localLink" href="https://schema.org/MixedEventAttendanceMode"&gt;MixedEventAttendanceMode&lt;/a&gt;).
        /// </summary>
        OneOrMany<int?> MaximumPhysicalAttendeeCapacity { get; set; }

        /// <summary>
        /// The maximum physical attendee capacity of an &lt;a class="localLink" href="https://schema.org/Event"&gt;Event&lt;/a&gt; whose &lt;a class="localLink" href="https://schema.org/eventAttendanceMode"&gt;eventAttendanceMode&lt;/a&gt; is &lt;a class="localLink" href="https://schema.org/OnlineEventAttendanceMode"&gt;OnlineEventAttendanceMode&lt;/a&gt; (or the online aspects, in the case of a &lt;a class="localLink" href="https://schema.org/MixedEventAttendanceMode"&gt;MixedEventAttendanceMode&lt;/a&gt;).
        /// </summary>
        OneOrMany<int?> MaximumVirtualAttendeeCapacity { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event. Use &lt;a class="localLink" href="https://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; to indicate the kind of transaction offered, i.e. sell, lease, etc. This property can also be used to describe a &lt;a class="localLink" href="https://schema.org/Demand"&gt;Demand&lt;/a&gt;. While this property is listed as expected on a number of common types, it can be used in others. In that case, using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.
        /// </summary>
        Values<IDemand, IOffer> Offers { get; set; }

        /// <summary>
        /// An organizer of an Event.
        /// </summary>
        Values<IOrganization, IPerson> Organizer { get; set; }

        /// <summary>
        /// A performer at the event&amp;#x2014;for example, a presenter, musician, musical group or actor.
        /// </summary>
        Values<IOrganization, IPerson> Performer { get; set; }

        /// <summary>
        /// Used in conjunction with eventStatus for rescheduled or cancelled events. This property contains the previously scheduled start date. For rescheduled events, the startDate property should be used for the newly scheduled start date. In the (rare) case of an event that has been postponed and rescheduled multiple times, this field may be repeated.
        /// </summary>
        Values<int?, DateTime?> PreviousStartDate { get; set; }

        /// <summary>
        /// The CreativeWork that captured all or part of this Event.
        /// </summary>
        OneOrMany<ICreativeWork> RecordedIn { get; set; }

        /// <summary>
        /// The number of attendee places for an event that remain unallocated.
        /// </summary>
        OneOrMany<int?> RemainingAttendeeCapacity { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        OneOrMany<IReview> Review { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        Values<IOrganization, IPerson> Sponsor { get; set; }

        /// <summary>
        /// The start date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> StartDate { get; set; }

        /// <summary>
        /// The end date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> EndDate { get; set; }

        /// <summary>
        /// An Event that is part of this event. For example, a conference event includes many presentations, each of which is a subEvent of the conference.
        /// </summary>
        OneOrMany<IEvent> SubEvent { get; set; }

        /// <summary>
        /// An event that this event is a part of. For example, a collection of individual music performances might each have a music festival as their superEvent.
        /// </summary>
        OneOrMany<IEvent> SuperEvent { get; set; }

        /// <summary>
        /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
        /// </summary>
        Values<IOrganization, IPerson> Translator { get; set; }

        /// <summary>
        /// The typical expected age range, e.g. '7-9', '11-'.
        /// </summary>
        OneOrMany<string> TypicalAgeRange { get; set; }

        /// <summary>
        /// A work featured in some event, e.g. exhibited in an ExhibitionEvent.
        ///        Specific subproperties are available for workPerformed (e.g. a play), or a workPresented (a Movie at a ScreeningEvent).
        /// </summary>
        OneOrMany<ICreativeWork> WorkFeatured { get; set; }

        /// <summary>
        /// A work performed in some event, for example a play performed in a TheaterEvent.
        /// </summary>
        OneOrMany<ICreativeWork> WorkPerformed { get; set; }
    }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the &lt;a class="localLink" href="https://schema.org/offers"&gt;offers&lt;/a&gt; property. Repeated events may be structured as separate Event objects.
    /// </summary>
    [DataContract]
    public partial class Event : Thing, IEvent, IEquatable<Event>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Event";

        /// <summary>
        /// The subject matter of the content.
        /// </summary>
        [DataMember(Name = "about", Order = 106)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> About { get; set; }

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 107)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Actor { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 108)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAggregateRating> AggregateRating { get; set; }

        /// <summary>
        /// A person or organization attending the event.
        /// </summary>
        [DataMember(Name = "attendee", Order = 109)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Attendee { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience", Order = 110)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAudience> Audience { get; set; }

        /// <summary>
        /// The person or organization who wrote a composition, or who is the composer of a work performed at some event.
        /// </summary>
        [DataMember(Name = "composer", Order = 111)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Composer { get; set; }

        /// <summary>
        /// A secondary contributor to the CreativeWork or Event.
        /// </summary>
        [DataMember(Name = "contributor", Order = 112)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Contributor { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 113)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Director { get; set; }

        /// <summary>
        /// The time admission will commence.
        /// </summary>
        [DataMember(Name = "doorTime", Order = 114)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<DateTimeOffset?, TimeSpan?> DoorTime { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration", Order = 115)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public OneOrMany<TimeSpan?> Duration { get; set; }

        /// <summary>
        /// An eventStatus of an event represents its status; particularly useful when an event is cancelled or rescheduled.
        /// </summary>
        [DataMember(Name = "eventStatus", Order = 116)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<EventStatusType?> EventStatus { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 117)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Funder { get; set; }

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="https://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "inLanguage", Order = 118)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ILanguage, string> InLanguage { get; set; }

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree", Order = 119)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> IsAccessibleForFree { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [DataMember(Name = "location", Order = 120)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPlace, IPostalAddress, string> Location { get; set; }

        /// <summary>
        /// The total number of individuals that may attend an event or venue.
        /// </summary>
        [DataMember(Name = "maximumAttendeeCapacity", Order = 121)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> MaximumAttendeeCapacity { get; set; }

        /// <summary>
        /// The maximum physical attendee capacity of an &lt;a class="localLink" href="https://schema.org/Event"&gt;Event&lt;/a&gt; whose &lt;a class="localLink" href="https://schema.org/eventAttendanceMode"&gt;eventAttendanceMode&lt;/a&gt; is &lt;a class="localLink" href="https://schema.org/OfflineEventAttendanceMode"&gt;OfflineEventAttendanceMode&lt;/a&gt; (or the offline aspects, in the case of a &lt;a class="localLink" href="https://schema.org/MixedEventAttendanceMode"&gt;MixedEventAttendanceMode&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "maximumPhysicalAttendeeCapacity", Order = 122)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> MaximumPhysicalAttendeeCapacity { get; set; }

        /// <summary>
        /// The maximum physical attendee capacity of an &lt;a class="localLink" href="https://schema.org/Event"&gt;Event&lt;/a&gt; whose &lt;a class="localLink" href="https://schema.org/eventAttendanceMode"&gt;eventAttendanceMode&lt;/a&gt; is &lt;a class="localLink" href="https://schema.org/OnlineEventAttendanceMode"&gt;OnlineEventAttendanceMode&lt;/a&gt; (or the online aspects, in the case of a &lt;a class="localLink" href="https://schema.org/MixedEventAttendanceMode"&gt;MixedEventAttendanceMode&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "maximumVirtualAttendeeCapacity", Order = 123)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> MaximumVirtualAttendeeCapacity { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event. Use &lt;a class="localLink" href="https://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; to indicate the kind of transaction offered, i.e. sell, lease, etc. This property can also be used to describe a &lt;a class="localLink" href="https://schema.org/Demand"&gt;Demand&lt;/a&gt;. While this property is listed as expected on a number of common types, it can be used in others. In that case, using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.
        /// </summary>
        [DataMember(Name = "offers", Order = 124)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IDemand, IOffer> Offers { get; set; }

        /// <summary>
        /// An organizer of an Event.
        /// </summary>
        [DataMember(Name = "organizer", Order = 125)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Organizer { get; set; }

        /// <summary>
        /// A performer at the event&amp;#x2014;for example, a presenter, musician, musical group or actor.
        /// </summary>
        [DataMember(Name = "performer", Order = 126)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Performer { get; set; }

        /// <summary>
        /// Used in conjunction with eventStatus for rescheduled or cancelled events. This property contains the previously scheduled start date. For rescheduled events, the startDate property should be used for the newly scheduled start date. In the (rare) case of an event that has been postponed and rescheduled multiple times, this field may be repeated.
        /// </summary>
        [DataMember(Name = "previousStartDate", Order = 127)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> PreviousStartDate { get; set; }

        /// <summary>
        /// The CreativeWork that captured all or part of this Event.
        /// </summary>
        [DataMember(Name = "recordedIn", Order = 128)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> RecordedIn { get; set; }

        /// <summary>
        /// The number of attendee places for an event that remain unallocated.
        /// </summary>
        [DataMember(Name = "remainingAttendeeCapacity", Order = 129)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> RemainingAttendeeCapacity { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 130)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IReview> Review { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 131)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Sponsor { get; set; }

        /// <summary>
        /// The start date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "startDate", Order = 132)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> StartDate { get; set; }

        /// <summary>
        /// The end date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "endDate", Order = 133)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> EndDate { get; set; }

        /// <summary>
        /// An Event that is part of this event. For example, a conference event includes many presentations, each of which is a subEvent of the conference.
        /// </summary>
        [DataMember(Name = "subEvent", Order = 134)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEvent> SubEvent { get; set; }

        /// <summary>
        /// An event that this event is a part of. For example, a collection of individual music performances might each have a music festival as their superEvent.
        /// </summary>
        [DataMember(Name = "superEvent", Order = 135)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEvent> SuperEvent { get; set; }

        /// <summary>
        /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
        /// </summary>
        [DataMember(Name = "translator", Order = 136)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Translator { get; set; }

        /// <summary>
        /// The typical expected age range, e.g. '7-9', '11-'.
        /// </summary>
        [DataMember(Name = "typicalAgeRange", Order = 137)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TypicalAgeRange { get; set; }

        /// <summary>
        /// A work featured in some event, e.g. exhibited in an ExhibitionEvent.
        ///        Specific subproperties are available for workPerformed (e.g. a play), or a workPresented (a Movie at a ScreeningEvent).
        /// </summary>
        [DataMember(Name = "workFeatured", Order = 138)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> WorkFeatured { get; set; }

        /// <summary>
        /// A work performed in some event, for example a play performed in a TheaterEvent.
        /// </summary>
        [DataMember(Name = "workPerformed", Order = 139)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> WorkPerformed { get; set; }

        /// <inheritdoc/>
        public bool Equals(Event other)
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
                this.About == other.About &&
                this.Actor == other.Actor &&
                this.AggregateRating == other.AggregateRating &&
                this.Attendee == other.Attendee &&
                this.Audience == other.Audience &&
                this.Composer == other.Composer &&
                this.Contributor == other.Contributor &&
                this.Director == other.Director &&
                this.DoorTime == other.DoorTime &&
                this.Duration == other.Duration &&
                this.EventStatus == other.EventStatus &&
                this.Funder == other.Funder &&
                this.InLanguage == other.InLanguage &&
                this.IsAccessibleForFree == other.IsAccessibleForFree &&
                this.Location == other.Location &&
                this.MaximumAttendeeCapacity == other.MaximumAttendeeCapacity &&
                this.MaximumPhysicalAttendeeCapacity == other.MaximumPhysicalAttendeeCapacity &&
                this.MaximumVirtualAttendeeCapacity == other.MaximumVirtualAttendeeCapacity &&
                this.Offers == other.Offers &&
                this.Organizer == other.Organizer &&
                this.Performer == other.Performer &&
                this.PreviousStartDate == other.PreviousStartDate &&
                this.RecordedIn == other.RecordedIn &&
                this.RemainingAttendeeCapacity == other.RemainingAttendeeCapacity &&
                this.Review == other.Review &&
                this.Sponsor == other.Sponsor &&
                this.StartDate == other.StartDate &&
                this.EndDate == other.EndDate &&
                this.SubEvent == other.SubEvent &&
                this.SuperEvent == other.SuperEvent &&
                this.Translator == other.Translator &&
                this.TypicalAgeRange == other.TypicalAgeRange &&
                this.WorkFeatured == other.WorkFeatured &&
                this.WorkPerformed == other.WorkPerformed &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Event);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.About)
            .And(this.Actor)
            .And(this.AggregateRating)
            .And(this.Attendee)
            .And(this.Audience)
            .And(this.Composer)
            .And(this.Contributor)
            .And(this.Director)
            .And(this.DoorTime)
            .And(this.Duration)
            .And(this.EventStatus)
            .And(this.Funder)
            .And(this.InLanguage)
            .And(this.IsAccessibleForFree)
            .And(this.Location)
            .And(this.MaximumAttendeeCapacity)
            .And(this.MaximumPhysicalAttendeeCapacity)
            .And(this.MaximumVirtualAttendeeCapacity)
            .And(this.Offers)
            .And(this.Organizer)
            .And(this.Performer)
            .And(this.PreviousStartDate)
            .And(this.RecordedIn)
            .And(this.RemainingAttendeeCapacity)
            .And(this.Review)
            .And(this.Sponsor)
            .And(this.StartDate)
            .And(this.EndDate)
            .And(this.SubEvent)
            .And(this.SuperEvent)
            .And(this.Translator)
            .And(this.TypicalAgeRange)
            .And(this.WorkFeatured)
            .And(this.WorkPerformed)
            .And(base.GetHashCode());
    }
}
