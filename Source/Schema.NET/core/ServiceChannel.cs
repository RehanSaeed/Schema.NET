namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A means for accessing a service, e.g. a government office location, web site, or phone number.
    /// </summary>
    [DataContract]
    public partial class ServiceChannel : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ServiceChannel";

        /// <summary>
        /// A language someone may use with the item. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        [DataMember(Name = "availableLanguage", Order = 204)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Language>? AvailableLanguage { get; set; }

        /// <summary>
        /// Estimated processing time for the service using this channel.
        /// </summary>
        [DataMember(Name = "processingTime", Order = 205)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan?>? ProcessingTime { get; set; }

        /// <summary>
        /// The service provided by this channel.
        /// </summary>
        [DataMember(Name = "providesService", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Service>? ProvidesService { get; set; }

        /// <summary>
        /// The location (e.g. civic structure, local business, etc.) where a person can go to access the service.
        /// </summary>
        [DataMember(Name = "serviceLocation", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? ServiceLocation { get; set; }

        /// <summary>
        /// The phone number to use to access the service.
        /// </summary>
        [DataMember(Name = "servicePhone", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ContactPoint>? ServicePhone { get; set; }

        /// <summary>
        /// The address for accessing the service by mail.
        /// </summary>
        [DataMember(Name = "servicePostalAddress", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PostalAddress>? ServicePostalAddress { get; set; }

        /// <summary>
        /// The number to access the service by text message.
        /// </summary>
        [DataMember(Name = "serviceSmsNumber", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ContactPoint>? ServiceSmsNumber { get; set; }

        /// <summary>
        /// The website to access the service.
        /// </summary>
        [DataMember(Name = "serviceUrl", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? ServiceUrl { get; set; }
    }
}