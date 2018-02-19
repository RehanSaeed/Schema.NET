using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// See CreativeWork, LifestyleModification for more information.
    /// </summary>
    [DataContract]
    public abstract partial class CreativeWorkAndLifestyleModification : MedicalEntity
    {
        public interface IAuthor : IWrapper { }
        public interface IAuthor<T> : IAuthor { new T Data { get; set; } }
        public class AuthorOrganization : IAuthor<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public AuthorOrganization () { }
            public AuthorOrganization (Organization data) { Data = data; }
            public static implicit operator AuthorOrganization (Organization data) { return new AuthorOrganization (data); }
        }

        public class AuthorPerson : IAuthor<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public AuthorPerson () { }
            public AuthorPerson (Person data) { Data = data; }
            public static implicit operator AuthorPerson (Person data) { return new AuthorPerson (data); }
        }


        public interface ICitation : IWrapper { }
        public interface ICitation<T> : ICitation { new T Data { get; set; } }
        public class CitationCreativeWork : ICitation<CreativeWork>
        {
            object IWrapper.Data { get { return Data; } set { Data = (CreativeWork) value; } }
            public virtual CreativeWork Data { get; set; }
            public CitationCreativeWork () { }
            public CitationCreativeWork (CreativeWork data) { Data = data; }
            public static implicit operator CitationCreativeWork (CreativeWork data) { return new CitationCreativeWork (data); }
        }

        public class Citationstring : ICitation<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Citationstring () { }
            public Citationstring (string data) { Data = data; }
            public static implicit operator Citationstring (string data) { return new Citationstring (data); }
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


        public interface ICopyrightHolder : IWrapper { }
        public interface ICopyrightHolder<T> : ICopyrightHolder { new T Data { get; set; } }
        public class CopyrightHolderOrganization : ICopyrightHolder<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public CopyrightHolderOrganization () { }
            public CopyrightHolderOrganization (Organization data) { Data = data; }
            public static implicit operator CopyrightHolderOrganization (Organization data) { return new CopyrightHolderOrganization (data); }
        }

        public class CopyrightHolderPerson : ICopyrightHolder<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public CopyrightHolderPerson () { }
            public CopyrightHolderPerson (Person data) { Data = data; }
            public static implicit operator CopyrightHolderPerson (Person data) { return new CopyrightHolderPerson (data); }
        }


        public interface ICreator : IWrapper { }
        public interface ICreator<T> : ICreator { new T Data { get; set; } }
        public class CreatorOrganization : ICreator<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public CreatorOrganization () { }
            public CreatorOrganization (Organization data) { Data = data; }
            public static implicit operator CreatorOrganization (Organization data) { return new CreatorOrganization (data); }
        }

        public class CreatorPerson : ICreator<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public CreatorPerson () { }
            public CreatorPerson (Person data) { Data = data; }
            public static implicit operator CreatorPerson (Person data) { return new CreatorPerson (data); }
        }


        public interface IFileFormat : IWrapper { }
        public interface IFileFormat<T> : IFileFormat { new T Data { get; set; } }
        public class FileFormatstring : IFileFormat<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public FileFormatstring () { }
            public FileFormatstring (string data) { Data = data; }
            public static implicit operator FileFormatstring (string data) { return new FileFormatstring (data); }
        }

        public class FileFormatUri : IFileFormat<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public FileFormatUri () { }
            public FileFormatUri (Uri data) { Data = data; }
            public static implicit operator FileFormatUri (Uri data) { return new FileFormatUri (data); }
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


        public interface IGenre : IWrapper { }
        public interface IGenre<T> : IGenre { new T Data { get; set; } }
        public class Genrestring : IGenre<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Genrestring () { }
            public Genrestring (string data) { Data = data; }
            public static implicit operator Genrestring (string data) { return new Genrestring (data); }
        }

        public class GenreUri : IGenre<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public GenreUri () { }
            public GenreUri (Uri data) { Data = data; }
            public static implicit operator GenreUri (Uri data) { return new GenreUri (data); }
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


        public interface IIsBasedOn : IWrapper { }
        public interface IIsBasedOn<T> : IIsBasedOn { new T Data { get; set; } }
        public class IsBasedOnCreativeWork : IIsBasedOn<CreativeWork>
        {
            object IWrapper.Data { get { return Data; } set { Data = (CreativeWork) value; } }
            public virtual CreativeWork Data { get; set; }
            public IsBasedOnCreativeWork () { }
            public IsBasedOnCreativeWork (CreativeWork data) { Data = data; }
            public static implicit operator IsBasedOnCreativeWork (CreativeWork data) { return new IsBasedOnCreativeWork (data); }
        }

        public class IsBasedOnProduct : IIsBasedOn<Product>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Product) value; } }
            public virtual Product Data { get; set; }
            public IsBasedOnProduct () { }
            public IsBasedOnProduct (Product data) { Data = data; }
            public static implicit operator IsBasedOnProduct (Product data) { return new IsBasedOnProduct (data); }
        }

        public class IsBasedOnUri : IIsBasedOn<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public IsBasedOnUri () { }
            public IsBasedOnUri (Uri data) { Data = data; }
            public static implicit operator IsBasedOnUri (Uri data) { return new IsBasedOnUri (data); }
        }


        public interface ILicense : IWrapper { }
        public interface ILicense<T> : ILicense { new T Data { get; set; } }
        public class LicenseCreativeWork : ILicense<CreativeWork>
        {
            object IWrapper.Data { get { return Data; } set { Data = (CreativeWork) value; } }
            public virtual CreativeWork Data { get; set; }
            public LicenseCreativeWork () { }
            public LicenseCreativeWork (CreativeWork data) { Data = data; }
            public static implicit operator LicenseCreativeWork (CreativeWork data) { return new LicenseCreativeWork (data); }
        }

        public class LicenseUri : ILicense<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public LicenseUri () { }
            public LicenseUri (Uri data) { Data = data; }
            public static implicit operator LicenseUri (Uri data) { return new LicenseUri (data); }
        }


        public interface IMaterial : IWrapper { }
        public interface IMaterial<T> : IMaterial { new T Data { get; set; } }
        public class MaterialProduct : IMaterial<Product>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Product) value; } }
            public virtual Product Data { get; set; }
            public MaterialProduct () { }
            public MaterialProduct (Product data) { Data = data; }
            public static implicit operator MaterialProduct (Product data) { return new MaterialProduct (data); }
        }

        public class Materialstring : IMaterial<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Materialstring () { }
            public Materialstring (string data) { Data = data; }
            public static implicit operator Materialstring (string data) { return new Materialstring (data); }
        }

        public class MaterialUri : IMaterial<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public MaterialUri () { }
            public MaterialUri (Uri data) { Data = data; }
            public static implicit operator MaterialUri (Uri data) { return new MaterialUri (data); }
        }


        public interface IPosition : IWrapper { }
        public interface IPosition<T> : IPosition { new T Data { get; set; } }
        public class Positionint : IPosition<int>
        {
            object IWrapper.Data { get { return Data; } set { Data = (int) value; } }
            public virtual int Data { get; set; }
            public Positionint () { }
            public Positionint (int data) { Data = data; }
            public static implicit operator Positionint (int data) { return new Positionint (data); }
        }

        public class Positionstring : IPosition<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Positionstring () { }
            public Positionstring (string data) { Data = data; }
            public static implicit operator Positionstring (string data) { return new Positionstring (data); }
        }


        public interface IProducer : IWrapper { }
        public interface IProducer<T> : IProducer { new T Data { get; set; } }
        public class ProducerOrganization : IProducer<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public ProducerOrganization () { }
            public ProducerOrganization (Organization data) { Data = data; }
            public static implicit operator ProducerOrganization (Organization data) { return new ProducerOrganization (data); }
        }

        public class ProducerPerson : IProducer<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public ProducerPerson () { }
            public ProducerPerson (Person data) { Data = data; }
            public static implicit operator ProducerPerson (Person data) { return new ProducerPerson (data); }
        }


        public interface IProvider : IWrapper { }
        public interface IProvider<T> : IProvider { new T Data { get; set; } }
        public class ProviderOrganization : IProvider<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public ProviderOrganization () { }
            public ProviderOrganization (Organization data) { Data = data; }
            public static implicit operator ProviderOrganization (Organization data) { return new ProviderOrganization (data); }
        }

        public class ProviderPerson : IProvider<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public ProviderPerson () { }
            public ProviderPerson (Person data) { Data = data; }
            public static implicit operator ProviderPerson (Person data) { return new ProviderPerson (data); }
        }


        public interface IPublisher : IWrapper { }
        public interface IPublisher<T> : IPublisher { new T Data { get; set; } }
        public class PublisherOrganization : IPublisher<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public PublisherOrganization () { }
            public PublisherOrganization (Organization data) { Data = data; }
            public static implicit operator PublisherOrganization (Organization data) { return new PublisherOrganization (data); }
        }

        public class PublisherPerson : IPublisher<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public PublisherPerson () { }
            public PublisherPerson (Person data) { Data = data; }
            public static implicit operator PublisherPerson (Person data) { return new PublisherPerson (data); }
        }


        public interface IPublishingPrinciples : IWrapper { }
        public interface IPublishingPrinciples<T> : IPublishingPrinciples { new T Data { get; set; } }
        public class PublishingPrinciplesCreativeWork : IPublishingPrinciples<CreativeWork>
        {
            object IWrapper.Data { get { return Data; } set { Data = (CreativeWork) value; } }
            public virtual CreativeWork Data { get; set; }
            public PublishingPrinciplesCreativeWork () { }
            public PublishingPrinciplesCreativeWork (CreativeWork data) { Data = data; }
            public static implicit operator PublishingPrinciplesCreativeWork (CreativeWork data) { return new PublishingPrinciplesCreativeWork (data); }
        }

        public class PublishingPrinciplesUri : IPublishingPrinciples<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public PublishingPrinciplesUri () { }
            public PublishingPrinciplesUri (Uri data) { Data = data; }
            public static implicit operator PublishingPrinciplesUri (Uri data) { return new PublishingPrinciplesUri (data); }
        }


        public interface ISchemaVersion : IWrapper { }
        public interface ISchemaVersion<T> : ISchemaVersion { new T Data { get; set; } }
        public class SchemaVersionstring : ISchemaVersion<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public SchemaVersionstring () { }
            public SchemaVersionstring (string data) { Data = data; }
            public static implicit operator SchemaVersionstring (string data) { return new SchemaVersionstring (data); }
        }

        public class SchemaVersionUri : ISchemaVersion<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public SchemaVersionUri () { }
            public SchemaVersionUri (Uri data) { Data = data; }
            public static implicit operator SchemaVersionUri (Uri data) { return new SchemaVersionUri (data); }
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


        public interface ITemporalCoverage : IWrapper { }
        public interface ITemporalCoverage<T> : ITemporalCoverage { new T Data { get; set; } }
        public class TemporalCoverageDateTimeOffset : ITemporalCoverage<DateTimeOffset>
        {
            object IWrapper.Data { get { return Data; } set { Data = (DateTimeOffset) value; } }
            public virtual DateTimeOffset Data { get; set; }
            public TemporalCoverageDateTimeOffset () { }
            public TemporalCoverageDateTimeOffset (DateTimeOffset data) { Data = data; }
            public static implicit operator TemporalCoverageDateTimeOffset (DateTimeOffset data) { return new TemporalCoverageDateTimeOffset (data); }
        }

        public class TemporalCoveragestring : ITemporalCoverage<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public TemporalCoveragestring () { }
            public TemporalCoveragestring (string data) { Data = data; }
            public static implicit operator TemporalCoveragestring (string data) { return new TemporalCoveragestring (data); }
        }

        public class TemporalCoverageUri : ITemporalCoverage<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public TemporalCoverageUri () { }
            public TemporalCoverageUri (Uri data) { Data = data; }
            public static implicit operator TemporalCoverageUri (Uri data) { return new TemporalCoverageUri (data); }
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


        public interface IVersion : IWrapper { }
        public interface IVersion<T> : IVersion { new T Data { get; set; } }
        public class Versiondouble : IVersion<double>
        {
            object IWrapper.Data { get { return Data; } set { Data = (double) value; } }
            public virtual double Data { get; set; }
            public Versiondouble () { }
            public Versiondouble (double data) { Data = data; }
            public static implicit operator Versiondouble (double data) { return new Versiondouble (data); }
        }

        public class Versionstring : IVersion<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Versionstring () { }
            public Versionstring (string data) { Data = data; }
            public static implicit operator Versionstring (string data) { return new Versionstring (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CreativeWorkAndLifestyleModification";

        /// <summary>
        /// The subject matter of the content.
        /// </summary>
        [DataMember(Name = "about", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? About { get; set; } 

        /// <summary>
        /// Indicates that the resource is compatible with the referenced accessibility API (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "accessibilityAPI", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AccessibilityAPI { get; set; } 

        /// <summary>
        /// Identifies input methods that are sufficient to fully control the described resource (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "accessibilityControl", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AccessibilityControl { get; set; } 

        /// <summary>
        /// Content features of the resource, such as accessible media, alternatives and supported enhancements for accessibility (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "accessibilityFeature", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AccessibilityFeature { get; set; } 

        /// <summary>
        /// A characteristic of the described resource that is physiologically dangerous to some users. Related to WCAG 2.0 guideline 2.3 (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "accessibilityHazard", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AccessibilityHazard { get; set; } 

        /// <summary>
        /// A human-readable summary of specific accessibility features or deficiencies, consistent with the other accessibility metadata but expressing subtleties such as "short descriptions are present but long descriptions will be needed for non-visual users" or "short descriptions are present and no long descriptions are needed."
        /// </summary>
        [DataMember(Name = "accessibilitySummary", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AccessibilitySummary { get; set; } 

        /// <summary>
        /// The human sensory perceptual system or cognitive faculty through which a person may process or perceive information. Expected values include: auditory, tactile, textual, visual, colorDependent, chartOnVisual, chemOnVisual, diagramOnVisual, mathOnVisual, musicOnVisual, textOnVisual.
        /// </summary>
        [DataMember(Name = "accessMode", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AccessMode { get; set; } 

        /// <summary>
        /// A list of single or combined accessModes that are sufficient to understand all the intellectual content of a resource. Expected values include:  auditory, tactile, textual, visual.
        /// </summary>
        [DataMember(Name = "accessModeSufficient", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AccessModeSufficient { get; set; } 

        /// <summary>
        /// Specifies the Person that is legally accountable for the CreativeWork.
        /// </summary>
        [DataMember(Name = "accountablePerson", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? AccountablePerson { get; set; } 

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AggregateRating>? AggregateRating { get; set; } 

        /// <summary>
        /// A secondary title of the CreativeWork.
        /// </summary>
        [DataMember(Name = "alternativeHeadline", Order = 216)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AlternativeHeadline { get; set; } 

        /// <summary>
        /// A media object that encodes this CreativeWork. This property is a synonym for encoding.
        /// </summary>
        [DataMember(Name = "associatedMedia", Order = 217)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MediaObject>? AssociatedMedia { get; set; } 

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience", Order = 218)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Audience>? Audience { get; set; } 

        /// <summary>
        /// An embedded audio object.
        /// </summary>
        [DataMember(Name = "audio", Order = 219)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AudioObject>? Audio { get; set; } 

        /// <summary>
        /// The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.
        /// </summary>
        [DataMember(Name = "author", Order = 220)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAuthor>? Author { get; set; } //Organization, Person

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 221)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Award { get; set; } 

        /// <summary>
        /// Fictional person connected with a creative work.
        /// </summary>
        [DataMember(Name = "character", Order = 222)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Character { get; set; } 

        /// <summary>
        /// A citation or reference to another creative work, such as another publication, web page, scholarly article, etc.
        /// </summary>
        [DataMember(Name = "citation", Order = 223)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ICitation>? Citation { get; set; } //CreativeWork, string

        /// <summary>
        /// Comments, typically from users.
        /// </summary>
        [DataMember(Name = "comment", Order = 224)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Comment>? Comment { get; set; } 

        /// <summary>
        /// The number of comments this CreativeWork (e.g. Article, Question or Answer) has received. This is most applicable to works published in Web sites with commenting system; additional comments may exist elsewhere.
        /// </summary>
        [DataMember(Name = "commentCount", Order = 225)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int>? CommentCount { get; set; } 

        /// <summary>
        /// The location depicted or described in the content. For example, the location in a photograph or painting.
        /// </summary>
        [DataMember(Name = "contentLocation", Order = 226)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? ContentLocation { get; set; } 

        /// <summary>
        /// Official rating of a piece of content&amp;#x2014;for example,'MPAA PG-13'.
        /// </summary>
        [DataMember(Name = "contentRating", Order = 227)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ContentRating { get; set; } 

        /// <summary>
        /// The specific time described by a creative work, for works (e.g. articles, video objects etc.) that emphasise a particular moment within an Event.
        /// </summary>
        [DataMember(Name = "contentReferenceTime", Order = 228)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? ContentReferenceTime { get; set; } 

        /// <summary>
        /// A secondary contributor to the CreativeWork or Event.
        /// </summary>
        [DataMember(Name = "contributor", Order = 229)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IContributor>? Contributor { get; set; } //Organization, Person

        /// <summary>
        /// The party holding the legal copyright to the CreativeWork.
        /// </summary>
        [DataMember(Name = "copyrightHolder", Order = 230)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ICopyrightHolder>? CopyrightHolder { get; set; } //Organization, Person

        /// <summary>
        /// The year during which the claimed copyright for the CreativeWork was first asserted.
        /// </summary>
        [DataMember(Name = "copyrightYear", Order = 231)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int>? CopyrightYear { get; set; } 

        /// <summary>
        /// The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.
        /// </summary>
        [DataMember(Name = "creator", Order = 232)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ICreator>? Creator { get; set; } //Organization, Person

        /// <summary>
        /// The date on which the CreativeWork was created or the item was added to a DataFeed.
        /// </summary>
        [DataMember(Name = "dateCreated", Order = 233)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? DateCreated { get; set; } 

        /// <summary>
        /// The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.
        /// </summary>
        [DataMember(Name = "dateModified", Order = 234)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? DateModified { get; set; } 

        /// <summary>
        /// Date of first broadcast/publication.
        /// </summary>
        [DataMember(Name = "datePublished", Order = 235)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? DatePublished { get; set; } 

        /// <summary>
        /// A link to the page containing the comments of the CreativeWork.
        /// </summary>
        [DataMember(Name = "discussionUrl", Order = 236)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? DiscussionUrl { get; set; } 

        /// <summary>
        /// Specifies the Person who edited the CreativeWork.
        /// </summary>
        [DataMember(Name = "editor", Order = 237)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Editor { get; set; } 

        /// <summary>
        /// An alignment to an established educational framework.
        /// </summary>
        [DataMember(Name = "educationalAlignment", Order = 238)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AlignmentObject>? EducationalAlignment { get; set; } 

        /// <summary>
        /// The purpose of a work in the context of education; for example, 'assignment', 'group work'.
        /// </summary>
        [DataMember(Name = "educationalUse", Order = 239)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? EducationalUse { get; set; } 

        /// <summary>
        /// A media object that encodes this CreativeWork. This property is a synonym for associatedMedia.
        /// </summary>
        [DataMember(Name = "encoding", Order = 240)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MediaObject>? Encoding { get; set; } 

        /// <summary>
        /// A creative work that this work is an example/instance/realization/derivation of.
        /// </summary>
        [DataMember(Name = "exampleOfWork", Order = 241)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? ExampleOfWork { get; set; } 

        /// <summary>
        /// Date the content expires and is no longer useful or available. For example a &lt;a class="localLink" href="http://schema.org/VideoObject"&gt;VideoObject&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt; whose availability or relevance is time-limited, or a &lt;a class="localLink" href="http://schema.org/ClaimReview"&gt;ClaimReview&lt;/a&gt; fact check whose publisher wants to indicate that it may no longer be relevant (or helpful to highlight) after some date.
        /// </summary>
        [DataMember(Name = "expires", Order = 242)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? Expires { get; set; } 

        /// <summary>
        /// Media type, typically MIME format (see &lt;a href="http://www.iana.org/assignments/media-types/media-types.xhtml"&gt;IANA site&lt;/a&gt;) of the content e.g. application/zip of a SoftwareApplication binary. In cases where a CreativeWork has several media type representations, 'encoding' can be used to indicate each MediaObject alongside particular fileFormat information. Unregistered or niche file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia entry.
        /// </summary>
        [DataMember(Name = "fileFormat", Order = 243)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IFileFormat>? FileFormat { get; set; } //string, Uri

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 244)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IFunder>? Funder { get; set; } //Organization, Person

        /// <summary>
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        [DataMember(Name = "genre", Order = 245)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IGenre>? Genre { get; set; } //string, Uri

        /// <summary>
        /// Indicates a CreativeWork that is (in some sense) a part of this CreativeWork.
        /// </summary>
        [DataMember(Name = "hasPart", Order = 246)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? HasPart { get; set; } 

        /// <summary>
        /// Headline of the article.
        /// </summary>
        [DataMember(Name = "headline", Order = 247)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Headline { get; set; } 

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "inLanguage", Order = 248)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IInLanguage>? InLanguage { get; set; } //Language, string

        /// <summary>
        /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication. The most specific child type of InteractionCounter should be used.
        /// </summary>
        [DataMember(Name = "interactionStatistic", Order = 249)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<InteractionCounter>? InteractionStatistic { get; set; } 

        /// <summary>
        /// The predominant mode of learning supported by the learning resource. Acceptable values are 'active', 'expositive', or 'mixed'.
        /// </summary>
        [DataMember(Name = "interactivityType", Order = 250)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? InteractivityType { get; set; } 

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree", Order = 251)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<bool>? IsAccessibleForFree { get; set; } 

        /// <summary>
        /// A resource that was used in the creation of this resource. This term can be repeated for multiple sources. For example, http://example.com/great-multiplication-intro.html.
        /// </summary>
        [DataMember(Name = "isBasedOn", Order = 252)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IIsBasedOn>? IsBasedOn { get; set; } //CreativeWork, Product, Uri

        /// <summary>
        /// Indicates whether this content is family friendly.
        /// </summary>
        [DataMember(Name = "isFamilyFriendly", Order = 253)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<bool>? IsFamilyFriendly { get; set; } 

        /// <summary>
        /// Indicates a CreativeWork that this CreativeWork is (in some sense) part of.
        /// </summary>
        [DataMember(Name = "isPartOf", Order = 254)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? IsPartOf { get; set; } 

        /// <summary>
        /// Keywords or tags used to describe this content. Multiple entries in a keywords list are typically delimited by commas.
        /// </summary>
        [DataMember(Name = "keywords", Order = 255)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Keywords { get; set; } 

        /// <summary>
        /// The predominant type or kind characterizing the learning resource. For example, 'presentation', 'handout'.
        /// </summary>
        [DataMember(Name = "learningResourceType", Order = 256)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? LearningResourceType { get; set; } 

        /// <summary>
        /// A license document that applies to this content, typically indicated by URL.
        /// </summary>
        [DataMember(Name = "license", Order = 257)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ILicense>? License { get; set; } //CreativeWork, Uri

        /// <summary>
        /// The location where the CreativeWork was created, which may not be the same as the location depicted in the CreativeWork.
        /// </summary>
        [DataMember(Name = "locationCreated", Order = 258)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? LocationCreated { get; set; } 

        /// <summary>
        /// Indicates the primary entity described in some page or other CreativeWork.
        /// </summary>
        [DataMember(Name = "mainEntity", Order = 259)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? MainEntity { get; set; } 

        /// <summary>
        /// A material that something is made from, e.g. leather, wool, cotton, paper.
        /// </summary>
        [DataMember(Name = "material", Order = 260)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IMaterial>? Material { get; set; } //Product, string, Uri

        /// <summary>
        /// Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.
        /// </summary>
        [DataMember(Name = "mentions", Order = 261)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? Mentions { get; set; } 

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers", Order = 262)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Offer>? Offers { get; set; } 

        /// <summary>
        /// The position of an item in a series or sequence of items.
        /// </summary>
        [DataMember(Name = "position", Order = 263)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPosition>? Position { get; set; } //int?, string

        /// <summary>
        /// The person or organization who produced the work (e.g. music album, movie, tv/radio series etc.).
        /// </summary>
        [DataMember(Name = "producer", Order = 264)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IProducer>? Producer { get; set; } //Organization, Person

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 265)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IProvider>? Provider { get; set; } //Organization, Person

        /// <summary>
        /// A publication event associated with the item.
        /// </summary>
        [DataMember(Name = "publication", Order = 266)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PublicationEvent>? Publication { get; set; } 

        /// <summary>
        /// The publisher of the creative work.
        /// </summary>
        [DataMember(Name = "publisher", Order = 267)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPublisher>? Publisher { get; set; } //Organization, Person

        /// <summary>
        /// The publishing division which published the comic.
        /// </summary>
        [DataMember(Name = "publisherImprint", Order = 268)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? PublisherImprint { get; set; } 

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;/p&gt;
        /// &lt;p&gt;While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        [DataMember(Name = "publishingPrinciples", Order = 269)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPublishingPrinciples>? PublishingPrinciples { get; set; } //CreativeWork, Uri

        /// <summary>
        /// The Event where the CreativeWork was recorded. The CreativeWork may capture all or part of the event.
        /// </summary>
        [DataMember(Name = "recordedAt", Order = 270)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Event>? RecordedAt { get; set; } 

        /// <summary>
        /// The place and time the release was issued, expressed as a PublicationEvent.
        /// </summary>
        [DataMember(Name = "releasedEvent", Order = 271)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PublicationEvent>? ReleasedEvent { get; set; } 

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 272)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Review>? Review { get; set; } 

        /// <summary>
        /// Indicates (by URL or string) a particular version of a schema used in some CreativeWork. For example, a document could declare a schemaVersion using an URL such as http://schema.org/version/2.0/ if precise indication of schema version was required by some application.
        /// </summary>
        [DataMember(Name = "schemaVersion", Order = 273)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ISchemaVersion>? SchemaVersion { get; set; } //string, Uri

        /// <summary>
        /// The Organization on whose behalf the creator was working.
        /// </summary>
        [DataMember(Name = "sourceOrganization", Order = 274)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? SourceOrganization { get; set; } 

        /// <summary>
        /// The spatialCoverage of a CreativeWork indicates the place(s) which are the focus of the content. It is a subproperty of
        ///       contentLocation intended primarily for more technical and detailed materials. For example with a Dataset, it indicates
        ///       areas that the dataset describes: a dataset of New York weather would have spatialCoverage which was the place: the state of New York.
        /// </summary>
        [DataMember(Name = "spatialCoverage", Order = 275)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? SpatialCoverage { get; set; } 

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 276)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ISponsor>? Sponsor { get; set; } //Organization, Person

        /// <summary>
        /// The temporalCoverage of a CreativeWork indicates the period that the content applies to, i.e. that it describes, either as a DateTime or as a textual string indicating a time period in &lt;a href="https://en.wikipedia.org/wiki/ISO_8601#Time_intervals"&gt;ISO 8601 time interval format&lt;/a&gt;. In
        ///       the case of a Dataset it will typically indicate the relevant time period in a precise notation (e.g. for a 2011 census dataset, the year 2011 would be written "2011/2012"). Other forms of content e.g. ScholarlyArticle, Book, TVSeries or TVEpisode may indicate their temporalCoverage in broader terms - textually or via well-known URL.
        ///       Written works such as books may sometimes have precise temporal coverage too, e.g. a work set in 1939 - 1945 can be indicated in ISO 8601 interval format format via "1939/1945".
        /// </summary>
        [DataMember(Name = "temporalCoverage", Order = 277)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ITemporalCoverage>? TemporalCoverage { get; set; } //DateTimeOffset?, string, Uri

        /// <summary>
        /// The textual content of this CreativeWork.
        /// </summary>
        [DataMember(Name = "text", Order = 278)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Text { get; set; } 

        /// <summary>
        /// A thumbnail image relevant to the Thing.
        /// </summary>
        [DataMember(Name = "thumbnailUrl", Order = 279)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? ThumbnailUrl { get; set; } 

        /// <summary>
        /// Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience, e.g. 'P30M', 'P1H25M'.
        /// </summary>
        [DataMember(Name = "timeRequired", Order = 280)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan>? TimeRequired { get; set; } 

        /// <summary>
        /// The work that this work has been translated from. e.g. 物种起源 is a translationOf “On the Origin of Species”
        /// </summary>
        [DataMember(Name = "translationOfWork", Order = 281)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? TranslationOfWork { get; set; } 

        /// <summary>
        /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
        /// </summary>
        [DataMember(Name = "translator", Order = 282)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ITranslator>? Translator { get; set; } //Organization, Person

        /// <summary>
        /// The typical expected age range, e.g. '7-9', '11-'.
        /// </summary>
        [DataMember(Name = "typicalAgeRange", Order = 283)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? TypicalAgeRange { get; set; } 

        /// <summary>
        /// The version of the CreativeWork embodied by a specified resource.
        /// </summary>
        [DataMember(Name = "version", Order = 284)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IVersion>? Version { get; set; } //double?, string

        /// <summary>
        /// An embedded video object.
        /// </summary>
        [DataMember(Name = "video", Order = 285)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<VideoObject>? Video { get; set; } 

        /// <summary>
        /// Example/instance/realization/derivation of the concept of this creative work. eg. The paperback edition, first edition, or eBook.
        /// </summary>
        [DataMember(Name = "workExample", Order = 286)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? WorkExample { get; set; } 

        /// <summary>
        /// A work that is a translation of the content of this work. e.g. 西遊記 has an English workTranslation “Journey to the West”,a German workTranslation “Monkeys Pilgerfahrt” and a Vietnamese  translation Tây du ký bình khảo.
        /// </summary>
        [DataMember(Name = "workTranslation", Order = 287)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? WorkTranslation { get; set; } 
    }
}
