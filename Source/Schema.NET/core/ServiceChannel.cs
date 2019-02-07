namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A means for accessing a service, e.g. a government office location, web site, or phone number.
    /// </summary>
    [DataContract]
    public partial class ServiceChannel : Intangible
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

        public interface IProcessingTime : IValue {}
        public interface IProcessingTime<T> : IProcessingTime { new T Value { get; } }
        public class OneOrManyProcessingTime : OneOrMany<IProcessingTime>
        {
            public OneOrManyProcessingTime(IProcessingTime item) : base(item) { }
            public OneOrManyProcessingTime(IEnumerable<IProcessingTime> items) : base(items) { }
            public static implicit operator OneOrManyProcessingTime (TimeSpan value) { return new OneOrManyProcessingTime (new ProcessingTimeTimeSpan (value)); }
            public static implicit operator OneOrManyProcessingTime (TimeSpan[] values) { return new OneOrManyProcessingTime (values.Select(v => (IProcessingTime) new ProcessingTimeTimeSpan (v))); }
            public static implicit operator OneOrManyProcessingTime (List<TimeSpan> values) { return new OneOrManyProcessingTime (values.Select(v => (IProcessingTime) new ProcessingTimeTimeSpan (v))); }
        }
        public struct ProcessingTimeTimeSpan : IProcessingTime<TimeSpan>
        {
            object IValue.Value => this.Value;
            public TimeSpan Value { get; }
            public ProcessingTimeTimeSpan (TimeSpan value) { Value = value; }
            public static implicit operator ProcessingTimeTimeSpan (TimeSpan value) { return new ProcessingTimeTimeSpan (value); }
        }

        public interface IProvidesService : IValue {}
        public interface IProvidesService<T> : IProvidesService { new T Value { get; } }
        public class OneOrManyProvidesService : OneOrMany<IProvidesService>
        {
            public OneOrManyProvidesService(IProvidesService item) : base(item) { }
            public OneOrManyProvidesService(IEnumerable<IProvidesService> items) : base(items) { }
            public static implicit operator OneOrManyProvidesService (Service value) { return new OneOrManyProvidesService (new ProvidesServiceService (value)); }
            public static implicit operator OneOrManyProvidesService (Service[] values) { return new OneOrManyProvidesService (values.Select(v => (IProvidesService) new ProvidesServiceService (v))); }
            public static implicit operator OneOrManyProvidesService (List<Service> values) { return new OneOrManyProvidesService (values.Select(v => (IProvidesService) new ProvidesServiceService (v))); }
        }
        public struct ProvidesServiceService : IProvidesService<Service>
        {
            object IValue.Value => this.Value;
            public Service Value { get; }
            public ProvidesServiceService (Service value) { Value = value; }
            public static implicit operator ProvidesServiceService (Service value) { return new ProvidesServiceService (value); }
        }

        public interface IServiceLocation : IValue {}
        public interface IServiceLocation<T> : IServiceLocation { new T Value { get; } }
        public class OneOrManyServiceLocation : OneOrMany<IServiceLocation>
        {
            public OneOrManyServiceLocation(IServiceLocation item) : base(item) { }
            public OneOrManyServiceLocation(IEnumerable<IServiceLocation> items) : base(items) { }
            public static implicit operator OneOrManyServiceLocation (Place value) { return new OneOrManyServiceLocation (new ServiceLocationPlace (value)); }
            public static implicit operator OneOrManyServiceLocation (Place[] values) { return new OneOrManyServiceLocation (values.Select(v => (IServiceLocation) new ServiceLocationPlace (v))); }
            public static implicit operator OneOrManyServiceLocation (List<Place> values) { return new OneOrManyServiceLocation (values.Select(v => (IServiceLocation) new ServiceLocationPlace (v))); }
        }
        public struct ServiceLocationPlace : IServiceLocation<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public ServiceLocationPlace (Place value) { Value = value; }
            public static implicit operator ServiceLocationPlace (Place value) { return new ServiceLocationPlace (value); }
        }

        public interface IServicePhone : IValue {}
        public interface IServicePhone<T> : IServicePhone { new T Value { get; } }
        public class OneOrManyServicePhone : OneOrMany<IServicePhone>
        {
            public OneOrManyServicePhone(IServicePhone item) : base(item) { }
            public OneOrManyServicePhone(IEnumerable<IServicePhone> items) : base(items) { }
            public static implicit operator OneOrManyServicePhone (ContactPoint value) { return new OneOrManyServicePhone (new ServicePhoneContactPoint (value)); }
            public static implicit operator OneOrManyServicePhone (ContactPoint[] values) { return new OneOrManyServicePhone (values.Select(v => (IServicePhone) new ServicePhoneContactPoint (v))); }
            public static implicit operator OneOrManyServicePhone (List<ContactPoint> values) { return new OneOrManyServicePhone (values.Select(v => (IServicePhone) new ServicePhoneContactPoint (v))); }
        }
        public struct ServicePhoneContactPoint : IServicePhone<ContactPoint>
        {
            object IValue.Value => this.Value;
            public ContactPoint Value { get; }
            public ServicePhoneContactPoint (ContactPoint value) { Value = value; }
            public static implicit operator ServicePhoneContactPoint (ContactPoint value) { return new ServicePhoneContactPoint (value); }
        }

        public interface IServicePostalAddress : IValue {}
        public interface IServicePostalAddress<T> : IServicePostalAddress { new T Value { get; } }
        public class OneOrManyServicePostalAddress : OneOrMany<IServicePostalAddress>
        {
            public OneOrManyServicePostalAddress(IServicePostalAddress item) : base(item) { }
            public OneOrManyServicePostalAddress(IEnumerable<IServicePostalAddress> items) : base(items) { }
            public static implicit operator OneOrManyServicePostalAddress (PostalAddress value) { return new OneOrManyServicePostalAddress (new ServicePostalAddressPostalAddress (value)); }
            public static implicit operator OneOrManyServicePostalAddress (PostalAddress[] values) { return new OneOrManyServicePostalAddress (values.Select(v => (IServicePostalAddress) new ServicePostalAddressPostalAddress (v))); }
            public static implicit operator OneOrManyServicePostalAddress (List<PostalAddress> values) { return new OneOrManyServicePostalAddress (values.Select(v => (IServicePostalAddress) new ServicePostalAddressPostalAddress (v))); }
        }
        public struct ServicePostalAddressPostalAddress : IServicePostalAddress<PostalAddress>
        {
            object IValue.Value => this.Value;
            public PostalAddress Value { get; }
            public ServicePostalAddressPostalAddress (PostalAddress value) { Value = value; }
            public static implicit operator ServicePostalAddressPostalAddress (PostalAddress value) { return new ServicePostalAddressPostalAddress (value); }
        }

        public interface IServiceSmsNumber : IValue {}
        public interface IServiceSmsNumber<T> : IServiceSmsNumber { new T Value { get; } }
        public class OneOrManyServiceSmsNumber : OneOrMany<IServiceSmsNumber>
        {
            public OneOrManyServiceSmsNumber(IServiceSmsNumber item) : base(item) { }
            public OneOrManyServiceSmsNumber(IEnumerable<IServiceSmsNumber> items) : base(items) { }
            public static implicit operator OneOrManyServiceSmsNumber (ContactPoint value) { return new OneOrManyServiceSmsNumber (new ServiceSmsNumberContactPoint (value)); }
            public static implicit operator OneOrManyServiceSmsNumber (ContactPoint[] values) { return new OneOrManyServiceSmsNumber (values.Select(v => (IServiceSmsNumber) new ServiceSmsNumberContactPoint (v))); }
            public static implicit operator OneOrManyServiceSmsNumber (List<ContactPoint> values) { return new OneOrManyServiceSmsNumber (values.Select(v => (IServiceSmsNumber) new ServiceSmsNumberContactPoint (v))); }
        }
        public struct ServiceSmsNumberContactPoint : IServiceSmsNumber<ContactPoint>
        {
            object IValue.Value => this.Value;
            public ContactPoint Value { get; }
            public ServiceSmsNumberContactPoint (ContactPoint value) { Value = value; }
            public static implicit operator ServiceSmsNumberContactPoint (ContactPoint value) { return new ServiceSmsNumberContactPoint (value); }
        }

        public interface IServiceUrl : IValue {}
        public interface IServiceUrl<T> : IServiceUrl { new T Value { get; } }
        public class OneOrManyServiceUrl : OneOrMany<IServiceUrl>
        {
            public OneOrManyServiceUrl(IServiceUrl item) : base(item) { }
            public OneOrManyServiceUrl(IEnumerable<IServiceUrl> items) : base(items) { }
            public static implicit operator OneOrManyServiceUrl (Uri value) { return new OneOrManyServiceUrl (new ServiceUrlUri (value)); }
            public static implicit operator OneOrManyServiceUrl (Uri[] values) { return new OneOrManyServiceUrl (values.Select(v => (IServiceUrl) new ServiceUrlUri (v))); }
            public static implicit operator OneOrManyServiceUrl (List<Uri> values) { return new OneOrManyServiceUrl (values.Select(v => (IServiceUrl) new ServiceUrlUri (v))); }
        }
        public struct ServiceUrlUri : IServiceUrl<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public ServiceUrlUri (Uri value) { Value = value; }
            public static implicit operator ServiceUrlUri (Uri value) { return new ServiceUrlUri (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ServiceChannel";

        /// <summary>
        /// A language someone may use with or at the item, service or place. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        [DataMember(Name = "availableLanguage", Order = 206)]
        public OneOrManyAvailableLanguage AvailableLanguage { get; set; }

        /// <summary>
        /// Estimated processing time for the service using this channel.
        /// </summary>
        [DataMember(Name = "processingTime", Order = 207)]
        public OneOrManyProcessingTime ProcessingTime { get; set; }

        /// <summary>
        /// The service provided by this channel.
        /// </summary>
        [DataMember(Name = "providesService", Order = 208)]
        public OneOrManyProvidesService ProvidesService { get; set; }

        /// <summary>
        /// The location (e.g. civic structure, local business, etc.) where a person can go to access the service.
        /// </summary>
        [DataMember(Name = "serviceLocation", Order = 209)]
        public OneOrManyServiceLocation ServiceLocation { get; set; }

        /// <summary>
        /// The phone number to use to access the service.
        /// </summary>
        [DataMember(Name = "servicePhone", Order = 210)]
        public OneOrManyServicePhone ServicePhone { get; set; }

        /// <summary>
        /// The address for accessing the service by mail.
        /// </summary>
        [DataMember(Name = "servicePostalAddress", Order = 211)]
        public OneOrManyServicePostalAddress ServicePostalAddress { get; set; }

        /// <summary>
        /// The number to access the service by text message.
        /// </summary>
        [DataMember(Name = "serviceSmsNumber", Order = 212)]
        public OneOrManyServiceSmsNumber ServiceSmsNumber { get; set; }

        /// <summary>
        /// The website to access the service.
        /// </summary>
        [DataMember(Name = "serviceUrl", Order = 213)]
        public OneOrManyServiceUrl ServiceUrl { get; set; }
    }
}
