namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
    [DataContract]
    public class Place : Thing
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Place";

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address")]
        public object Address { get; protected set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [IgnoreDataMember]
        public PostalAddress AddressPostalAddress
        {
            get => this.Address as PostalAddress;
            set => this.Address = value;
        }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [IgnoreDataMember]
        public string AddressText
        {
            get => this.Address as string;
            set => this.Address = value;
        }

        /// <summary>
        /// The opening hours of a certain place.
        /// </summary>
        [DataMember(Name = "openingHoursSpecification")]
        public OpeningHoursSpecification OpeningHoursSpecification { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber")]
        public string FaxNumber { get; set; }

        /// <summary>
        /// A photograph of this place.
        /// </summary>
        [DataMember(Name = "photo")]
        public object Photo { get; protected set; }

        /// <summary>
        /// A photograph of this place.
        /// </summary>
        [IgnoreDataMember]
        public ImageObject PhotoImageObject
        {
            get => this.Photo as ImageObject;
            set => this.Photo = value;
        }

        /// <summary>
        /// A photograph of this place.
        /// </summary>
        [IgnoreDataMember]
        public Photograph PhotoPhotograph
        {
            get => this.Photo as Photograph;
            set => this.Photo = value;
        }

        /// <summary>
        /// Indicates whether it is allowed to smoke in the place, e.g. in the restaurant, hotel or hotel room.
        /// </summary>
        [DataMember(Name = "smokingAllowed")]
        public bool SmokingAllowed { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber")]
        public string GlobalLocationNumber { get; set; }

        /// <summary>
        /// The total number of individuals that may attend an event or venue.
        /// </summary>
        [DataMember(Name = "maximumAttendeeCapacity")]
        public int MaximumAttendeeCapacity { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating")]
        public AggregateRating AggregateRating { get; set; }

        /// <summary>
        /// A short textual code (also called "store code") that uniquely identifies a place of business. The code is typically assigned by the parentOrganization and used in structured URLs.&lt;/p&gt;
        /// &lt;p&gt;For example, in the URL http://www.starbucks.co.uk/store-locator/etc/detail/3047 the code "3047" is a branchCode for a particular branch.
        /// </summary>
        [DataMember(Name = "branchCode")]
        public string BranchCode { get; set; }

        /// <summary>
        /// A URL to a map of the place.
        /// </summary>
        [DataMember(Name = "hasMap")]
        public object HasMap { get; protected set; }

        /// <summary>
        /// A URL to a map of the place.
        /// </summary>
        [IgnoreDataMember]
        public Uri HasMapURL
        {
            get => this.HasMap as Uri;
            set => this.HasMap = value;
        }

        /// <summary>
        /// A URL to a map of the place.
        /// </summary>
        [IgnoreDataMember]
        public Map HasMapMap
        {
            get => this.HasMap as Map;
            set => this.HasMap = value;
        }

        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;/p&gt;
        /// &lt;p&gt;Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        [DataMember(Name = "additionalProperty")]
        public PropertyValue AdditionalProperty { get; set; }

        /// <summary>
        /// The special opening hours of a certain place.&lt;/p&gt;
        /// &lt;p&gt;Use this to explicitly override general opening hours brought in scope by &lt;a class="localLink" href="http://schema.org/openingHoursSpecification"&gt;openingHoursSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/openingHours"&gt;openingHours&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "specialOpeningHoursSpecification")]
        public OpeningHoursSpecification SpecialOpeningHoursSpecification { get; set; }

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [DataMember(Name = "amenityFeature")]
        public virtual LocationFeatureSpecification AmenityFeature { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo")]
        public object Logo { get; protected set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [IgnoreDataMember]
        public Uri LogoURL
        {
            get => this.Logo as Uri;
            set => this.Logo = value;
        }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [IgnoreDataMember]
        public ImageObject LogoImageObject
        {
            get => this.Logo as ImageObject;
            set => this.Logo = value;
        }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone")]
        public string Telephone { get; set; }

        /// <summary>
        /// The geo coordinates of the place.
        /// </summary>
        [DataMember(Name = "geo")]
        public object Geo { get; protected set; }

        /// <summary>
        /// The geo coordinates of the place.
        /// </summary>
        [IgnoreDataMember]
        public GeoCoordinates GeoGeoCoordinates
        {
            get => this.Geo as GeoCoordinates;
            set => this.Geo = value;
        }

        /// <summary>
        /// The geo coordinates of the place.
        /// </summary>
        [IgnoreDataMember]
        public GeoShape GeoGeoShape
        {
            get => this.Geo as GeoShape;
            set => this.Geo = value;
        }

        /// <summary>
        /// The basic containment relation between a place and one that contains it.
        /// </summary>
        [DataMember(Name = "containedInPlace")]
        public Place ContainedInPlace { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review")]
        public Review Review { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event")]
        public Event Event { get; set; }

        /// <summary>
        /// The basic containment relation between a place and another that it contains.
        /// </summary>
        [DataMember(Name = "containsPlace")]
        public Place ContainsPlace { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4")]
        public string IsicV4 { get; set; }
    }
}
