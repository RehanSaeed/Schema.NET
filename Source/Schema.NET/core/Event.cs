namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the &lt;a class="localLink" href="http://schema.org/offers"&gt;offers&lt;/a&gt; property. Repeated events may be structured as separate Event objects.
    /// </summary>
    [DataContract]
    public partial class Event : Thing
    {
        public interface IAbout : IValue {}
        public interface IAbout<T> : IAbout { new T Value { get; } }
        public class OneOrManyAbout : OneOrMany<IAbout>
        {
            public OneOrManyAbout(IAbout item) : base(item) { }
            public OneOrManyAbout(IEnumerable<IAbout> items) : base(items) { }
            public static implicit operator OneOrManyAbout (Thing value) { return new OneOrManyAbout (new AboutThing (value)); }
            public static implicit operator OneOrManyAbout (Thing[] values) { return new OneOrManyAbout (values.Select(v => (IAbout) new AboutThing (v))); }
            public static implicit operator OneOrManyAbout (List<Thing> values) { return new OneOrManyAbout (values.Select(v => (IAbout) new AboutThing (v))); }
        }
        public struct AboutThing : IAbout<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public AboutThing (Thing value) { Value = value; }
            public static implicit operator AboutThing (Thing value) { return new AboutThing (value); }
        }

        public interface IActor : IValue {}
        public interface IActor<T> : IActor { new T Value { get; } }
        public class OneOrManyActor : OneOrMany<IActor>
        {
            public OneOrManyActor(IActor item) : base(item) { }
            public OneOrManyActor(IEnumerable<IActor> items) : base(items) { }
            public static implicit operator OneOrManyActor (Person value) { return new OneOrManyActor (new ActorPerson (value)); }
            public static implicit operator OneOrManyActor (Person[] values) { return new OneOrManyActor (values.Select(v => (IActor) new ActorPerson (v))); }
            public static implicit operator OneOrManyActor (List<Person> values) { return new OneOrManyActor (values.Select(v => (IActor) new ActorPerson (v))); }
        }
        public struct ActorPerson : IActor<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ActorPerson (Person value) { Value = value; }
            public static implicit operator ActorPerson (Person value) { return new ActorPerson (value); }
        }

        public interface IAggregateRating : IValue {}
        public interface IAggregateRating<T> : IAggregateRating { new T Value { get; } }
        public class OneOrManyAggregateRating : OneOrMany<IAggregateRating>
        {
            public OneOrManyAggregateRating(IAggregateRating item) : base(item) { }
            public OneOrManyAggregateRating(IEnumerable<IAggregateRating> items) : base(items) { }
            public static implicit operator OneOrManyAggregateRating (AggregateRating value) { return new OneOrManyAggregateRating (new AggregateRatingAggregateRating (value)); }
            public static implicit operator OneOrManyAggregateRating (AggregateRating[] values) { return new OneOrManyAggregateRating (values.Select(v => (IAggregateRating) new AggregateRatingAggregateRating (v))); }
            public static implicit operator OneOrManyAggregateRating (List<AggregateRating> values) { return new OneOrManyAggregateRating (values.Select(v => (IAggregateRating) new AggregateRatingAggregateRating (v))); }
        }
        public struct AggregateRatingAggregateRating : IAggregateRating<AggregateRating>
        {
            object IValue.Value => this.Value;
            public AggregateRating Value { get; }
            public AggregateRatingAggregateRating (AggregateRating value) { Value = value; }
            public static implicit operator AggregateRatingAggregateRating (AggregateRating value) { return new AggregateRatingAggregateRating (value); }
        }

        public interface IAttendee : IValue {}
        public interface IAttendee<T> : IAttendee { new T Value { get; } }
        public class OneOrManyAttendee : OneOrMany<IAttendee>
        {
            public OneOrManyAttendee(IAttendee item) : base(item) { }
            public OneOrManyAttendee(IEnumerable<IAttendee> items) : base(items) { }
            public static implicit operator OneOrManyAttendee (Organization value) { return new OneOrManyAttendee (new AttendeeOrganization (value)); }
            public static implicit operator OneOrManyAttendee (Organization[] values) { return new OneOrManyAttendee (values.Select(v => (IAttendee) new AttendeeOrganization (v))); }
            public static implicit operator OneOrManyAttendee (List<Organization> values) { return new OneOrManyAttendee (values.Select(v => (IAttendee) new AttendeeOrganization (v))); }
            public static implicit operator OneOrManyAttendee (Person value) { return new OneOrManyAttendee (new AttendeePerson (value)); }
            public static implicit operator OneOrManyAttendee (Person[] values) { return new OneOrManyAttendee (values.Select(v => (IAttendee) new AttendeePerson (v))); }
            public static implicit operator OneOrManyAttendee (List<Person> values) { return new OneOrManyAttendee (values.Select(v => (IAttendee) new AttendeePerson (v))); }
        }
        public struct AttendeeOrganization : IAttendee<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public AttendeeOrganization (Organization value) { Value = value; }
            public static implicit operator AttendeeOrganization (Organization value) { return new AttendeeOrganization (value); }
        }
        public struct AttendeePerson : IAttendee<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public AttendeePerson (Person value) { Value = value; }
            public static implicit operator AttendeePerson (Person value) { return new AttendeePerson (value); }
        }

        public interface IAudience : IValue {}
        public interface IAudience<T> : IAudience { new T Value { get; } }
        public class OneOrManyAudience : OneOrMany<IAudience>
        {
            public OneOrManyAudience(IAudience item) : base(item) { }
            public OneOrManyAudience(IEnumerable<IAudience> items) : base(items) { }
            public static implicit operator OneOrManyAudience (Audience value) { return new OneOrManyAudience (new AudienceAudience (value)); }
            public static implicit operator OneOrManyAudience (Audience[] values) { return new OneOrManyAudience (values.Select(v => (IAudience) new AudienceAudience (v))); }
            public static implicit operator OneOrManyAudience (List<Audience> values) { return new OneOrManyAudience (values.Select(v => (IAudience) new AudienceAudience (v))); }
        }
        public struct AudienceAudience : IAudience<Audience>
        {
            object IValue.Value => this.Value;
            public Audience Value { get; }
            public AudienceAudience (Audience value) { Value = value; }
            public static implicit operator AudienceAudience (Audience value) { return new AudienceAudience (value); }
        }

        public interface IComposer : IValue {}
        public interface IComposer<T> : IComposer { new T Value { get; } }
        public class OneOrManyComposer : OneOrMany<IComposer>
        {
            public OneOrManyComposer(IComposer item) : base(item) { }
            public OneOrManyComposer(IEnumerable<IComposer> items) : base(items) { }
            public static implicit operator OneOrManyComposer (Organization value) { return new OneOrManyComposer (new ComposerOrganization (value)); }
            public static implicit operator OneOrManyComposer (Organization[] values) { return new OneOrManyComposer (values.Select(v => (IComposer) new ComposerOrganization (v))); }
            public static implicit operator OneOrManyComposer (List<Organization> values) { return new OneOrManyComposer (values.Select(v => (IComposer) new ComposerOrganization (v))); }
            public static implicit operator OneOrManyComposer (Person value) { return new OneOrManyComposer (new ComposerPerson (value)); }
            public static implicit operator OneOrManyComposer (Person[] values) { return new OneOrManyComposer (values.Select(v => (IComposer) new ComposerPerson (v))); }
            public static implicit operator OneOrManyComposer (List<Person> values) { return new OneOrManyComposer (values.Select(v => (IComposer) new ComposerPerson (v))); }
        }
        public struct ComposerOrganization : IComposer<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public ComposerOrganization (Organization value) { Value = value; }
            public static implicit operator ComposerOrganization (Organization value) { return new ComposerOrganization (value); }
        }
        public struct ComposerPerson : IComposer<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ComposerPerson (Person value) { Value = value; }
            public static implicit operator ComposerPerson (Person value) { return new ComposerPerson (value); }
        }

        public interface IContributor : IValue {}
        public interface IContributor<T> : IContributor { new T Value { get; } }
        public class OneOrManyContributor : OneOrMany<IContributor>
        {
            public OneOrManyContributor(IContributor item) : base(item) { }
            public OneOrManyContributor(IEnumerable<IContributor> items) : base(items) { }
            public static implicit operator OneOrManyContributor (Organization value) { return new OneOrManyContributor (new ContributorOrganization (value)); }
            public static implicit operator OneOrManyContributor (Organization[] values) { return new OneOrManyContributor (values.Select(v => (IContributor) new ContributorOrganization (v))); }
            public static implicit operator OneOrManyContributor (List<Organization> values) { return new OneOrManyContributor (values.Select(v => (IContributor) new ContributorOrganization (v))); }
            public static implicit operator OneOrManyContributor (Person value) { return new OneOrManyContributor (new ContributorPerson (value)); }
            public static implicit operator OneOrManyContributor (Person[] values) { return new OneOrManyContributor (values.Select(v => (IContributor) new ContributorPerson (v))); }
            public static implicit operator OneOrManyContributor (List<Person> values) { return new OneOrManyContributor (values.Select(v => (IContributor) new ContributorPerson (v))); }
        }
        public struct ContributorOrganization : IContributor<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public ContributorOrganization (Organization value) { Value = value; }
            public static implicit operator ContributorOrganization (Organization value) { return new ContributorOrganization (value); }
        }
        public struct ContributorPerson : IContributor<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ContributorPerson (Person value) { Value = value; }
            public static implicit operator ContributorPerson (Person value) { return new ContributorPerson (value); }
        }

        public interface IDirector : IValue {}
        public interface IDirector<T> : IDirector { new T Value { get; } }
        public class OneOrManyDirector : OneOrMany<IDirector>
        {
            public OneOrManyDirector(IDirector item) : base(item) { }
            public OneOrManyDirector(IEnumerable<IDirector> items) : base(items) { }
            public static implicit operator OneOrManyDirector (Person value) { return new OneOrManyDirector (new DirectorPerson (value)); }
            public static implicit operator OneOrManyDirector (Person[] values) { return new OneOrManyDirector (values.Select(v => (IDirector) new DirectorPerson (v))); }
            public static implicit operator OneOrManyDirector (List<Person> values) { return new OneOrManyDirector (values.Select(v => (IDirector) new DirectorPerson (v))); }
        }
        public struct DirectorPerson : IDirector<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public DirectorPerson (Person value) { Value = value; }
            public static implicit operator DirectorPerson (Person value) { return new DirectorPerson (value); }
        }

        public interface IDoorTime : IValue {}
        public interface IDoorTime<T> : IDoorTime { new T Value { get; } }
        public class OneOrManyDoorTime : OneOrMany<IDoorTime>
        {
            public OneOrManyDoorTime(IDoorTime item) : base(item) { }
            public OneOrManyDoorTime(IEnumerable<IDoorTime> items) : base(items) { }
            public static implicit operator OneOrManyDoorTime (DateTimeOffset value) { return new OneOrManyDoorTime (new DoorTimeDateTimeOffset (value)); }
            public static implicit operator OneOrManyDoorTime (DateTimeOffset[] values) { return new OneOrManyDoorTime (values.Select(v => (IDoorTime) new DoorTimeDateTimeOffset (v))); }
            public static implicit operator OneOrManyDoorTime (List<DateTimeOffset> values) { return new OneOrManyDoorTime (values.Select(v => (IDoorTime) new DoorTimeDateTimeOffset (v))); }
        }
        public struct DoorTimeDateTimeOffset : IDoorTime<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public DoorTimeDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator DoorTimeDateTimeOffset (DateTimeOffset value) { return new DoorTimeDateTimeOffset (value); }
        }

        public interface IDuration : IValue {}
        public interface IDuration<T> : IDuration { new T Value { get; } }
        public class OneOrManyDuration : OneOrMany<IDuration>
        {
            public OneOrManyDuration(IDuration item) : base(item) { }
            public OneOrManyDuration(IEnumerable<IDuration> items) : base(items) { }
            public static implicit operator OneOrManyDuration (TimeSpan value) { return new OneOrManyDuration (new DurationTimeSpan (value)); }
            public static implicit operator OneOrManyDuration (TimeSpan[] values) { return new OneOrManyDuration (values.Select(v => (IDuration) new DurationTimeSpan (v))); }
            public static implicit operator OneOrManyDuration (List<TimeSpan> values) { return new OneOrManyDuration (values.Select(v => (IDuration) new DurationTimeSpan (v))); }
        }
        public struct DurationTimeSpan : IDuration<TimeSpan>
        {
            object IValue.Value => this.Value;
            public TimeSpan Value { get; }
            public DurationTimeSpan (TimeSpan value) { Value = value; }
            public static implicit operator DurationTimeSpan (TimeSpan value) { return new DurationTimeSpan (value); }
        }

        public interface IEventStatus : IValue {}
        public interface IEventStatus<T> : IEventStatus { new T Value { get; } }
        public class OneOrManyEventStatus : OneOrMany<IEventStatus>
        {
            public OneOrManyEventStatus(IEventStatus item) : base(item) { }
            public OneOrManyEventStatus(IEnumerable<IEventStatus> items) : base(items) { }
            public static implicit operator OneOrManyEventStatus (EventStatusType value) { return new OneOrManyEventStatus (new EventStatusEventStatusType (value)); }
            public static implicit operator OneOrManyEventStatus (EventStatusType[] values) { return new OneOrManyEventStatus (values.Select(v => (IEventStatus) new EventStatusEventStatusType (v))); }
            public static implicit operator OneOrManyEventStatus (List<EventStatusType> values) { return new OneOrManyEventStatus (values.Select(v => (IEventStatus) new EventStatusEventStatusType (v))); }
        }
        public struct EventStatusEventStatusType : IEventStatus<EventStatusType>
        {
            object IValue.Value => this.Value;
            public EventStatusType Value { get; }
            public EventStatusEventStatusType (EventStatusType value) { Value = value; }
            public static implicit operator EventStatusEventStatusType (EventStatusType value) { return new EventStatusEventStatusType (value); }
        }

        public interface IFunder : IValue {}
        public interface IFunder<T> : IFunder { new T Value { get; } }
        public class OneOrManyFunder : OneOrMany<IFunder>
        {
            public OneOrManyFunder(IFunder item) : base(item) { }
            public OneOrManyFunder(IEnumerable<IFunder> items) : base(items) { }
            public static implicit operator OneOrManyFunder (Organization value) { return new OneOrManyFunder (new FunderOrganization (value)); }
            public static implicit operator OneOrManyFunder (Organization[] values) { return new OneOrManyFunder (values.Select(v => (IFunder) new FunderOrganization (v))); }
            public static implicit operator OneOrManyFunder (List<Organization> values) { return new OneOrManyFunder (values.Select(v => (IFunder) new FunderOrganization (v))); }
            public static implicit operator OneOrManyFunder (Person value) { return new OneOrManyFunder (new FunderPerson (value)); }
            public static implicit operator OneOrManyFunder (Person[] values) { return new OneOrManyFunder (values.Select(v => (IFunder) new FunderPerson (v))); }
            public static implicit operator OneOrManyFunder (List<Person> values) { return new OneOrManyFunder (values.Select(v => (IFunder) new FunderPerson (v))); }
        }
        public struct FunderOrganization : IFunder<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public FunderOrganization (Organization value) { Value = value; }
            public static implicit operator FunderOrganization (Organization value) { return new FunderOrganization (value); }
        }
        public struct FunderPerson : IFunder<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public FunderPerson (Person value) { Value = value; }
            public static implicit operator FunderPerson (Person value) { return new FunderPerson (value); }
        }

        public interface IInLanguage : IValue {}
        public interface IInLanguage<T> : IInLanguage { new T Value { get; } }
        public class OneOrManyInLanguage : OneOrMany<IInLanguage>
        {
            public OneOrManyInLanguage(IInLanguage item) : base(item) { }
            public OneOrManyInLanguage(IEnumerable<IInLanguage> items) : base(items) { }
            public static implicit operator OneOrManyInLanguage (Language value) { return new OneOrManyInLanguage (new InLanguageLanguage (value)); }
            public static implicit operator OneOrManyInLanguage (Language[] values) { return new OneOrManyInLanguage (values.Select(v => (IInLanguage) new InLanguageLanguage (v))); }
            public static implicit operator OneOrManyInLanguage (List<Language> values) { return new OneOrManyInLanguage (values.Select(v => (IInLanguage) new InLanguageLanguage (v))); }
            public static implicit operator OneOrManyInLanguage (string value) { return new OneOrManyInLanguage (new InLanguagestring (value)); }
            public static implicit operator OneOrManyInLanguage (string[] values) { return new OneOrManyInLanguage (values.Select(v => (IInLanguage) new InLanguagestring (v))); }
            public static implicit operator OneOrManyInLanguage (List<string> values) { return new OneOrManyInLanguage (values.Select(v => (IInLanguage) new InLanguagestring (v))); }
        }
        public struct InLanguageLanguage : IInLanguage<Language>
        {
            object IValue.Value => this.Value;
            public Language Value { get; }
            public InLanguageLanguage (Language value) { Value = value; }
            public static implicit operator InLanguageLanguage (Language value) { return new InLanguageLanguage (value); }
        }
        public struct InLanguagestring : IInLanguage<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public InLanguagestring (string value) { Value = value; }
            public static implicit operator InLanguagestring (string value) { return new InLanguagestring (value); }
        }

        public interface IIsAccessibleForFree : IValue {}
        public interface IIsAccessibleForFree<T> : IIsAccessibleForFree { new T Value { get; } }
        public class OneOrManyIsAccessibleForFree : OneOrMany<IIsAccessibleForFree>
        {
            public OneOrManyIsAccessibleForFree(IIsAccessibleForFree item) : base(item) { }
            public OneOrManyIsAccessibleForFree(IEnumerable<IIsAccessibleForFree> items) : base(items) { }
            public static implicit operator OneOrManyIsAccessibleForFree (bool value) { return new OneOrManyIsAccessibleForFree (new IsAccessibleForFreebool (value)); }
            public static implicit operator OneOrManyIsAccessibleForFree (bool[] values) { return new OneOrManyIsAccessibleForFree (values.Select(v => (IIsAccessibleForFree) new IsAccessibleForFreebool (v))); }
            public static implicit operator OneOrManyIsAccessibleForFree (List<bool> values) { return new OneOrManyIsAccessibleForFree (values.Select(v => (IIsAccessibleForFree) new IsAccessibleForFreebool (v))); }
        }
        public struct IsAccessibleForFreebool : IIsAccessibleForFree<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public IsAccessibleForFreebool (bool value) { Value = value; }
            public static implicit operator IsAccessibleForFreebool (bool value) { return new IsAccessibleForFreebool (value); }
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

        public interface IMaximumAttendeeCapacity : IValue {}
        public interface IMaximumAttendeeCapacity<T> : IMaximumAttendeeCapacity { new T Value { get; } }
        public class OneOrManyMaximumAttendeeCapacity : OneOrMany<IMaximumAttendeeCapacity>
        {
            public OneOrManyMaximumAttendeeCapacity(IMaximumAttendeeCapacity item) : base(item) { }
            public OneOrManyMaximumAttendeeCapacity(IEnumerable<IMaximumAttendeeCapacity> items) : base(items) { }
            public static implicit operator OneOrManyMaximumAttendeeCapacity (int value) { return new OneOrManyMaximumAttendeeCapacity (new MaximumAttendeeCapacityint (value)); }
            public static implicit operator OneOrManyMaximumAttendeeCapacity (int[] values) { return new OneOrManyMaximumAttendeeCapacity (values.Select(v => (IMaximumAttendeeCapacity) new MaximumAttendeeCapacityint (v))); }
            public static implicit operator OneOrManyMaximumAttendeeCapacity (List<int> values) { return new OneOrManyMaximumAttendeeCapacity (values.Select(v => (IMaximumAttendeeCapacity) new MaximumAttendeeCapacityint (v))); }
        }
        public struct MaximumAttendeeCapacityint : IMaximumAttendeeCapacity<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public MaximumAttendeeCapacityint (int value) { Value = value; }
            public static implicit operator MaximumAttendeeCapacityint (int value) { return new MaximumAttendeeCapacityint (value); }
        }

        public interface IOffers : IValue {}
        public interface IOffers<T> : IOffers { new T Value { get; } }
        public class OneOrManyOffers : OneOrMany<IOffers>
        {
            public OneOrManyOffers(IOffers item) : base(item) { }
            public OneOrManyOffers(IEnumerable<IOffers> items) : base(items) { }
            public static implicit operator OneOrManyOffers (Offer value) { return new OneOrManyOffers (new OffersOffer (value)); }
            public static implicit operator OneOrManyOffers (Offer[] values) { return new OneOrManyOffers (values.Select(v => (IOffers) new OffersOffer (v))); }
            public static implicit operator OneOrManyOffers (List<Offer> values) { return new OneOrManyOffers (values.Select(v => (IOffers) new OffersOffer (v))); }
        }
        public struct OffersOffer : IOffers<Offer>
        {
            object IValue.Value => this.Value;
            public Offer Value { get; }
            public OffersOffer (Offer value) { Value = value; }
            public static implicit operator OffersOffer (Offer value) { return new OffersOffer (value); }
        }

        public interface IOrganizer : IValue {}
        public interface IOrganizer<T> : IOrganizer { new T Value { get; } }
        public class OneOrManyOrganizer : OneOrMany<IOrganizer>
        {
            public OneOrManyOrganizer(IOrganizer item) : base(item) { }
            public OneOrManyOrganizer(IEnumerable<IOrganizer> items) : base(items) { }
            public static implicit operator OneOrManyOrganizer (Organization value) { return new OneOrManyOrganizer (new OrganizerOrganization (value)); }
            public static implicit operator OneOrManyOrganizer (Organization[] values) { return new OneOrManyOrganizer (values.Select(v => (IOrganizer) new OrganizerOrganization (v))); }
            public static implicit operator OneOrManyOrganizer (List<Organization> values) { return new OneOrManyOrganizer (values.Select(v => (IOrganizer) new OrganizerOrganization (v))); }
            public static implicit operator OneOrManyOrganizer (Person value) { return new OneOrManyOrganizer (new OrganizerPerson (value)); }
            public static implicit operator OneOrManyOrganizer (Person[] values) { return new OneOrManyOrganizer (values.Select(v => (IOrganizer) new OrganizerPerson (v))); }
            public static implicit operator OneOrManyOrganizer (List<Person> values) { return new OneOrManyOrganizer (values.Select(v => (IOrganizer) new OrganizerPerson (v))); }
        }
        public struct OrganizerOrganization : IOrganizer<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public OrganizerOrganization (Organization value) { Value = value; }
            public static implicit operator OrganizerOrganization (Organization value) { return new OrganizerOrganization (value); }
        }
        public struct OrganizerPerson : IOrganizer<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public OrganizerPerson (Person value) { Value = value; }
            public static implicit operator OrganizerPerson (Person value) { return new OrganizerPerson (value); }
        }

        public interface IPerformer : IValue {}
        public interface IPerformer<T> : IPerformer { new T Value { get; } }
        public class OneOrManyPerformer : OneOrMany<IPerformer>
        {
            public OneOrManyPerformer(IPerformer item) : base(item) { }
            public OneOrManyPerformer(IEnumerable<IPerformer> items) : base(items) { }
            public static implicit operator OneOrManyPerformer (Organization value) { return new OneOrManyPerformer (new PerformerOrganization (value)); }
            public static implicit operator OneOrManyPerformer (Organization[] values) { return new OneOrManyPerformer (values.Select(v => (IPerformer) new PerformerOrganization (v))); }
            public static implicit operator OneOrManyPerformer (List<Organization> values) { return new OneOrManyPerformer (values.Select(v => (IPerformer) new PerformerOrganization (v))); }
            public static implicit operator OneOrManyPerformer (Person value) { return new OneOrManyPerformer (new PerformerPerson (value)); }
            public static implicit operator OneOrManyPerformer (Person[] values) { return new OneOrManyPerformer (values.Select(v => (IPerformer) new PerformerPerson (v))); }
            public static implicit operator OneOrManyPerformer (List<Person> values) { return new OneOrManyPerformer (values.Select(v => (IPerformer) new PerformerPerson (v))); }
        }
        public struct PerformerOrganization : IPerformer<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public PerformerOrganization (Organization value) { Value = value; }
            public static implicit operator PerformerOrganization (Organization value) { return new PerformerOrganization (value); }
        }
        public struct PerformerPerson : IPerformer<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public PerformerPerson (Person value) { Value = value; }
            public static implicit operator PerformerPerson (Person value) { return new PerformerPerson (value); }
        }

        public interface IPreviousStartDate : IValue {}
        public interface IPreviousStartDate<T> : IPreviousStartDate { new T Value { get; } }
        public class OneOrManyPreviousStartDate : OneOrMany<IPreviousStartDate>
        {
            public OneOrManyPreviousStartDate(IPreviousStartDate item) : base(item) { }
            public OneOrManyPreviousStartDate(IEnumerable<IPreviousStartDate> items) : base(items) { }
            public static implicit operator OneOrManyPreviousStartDate (DateTimeOffset value) { return new OneOrManyPreviousStartDate (new PreviousStartDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyPreviousStartDate (DateTimeOffset[] values) { return new OneOrManyPreviousStartDate (values.Select(v => (IPreviousStartDate) new PreviousStartDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyPreviousStartDate (List<DateTimeOffset> values) { return new OneOrManyPreviousStartDate (values.Select(v => (IPreviousStartDate) new PreviousStartDateDateTimeOffset (v))); }
        }
        public struct PreviousStartDateDateTimeOffset : IPreviousStartDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public PreviousStartDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator PreviousStartDateDateTimeOffset (DateTimeOffset value) { return new PreviousStartDateDateTimeOffset (value); }
        }

        public interface IRecordedIn : IValue {}
        public interface IRecordedIn<T> : IRecordedIn { new T Value { get; } }
        public class OneOrManyRecordedIn : OneOrMany<IRecordedIn>
        {
            public OneOrManyRecordedIn(IRecordedIn item) : base(item) { }
            public OneOrManyRecordedIn(IEnumerable<IRecordedIn> items) : base(items) { }
            public static implicit operator OneOrManyRecordedIn (CreativeWork value) { return new OneOrManyRecordedIn (new RecordedInCreativeWork (value)); }
            public static implicit operator OneOrManyRecordedIn (CreativeWork[] values) { return new OneOrManyRecordedIn (values.Select(v => (IRecordedIn) new RecordedInCreativeWork (v))); }
            public static implicit operator OneOrManyRecordedIn (List<CreativeWork> values) { return new OneOrManyRecordedIn (values.Select(v => (IRecordedIn) new RecordedInCreativeWork (v))); }
        }
        public struct RecordedInCreativeWork : IRecordedIn<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public RecordedInCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator RecordedInCreativeWork (CreativeWork value) { return new RecordedInCreativeWork (value); }
        }

        public interface IRemainingAttendeeCapacity : IValue {}
        public interface IRemainingAttendeeCapacity<T> : IRemainingAttendeeCapacity { new T Value { get; } }
        public class OneOrManyRemainingAttendeeCapacity : OneOrMany<IRemainingAttendeeCapacity>
        {
            public OneOrManyRemainingAttendeeCapacity(IRemainingAttendeeCapacity item) : base(item) { }
            public OneOrManyRemainingAttendeeCapacity(IEnumerable<IRemainingAttendeeCapacity> items) : base(items) { }
            public static implicit operator OneOrManyRemainingAttendeeCapacity (int value) { return new OneOrManyRemainingAttendeeCapacity (new RemainingAttendeeCapacityint (value)); }
            public static implicit operator OneOrManyRemainingAttendeeCapacity (int[] values) { return new OneOrManyRemainingAttendeeCapacity (values.Select(v => (IRemainingAttendeeCapacity) new RemainingAttendeeCapacityint (v))); }
            public static implicit operator OneOrManyRemainingAttendeeCapacity (List<int> values) { return new OneOrManyRemainingAttendeeCapacity (values.Select(v => (IRemainingAttendeeCapacity) new RemainingAttendeeCapacityint (v))); }
        }
        public struct RemainingAttendeeCapacityint : IRemainingAttendeeCapacity<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public RemainingAttendeeCapacityint (int value) { Value = value; }
            public static implicit operator RemainingAttendeeCapacityint (int value) { return new RemainingAttendeeCapacityint (value); }
        }

        public interface IReview : IValue {}
        public interface IReview<T> : IReview { new T Value { get; } }
        public class OneOrManyReview : OneOrMany<IReview>
        {
            public OneOrManyReview(IReview item) : base(item) { }
            public OneOrManyReview(IEnumerable<IReview> items) : base(items) { }
            public static implicit operator OneOrManyReview (Review value) { return new OneOrManyReview (new ReviewReview (value)); }
            public static implicit operator OneOrManyReview (Review[] values) { return new OneOrManyReview (values.Select(v => (IReview) new ReviewReview (v))); }
            public static implicit operator OneOrManyReview (List<Review> values) { return new OneOrManyReview (values.Select(v => (IReview) new ReviewReview (v))); }
        }
        public struct ReviewReview : IReview<Review>
        {
            object IValue.Value => this.Value;
            public Review Value { get; }
            public ReviewReview (Review value) { Value = value; }
            public static implicit operator ReviewReview (Review value) { return new ReviewReview (value); }
        }

        public interface ISponsor : IValue {}
        public interface ISponsor<T> : ISponsor { new T Value { get; } }
        public class OneOrManySponsor : OneOrMany<ISponsor>
        {
            public OneOrManySponsor(ISponsor item) : base(item) { }
            public OneOrManySponsor(IEnumerable<ISponsor> items) : base(items) { }
            public static implicit operator OneOrManySponsor (Organization value) { return new OneOrManySponsor (new SponsorOrganization (value)); }
            public static implicit operator OneOrManySponsor (Organization[] values) { return new OneOrManySponsor (values.Select(v => (ISponsor) new SponsorOrganization (v))); }
            public static implicit operator OneOrManySponsor (List<Organization> values) { return new OneOrManySponsor (values.Select(v => (ISponsor) new SponsorOrganization (v))); }
            public static implicit operator OneOrManySponsor (Person value) { return new OneOrManySponsor (new SponsorPerson (value)); }
            public static implicit operator OneOrManySponsor (Person[] values) { return new OneOrManySponsor (values.Select(v => (ISponsor) new SponsorPerson (v))); }
            public static implicit operator OneOrManySponsor (List<Person> values) { return new OneOrManySponsor (values.Select(v => (ISponsor) new SponsorPerson (v))); }
        }
        public struct SponsorOrganization : ISponsor<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public SponsorOrganization (Organization value) { Value = value; }
            public static implicit operator SponsorOrganization (Organization value) { return new SponsorOrganization (value); }
        }
        public struct SponsorPerson : ISponsor<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public SponsorPerson (Person value) { Value = value; }
            public static implicit operator SponsorPerson (Person value) { return new SponsorPerson (value); }
        }

        public interface IStartDate : IValue {}
        public interface IStartDate<T> : IStartDate { new T Value { get; } }
        public class OneOrManyStartDate : OneOrMany<IStartDate>
        {
            public OneOrManyStartDate(IStartDate item) : base(item) { }
            public OneOrManyStartDate(IEnumerable<IStartDate> items) : base(items) { }
            public static implicit operator OneOrManyStartDate (DateTimeOffset value) { return new OneOrManyStartDate (new StartDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyStartDate (DateTimeOffset[] values) { return new OneOrManyStartDate (values.Select(v => (IStartDate) new StartDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyStartDate (List<DateTimeOffset> values) { return new OneOrManyStartDate (values.Select(v => (IStartDate) new StartDateDateTimeOffset (v))); }
        }
        public struct StartDateDateTimeOffset : IStartDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public StartDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator StartDateDateTimeOffset (DateTimeOffset value) { return new StartDateDateTimeOffset (value); }
        }

        public interface IEndDate : IValue {}
        public interface IEndDate<T> : IEndDate { new T Value { get; } }
        public class OneOrManyEndDate : OneOrMany<IEndDate>
        {
            public OneOrManyEndDate(IEndDate item) : base(item) { }
            public OneOrManyEndDate(IEnumerable<IEndDate> items) : base(items) { }
            public static implicit operator OneOrManyEndDate (DateTimeOffset value) { return new OneOrManyEndDate (new EndDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyEndDate (DateTimeOffset[] values) { return new OneOrManyEndDate (values.Select(v => (IEndDate) new EndDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyEndDate (List<DateTimeOffset> values) { return new OneOrManyEndDate (values.Select(v => (IEndDate) new EndDateDateTimeOffset (v))); }
        }
        public struct EndDateDateTimeOffset : IEndDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public EndDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator EndDateDateTimeOffset (DateTimeOffset value) { return new EndDateDateTimeOffset (value); }
        }

        public interface ISubEvent : IValue {}
        public interface ISubEvent<T> : ISubEvent { new T Value { get; } }
        public class OneOrManySubEvent : OneOrMany<ISubEvent>
        {
            public OneOrManySubEvent(ISubEvent item) : base(item) { }
            public OneOrManySubEvent(IEnumerable<ISubEvent> items) : base(items) { }
            public static implicit operator OneOrManySubEvent (Event value) { return new OneOrManySubEvent (new SubEventEvent (value)); }
            public static implicit operator OneOrManySubEvent (Event[] values) { return new OneOrManySubEvent (values.Select(v => (ISubEvent) new SubEventEvent (v))); }
            public static implicit operator OneOrManySubEvent (List<Event> values) { return new OneOrManySubEvent (values.Select(v => (ISubEvent) new SubEventEvent (v))); }
        }
        public struct SubEventEvent : ISubEvent<Event>
        {
            object IValue.Value => this.Value;
            public Event Value { get; }
            public SubEventEvent (Event value) { Value = value; }
            public static implicit operator SubEventEvent (Event value) { return new SubEventEvent (value); }
        }

        public interface ISuperEvent : IValue {}
        public interface ISuperEvent<T> : ISuperEvent { new T Value { get; } }
        public class OneOrManySuperEvent : OneOrMany<ISuperEvent>
        {
            public OneOrManySuperEvent(ISuperEvent item) : base(item) { }
            public OneOrManySuperEvent(IEnumerable<ISuperEvent> items) : base(items) { }
            public static implicit operator OneOrManySuperEvent (Event value) { return new OneOrManySuperEvent (new SuperEventEvent (value)); }
            public static implicit operator OneOrManySuperEvent (Event[] values) { return new OneOrManySuperEvent (values.Select(v => (ISuperEvent) new SuperEventEvent (v))); }
            public static implicit operator OneOrManySuperEvent (List<Event> values) { return new OneOrManySuperEvent (values.Select(v => (ISuperEvent) new SuperEventEvent (v))); }
        }
        public struct SuperEventEvent : ISuperEvent<Event>
        {
            object IValue.Value => this.Value;
            public Event Value { get; }
            public SuperEventEvent (Event value) { Value = value; }
            public static implicit operator SuperEventEvent (Event value) { return new SuperEventEvent (value); }
        }

        public interface ITranslator : IValue {}
        public interface ITranslator<T> : ITranslator { new T Value { get; } }
        public class OneOrManyTranslator : OneOrMany<ITranslator>
        {
            public OneOrManyTranslator(ITranslator item) : base(item) { }
            public OneOrManyTranslator(IEnumerable<ITranslator> items) : base(items) { }
            public static implicit operator OneOrManyTranslator (Organization value) { return new OneOrManyTranslator (new TranslatorOrganization (value)); }
            public static implicit operator OneOrManyTranslator (Organization[] values) { return new OneOrManyTranslator (values.Select(v => (ITranslator) new TranslatorOrganization (v))); }
            public static implicit operator OneOrManyTranslator (List<Organization> values) { return new OneOrManyTranslator (values.Select(v => (ITranslator) new TranslatorOrganization (v))); }
            public static implicit operator OneOrManyTranslator (Person value) { return new OneOrManyTranslator (new TranslatorPerson (value)); }
            public static implicit operator OneOrManyTranslator (Person[] values) { return new OneOrManyTranslator (values.Select(v => (ITranslator) new TranslatorPerson (v))); }
            public static implicit operator OneOrManyTranslator (List<Person> values) { return new OneOrManyTranslator (values.Select(v => (ITranslator) new TranslatorPerson (v))); }
        }
        public struct TranslatorOrganization : ITranslator<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public TranslatorOrganization (Organization value) { Value = value; }
            public static implicit operator TranslatorOrganization (Organization value) { return new TranslatorOrganization (value); }
        }
        public struct TranslatorPerson : ITranslator<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public TranslatorPerson (Person value) { Value = value; }
            public static implicit operator TranslatorPerson (Person value) { return new TranslatorPerson (value); }
        }

        public interface ITypicalAgeRange : IValue {}
        public interface ITypicalAgeRange<T> : ITypicalAgeRange { new T Value { get; } }
        public class OneOrManyTypicalAgeRange : OneOrMany<ITypicalAgeRange>
        {
            public OneOrManyTypicalAgeRange(ITypicalAgeRange item) : base(item) { }
            public OneOrManyTypicalAgeRange(IEnumerable<ITypicalAgeRange> items) : base(items) { }
            public static implicit operator OneOrManyTypicalAgeRange (string value) { return new OneOrManyTypicalAgeRange (new TypicalAgeRangestring (value)); }
            public static implicit operator OneOrManyTypicalAgeRange (string[] values) { return new OneOrManyTypicalAgeRange (values.Select(v => (ITypicalAgeRange) new TypicalAgeRangestring (v))); }
            public static implicit operator OneOrManyTypicalAgeRange (List<string> values) { return new OneOrManyTypicalAgeRange (values.Select(v => (ITypicalAgeRange) new TypicalAgeRangestring (v))); }
        }
        public struct TypicalAgeRangestring : ITypicalAgeRange<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public TypicalAgeRangestring (string value) { Value = value; }
            public static implicit operator TypicalAgeRangestring (string value) { return new TypicalAgeRangestring (value); }
        }

        public interface IWorkFeatured : IValue {}
        public interface IWorkFeatured<T> : IWorkFeatured { new T Value { get; } }
        public class OneOrManyWorkFeatured : OneOrMany<IWorkFeatured>
        {
            public OneOrManyWorkFeatured(IWorkFeatured item) : base(item) { }
            public OneOrManyWorkFeatured(IEnumerable<IWorkFeatured> items) : base(items) { }
            public static implicit operator OneOrManyWorkFeatured (CreativeWork value) { return new OneOrManyWorkFeatured (new WorkFeaturedCreativeWork (value)); }
            public static implicit operator OneOrManyWorkFeatured (CreativeWork[] values) { return new OneOrManyWorkFeatured (values.Select(v => (IWorkFeatured) new WorkFeaturedCreativeWork (v))); }
            public static implicit operator OneOrManyWorkFeatured (List<CreativeWork> values) { return new OneOrManyWorkFeatured (values.Select(v => (IWorkFeatured) new WorkFeaturedCreativeWork (v))); }
        }
        public struct WorkFeaturedCreativeWork : IWorkFeatured<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public WorkFeaturedCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator WorkFeaturedCreativeWork (CreativeWork value) { return new WorkFeaturedCreativeWork (value); }
        }

        public interface IWorkPerformed : IValue {}
        public interface IWorkPerformed<T> : IWorkPerformed { new T Value { get; } }
        public class OneOrManyWorkPerformed : OneOrMany<IWorkPerformed>
        {
            public OneOrManyWorkPerformed(IWorkPerformed item) : base(item) { }
            public OneOrManyWorkPerformed(IEnumerable<IWorkPerformed> items) : base(items) { }
            public static implicit operator OneOrManyWorkPerformed (CreativeWork value) { return new OneOrManyWorkPerformed (new WorkPerformedCreativeWork (value)); }
            public static implicit operator OneOrManyWorkPerformed (CreativeWork[] values) { return new OneOrManyWorkPerformed (values.Select(v => (IWorkPerformed) new WorkPerformedCreativeWork (v))); }
            public static implicit operator OneOrManyWorkPerformed (List<CreativeWork> values) { return new OneOrManyWorkPerformed (values.Select(v => (IWorkPerformed) new WorkPerformedCreativeWork (v))); }
        }
        public struct WorkPerformedCreativeWork : IWorkPerformed<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public WorkPerformedCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator WorkPerformedCreativeWork (CreativeWork value) { return new WorkPerformedCreativeWork (value); }
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
        public OneOrManyAbout About { get; set; }

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 107)]
        public OneOrManyActor Actor { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 108)]
        public OneOrManyAggregateRating AggregateRating { get; set; }

        /// <summary>
        /// A person or organization attending the event.
        /// </summary>
        [DataMember(Name = "attendee", Order = 109)]
        public OneOrManyAttendee Attendee { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience", Order = 110)]
        public OneOrManyAudience Audience { get; set; }

        /// <summary>
        /// The person or organization who wrote a composition, or who is the composer of a work performed at some event.
        /// </summary>
        [DataMember(Name = "composer", Order = 111)]
        public OneOrManyComposer Composer { get; set; }

        /// <summary>
        /// A secondary contributor to the CreativeWork or Event.
        /// </summary>
        [DataMember(Name = "contributor", Order = 112)]
        public OneOrManyContributor Contributor { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 113)]
        public OneOrManyDirector Director { get; set; }

        /// <summary>
        /// The time admission will commence.
        /// </summary>
        [DataMember(Name = "doorTime", Order = 114)]
        public OneOrManyDoorTime DoorTime { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration", Order = 115)]
        public OneOrManyDuration Duration { get; set; }

        /// <summary>
        /// An eventStatus of an event represents its status; particularly useful when an event is cancelled or rescheduled.
        /// </summary>
        [DataMember(Name = "eventStatus", Order = 116)]
        public OneOrManyEventStatus EventStatus { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 117)]
        public OneOrManyFunder Funder { get; set; }

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "inLanguage", Order = 118)]
        public OneOrManyInLanguage InLanguage { get; set; }

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree", Order = 119)]
        public virtual OneOrManyIsAccessibleForFree IsAccessibleForFree { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [DataMember(Name = "location", Order = 120)]
        public OneOrManyLocation Location { get; set; }

        /// <summary>
        /// The total number of individuals that may attend an event or venue.
        /// </summary>
        [DataMember(Name = "maximumAttendeeCapacity", Order = 121)]
        public OneOrManyMaximumAttendeeCapacity MaximumAttendeeCapacity { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers", Order = 122)]
        public OneOrManyOffers Offers { get; set; }

        /// <summary>
        /// An organizer of an Event.
        /// </summary>
        [DataMember(Name = "organizer", Order = 123)]
        public OneOrManyOrganizer Organizer { get; set; }

        /// <summary>
        /// A performer at the event&amp;#x2014;for example, a presenter, musician, musical group or actor.
        /// </summary>
        [DataMember(Name = "performer", Order = 124)]
        public OneOrManyPerformer Performer { get; set; }

        /// <summary>
        /// Used in conjunction with eventStatus for rescheduled or cancelled events. This property contains the previously scheduled start date. For rescheduled events, the startDate property should be used for the newly scheduled start date. In the (rare) case of an event that has been postponed and rescheduled multiple times, this field may be repeated.
        /// </summary>
        [DataMember(Name = "previousStartDate", Order = 125)]
        public OneOrManyPreviousStartDate PreviousStartDate { get; set; }

        /// <summary>
        /// The CreativeWork that captured all or part of this Event.
        /// </summary>
        [DataMember(Name = "recordedIn", Order = 126)]
        public OneOrManyRecordedIn RecordedIn { get; set; }

        /// <summary>
        /// The number of attendee places for an event that remain unallocated.
        /// </summary>
        [DataMember(Name = "remainingAttendeeCapacity", Order = 127)]
        public OneOrManyRemainingAttendeeCapacity RemainingAttendeeCapacity { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 128)]
        public OneOrManyReview Review { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 129)]
        public OneOrManySponsor Sponsor { get; set; }

        /// <summary>
        /// The start date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "startDate", Order = 130)]
        public OneOrManyStartDate StartDate { get; set; }

        /// <summary>
        /// The end date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "endDate", Order = 131)]
        public OneOrManyEndDate EndDate { get; set; }

        /// <summary>
        /// An Event that is part of this event. For example, a conference event includes many presentations, each of which is a subEvent of the conference.
        /// </summary>
        [DataMember(Name = "subEvent", Order = 132)]
        public OneOrManySubEvent SubEvent { get; set; }

        /// <summary>
        /// An event that this event is a part of. For example, a collection of individual music performances might each have a music festival as their superEvent.
        /// </summary>
        [DataMember(Name = "superEvent", Order = 133)]
        public OneOrManySuperEvent SuperEvent { get; set; }

        /// <summary>
        /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
        /// </summary>
        [DataMember(Name = "translator", Order = 134)]
        public OneOrManyTranslator Translator { get; set; }

        /// <summary>
        /// The typical expected age range, e.g. '7-9', '11-'.
        /// </summary>
        [DataMember(Name = "typicalAgeRange", Order = 135)]
        public OneOrManyTypicalAgeRange TypicalAgeRange { get; set; }

        /// <summary>
        /// A work featured in some event, e.g. exhibited in an ExhibitionEvent.
        ///        Specific subproperties are available for workPerformed (e.g. a play), or a workPresented (a Movie at a ScreeningEvent).
        /// </summary>
        [DataMember(Name = "workFeatured", Order = 136)]
        public OneOrManyWorkFeatured WorkFeatured { get; set; }

        /// <summary>
        /// A work performed in some event, for example a play performed in a TheaterEvent.
        /// </summary>
        [DataMember(Name = "workPerformed", Order = 137)]
        public OneOrManyWorkPerformed WorkPerformed { get; set; }
    }
}
