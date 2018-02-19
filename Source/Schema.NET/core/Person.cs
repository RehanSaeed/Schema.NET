using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
    [DataContract]
    public partial class Person : Thing
    {
        public interface IAddress : IWrapper { }
        public interface IAddress<T> : IAddress { new T Data { get; set; } }
        public class AddressPostalAddress : IAddress<PostalAddress>
        {
            object IWrapper.Data { get { return Data; } set { Data = (PostalAddress) value; } }
            public virtual PostalAddress Data { get; set; }
            public AddressPostalAddress () { }
            public AddressPostalAddress (PostalAddress data) { Data = data; }
            public static implicit operator AddressPostalAddress (PostalAddress data) { return new AddressPostalAddress (data); }
        }

        public class Addressstring : IAddress<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Addressstring () { }
            public Addressstring (string data) { Data = data; }
            public static implicit operator Addressstring (string data) { return new Addressstring (data); }
        }


        public interface IAlumniOf : IWrapper { }
        public interface IAlumniOf<T> : IAlumniOf { new T Data { get; set; } }
        public class AlumniOfEducationalOrganization : IAlumniOf<EducationalOrganization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (EducationalOrganization) value; } }
            public virtual EducationalOrganization Data { get; set; }
            public AlumniOfEducationalOrganization () { }
            public AlumniOfEducationalOrganization (EducationalOrganization data) { Data = data; }
            public static implicit operator AlumniOfEducationalOrganization (EducationalOrganization data) { return new AlumniOfEducationalOrganization (data); }
        }

        public class AlumniOfOrganization : IAlumniOf<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public AlumniOfOrganization () { }
            public AlumniOfOrganization (Organization data) { Data = data; }
            public static implicit operator AlumniOfOrganization (Organization data) { return new AlumniOfOrganization (data); }
        }


        public interface IBrand : IWrapper { }
        public interface IBrand<T> : IBrand { new T Data { get; set; } }
        public class BrandBrand : IBrand<Brand>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Brand) value; } }
            public virtual Brand Data { get; set; }
            public BrandBrand () { }
            public BrandBrand (Brand data) { Data = data; }
            public static implicit operator BrandBrand (Brand data) { return new BrandBrand (data); }
        }

        public class BrandOrganization : IBrand<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public BrandOrganization () { }
            public BrandOrganization (Organization data) { Data = data; }
            public static implicit operator BrandOrganization (Organization data) { return new BrandOrganization (data); }
        }


        public interface IColleague : IWrapper { }
        public interface IColleague<T> : IColleague { new T Data { get; set; } }
        public class ColleaguePerson : IColleague<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public ColleaguePerson () { }
            public ColleaguePerson (Person data) { Data = data; }
            public static implicit operator ColleaguePerson (Person data) { return new ColleaguePerson (data); }
        }

        public class ColleagueUri : IColleague<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public ColleagueUri () { }
            public ColleagueUri (Uri data) { Data = data; }
            public static implicit operator ColleagueUri (Uri data) { return new ColleagueUri (data); }
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


        public interface IGender : IWrapper { }
        public interface IGender<T> : IGender { new T Data { get; set; } }
        public class GenderGenderType : IGender<GenderType>
        {
            object IWrapper.Data { get { return Data; } set { Data = (GenderType) value; } }
            public virtual GenderType Data { get; set; }
            public GenderGenderType () { }
            public GenderGenderType (GenderType data) { Data = data; }
            public static implicit operator GenderGenderType (GenderType data) { return new GenderGenderType (data); }
        }

        public class Genderstring : IGender<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Genderstring () { }
            public Genderstring (string data) { Data = data; }
            public static implicit operator Genderstring (string data) { return new Genderstring (data); }
        }


        public interface IHeight : IWrapper { }
        public interface IHeight<T> : IHeight { new T Data { get; set; } }
        public class Heightstring : IHeight<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Heightstring () { }
            public Heightstring (string data) { Data = data; }
            public static implicit operator Heightstring (string data) { return new Heightstring (data); }
        }

        public class HeightQuantitativeValue : IHeight<QuantitativeValue>
        {
            object IWrapper.Data { get { return Data; } set { Data = (QuantitativeValue) value; } }
            public virtual QuantitativeValue Data { get; set; }
            public HeightQuantitativeValue () { }
            public HeightQuantitativeValue (QuantitativeValue data) { Data = data; }
            public static implicit operator HeightQuantitativeValue (QuantitativeValue data) { return new HeightQuantitativeValue (data); }
        }


        public interface IHomeLocation : IWrapper { }
        public interface IHomeLocation<T> : IHomeLocation { new T Data { get; set; } }
        public class HomeLocationContactPoint : IHomeLocation<ContactPoint>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ContactPoint) value; } }
            public virtual ContactPoint Data { get; set; }
            public HomeLocationContactPoint () { }
            public HomeLocationContactPoint (ContactPoint data) { Data = data; }
            public static implicit operator HomeLocationContactPoint (ContactPoint data) { return new HomeLocationContactPoint (data); }
        }

        public class HomeLocationPlace : IHomeLocation<Place>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Place) value; } }
            public virtual Place Data { get; set; }
            public HomeLocationPlace () { }
            public HomeLocationPlace (Place data) { Data = data; }
            public static implicit operator HomeLocationPlace (Place data) { return new HomeLocationPlace (data); }
        }


        public interface IMemberOf : IWrapper { }
        public interface IMemberOf<T> : IMemberOf { new T Data { get; set; } }
        public class MemberOfOrganization : IMemberOf<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public MemberOfOrganization () { }
            public MemberOfOrganization (Organization data) { Data = data; }
            public static implicit operator MemberOfOrganization (Organization data) { return new MemberOfOrganization (data); }
        }

        public class MemberOfProgramMembership : IMemberOf<ProgramMembership>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ProgramMembership) value; } }
            public virtual ProgramMembership Data { get; set; }
            public MemberOfProgramMembership () { }
            public MemberOfProgramMembership (ProgramMembership data) { Data = data; }
            public static implicit operator MemberOfProgramMembership (ProgramMembership data) { return new MemberOfProgramMembership (data); }
        }


        public interface INetWorth : IWrapper { }
        public interface INetWorth<T> : INetWorth { new T Data { get; set; } }
        public class NetWorthMonetaryAmount : INetWorth<MonetaryAmount>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MonetaryAmount) value; } }
            public virtual MonetaryAmount Data { get; set; }
            public NetWorthMonetaryAmount () { }
            public NetWorthMonetaryAmount (MonetaryAmount data) { Data = data; }
            public static implicit operator NetWorthMonetaryAmount (MonetaryAmount data) { return new NetWorthMonetaryAmount (data); }
        }

        public class NetWorthPriceSpecification : INetWorth<PriceSpecification>
        {
            object IWrapper.Data { get { return Data; } set { Data = (PriceSpecification) value; } }
            public virtual PriceSpecification Data { get; set; }
            public NetWorthPriceSpecification () { }
            public NetWorthPriceSpecification (PriceSpecification data) { Data = data; }
            public static implicit operator NetWorthPriceSpecification (PriceSpecification data) { return new NetWorthPriceSpecification (data); }
        }


        public interface IOwns : IWrapper { }
        public interface IOwns<T> : IOwns { new T Data { get; set; } }
        public class OwnsOwnershipInfo : IOwns<OwnershipInfo>
        {
            object IWrapper.Data { get { return Data; } set { Data = (OwnershipInfo) value; } }
            public virtual OwnershipInfo Data { get; set; }
            public OwnsOwnershipInfo () { }
            public OwnsOwnershipInfo (OwnershipInfo data) { Data = data; }
            public static implicit operator OwnsOwnershipInfo (OwnershipInfo data) { return new OwnsOwnershipInfo (data); }
        }

        public class OwnsProduct : IOwns<Product>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Product) value; } }
            public virtual Product Data { get; set; }
            public OwnsProduct () { }
            public OwnsProduct (Product data) { Data = data; }
            public static implicit operator OwnsProduct (Product data) { return new OwnsProduct (data); }
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


        public interface IWorkLocation : IWrapper { }
        public interface IWorkLocation<T> : IWorkLocation { new T Data { get; set; } }
        public class WorkLocationContactPoint : IWorkLocation<ContactPoint>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ContactPoint) value; } }
            public virtual ContactPoint Data { get; set; }
            public WorkLocationContactPoint () { }
            public WorkLocationContactPoint (ContactPoint data) { Data = data; }
            public static implicit operator WorkLocationContactPoint (ContactPoint data) { return new WorkLocationContactPoint (data); }
        }

        public class WorkLocationPlace : IWorkLocation<Place>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Place) value; } }
            public virtual Place Data { get; set; }
            public WorkLocationPlace () { }
            public WorkLocationPlace (Place data) { Data = data; }
            public static implicit operator WorkLocationPlace (Place data) { return new WorkLocationPlace (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Person";

        /// <summary>
        /// An additional name for a Person, can be used for a middle name.
        /// </summary>
        [DataMember(Name = "additionalName", Order = 106)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AdditionalName { get; set; } 

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 107)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAddress>? Address { get; set; } //PostalAddress, string

        /// <summary>
        /// An organization that this person is affiliated with. For example, a school/university, a club, or a team.
        /// </summary>
        [DataMember(Name = "affiliation", Order = 108)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? Affiliation { get; set; } 

        /// <summary>
        /// An organization that the person is an alumni of.
        /// </summary>
        [DataMember(Name = "alumniOf", Order = 109)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAlumniOf>? AlumniOf { get; set; } //EducationalOrganization, Organization

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 110)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Award { get; set; } 

        /// <summary>
        /// Date of birth.
        /// </summary>
        [DataMember(Name = "birthDate", Order = 111)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? BirthDate { get; set; } 

        /// <summary>
        /// The place where the person was born.
        /// </summary>
        [DataMember(Name = "birthPlace", Order = 112)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? BirthPlace { get; set; } 

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 113)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IBrand>? Brand { get; set; } //Brand, Organization

        /// <summary>
        /// A child of the person.
        /// </summary>
        [DataMember(Name = "children", Order = 114)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Children { get; set; } 

        /// <summary>
        /// A colleague of the person.
        /// </summary>
        [DataMember(Name = "colleague", Order = 115)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IColleague>? Colleague { get; set; } //Person, Uri

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        [DataMember(Name = "contactPoint", Order = 116)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ContactPoint>? ContactPoint { get; set; } 

        /// <summary>
        /// Date of death.
        /// </summary>
        [DataMember(Name = "deathDate", Order = 117)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? DeathDate { get; set; } 

        /// <summary>
        /// The place where the person died.
        /// </summary>
        [DataMember(Name = "deathPlace", Order = 118)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? DeathPlace { get; set; } 

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        [DataMember(Name = "duns", Order = 119)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Duns { get; set; } 

        /// <summary>
        /// Email address.
        /// </summary>
        [DataMember(Name = "email", Order = 120)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Email { get; set; } 

        /// <summary>
        /// Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the name property.
        /// </summary>
        [DataMember(Name = "familyName", Order = 121)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? FamilyName { get; set; } 

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 122)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? FaxNumber { get; set; } 

        /// <summary>
        /// The most generic uni-directional social relation.
        /// </summary>
        [DataMember(Name = "follows", Order = 123)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Follows { get; set; } 

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 124)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IFunder>? Funder { get; set; } //Organization, Person

        /// <summary>
        /// Gender of the person. While http://schema.org/Male and http://schema.org/Female may be used, text strings are also acceptable for people who do not identify as a binary gender.
        /// </summary>
        [DataMember(Name = "gender", Order = 125)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IGender>? Gender { get; set; } //GenderType?, string

        /// <summary>
        /// Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the name property.
        /// </summary>
        [DataMember(Name = "givenName", Order = 126)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? GivenName { get; set; } 

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber", Order = 127)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? GlobalLocationNumber { get; set; } 

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [DataMember(Name = "hasOfferCatalog", Order = 128)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<OfferCatalog>? HasOfferCatalog { get; set; } 

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        [DataMember(Name = "hasPOS", Order = 129)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? HasPOS { get; set; } 

        /// <summary>
        /// The height of the item.
        /// </summary>
        [DataMember(Name = "height", Order = 130)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IHeight>? Height { get; set; } //string, QuantitativeValue

        /// <summary>
        /// A contact location for a person's residence.
        /// </summary>
        [DataMember(Name = "homeLocation", Order = 131)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IHomeLocation>? HomeLocation { get; set; } //ContactPoint, Place

        /// <summary>
        /// An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.
        /// </summary>
        [DataMember(Name = "honorificPrefix", Order = 132)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? HonorificPrefix { get; set; } 

        /// <summary>
        /// An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.
        /// </summary>
        [DataMember(Name = "honorificSuffix", Order = 133)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? HonorificSuffix { get; set; } 

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4", Order = 134)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? IsicV4 { get; set; } 

        /// <summary>
        /// The job title of the person (for example, Financial Manager).
        /// </summary>
        [DataMember(Name = "jobTitle", Order = 135)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? JobTitle { get; set; } 

        /// <summary>
        /// The most generic bi-directional social/work relation.
        /// </summary>
        [DataMember(Name = "knows", Order = 136)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Knows { get; set; } 

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        [DataMember(Name = "makesOffer", Order = 137)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Offer>? MakesOffer { get; set; } 

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        [DataMember(Name = "memberOf", Order = 138)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IMemberOf>? MemberOf { get; set; } //Organization, ProgramMembership

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        [DataMember(Name = "naics", Order = 139)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Naics { get; set; } 

        /// <summary>
        /// Nationality of the person.
        /// </summary>
        [DataMember(Name = "nationality", Order = 140)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Country>? Nationality { get; set; } 

        /// <summary>
        /// The total financial value of the person as calculated by subtracting assets from liabilities.
        /// </summary>
        [DataMember(Name = "netWorth", Order = 141)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<INetWorth>? NetWorth { get; set; } //MonetaryAmount, PriceSpecification

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        [DataMember(Name = "owns", Order = 142)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IOwns>? Owns { get; set; } //OwnershipInfo, Product

        /// <summary>
        /// A parent of this person.
        /// </summary>
        [DataMember(Name = "parent", Order = 143)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Parent { get; set; } 

        /// <summary>
        /// Event that this person is a performer or participant in.
        /// </summary>
        [DataMember(Name = "performerIn", Order = 144)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Event>? PerformerIn { get; set; } 

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;/p&gt;
        /// &lt;p&gt;While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        [DataMember(Name = "publishingPrinciples", Order = 145)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPublishingPrinciples>? PublishingPrinciples { get; set; } //CreativeWork, Uri

        /// <summary>
        /// The most generic familial relation.
        /// </summary>
        [DataMember(Name = "relatedTo", Order = 146)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? RelatedTo { get; set; } 

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        [DataMember(Name = "seeks", Order = 147)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Demand>? Seeks { get; set; } 

        /// <summary>
        /// A sibling of the person.
        /// </summary>
        [DataMember(Name = "sibling", Order = 148)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Sibling { get; set; } 

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 149)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ISponsor>? Sponsor { get; set; } //Organization, Person

        /// <summary>
        /// The person's spouse.
        /// </summary>
        [DataMember(Name = "spouse", Order = 150)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Spouse { get; set; } 

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [DataMember(Name = "taxID", Order = 151)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? TaxID { get; set; } 

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 152)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Telephone { get; set; } 

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        [DataMember(Name = "vatID", Order = 153)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? VatID { get; set; } 

        /// <summary>
        /// The weight of the product or person.
        /// </summary>
        [DataMember(Name = "weight", Order = 154)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? Weight { get; set; } 

        /// <summary>
        /// A contact location for a person's place of work.
        /// </summary>
        [DataMember(Name = "workLocation", Order = 155)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IWorkLocation>? WorkLocation { get; set; } //ContactPoint, Place

        /// <summary>
        /// Organizations that the person works for.
        /// </summary>
        [DataMember(Name = "worksFor", Order = 156)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? WorksFor { get; set; } 
    }
}
