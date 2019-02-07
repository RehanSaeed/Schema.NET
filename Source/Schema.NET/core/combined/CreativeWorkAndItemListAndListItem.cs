namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// See CreativeWork, ItemList, ListItem for more information.
    /// </summary>
    [DataContract]
    public abstract partial class CreativeWorkAndItemListAndListItem : Intangible
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

        public interface IAccessibilityAPI : IValue {}
        public interface IAccessibilityAPI<T> : IAccessibilityAPI { new T Value { get; } }
        public class OneOrManyAccessibilityAPI : OneOrMany<IAccessibilityAPI>
        {
            public OneOrManyAccessibilityAPI(IAccessibilityAPI item) : base(item) { }
            public OneOrManyAccessibilityAPI(IEnumerable<IAccessibilityAPI> items) : base(items) { }
            public static implicit operator OneOrManyAccessibilityAPI (string value) { return new OneOrManyAccessibilityAPI (new AccessibilityAPIstring (value)); }
            public static implicit operator OneOrManyAccessibilityAPI (string[] values) { return new OneOrManyAccessibilityAPI (values.Select(v => (IAccessibilityAPI) new AccessibilityAPIstring (v))); }
            public static implicit operator OneOrManyAccessibilityAPI (List<string> values) { return new OneOrManyAccessibilityAPI (values.Select(v => (IAccessibilityAPI) new AccessibilityAPIstring (v))); }
        }
        public struct AccessibilityAPIstring : IAccessibilityAPI<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AccessibilityAPIstring (string value) { Value = value; }
            public static implicit operator AccessibilityAPIstring (string value) { return new AccessibilityAPIstring (value); }
        }

        public interface IAccessibilityControl : IValue {}
        public interface IAccessibilityControl<T> : IAccessibilityControl { new T Value { get; } }
        public class OneOrManyAccessibilityControl : OneOrMany<IAccessibilityControl>
        {
            public OneOrManyAccessibilityControl(IAccessibilityControl item) : base(item) { }
            public OneOrManyAccessibilityControl(IEnumerable<IAccessibilityControl> items) : base(items) { }
            public static implicit operator OneOrManyAccessibilityControl (string value) { return new OneOrManyAccessibilityControl (new AccessibilityControlstring (value)); }
            public static implicit operator OneOrManyAccessibilityControl (string[] values) { return new OneOrManyAccessibilityControl (values.Select(v => (IAccessibilityControl) new AccessibilityControlstring (v))); }
            public static implicit operator OneOrManyAccessibilityControl (List<string> values) { return new OneOrManyAccessibilityControl (values.Select(v => (IAccessibilityControl) new AccessibilityControlstring (v))); }
        }
        public struct AccessibilityControlstring : IAccessibilityControl<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AccessibilityControlstring (string value) { Value = value; }
            public static implicit operator AccessibilityControlstring (string value) { return new AccessibilityControlstring (value); }
        }

        public interface IAccessibilityFeature : IValue {}
        public interface IAccessibilityFeature<T> : IAccessibilityFeature { new T Value { get; } }
        public class OneOrManyAccessibilityFeature : OneOrMany<IAccessibilityFeature>
        {
            public OneOrManyAccessibilityFeature(IAccessibilityFeature item) : base(item) { }
            public OneOrManyAccessibilityFeature(IEnumerable<IAccessibilityFeature> items) : base(items) { }
            public static implicit operator OneOrManyAccessibilityFeature (string value) { return new OneOrManyAccessibilityFeature (new AccessibilityFeaturestring (value)); }
            public static implicit operator OneOrManyAccessibilityFeature (string[] values) { return new OneOrManyAccessibilityFeature (values.Select(v => (IAccessibilityFeature) new AccessibilityFeaturestring (v))); }
            public static implicit operator OneOrManyAccessibilityFeature (List<string> values) { return new OneOrManyAccessibilityFeature (values.Select(v => (IAccessibilityFeature) new AccessibilityFeaturestring (v))); }
        }
        public struct AccessibilityFeaturestring : IAccessibilityFeature<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AccessibilityFeaturestring (string value) { Value = value; }
            public static implicit operator AccessibilityFeaturestring (string value) { return new AccessibilityFeaturestring (value); }
        }

        public interface IAccessibilityHazard : IValue {}
        public interface IAccessibilityHazard<T> : IAccessibilityHazard { new T Value { get; } }
        public class OneOrManyAccessibilityHazard : OneOrMany<IAccessibilityHazard>
        {
            public OneOrManyAccessibilityHazard(IAccessibilityHazard item) : base(item) { }
            public OneOrManyAccessibilityHazard(IEnumerable<IAccessibilityHazard> items) : base(items) { }
            public static implicit operator OneOrManyAccessibilityHazard (string value) { return new OneOrManyAccessibilityHazard (new AccessibilityHazardstring (value)); }
            public static implicit operator OneOrManyAccessibilityHazard (string[] values) { return new OneOrManyAccessibilityHazard (values.Select(v => (IAccessibilityHazard) new AccessibilityHazardstring (v))); }
            public static implicit operator OneOrManyAccessibilityHazard (List<string> values) { return new OneOrManyAccessibilityHazard (values.Select(v => (IAccessibilityHazard) new AccessibilityHazardstring (v))); }
        }
        public struct AccessibilityHazardstring : IAccessibilityHazard<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AccessibilityHazardstring (string value) { Value = value; }
            public static implicit operator AccessibilityHazardstring (string value) { return new AccessibilityHazardstring (value); }
        }

        public interface IAccessibilitySummary : IValue {}
        public interface IAccessibilitySummary<T> : IAccessibilitySummary { new T Value { get; } }
        public class OneOrManyAccessibilitySummary : OneOrMany<IAccessibilitySummary>
        {
            public OneOrManyAccessibilitySummary(IAccessibilitySummary item) : base(item) { }
            public OneOrManyAccessibilitySummary(IEnumerable<IAccessibilitySummary> items) : base(items) { }
            public static implicit operator OneOrManyAccessibilitySummary (string value) { return new OneOrManyAccessibilitySummary (new AccessibilitySummarystring (value)); }
            public static implicit operator OneOrManyAccessibilitySummary (string[] values) { return new OneOrManyAccessibilitySummary (values.Select(v => (IAccessibilitySummary) new AccessibilitySummarystring (v))); }
            public static implicit operator OneOrManyAccessibilitySummary (List<string> values) { return new OneOrManyAccessibilitySummary (values.Select(v => (IAccessibilitySummary) new AccessibilitySummarystring (v))); }
        }
        public struct AccessibilitySummarystring : IAccessibilitySummary<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AccessibilitySummarystring (string value) { Value = value; }
            public static implicit operator AccessibilitySummarystring (string value) { return new AccessibilitySummarystring (value); }
        }

        public interface IAccessMode : IValue {}
        public interface IAccessMode<T> : IAccessMode { new T Value { get; } }
        public class OneOrManyAccessMode : OneOrMany<IAccessMode>
        {
            public OneOrManyAccessMode(IAccessMode item) : base(item) { }
            public OneOrManyAccessMode(IEnumerable<IAccessMode> items) : base(items) { }
            public static implicit operator OneOrManyAccessMode (string value) { return new OneOrManyAccessMode (new AccessModestring (value)); }
            public static implicit operator OneOrManyAccessMode (string[] values) { return new OneOrManyAccessMode (values.Select(v => (IAccessMode) new AccessModestring (v))); }
            public static implicit operator OneOrManyAccessMode (List<string> values) { return new OneOrManyAccessMode (values.Select(v => (IAccessMode) new AccessModestring (v))); }
        }
        public struct AccessModestring : IAccessMode<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AccessModestring (string value) { Value = value; }
            public static implicit operator AccessModestring (string value) { return new AccessModestring (value); }
        }

        public interface IAccessModeSufficient : IValue {}
        public interface IAccessModeSufficient<T> : IAccessModeSufficient { new T Value { get; } }
        public class OneOrManyAccessModeSufficient : OneOrMany<IAccessModeSufficient>
        {
            public OneOrManyAccessModeSufficient(IAccessModeSufficient item) : base(item) { }
            public OneOrManyAccessModeSufficient(IEnumerable<IAccessModeSufficient> items) : base(items) { }
            public static implicit operator OneOrManyAccessModeSufficient (string value) { return new OneOrManyAccessModeSufficient (new AccessModeSufficientstring (value)); }
            public static implicit operator OneOrManyAccessModeSufficient (string[] values) { return new OneOrManyAccessModeSufficient (values.Select(v => (IAccessModeSufficient) new AccessModeSufficientstring (v))); }
            public static implicit operator OneOrManyAccessModeSufficient (List<string> values) { return new OneOrManyAccessModeSufficient (values.Select(v => (IAccessModeSufficient) new AccessModeSufficientstring (v))); }
        }
        public struct AccessModeSufficientstring : IAccessModeSufficient<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AccessModeSufficientstring (string value) { Value = value; }
            public static implicit operator AccessModeSufficientstring (string value) { return new AccessModeSufficientstring (value); }
        }

        public interface IAccountablePerson : IValue {}
        public interface IAccountablePerson<T> : IAccountablePerson { new T Value { get; } }
        public class OneOrManyAccountablePerson : OneOrMany<IAccountablePerson>
        {
            public OneOrManyAccountablePerson(IAccountablePerson item) : base(item) { }
            public OneOrManyAccountablePerson(IEnumerable<IAccountablePerson> items) : base(items) { }
            public static implicit operator OneOrManyAccountablePerson (Person value) { return new OneOrManyAccountablePerson (new AccountablePersonPerson (value)); }
            public static implicit operator OneOrManyAccountablePerson (Person[] values) { return new OneOrManyAccountablePerson (values.Select(v => (IAccountablePerson) new AccountablePersonPerson (v))); }
            public static implicit operator OneOrManyAccountablePerson (List<Person> values) { return new OneOrManyAccountablePerson (values.Select(v => (IAccountablePerson) new AccountablePersonPerson (v))); }
        }
        public struct AccountablePersonPerson : IAccountablePerson<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public AccountablePersonPerson (Person value) { Value = value; }
            public static implicit operator AccountablePersonPerson (Person value) { return new AccountablePersonPerson (value); }
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

        public interface IAlternativeHeadline : IValue {}
        public interface IAlternativeHeadline<T> : IAlternativeHeadline { new T Value { get; } }
        public class OneOrManyAlternativeHeadline : OneOrMany<IAlternativeHeadline>
        {
            public OneOrManyAlternativeHeadline(IAlternativeHeadline item) : base(item) { }
            public OneOrManyAlternativeHeadline(IEnumerable<IAlternativeHeadline> items) : base(items) { }
            public static implicit operator OneOrManyAlternativeHeadline (string value) { return new OneOrManyAlternativeHeadline (new AlternativeHeadlinestring (value)); }
            public static implicit operator OneOrManyAlternativeHeadline (string[] values) { return new OneOrManyAlternativeHeadline (values.Select(v => (IAlternativeHeadline) new AlternativeHeadlinestring (v))); }
            public static implicit operator OneOrManyAlternativeHeadline (List<string> values) { return new OneOrManyAlternativeHeadline (values.Select(v => (IAlternativeHeadline) new AlternativeHeadlinestring (v))); }
        }
        public struct AlternativeHeadlinestring : IAlternativeHeadline<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AlternativeHeadlinestring (string value) { Value = value; }
            public static implicit operator AlternativeHeadlinestring (string value) { return new AlternativeHeadlinestring (value); }
        }

        public interface IAssociatedMedia : IValue {}
        public interface IAssociatedMedia<T> : IAssociatedMedia { new T Value { get; } }
        public class OneOrManyAssociatedMedia : OneOrMany<IAssociatedMedia>
        {
            public OneOrManyAssociatedMedia(IAssociatedMedia item) : base(item) { }
            public OneOrManyAssociatedMedia(IEnumerable<IAssociatedMedia> items) : base(items) { }
            public static implicit operator OneOrManyAssociatedMedia (MediaObject value) { return new OneOrManyAssociatedMedia (new AssociatedMediaMediaObject (value)); }
            public static implicit operator OneOrManyAssociatedMedia (MediaObject[] values) { return new OneOrManyAssociatedMedia (values.Select(v => (IAssociatedMedia) new AssociatedMediaMediaObject (v))); }
            public static implicit operator OneOrManyAssociatedMedia (List<MediaObject> values) { return new OneOrManyAssociatedMedia (values.Select(v => (IAssociatedMedia) new AssociatedMediaMediaObject (v))); }
        }
        public struct AssociatedMediaMediaObject : IAssociatedMedia<MediaObject>
        {
            object IValue.Value => this.Value;
            public MediaObject Value { get; }
            public AssociatedMediaMediaObject (MediaObject value) { Value = value; }
            public static implicit operator AssociatedMediaMediaObject (MediaObject value) { return new AssociatedMediaMediaObject (value); }
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

        public interface IAudio : IValue {}
        public interface IAudio<T> : IAudio { new T Value { get; } }
        public class OneOrManyAudio : OneOrMany<IAudio>
        {
            public OneOrManyAudio(IAudio item) : base(item) { }
            public OneOrManyAudio(IEnumerable<IAudio> items) : base(items) { }
            public static implicit operator OneOrManyAudio (AudioObject value) { return new OneOrManyAudio (new AudioAudioObject (value)); }
            public static implicit operator OneOrManyAudio (AudioObject[] values) { return new OneOrManyAudio (values.Select(v => (IAudio) new AudioAudioObject (v))); }
            public static implicit operator OneOrManyAudio (List<AudioObject> values) { return new OneOrManyAudio (values.Select(v => (IAudio) new AudioAudioObject (v))); }
        }
        public struct AudioAudioObject : IAudio<AudioObject>
        {
            object IValue.Value => this.Value;
            public AudioObject Value { get; }
            public AudioAudioObject (AudioObject value) { Value = value; }
            public static implicit operator AudioAudioObject (AudioObject value) { return new AudioAudioObject (value); }
        }

        public interface IAuthor : IValue {}
        public interface IAuthor<T> : IAuthor { new T Value { get; } }
        public class OneOrManyAuthor : OneOrMany<IAuthor>
        {
            public OneOrManyAuthor(IAuthor item) : base(item) { }
            public OneOrManyAuthor(IEnumerable<IAuthor> items) : base(items) { }
            public static implicit operator OneOrManyAuthor (Organization value) { return new OneOrManyAuthor (new AuthorOrganization (value)); }
            public static implicit operator OneOrManyAuthor (Organization[] values) { return new OneOrManyAuthor (values.Select(v => (IAuthor) new AuthorOrganization (v))); }
            public static implicit operator OneOrManyAuthor (List<Organization> values) { return new OneOrManyAuthor (values.Select(v => (IAuthor) new AuthorOrganization (v))); }
            public static implicit operator OneOrManyAuthor (Person value) { return new OneOrManyAuthor (new AuthorPerson (value)); }
            public static implicit operator OneOrManyAuthor (Person[] values) { return new OneOrManyAuthor (values.Select(v => (IAuthor) new AuthorPerson (v))); }
            public static implicit operator OneOrManyAuthor (List<Person> values) { return new OneOrManyAuthor (values.Select(v => (IAuthor) new AuthorPerson (v))); }
        }
        public struct AuthorOrganization : IAuthor<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public AuthorOrganization (Organization value) { Value = value; }
            public static implicit operator AuthorOrganization (Organization value) { return new AuthorOrganization (value); }
        }
        public struct AuthorPerson : IAuthor<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public AuthorPerson (Person value) { Value = value; }
            public static implicit operator AuthorPerson (Person value) { return new AuthorPerson (value); }
        }

        public interface IAward : IValue {}
        public interface IAward<T> : IAward { new T Value { get; } }
        public class OneOrManyAward : OneOrMany<IAward>
        {
            public OneOrManyAward(IAward item) : base(item) { }
            public OneOrManyAward(IEnumerable<IAward> items) : base(items) { }
            public static implicit operator OneOrManyAward (string value) { return new OneOrManyAward (new Awardstring (value)); }
            public static implicit operator OneOrManyAward (string[] values) { return new OneOrManyAward (values.Select(v => (IAward) new Awardstring (v))); }
            public static implicit operator OneOrManyAward (List<string> values) { return new OneOrManyAward (values.Select(v => (IAward) new Awardstring (v))); }
        }
        public struct Awardstring : IAward<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Awardstring (string value) { Value = value; }
            public static implicit operator Awardstring (string value) { return new Awardstring (value); }
        }

        public interface ICharacter : IValue {}
        public interface ICharacter<T> : ICharacter { new T Value { get; } }
        public class OneOrManyCharacter : OneOrMany<ICharacter>
        {
            public OneOrManyCharacter(ICharacter item) : base(item) { }
            public OneOrManyCharacter(IEnumerable<ICharacter> items) : base(items) { }
            public static implicit operator OneOrManyCharacter (Person value) { return new OneOrManyCharacter (new CharacterPerson (value)); }
            public static implicit operator OneOrManyCharacter (Person[] values) { return new OneOrManyCharacter (values.Select(v => (ICharacter) new CharacterPerson (v))); }
            public static implicit operator OneOrManyCharacter (List<Person> values) { return new OneOrManyCharacter (values.Select(v => (ICharacter) new CharacterPerson (v))); }
        }
        public struct CharacterPerson : ICharacter<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public CharacterPerson (Person value) { Value = value; }
            public static implicit operator CharacterPerson (Person value) { return new CharacterPerson (value); }
        }

        public interface ICitation : IValue {}
        public interface ICitation<T> : ICitation { new T Value { get; } }
        public class OneOrManyCitation : OneOrMany<ICitation>
        {
            public OneOrManyCitation(ICitation item) : base(item) { }
            public OneOrManyCitation(IEnumerable<ICitation> items) : base(items) { }
            public static implicit operator OneOrManyCitation (CreativeWork value) { return new OneOrManyCitation (new CitationCreativeWork (value)); }
            public static implicit operator OneOrManyCitation (CreativeWork[] values) { return new OneOrManyCitation (values.Select(v => (ICitation) new CitationCreativeWork (v))); }
            public static implicit operator OneOrManyCitation (List<CreativeWork> values) { return new OneOrManyCitation (values.Select(v => (ICitation) new CitationCreativeWork (v))); }
            public static implicit operator OneOrManyCitation (string value) { return new OneOrManyCitation (new Citationstring (value)); }
            public static implicit operator OneOrManyCitation (string[] values) { return new OneOrManyCitation (values.Select(v => (ICitation) new Citationstring (v))); }
            public static implicit operator OneOrManyCitation (List<string> values) { return new OneOrManyCitation (values.Select(v => (ICitation) new Citationstring (v))); }
        }
        public struct CitationCreativeWork : ICitation<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public CitationCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator CitationCreativeWork (CreativeWork value) { return new CitationCreativeWork (value); }
        }
        public struct Citationstring : ICitation<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Citationstring (string value) { Value = value; }
            public static implicit operator Citationstring (string value) { return new Citationstring (value); }
        }

        public interface IComment : IValue {}
        public interface IComment<T> : IComment { new T Value { get; } }
        public class OneOrManyComment : OneOrMany<IComment>
        {
            public OneOrManyComment(IComment item) : base(item) { }
            public OneOrManyComment(IEnumerable<IComment> items) : base(items) { }
            public static implicit operator OneOrManyComment (Comment value) { return new OneOrManyComment (new CommentComment (value)); }
            public static implicit operator OneOrManyComment (Comment[] values) { return new OneOrManyComment (values.Select(v => (IComment) new CommentComment (v))); }
            public static implicit operator OneOrManyComment (List<Comment> values) { return new OneOrManyComment (values.Select(v => (IComment) new CommentComment (v))); }
        }
        public struct CommentComment : IComment<Comment>
        {
            object IValue.Value => this.Value;
            public Comment Value { get; }
            public CommentComment (Comment value) { Value = value; }
            public static implicit operator CommentComment (Comment value) { return new CommentComment (value); }
        }

        public interface ICommentCount : IValue {}
        public interface ICommentCount<T> : ICommentCount { new T Value { get; } }
        public class OneOrManyCommentCount : OneOrMany<ICommentCount>
        {
            public OneOrManyCommentCount(ICommentCount item) : base(item) { }
            public OneOrManyCommentCount(IEnumerable<ICommentCount> items) : base(items) { }
            public static implicit operator OneOrManyCommentCount (int value) { return new OneOrManyCommentCount (new CommentCountint (value)); }
            public static implicit operator OneOrManyCommentCount (int[] values) { return new OneOrManyCommentCount (values.Select(v => (ICommentCount) new CommentCountint (v))); }
            public static implicit operator OneOrManyCommentCount (List<int> values) { return new OneOrManyCommentCount (values.Select(v => (ICommentCount) new CommentCountint (v))); }
        }
        public struct CommentCountint : ICommentCount<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public CommentCountint (int value) { Value = value; }
            public static implicit operator CommentCountint (int value) { return new CommentCountint (value); }
        }

        public interface IContentLocation : IValue {}
        public interface IContentLocation<T> : IContentLocation { new T Value { get; } }
        public class OneOrManyContentLocation : OneOrMany<IContentLocation>
        {
            public OneOrManyContentLocation(IContentLocation item) : base(item) { }
            public OneOrManyContentLocation(IEnumerable<IContentLocation> items) : base(items) { }
            public static implicit operator OneOrManyContentLocation (Place value) { return new OneOrManyContentLocation (new ContentLocationPlace (value)); }
            public static implicit operator OneOrManyContentLocation (Place[] values) { return new OneOrManyContentLocation (values.Select(v => (IContentLocation) new ContentLocationPlace (v))); }
            public static implicit operator OneOrManyContentLocation (List<Place> values) { return new OneOrManyContentLocation (values.Select(v => (IContentLocation) new ContentLocationPlace (v))); }
        }
        public struct ContentLocationPlace : IContentLocation<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public ContentLocationPlace (Place value) { Value = value; }
            public static implicit operator ContentLocationPlace (Place value) { return new ContentLocationPlace (value); }
        }

        public interface IContentRating : IValue {}
        public interface IContentRating<T> : IContentRating { new T Value { get; } }
        public class OneOrManyContentRating : OneOrMany<IContentRating>
        {
            public OneOrManyContentRating(IContentRating item) : base(item) { }
            public OneOrManyContentRating(IEnumerable<IContentRating> items) : base(items) { }
            public static implicit operator OneOrManyContentRating (Rating value) { return new OneOrManyContentRating (new ContentRatingRating (value)); }
            public static implicit operator OneOrManyContentRating (Rating[] values) { return new OneOrManyContentRating (values.Select(v => (IContentRating) new ContentRatingRating (v))); }
            public static implicit operator OneOrManyContentRating (List<Rating> values) { return new OneOrManyContentRating (values.Select(v => (IContentRating) new ContentRatingRating (v))); }
            public static implicit operator OneOrManyContentRating (string value) { return new OneOrManyContentRating (new ContentRatingstring (value)); }
            public static implicit operator OneOrManyContentRating (string[] values) { return new OneOrManyContentRating (values.Select(v => (IContentRating) new ContentRatingstring (v))); }
            public static implicit operator OneOrManyContentRating (List<string> values) { return new OneOrManyContentRating (values.Select(v => (IContentRating) new ContentRatingstring (v))); }
        }
        public struct ContentRatingRating : IContentRating<Rating>
        {
            object IValue.Value => this.Value;
            public Rating Value { get; }
            public ContentRatingRating (Rating value) { Value = value; }
            public static implicit operator ContentRatingRating (Rating value) { return new ContentRatingRating (value); }
        }
        public struct ContentRatingstring : IContentRating<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ContentRatingstring (string value) { Value = value; }
            public static implicit operator ContentRatingstring (string value) { return new ContentRatingstring (value); }
        }

        public interface IContentReferenceTime : IValue {}
        public interface IContentReferenceTime<T> : IContentReferenceTime { new T Value { get; } }
        public class OneOrManyContentReferenceTime : OneOrMany<IContentReferenceTime>
        {
            public OneOrManyContentReferenceTime(IContentReferenceTime item) : base(item) { }
            public OneOrManyContentReferenceTime(IEnumerable<IContentReferenceTime> items) : base(items) { }
            public static implicit operator OneOrManyContentReferenceTime (DateTimeOffset value) { return new OneOrManyContentReferenceTime (new ContentReferenceTimeDateTimeOffset (value)); }
            public static implicit operator OneOrManyContentReferenceTime (DateTimeOffset[] values) { return new OneOrManyContentReferenceTime (values.Select(v => (IContentReferenceTime) new ContentReferenceTimeDateTimeOffset (v))); }
            public static implicit operator OneOrManyContentReferenceTime (List<DateTimeOffset> values) { return new OneOrManyContentReferenceTime (values.Select(v => (IContentReferenceTime) new ContentReferenceTimeDateTimeOffset (v))); }
        }
        public struct ContentReferenceTimeDateTimeOffset : IContentReferenceTime<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public ContentReferenceTimeDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator ContentReferenceTimeDateTimeOffset (DateTimeOffset value) { return new ContentReferenceTimeDateTimeOffset (value); }
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

        public interface ICopyrightHolder : IValue {}
        public interface ICopyrightHolder<T> : ICopyrightHolder { new T Value { get; } }
        public class OneOrManyCopyrightHolder : OneOrMany<ICopyrightHolder>
        {
            public OneOrManyCopyrightHolder(ICopyrightHolder item) : base(item) { }
            public OneOrManyCopyrightHolder(IEnumerable<ICopyrightHolder> items) : base(items) { }
            public static implicit operator OneOrManyCopyrightHolder (Organization value) { return new OneOrManyCopyrightHolder (new CopyrightHolderOrganization (value)); }
            public static implicit operator OneOrManyCopyrightHolder (Organization[] values) { return new OneOrManyCopyrightHolder (values.Select(v => (ICopyrightHolder) new CopyrightHolderOrganization (v))); }
            public static implicit operator OneOrManyCopyrightHolder (List<Organization> values) { return new OneOrManyCopyrightHolder (values.Select(v => (ICopyrightHolder) new CopyrightHolderOrganization (v))); }
            public static implicit operator OneOrManyCopyrightHolder (Person value) { return new OneOrManyCopyrightHolder (new CopyrightHolderPerson (value)); }
            public static implicit operator OneOrManyCopyrightHolder (Person[] values) { return new OneOrManyCopyrightHolder (values.Select(v => (ICopyrightHolder) new CopyrightHolderPerson (v))); }
            public static implicit operator OneOrManyCopyrightHolder (List<Person> values) { return new OneOrManyCopyrightHolder (values.Select(v => (ICopyrightHolder) new CopyrightHolderPerson (v))); }
        }
        public struct CopyrightHolderOrganization : ICopyrightHolder<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public CopyrightHolderOrganization (Organization value) { Value = value; }
            public static implicit operator CopyrightHolderOrganization (Organization value) { return new CopyrightHolderOrganization (value); }
        }
        public struct CopyrightHolderPerson : ICopyrightHolder<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public CopyrightHolderPerson (Person value) { Value = value; }
            public static implicit operator CopyrightHolderPerson (Person value) { return new CopyrightHolderPerson (value); }
        }

        public interface ICopyrightYear : IValue {}
        public interface ICopyrightYear<T> : ICopyrightYear { new T Value { get; } }
        public class OneOrManyCopyrightYear : OneOrMany<ICopyrightYear>
        {
            public OneOrManyCopyrightYear(ICopyrightYear item) : base(item) { }
            public OneOrManyCopyrightYear(IEnumerable<ICopyrightYear> items) : base(items) { }
            public static implicit operator OneOrManyCopyrightYear (int value) { return new OneOrManyCopyrightYear (new CopyrightYearint (value)); }
            public static implicit operator OneOrManyCopyrightYear (int[] values) { return new OneOrManyCopyrightYear (values.Select(v => (ICopyrightYear) new CopyrightYearint (v))); }
            public static implicit operator OneOrManyCopyrightYear (List<int> values) { return new OneOrManyCopyrightYear (values.Select(v => (ICopyrightYear) new CopyrightYearint (v))); }
        }
        public struct CopyrightYearint : ICopyrightYear<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public CopyrightYearint (int value) { Value = value; }
            public static implicit operator CopyrightYearint (int value) { return new CopyrightYearint (value); }
        }

        public interface ICorrection : IValue {}
        public interface ICorrection<T> : ICorrection { new T Value { get; } }
        public class OneOrManyCorrection : OneOrMany<ICorrection>
        {
            public OneOrManyCorrection(ICorrection item) : base(item) { }
            public OneOrManyCorrection(IEnumerable<ICorrection> items) : base(items) { }
            public static implicit operator OneOrManyCorrection (string value) { return new OneOrManyCorrection (new Correctionstring (value)); }
            public static implicit operator OneOrManyCorrection (string[] values) { return new OneOrManyCorrection (values.Select(v => (ICorrection) new Correctionstring (v))); }
            public static implicit operator OneOrManyCorrection (List<string> values) { return new OneOrManyCorrection (values.Select(v => (ICorrection) new Correctionstring (v))); }
            public static implicit operator OneOrManyCorrection (Uri value) { return new OneOrManyCorrection (new CorrectionUri (value)); }
            public static implicit operator OneOrManyCorrection (Uri[] values) { return new OneOrManyCorrection (values.Select(v => (ICorrection) new CorrectionUri (v))); }
            public static implicit operator OneOrManyCorrection (List<Uri> values) { return new OneOrManyCorrection (values.Select(v => (ICorrection) new CorrectionUri (v))); }
        }
        public struct Correctionstring : ICorrection<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Correctionstring (string value) { Value = value; }
            public static implicit operator Correctionstring (string value) { return new Correctionstring (value); }
        }
        public struct CorrectionUri : ICorrection<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public CorrectionUri (Uri value) { Value = value; }
            public static implicit operator CorrectionUri (Uri value) { return new CorrectionUri (value); }
        }

        public interface ICreator : IValue {}
        public interface ICreator<T> : ICreator { new T Value { get; } }
        public class OneOrManyCreator : OneOrMany<ICreator>
        {
            public OneOrManyCreator(ICreator item) : base(item) { }
            public OneOrManyCreator(IEnumerable<ICreator> items) : base(items) { }
            public static implicit operator OneOrManyCreator (Organization value) { return new OneOrManyCreator (new CreatorOrganization (value)); }
            public static implicit operator OneOrManyCreator (Organization[] values) { return new OneOrManyCreator (values.Select(v => (ICreator) new CreatorOrganization (v))); }
            public static implicit operator OneOrManyCreator (List<Organization> values) { return new OneOrManyCreator (values.Select(v => (ICreator) new CreatorOrganization (v))); }
            public static implicit operator OneOrManyCreator (Person value) { return new OneOrManyCreator (new CreatorPerson (value)); }
            public static implicit operator OneOrManyCreator (Person[] values) { return new OneOrManyCreator (values.Select(v => (ICreator) new CreatorPerson (v))); }
            public static implicit operator OneOrManyCreator (List<Person> values) { return new OneOrManyCreator (values.Select(v => (ICreator) new CreatorPerson (v))); }
        }
        public struct CreatorOrganization : ICreator<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public CreatorOrganization (Organization value) { Value = value; }
            public static implicit operator CreatorOrganization (Organization value) { return new CreatorOrganization (value); }
        }
        public struct CreatorPerson : ICreator<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public CreatorPerson (Person value) { Value = value; }
            public static implicit operator CreatorPerson (Person value) { return new CreatorPerson (value); }
        }

        public interface IDateCreated : IValue {}
        public interface IDateCreated<T> : IDateCreated { new T Value { get; } }
        public class OneOrManyDateCreated : OneOrMany<IDateCreated>
        {
            public OneOrManyDateCreated(IDateCreated item) : base(item) { }
            public OneOrManyDateCreated(IEnumerable<IDateCreated> items) : base(items) { }
            public static implicit operator OneOrManyDateCreated (DateTimeOffset value) { return new OneOrManyDateCreated (new DateCreatedDateTimeOffset (value)); }
            public static implicit operator OneOrManyDateCreated (DateTimeOffset[] values) { return new OneOrManyDateCreated (values.Select(v => (IDateCreated) new DateCreatedDateTimeOffset (v))); }
            public static implicit operator OneOrManyDateCreated (List<DateTimeOffset> values) { return new OneOrManyDateCreated (values.Select(v => (IDateCreated) new DateCreatedDateTimeOffset (v))); }
        }
        public struct DateCreatedDateTimeOffset : IDateCreated<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public DateCreatedDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator DateCreatedDateTimeOffset (DateTimeOffset value) { return new DateCreatedDateTimeOffset (value); }
        }

        public interface IDateModified : IValue {}
        public interface IDateModified<T> : IDateModified { new T Value { get; } }
        public class OneOrManyDateModified : OneOrMany<IDateModified>
        {
            public OneOrManyDateModified(IDateModified item) : base(item) { }
            public OneOrManyDateModified(IEnumerable<IDateModified> items) : base(items) { }
            public static implicit operator OneOrManyDateModified (DateTimeOffset value) { return new OneOrManyDateModified (new DateModifiedDateTimeOffset (value)); }
            public static implicit operator OneOrManyDateModified (DateTimeOffset[] values) { return new OneOrManyDateModified (values.Select(v => (IDateModified) new DateModifiedDateTimeOffset (v))); }
            public static implicit operator OneOrManyDateModified (List<DateTimeOffset> values) { return new OneOrManyDateModified (values.Select(v => (IDateModified) new DateModifiedDateTimeOffset (v))); }
        }
        public struct DateModifiedDateTimeOffset : IDateModified<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public DateModifiedDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator DateModifiedDateTimeOffset (DateTimeOffset value) { return new DateModifiedDateTimeOffset (value); }
        }

        public interface IDatePublished : IValue {}
        public interface IDatePublished<T> : IDatePublished { new T Value { get; } }
        public class OneOrManyDatePublished : OneOrMany<IDatePublished>
        {
            public OneOrManyDatePublished(IDatePublished item) : base(item) { }
            public OneOrManyDatePublished(IEnumerable<IDatePublished> items) : base(items) { }
            public static implicit operator OneOrManyDatePublished (DateTimeOffset value) { return new OneOrManyDatePublished (new DatePublishedDateTimeOffset (value)); }
            public static implicit operator OneOrManyDatePublished (DateTimeOffset[] values) { return new OneOrManyDatePublished (values.Select(v => (IDatePublished) new DatePublishedDateTimeOffset (v))); }
            public static implicit operator OneOrManyDatePublished (List<DateTimeOffset> values) { return new OneOrManyDatePublished (values.Select(v => (IDatePublished) new DatePublishedDateTimeOffset (v))); }
        }
        public struct DatePublishedDateTimeOffset : IDatePublished<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public DatePublishedDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator DatePublishedDateTimeOffset (DateTimeOffset value) { return new DatePublishedDateTimeOffset (value); }
        }

        public interface IDiscussionUrl : IValue {}
        public interface IDiscussionUrl<T> : IDiscussionUrl { new T Value { get; } }
        public class OneOrManyDiscussionUrl : OneOrMany<IDiscussionUrl>
        {
            public OneOrManyDiscussionUrl(IDiscussionUrl item) : base(item) { }
            public OneOrManyDiscussionUrl(IEnumerable<IDiscussionUrl> items) : base(items) { }
            public static implicit operator OneOrManyDiscussionUrl (Uri value) { return new OneOrManyDiscussionUrl (new DiscussionUrlUri (value)); }
            public static implicit operator OneOrManyDiscussionUrl (Uri[] values) { return new OneOrManyDiscussionUrl (values.Select(v => (IDiscussionUrl) new DiscussionUrlUri (v))); }
            public static implicit operator OneOrManyDiscussionUrl (List<Uri> values) { return new OneOrManyDiscussionUrl (values.Select(v => (IDiscussionUrl) new DiscussionUrlUri (v))); }
        }
        public struct DiscussionUrlUri : IDiscussionUrl<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public DiscussionUrlUri (Uri value) { Value = value; }
            public static implicit operator DiscussionUrlUri (Uri value) { return new DiscussionUrlUri (value); }
        }

        public interface IEditor : IValue {}
        public interface IEditor<T> : IEditor { new T Value { get; } }
        public class OneOrManyEditor : OneOrMany<IEditor>
        {
            public OneOrManyEditor(IEditor item) : base(item) { }
            public OneOrManyEditor(IEnumerable<IEditor> items) : base(items) { }
            public static implicit operator OneOrManyEditor (Person value) { return new OneOrManyEditor (new EditorPerson (value)); }
            public static implicit operator OneOrManyEditor (Person[] values) { return new OneOrManyEditor (values.Select(v => (IEditor) new EditorPerson (v))); }
            public static implicit operator OneOrManyEditor (List<Person> values) { return new OneOrManyEditor (values.Select(v => (IEditor) new EditorPerson (v))); }
        }
        public struct EditorPerson : IEditor<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public EditorPerson (Person value) { Value = value; }
            public static implicit operator EditorPerson (Person value) { return new EditorPerson (value); }
        }

        public interface IEducationalAlignment : IValue {}
        public interface IEducationalAlignment<T> : IEducationalAlignment { new T Value { get; } }
        public class OneOrManyEducationalAlignment : OneOrMany<IEducationalAlignment>
        {
            public OneOrManyEducationalAlignment(IEducationalAlignment item) : base(item) { }
            public OneOrManyEducationalAlignment(IEnumerable<IEducationalAlignment> items) : base(items) { }
            public static implicit operator OneOrManyEducationalAlignment (AlignmentObject value) { return new OneOrManyEducationalAlignment (new EducationalAlignmentAlignmentObject (value)); }
            public static implicit operator OneOrManyEducationalAlignment (AlignmentObject[] values) { return new OneOrManyEducationalAlignment (values.Select(v => (IEducationalAlignment) new EducationalAlignmentAlignmentObject (v))); }
            public static implicit operator OneOrManyEducationalAlignment (List<AlignmentObject> values) { return new OneOrManyEducationalAlignment (values.Select(v => (IEducationalAlignment) new EducationalAlignmentAlignmentObject (v))); }
        }
        public struct EducationalAlignmentAlignmentObject : IEducationalAlignment<AlignmentObject>
        {
            object IValue.Value => this.Value;
            public AlignmentObject Value { get; }
            public EducationalAlignmentAlignmentObject (AlignmentObject value) { Value = value; }
            public static implicit operator EducationalAlignmentAlignmentObject (AlignmentObject value) { return new EducationalAlignmentAlignmentObject (value); }
        }

        public interface IEducationalUse : IValue {}
        public interface IEducationalUse<T> : IEducationalUse { new T Value { get; } }
        public class OneOrManyEducationalUse : OneOrMany<IEducationalUse>
        {
            public OneOrManyEducationalUse(IEducationalUse item) : base(item) { }
            public OneOrManyEducationalUse(IEnumerable<IEducationalUse> items) : base(items) { }
            public static implicit operator OneOrManyEducationalUse (string value) { return new OneOrManyEducationalUse (new EducationalUsestring (value)); }
            public static implicit operator OneOrManyEducationalUse (string[] values) { return new OneOrManyEducationalUse (values.Select(v => (IEducationalUse) new EducationalUsestring (v))); }
            public static implicit operator OneOrManyEducationalUse (List<string> values) { return new OneOrManyEducationalUse (values.Select(v => (IEducationalUse) new EducationalUsestring (v))); }
        }
        public struct EducationalUsestring : IEducationalUse<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public EducationalUsestring (string value) { Value = value; }
            public static implicit operator EducationalUsestring (string value) { return new EducationalUsestring (value); }
        }

        public interface IEncoding : IValue {}
        public interface IEncoding<T> : IEncoding { new T Value { get; } }
        public class OneOrManyEncoding : OneOrMany<IEncoding>
        {
            public OneOrManyEncoding(IEncoding item) : base(item) { }
            public OneOrManyEncoding(IEnumerable<IEncoding> items) : base(items) { }
            public static implicit operator OneOrManyEncoding (MediaObject value) { return new OneOrManyEncoding (new EncodingMediaObject (value)); }
            public static implicit operator OneOrManyEncoding (MediaObject[] values) { return new OneOrManyEncoding (values.Select(v => (IEncoding) new EncodingMediaObject (v))); }
            public static implicit operator OneOrManyEncoding (List<MediaObject> values) { return new OneOrManyEncoding (values.Select(v => (IEncoding) new EncodingMediaObject (v))); }
        }
        public struct EncodingMediaObject : IEncoding<MediaObject>
        {
            object IValue.Value => this.Value;
            public MediaObject Value { get; }
            public EncodingMediaObject (MediaObject value) { Value = value; }
            public static implicit operator EncodingMediaObject (MediaObject value) { return new EncodingMediaObject (value); }
        }

        public interface IEncodingFormat : IValue {}
        public interface IEncodingFormat<T> : IEncodingFormat { new T Value { get; } }
        public class OneOrManyEncodingFormat : OneOrMany<IEncodingFormat>
        {
            public OneOrManyEncodingFormat(IEncodingFormat item) : base(item) { }
            public OneOrManyEncodingFormat(IEnumerable<IEncodingFormat> items) : base(items) { }
            public static implicit operator OneOrManyEncodingFormat (string value) { return new OneOrManyEncodingFormat (new EncodingFormatstring (value)); }
            public static implicit operator OneOrManyEncodingFormat (string[] values) { return new OneOrManyEncodingFormat (values.Select(v => (IEncodingFormat) new EncodingFormatstring (v))); }
            public static implicit operator OneOrManyEncodingFormat (List<string> values) { return new OneOrManyEncodingFormat (values.Select(v => (IEncodingFormat) new EncodingFormatstring (v))); }
            public static implicit operator OneOrManyEncodingFormat (Uri value) { return new OneOrManyEncodingFormat (new EncodingFormatUri (value)); }
            public static implicit operator OneOrManyEncodingFormat (Uri[] values) { return new OneOrManyEncodingFormat (values.Select(v => (IEncodingFormat) new EncodingFormatUri (v))); }
            public static implicit operator OneOrManyEncodingFormat (List<Uri> values) { return new OneOrManyEncodingFormat (values.Select(v => (IEncodingFormat) new EncodingFormatUri (v))); }
        }
        public struct EncodingFormatstring : IEncodingFormat<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public EncodingFormatstring (string value) { Value = value; }
            public static implicit operator EncodingFormatstring (string value) { return new EncodingFormatstring (value); }
        }
        public struct EncodingFormatUri : IEncodingFormat<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public EncodingFormatUri (Uri value) { Value = value; }
            public static implicit operator EncodingFormatUri (Uri value) { return new EncodingFormatUri (value); }
        }

        public interface IExampleOfWork : IValue {}
        public interface IExampleOfWork<T> : IExampleOfWork { new T Value { get; } }
        public class OneOrManyExampleOfWork : OneOrMany<IExampleOfWork>
        {
            public OneOrManyExampleOfWork(IExampleOfWork item) : base(item) { }
            public OneOrManyExampleOfWork(IEnumerable<IExampleOfWork> items) : base(items) { }
            public static implicit operator OneOrManyExampleOfWork (CreativeWork value) { return new OneOrManyExampleOfWork (new ExampleOfWorkCreativeWork (value)); }
            public static implicit operator OneOrManyExampleOfWork (CreativeWork[] values) { return new OneOrManyExampleOfWork (values.Select(v => (IExampleOfWork) new ExampleOfWorkCreativeWork (v))); }
            public static implicit operator OneOrManyExampleOfWork (List<CreativeWork> values) { return new OneOrManyExampleOfWork (values.Select(v => (IExampleOfWork) new ExampleOfWorkCreativeWork (v))); }
        }
        public struct ExampleOfWorkCreativeWork : IExampleOfWork<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public ExampleOfWorkCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator ExampleOfWorkCreativeWork (CreativeWork value) { return new ExampleOfWorkCreativeWork (value); }
        }

        public interface IExpires : IValue {}
        public interface IExpires<T> : IExpires { new T Value { get; } }
        public class OneOrManyExpires : OneOrMany<IExpires>
        {
            public OneOrManyExpires(IExpires item) : base(item) { }
            public OneOrManyExpires(IEnumerable<IExpires> items) : base(items) { }
            public static implicit operator OneOrManyExpires (DateTimeOffset value) { return new OneOrManyExpires (new ExpiresDateTimeOffset (value)); }
            public static implicit operator OneOrManyExpires (DateTimeOffset[] values) { return new OneOrManyExpires (values.Select(v => (IExpires) new ExpiresDateTimeOffset (v))); }
            public static implicit operator OneOrManyExpires (List<DateTimeOffset> values) { return new OneOrManyExpires (values.Select(v => (IExpires) new ExpiresDateTimeOffset (v))); }
        }
        public struct ExpiresDateTimeOffset : IExpires<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public ExpiresDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator ExpiresDateTimeOffset (DateTimeOffset value) { return new ExpiresDateTimeOffset (value); }
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

        public interface IGenre : IValue {}
        public interface IGenre<T> : IGenre { new T Value { get; } }
        public class OneOrManyGenre : OneOrMany<IGenre>
        {
            public OneOrManyGenre(IGenre item) : base(item) { }
            public OneOrManyGenre(IEnumerable<IGenre> items) : base(items) { }
            public static implicit operator OneOrManyGenre (string value) { return new OneOrManyGenre (new Genrestring (value)); }
            public static implicit operator OneOrManyGenre (string[] values) { return new OneOrManyGenre (values.Select(v => (IGenre) new Genrestring (v))); }
            public static implicit operator OneOrManyGenre (List<string> values) { return new OneOrManyGenre (values.Select(v => (IGenre) new Genrestring (v))); }
            public static implicit operator OneOrManyGenre (Uri value) { return new OneOrManyGenre (new GenreUri (value)); }
            public static implicit operator OneOrManyGenre (Uri[] values) { return new OneOrManyGenre (values.Select(v => (IGenre) new GenreUri (v))); }
            public static implicit operator OneOrManyGenre (List<Uri> values) { return new OneOrManyGenre (values.Select(v => (IGenre) new GenreUri (v))); }
        }
        public struct Genrestring : IGenre<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Genrestring (string value) { Value = value; }
            public static implicit operator Genrestring (string value) { return new Genrestring (value); }
        }
        public struct GenreUri : IGenre<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public GenreUri (Uri value) { Value = value; }
            public static implicit operator GenreUri (Uri value) { return new GenreUri (value); }
        }

        public interface IHasPart : IValue {}
        public interface IHasPart<T> : IHasPart { new T Value { get; } }
        public class OneOrManyHasPart : OneOrMany<IHasPart>
        {
            public OneOrManyHasPart(IHasPart item) : base(item) { }
            public OneOrManyHasPart(IEnumerable<IHasPart> items) : base(items) { }
            public static implicit operator OneOrManyHasPart (CreativeWork value) { return new OneOrManyHasPart (new HasPartCreativeWork (value)); }
            public static implicit operator OneOrManyHasPart (CreativeWork[] values) { return new OneOrManyHasPart (values.Select(v => (IHasPart) new HasPartCreativeWork (v))); }
            public static implicit operator OneOrManyHasPart (List<CreativeWork> values) { return new OneOrManyHasPart (values.Select(v => (IHasPart) new HasPartCreativeWork (v))); }
        }
        public struct HasPartCreativeWork : IHasPart<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public HasPartCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator HasPartCreativeWork (CreativeWork value) { return new HasPartCreativeWork (value); }
        }

        public interface IHeadline : IValue {}
        public interface IHeadline<T> : IHeadline { new T Value { get; } }
        public class OneOrManyHeadline : OneOrMany<IHeadline>
        {
            public OneOrManyHeadline(IHeadline item) : base(item) { }
            public OneOrManyHeadline(IEnumerable<IHeadline> items) : base(items) { }
            public static implicit operator OneOrManyHeadline (string value) { return new OneOrManyHeadline (new Headlinestring (value)); }
            public static implicit operator OneOrManyHeadline (string[] values) { return new OneOrManyHeadline (values.Select(v => (IHeadline) new Headlinestring (v))); }
            public static implicit operator OneOrManyHeadline (List<string> values) { return new OneOrManyHeadline (values.Select(v => (IHeadline) new Headlinestring (v))); }
        }
        public struct Headlinestring : IHeadline<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Headlinestring (string value) { Value = value; }
            public static implicit operator Headlinestring (string value) { return new Headlinestring (value); }
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

        public interface IInteractionStatistic : IValue {}
        public interface IInteractionStatistic<T> : IInteractionStatistic { new T Value { get; } }
        public class OneOrManyInteractionStatistic : OneOrMany<IInteractionStatistic>
        {
            public OneOrManyInteractionStatistic(IInteractionStatistic item) : base(item) { }
            public OneOrManyInteractionStatistic(IEnumerable<IInteractionStatistic> items) : base(items) { }
            public static implicit operator OneOrManyInteractionStatistic (InteractionCounter value) { return new OneOrManyInteractionStatistic (new InteractionStatisticInteractionCounter (value)); }
            public static implicit operator OneOrManyInteractionStatistic (InteractionCounter[] values) { return new OneOrManyInteractionStatistic (values.Select(v => (IInteractionStatistic) new InteractionStatisticInteractionCounter (v))); }
            public static implicit operator OneOrManyInteractionStatistic (List<InteractionCounter> values) { return new OneOrManyInteractionStatistic (values.Select(v => (IInteractionStatistic) new InteractionStatisticInteractionCounter (v))); }
        }
        public struct InteractionStatisticInteractionCounter : IInteractionStatistic<InteractionCounter>
        {
            object IValue.Value => this.Value;
            public InteractionCounter Value { get; }
            public InteractionStatisticInteractionCounter (InteractionCounter value) { Value = value; }
            public static implicit operator InteractionStatisticInteractionCounter (InteractionCounter value) { return new InteractionStatisticInteractionCounter (value); }
        }

        public interface IInteractivityType : IValue {}
        public interface IInteractivityType<T> : IInteractivityType { new T Value { get; } }
        public class OneOrManyInteractivityType : OneOrMany<IInteractivityType>
        {
            public OneOrManyInteractivityType(IInteractivityType item) : base(item) { }
            public OneOrManyInteractivityType(IEnumerable<IInteractivityType> items) : base(items) { }
            public static implicit operator OneOrManyInteractivityType (string value) { return new OneOrManyInteractivityType (new InteractivityTypestring (value)); }
            public static implicit operator OneOrManyInteractivityType (string[] values) { return new OneOrManyInteractivityType (values.Select(v => (IInteractivityType) new InteractivityTypestring (v))); }
            public static implicit operator OneOrManyInteractivityType (List<string> values) { return new OneOrManyInteractivityType (values.Select(v => (IInteractivityType) new InteractivityTypestring (v))); }
        }
        public struct InteractivityTypestring : IInteractivityType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public InteractivityTypestring (string value) { Value = value; }
            public static implicit operator InteractivityTypestring (string value) { return new InteractivityTypestring (value); }
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

        public interface IIsBasedOn : IValue {}
        public interface IIsBasedOn<T> : IIsBasedOn { new T Value { get; } }
        public class OneOrManyIsBasedOn : OneOrMany<IIsBasedOn>
        {
            public OneOrManyIsBasedOn(IIsBasedOn item) : base(item) { }
            public OneOrManyIsBasedOn(IEnumerable<IIsBasedOn> items) : base(items) { }
            public static implicit operator OneOrManyIsBasedOn (CreativeWork value) { return new OneOrManyIsBasedOn (new IsBasedOnCreativeWork (value)); }
            public static implicit operator OneOrManyIsBasedOn (CreativeWork[] values) { return new OneOrManyIsBasedOn (values.Select(v => (IIsBasedOn) new IsBasedOnCreativeWork (v))); }
            public static implicit operator OneOrManyIsBasedOn (List<CreativeWork> values) { return new OneOrManyIsBasedOn (values.Select(v => (IIsBasedOn) new IsBasedOnCreativeWork (v))); }
            public static implicit operator OneOrManyIsBasedOn (Product value) { return new OneOrManyIsBasedOn (new IsBasedOnProduct (value)); }
            public static implicit operator OneOrManyIsBasedOn (Product[] values) { return new OneOrManyIsBasedOn (values.Select(v => (IIsBasedOn) new IsBasedOnProduct (v))); }
            public static implicit operator OneOrManyIsBasedOn (List<Product> values) { return new OneOrManyIsBasedOn (values.Select(v => (IIsBasedOn) new IsBasedOnProduct (v))); }
            public static implicit operator OneOrManyIsBasedOn (Uri value) { return new OneOrManyIsBasedOn (new IsBasedOnUri (value)); }
            public static implicit operator OneOrManyIsBasedOn (Uri[] values) { return new OneOrManyIsBasedOn (values.Select(v => (IIsBasedOn) new IsBasedOnUri (v))); }
            public static implicit operator OneOrManyIsBasedOn (List<Uri> values) { return new OneOrManyIsBasedOn (values.Select(v => (IIsBasedOn) new IsBasedOnUri (v))); }
        }
        public struct IsBasedOnCreativeWork : IIsBasedOn<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public IsBasedOnCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator IsBasedOnCreativeWork (CreativeWork value) { return new IsBasedOnCreativeWork (value); }
        }
        public struct IsBasedOnProduct : IIsBasedOn<Product>
        {
            object IValue.Value => this.Value;
            public Product Value { get; }
            public IsBasedOnProduct (Product value) { Value = value; }
            public static implicit operator IsBasedOnProduct (Product value) { return new IsBasedOnProduct (value); }
        }
        public struct IsBasedOnUri : IIsBasedOn<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public IsBasedOnUri (Uri value) { Value = value; }
            public static implicit operator IsBasedOnUri (Uri value) { return new IsBasedOnUri (value); }
        }

        public interface IIsFamilyFriendly : IValue {}
        public interface IIsFamilyFriendly<T> : IIsFamilyFriendly { new T Value { get; } }
        public class OneOrManyIsFamilyFriendly : OneOrMany<IIsFamilyFriendly>
        {
            public OneOrManyIsFamilyFriendly(IIsFamilyFriendly item) : base(item) { }
            public OneOrManyIsFamilyFriendly(IEnumerable<IIsFamilyFriendly> items) : base(items) { }
            public static implicit operator OneOrManyIsFamilyFriendly (bool value) { return new OneOrManyIsFamilyFriendly (new IsFamilyFriendlybool (value)); }
            public static implicit operator OneOrManyIsFamilyFriendly (bool[] values) { return new OneOrManyIsFamilyFriendly (values.Select(v => (IIsFamilyFriendly) new IsFamilyFriendlybool (v))); }
            public static implicit operator OneOrManyIsFamilyFriendly (List<bool> values) { return new OneOrManyIsFamilyFriendly (values.Select(v => (IIsFamilyFriendly) new IsFamilyFriendlybool (v))); }
        }
        public struct IsFamilyFriendlybool : IIsFamilyFriendly<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public IsFamilyFriendlybool (bool value) { Value = value; }
            public static implicit operator IsFamilyFriendlybool (bool value) { return new IsFamilyFriendlybool (value); }
        }

        public interface IIsPartOf : IValue {}
        public interface IIsPartOf<T> : IIsPartOf { new T Value { get; } }
        public class OneOrManyIsPartOf : OneOrMany<IIsPartOf>
        {
            public OneOrManyIsPartOf(IIsPartOf item) : base(item) { }
            public OneOrManyIsPartOf(IEnumerable<IIsPartOf> items) : base(items) { }
            public static implicit operator OneOrManyIsPartOf (CreativeWork value) { return new OneOrManyIsPartOf (new IsPartOfCreativeWork (value)); }
            public static implicit operator OneOrManyIsPartOf (CreativeWork[] values) { return new OneOrManyIsPartOf (values.Select(v => (IIsPartOf) new IsPartOfCreativeWork (v))); }
            public static implicit operator OneOrManyIsPartOf (List<CreativeWork> values) { return new OneOrManyIsPartOf (values.Select(v => (IIsPartOf) new IsPartOfCreativeWork (v))); }
        }
        public struct IsPartOfCreativeWork : IIsPartOf<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public IsPartOfCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator IsPartOfCreativeWork (CreativeWork value) { return new IsPartOfCreativeWork (value); }
        }

        public interface IItem : IValue {}
        public interface IItem<T> : IItem { new T Value { get; } }
        public class OneOrManyItem : OneOrMany<IItem>
        {
            public OneOrManyItem(IItem item) : base(item) { }
            public OneOrManyItem(IEnumerable<IItem> items) : base(items) { }
            public static implicit operator OneOrManyItem (Thing value) { return new OneOrManyItem (new ItemThing (value)); }
            public static implicit operator OneOrManyItem (Thing[] values) { return new OneOrManyItem (values.Select(v => (IItem) new ItemThing (v))); }
            public static implicit operator OneOrManyItem (List<Thing> values) { return new OneOrManyItem (values.Select(v => (IItem) new ItemThing (v))); }
        }
        public struct ItemThing : IItem<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public ItemThing (Thing value) { Value = value; }
            public static implicit operator ItemThing (Thing value) { return new ItemThing (value); }
        }

        public interface IItemListElement : IValue {}
        public interface IItemListElement<T> : IItemListElement { new T Value { get; } }
        public class OneOrManyItemListElement : OneOrMany<IItemListElement>
        {
            public OneOrManyItemListElement(IItemListElement item) : base(item) { }
            public OneOrManyItemListElement(IEnumerable<IItemListElement> items) : base(items) { }
            public static implicit operator OneOrManyItemListElement (ListItem value) { return new OneOrManyItemListElement (new ItemListElementListItem (value)); }
            public static implicit operator OneOrManyItemListElement (ListItem[] values) { return new OneOrManyItemListElement (values.Select(v => (IItemListElement) new ItemListElementListItem (v))); }
            public static implicit operator OneOrManyItemListElement (List<ListItem> values) { return new OneOrManyItemListElement (values.Select(v => (IItemListElement) new ItemListElementListItem (v))); }
            public static implicit operator OneOrManyItemListElement (string value) { return new OneOrManyItemListElement (new ItemListElementstring (value)); }
            public static implicit operator OneOrManyItemListElement (string[] values) { return new OneOrManyItemListElement (values.Select(v => (IItemListElement) new ItemListElementstring (v))); }
            public static implicit operator OneOrManyItemListElement (List<string> values) { return new OneOrManyItemListElement (values.Select(v => (IItemListElement) new ItemListElementstring (v))); }
            public static implicit operator OneOrManyItemListElement (Thing value) { return new OneOrManyItemListElement (new ItemListElementThing (value)); }
            public static implicit operator OneOrManyItemListElement (Thing[] values) { return new OneOrManyItemListElement (values.Select(v => (IItemListElement) new ItemListElementThing (v))); }
            public static implicit operator OneOrManyItemListElement (List<Thing> values) { return new OneOrManyItemListElement (values.Select(v => (IItemListElement) new ItemListElementThing (v))); }
        }
        public struct ItemListElementListItem : IItemListElement<ListItem>
        {
            object IValue.Value => this.Value;
            public ListItem Value { get; }
            public ItemListElementListItem (ListItem value) { Value = value; }
            public static implicit operator ItemListElementListItem (ListItem value) { return new ItemListElementListItem (value); }
        }
        public struct ItemListElementstring : IItemListElement<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ItemListElementstring (string value) { Value = value; }
            public static implicit operator ItemListElementstring (string value) { return new ItemListElementstring (value); }
        }
        public struct ItemListElementThing : IItemListElement<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public ItemListElementThing (Thing value) { Value = value; }
            public static implicit operator ItemListElementThing (Thing value) { return new ItemListElementThing (value); }
        }

        public interface IItemListOrder : IValue {}
        public interface IItemListOrder<T> : IItemListOrder { new T Value { get; } }
        public class OneOrManyItemListOrder : OneOrMany<IItemListOrder>
        {
            public OneOrManyItemListOrder(IItemListOrder item) : base(item) { }
            public OneOrManyItemListOrder(IEnumerable<IItemListOrder> items) : base(items) { }
            public static implicit operator OneOrManyItemListOrder (ItemListOrderType value) { return new OneOrManyItemListOrder (new ItemListOrderItemListOrderType (value)); }
            public static implicit operator OneOrManyItemListOrder (ItemListOrderType[] values) { return new OneOrManyItemListOrder (values.Select(v => (IItemListOrder) new ItemListOrderItemListOrderType (v))); }
            public static implicit operator OneOrManyItemListOrder (List<ItemListOrderType> values) { return new OneOrManyItemListOrder (values.Select(v => (IItemListOrder) new ItemListOrderItemListOrderType (v))); }
            public static implicit operator OneOrManyItemListOrder (string value) { return new OneOrManyItemListOrder (new ItemListOrderstring (value)); }
            public static implicit operator OneOrManyItemListOrder (string[] values) { return new OneOrManyItemListOrder (values.Select(v => (IItemListOrder) new ItemListOrderstring (v))); }
            public static implicit operator OneOrManyItemListOrder (List<string> values) { return new OneOrManyItemListOrder (values.Select(v => (IItemListOrder) new ItemListOrderstring (v))); }
        }
        public struct ItemListOrderItemListOrderType : IItemListOrder<ItemListOrderType>
        {
            object IValue.Value => this.Value;
            public ItemListOrderType Value { get; }
            public ItemListOrderItemListOrderType (ItemListOrderType value) { Value = value; }
            public static implicit operator ItemListOrderItemListOrderType (ItemListOrderType value) { return new ItemListOrderItemListOrderType (value); }
        }
        public struct ItemListOrderstring : IItemListOrder<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ItemListOrderstring (string value) { Value = value; }
            public static implicit operator ItemListOrderstring (string value) { return new ItemListOrderstring (value); }
        }

        public interface IKeywords : IValue {}
        public interface IKeywords<T> : IKeywords { new T Value { get; } }
        public class OneOrManyKeywords : OneOrMany<IKeywords>
        {
            public OneOrManyKeywords(IKeywords item) : base(item) { }
            public OneOrManyKeywords(IEnumerable<IKeywords> items) : base(items) { }
            public static implicit operator OneOrManyKeywords (string value) { return new OneOrManyKeywords (new Keywordsstring (value)); }
            public static implicit operator OneOrManyKeywords (string[] values) { return new OneOrManyKeywords (values.Select(v => (IKeywords) new Keywordsstring (v))); }
            public static implicit operator OneOrManyKeywords (List<string> values) { return new OneOrManyKeywords (values.Select(v => (IKeywords) new Keywordsstring (v))); }
        }
        public struct Keywordsstring : IKeywords<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Keywordsstring (string value) { Value = value; }
            public static implicit operator Keywordsstring (string value) { return new Keywordsstring (value); }
        }

        public interface ILearningResourceType : IValue {}
        public interface ILearningResourceType<T> : ILearningResourceType { new T Value { get; } }
        public class OneOrManyLearningResourceType : OneOrMany<ILearningResourceType>
        {
            public OneOrManyLearningResourceType(ILearningResourceType item) : base(item) { }
            public OneOrManyLearningResourceType(IEnumerable<ILearningResourceType> items) : base(items) { }
            public static implicit operator OneOrManyLearningResourceType (string value) { return new OneOrManyLearningResourceType (new LearningResourceTypestring (value)); }
            public static implicit operator OneOrManyLearningResourceType (string[] values) { return new OneOrManyLearningResourceType (values.Select(v => (ILearningResourceType) new LearningResourceTypestring (v))); }
            public static implicit operator OneOrManyLearningResourceType (List<string> values) { return new OneOrManyLearningResourceType (values.Select(v => (ILearningResourceType) new LearningResourceTypestring (v))); }
        }
        public struct LearningResourceTypestring : ILearningResourceType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public LearningResourceTypestring (string value) { Value = value; }
            public static implicit operator LearningResourceTypestring (string value) { return new LearningResourceTypestring (value); }
        }

        public interface ILicense : IValue {}
        public interface ILicense<T> : ILicense { new T Value { get; } }
        public class OneOrManyLicense : OneOrMany<ILicense>
        {
            public OneOrManyLicense(ILicense item) : base(item) { }
            public OneOrManyLicense(IEnumerable<ILicense> items) : base(items) { }
            public static implicit operator OneOrManyLicense (CreativeWork value) { return new OneOrManyLicense (new LicenseCreativeWork (value)); }
            public static implicit operator OneOrManyLicense (CreativeWork[] values) { return new OneOrManyLicense (values.Select(v => (ILicense) new LicenseCreativeWork (v))); }
            public static implicit operator OneOrManyLicense (List<CreativeWork> values) { return new OneOrManyLicense (values.Select(v => (ILicense) new LicenseCreativeWork (v))); }
            public static implicit operator OneOrManyLicense (Uri value) { return new OneOrManyLicense (new LicenseUri (value)); }
            public static implicit operator OneOrManyLicense (Uri[] values) { return new OneOrManyLicense (values.Select(v => (ILicense) new LicenseUri (v))); }
            public static implicit operator OneOrManyLicense (List<Uri> values) { return new OneOrManyLicense (values.Select(v => (ILicense) new LicenseUri (v))); }
        }
        public struct LicenseCreativeWork : ILicense<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public LicenseCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator LicenseCreativeWork (CreativeWork value) { return new LicenseCreativeWork (value); }
        }
        public struct LicenseUri : ILicense<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public LicenseUri (Uri value) { Value = value; }
            public static implicit operator LicenseUri (Uri value) { return new LicenseUri (value); }
        }

        public interface ILocationCreated : IValue {}
        public interface ILocationCreated<T> : ILocationCreated { new T Value { get; } }
        public class OneOrManyLocationCreated : OneOrMany<ILocationCreated>
        {
            public OneOrManyLocationCreated(ILocationCreated item) : base(item) { }
            public OneOrManyLocationCreated(IEnumerable<ILocationCreated> items) : base(items) { }
            public static implicit operator OneOrManyLocationCreated (Place value) { return new OneOrManyLocationCreated (new LocationCreatedPlace (value)); }
            public static implicit operator OneOrManyLocationCreated (Place[] values) { return new OneOrManyLocationCreated (values.Select(v => (ILocationCreated) new LocationCreatedPlace (v))); }
            public static implicit operator OneOrManyLocationCreated (List<Place> values) { return new OneOrManyLocationCreated (values.Select(v => (ILocationCreated) new LocationCreatedPlace (v))); }
        }
        public struct LocationCreatedPlace : ILocationCreated<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public LocationCreatedPlace (Place value) { Value = value; }
            public static implicit operator LocationCreatedPlace (Place value) { return new LocationCreatedPlace (value); }
        }

        public interface IMainEntity : IValue {}
        public interface IMainEntity<T> : IMainEntity { new T Value { get; } }
        public class OneOrManyMainEntity : OneOrMany<IMainEntity>
        {
            public OneOrManyMainEntity(IMainEntity item) : base(item) { }
            public OneOrManyMainEntity(IEnumerable<IMainEntity> items) : base(items) { }
            public static implicit operator OneOrManyMainEntity (Thing value) { return new OneOrManyMainEntity (new MainEntityThing (value)); }
            public static implicit operator OneOrManyMainEntity (Thing[] values) { return new OneOrManyMainEntity (values.Select(v => (IMainEntity) new MainEntityThing (v))); }
            public static implicit operator OneOrManyMainEntity (List<Thing> values) { return new OneOrManyMainEntity (values.Select(v => (IMainEntity) new MainEntityThing (v))); }
        }
        public struct MainEntityThing : IMainEntity<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public MainEntityThing (Thing value) { Value = value; }
            public static implicit operator MainEntityThing (Thing value) { return new MainEntityThing (value); }
        }

        public interface IMaterial : IValue {}
        public interface IMaterial<T> : IMaterial { new T Value { get; } }
        public class OneOrManyMaterial : OneOrMany<IMaterial>
        {
            public OneOrManyMaterial(IMaterial item) : base(item) { }
            public OneOrManyMaterial(IEnumerable<IMaterial> items) : base(items) { }
            public static implicit operator OneOrManyMaterial (Product value) { return new OneOrManyMaterial (new MaterialProduct (value)); }
            public static implicit operator OneOrManyMaterial (Product[] values) { return new OneOrManyMaterial (values.Select(v => (IMaterial) new MaterialProduct (v))); }
            public static implicit operator OneOrManyMaterial (List<Product> values) { return new OneOrManyMaterial (values.Select(v => (IMaterial) new MaterialProduct (v))); }
            public static implicit operator OneOrManyMaterial (string value) { return new OneOrManyMaterial (new Materialstring (value)); }
            public static implicit operator OneOrManyMaterial (string[] values) { return new OneOrManyMaterial (values.Select(v => (IMaterial) new Materialstring (v))); }
            public static implicit operator OneOrManyMaterial (List<string> values) { return new OneOrManyMaterial (values.Select(v => (IMaterial) new Materialstring (v))); }
            public static implicit operator OneOrManyMaterial (Uri value) { return new OneOrManyMaterial (new MaterialUri (value)); }
            public static implicit operator OneOrManyMaterial (Uri[] values) { return new OneOrManyMaterial (values.Select(v => (IMaterial) new MaterialUri (v))); }
            public static implicit operator OneOrManyMaterial (List<Uri> values) { return new OneOrManyMaterial (values.Select(v => (IMaterial) new MaterialUri (v))); }
        }
        public struct MaterialProduct : IMaterial<Product>
        {
            object IValue.Value => this.Value;
            public Product Value { get; }
            public MaterialProduct (Product value) { Value = value; }
            public static implicit operator MaterialProduct (Product value) { return new MaterialProduct (value); }
        }
        public struct Materialstring : IMaterial<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Materialstring (string value) { Value = value; }
            public static implicit operator Materialstring (string value) { return new Materialstring (value); }
        }
        public struct MaterialUri : IMaterial<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public MaterialUri (Uri value) { Value = value; }
            public static implicit operator MaterialUri (Uri value) { return new MaterialUri (value); }
        }

        public interface IMentions : IValue {}
        public interface IMentions<T> : IMentions { new T Value { get; } }
        public class OneOrManyMentions : OneOrMany<IMentions>
        {
            public OneOrManyMentions(IMentions item) : base(item) { }
            public OneOrManyMentions(IEnumerable<IMentions> items) : base(items) { }
            public static implicit operator OneOrManyMentions (Thing value) { return new OneOrManyMentions (new MentionsThing (value)); }
            public static implicit operator OneOrManyMentions (Thing[] values) { return new OneOrManyMentions (values.Select(v => (IMentions) new MentionsThing (v))); }
            public static implicit operator OneOrManyMentions (List<Thing> values) { return new OneOrManyMentions (values.Select(v => (IMentions) new MentionsThing (v))); }
        }
        public struct MentionsThing : IMentions<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public MentionsThing (Thing value) { Value = value; }
            public static implicit operator MentionsThing (Thing value) { return new MentionsThing (value); }
        }

        public interface INextItem : IValue {}
        public interface INextItem<T> : INextItem { new T Value { get; } }
        public class OneOrManyNextItem : OneOrMany<INextItem>
        {
            public OneOrManyNextItem(INextItem item) : base(item) { }
            public OneOrManyNextItem(IEnumerable<INextItem> items) : base(items) { }
            public static implicit operator OneOrManyNextItem (ListItem value) { return new OneOrManyNextItem (new NextItemListItem (value)); }
            public static implicit operator OneOrManyNextItem (ListItem[] values) { return new OneOrManyNextItem (values.Select(v => (INextItem) new NextItemListItem (v))); }
            public static implicit operator OneOrManyNextItem (List<ListItem> values) { return new OneOrManyNextItem (values.Select(v => (INextItem) new NextItemListItem (v))); }
        }
        public struct NextItemListItem : INextItem<ListItem>
        {
            object IValue.Value => this.Value;
            public ListItem Value { get; }
            public NextItemListItem (ListItem value) { Value = value; }
            public static implicit operator NextItemListItem (ListItem value) { return new NextItemListItem (value); }
        }

        public interface INumberOfItems : IValue {}
        public interface INumberOfItems<T> : INumberOfItems { new T Value { get; } }
        public class OneOrManyNumberOfItems : OneOrMany<INumberOfItems>
        {
            public OneOrManyNumberOfItems(INumberOfItems item) : base(item) { }
            public OneOrManyNumberOfItems(IEnumerable<INumberOfItems> items) : base(items) { }
            public static implicit operator OneOrManyNumberOfItems (int value) { return new OneOrManyNumberOfItems (new NumberOfItemsint (value)); }
            public static implicit operator OneOrManyNumberOfItems (int[] values) { return new OneOrManyNumberOfItems (values.Select(v => (INumberOfItems) new NumberOfItemsint (v))); }
            public static implicit operator OneOrManyNumberOfItems (List<int> values) { return new OneOrManyNumberOfItems (values.Select(v => (INumberOfItems) new NumberOfItemsint (v))); }
        }
        public struct NumberOfItemsint : INumberOfItems<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public NumberOfItemsint (int value) { Value = value; }
            public static implicit operator NumberOfItemsint (int value) { return new NumberOfItemsint (value); }
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

        public interface IPosition : IValue {}
        public interface IPosition<T> : IPosition { new T Value { get; } }
        public class OneOrManyPosition : OneOrMany<IPosition>
        {
            public OneOrManyPosition(IPosition item) : base(item) { }
            public OneOrManyPosition(IEnumerable<IPosition> items) : base(items) { }
            public static implicit operator OneOrManyPosition (int value) { return new OneOrManyPosition (new Positionint (value)); }
            public static implicit operator OneOrManyPosition (int[] values) { return new OneOrManyPosition (values.Select(v => (IPosition) new Positionint (v))); }
            public static implicit operator OneOrManyPosition (List<int> values) { return new OneOrManyPosition (values.Select(v => (IPosition) new Positionint (v))); }
            public static implicit operator OneOrManyPosition (string value) { return new OneOrManyPosition (new Positionstring (value)); }
            public static implicit operator OneOrManyPosition (string[] values) { return new OneOrManyPosition (values.Select(v => (IPosition) new Positionstring (v))); }
            public static implicit operator OneOrManyPosition (List<string> values) { return new OneOrManyPosition (values.Select(v => (IPosition) new Positionstring (v))); }
        }
        public struct Positionint : IPosition<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public Positionint (int value) { Value = value; }
            public static implicit operator Positionint (int value) { return new Positionint (value); }
        }
        public struct Positionstring : IPosition<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Positionstring (string value) { Value = value; }
            public static implicit operator Positionstring (string value) { return new Positionstring (value); }
        }

        public interface IPreviousItem : IValue {}
        public interface IPreviousItem<T> : IPreviousItem { new T Value { get; } }
        public class OneOrManyPreviousItem : OneOrMany<IPreviousItem>
        {
            public OneOrManyPreviousItem(IPreviousItem item) : base(item) { }
            public OneOrManyPreviousItem(IEnumerable<IPreviousItem> items) : base(items) { }
            public static implicit operator OneOrManyPreviousItem (ListItem value) { return new OneOrManyPreviousItem (new PreviousItemListItem (value)); }
            public static implicit operator OneOrManyPreviousItem (ListItem[] values) { return new OneOrManyPreviousItem (values.Select(v => (IPreviousItem) new PreviousItemListItem (v))); }
            public static implicit operator OneOrManyPreviousItem (List<ListItem> values) { return new OneOrManyPreviousItem (values.Select(v => (IPreviousItem) new PreviousItemListItem (v))); }
        }
        public struct PreviousItemListItem : IPreviousItem<ListItem>
        {
            object IValue.Value => this.Value;
            public ListItem Value { get; }
            public PreviousItemListItem (ListItem value) { Value = value; }
            public static implicit operator PreviousItemListItem (ListItem value) { return new PreviousItemListItem (value); }
        }

        public interface IProducer : IValue {}
        public interface IProducer<T> : IProducer { new T Value { get; } }
        public class OneOrManyProducer : OneOrMany<IProducer>
        {
            public OneOrManyProducer(IProducer item) : base(item) { }
            public OneOrManyProducer(IEnumerable<IProducer> items) : base(items) { }
            public static implicit operator OneOrManyProducer (Organization value) { return new OneOrManyProducer (new ProducerOrganization (value)); }
            public static implicit operator OneOrManyProducer (Organization[] values) { return new OneOrManyProducer (values.Select(v => (IProducer) new ProducerOrganization (v))); }
            public static implicit operator OneOrManyProducer (List<Organization> values) { return new OneOrManyProducer (values.Select(v => (IProducer) new ProducerOrganization (v))); }
            public static implicit operator OneOrManyProducer (Person value) { return new OneOrManyProducer (new ProducerPerson (value)); }
            public static implicit operator OneOrManyProducer (Person[] values) { return new OneOrManyProducer (values.Select(v => (IProducer) new ProducerPerson (v))); }
            public static implicit operator OneOrManyProducer (List<Person> values) { return new OneOrManyProducer (values.Select(v => (IProducer) new ProducerPerson (v))); }
        }
        public struct ProducerOrganization : IProducer<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public ProducerOrganization (Organization value) { Value = value; }
            public static implicit operator ProducerOrganization (Organization value) { return new ProducerOrganization (value); }
        }
        public struct ProducerPerson : IProducer<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ProducerPerson (Person value) { Value = value; }
            public static implicit operator ProducerPerson (Person value) { return new ProducerPerson (value); }
        }

        public interface IProvider : IValue {}
        public interface IProvider<T> : IProvider { new T Value { get; } }
        public class OneOrManyProvider : OneOrMany<IProvider>
        {
            public OneOrManyProvider(IProvider item) : base(item) { }
            public OneOrManyProvider(IEnumerable<IProvider> items) : base(items) { }
            public static implicit operator OneOrManyProvider (Organization value) { return new OneOrManyProvider (new ProviderOrganization (value)); }
            public static implicit operator OneOrManyProvider (Organization[] values) { return new OneOrManyProvider (values.Select(v => (IProvider) new ProviderOrganization (v))); }
            public static implicit operator OneOrManyProvider (List<Organization> values) { return new OneOrManyProvider (values.Select(v => (IProvider) new ProviderOrganization (v))); }
            public static implicit operator OneOrManyProvider (Person value) { return new OneOrManyProvider (new ProviderPerson (value)); }
            public static implicit operator OneOrManyProvider (Person[] values) { return new OneOrManyProvider (values.Select(v => (IProvider) new ProviderPerson (v))); }
            public static implicit operator OneOrManyProvider (List<Person> values) { return new OneOrManyProvider (values.Select(v => (IProvider) new ProviderPerson (v))); }
        }
        public struct ProviderOrganization : IProvider<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public ProviderOrganization (Organization value) { Value = value; }
            public static implicit operator ProviderOrganization (Organization value) { return new ProviderOrganization (value); }
        }
        public struct ProviderPerson : IProvider<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ProviderPerson (Person value) { Value = value; }
            public static implicit operator ProviderPerson (Person value) { return new ProviderPerson (value); }
        }

        public interface IPublication : IValue {}
        public interface IPublication<T> : IPublication { new T Value { get; } }
        public class OneOrManyPublication : OneOrMany<IPublication>
        {
            public OneOrManyPublication(IPublication item) : base(item) { }
            public OneOrManyPublication(IEnumerable<IPublication> items) : base(items) { }
            public static implicit operator OneOrManyPublication (PublicationEvent value) { return new OneOrManyPublication (new PublicationPublicationEvent (value)); }
            public static implicit operator OneOrManyPublication (PublicationEvent[] values) { return new OneOrManyPublication (values.Select(v => (IPublication) new PublicationPublicationEvent (v))); }
            public static implicit operator OneOrManyPublication (List<PublicationEvent> values) { return new OneOrManyPublication (values.Select(v => (IPublication) new PublicationPublicationEvent (v))); }
        }
        public struct PublicationPublicationEvent : IPublication<PublicationEvent>
        {
            object IValue.Value => this.Value;
            public PublicationEvent Value { get; }
            public PublicationPublicationEvent (PublicationEvent value) { Value = value; }
            public static implicit operator PublicationPublicationEvent (PublicationEvent value) { return new PublicationPublicationEvent (value); }
        }

        public interface IPublisher : IValue {}
        public interface IPublisher<T> : IPublisher { new T Value { get; } }
        public class OneOrManyPublisher : OneOrMany<IPublisher>
        {
            public OneOrManyPublisher(IPublisher item) : base(item) { }
            public OneOrManyPublisher(IEnumerable<IPublisher> items) : base(items) { }
            public static implicit operator OneOrManyPublisher (Organization value) { return new OneOrManyPublisher (new PublisherOrganization (value)); }
            public static implicit operator OneOrManyPublisher (Organization[] values) { return new OneOrManyPublisher (values.Select(v => (IPublisher) new PublisherOrganization (v))); }
            public static implicit operator OneOrManyPublisher (List<Organization> values) { return new OneOrManyPublisher (values.Select(v => (IPublisher) new PublisherOrganization (v))); }
            public static implicit operator OneOrManyPublisher (Person value) { return new OneOrManyPublisher (new PublisherPerson (value)); }
            public static implicit operator OneOrManyPublisher (Person[] values) { return new OneOrManyPublisher (values.Select(v => (IPublisher) new PublisherPerson (v))); }
            public static implicit operator OneOrManyPublisher (List<Person> values) { return new OneOrManyPublisher (values.Select(v => (IPublisher) new PublisherPerson (v))); }
        }
        public struct PublisherOrganization : IPublisher<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public PublisherOrganization (Organization value) { Value = value; }
            public static implicit operator PublisherOrganization (Organization value) { return new PublisherOrganization (value); }
        }
        public struct PublisherPerson : IPublisher<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public PublisherPerson (Person value) { Value = value; }
            public static implicit operator PublisherPerson (Person value) { return new PublisherPerson (value); }
        }

        public interface IPublisherImprint : IValue {}
        public interface IPublisherImprint<T> : IPublisherImprint { new T Value { get; } }
        public class OneOrManyPublisherImprint : OneOrMany<IPublisherImprint>
        {
            public OneOrManyPublisherImprint(IPublisherImprint item) : base(item) { }
            public OneOrManyPublisherImprint(IEnumerable<IPublisherImprint> items) : base(items) { }
            public static implicit operator OneOrManyPublisherImprint (Organization value) { return new OneOrManyPublisherImprint (new PublisherImprintOrganization (value)); }
            public static implicit operator OneOrManyPublisherImprint (Organization[] values) { return new OneOrManyPublisherImprint (values.Select(v => (IPublisherImprint) new PublisherImprintOrganization (v))); }
            public static implicit operator OneOrManyPublisherImprint (List<Organization> values) { return new OneOrManyPublisherImprint (values.Select(v => (IPublisherImprint) new PublisherImprintOrganization (v))); }
        }
        public struct PublisherImprintOrganization : IPublisherImprint<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public PublisherImprintOrganization (Organization value) { Value = value; }
            public static implicit operator PublisherImprintOrganization (Organization value) { return new PublisherImprintOrganization (value); }
        }

        public interface IPublishingPrinciples : IValue {}
        public interface IPublishingPrinciples<T> : IPublishingPrinciples { new T Value { get; } }
        public class OneOrManyPublishingPrinciples : OneOrMany<IPublishingPrinciples>
        {
            public OneOrManyPublishingPrinciples(IPublishingPrinciples item) : base(item) { }
            public OneOrManyPublishingPrinciples(IEnumerable<IPublishingPrinciples> items) : base(items) { }
            public static implicit operator OneOrManyPublishingPrinciples (CreativeWork value) { return new OneOrManyPublishingPrinciples (new PublishingPrinciplesCreativeWork (value)); }
            public static implicit operator OneOrManyPublishingPrinciples (CreativeWork[] values) { return new OneOrManyPublishingPrinciples (values.Select(v => (IPublishingPrinciples) new PublishingPrinciplesCreativeWork (v))); }
            public static implicit operator OneOrManyPublishingPrinciples (List<CreativeWork> values) { return new OneOrManyPublishingPrinciples (values.Select(v => (IPublishingPrinciples) new PublishingPrinciplesCreativeWork (v))); }
            public static implicit operator OneOrManyPublishingPrinciples (Uri value) { return new OneOrManyPublishingPrinciples (new PublishingPrinciplesUri (value)); }
            public static implicit operator OneOrManyPublishingPrinciples (Uri[] values) { return new OneOrManyPublishingPrinciples (values.Select(v => (IPublishingPrinciples) new PublishingPrinciplesUri (v))); }
            public static implicit operator OneOrManyPublishingPrinciples (List<Uri> values) { return new OneOrManyPublishingPrinciples (values.Select(v => (IPublishingPrinciples) new PublishingPrinciplesUri (v))); }
        }
        public struct PublishingPrinciplesCreativeWork : IPublishingPrinciples<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public PublishingPrinciplesCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator PublishingPrinciplesCreativeWork (CreativeWork value) { return new PublishingPrinciplesCreativeWork (value); }
        }
        public struct PublishingPrinciplesUri : IPublishingPrinciples<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public PublishingPrinciplesUri (Uri value) { Value = value; }
            public static implicit operator PublishingPrinciplesUri (Uri value) { return new PublishingPrinciplesUri (value); }
        }

        public interface IRecordedAt : IValue {}
        public interface IRecordedAt<T> : IRecordedAt { new T Value { get; } }
        public class OneOrManyRecordedAt : OneOrMany<IRecordedAt>
        {
            public OneOrManyRecordedAt(IRecordedAt item) : base(item) { }
            public OneOrManyRecordedAt(IEnumerable<IRecordedAt> items) : base(items) { }
            public static implicit operator OneOrManyRecordedAt (Event value) { return new OneOrManyRecordedAt (new RecordedAtEvent (value)); }
            public static implicit operator OneOrManyRecordedAt (Event[] values) { return new OneOrManyRecordedAt (values.Select(v => (IRecordedAt) new RecordedAtEvent (v))); }
            public static implicit operator OneOrManyRecordedAt (List<Event> values) { return new OneOrManyRecordedAt (values.Select(v => (IRecordedAt) new RecordedAtEvent (v))); }
        }
        public struct RecordedAtEvent : IRecordedAt<Event>
        {
            object IValue.Value => this.Value;
            public Event Value { get; }
            public RecordedAtEvent (Event value) { Value = value; }
            public static implicit operator RecordedAtEvent (Event value) { return new RecordedAtEvent (value); }
        }

        public interface IReleasedEvent : IValue {}
        public interface IReleasedEvent<T> : IReleasedEvent { new T Value { get; } }
        public class OneOrManyReleasedEvent : OneOrMany<IReleasedEvent>
        {
            public OneOrManyReleasedEvent(IReleasedEvent item) : base(item) { }
            public OneOrManyReleasedEvent(IEnumerable<IReleasedEvent> items) : base(items) { }
            public static implicit operator OneOrManyReleasedEvent (PublicationEvent value) { return new OneOrManyReleasedEvent (new ReleasedEventPublicationEvent (value)); }
            public static implicit operator OneOrManyReleasedEvent (PublicationEvent[] values) { return new OneOrManyReleasedEvent (values.Select(v => (IReleasedEvent) new ReleasedEventPublicationEvent (v))); }
            public static implicit operator OneOrManyReleasedEvent (List<PublicationEvent> values) { return new OneOrManyReleasedEvent (values.Select(v => (IReleasedEvent) new ReleasedEventPublicationEvent (v))); }
        }
        public struct ReleasedEventPublicationEvent : IReleasedEvent<PublicationEvent>
        {
            object IValue.Value => this.Value;
            public PublicationEvent Value { get; }
            public ReleasedEventPublicationEvent (PublicationEvent value) { Value = value; }
            public static implicit operator ReleasedEventPublicationEvent (PublicationEvent value) { return new ReleasedEventPublicationEvent (value); }
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

        public interface ISchemaVersion : IValue {}
        public interface ISchemaVersion<T> : ISchemaVersion { new T Value { get; } }
        public class OneOrManySchemaVersion : OneOrMany<ISchemaVersion>
        {
            public OneOrManySchemaVersion(ISchemaVersion item) : base(item) { }
            public OneOrManySchemaVersion(IEnumerable<ISchemaVersion> items) : base(items) { }
            public static implicit operator OneOrManySchemaVersion (string value) { return new OneOrManySchemaVersion (new SchemaVersionstring (value)); }
            public static implicit operator OneOrManySchemaVersion (string[] values) { return new OneOrManySchemaVersion (values.Select(v => (ISchemaVersion) new SchemaVersionstring (v))); }
            public static implicit operator OneOrManySchemaVersion (List<string> values) { return new OneOrManySchemaVersion (values.Select(v => (ISchemaVersion) new SchemaVersionstring (v))); }
            public static implicit operator OneOrManySchemaVersion (Uri value) { return new OneOrManySchemaVersion (new SchemaVersionUri (value)); }
            public static implicit operator OneOrManySchemaVersion (Uri[] values) { return new OneOrManySchemaVersion (values.Select(v => (ISchemaVersion) new SchemaVersionUri (v))); }
            public static implicit operator OneOrManySchemaVersion (List<Uri> values) { return new OneOrManySchemaVersion (values.Select(v => (ISchemaVersion) new SchemaVersionUri (v))); }
        }
        public struct SchemaVersionstring : ISchemaVersion<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SchemaVersionstring (string value) { Value = value; }
            public static implicit operator SchemaVersionstring (string value) { return new SchemaVersionstring (value); }
        }
        public struct SchemaVersionUri : ISchemaVersion<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public SchemaVersionUri (Uri value) { Value = value; }
            public static implicit operator SchemaVersionUri (Uri value) { return new SchemaVersionUri (value); }
        }

        public interface ISdDatePublished : IValue {}
        public interface ISdDatePublished<T> : ISdDatePublished { new T Value { get; } }
        public class OneOrManySdDatePublished : OneOrMany<ISdDatePublished>
        {
            public OneOrManySdDatePublished(ISdDatePublished item) : base(item) { }
            public OneOrManySdDatePublished(IEnumerable<ISdDatePublished> items) : base(items) { }
            public static implicit operator OneOrManySdDatePublished (DateTimeOffset value) { return new OneOrManySdDatePublished (new SdDatePublishedDateTimeOffset (value)); }
            public static implicit operator OneOrManySdDatePublished (DateTimeOffset[] values) { return new OneOrManySdDatePublished (values.Select(v => (ISdDatePublished) new SdDatePublishedDateTimeOffset (v))); }
            public static implicit operator OneOrManySdDatePublished (List<DateTimeOffset> values) { return new OneOrManySdDatePublished (values.Select(v => (ISdDatePublished) new SdDatePublishedDateTimeOffset (v))); }
        }
        public struct SdDatePublishedDateTimeOffset : ISdDatePublished<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public SdDatePublishedDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator SdDatePublishedDateTimeOffset (DateTimeOffset value) { return new SdDatePublishedDateTimeOffset (value); }
        }

        public interface ISdLicense : IValue {}
        public interface ISdLicense<T> : ISdLicense { new T Value { get; } }
        public class OneOrManySdLicense : OneOrMany<ISdLicense>
        {
            public OneOrManySdLicense(ISdLicense item) : base(item) { }
            public OneOrManySdLicense(IEnumerable<ISdLicense> items) : base(items) { }
            public static implicit operator OneOrManySdLicense (CreativeWork value) { return new OneOrManySdLicense (new SdLicenseCreativeWork (value)); }
            public static implicit operator OneOrManySdLicense (CreativeWork[] values) { return new OneOrManySdLicense (values.Select(v => (ISdLicense) new SdLicenseCreativeWork (v))); }
            public static implicit operator OneOrManySdLicense (List<CreativeWork> values) { return new OneOrManySdLicense (values.Select(v => (ISdLicense) new SdLicenseCreativeWork (v))); }
            public static implicit operator OneOrManySdLicense (Uri value) { return new OneOrManySdLicense (new SdLicenseUri (value)); }
            public static implicit operator OneOrManySdLicense (Uri[] values) { return new OneOrManySdLicense (values.Select(v => (ISdLicense) new SdLicenseUri (v))); }
            public static implicit operator OneOrManySdLicense (List<Uri> values) { return new OneOrManySdLicense (values.Select(v => (ISdLicense) new SdLicenseUri (v))); }
        }
        public struct SdLicenseCreativeWork : ISdLicense<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public SdLicenseCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator SdLicenseCreativeWork (CreativeWork value) { return new SdLicenseCreativeWork (value); }
        }
        public struct SdLicenseUri : ISdLicense<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public SdLicenseUri (Uri value) { Value = value; }
            public static implicit operator SdLicenseUri (Uri value) { return new SdLicenseUri (value); }
        }

        public interface ISdPublisher : IValue {}
        public interface ISdPublisher<T> : ISdPublisher { new T Value { get; } }
        public class OneOrManySdPublisher : OneOrMany<ISdPublisher>
        {
            public OneOrManySdPublisher(ISdPublisher item) : base(item) { }
            public OneOrManySdPublisher(IEnumerable<ISdPublisher> items) : base(items) { }
            public static implicit operator OneOrManySdPublisher (Organization value) { return new OneOrManySdPublisher (new SdPublisherOrganization (value)); }
            public static implicit operator OneOrManySdPublisher (Organization[] values) { return new OneOrManySdPublisher (values.Select(v => (ISdPublisher) new SdPublisherOrganization (v))); }
            public static implicit operator OneOrManySdPublisher (List<Organization> values) { return new OneOrManySdPublisher (values.Select(v => (ISdPublisher) new SdPublisherOrganization (v))); }
            public static implicit operator OneOrManySdPublisher (Person value) { return new OneOrManySdPublisher (new SdPublisherPerson (value)); }
            public static implicit operator OneOrManySdPublisher (Person[] values) { return new OneOrManySdPublisher (values.Select(v => (ISdPublisher) new SdPublisherPerson (v))); }
            public static implicit operator OneOrManySdPublisher (List<Person> values) { return new OneOrManySdPublisher (values.Select(v => (ISdPublisher) new SdPublisherPerson (v))); }
        }
        public struct SdPublisherOrganization : ISdPublisher<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public SdPublisherOrganization (Organization value) { Value = value; }
            public static implicit operator SdPublisherOrganization (Organization value) { return new SdPublisherOrganization (value); }
        }
        public struct SdPublisherPerson : ISdPublisher<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public SdPublisherPerson (Person value) { Value = value; }
            public static implicit operator SdPublisherPerson (Person value) { return new SdPublisherPerson (value); }
        }

        public interface ISourceOrganization : IValue {}
        public interface ISourceOrganization<T> : ISourceOrganization { new T Value { get; } }
        public class OneOrManySourceOrganization : OneOrMany<ISourceOrganization>
        {
            public OneOrManySourceOrganization(ISourceOrganization item) : base(item) { }
            public OneOrManySourceOrganization(IEnumerable<ISourceOrganization> items) : base(items) { }
            public static implicit operator OneOrManySourceOrganization (Organization value) { return new OneOrManySourceOrganization (new SourceOrganizationOrganization (value)); }
            public static implicit operator OneOrManySourceOrganization (Organization[] values) { return new OneOrManySourceOrganization (values.Select(v => (ISourceOrganization) new SourceOrganizationOrganization (v))); }
            public static implicit operator OneOrManySourceOrganization (List<Organization> values) { return new OneOrManySourceOrganization (values.Select(v => (ISourceOrganization) new SourceOrganizationOrganization (v))); }
        }
        public struct SourceOrganizationOrganization : ISourceOrganization<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public SourceOrganizationOrganization (Organization value) { Value = value; }
            public static implicit operator SourceOrganizationOrganization (Organization value) { return new SourceOrganizationOrganization (value); }
        }

        public interface ISpatialCoverage : IValue {}
        public interface ISpatialCoverage<T> : ISpatialCoverage { new T Value { get; } }
        public class OneOrManySpatialCoverage : OneOrMany<ISpatialCoverage>
        {
            public OneOrManySpatialCoverage(ISpatialCoverage item) : base(item) { }
            public OneOrManySpatialCoverage(IEnumerable<ISpatialCoverage> items) : base(items) { }
            public static implicit operator OneOrManySpatialCoverage (Place value) { return new OneOrManySpatialCoverage (new SpatialCoveragePlace (value)); }
            public static implicit operator OneOrManySpatialCoverage (Place[] values) { return new OneOrManySpatialCoverage (values.Select(v => (ISpatialCoverage) new SpatialCoveragePlace (v))); }
            public static implicit operator OneOrManySpatialCoverage (List<Place> values) { return new OneOrManySpatialCoverage (values.Select(v => (ISpatialCoverage) new SpatialCoveragePlace (v))); }
        }
        public struct SpatialCoveragePlace : ISpatialCoverage<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public SpatialCoveragePlace (Place value) { Value = value; }
            public static implicit operator SpatialCoveragePlace (Place value) { return new SpatialCoveragePlace (value); }
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

        public interface ITemporalCoverage : IValue {}
        public interface ITemporalCoverage<T> : ITemporalCoverage { new T Value { get; } }
        public class OneOrManyTemporalCoverage : OneOrMany<ITemporalCoverage>
        {
            public OneOrManyTemporalCoverage(ITemporalCoverage item) : base(item) { }
            public OneOrManyTemporalCoverage(IEnumerable<ITemporalCoverage> items) : base(items) { }
            public static implicit operator OneOrManyTemporalCoverage (DateTimeOffset value) { return new OneOrManyTemporalCoverage (new TemporalCoverageDateTimeOffset (value)); }
            public static implicit operator OneOrManyTemporalCoverage (DateTimeOffset[] values) { return new OneOrManyTemporalCoverage (values.Select(v => (ITemporalCoverage) new TemporalCoverageDateTimeOffset (v))); }
            public static implicit operator OneOrManyTemporalCoverage (List<DateTimeOffset> values) { return new OneOrManyTemporalCoverage (values.Select(v => (ITemporalCoverage) new TemporalCoverageDateTimeOffset (v))); }
            public static implicit operator OneOrManyTemporalCoverage (string value) { return new OneOrManyTemporalCoverage (new TemporalCoveragestring (value)); }
            public static implicit operator OneOrManyTemporalCoverage (string[] values) { return new OneOrManyTemporalCoverage (values.Select(v => (ITemporalCoverage) new TemporalCoveragestring (v))); }
            public static implicit operator OneOrManyTemporalCoverage (List<string> values) { return new OneOrManyTemporalCoverage (values.Select(v => (ITemporalCoverage) new TemporalCoveragestring (v))); }
            public static implicit operator OneOrManyTemporalCoverage (Uri value) { return new OneOrManyTemporalCoverage (new TemporalCoverageUri (value)); }
            public static implicit operator OneOrManyTemporalCoverage (Uri[] values) { return new OneOrManyTemporalCoverage (values.Select(v => (ITemporalCoverage) new TemporalCoverageUri (v))); }
            public static implicit operator OneOrManyTemporalCoverage (List<Uri> values) { return new OneOrManyTemporalCoverage (values.Select(v => (ITemporalCoverage) new TemporalCoverageUri (v))); }
        }
        public struct TemporalCoverageDateTimeOffset : ITemporalCoverage<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public TemporalCoverageDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator TemporalCoverageDateTimeOffset (DateTimeOffset value) { return new TemporalCoverageDateTimeOffset (value); }
        }
        public struct TemporalCoveragestring : ITemporalCoverage<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public TemporalCoveragestring (string value) { Value = value; }
            public static implicit operator TemporalCoveragestring (string value) { return new TemporalCoveragestring (value); }
        }
        public struct TemporalCoverageUri : ITemporalCoverage<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public TemporalCoverageUri (Uri value) { Value = value; }
            public static implicit operator TemporalCoverageUri (Uri value) { return new TemporalCoverageUri (value); }
        }

        public interface IText : IValue {}
        public interface IText<T> : IText { new T Value { get; } }
        public class OneOrManyText : OneOrMany<IText>
        {
            public OneOrManyText(IText item) : base(item) { }
            public OneOrManyText(IEnumerable<IText> items) : base(items) { }
            public static implicit operator OneOrManyText (string value) { return new OneOrManyText (new Textstring (value)); }
            public static implicit operator OneOrManyText (string[] values) { return new OneOrManyText (values.Select(v => (IText) new Textstring (v))); }
            public static implicit operator OneOrManyText (List<string> values) { return new OneOrManyText (values.Select(v => (IText) new Textstring (v))); }
        }
        public struct Textstring : IText<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Textstring (string value) { Value = value; }
            public static implicit operator Textstring (string value) { return new Textstring (value); }
        }

        public interface IThumbnailUrl : IValue {}
        public interface IThumbnailUrl<T> : IThumbnailUrl { new T Value { get; } }
        public class OneOrManyThumbnailUrl : OneOrMany<IThumbnailUrl>
        {
            public OneOrManyThumbnailUrl(IThumbnailUrl item) : base(item) { }
            public OneOrManyThumbnailUrl(IEnumerable<IThumbnailUrl> items) : base(items) { }
            public static implicit operator OneOrManyThumbnailUrl (Uri value) { return new OneOrManyThumbnailUrl (new ThumbnailUrlUri (value)); }
            public static implicit operator OneOrManyThumbnailUrl (Uri[] values) { return new OneOrManyThumbnailUrl (values.Select(v => (IThumbnailUrl) new ThumbnailUrlUri (v))); }
            public static implicit operator OneOrManyThumbnailUrl (List<Uri> values) { return new OneOrManyThumbnailUrl (values.Select(v => (IThumbnailUrl) new ThumbnailUrlUri (v))); }
        }
        public struct ThumbnailUrlUri : IThumbnailUrl<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public ThumbnailUrlUri (Uri value) { Value = value; }
            public static implicit operator ThumbnailUrlUri (Uri value) { return new ThumbnailUrlUri (value); }
        }

        public interface ITimeRequired : IValue {}
        public interface ITimeRequired<T> : ITimeRequired { new T Value { get; } }
        public class OneOrManyTimeRequired : OneOrMany<ITimeRequired>
        {
            public OneOrManyTimeRequired(ITimeRequired item) : base(item) { }
            public OneOrManyTimeRequired(IEnumerable<ITimeRequired> items) : base(items) { }
            public static implicit operator OneOrManyTimeRequired (TimeSpan value) { return new OneOrManyTimeRequired (new TimeRequiredTimeSpan (value)); }
            public static implicit operator OneOrManyTimeRequired (TimeSpan[] values) { return new OneOrManyTimeRequired (values.Select(v => (ITimeRequired) new TimeRequiredTimeSpan (v))); }
            public static implicit operator OneOrManyTimeRequired (List<TimeSpan> values) { return new OneOrManyTimeRequired (values.Select(v => (ITimeRequired) new TimeRequiredTimeSpan (v))); }
        }
        public struct TimeRequiredTimeSpan : ITimeRequired<TimeSpan>
        {
            object IValue.Value => this.Value;
            public TimeSpan Value { get; }
            public TimeRequiredTimeSpan (TimeSpan value) { Value = value; }
            public static implicit operator TimeRequiredTimeSpan (TimeSpan value) { return new TimeRequiredTimeSpan (value); }
        }

        public interface ITranslationOfWork : IValue {}
        public interface ITranslationOfWork<T> : ITranslationOfWork { new T Value { get; } }
        public class OneOrManyTranslationOfWork : OneOrMany<ITranslationOfWork>
        {
            public OneOrManyTranslationOfWork(ITranslationOfWork item) : base(item) { }
            public OneOrManyTranslationOfWork(IEnumerable<ITranslationOfWork> items) : base(items) { }
            public static implicit operator OneOrManyTranslationOfWork (CreativeWork value) { return new OneOrManyTranslationOfWork (new TranslationOfWorkCreativeWork (value)); }
            public static implicit operator OneOrManyTranslationOfWork (CreativeWork[] values) { return new OneOrManyTranslationOfWork (values.Select(v => (ITranslationOfWork) new TranslationOfWorkCreativeWork (v))); }
            public static implicit operator OneOrManyTranslationOfWork (List<CreativeWork> values) { return new OneOrManyTranslationOfWork (values.Select(v => (ITranslationOfWork) new TranslationOfWorkCreativeWork (v))); }
        }
        public struct TranslationOfWorkCreativeWork : ITranslationOfWork<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public TranslationOfWorkCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator TranslationOfWorkCreativeWork (CreativeWork value) { return new TranslationOfWorkCreativeWork (value); }
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

        public interface IVersion : IValue {}
        public interface IVersion<T> : IVersion { new T Value { get; } }
        public class OneOrManyVersion : OneOrMany<IVersion>
        {
            public OneOrManyVersion(IVersion item) : base(item) { }
            public OneOrManyVersion(IEnumerable<IVersion> items) : base(items) { }
            public static implicit operator OneOrManyVersion (double value) { return new OneOrManyVersion (new Versiondouble (value)); }
            public static implicit operator OneOrManyVersion (double[] values) { return new OneOrManyVersion (values.Select(v => (IVersion) new Versiondouble (v))); }
            public static implicit operator OneOrManyVersion (List<double> values) { return new OneOrManyVersion (values.Select(v => (IVersion) new Versiondouble (v))); }
            public static implicit operator OneOrManyVersion (string value) { return new OneOrManyVersion (new Versionstring (value)); }
            public static implicit operator OneOrManyVersion (string[] values) { return new OneOrManyVersion (values.Select(v => (IVersion) new Versionstring (v))); }
            public static implicit operator OneOrManyVersion (List<string> values) { return new OneOrManyVersion (values.Select(v => (IVersion) new Versionstring (v))); }
        }
        public struct Versiondouble : IVersion<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public Versiondouble (double value) { Value = value; }
            public static implicit operator Versiondouble (double value) { return new Versiondouble (value); }
        }
        public struct Versionstring : IVersion<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Versionstring (string value) { Value = value; }
            public static implicit operator Versionstring (string value) { return new Versionstring (value); }
        }

        public interface IVideo : IValue {}
        public interface IVideo<T> : IVideo { new T Value { get; } }
        public class OneOrManyVideo : OneOrMany<IVideo>
        {
            public OneOrManyVideo(IVideo item) : base(item) { }
            public OneOrManyVideo(IEnumerable<IVideo> items) : base(items) { }
            public static implicit operator OneOrManyVideo (VideoObject value) { return new OneOrManyVideo (new VideoVideoObject (value)); }
            public static implicit operator OneOrManyVideo (VideoObject[] values) { return new OneOrManyVideo (values.Select(v => (IVideo) new VideoVideoObject (v))); }
            public static implicit operator OneOrManyVideo (List<VideoObject> values) { return new OneOrManyVideo (values.Select(v => (IVideo) new VideoVideoObject (v))); }
        }
        public struct VideoVideoObject : IVideo<VideoObject>
        {
            object IValue.Value => this.Value;
            public VideoObject Value { get; }
            public VideoVideoObject (VideoObject value) { Value = value; }
            public static implicit operator VideoVideoObject (VideoObject value) { return new VideoVideoObject (value); }
        }

        public interface IWorkExample : IValue {}
        public interface IWorkExample<T> : IWorkExample { new T Value { get; } }
        public class OneOrManyWorkExample : OneOrMany<IWorkExample>
        {
            public OneOrManyWorkExample(IWorkExample item) : base(item) { }
            public OneOrManyWorkExample(IEnumerable<IWorkExample> items) : base(items) { }
            public static implicit operator OneOrManyWorkExample (CreativeWork value) { return new OneOrManyWorkExample (new WorkExampleCreativeWork (value)); }
            public static implicit operator OneOrManyWorkExample (CreativeWork[] values) { return new OneOrManyWorkExample (values.Select(v => (IWorkExample) new WorkExampleCreativeWork (v))); }
            public static implicit operator OneOrManyWorkExample (List<CreativeWork> values) { return new OneOrManyWorkExample (values.Select(v => (IWorkExample) new WorkExampleCreativeWork (v))); }
        }
        public struct WorkExampleCreativeWork : IWorkExample<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public WorkExampleCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator WorkExampleCreativeWork (CreativeWork value) { return new WorkExampleCreativeWork (value); }
        }

        public interface IWorkTranslation : IValue {}
        public interface IWorkTranslation<T> : IWorkTranslation { new T Value { get; } }
        public class OneOrManyWorkTranslation : OneOrMany<IWorkTranslation>
        {
            public OneOrManyWorkTranslation(IWorkTranslation item) : base(item) { }
            public OneOrManyWorkTranslation(IEnumerable<IWorkTranslation> items) : base(items) { }
            public static implicit operator OneOrManyWorkTranslation (CreativeWork value) { return new OneOrManyWorkTranslation (new WorkTranslationCreativeWork (value)); }
            public static implicit operator OneOrManyWorkTranslation (CreativeWork[] values) { return new OneOrManyWorkTranslation (values.Select(v => (IWorkTranslation) new WorkTranslationCreativeWork (v))); }
            public static implicit operator OneOrManyWorkTranslation (List<CreativeWork> values) { return new OneOrManyWorkTranslation (values.Select(v => (IWorkTranslation) new WorkTranslationCreativeWork (v))); }
        }
        public struct WorkTranslationCreativeWork : IWorkTranslation<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public WorkTranslationCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator WorkTranslationCreativeWork (CreativeWork value) { return new WorkTranslationCreativeWork (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CreativeWorkAndItemListAndListItem";

        /// <summary>
        /// The subject matter of the content.
        /// </summary>
        [DataMember(Name = "about", Order = 206)]
        public OneOrManyAbout About { get; set; }

        /// <summary>
        /// Indicates that the resource is compatible with the referenced accessibility API (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "accessibilityAPI", Order = 207)]
        public OneOrManyAccessibilityAPI AccessibilityAPI { get; set; }

        /// <summary>
        /// Identifies input methods that are sufficient to fully control the described resource (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "accessibilityControl", Order = 208)]
        public OneOrManyAccessibilityControl AccessibilityControl { get; set; }

        /// <summary>
        /// Content features of the resource, such as accessible media, alternatives and supported enhancements for accessibility (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "accessibilityFeature", Order = 209)]
        public OneOrManyAccessibilityFeature AccessibilityFeature { get; set; }

        /// <summary>
        /// A characteristic of the described resource that is physiologically dangerous to some users. Related to WCAG 2.0 guideline 2.3 (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "accessibilityHazard", Order = 210)]
        public OneOrManyAccessibilityHazard AccessibilityHazard { get; set; }

        /// <summary>
        /// A human-readable summary of specific accessibility features or deficiencies, consistent with the other accessibility metadata but expressing subtleties such as "short descriptions are present but long descriptions will be needed for non-visual users" or "short descriptions are present and no long descriptions are needed."
        /// </summary>
        [DataMember(Name = "accessibilitySummary", Order = 211)]
        public OneOrManyAccessibilitySummary AccessibilitySummary { get; set; }

        /// <summary>
        /// The human sensory perceptual system or cognitive faculty through which a person may process or perceive information. Expected values include: auditory, tactile, textual, visual, colorDependent, chartOnVisual, chemOnVisual, diagramOnVisual, mathOnVisual, musicOnVisual, textOnVisual.
        /// </summary>
        [DataMember(Name = "accessMode", Order = 212)]
        public OneOrManyAccessMode AccessMode { get; set; }

        /// <summary>
        /// A list of single or combined accessModes that are sufficient to understand all the intellectual content of a resource. Expected values include:  auditory, tactile, textual, visual.
        /// </summary>
        [DataMember(Name = "accessModeSufficient", Order = 213)]
        public OneOrManyAccessModeSufficient AccessModeSufficient { get; set; }

        /// <summary>
        /// Specifies the Person that is legally accountable for the CreativeWork.
        /// </summary>
        [DataMember(Name = "accountablePerson", Order = 214)]
        public OneOrManyAccountablePerson AccountablePerson { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 215)]
        public OneOrManyAggregateRating AggregateRating { get; set; }

        /// <summary>
        /// A secondary title of the CreativeWork.
        /// </summary>
        [DataMember(Name = "alternativeHeadline", Order = 216)]
        public OneOrManyAlternativeHeadline AlternativeHeadline { get; set; }

        /// <summary>
        /// A media object that encodes this CreativeWork. This property is a synonym for encoding.
        /// </summary>
        [DataMember(Name = "associatedMedia", Order = 217)]
        public OneOrManyAssociatedMedia AssociatedMedia { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience", Order = 218)]
        public OneOrManyAudience Audience { get; set; }

        /// <summary>
        /// An embedded audio object.
        /// </summary>
        [DataMember(Name = "audio", Order = 219)]
        public OneOrManyAudio Audio { get; set; }

        /// <summary>
        /// The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.
        /// </summary>
        [DataMember(Name = "author", Order = 220)]
        public OneOrManyAuthor Author { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 221)]
        public OneOrManyAward Award { get; set; }

        /// <summary>
        /// Fictional person connected with a creative work.
        /// </summary>
        [DataMember(Name = "character", Order = 222)]
        public OneOrManyCharacter Character { get; set; }

        /// <summary>
        /// A citation or reference to another creative work, such as another publication, web page, scholarly article, etc.
        /// </summary>
        [DataMember(Name = "citation", Order = 223)]
        public OneOrManyCitation Citation { get; set; }

        /// <summary>
        /// Comments, typically from users.
        /// </summary>
        [DataMember(Name = "comment", Order = 224)]
        public OneOrManyComment Comment { get; set; }

        /// <summary>
        /// The number of comments this CreativeWork (e.g. Article, Question or Answer) has received. This is most applicable to works published in Web sites with commenting system; additional comments may exist elsewhere.
        /// </summary>
        [DataMember(Name = "commentCount", Order = 225)]
        public OneOrManyCommentCount CommentCount { get; set; }

        /// <summary>
        /// The location depicted or described in the content. For example, the location in a photograph or painting.
        /// </summary>
        [DataMember(Name = "contentLocation", Order = 226)]
        public OneOrManyContentLocation ContentLocation { get; set; }

        /// <summary>
        /// Official rating of a piece of content&amp;#x2014;for example,'MPAA PG-13'.
        /// </summary>
        [DataMember(Name = "contentRating", Order = 227)]
        public OneOrManyContentRating ContentRating { get; set; }

        /// <summary>
        /// The specific time described by a creative work, for works (e.g. articles, video objects etc.) that emphasise a particular moment within an Event.
        /// </summary>
        [DataMember(Name = "contentReferenceTime", Order = 228)]
        public OneOrManyContentReferenceTime ContentReferenceTime { get; set; }

        /// <summary>
        /// A secondary contributor to the CreativeWork or Event.
        /// </summary>
        [DataMember(Name = "contributor", Order = 229)]
        public OneOrManyContributor Contributor { get; set; }

        /// <summary>
        /// The party holding the legal copyright to the CreativeWork.
        /// </summary>
        [DataMember(Name = "copyrightHolder", Order = 230)]
        public OneOrManyCopyrightHolder CopyrightHolder { get; set; }

        /// <summary>
        /// The year during which the claimed copyright for the CreativeWork was first asserted.
        /// </summary>
        [DataMember(Name = "copyrightYear", Order = 231)]
        public OneOrManyCopyrightYear CopyrightYear { get; set; }

        /// <summary>
        /// Indicates a correction to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;, either via a &lt;a class="localLink" href="http://schema.org/CorrectionComment"&gt;CorrectionComment&lt;/a&gt;, textually or in another document.
        /// </summary>
        [DataMember(Name = "correction", Order = 232)]
        public OneOrManyCorrection Correction { get; set; }

        /// <summary>
        /// The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.
        /// </summary>
        [DataMember(Name = "creator", Order = 233)]
        public OneOrManyCreator Creator { get; set; }

        /// <summary>
        /// The date on which the CreativeWork was created or the item was added to a DataFeed.
        /// </summary>
        [DataMember(Name = "dateCreated", Order = 234)]
        public OneOrManyDateCreated DateCreated { get; set; }

        /// <summary>
        /// The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.
        /// </summary>
        [DataMember(Name = "dateModified", Order = 235)]
        public OneOrManyDateModified DateModified { get; set; }

        /// <summary>
        /// Date of first broadcast/publication.
        /// </summary>
        [DataMember(Name = "datePublished", Order = 236)]
        public OneOrManyDatePublished DatePublished { get; set; }

        /// <summary>
        /// A link to the page containing the comments of the CreativeWork.
        /// </summary>
        [DataMember(Name = "discussionUrl", Order = 237)]
        public OneOrManyDiscussionUrl DiscussionUrl { get; set; }

        /// <summary>
        /// Specifies the Person who edited the CreativeWork.
        /// </summary>
        [DataMember(Name = "editor", Order = 238)]
        public OneOrManyEditor Editor { get; set; }

        /// <summary>
        /// An alignment to an established educational framework.
        /// </summary>
        [DataMember(Name = "educationalAlignment", Order = 239)]
        public OneOrManyEducationalAlignment EducationalAlignment { get; set; }

        /// <summary>
        /// The purpose of a work in the context of education; for example, 'assignment', 'group work'.
        /// </summary>
        [DataMember(Name = "educationalUse", Order = 240)]
        public OneOrManyEducationalUse EducationalUse { get; set; }

        /// <summary>
        /// A media object that encodes this CreativeWork. This property is a synonym for associatedMedia.
        /// </summary>
        [DataMember(Name = "encoding", Order = 241)]
        public OneOrManyEncoding Encoding { get; set; }

        /// <summary>
        /// Media type typically expressed using a MIME format (see &lt;a href="http://www.iana.org/assignments/media-types/media-types.xhtml"&gt;IANA site&lt;/a&gt; and &lt;a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types"&gt;MDN reference&lt;/a&gt;) e.g. application/zip for a SoftwareApplication binary, audio/mpeg for .mp3 etc.).&lt;br/&gt;&lt;br/&gt;
        /// In cases where a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; has several media type representations, &lt;a class="localLink" href="http://schema.org/encoding"&gt;encoding&lt;/a&gt; can be used to indicate each &lt;a class="localLink" href="http://schema.org/MediaObject"&gt;MediaObject&lt;/a&gt; alongside particular &lt;a class="localLink" href="http://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt; information.&lt;br/&gt;&lt;br/&gt;
        /// Unregistered or niche encoding and file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia/Wikidata entry.
        /// </summary>
        [DataMember(Name = "encodingFormat", Order = 242)]
        public OneOrManyEncodingFormat EncodingFormat { get; set; }

        /// <summary>
        /// A creative work that this work is an example/instance/realization/derivation of.
        /// </summary>
        [DataMember(Name = "exampleOfWork", Order = 243)]
        public OneOrManyExampleOfWork ExampleOfWork { get; set; }

        /// <summary>
        /// Date the content expires and is no longer useful or available. For example a &lt;a class="localLink" href="http://schema.org/VideoObject"&gt;VideoObject&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt; whose availability or relevance is time-limited, or a &lt;a class="localLink" href="http://schema.org/ClaimReview"&gt;ClaimReview&lt;/a&gt; fact check whose publisher wants to indicate that it may no longer be relevant (or helpful to highlight) after some date.
        /// </summary>
        [DataMember(Name = "expires", Order = 244)]
        public OneOrManyExpires Expires { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 245)]
        public OneOrManyFunder Funder { get; set; }

        /// <summary>
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        [DataMember(Name = "genre", Order = 246)]
        public OneOrManyGenre Genre { get; set; }

        /// <summary>
        /// Indicates an item or CreativeWork that is part of this item, or CreativeWork (in some sense).
        /// </summary>
        [DataMember(Name = "hasPart", Order = 247)]
        public OneOrManyHasPart HasPart { get; set; }

        /// <summary>
        /// Headline of the article.
        /// </summary>
        [DataMember(Name = "headline", Order = 248)]
        public OneOrManyHeadline Headline { get; set; }

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "inLanguage", Order = 249)]
        public OneOrManyInLanguage InLanguage { get; set; }

        /// <summary>
        /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication. The most specific child type of InteractionCounter should be used.
        /// </summary>
        [DataMember(Name = "interactionStatistic", Order = 250)]
        public OneOrManyInteractionStatistic InteractionStatistic { get; set; }

        /// <summary>
        /// The predominant mode of learning supported by the learning resource. Acceptable values are 'active', 'expositive', or 'mixed'.
        /// </summary>
        [DataMember(Name = "interactivityType", Order = 251)]
        public OneOrManyInteractivityType InteractivityType { get; set; }

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree", Order = 252)]
        public OneOrManyIsAccessibleForFree IsAccessibleForFree { get; set; }

        /// <summary>
        /// A resource that was used in the creation of this resource. This term can be repeated for multiple sources. For example, http://example.com/great-multiplication-intro.html.
        /// </summary>
        [DataMember(Name = "isBasedOn", Order = 253)]
        public OneOrManyIsBasedOn IsBasedOn { get; set; }

        /// <summary>
        /// Indicates whether this content is family friendly.
        /// </summary>
        [DataMember(Name = "isFamilyFriendly", Order = 254)]
        public OneOrManyIsFamilyFriendly IsFamilyFriendly { get; set; }

        /// <summary>
        /// Indicates an item or CreativeWork that this item, or CreativeWork (in some sense), is part of.
        /// </summary>
        [DataMember(Name = "isPartOf", Order = 255)]
        public OneOrManyIsPartOf IsPartOf { get; set; }

        /// <summary>
        /// An entity represented by an entry in a list or data feed (e.g. an 'artist' in a list of 'artists')’.
        /// </summary>
        [DataMember(Name = "item", Order = 256)]
        public OneOrManyItem Item { get; set; }

        /// <summary>
        /// For itemListElement values, you can use simple strings (e.g. "Peter", "Paul", "Mary"), existing entities, or use ListItem.&lt;br/&gt;&lt;br/&gt;
        /// Text values are best if the elements in the list are plain strings. Existing entities are best for a simple, unordered list of existing things in your data. ListItem is used with ordered lists when you want to provide additional context about the element in that list or when the same item might be in different places in different lists.&lt;br/&gt;&lt;br/&gt;
        /// Note: The order of elements in your mark-up is not sufficient for indicating the order or elements.  Use ListItem with a 'position' property in such cases.
        /// </summary>
        [DataMember(Name = "itemListElement", Order = 257)]
        public OneOrManyItemListElement ItemListElement { get; set; }

        /// <summary>
        /// Type of ordering (e.g. Ascending, Descending, Unordered).
        /// </summary>
        [DataMember(Name = "itemListOrder", Order = 258)]
        public OneOrManyItemListOrder ItemListOrder { get; set; }

        /// <summary>
        /// Keywords or tags used to describe this content. Multiple entries in a keywords list are typically delimited by commas.
        /// </summary>
        [DataMember(Name = "keywords", Order = 259)]
        public OneOrManyKeywords Keywords { get; set; }

        /// <summary>
        /// The predominant type or kind characterizing the learning resource. For example, 'presentation', 'handout'.
        /// </summary>
        [DataMember(Name = "learningResourceType", Order = 260)]
        public OneOrManyLearningResourceType LearningResourceType { get; set; }

        /// <summary>
        /// A license document that applies to this content, typically indicated by URL.
        /// </summary>
        [DataMember(Name = "license", Order = 261)]
        public OneOrManyLicense License { get; set; }

        /// <summary>
        /// The location where the CreativeWork was created, which may not be the same as the location depicted in the CreativeWork.
        /// </summary>
        [DataMember(Name = "locationCreated", Order = 262)]
        public OneOrManyLocationCreated LocationCreated { get; set; }

        /// <summary>
        /// Indicates the primary entity described in some page or other CreativeWork.
        /// </summary>
        [DataMember(Name = "mainEntity", Order = 263)]
        public OneOrManyMainEntity MainEntity { get; set; }

        /// <summary>
        /// A material that something is made from, e.g. leather, wool, cotton, paper.
        /// </summary>
        [DataMember(Name = "material", Order = 264)]
        public OneOrManyMaterial Material { get; set; }

        /// <summary>
        /// Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.
        /// </summary>
        [DataMember(Name = "mentions", Order = 265)]
        public OneOrManyMentions Mentions { get; set; }

        /// <summary>
        /// A link to the ListItem that follows the current one.
        /// </summary>
        [DataMember(Name = "nextItem", Order = 266)]
        public OneOrManyNextItem NextItem { get; set; }

        /// <summary>
        /// The number of items in an ItemList. Note that some descriptions might not fully describe all items in a list (e.g., multi-page pagination); in such cases, the numberOfItems would be for the entire list.
        /// </summary>
        [DataMember(Name = "numberOfItems", Order = 267)]
        public OneOrManyNumberOfItems NumberOfItems { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers", Order = 268)]
        public OneOrManyOffers Offers { get; set; }

        /// <summary>
        /// The position of an item in a series or sequence of items.
        /// </summary>
        [DataMember(Name = "position", Order = 269)]
        public OneOrManyPosition Position { get; set; }

        /// <summary>
        /// A link to the ListItem that preceeds the current one.
        /// </summary>
        [DataMember(Name = "previousItem", Order = 270)]
        public OneOrManyPreviousItem PreviousItem { get; set; }

        /// <summary>
        /// The person or organization who produced the work (e.g. music album, movie, tv/radio series etc.).
        /// </summary>
        [DataMember(Name = "producer", Order = 271)]
        public OneOrManyProducer Producer { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 272)]
        public OneOrManyProvider Provider { get; set; }

        /// <summary>
        /// A publication event associated with the item.
        /// </summary>
        [DataMember(Name = "publication", Order = 273)]
        public OneOrManyPublication Publication { get; set; }

        /// <summary>
        /// The publisher of the creative work.
        /// </summary>
        [DataMember(Name = "publisher", Order = 274)]
        public OneOrManyPublisher Publisher { get; set; }

        /// <summary>
        /// The publishing division which published the comic.
        /// </summary>
        [DataMember(Name = "publisherImprint", Order = 275)]
        public OneOrManyPublisherImprint PublisherImprint { get; set; }

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        [DataMember(Name = "publishingPrinciples", Order = 276)]
        public OneOrManyPublishingPrinciples PublishingPrinciples { get; set; }

        /// <summary>
        /// The Event where the CreativeWork was recorded. The CreativeWork may capture all or part of the event.
        /// </summary>
        [DataMember(Name = "recordedAt", Order = 277)]
        public OneOrManyRecordedAt RecordedAt { get; set; }

        /// <summary>
        /// The place and time the release was issued, expressed as a PublicationEvent.
        /// </summary>
        [DataMember(Name = "releasedEvent", Order = 278)]
        public OneOrManyReleasedEvent ReleasedEvent { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 279)]
        public OneOrManyReview Review { get; set; }

        /// <summary>
        /// Indicates (by URL or string) a particular version of a schema used in some CreativeWork. For example, a document could declare a schemaVersion using an URL such as http://schema.org/version/2.0/ if precise indication of schema version was required by some application.
        /// </summary>
        [DataMember(Name = "schemaVersion", Order = 280)]
        public OneOrManySchemaVersion SchemaVersion { get; set; }

        /// <summary>
        /// Indicates the date on which the current structured data was generated / published. Typically used alongside &lt;a class="localLink" href="http://schema.org/sdPublisher"&gt;sdPublisher&lt;/a&gt;
        /// </summary>
        [DataMember(Name = "sdDatePublished", Order = 281)]
        public OneOrManySdDatePublished SdDatePublished { get; set; }

        /// <summary>
        /// A license document that applies to this structured data, typically indicated by URL.
        /// </summary>
        [DataMember(Name = "sdLicense", Order = 282)]
        public OneOrManySdLicense SdLicense { get; set; }

        /// <summary>
        /// Indicates the party responsible for generating and publishing the current structured data markup, typically in cases where the structured data is derived automatically from existing published content but published on a different site. For example, student projects and open data initiatives often re-publish existing content with more explicitly structured metadata. The
        /// &lt;a class="localLink" href="http://schema.org/sdPublisher"&gt;sdPublisher&lt;/a&gt; property helps make such practices more explicit.
        /// </summary>
        [DataMember(Name = "sdPublisher", Order = 283)]
        public OneOrManySdPublisher SdPublisher { get; set; }

        /// <summary>
        /// The Organization on whose behalf the creator was working.
        /// </summary>
        [DataMember(Name = "sourceOrganization", Order = 284)]
        public OneOrManySourceOrganization SourceOrganization { get; set; }

        /// <summary>
        /// The spatialCoverage of a CreativeWork indicates the place(s) which are the focus of the content. It is a subproperty of
        ///       contentLocation intended primarily for more technical and detailed materials. For example with a Dataset, it indicates
        ///       areas that the dataset describes: a dataset of New York weather would have spatialCoverage which was the place: the state of New York.
        /// </summary>
        [DataMember(Name = "spatialCoverage", Order = 285)]
        public OneOrManySpatialCoverage SpatialCoverage { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 286)]
        public OneOrManySponsor Sponsor { get; set; }

        /// <summary>
        /// The temporalCoverage of a CreativeWork indicates the period that the content applies to, i.e. that it describes, either as a DateTime or as a textual string indicating a time period in &lt;a href="https://en.wikipedia.org/wiki/ISO_8601#Time_intervals"&gt;ISO 8601 time interval format&lt;/a&gt;. In
        ///       the case of a Dataset it will typically indicate the relevant time period in a precise notation (e.g. for a 2011 census dataset, the year 2011 would be written "2011/2012"). Other forms of content e.g. ScholarlyArticle, Book, TVSeries or TVEpisode may indicate their temporalCoverage in broader terms - textually or via well-known URL.
        ///       Written works such as books may sometimes have precise temporal coverage too, e.g. a work set in 1939 - 1945 can be indicated in ISO 8601 interval format format via "1939/1945".
        /// </summary>
        [DataMember(Name = "temporalCoverage", Order = 287)]
        public OneOrManyTemporalCoverage TemporalCoverage { get; set; }

        /// <summary>
        /// The textual content of this CreativeWork.
        /// </summary>
        [DataMember(Name = "text", Order = 288)]
        public OneOrManyText Text { get; set; }

        /// <summary>
        /// A thumbnail image relevant to the Thing.
        /// </summary>
        [DataMember(Name = "thumbnailUrl", Order = 289)]
        public OneOrManyThumbnailUrl ThumbnailUrl { get; set; }

        /// <summary>
        /// Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience, e.g. 'P30M', 'P1H25M'.
        /// </summary>
        [DataMember(Name = "timeRequired", Order = 290)]
        public OneOrManyTimeRequired TimeRequired { get; set; }

        /// <summary>
        /// The work that this work has been translated from. e.g. 物种起源 is a translationOf “On the Origin of Species”
        /// </summary>
        [DataMember(Name = "translationOfWork", Order = 291)]
        public OneOrManyTranslationOfWork TranslationOfWork { get; set; }

        /// <summary>
        /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
        /// </summary>
        [DataMember(Name = "translator", Order = 292)]
        public OneOrManyTranslator Translator { get; set; }

        /// <summary>
        /// The typical expected age range, e.g. '7-9', '11-'.
        /// </summary>
        [DataMember(Name = "typicalAgeRange", Order = 293)]
        public OneOrManyTypicalAgeRange TypicalAgeRange { get; set; }

        /// <summary>
        /// The version of the CreativeWork embodied by a specified resource.
        /// </summary>
        [DataMember(Name = "version", Order = 294)]
        public OneOrManyVersion Version { get; set; }

        /// <summary>
        /// An embedded video object.
        /// </summary>
        [DataMember(Name = "video", Order = 295)]
        public OneOrManyVideo Video { get; set; }

        /// <summary>
        /// Example/instance/realization/derivation of the concept of this creative work. eg. The paperback edition, first edition, or eBook.
        /// </summary>
        [DataMember(Name = "workExample", Order = 296)]
        public OneOrManyWorkExample WorkExample { get; set; }

        /// <summary>
        /// A work that is a translation of the content of this work. e.g. 西遊記 has an English workTranslation “Journey to the West”,a German workTranslation “Monkeys Pilgerfahrt” and a Vietnamese  translation Tây du ký bình khảo.
        /// </summary>
        [DataMember(Name = "workTranslation", Order = 297)]
        public OneOrManyWorkTranslation WorkTranslation { get; set; }
    }
}
