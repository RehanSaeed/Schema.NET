using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
    [DataContract]
    public partial class Place : Thing
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


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Place";

        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;/p&gt;
        /// &lt;p&gt;Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        [DataMember(Name = "additionalProperty", Order = 106)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PropertyValue>? AdditionalProperty { get; set; } 

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 107)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAddress>? Address { get; set; } //PostalAddress, string

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 108)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AggregateRating>? AggregateRating { get; set; } 

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [DataMember(Name = "amenityFeature", Order = 109)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<LocationFeatureSpecification>? AmenityFeature { get; set; } 

        /// <summary>
        /// A short textual code (also called "store code") that uniquely identifies a place of business. The code is typically assigned by the parentOrganization and used in structured URLs.&lt;/p&gt;
        /// &lt;p&gt;For example, in the URL http://www.starbucks.co.uk/store-locator/etc/detail/3047 the code "3047" is a branchCode for a particular branch.
        /// </summary>
        [DataMember(Name = "branchCode", Order = 110)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? BranchCode { get; set; } 

        /// <summary>
        /// The basic containment relation between a place and one that contains it.
        /// </summary>
        [DataMember(Name = "containedInPlace", Order = 111)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? ContainedInPlace { get; set; } 

        /// <summary>
        /// The basic containment relation between a place and another that it contains.
        /// </summary>
        [DataMember(Name = "containsPlace", Order = 112)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? ContainsPlace { get; set; } 

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 113)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Event>? Event { get; set; } 

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 114)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? FaxNumber { get; set; } 

        /// <summary>
        /// The geo coordinates of the place.
        /// </summary>
        [DataMember(Name = "geo", Order = 115)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IGeo>? Geo { get; set; } //GeoCoordinates, GeoShape

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a containing geometry to a contained geometry. "a contains b iff no points of b lie in the exterior of a, and at least one point of the interior of b lies in the interior of a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyContains", Order = 116)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? GeospatiallyContains { get; set; } 

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that covers it. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyCoveredBy", Order = 117)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? GeospatiallyCoveredBy { get; set; } 

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a covering geometry to a covered geometry. "Every point of b is a point of (the interior or boundary of) a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyCovers", Order = 118)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? GeospatiallyCovers { get; set; } 

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that crosses it: "a crosses b: they have some but not all interior points in common, and the dimension of the intersection is less than that of at least one of them". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyCrosses", Order = 119)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? GeospatiallyCrosses { get; set; } 

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically disjoint: they have no point in common. They form a set of disconnected geometries." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;)
        /// </summary>
        [DataMember(Name = "geospatiallyDisjoint", Order = 120)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? GeospatiallyDisjoint { get; set; } 

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically equal, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;. "Two geometries are topologically equal if their interiors intersect and no part of the interior or boundary of one geometry intersects the exterior of the other" (a symmetric relationship)
        /// </summary>
        [DataMember(Name = "geospatiallyEquals", Order = 121)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? GeospatiallyEquals { get; set; } 

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) have at least one point in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyIntersects", Order = 122)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? GeospatiallyIntersects { get; set; } 

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that geospatially overlaps it, i.e. they have some but not all points in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyOverlaps", Order = 123)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? GeospatiallyOverlaps { get; set; } 

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) touch: they have at least one boundary point in common, but no interior points." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt; )
        /// </summary>
        [DataMember(Name = "geospatiallyTouches", Order = 124)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? GeospatiallyTouches { get; set; } 

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to one that contains it, i.e. it is inside (i.e. within) its interior. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyWithin", Order = 125)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? GeospatiallyWithin { get; set; } 

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber", Order = 126)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? GlobalLocationNumber { get; set; } 

        /// <summary>
        /// A URL to a map of the place.
        /// </summary>
        [DataMember(Name = "hasMap", Order = 127)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IHasMap>? HasMap { get; set; } //Map, Uri

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree", Order = 128)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<bool>? IsAccessibleForFree { get; set; } 

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4", Order = 129)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? IsicV4 { get; set; } 

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 130)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ILogo>? Logo { get; set; } //ImageObject, Uri

        /// <summary>
        /// The total number of individuals that may attend an event or venue.
        /// </summary>
        [DataMember(Name = "maximumAttendeeCapacity", Order = 131)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int>? MaximumAttendeeCapacity { get; set; } 

        /// <summary>
        /// The opening hours of a certain place.
        /// </summary>
        [DataMember(Name = "openingHoursSpecification", Order = 132)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<OpeningHoursSpecification>? OpeningHoursSpecification { get; set; } 

        /// <summary>
        /// A photograph of this place.
        /// </summary>
        [DataMember(Name = "photo", Order = 133)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPhoto>? Photo { get; set; } //ImageObject, Photograph

        /// <summary>
        /// A flag to signal that the &lt;a class="localLink" href="http://schema.org/Place"&gt;Place&lt;/a&gt; is open to public visitors.  If this property is omitted there is no assumed default boolean value
        /// </summary>
        [DataMember(Name = "publicAccess", Order = 134)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<bool>? PublicAccess { get; set; } 

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 135)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Review>? Review { get; set; } 

        /// <summary>
        /// Indicates whether it is allowed to smoke in the place, e.g. in the restaurant, hotel or hotel room.
        /// </summary>
        [DataMember(Name = "smokingAllowed", Order = 136)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<bool>? SmokingAllowed { get; set; } 

        /// <summary>
        /// The special opening hours of a certain place.&lt;/p&gt;
        /// &lt;p&gt;Use this to explicitly override general opening hours brought in scope by &lt;a class="localLink" href="http://schema.org/openingHoursSpecification"&gt;openingHoursSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/openingHours"&gt;openingHours&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "specialOpeningHoursSpecification", Order = 137)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<OpeningHoursSpecification>? SpecialOpeningHoursSpecification { get; set; } 

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 138)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Telephone { get; set; } 
    }
}
