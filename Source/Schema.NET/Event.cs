namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival...
    /// </summary>
    [DataContract]
    public class Event : Thing
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Event";

        /// <summary>
        /// The subject matter of the content.
        /// </summary>
        [DataMember(Name = "about")]
        public Thing About { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder")]
        public object Funder { get; protected set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [IgnoreDataMember]
        public Organization FunderOrganization
        {
            get => this.Funder as Organization;
            set => this.Funder = value;
        }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [IgnoreDataMember]
        public Person FunderPerson
        {
            get => this.Funder as Person;
            set => this.Funder = value;
        }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor")]
        public object Sponsor { get; protected set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [IgnoreDataMember]
        public Organization SponsorOrganization
        {
            get => this.Sponsor as Organization;
            set => this.Sponsor = value;
        }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [IgnoreDataMember]
        public Person SponsorPerson
        {
            get => this.Sponsor as Person;
            set => this.Sponsor = value;
        }

        /// <summary>
        /// A work featured in some event, e.g. exhibited in an ExhibitionEvent.
        ///        Specific subproperties are available for workPerformed (e.g. a play), or a workPresented (a Movie at a ScreeningEvent).
        /// </summary>
        [DataMember(Name = "workFeatured")]
        public CreativeWork WorkFeatured { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience")]
        public Audience Audience { get; set; }

        /// <summary>
        /// The number of attendee places for an event that remain unallocated.
        /// </summary>
        [DataMember(Name = "remainingAttendeeCapacity")]
        public int RemainingAttendeeCapacity { get; set; }

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor")]
        public Person Actor { get; set; }

        /// <summary>
        /// The end date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "endDate")]
        public DateTimeOffset EndDate { get; set; }

        /// <summary>
        /// The time admission will commence.
        /// </summary>
        [DataMember(Name = "doorTime")]
        public DateTimeOffset DoorTime { get; set; }

        /// <summary>
        /// A secondary contributor to the CreativeWork or Event.
        /// </summary>
        [DataMember(Name = "contributor")]
        public object Contributor { get; protected set; }

        /// <summary>
        /// A secondary contributor to the CreativeWork or Event.
        /// </summary>
        [IgnoreDataMember]
        public Person ContributorPerson
        {
            get => this.Contributor as Person;
            set => this.Contributor = value;
        }

        /// <summary>
        /// A secondary contributor to the CreativeWork or Event.
        /// </summary>
        [IgnoreDataMember]
        public Organization ContributorOrganization
        {
            get => this.Contributor as Organization;
            set => this.Contributor = value;
        }

        /// <summary>
        /// The total number of individuals that may attend an event or venue.
        /// </summary>
        [DataMember(Name = "maximumAttendeeCapacity")]
        public int MaximumAttendeeCapacity { get; set; }

        /// <summary>
        /// The typical expected age range, e.g. '7-9', '11-'.
        /// </summary>
        [DataMember(Name = "typicalAgeRange")]
        public string TypicalAgeRange { get; set; }

        /// <summary>
        /// An organizer of an Event.
        /// </summary>
        [DataMember(Name = "organizer")]
        public object Organizer { get; protected set; }

        /// <summary>
        /// An organizer of an Event.
        /// </summary>
        [IgnoreDataMember]
        public Organization OrganizerOrganization
        {
            get => this.Organizer as Organization;
            set => this.Organizer = value;
        }

        /// <summary>
        /// An organizer of an Event.
        /// </summary>
        [IgnoreDataMember]
        public Person OrganizerPerson
        {
            get => this.Organizer as Person;
            set => this.Organizer = value;
        }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating")]
        public AggregateRating AggregateRating { get; set; }

        /// <summary>
        /// An Event that is part of this event. For example, a conference event includes many presentations, each of which is a subEvent of the conference.
        /// </summary>
        [DataMember(Name = "subEvent")]
        public Event SubEvent { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers")]
        public Offer Offers { get; set; }

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "inLanguage")]
        public object InLanguage { get; protected set; }

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public Language InLanguageLanguage
        {
            get => this.InLanguage as Language;
            set => this.InLanguage = value;
        }

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public string InLanguageText
        {
            get => this.InLanguage as string;
            set => this.InLanguage = value;
        }

        /// <summary>
        /// A person or organization attending the event.
        /// </summary>
        [DataMember(Name = "attendee")]
        public object Attendee { get; protected set; }

        /// <summary>
        /// A person or organization attending the event.
        /// </summary>
        [IgnoreDataMember]
        public Person AttendeePerson
        {
            get => this.Attendee as Person;
            set => this.Attendee = value;
        }

        /// <summary>
        /// A person or organization attending the event.
        /// </summary>
        [IgnoreDataMember]
        public Organization AttendeeOrganization
        {
            get => this.Attendee as Organization;
            set => this.Attendee = value;
        }

        /// <summary>
        /// A work performed in some event, for example a play performed in a TheaterEvent.
        /// </summary>
        [DataMember(Name = "workPerformed")]
        public CreativeWork WorkPerformed { get; set; }

        /// <summary>
        /// An eventStatus of an event represents its status; particularly useful when an event is cancelled or rescheduled.
        /// </summary>
        [DataMember(Name = "eventStatus")]
        public EventStatusType EventStatus { get; set; }

        /// <summary>
        /// The start date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "startDate")]
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director")]
        public Person Director { get; set; }

        /// <summary>
        /// An event that this event is a part of. For example, a collection of individual music performances might each have a music festival as their superEvent.
        /// </summary>
        [DataMember(Name = "superEvent")]
        public Event SuperEvent { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration")]
        public Duration Duration { get; set; }

        /// <summary>
        /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
        /// </summary>
        [DataMember(Name = "translator")]
        public object Translator { get; protected set; }

        /// <summary>
        /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
        /// </summary>
        [IgnoreDataMember]
        public Person TranslatorPerson
        {
            get => this.Translator as Person;
            set => this.Translator = value;
        }

        /// <summary>
        /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
        /// </summary>
        [IgnoreDataMember]
        public Organization TranslatorOrganization
        {
            get => this.Translator as Organization;
            set => this.Translator = value;
        }

        /// <summary>
        /// Used in conjunction with eventStatus for rescheduled or cancelled events. This property contains the previously scheduled start date. For rescheduled events, the startDate property should be used for the newly scheduled start date. In the (rare) case of an event that has been postponed and rescheduled multiple times, this field may be repeated.
        /// </summary>
        [DataMember(Name = "previousStartDate")]
        public DateTimeOffset PreviousStartDate { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review")]
        public Review Review { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [DataMember(Name = "location")]
        public object Location { get; protected set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [IgnoreDataMember]
        public Place LocationPlace
        {
            get => this.Location as Place;
            set => this.Location = value;
        }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [IgnoreDataMember]
        public string LocationText
        {
            get => this.Location as string;
            set => this.Location = value;
        }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [IgnoreDataMember]
        public PostalAddress LocationPostalAddress
        {
            get => this.Location as PostalAddress;
            set => this.Location = value;
        }

        /// <summary>
        /// The CreativeWork that captured all or part of this Event.
        /// </summary>
        [DataMember(Name = "recordedIn")]
        public CreativeWork RecordedIn { get; set; }

        /// <summary>
        /// The person or organization who wrote a composition, or who is the composer of a work performed at some event.
        /// </summary>
        [DataMember(Name = "composer")]
        public object Composer { get; protected set; }

        /// <summary>
        /// The person or organization who wrote a composition, or who is the composer of a work performed at some event.
        /// </summary>
        [IgnoreDataMember]
        public Organization ComposerOrganization
        {
            get => this.Composer as Organization;
            set => this.Composer = value;
        }

        /// <summary>
        /// The person or organization who wrote a composition, or who is the composer of a work performed at some event.
        /// </summary>
        [IgnoreDataMember]
        public Person ComposerPerson
        {
            get => this.Composer as Person;
            set => this.Composer = value;
        }

        /// <summary>
        /// A flag to signal that the publication is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree")]
        public virtual bool IsAccessibleForFree { get; set; }

        /// <summary>
        /// A performer at the event&amp;#x2014;for example, a presenter, musician, musical group or actor.
        /// </summary>
        [DataMember(Name = "performer")]
        public object Performer { get; protected set; }

        /// <summary>
        /// A performer at the event&amp;#x2014;for example, a presenter, musician, musical group or actor.
        /// </summary>
        [IgnoreDataMember]
        public Organization PerformerOrganization
        {
            get => this.Performer as Organization;
            set => this.Performer = value;
        }

        /// <summary>
        /// A performer at the event&amp;#x2014;for example, a presenter, musician, musical group or actor.
        /// </summary>
        [IgnoreDataMember]
        public Person PerformerPerson
        {
            get => this.Performer as Person;
            set => this.Performer = value;
        }
    }
}
