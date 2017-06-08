namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A means for accessing a service, e.g. a government office location, web site, or phone number.
    /// </summary>
    [DataContract]
    public class ServiceChannel : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ServiceChannel";

        /// <summary>
        /// The service provided by this channel.
        /// </summary>
        [DataMember(Name = "providesService")]
        public Service ProvidesService { get; set; }

        /// <summary>
        /// The location (e.g. civic structure, local business, etc.) where a person can go to access the service.
        /// </summary>
        [DataMember(Name = "serviceLocation")]
        public Place ServiceLocation { get; set; }

        /// <summary>
        /// The address for accessing the service by mail.
        /// </summary>
        [DataMember(Name = "servicePostalAddress")]
        public PostalAddress ServicePostalAddress { get; set; }

        /// <summary>
        /// A language someone may use with the item. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        [DataMember(Name = "availableLanguage")]
        public object AvailableLanguage { get; protected set; }

        /// <summary>
        /// A language someone may use with the item. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        [IgnoreDataMember]
        public string AvailableLanguageText
        {
            get => this.AvailableLanguage as string;
            set => this.AvailableLanguage = value;
        }

        /// <summary>
        /// A language someone may use with the item. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        [IgnoreDataMember]
        public Language AvailableLanguageLanguage
        {
            get => this.AvailableLanguage as Language;
            set => this.AvailableLanguage = value;
        }

        /// <summary>
        /// The number to access the service by text message.
        /// </summary>
        [DataMember(Name = "serviceSmsNumber")]
        public ContactPoint ServiceSmsNumber { get; set; }

        /// <summary>
        /// The website to access the service.
        /// </summary>
        [DataMember(Name = "serviceUrl")]
        public Uri ServiceUrl { get; set; }

        /// <summary>
        /// The phone number to use to access the service.
        /// </summary>
        [DataMember(Name = "servicePhone")]
        public ContactPoint ServicePhone { get; set; }

        /// <summary>
        /// Estimated processing time for the service using this channel.
        /// </summary>
        [DataMember(Name = "processingTime")]
        public Duration ProcessingTime { get; set; }
    }
}
