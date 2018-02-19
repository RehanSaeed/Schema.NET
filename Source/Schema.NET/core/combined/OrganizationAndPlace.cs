using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// See Organization, Place for more information.
    /// </summary>
    [DataContract]
    public abstract partial class OrganizationAndPlace : Thing
    {
        public interface IActionableFeedbackPolicy : IWrapper { }
        public interface IActionableFeedbackPolicy<T> : IActionableFeedbackPolicy { new T Data { get; set; } }
        public class ActionableFeedbackPolicyCreativeWork : IActionableFeedbackPolicy<CreativeWork>
        {
            object IWrapper.Data { get { return Data; } set { Data = (CreativeWork) value; } }
            public virtual CreativeWork Data { get; set; }
            public ActionableFeedbackPolicyCreativeWork () { }
            public ActionableFeedbackPolicyCreativeWork (CreativeWork data) { Data = data; }
            public static implicit operator ActionableFeedbackPolicyCreativeWork (CreativeWork data) { return new ActionableFeedbackPolicyCreativeWork (data); }
        }

        public class ActionableFeedbackPolicyUri : IActionableFeedbackPolicy<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public ActionableFeedbackPolicyUri () { }
            public ActionableFeedbackPolicyUri (Uri data) { Data = data; }
            public static implicit operator ActionableFeedbackPolicyUri (Uri data) { return new ActionableFeedbackPolicyUri (data); }
        }


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


        public interface IAreaServed : IWrapper { }
        public interface IAreaServed<T> : IAreaServed { new T Data { get; set; } }
        public class AreaServedAdministrativeArea : IAreaServed<AdministrativeArea>
        {
            object IWrapper.Data { get { return Data; } set { Data = (AdministrativeArea) value; } }
            public virtual AdministrativeArea Data { get; set; }
            public AreaServedAdministrativeArea () { }
            public AreaServedAdministrativeArea (AdministrativeArea data) { Data = data; }
            public static implicit operator AreaServedAdministrativeArea (AdministrativeArea data) { return new AreaServedAdministrativeArea (data); }
        }

        public class AreaServedGeoShape : IAreaServed<GeoShape>
        {
            object IWrapper.Data { get { return Data; } set { Data = (GeoShape) value; } }
            public virtual GeoShape Data { get; set; }
            public AreaServedGeoShape () { }
            public AreaServedGeoShape (GeoShape data) { Data = data; }
            public static implicit operator AreaServedGeoShape (GeoShape data) { return new AreaServedGeoShape (data); }
        }

        public class AreaServedPlace : IAreaServed<Place>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Place) value; } }
            public virtual Place Data { get; set; }
            public AreaServedPlace () { }
            public AreaServedPlace (Place data) { Data = data; }
            public static implicit operator AreaServedPlace (Place data) { return new AreaServedPlace (data); }
        }

        public class AreaServedstring : IAreaServed<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public AreaServedstring () { }
            public AreaServedstring (string data) { Data = data; }
            public static implicit operator AreaServedstring (string data) { return new AreaServedstring (data); }
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


        public interface ICorrectionsPolicy : IWrapper { }
        public interface ICorrectionsPolicy<T> : ICorrectionsPolicy { new T Data { get; set; } }
        public class CorrectionsPolicyCreativeWork : ICorrectionsPolicy<CreativeWork>
        {
            object IWrapper.Data { get { return Data; } set { Data = (CreativeWork) value; } }
            public virtual CreativeWork Data { get; set; }
            public CorrectionsPolicyCreativeWork () { }
            public CorrectionsPolicyCreativeWork (CreativeWork data) { Data = data; }
            public static implicit operator CorrectionsPolicyCreativeWork (CreativeWork data) { return new CorrectionsPolicyCreativeWork (data); }
        }

        public class CorrectionsPolicyUri : ICorrectionsPolicy<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public CorrectionsPolicyUri () { }
            public CorrectionsPolicyUri (Uri data) { Data = data; }
            public static implicit operator CorrectionsPolicyUri (Uri data) { return new CorrectionsPolicyUri (data); }
        }


        public interface IDiversityPolicy : IWrapper { }
        public interface IDiversityPolicy<T> : IDiversityPolicy { new T Data { get; set; } }
        public class DiversityPolicyCreativeWork : IDiversityPolicy<CreativeWork>
        {
            object IWrapper.Data { get { return Data; } set { Data = (CreativeWork) value; } }
            public virtual CreativeWork Data { get; set; }
            public DiversityPolicyCreativeWork () { }
            public DiversityPolicyCreativeWork (CreativeWork data) { Data = data; }
            public static implicit operator DiversityPolicyCreativeWork (CreativeWork data) { return new DiversityPolicyCreativeWork (data); }
        }

        public class DiversityPolicyUri : IDiversityPolicy<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public DiversityPolicyUri () { }
            public DiversityPolicyUri (Uri data) { Data = data; }
            public static implicit operator DiversityPolicyUri (Uri data) { return new DiversityPolicyUri (data); }
        }


        public interface IEthicsPolicy : IWrapper { }
        public interface IEthicsPolicy<T> : IEthicsPolicy { new T Data { get; set; } }
        public class EthicsPolicyCreativeWork : IEthicsPolicy<CreativeWork>
        {
            object IWrapper.Data { get { return Data; } set { Data = (CreativeWork) value; } }
            public virtual CreativeWork Data { get; set; }
            public EthicsPolicyCreativeWork () { }
            public EthicsPolicyCreativeWork (CreativeWork data) { Data = data; }
            public static implicit operator EthicsPolicyCreativeWork (CreativeWork data) { return new EthicsPolicyCreativeWork (data); }
        }

        public class EthicsPolicyUri : IEthicsPolicy<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public EthicsPolicyUri () { }
            public EthicsPolicyUri (Uri data) { Data = data; }
            public static implicit operator EthicsPolicyUri (Uri data) { return new EthicsPolicyUri (data); }
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


        public interface IGeo : IWrapper { }
        public interface IGeo<T> : IGeo { new T Data { get; set; } }
        public class GeoGeoCoordinates : IGeo<GeoCoordinates>
        {
            object IWrapper.Data { get { return Data; } set { Data = (GeoCoordinates) value; } }
            public virtual GeoCoordinates Data { get; set; }
            public GeoGeoCoordinates () { }
            public GeoGeoCoordinates (GeoCoordinates data) { Data = data; }
            public static implicit operator GeoGeoCoordinates (GeoCoordinates data) { return new GeoGeoCoordinates (data); }
        }

        public class GeoGeoShape : IGeo<GeoShape>
        {
            object IWrapper.Data { get { return Data; } set { Data = (GeoShape) value; } }
            public virtual GeoShape Data { get; set; }
            public GeoGeoShape () { }
            public GeoGeoShape (GeoShape data) { Data = data; }
            public static implicit operator GeoGeoShape (GeoShape data) { return new GeoGeoShape (data); }
        }


        public interface IHasMap : IWrapper { }
        public interface IHasMap<T> : IHasMap { new T Data { get; set; } }
        public class HasMapMap : IHasMap<Map>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Map) value; } }
            public virtual Map Data { get; set; }
            public HasMapMap () { }
            public HasMapMap (Map data) { Data = data; }
            public static implicit operator HasMapMap (Map data) { return new HasMapMap (data); }
        }

        public class HasMapUri : IHasMap<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public HasMapUri () { }
            public HasMapUri (Uri data) { Data = data; }
            public static implicit operator HasMapUri (Uri data) { return new HasMapUri (data); }
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


        public interface ILogo : IWrapper { }
        public interface ILogo<T> : ILogo { new T Data { get; set; } }
        public class LogoImageObject : ILogo<ImageObject>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ImageObject) value; } }
            public virtual ImageObject Data { get; set; }
            public LogoImageObject () { }
            public LogoImageObject (ImageObject data) { Data = data; }
            public static implicit operator LogoImageObject (ImageObject data) { return new LogoImageObject (data); }
        }

        public class LogoUri : ILogo<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public LogoUri () { }
            public LogoUri (Uri data) { Data = data; }
            public static implicit operator LogoUri (Uri data) { return new LogoUri (data); }
        }


        public interface IMember : IWrapper { }
        public interface IMember<T> : IMember { new T Data { get; set; } }
        public class MemberOrganization : IMember<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public MemberOrganization () { }
            public MemberOrganization (Organization data) { Data = data; }
            public static implicit operator MemberOrganization (Organization data) { return new MemberOrganization (data); }
        }

        public class MemberPerson : IMember<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public MemberPerson () { }
            public MemberPerson (Person data) { Data = data; }
            public static implicit operator MemberPerson (Person data) { return new MemberPerson (data); }
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


        public interface IPhoto : IWrapper { }
        public interface IPhoto<T> : IPhoto { new T Data { get; set; } }
        public class PhotoImageObject : IPhoto<ImageObject>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ImageObject) value; } }
            public virtual ImageObject Data { get; set; }
            public PhotoImageObject () { }
            public PhotoImageObject (ImageObject data) { Data = data; }
            public static implicit operator PhotoImageObject (ImageObject data) { return new PhotoImageObject (data); }
        }

        public class PhotoPhotograph : IPhoto<Photograph>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Photograph) value; } }
            public virtual Photograph Data { get; set; }
            public PhotoPhotograph () { }
            public PhotoPhotograph (Photograph data) { Data = data; }
            public static implicit operator PhotoPhotograph (Photograph data) { return new PhotoPhotograph (data); }
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


        public interface IUnnamedSourcesPolicy : IWrapper { }
        public interface IUnnamedSourcesPolicy<T> : IUnnamedSourcesPolicy { new T Data { get; set; } }
        public class UnnamedSourcesPolicyCreativeWork : IUnnamedSourcesPolicy<CreativeWork>
        {
            object IWrapper.Data { get { return Data; } set { Data = (CreativeWork) value; } }
            public virtual CreativeWork Data { get; set; }
            public UnnamedSourcesPolicyCreativeWork () { }
            public UnnamedSourcesPolicyCreativeWork (CreativeWork data) { Data = data; }
            public static implicit operator UnnamedSourcesPolicyCreativeWork (CreativeWork data) { return new UnnamedSourcesPolicyCreativeWork (data); }
        }

        public class UnnamedSourcesPolicyUri : IUnnamedSourcesPolicy<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public UnnamedSourcesPolicyUri () { }
            public UnnamedSourcesPolicyUri (Uri data) { Data = data; }
            public static implicit operator UnnamedSourcesPolicyUri (Uri data) { return new UnnamedSourcesPolicyUri (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OrganizationAndPlace";

        /// <summary>
        /// For a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt; or other news-related &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, a statement about public engagement activities (for news media, the newsroom’s), including involving the public - digitally or otherwise -- in coverage decisions, reporting and activities after publication.
        /// </summary>
        [DataMember(Name = "actionableFeedbackPolicy", Order = 106)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<IActionableFeedbackPolicy>? ActionableFeedbackPolicy { get; set; } //CreativeWork, Uri

        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;/p&gt;
        /// &lt;p&gt;Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        [DataMember(Name = "additionalProperty", Order = 107)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<PropertyValue>? AdditionalProperty { get; set; } 

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 108)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<IAddress>? Address { get; set; } //PostalAddress, string

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 109)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<AggregateRating>? AggregateRating { get; set; } 

        /// <summary>
        /// Alumni of an organization.
        /// </summary>
        [DataMember(Name = "alumni", Order = 110)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Person>? Alumni { get; set; } 

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [DataMember(Name = "amenityFeature", Order = 111)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<LocationFeatureSpecification>? AmenityFeature { get; set; } 

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 112)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<IAreaServed>? AreaServed { get; set; } //AdministrativeArea, GeoShape, Place, string

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 113)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? Award { get; set; } 

        /// <summary>
        /// A short textual code (also called "store code") that uniquely identifies a place of business. The code is typically assigned by the parentOrganization and used in structured URLs.&lt;/p&gt;
        /// &lt;p&gt;For example, in the URL http://www.starbucks.co.uk/store-locator/etc/detail/3047 the code "3047" is a branchCode for a particular branch.
        /// </summary>
        [DataMember(Name = "branchCode", Order = 114)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? BranchCode { get; set; } 

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 115)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<IBrand>? Brand { get; set; } //Brand, Organization

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        [DataMember(Name = "contactPoint", Order = 116)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<ContactPoint>? ContactPoint { get; set; } 

        /// <summary>
        /// The basic containment relation between a place and one that contains it.
        /// </summary>
        [DataMember(Name = "containedInPlace", Order = 117)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? ContainedInPlace { get; set; } 

        /// <summary>
        /// The basic containment relation between a place and another that it contains.
        /// </summary>
        [DataMember(Name = "containsPlace", Order = 118)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? ContainsPlace { get; set; } 

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a statement describing (in news media, the newsroom’s) disclosure and correction policy for errors.
        /// </summary>
        [DataMember(Name = "correctionsPolicy", Order = 119)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<ICorrectionsPolicy>? CorrectionsPolicy { get; set; } //CreativeWork, Uri

        /// <summary>
        /// A relationship between an organization and a department of that organization, also described as an organization (allowing different urls, logos, opening hours). For example: a store with a pharmacy, or a bakery with a cafe.
        /// </summary>
        [DataMember(Name = "department", Order = 120)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Organization>? Department { get; set; } 

        /// <summary>
        /// The date that this organization was dissolved.
        /// </summary>
        [DataMember(Name = "dissolutionDate", Order = 121)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<DateTimeOffset>? DissolutionDate { get; set; } 

        /// <summary>
        /// Statement on diversity policy by an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; e.g. a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;. For a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;, a statement describing the newsroom’s diversity policy on both staffing and sources, typically providing staffing data.
        /// </summary>
        [DataMember(Name = "diversityPolicy", Order = 122)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<IDiversityPolicy>? DiversityPolicy { get; set; } //CreativeWork, Uri

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        [DataMember(Name = "duns", Order = 123)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? Duns { get; set; } 

        /// <summary>
        /// Email address.
        /// </summary>
        [DataMember(Name = "email", Order = 124)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? Email { get; set; } 

        /// <summary>
        /// Someone working for this organization.
        /// </summary>
        [DataMember(Name = "employee", Order = 125)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Person>? Employee { get; set; } 

        /// <summary>
        /// Statement about ethics policy, e.g. of a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt; regarding journalistic and publishing practices, or of a &lt;a class="localLink" href="http://schema.org/Restaurant"&gt;Restaurant&lt;/a&gt;, a page describing food source policies. In the case of a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;, an ethicsPolicy is typically a statement describing the personal, organizational, and corporate standards of behavior expected by the organization.
        /// </summary>
        [DataMember(Name = "ethicsPolicy", Order = 126)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<IEthicsPolicy>? EthicsPolicy { get; set; } //CreativeWork, Uri

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 127)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Event>? Event { get; set; } 

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 128)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? FaxNumber { get; set; } 

        /// <summary>
        /// A person who founded this organization.
        /// </summary>
        [DataMember(Name = "founder", Order = 129)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Person>? Founder { get; set; } 

        /// <summary>
        /// The date that this organization was founded.
        /// </summary>
        [DataMember(Name = "foundingDate", Order = 130)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<DateTimeOffset>? FoundingDate { get; set; } 

        /// <summary>
        /// The place where the Organization was founded.
        /// </summary>
        [DataMember(Name = "foundingLocation", Order = 131)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? FoundingLocation { get; set; } 

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 132)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<IFunder>? Funder { get; set; } //Organization, Person

        /// <summary>
        /// The geo coordinates of the place.
        /// </summary>
        [DataMember(Name = "geo", Order = 133)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<IGeo>? Geo { get; set; } //GeoCoordinates, GeoShape

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a containing geometry to a contained geometry. "a contains b iff no points of b lie in the exterior of a, and at least one point of the interior of b lies in the interior of a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyContains", Order = 134)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? GeospatiallyContains { get; set; } 

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that covers it. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyCoveredBy", Order = 135)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? GeospatiallyCoveredBy { get; set; } 

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a covering geometry to a covered geometry. "Every point of b is a point of (the interior or boundary of) a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyCovers", Order = 136)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? GeospatiallyCovers { get; set; } 

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that crosses it: "a crosses b: they have some but not all interior points in common, and the dimension of the intersection is less than that of at least one of them". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyCrosses", Order = 137)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? GeospatiallyCrosses { get; set; } 

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically disjoint: they have no point in common. They form a set of disconnected geometries." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;)
        /// </summary>
        [DataMember(Name = "geospatiallyDisjoint", Order = 138)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? GeospatiallyDisjoint { get; set; } 

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically equal, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;. "Two geometries are topologically equal if their interiors intersect and no part of the interior or boundary of one geometry intersects the exterior of the other" (a symmetric relationship)
        /// </summary>
        [DataMember(Name = "geospatiallyEquals", Order = 139)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? GeospatiallyEquals { get; set; } 

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) have at least one point in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyIntersects", Order = 140)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? GeospatiallyIntersects { get; set; } 

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that geospatially overlaps it, i.e. they have some but not all points in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyOverlaps", Order = 141)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? GeospatiallyOverlaps { get; set; } 

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) touch: they have at least one boundary point in common, but no interior points." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt; )
        /// </summary>
        [DataMember(Name = "geospatiallyTouches", Order = 142)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? GeospatiallyTouches { get; set; } 

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to one that contains it, i.e. it is inside (i.e. within) its interior. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyWithin", Order = 143)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? GeospatiallyWithin { get; set; } 

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber", Order = 144)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? GlobalLocationNumber { get; set; } 

        /// <summary>
        /// A URL to a map of the place.
        /// </summary>
        [DataMember(Name = "hasMap", Order = 145)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<IHasMap>? HasMap { get; set; } //Map, Uri

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [DataMember(Name = "hasOfferCatalog", Order = 146)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<OfferCatalog>? HasOfferCatalog { get; set; } 

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        [DataMember(Name = "hasPOS", Order = 147)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? HasPOS { get; set; } 

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree", Order = 148)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<bool>? IsAccessibleForFree { get; set; } 

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4", Order = 149)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? IsicV4 { get; set; } 

        /// <summary>
        /// The official name of the organization, e.g. the registered company name.
        /// </summary>
        [DataMember(Name = "legalName", Order = 150)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? LegalName { get; set; } 

        /// <summary>
        /// An organization identifier that uniquely identifies a legal entity as defined in ISO 17442.
        /// </summary>
        [DataMember(Name = "leiCode", Order = 151)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? LeiCode { get; set; } 

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [DataMember(Name = "location", Order = 152)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<ILocation>? Location { get; set; } //Place, PostalAddress, string

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 153)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<ILogo>? Logo { get; set; } //ImageObject, Uri

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        [DataMember(Name = "makesOffer", Order = 154)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Offer>? MakesOffer { get; set; } 

        /// <summary>
        /// The total number of individuals that may attend an event or venue.
        /// </summary>
        [DataMember(Name = "maximumAttendeeCapacity", Order = 155)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<int>? MaximumAttendeeCapacity { get; set; } 

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [DataMember(Name = "member", Order = 156)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<IMember>? Member { get; set; } //Organization, Person

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        [DataMember(Name = "memberOf", Order = 157)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<IMemberOf>? MemberOf { get; set; } //Organization, ProgramMembership

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        [DataMember(Name = "naics", Order = 158)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? Naics { get; set; } 

        /// <summary>
        /// The number of employees in an organization e.g. business.
        /// </summary>
        [DataMember(Name = "numberOfEmployees", Order = 159)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<QuantitativeValue>? NumberOfEmployees { get; set; } 

        /// <summary>
        /// The opening hours of a certain place.
        /// </summary>
        [DataMember(Name = "openingHoursSpecification", Order = 160)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<OpeningHoursSpecification>? OpeningHoursSpecification { get; set; } 

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        [DataMember(Name = "owns", Order = 161)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<IOwns>? Owns { get; set; } //OwnershipInfo, Product

        /// <summary>
        /// The larger organization that this organization is a &lt;a class="localLink" href="http://schema.org/subOrganization"&gt;subOrganization&lt;/a&gt; of, if any.
        /// </summary>
        [DataMember(Name = "parentOrganization", Order = 162)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Organization>? ParentOrganization { get; set; } 

        /// <summary>
        /// A photograph of this place.
        /// </summary>
        [DataMember(Name = "photo", Order = 163)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<IPhoto>? Photo { get; set; } //ImageObject, Photograph

        /// <summary>
        /// A flag to signal that the &lt;a class="localLink" href="http://schema.org/Place"&gt;Place&lt;/a&gt; is open to public visitors.  If this property is omitted there is no assumed default boolean value
        /// </summary>
        [DataMember(Name = "publicAccess", Order = 164)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<bool>? PublicAccess { get; set; } 

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;/p&gt;
        /// &lt;p&gt;While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        [DataMember(Name = "publishingPrinciples", Order = 165)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<IPublishingPrinciples>? PublishingPrinciples { get; set; } //CreativeWork, Uri

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 166)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Review>? Review { get; set; } 

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        [DataMember(Name = "seeks", Order = 167)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Demand>? Seeks { get; set; } 

        /// <summary>
        /// Indicates whether it is allowed to smoke in the place, e.g. in the restaurant, hotel or hotel room.
        /// </summary>
        [DataMember(Name = "smokingAllowed", Order = 168)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<bool>? SmokingAllowed { get; set; } 

        /// <summary>
        /// The special opening hours of a certain place.&lt;/p&gt;
        /// &lt;p&gt;Use this to explicitly override general opening hours brought in scope by &lt;a class="localLink" href="http://schema.org/openingHoursSpecification"&gt;openingHoursSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/openingHours"&gt;openingHours&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "specialOpeningHoursSpecification", Order = 169)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<OpeningHoursSpecification>? SpecialOpeningHoursSpecification { get; set; } 

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 170)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<ISponsor>? Sponsor { get; set; } //Organization, Person

        /// <summary>
        /// A relationship between two organizations where the first includes the second, e.g., as a subsidiary. See also: the more specific 'department' property.
        /// </summary>
        [DataMember(Name = "subOrganization", Order = 171)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Organization>? SubOrganization { get; set; } 

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [DataMember(Name = "taxID", Order = 172)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? TaxID { get; set; } 

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 173)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? Telephone { get; set; } 

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (typically a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a statement about policy on use of unnamed sources and the decision process required.
        /// </summary>
        [DataMember(Name = "unnamedSourcesPolicy", Order = 174)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<IUnnamedSourcesPolicy>? UnnamedSourcesPolicy { get; set; } //CreativeWork, Uri

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        [DataMember(Name = "vatID", Order = 175)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? VatID { get; set; } 
    }
}
