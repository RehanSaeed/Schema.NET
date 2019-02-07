namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// See CivicStructure, LodgingBusiness for more information.
    /// </summary>
    [DataContract]
    public abstract partial class CivicStructureAndLodgingBusiness : LocalBusinessAndPlace
    {

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

        public interface IAvailableLanguage : IValue {}
        public interface IAvailableLanguage<T> : IAvailableLanguage { new T Value { get; } }
        public class OneOrManyAvailableLanguage : OneOrMany<IAvailableLanguage>
        {
            public OneOrManyAvailableLanguage(IAvailableLanguage item) : base(item) { }
            public OneOrManyAvailableLanguage(IEnumerable<IAvailableLanguage> items) : base(items) { }
            public static implicit operator OneOrManyAvailableLanguage (Language value) { return new OneOrManyAvailableLanguage (new AvailableLanguageLanguage (value)); }
            public static implicit operator OneOrManyAvailableLanguage (Language[] values) { return new OneOrManyAvailableLanguage (values.Select(v => (IAvailableLanguage) new AvailableLanguageLanguage (v))); }
            public static implicit operator OneOrManyAvailableLanguage (List<Language> values) { return new OneOrManyAvailableLanguage (values.Select(v => (IAvailableLanguage) new AvailableLanguageLanguage (v))); }
            public static implicit operator OneOrManyAvailableLanguage (string value) { return new OneOrManyAvailableLanguage (new AvailableLanguagestring (value)); }
            public static implicit operator OneOrManyAvailableLanguage (string[] values) { return new OneOrManyAvailableLanguage (values.Select(v => (IAvailableLanguage) new AvailableLanguagestring (v))); }
            public static implicit operator OneOrManyAvailableLanguage (List<string> values) { return new OneOrManyAvailableLanguage (values.Select(v => (IAvailableLanguage) new AvailableLanguagestring (v))); }
        }
        public struct AvailableLanguageLanguage : IAvailableLanguage<Language>
        {
            object IValue.Value => this.Value;
            public Language Value { get; }
            public AvailableLanguageLanguage (Language value) { Value = value; }
            public static implicit operator AvailableLanguageLanguage (Language value) { return new AvailableLanguageLanguage (value); }
        }
        public struct AvailableLanguagestring : IAvailableLanguage<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AvailableLanguagestring (string value) { Value = value; }
            public static implicit operator AvailableLanguagestring (string value) { return new AvailableLanguagestring (value); }
        }

        public interface ICheckinTime : IValue {}
        public interface ICheckinTime<T> : ICheckinTime { new T Value { get; } }
        public class OneOrManyCheckinTime : OneOrMany<ICheckinTime>
        {
            public OneOrManyCheckinTime(ICheckinTime item) : base(item) { }
            public OneOrManyCheckinTime(IEnumerable<ICheckinTime> items) : base(items) { }
            public static implicit operator OneOrManyCheckinTime (DateTimeOffset value) { return new OneOrManyCheckinTime (new CheckinTimeDateTimeOffset (value)); }
            public static implicit operator OneOrManyCheckinTime (DateTimeOffset[] values) { return new OneOrManyCheckinTime (values.Select(v => (ICheckinTime) new CheckinTimeDateTimeOffset (v))); }
            public static implicit operator OneOrManyCheckinTime (List<DateTimeOffset> values) { return new OneOrManyCheckinTime (values.Select(v => (ICheckinTime) new CheckinTimeDateTimeOffset (v))); }
        }
        public struct CheckinTimeDateTimeOffset : ICheckinTime<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public CheckinTimeDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator CheckinTimeDateTimeOffset (DateTimeOffset value) { return new CheckinTimeDateTimeOffset (value); }
        }

        public interface ICheckoutTime : IValue {}
        public interface ICheckoutTime<T> : ICheckoutTime { new T Value { get; } }
        public class OneOrManyCheckoutTime : OneOrMany<ICheckoutTime>
        {
            public OneOrManyCheckoutTime(ICheckoutTime item) : base(item) { }
            public OneOrManyCheckoutTime(IEnumerable<ICheckoutTime> items) : base(items) { }
            public static implicit operator OneOrManyCheckoutTime (DateTimeOffset value) { return new OneOrManyCheckoutTime (new CheckoutTimeDateTimeOffset (value)); }
            public static implicit operator OneOrManyCheckoutTime (DateTimeOffset[] values) { return new OneOrManyCheckoutTime (values.Select(v => (ICheckoutTime) new CheckoutTimeDateTimeOffset (v))); }
            public static implicit operator OneOrManyCheckoutTime (List<DateTimeOffset> values) { return new OneOrManyCheckoutTime (values.Select(v => (ICheckoutTime) new CheckoutTimeDateTimeOffset (v))); }
        }
        public struct CheckoutTimeDateTimeOffset : ICheckoutTime<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public CheckoutTimeDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator CheckoutTimeDateTimeOffset (DateTimeOffset value) { return new CheckoutTimeDateTimeOffset (value); }
        }


        public interface IPetsAllowed : IValue {}
        public interface IPetsAllowed<T> : IPetsAllowed { new T Value { get; } }
        public class OneOrManyPetsAllowed : OneOrMany<IPetsAllowed>
        {
            public OneOrManyPetsAllowed(IPetsAllowed item) : base(item) { }
            public OneOrManyPetsAllowed(IEnumerable<IPetsAllowed> items) : base(items) { }
            public static implicit operator OneOrManyPetsAllowed (bool value) { return new OneOrManyPetsAllowed (new PetsAllowedbool (value)); }
            public static implicit operator OneOrManyPetsAllowed (bool[] values) { return new OneOrManyPetsAllowed (values.Select(v => (IPetsAllowed) new PetsAllowedbool (v))); }
            public static implicit operator OneOrManyPetsAllowed (List<bool> values) { return new OneOrManyPetsAllowed (values.Select(v => (IPetsAllowed) new PetsAllowedbool (v))); }
            public static implicit operator OneOrManyPetsAllowed (string value) { return new OneOrManyPetsAllowed (new PetsAllowedstring (value)); }
            public static implicit operator OneOrManyPetsAllowed (string[] values) { return new OneOrManyPetsAllowed (values.Select(v => (IPetsAllowed) new PetsAllowedstring (v))); }
            public static implicit operator OneOrManyPetsAllowed (List<string> values) { return new OneOrManyPetsAllowed (values.Select(v => (IPetsAllowed) new PetsAllowedstring (v))); }
        }
        public struct PetsAllowedbool : IPetsAllowed<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public PetsAllowedbool (bool value) { Value = value; }
            public static implicit operator PetsAllowedbool (bool value) { return new PetsAllowedbool (value); }
        }
        public struct PetsAllowedstring : IPetsAllowed<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PetsAllowedstring (string value) { Value = value; }
            public static implicit operator PetsAllowedstring (string value) { return new PetsAllowedstring (value); }
        }

        public interface IStarRating : IValue {}
        public interface IStarRating<T> : IStarRating { new T Value { get; } }
        public class OneOrManyStarRating : OneOrMany<IStarRating>
        {
            public OneOrManyStarRating(IStarRating item) : base(item) { }
            public OneOrManyStarRating(IEnumerable<IStarRating> items) : base(items) { }
            public static implicit operator OneOrManyStarRating (Rating value) { return new OneOrManyStarRating (new StarRatingRating (value)); }
            public static implicit operator OneOrManyStarRating (Rating[] values) { return new OneOrManyStarRating (values.Select(v => (IStarRating) new StarRatingRating (v))); }
            public static implicit operator OneOrManyStarRating (List<Rating> values) { return new OneOrManyStarRating (values.Select(v => (IStarRating) new StarRatingRating (v))); }
        }
        public struct StarRatingRating : IStarRating<Rating>
        {
            object IValue.Value => this.Value;
            public Rating Value { get; }
            public StarRatingRating (Rating value) { Value = value; }
            public static implicit operator StarRatingRating (Rating value) { return new StarRatingRating (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CivicStructureAndLodgingBusiness";

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [DataMember(Name = "amenityFeature", Order = 306)]
        public override OneOrManyAmenityFeature AmenityFeature { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience", Order = 307)]
        public OneOrManyAudience Audience { get; set; }

        /// <summary>
        /// A language someone may use with or at the item, service or place. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        [DataMember(Name = "availableLanguage", Order = 308)]
        public OneOrManyAvailableLanguage AvailableLanguage { get; set; }

        /// <summary>
        /// The earliest someone may check into a lodging establishment.
        /// </summary>
        [DataMember(Name = "checkinTime", Order = 309)]
        public OneOrManyCheckinTime CheckinTime { get; set; }

        /// <summary>
        /// The latest someone may check out of a lodging establishment.
        /// </summary>
        [DataMember(Name = "checkoutTime", Order = 310)]
        public OneOrManyCheckoutTime CheckoutTime { get; set; }

        /// <summary>
        /// The general opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Days are specified using the following two-letter combinations: &lt;code&gt;Mo&lt;/code&gt;, &lt;code&gt;Tu&lt;/code&gt;, &lt;code&gt;We&lt;/code&gt;, &lt;code&gt;Th&lt;/code&gt;, &lt;code&gt;Fr&lt;/code&gt;, &lt;code&gt;Sa&lt;/code&gt;, &lt;code&gt;Su&lt;/code&gt;.&lt;/li&gt;
        /// &lt;li&gt;Times are specified using 24:00 time. For example, 3pm is specified as &lt;code&gt;15:00&lt;/code&gt;. &lt;/li&gt;
        /// &lt;li&gt;Here is an example: &lt;code&gt;&amp;lt;time itemprop="openingHours" datetime=&amp;quot;Tu,Th 16:00-20:00&amp;quot;&amp;gt;Tuesdays and Thursdays 4-8pm&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
        /// &lt;li&gt;If a business is open 7 days a week, then it can be specified as &lt;code&gt;&amp;lt;time itemprop=&amp;quot;openingHours&amp;quot; datetime=&amp;quot;Mo-Su&amp;quot;&amp;gt;Monday through Sunday, all day&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "openingHours", Order = 311)]
        public override OneOrManyOpeningHours OpeningHours { get; set; }

        /// <summary>
        /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        [DataMember(Name = "petsAllowed", Order = 312)]
        public OneOrManyPetsAllowed PetsAllowed { get; set; }

        /// <summary>
        /// An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).
        /// </summary>
        [DataMember(Name = "starRating", Order = 313)]
        public OneOrManyStarRating StarRating { get; set; }
    }
}
