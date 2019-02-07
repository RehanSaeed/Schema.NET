namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A tourist attraction.  In principle any Thing can be a &lt;a class="localLink" href="http://schema.org/TouristAttraction"&gt;TouristAttraction&lt;/a&gt;, from a &lt;a class="localLink" href="http://schema.org/Mountain"&gt;Mountain&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/LandmarksOrHistoricalBuildings"&gt;LandmarksOrHistoricalBuildings&lt;/a&gt; to a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt;.  This Type can be used on its own to describe a general &lt;a class="localLink" href="http://schema.org/TouristAttraction"&gt;TouristAttraction&lt;/a&gt;, or be used as an &lt;a class="localLink" href="http://schema.org/additionalType"&gt;additionalType&lt;/a&gt; to add tourist attraction properties to any other type.  (See examples below)
    /// </summary>
    [DataContract]
    public partial class TouristAttraction : Place
    {
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

        public interface ITouristType : IValue {}
        public interface ITouristType<T> : ITouristType { new T Value { get; } }
        public class OneOrManyTouristType : OneOrMany<ITouristType>
        {
            public OneOrManyTouristType(ITouristType item) : base(item) { }
            public OneOrManyTouristType(IEnumerable<ITouristType> items) : base(items) { }
            public static implicit operator OneOrManyTouristType (Audience value) { return new OneOrManyTouristType (new TouristTypeAudience (value)); }
            public static implicit operator OneOrManyTouristType (Audience[] values) { return new OneOrManyTouristType (values.Select(v => (ITouristType) new TouristTypeAudience (v))); }
            public static implicit operator OneOrManyTouristType (List<Audience> values) { return new OneOrManyTouristType (values.Select(v => (ITouristType) new TouristTypeAudience (v))); }
            public static implicit operator OneOrManyTouristType (string value) { return new OneOrManyTouristType (new TouristTypestring (value)); }
            public static implicit operator OneOrManyTouristType (string[] values) { return new OneOrManyTouristType (values.Select(v => (ITouristType) new TouristTypestring (v))); }
            public static implicit operator OneOrManyTouristType (List<string> values) { return new OneOrManyTouristType (values.Select(v => (ITouristType) new TouristTypestring (v))); }
        }
        public struct TouristTypeAudience : ITouristType<Audience>
        {
            object IValue.Value => this.Value;
            public Audience Value { get; }
            public TouristTypeAudience (Audience value) { Value = value; }
            public static implicit operator TouristTypeAudience (Audience value) { return new TouristTypeAudience (value); }
        }
        public struct TouristTypestring : ITouristType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public TouristTypestring (string value) { Value = value; }
            public static implicit operator TouristTypestring (string value) { return new TouristTypestring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TouristAttraction";

        /// <summary>
        /// A language someone may use with or at the item, service or place. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        [DataMember(Name = "availableLanguage", Order = 206)]
        public OneOrManyAvailableLanguage AvailableLanguage { get; set; }

        /// <summary>
        /// Attraction suitable for type(s) of tourist. eg. Children, visitors from a particular country, etc.
        /// </summary>
        [DataMember(Name = "touristType", Order = 207)]
        public OneOrManyTouristType TouristType { get; set; }
    }
}
