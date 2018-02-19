using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A tourist attraction.  In principle any Thing can be a &lt;a class="localLink" href="http://schema.org/TouristAttraction"&gt;TouristAttraction&lt;/a&gt;, from a &lt;a class="localLink" href="http://schema.org/Mountain"&gt;Mountain&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/LandmarksOrHistoricalBuildings"&gt;LandmarksOrHistoricalBuildings&lt;/a&gt; to a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt;.  This Type can be used on its own to describe a general &lt;a class="localLink" href="http://schema.org/TourstAttraction"&gt;TourstAttraction&lt;/a&gt;, or be used as an &lt;a class="localLink" href="http://schema.org/additionalType"&gt;additionalType&lt;/a&gt; to add tourist attraction properties to any other type.  (See examples below)
    /// </summary>
    [DataContract]
    public partial class TouristAttraction : Place
    {
        public interface IAvailableLanguage : IWrapper { }
        public interface IAvailableLanguage<T> : IAvailableLanguage { new T Data { get; set; } }
        public class AvailableLanguageLanguage : IAvailableLanguage<Language>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Language) value; } }
            public virtual Language Data { get; set; }
            public AvailableLanguageLanguage () { }
            public AvailableLanguageLanguage (Language data) { Data = data; }
            public static implicit operator AvailableLanguageLanguage (Language data) { return new AvailableLanguageLanguage (data); }
        }

        public class AvailableLanguagestring : IAvailableLanguage<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public AvailableLanguagestring () { }
            public AvailableLanguagestring (string data) { Data = data; }
            public static implicit operator AvailableLanguagestring (string data) { return new AvailableLanguagestring (data); }
        }


        public interface ITouristType : IWrapper { }
        public interface ITouristType<T> : ITouristType { new T Data { get; set; } }
        public class TouristTypeAudience : ITouristType<Audience>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Audience) value; } }
            public virtual Audience Data { get; set; }
            public TouristTypeAudience () { }
            public TouristTypeAudience (Audience data) { Data = data; }
            public static implicit operator TouristTypeAudience (Audience data) { return new TouristTypeAudience (data); }
        }

        public class TouristTypestring : ITouristType<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public TouristTypestring () { }
            public TouristTypestring (string data) { Data = data; }
            public static implicit operator TouristTypestring (string data) { return new TouristTypestring (data); }
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAvailableLanguage>? AvailableLanguage { get; set; } //Language, string

        /// <summary>
        /// Attraction suitable for type(s) of tourist. eg. Children, visitors from a particular country, etc.
        /// </summary>
        [DataMember(Name = "touristType", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ITouristType>? TouristType { get; set; } //Audience, string
    }
}
