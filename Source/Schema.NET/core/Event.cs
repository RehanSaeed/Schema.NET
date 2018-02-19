using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the &lt;a class="localLink" href="http://schema.org/offers"&gt;offers&lt;/a&gt; property. Repeated events may be structured as separate Event objects.
    /// </summary>
    [DataContract]
    public partial class Event : Thing
    {
        public interface IAttendee : IWrapper { }
        public interface IAttendee<T> : IAttendee { new T Data { get; set; } }
        public class AttendeeOrganization : IAttendee<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public AttendeeOrganization () { }
            public AttendeeOrganization (Organization data) { Data = data; }
            public static implicit operator AttendeeOrganization (Organization data) { return new AttendeeOrganization (data); }
        }

        public class AttendeePerson : IAttendee<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public AttendeePerson () { }
            public AttendeePerson (Person data) { Data = data; }
            public static implicit operator AttendeePerson (Person data) { return new AttendeePerson (data); }
        }


        public interface IComposer : IWrapper { }
        public interface IComposer<T> : IComposer { new T Data { get; set; } }
        public class ComposerOrganization : IComposer<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public ComposerOrganization () { }
            public ComposerOrganization (Organization data) { Data = data; }
            public static implicit operator ComposerOrganization (Organization data) { return new ComposerOrganization (data); }
        }

        public class ComposerPerson : IComposer<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public ComposerPerson () { }
            public ComposerPerson (Person data) { Data = data; }
            public static implicit operator ComposerPerson (Person data) { return new ComposerPerson (data); }
        }


        public interface IContributor : IWrapper { }
        public interface IContributor<T> : IContributor { new T Data { get; set; } }
        public class ContributorOrganization : IContributor<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public ContributorOrganization () { }
            public ContributorOrganization (Organization data) { Data = data; }
            public static implicit operator ContributorOrganization (Organization data) { return new ContributorOrganization (data); }
        }

        public class ContributorPerson : IContributor<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public ContributorPerson () { }
            public ContributorPerson (Person data) { Data = data; }
            public static implicit operator ContributorPerson (Person data) { return new ContributorPerson (data); }
        }


        public interface IFunder : IWrapper { }
        public interface IFunder<T> : IFunder { new T Data { get; set; } }
        public class FunderOrganization : IFunder<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public FunderOrganization () { }
            public FunderOrganization (Organization data) { Data = data; }
            public static implicit operator FunderOrganization (Organization data) { return new FunderOrganization (data); }
        }

        public class FunderPerson : IFunder<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public FunderPerson () { }
            public FunderPerson (Person data) { Data = data; }
            public static implicit operator FunderPerson (Person data) { return new FunderPerson (data); }
        }


        public interface IInLanguage : IWrapper { }
        public interface IInLanguage<T> : IInLanguage { new T Data { get; set; } }
        public class InLanguageLanguage : IInLanguage<Language>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Language) value; } }
            public virtual Language Data { get; set; }
            public InLanguageLanguage () { }
            public InLanguageLanguage (Language data) { Data = data; }
            public static implicit operator InLanguageLanguage (Language data) { return new InLanguageLanguage (data); }
        }

        public class InLanguagestring : IInLanguage<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public InLanguagestring () { }
            public InLanguagestring (string data) { Data = data; }
            public static implicit operator InLanguagestring (string data) { return new InLanguagestring (data); }
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


        public interface IOrganizer : IWrapper { }
        public interface IOrganizer<T> : IOrganizer { new T Data { get; set; } }
        public class OrganizerOrganization : IOrganizer<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public OrganizerOrganization () { }
            public OrganizerOrganization (Organization data) { Data = data; }
            public static implicit operator OrganizerOrganization (Organization data) { return new OrganizerOrganization (data); }
        }

        public class OrganizerPerson : IOrganizer<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public OrganizerPerson () { }
            public OrganizerPerson (Person data) { Data = data; }
            public static implicit operator OrganizerPerson (Person data) { return new OrganizerPerson (data); }
        }


        public interface IPerformer : IWrapper { }
        public interface IPerformer<T> : IPerformer { new T Data { get; set; } }
        public class PerformerOrganization : IPerformer<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public PerformerOrganization () { }
            public PerformerOrganization (Organization data) { Data = data; }
            public static implicit operator PerformerOrganization (Organization data) { return new PerformerOrganization (data); }
        }

        public class PerformerPerson : IPerformer<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public PerformerPerson () { }
            public PerformerPerson (Person data) { Data = data; }
            public static implicit operator PerformerPerson (Person data) { return new PerformerPerson (data); }
        }


        public interface ISponsor : IWrapper { }
        public interface ISponsor<T> : ISponsor { new T Data { get; set; } }
        public class SponsorOrganization : ISponsor<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public SponsorOrganization () { }
            public SponsorOrganization (Organization data) { Data = data; }
            public static implicit operator SponsorOrganization (Organization data) { return new SponsorOrganization (data); }
        }

        public class SponsorPerson : ISponsor<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public SponsorPerson () { }
            public SponsorPerson (Person data) { Data = data; }
            public static implicit operator SponsorPerson (Person data) { return new SponsorPerson (data); }
        }


        public interface ITranslator : IWrapper { }
        public interface ITranslator<T> : ITranslator { new T Data { get; set; } }
        public class TranslatorOrganization : ITranslator<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public TranslatorOrganization () { }
            public TranslatorOrganization (Organization data) { Data = data; }
            public static implicit operator TranslatorOrganization (Organization data) { return new TranslatorOrganization (data); }
        }

        public class TranslatorPerson : ITranslator<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public TranslatorPerson () { }
            public TranslatorPerson (Person data) { Data = data; }
            public static implicit operator TranslatorPerson (Person data) { return new TranslatorPerson (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Event";

        /// <summary>
        /// The subject matter of the content.
        /// </summary>
        [DataMember(Name = "about", Order = 106)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? About { get; set; } 

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 107)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Actor { get; set; } 

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 108)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AggregateRating>? AggregateRating { get; set; } 

        /// <summary>
        /// A person or organization attending the event.
        /// </summary>
        [DataMember(Name = "attendee", Order = 109)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAttendee>? Attendee { get; set; } //Organization, Person

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience", Order = 110)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Audience>? Audience { get; set; } 

        /// <summary>
        /// The person or organization who wrote a composition, or who is the composer of a work performed at some event.
        /// </summary>
        [DataMember(Name = "composer", Order = 111)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IComposer>? Composer { get; set; } //Organization, Person

        /// <summary>
        /// A secondary contributor to the CreativeWork or Event.
        /// </summary>
        [DataMember(Name = "contributor", Order = 112)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IContributor>? Contributor { get; set; } //Organization, Person

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 113)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Director { get; set; } 

        /// <summary>
        /// The time admission will commence.
        /// </summary>
        [DataMember(Name = "doorTime", Order = 114)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? DoorTime { get; set; } 

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration", Order = 115)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan>? Duration { get; set; } 

        /// <summary>
        /// An eventStatus of an event represents its status; particularly useful when an event is cancelled or rescheduled.
        /// </summary>
        [DataMember(Name = "eventStatus", Order = 116)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<EventStatusType>? EventStatus { get; set; } 

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 117)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IFunder>? Funder { get; set; } //Organization, Person

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "inLanguage", Order = 118)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IInLanguage>? InLanguage { get; set; } //Language, string

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree", Order = 119)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<bool>? IsAccessibleForFree { get; set; } 

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [DataMember(Name = "location", Order = 120)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ILocation>? Location { get; set; } //Place, PostalAddress, string

        /// <summary>
        /// The total number of individuals that may attend an event or venue.
        /// </summary>
        [DataMember(Name = "maximumAttendeeCapacity", Order = 121)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int>? MaximumAttendeeCapacity { get; set; } 

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers", Order = 122)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Offer>? Offers { get; set; } 

        /// <summary>
        /// An organizer of an Event.
        /// </summary>
        [DataMember(Name = "organizer", Order = 123)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IOrganizer>? Organizer { get; set; } //Organization, Person

        /// <summary>
        /// A performer at the event&amp;#x2014;for example, a presenter, musician, musical group or actor.
        /// </summary>
        [DataMember(Name = "performer", Order = 124)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPerformer>? Performer { get; set; } //Organization, Person

        /// <summary>
        /// Used in conjunction with eventStatus for rescheduled or cancelled events. This property contains the previously scheduled start date. For rescheduled events, the startDate property should be used for the newly scheduled start date. In the (rare) case of an event that has been postponed and rescheduled multiple times, this field may be repeated.
        /// </summary>
        [DataMember(Name = "previousStartDate", Order = 125)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? PreviousStartDate { get; set; } 

        /// <summary>
        /// The CreativeWork that captured all or part of this Event.
        /// </summary>
        [DataMember(Name = "recordedIn", Order = 126)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? RecordedIn { get; set; } 

        /// <summary>
        /// The number of attendee places for an event that remain unallocated.
        /// </summary>
        [DataMember(Name = "remainingAttendeeCapacity", Order = 127)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int>? RemainingAttendeeCapacity { get; set; } 

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 128)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Review>? Review { get; set; } 

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 129)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ISponsor>? Sponsor { get; set; } //Organization, Person

        /// <summary>
        /// The start date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "startDate", Order = 130)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? StartDate { get; set; } 

        /// <summary>
        /// The end date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "endDate", Order = 131)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? EndDate { get; set; } 

        /// <summary>
        /// An Event that is part of this event. For example, a conference event includes many presentations, each of which is a subEvent of the conference.
        /// </summary>
        [DataMember(Name = "subEvent", Order = 132)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Event>? SubEvent { get; set; } 

        /// <summary>
        /// An event that this event is a part of. For example, a collection of individual music performances might each have a music festival as their superEvent.
        /// </summary>
        [DataMember(Name = "superEvent", Order = 133)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Event>? SuperEvent { get; set; } 

        /// <summary>
        /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
        /// </summary>
        [DataMember(Name = "translator", Order = 134)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ITranslator>? Translator { get; set; } //Organization, Person

        /// <summary>
        /// The typical expected age range, e.g. '7-9', '11-'.
        /// </summary>
        [DataMember(Name = "typicalAgeRange", Order = 135)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? TypicalAgeRange { get; set; } 

        /// <summary>
        /// A work featured in some event, e.g. exhibited in an ExhibitionEvent.
        ///        Specific subproperties are available for workPerformed (e.g. a play), or a workPresented (a Movie at a ScreeningEvent).
        /// </summary>
        [DataMember(Name = "workFeatured", Order = 136)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? WorkFeatured { get; set; } 

        /// <summary>
        /// A work performed in some event, for example a play performed in a TheaterEvent.
        /// </summary>
        [DataMember(Name = "workPerformed", Order = 137)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? WorkPerformed { get; set; } 
    }
}
