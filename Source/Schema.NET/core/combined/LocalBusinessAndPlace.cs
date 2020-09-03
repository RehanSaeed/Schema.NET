namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// See LocalBusiness, Place for more information.
    /// </summary>
    public partial interface ILocalBusinessAndPlace : IPlace, ILocalBusiness
    {
    }

    /// <summary>
    /// See LocalBusiness, Place for more information.
    /// </summary>
    [DataContract]
    public abstract partial class LocalBusinessAndPlace : OrganizationAndPlace, ILocalBusinessAndPlace, IEquatable<LocalBusinessAndPlace>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LocalBusinessAndPlace";

        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;br/&gt;&lt;br/&gt;
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. https://schema.org/width, https://schema.org/color, https://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        [DataMember(Name = "additionalProperty", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPropertyValue> AdditionalProperty { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<IPostalAddress, string> Address { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IAggregateRating> AggregateRating { get; set; }

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [DataMember(Name = "amenityFeature", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<ILocationFeatureSpecification> AmenityFeature { get; set; }

        /// <summary>
        /// A short textual code (also called "store code") that uniquely identifies a place of business. The code is typically assigned by the parentOrganization and used in structured URLs.&lt;br/&gt;&lt;br/&gt;
        /// For example, in the URL http://www.starbucks.co.uk/store-locator/etc/detail/3047 the code "3047" is a branchCode for a particular branch.
        /// </summary>
        [DataMember(Name = "branchCode", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> BranchCode { get; set; }

        /// <summary>
        /// The basic containment relation between a place and one that contains it.
        /// </summary>
        [DataMember(Name = "containedInPlace", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPlace> ContainedInPlace { get; set; }

        /// <summary>
        /// The basic containment relation between a place and another that it contains.
        /// </summary>
        [DataMember(Name = "containsPlace", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPlace> ContainsPlace { get; set; }

        /// <summary>
        /// The currency accepted.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        [DataMember(Name = "currenciesAccepted", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CurrenciesAccepted { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 214)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IEvent> Events { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 215)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> FaxNumber { get; set; }

        /// <summary>
        /// The geo coordinates of the place.
        /// </summary>
        [DataMember(Name = "geo", Order = 216)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<IGeoCoordinates, IGeoShape> Geo { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a containing geometry to a contained geometry. "a contains b iff no points of b lie in the exterior of a, and at least one point of the interior of b lies in the interior of a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geoContains", Order = 217)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPlace> GeoContains { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that covers it. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geoCoveredBy", Order = 218)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPlace> GeoCoveredBy { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a covering geometry to a covered geometry. "Every point of b is a point of (the interior or boundary of) a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geoCovers", Order = 219)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPlace> GeoCovers { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that crosses it: "a crosses b: they have some but not all interior points in common, and the dimension of the intersection is less than that of at least one of them". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geoCrosses", Order = 220)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPlace> GeoCrosses { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically disjoint: they have no point in common. They form a set of disconnected geometries." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;)
        /// </summary>
        [DataMember(Name = "geoDisjoint", Order = 221)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPlace> GeoDisjoint { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically equal, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;. "Two geometries are topologically equal if their interiors intersect and no part of the interior or boundary of one geometry intersects the exterior of the other" (a symmetric relationship)
        /// </summary>
        [DataMember(Name = "geoEquals", Order = 222)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPlace> GeoEquals { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) have at least one point in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geoIntersects", Order = 223)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPlace> GeoIntersects { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that geospatially overlaps it, i.e. they have some but not all points in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geoOverlaps", Order = 224)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPlace> GeoOverlaps { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) touch: they have at least one boundary point in common, but no interior points." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt; )
        /// </summary>
        [DataMember(Name = "geoTouches", Order = 225)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPlace> GeoTouches { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to one that contains it, i.e. it is inside (i.e. within) its interior. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geoWithin", Order = 226)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPlace> GeoWithin { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber", Order = 227)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> GlobalLocationNumber { get; set; }

        /// <summary>
        /// Indicates whether some facility (e.g. &lt;a class="localLink" href="https://schema.org/FoodEstablishment"&gt;FoodEstablishment&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/CovidTestingFacility"&gt;CovidTestingFacility&lt;/a&gt;) offers a service that can be used by driving through in a car. In the case of &lt;a class="localLink" href="https://schema.org/CovidTestingFacility"&gt;CovidTestingFacility&lt;/a&gt; such facilities could potentially help with social distancing from other potentially-infected users.
        /// </summary>
        [DataMember(Name = "hasDriveThroughService", Order = 228)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<bool?> HasDriveThroughService { get; set; }

        /// <summary>
        /// A URL to a map of the place.
        /// </summary>
        [DataMember(Name = "hasMap", Order = 229)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<IMap, Uri> HasMap { get; set; }

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree", Order = 230)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<bool?> IsAccessibleForFree { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4", Order = 231)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> IsicV4 { get; set; }

        /// <summary>
        /// The latitude of a location. For example &lt;code&gt;37.42242&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "latitude", Order = 232)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<double?, string> Latitude { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 233)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<IImageObject, Uri> Logo { get; set; }

        /// <summary>
        /// The longitude of a location. For example &lt;code&gt;-122.08585&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "longitude", Order = 234)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<double?, string> Longitude { get; set; }

        /// <summary>
        /// The total number of individuals that may attend an event or venue.
        /// </summary>
        [DataMember(Name = "maximumAttendeeCapacity", Order = 235)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<int?> MaximumAttendeeCapacity { get; set; }

        /// <summary>
        /// The general opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Days are specified using the following two-letter combinations: &lt;code&gt;Mo&lt;/code&gt;, &lt;code&gt;Tu&lt;/code&gt;, &lt;code&gt;We&lt;/code&gt;, &lt;code&gt;Th&lt;/code&gt;, &lt;code&gt;Fr&lt;/code&gt;, &lt;code&gt;Sa&lt;/code&gt;, &lt;code&gt;Su&lt;/code&gt;.&lt;/li&gt;
        /// &lt;li&gt;Times are specified using 24:00 time. For example, 3pm is specified as &lt;code&gt;15:00&lt;/code&gt;. &lt;/li&gt;
        /// &lt;li&gt;Here is an example: &lt;code&gt;&amp;lt;time itemprop="openingHours" datetime=&amp;quot;Tu,Th 16:00-20:00&amp;quot;&amp;gt;Tuesdays and Thursdays 4-8pm&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
        /// &lt;li&gt;If a business is open 7 days a week, then it can be specified as &lt;code&gt;&amp;lt;time itemprop=&amp;quot;openingHours&amp;quot; datetime=&amp;quot;Mo-Su&amp;quot;&amp;gt;Monday through Sunday, all day&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "openingHours", Order = 236)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> OpeningHours { get; set; }

        /// <summary>
        /// The opening hours of a certain place.
        /// </summary>
        [DataMember(Name = "openingHoursSpecification", Order = 237)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IOpeningHoursSpecification> OpeningHoursSpecification { get; set; }

        /// <summary>
        /// Cash, Credit Card, Cryptocurrency, Local Exchange Tradings System, etc.
        /// </summary>
        [DataMember(Name = "paymentAccepted", Order = 238)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PaymentAccepted { get; set; }

        /// <summary>
        /// A photograph of this place.
        /// </summary>
        [DataMember(Name = "photo", Order = 239)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<IImageObject, IPhotograph> Photo { get; set; }

        /// <summary>
        /// The price range of the business, for example &lt;code&gt;$$$&lt;/code&gt;.
        /// </summary>
        [DataMember(Name = "priceRange", Order = 240)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PriceRange { get; set; }

        /// <summary>
        /// A flag to signal that the &lt;a class="localLink" href="https://schema.org/Place"&gt;Place&lt;/a&gt; is open to public visitors.  If this property is omitted there is no assumed default boolean value
        /// </summary>
        [DataMember(Name = "publicAccess", Order = 241)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<bool?> PublicAccess { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 242)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IReview> Review { get; set; }

        /// <summary>
        /// A slogan or motto associated with the item.
        /// </summary>
        [DataMember(Name = "slogan", Order = 243)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> Slogan { get; set; }

        /// <summary>
        /// Indicates whether it is allowed to smoke in the place, e.g. in the restaurant, hotel or hotel room.
        /// </summary>
        [DataMember(Name = "smokingAllowed", Order = 244)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<bool?> SmokingAllowed { get; set; }

        /// <summary>
        /// The special opening hours of a certain place.&lt;br/&gt;&lt;br/&gt;
        /// Use this to explicitly override general opening hours brought in scope by &lt;a class="localLink" href="https://schema.org/openingHoursSpecification"&gt;openingHoursSpecification&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/openingHours"&gt;openingHours&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "specialOpeningHoursSpecification", Order = 245)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IOpeningHoursSpecification> SpecialOpeningHoursSpecification { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 246)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> Telephone { get; set; }

        /// <summary>
        /// A page providing information on how to book a tour of some &lt;a class="localLink" href="https://schema.org/Place"&gt;Place&lt;/a&gt;, such as an &lt;a class="localLink" href="https://schema.org/Accommodation"&gt;Accommodation&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/ApartmentComplex"&gt;ApartmentComplex&lt;/a&gt; in a real estate setting, as well as other kinds of tours as appropriate.
        /// </summary>
        [DataMember(Name = "tourBookingPage", Order = 247)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<Uri> TourBookingPage { get; set; }

        /// <inheritdoc/>
        public bool Equals(LocalBusinessAndPlace other)
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
                this.CurrenciesAccepted == other.CurrenciesAccepted &&
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
                this.OpeningHours == other.OpeningHours &&
                this.OpeningHoursSpecification == other.OpeningHoursSpecification &&
                this.PaymentAccepted == other.PaymentAccepted &&
                this.Photo == other.Photo &&
                this.PriceRange == other.PriceRange &&
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
        public override bool Equals(object obj) => this.Equals(obj as LocalBusinessAndPlace);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AdditionalProperty)
            .And(this.Address)
            .And(this.AggregateRating)
            .And(this.AmenityFeature)
            .And(this.BranchCode)
            .And(this.ContainedInPlace)
            .And(this.ContainsPlace)
            .And(this.CurrenciesAccepted)
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
            .And(this.OpeningHours)
            .And(this.OpeningHoursSpecification)
            .And(this.PaymentAccepted)
            .And(this.Photo)
            .And(this.PriceRange)
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
