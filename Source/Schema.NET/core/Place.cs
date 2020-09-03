namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
    public partial interface IPlace : IThing
    {
        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;br/&gt;&lt;br/&gt;
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. https://schema.org/width, https://schema.org/color, https://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        OneOrMany<IPropertyValue> AdditionalProperty { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        Values<IPostalAddress, string> Address { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        OneOrMany<IAggregateRating> AggregateRating { get; set; }

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        OneOrMany<ILocationFeatureSpecification> AmenityFeature { get; set; }

        /// <summary>
        /// A short textual code (also called "store code") that uniquely identifies a place of business. The code is typically assigned by the parentOrganization and used in structured URLs.&lt;br/&gt;&lt;br/&gt;
        /// For example, in the URL http://www.starbucks.co.uk/store-locator/etc/detail/3047 the code "3047" is a branchCode for a particular branch.
        /// </summary>
        OneOrMany<string> BranchCode { get; set; }

        /// <summary>
        /// The basic containment relation between a place and one that contains it.
        /// </summary>
        OneOrMany<IPlace> ContainedInPlace { get; set; }

        /// <summary>
        /// The basic containment relation between a place and another that it contains.
        /// </summary>
        OneOrMany<IPlace> ContainsPlace { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        OneOrMany<IEvent> Events { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        OneOrMany<string> FaxNumber { get; set; }

        /// <summary>
        /// The geo coordinates of the place.
        /// </summary>
        Values<IGeoCoordinates, IGeoShape> Geo { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a containing geometry to a contained geometry. "a contains b iff no points of b lie in the exterior of a, and at least one point of the interior of b lies in the interior of a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        OneOrMany<IPlace> GeoContains { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that covers it. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        OneOrMany<IPlace> GeoCoveredBy { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a covering geometry to a covered geometry. "Every point of b is a point of (the interior or boundary of) a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        OneOrMany<IPlace> GeoCovers { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that crosses it: "a crosses b: they have some but not all interior points in common, and the dimension of the intersection is less than that of at least one of them". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        OneOrMany<IPlace> GeoCrosses { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically disjoint: they have no point in common. They form a set of disconnected geometries." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;)
        /// </summary>
        OneOrMany<IPlace> GeoDisjoint { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically equal, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;. "Two geometries are topologically equal if their interiors intersect and no part of the interior or boundary of one geometry intersects the exterior of the other" (a symmetric relationship)
        /// </summary>
        OneOrMany<IPlace> GeoEquals { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) have at least one point in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        OneOrMany<IPlace> GeoIntersects { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that geospatially overlaps it, i.e. they have some but not all points in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        OneOrMany<IPlace> GeoOverlaps { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) touch: they have at least one boundary point in common, but no interior points." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt; )
        /// </summary>
        OneOrMany<IPlace> GeoTouches { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to one that contains it, i.e. it is inside (i.e. within) its interior. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        OneOrMany<IPlace> GeoWithin { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        OneOrMany<string> GlobalLocationNumber { get; set; }

        /// <summary>
        /// Indicates whether some facility (e.g. &lt;a class="localLink" href="https://schema.org/FoodEstablishment"&gt;FoodEstablishment&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/CovidTestingFacility"&gt;CovidTestingFacility&lt;/a&gt;) offers a service that can be used by driving through in a car. In the case of &lt;a class="localLink" href="https://schema.org/CovidTestingFacility"&gt;CovidTestingFacility&lt;/a&gt; such facilities could potentially help with social distancing from other potentially-infected users.
        /// </summary>
        OneOrMany<bool?> HasDriveThroughService { get; set; }

        /// <summary>
        /// A URL to a map of the place.
        /// </summary>
        Values<IMap, Uri> HasMap { get; set; }

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        OneOrMany<bool?> IsAccessibleForFree { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        OneOrMany<string> IsicV4 { get; set; }

        /// <summary>
        /// The latitude of a location. For example &lt;code&gt;37.42242&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        Values<double?, string> Latitude { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        Values<IImageObject, Uri> Logo { get; set; }

        /// <summary>
        /// The longitude of a location. For example &lt;code&gt;-122.08585&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        Values<double?, string> Longitude { get; set; }

        /// <summary>
        /// The total number of individuals that may attend an event or venue.
        /// </summary>
        OneOrMany<int?> MaximumAttendeeCapacity { get; set; }

        /// <summary>
        /// The opening hours of a certain place.
        /// </summary>
        OneOrMany<IOpeningHoursSpecification> OpeningHoursSpecification { get; set; }

        /// <summary>
        /// A photograph of this place.
        /// </summary>
        Values<IImageObject, IPhotograph> Photo { get; set; }

        /// <summary>
        /// A flag to signal that the &lt;a class="localLink" href="https://schema.org/Place"&gt;Place&lt;/a&gt; is open to public visitors.  If this property is omitted there is no assumed default boolean value
        /// </summary>
        OneOrMany<bool?> PublicAccess { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        OneOrMany<IReview> Review { get; set; }

        /// <summary>
        /// A slogan or motto associated with the item.
        /// </summary>
        OneOrMany<string> Slogan { get; set; }

        /// <summary>
        /// Indicates whether it is allowed to smoke in the place, e.g. in the restaurant, hotel or hotel room.
        /// </summary>
        OneOrMany<bool?> SmokingAllowed { get; set; }

        /// <summary>
        /// The special opening hours of a certain place.&lt;br/&gt;&lt;br/&gt;
        /// Use this to explicitly override general opening hours brought in scope by &lt;a class="localLink" href="https://schema.org/openingHoursSpecification"&gt;openingHoursSpecification&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/openingHours"&gt;openingHours&lt;/a&gt;.
        /// </summary>
        OneOrMany<IOpeningHoursSpecification> SpecialOpeningHoursSpecification { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        OneOrMany<string> Telephone { get; set; }

        /// <summary>
        /// A page providing information on how to book a tour of some &lt;a class="localLink" href="https://schema.org/Place"&gt;Place&lt;/a&gt;, such as an &lt;a class="localLink" href="https://schema.org/Accommodation"&gt;Accommodation&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt; in a real estate setting, as well as other kinds of tours as appropriate.
        /// </summary>
        OneOrMany<Uri> TourBookingPage { get; set; }
    }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
    [DataContract]
    public partial class Place : Thing, IPlace, IEquatable<Place>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Place";

        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;br/&gt;&lt;br/&gt;
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. https://schema.org/width, https://schema.org/color, https://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        [DataMember(Name = "additionalProperty", Order = 106)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPropertyValue> AdditionalProperty { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 107)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<IPostalAddress, string> Address { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 108)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IAggregateRating> AggregateRating { get; set; }

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [DataMember(Name = "amenityFeature", Order = 109)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<ILocationFeatureSpecification> AmenityFeature { get; set; }

        /// <summary>
        /// A short textual code (also called "store code") that uniquely identifies a place of business. The code is typically assigned by the parentOrganization and used in structured URLs.&lt;br/&gt;&lt;br/&gt;
        /// For example, in the URL http://www.starbucks.co.uk/store-locator/etc/detail/3047 the code "3047" is a branchCode for a particular branch.
        /// </summary>
        [DataMember(Name = "branchCode", Order = 110)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BranchCode { get; set; }

        /// <summary>
        /// The basic containment relation between a place and one that contains it.
        /// </summary>
        [DataMember(Name = "containedInPlace", Order = 111)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> ContainedInPlace { get; set; }

        /// <summary>
        /// The basic containment relation between a place and another that it contains.
        /// </summary>
        [DataMember(Name = "containsPlace", Order = 112)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> ContainsPlace { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 113)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IEvent> Events { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 114)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> FaxNumber { get; set; }

        /// <summary>
        /// The geo coordinates of the place.
        /// </summary>
        [DataMember(Name = "geo", Order = 115)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IGeoCoordinates, IGeoShape> Geo { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a containing geometry to a contained geometry. "a contains b iff no points of b lie in the exterior of a, and at least one point of the interior of b lies in the interior of a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geoContains", Order = 116)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> GeoContains { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that covers it. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geoCoveredBy", Order = 117)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> GeoCoveredBy { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a covering geometry to a covered geometry. "Every point of b is a point of (the interior or boundary of) a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geoCovers", Order = 118)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> GeoCovers { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that crosses it: "a crosses b: they have some but not all interior points in common, and the dimension of the intersection is less than that of at least one of them". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geoCrosses", Order = 119)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> GeoCrosses { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically disjoint: they have no point in common. They form a set of disconnected geometries." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;)
        /// </summary>
        [DataMember(Name = "geoDisjoint", Order = 120)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> GeoDisjoint { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically equal, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;. "Two geometries are topologically equal if their interiors intersect and no part of the interior or boundary of one geometry intersects the exterior of the other" (a symmetric relationship)
        /// </summary>
        [DataMember(Name = "geoEquals", Order = 121)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> GeoEquals { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) have at least one point in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geoIntersects", Order = 122)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> GeoIntersects { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that geospatially overlaps it, i.e. they have some but not all points in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geoOverlaps", Order = 123)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> GeoOverlaps { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) touch: they have at least one boundary point in common, but no interior points." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt; )
        /// </summary>
        [DataMember(Name = "geoTouches", Order = 124)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> GeoTouches { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to one that contains it, i.e. it is inside (i.e. within) its interior. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geoWithin", Order = 125)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> GeoWithin { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber", Order = 126)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> GlobalLocationNumber { get; set; }

        /// <summary>
        /// Indicates whether some facility (e.g. &lt;a class="localLink" href="https://schema.org/FoodEstablishment"&gt;FoodEstablishment&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/CovidTestingFacility"&gt;CovidTestingFacility&lt;/a&gt;) offers a service that can be used by driving through in a car. In the case of &lt;a class="localLink" href="https://schema.org/CovidTestingFacility"&gt;CovidTestingFacility&lt;/a&gt; such facilities could potentially help with social distancing from other potentially-infected users.
        /// </summary>
        [DataMember(Name = "hasDriveThroughService", Order = 127)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> HasDriveThroughService { get; set; }

        /// <summary>
        /// A URL to a map of the place.
        /// </summary>
        [DataMember(Name = "hasMap", Order = 128)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMap, Uri> HasMap { get; set; }

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree", Order = 129)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> IsAccessibleForFree { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4", Order = 130)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> IsicV4 { get; set; }

        /// <summary>
        /// The latitude of a location. For example &lt;code&gt;37.42242&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "latitude", Order = 131)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, string> Latitude { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 132)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual Values<IImageObject, Uri> Logo { get; set; }

        /// <summary>
        /// The longitude of a location. For example &lt;code&gt;-122.08585&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "longitude", Order = 133)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, string> Longitude { get; set; }

        /// <summary>
        /// The total number of individuals that may attend an event or venue.
        /// </summary>
        [DataMember(Name = "maximumAttendeeCapacity", Order = 134)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> MaximumAttendeeCapacity { get; set; }

        /// <summary>
        /// The opening hours of a certain place.
        /// </summary>
        [DataMember(Name = "openingHoursSpecification", Order = 135)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOpeningHoursSpecification> OpeningHoursSpecification { get; set; }

        /// <summary>
        /// A photograph of this place.
        /// </summary>
        [DataMember(Name = "photo", Order = 136)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IImageObject, IPhotograph> Photo { get; set; }

        /// <summary>
        /// A flag to signal that the &lt;a class="localLink" href="https://schema.org/Place"&gt;Place&lt;/a&gt; is open to public visitors.  If this property is omitted there is no assumed default boolean value
        /// </summary>
        [DataMember(Name = "publicAccess", Order = 137)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> PublicAccess { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 138)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IReview> Review { get; set; }

        /// <summary>
        /// A slogan or motto associated with the item.
        /// </summary>
        [DataMember(Name = "slogan", Order = 139)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> Slogan { get; set; }

        /// <summary>
        /// Indicates whether it is allowed to smoke in the place, e.g. in the restaurant, hotel or hotel room.
        /// </summary>
        [DataMember(Name = "smokingAllowed", Order = 140)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> SmokingAllowed { get; set; }

        /// <summary>
        /// The special opening hours of a certain place.&lt;br/&gt;&lt;br/&gt;
        /// Use this to explicitly override general opening hours brought in scope by &lt;a class="localLink" href="https://schema.org/openingHoursSpecification"&gt;openingHoursSpecification&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/openingHours"&gt;openingHours&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "specialOpeningHoursSpecification", Order = 141)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOpeningHoursSpecification> SpecialOpeningHoursSpecification { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 142)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> Telephone { get; set; }

        /// <summary>
        /// A page providing information on how to book a tour of some &lt;a class="localLink" href="https://schema.org/Place"&gt;Place&lt;/a&gt;, such as an &lt;a class="localLink" href="https://schema.org/Accommodation"&gt;Accommodation&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt; in a real estate setting, as well as other kinds of tours as appropriate.
        /// </summary>
        [DataMember(Name = "tourBookingPage", Order = 143)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<Uri> TourBookingPage { get; set; }

        /// <inheritdoc/>
        public bool Equals(Place other)
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
                this.AdditionalProperty == other.AdditionalProperty &&
                this.Address == other.Address &&
                this.AggregateRating == other.AggregateRating &&
                this.AmenityFeature == other.AmenityFeature &&
                this.BranchCode == other.BranchCode &&
                this.ContainedInPlace == other.ContainedInPlace &&
                this.ContainsPlace == other.ContainsPlace &&
                this.Events == other.Events &&
                this.FaxNumber == other.FaxNumber &&
                this.Geo == other.Geo &&
                this.GeoContains == other.GeoContains &&
                this.GeoCoveredBy == other.GeoCoveredBy &&
                this.GeoCovers == other.GeoCovers &&
                this.GeoCrosses == other.GeoCrosses &&
                this.GeoDisjoint == other.GeoDisjoint &&
                this.GeoEquals == other.GeoEquals &&
                this.GeoIntersects == other.GeoIntersects &&
                this.GeoOverlaps == other.GeoOverlaps &&
                this.GeoTouches == other.GeoTouches &&
                this.GeoWithin == other.GeoWithin &&
                this.GlobalLocationNumber == other.GlobalLocationNumber &&
                this.HasDriveThroughService == other.HasDriveThroughService &&
                this.HasMap == other.HasMap &&
                this.IsAccessibleForFree == other.IsAccessibleForFree &&
                this.IsicV4 == other.IsicV4 &&
                this.Latitude == other.Latitude &&
                this.Logo == other.Logo &&
                this.Longitude == other.Longitude &&
                this.MaximumAttendeeCapacity == other.MaximumAttendeeCapacity &&
                this.OpeningHoursSpecification == other.OpeningHoursSpecification &&
                this.Photo == other.Photo &&
                this.PublicAccess == other.PublicAccess &&
                this.Review == other.Review &&
                this.Slogan == other.Slogan &&
                this.SmokingAllowed == other.SmokingAllowed &&
                this.SpecialOpeningHoursSpecification == other.SpecialOpeningHoursSpecification &&
                this.Telephone == other.Telephone &&
                this.TourBookingPage == other.TourBookingPage &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Place);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AdditionalProperty)
            .And(this.Address)
            .And(this.AggregateRating)
            .And(this.AmenityFeature)
            .And(this.BranchCode)
            .And(this.ContainedInPlace)
            .And(this.ContainsPlace)
            .And(this.Events)
            .And(this.FaxNumber)
            .And(this.Geo)
            .And(this.GeoContains)
            .And(this.GeoCoveredBy)
            .And(this.GeoCovers)
            .And(this.GeoCrosses)
            .And(this.GeoDisjoint)
            .And(this.GeoEquals)
            .And(this.GeoIntersects)
            .And(this.GeoOverlaps)
            .And(this.GeoTouches)
            .And(this.GeoWithin)
            .And(this.GlobalLocationNumber)
            .And(this.HasDriveThroughService)
            .And(this.HasMap)
            .And(this.IsAccessibleForFree)
            .And(this.IsicV4)
            .And(this.Latitude)
            .And(this.Logo)
            .And(this.Longitude)
            .And(this.MaximumAttendeeCapacity)
            .And(this.OpeningHoursSpecification)
            .And(this.Photo)
            .And(this.PublicAccess)
            .And(this.Review)
            .And(this.Slogan)
            .And(this.SmokingAllowed)
            .And(this.SpecialOpeningHoursSpecification)
            .And(this.Telephone)
            .And(this.TourBookingPage)
            .And(base.GetHashCode());
    }
}
