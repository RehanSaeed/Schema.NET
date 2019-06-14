namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A means for accessing a service, e.g. a government office location, web site, or phone number.
    /// </summary>
    public partial interface IServiceChannel : IIntangible
    {
        /// <summary>
        /// A language someone may use with or at the item, service or place. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        Values<ILanguage, string>? AvailableLanguage { get; set; }

        /// <summary>
        /// Estimated processing time for the service using this channel.
        /// </summary>
        OneOrMany<TimeSpan?> ProcessingTime { get; set; }

        /// <summary>
        /// The service provided by this channel.
        /// </summary>
        OneOrMany<IService, Service> ProvidesService { get; set; }

        /// <summary>
        /// The location (e.g. civic structure, local business, etc.) where a person can go to access the service.
        /// </summary>
        OneOrMany<IPlace, Place> ServiceLocation { get; set; }

        /// <summary>
        /// The phone number to use to access the service.
        /// </summary>
        OneOrMany<IContactPoint, ContactPoint> ServicePhone { get; set; }

        /// <summary>
        /// The address for accessing the service by mail.
        /// </summary>
        OneOrMany<IPostalAddress, PostalAddress> ServicePostalAddress { get; set; }

        /// <summary>
        /// The number to access the service by text message.
        /// </summary>
        OneOrMany<IContactPoint, ContactPoint> ServiceSmsNumber { get; set; }

        /// <summary>
        /// The website to access the service.
        /// </summary>
        OneOrMany<Uri> ServiceUrl { get; set; }
    }

    /// <summary>
    /// A means for accessing a service, e.g. a government office location, web site, or phone number.
    /// </summary>
    [DataContract]
    public partial class ServiceChannel : Intangible, IServiceChannel
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ServiceChannel";

        /// <summary>
        /// A language someone may use with or at the item, service or place. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        [DataMember(Name = "availableLanguage", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ILanguage, string>? AvailableLanguage { get; set; }

        /// <summary>
        /// Estimated processing time for the service using this channel.
        /// </summary>
        [DataMember(Name = "processingTime", Order = 207)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public OneOrMany<TimeSpan?> ProcessingTime { get; set; }

        /// <summary>
        /// The service provided by this channel.
        /// </summary>
        [DataMember(Name = "providesService", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IService, Service> ProvidesService { get; set; }

        /// <summary>
        /// The location (e.g. civic structure, local business, etc.) where a person can go to access the service.
        /// </summary>
        [DataMember(Name = "serviceLocation", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace, Place> ServiceLocation { get; set; }

        /// <summary>
        /// The phone number to use to access the service.
        /// </summary>
        [DataMember(Name = "servicePhone", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IContactPoint, ContactPoint> ServicePhone { get; set; }

        /// <summary>
        /// The address for accessing the service by mail.
        /// </summary>
        [DataMember(Name = "servicePostalAddress", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPostalAddress, PostalAddress> ServicePostalAddress { get; set; }

        /// <summary>
        /// The number to access the service by text message.
        /// </summary>
        [DataMember(Name = "serviceSmsNumber", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IContactPoint, ContactPoint> ServiceSmsNumber { get; set; }

        /// <summary>
        /// The website to access the service.
        /// </summary>
        [DataMember(Name = "serviceUrl", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> ServiceUrl { get; set; }
    }
}
