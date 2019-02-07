namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A contact point&amp;#x2014;for example, a Customer Complaints department.
    /// </summary>
    [DataContract]
    public partial class ContactPoint : StructuredValue
    {
        public interface IAreaServed : IValue {}
        public interface IAreaServed<T> : IAreaServed { new T Value { get; } }
        public class OneOrManyAreaServed : OneOrMany<IAreaServed>
        {
            public OneOrManyAreaServed(IAreaServed item) : base(item) { }
            public OneOrManyAreaServed(IEnumerable<IAreaServed> items) : base(items) { }
            public static implicit operator OneOrManyAreaServed (AdministrativeArea value) { return new OneOrManyAreaServed (new AreaServedAdministrativeArea (value)); }
            public static implicit operator OneOrManyAreaServed (AdministrativeArea[] values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedAdministrativeArea (v))); }
            public static implicit operator OneOrManyAreaServed (List<AdministrativeArea> values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedAdministrativeArea (v))); }
            public static implicit operator OneOrManyAreaServed (GeoShape value) { return new OneOrManyAreaServed (new AreaServedGeoShape (value)); }
            public static implicit operator OneOrManyAreaServed (GeoShape[] values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedGeoShape (v))); }
            public static implicit operator OneOrManyAreaServed (List<GeoShape> values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedGeoShape (v))); }
            public static implicit operator OneOrManyAreaServed (Place value) { return new OneOrManyAreaServed (new AreaServedPlace (value)); }
            public static implicit operator OneOrManyAreaServed (Place[] values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedPlace (v))); }
            public static implicit operator OneOrManyAreaServed (List<Place> values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedPlace (v))); }
            public static implicit operator OneOrManyAreaServed (string value) { return new OneOrManyAreaServed (new AreaServedstring (value)); }
            public static implicit operator OneOrManyAreaServed (string[] values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedstring (v))); }
            public static implicit operator OneOrManyAreaServed (List<string> values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedstring (v))); }
        }
        public struct AreaServedAdministrativeArea : IAreaServed<AdministrativeArea>
        {
            object IValue.Value => this.Value;
            public AdministrativeArea Value { get; }
            public AreaServedAdministrativeArea (AdministrativeArea value) { Value = value; }
            public static implicit operator AreaServedAdministrativeArea (AdministrativeArea value) { return new AreaServedAdministrativeArea (value); }
        }
        public struct AreaServedGeoShape : IAreaServed<GeoShape>
        {
            object IValue.Value => this.Value;
            public GeoShape Value { get; }
            public AreaServedGeoShape (GeoShape value) { Value = value; }
            public static implicit operator AreaServedGeoShape (GeoShape value) { return new AreaServedGeoShape (value); }
        }
        public struct AreaServedPlace : IAreaServed<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public AreaServedPlace (Place value) { Value = value; }
            public static implicit operator AreaServedPlace (Place value) { return new AreaServedPlace (value); }
        }
        public struct AreaServedstring : IAreaServed<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AreaServedstring (string value) { Value = value; }
            public static implicit operator AreaServedstring (string value) { return new AreaServedstring (value); }
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

        public interface IContactOption : IValue {}
        public interface IContactOption<T> : IContactOption { new T Value { get; } }
        public class OneOrManyContactOption : OneOrMany<IContactOption>
        {
            public OneOrManyContactOption(IContactOption item) : base(item) { }
            public OneOrManyContactOption(IEnumerable<IContactOption> items) : base(items) { }
            public static implicit operator OneOrManyContactOption (ContactPointOption value) { return new OneOrManyContactOption (new ContactOptionContactPointOption (value)); }
            public static implicit operator OneOrManyContactOption (ContactPointOption[] values) { return new OneOrManyContactOption (values.Select(v => (IContactOption) new ContactOptionContactPointOption (v))); }
            public static implicit operator OneOrManyContactOption (List<ContactPointOption> values) { return new OneOrManyContactOption (values.Select(v => (IContactOption) new ContactOptionContactPointOption (v))); }
        }
        public struct ContactOptionContactPointOption : IContactOption<ContactPointOption>
        {
            object IValue.Value => this.Value;
            public ContactPointOption Value { get; }
            public ContactOptionContactPointOption (ContactPointOption value) { Value = value; }
            public static implicit operator ContactOptionContactPointOption (ContactPointOption value) { return new ContactOptionContactPointOption (value); }
        }

        public interface IContactType : IValue {}
        public interface IContactType<T> : IContactType { new T Value { get; } }
        public class OneOrManyContactType : OneOrMany<IContactType>
        {
            public OneOrManyContactType(IContactType item) : base(item) { }
            public OneOrManyContactType(IEnumerable<IContactType> items) : base(items) { }
            public static implicit operator OneOrManyContactType (string value) { return new OneOrManyContactType (new ContactTypestring (value)); }
            public static implicit operator OneOrManyContactType (string[] values) { return new OneOrManyContactType (values.Select(v => (IContactType) new ContactTypestring (v))); }
            public static implicit operator OneOrManyContactType (List<string> values) { return new OneOrManyContactType (values.Select(v => (IContactType) new ContactTypestring (v))); }
        }
        public struct ContactTypestring : IContactType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ContactTypestring (string value) { Value = value; }
            public static implicit operator ContactTypestring (string value) { return new ContactTypestring (value); }
        }

        public interface IEmail : IValue {}
        public interface IEmail<T> : IEmail { new T Value { get; } }
        public class OneOrManyEmail : OneOrMany<IEmail>
        {
            public OneOrManyEmail(IEmail item) : base(item) { }
            public OneOrManyEmail(IEnumerable<IEmail> items) : base(items) { }
            public static implicit operator OneOrManyEmail (string value) { return new OneOrManyEmail (new Emailstring (value)); }
            public static implicit operator OneOrManyEmail (string[] values) { return new OneOrManyEmail (values.Select(v => (IEmail) new Emailstring (v))); }
            public static implicit operator OneOrManyEmail (List<string> values) { return new OneOrManyEmail (values.Select(v => (IEmail) new Emailstring (v))); }
        }
        public struct Emailstring : IEmail<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Emailstring (string value) { Value = value; }
            public static implicit operator Emailstring (string value) { return new Emailstring (value); }
        }

        public interface IFaxNumber : IValue {}
        public interface IFaxNumber<T> : IFaxNumber { new T Value { get; } }
        public class OneOrManyFaxNumber : OneOrMany<IFaxNumber>
        {
            public OneOrManyFaxNumber(IFaxNumber item) : base(item) { }
            public OneOrManyFaxNumber(IEnumerable<IFaxNumber> items) : base(items) { }
            public static implicit operator OneOrManyFaxNumber (string value) { return new OneOrManyFaxNumber (new FaxNumberstring (value)); }
            public static implicit operator OneOrManyFaxNumber (string[] values) { return new OneOrManyFaxNumber (values.Select(v => (IFaxNumber) new FaxNumberstring (v))); }
            public static implicit operator OneOrManyFaxNumber (List<string> values) { return new OneOrManyFaxNumber (values.Select(v => (IFaxNumber) new FaxNumberstring (v))); }
        }
        public struct FaxNumberstring : IFaxNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public FaxNumberstring (string value) { Value = value; }
            public static implicit operator FaxNumberstring (string value) { return new FaxNumberstring (value); }
        }

        public interface IHoursAvailable : IValue {}
        public interface IHoursAvailable<T> : IHoursAvailable { new T Value { get; } }
        public class OneOrManyHoursAvailable : OneOrMany<IHoursAvailable>
        {
            public OneOrManyHoursAvailable(IHoursAvailable item) : base(item) { }
            public OneOrManyHoursAvailable(IEnumerable<IHoursAvailable> items) : base(items) { }
            public static implicit operator OneOrManyHoursAvailable (OpeningHoursSpecification value) { return new OneOrManyHoursAvailable (new HoursAvailableOpeningHoursSpecification (value)); }
            public static implicit operator OneOrManyHoursAvailable (OpeningHoursSpecification[] values) { return new OneOrManyHoursAvailable (values.Select(v => (IHoursAvailable) new HoursAvailableOpeningHoursSpecification (v))); }
            public static implicit operator OneOrManyHoursAvailable (List<OpeningHoursSpecification> values) { return new OneOrManyHoursAvailable (values.Select(v => (IHoursAvailable) new HoursAvailableOpeningHoursSpecification (v))); }
        }
        public struct HoursAvailableOpeningHoursSpecification : IHoursAvailable<OpeningHoursSpecification>
        {
            object IValue.Value => this.Value;
            public OpeningHoursSpecification Value { get; }
            public HoursAvailableOpeningHoursSpecification (OpeningHoursSpecification value) { Value = value; }
            public static implicit operator HoursAvailableOpeningHoursSpecification (OpeningHoursSpecification value) { return new HoursAvailableOpeningHoursSpecification (value); }
        }

        public interface IProductSupported : IValue {}
        public interface IProductSupported<T> : IProductSupported { new T Value { get; } }
        public class OneOrManyProductSupported : OneOrMany<IProductSupported>
        {
            public OneOrManyProductSupported(IProductSupported item) : base(item) { }
            public OneOrManyProductSupported(IEnumerable<IProductSupported> items) : base(items) { }
            public static implicit operator OneOrManyProductSupported (Product value) { return new OneOrManyProductSupported (new ProductSupportedProduct (value)); }
            public static implicit operator OneOrManyProductSupported (Product[] values) { return new OneOrManyProductSupported (values.Select(v => (IProductSupported) new ProductSupportedProduct (v))); }
            public static implicit operator OneOrManyProductSupported (List<Product> values) { return new OneOrManyProductSupported (values.Select(v => (IProductSupported) new ProductSupportedProduct (v))); }
            public static implicit operator OneOrManyProductSupported (string value) { return new OneOrManyProductSupported (new ProductSupportedstring (value)); }
            public static implicit operator OneOrManyProductSupported (string[] values) { return new OneOrManyProductSupported (values.Select(v => (IProductSupported) new ProductSupportedstring (v))); }
            public static implicit operator OneOrManyProductSupported (List<string> values) { return new OneOrManyProductSupported (values.Select(v => (IProductSupported) new ProductSupportedstring (v))); }
        }
        public struct ProductSupportedProduct : IProductSupported<Product>
        {
            object IValue.Value => this.Value;
            public Product Value { get; }
            public ProductSupportedProduct (Product value) { Value = value; }
            public static implicit operator ProductSupportedProduct (Product value) { return new ProductSupportedProduct (value); }
        }
        public struct ProductSupportedstring : IProductSupported<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ProductSupportedstring (string value) { Value = value; }
            public static implicit operator ProductSupportedstring (string value) { return new ProductSupportedstring (value); }
        }

        public interface ITelephone : IValue {}
        public interface ITelephone<T> : ITelephone { new T Value { get; } }
        public class OneOrManyTelephone : OneOrMany<ITelephone>
        {
            public OneOrManyTelephone(ITelephone item) : base(item) { }
            public OneOrManyTelephone(IEnumerable<ITelephone> items) : base(items) { }
            public static implicit operator OneOrManyTelephone (string value) { return new OneOrManyTelephone (new Telephonestring (value)); }
            public static implicit operator OneOrManyTelephone (string[] values) { return new OneOrManyTelephone (values.Select(v => (ITelephone) new Telephonestring (v))); }
            public static implicit operator OneOrManyTelephone (List<string> values) { return new OneOrManyTelephone (values.Select(v => (ITelephone) new Telephonestring (v))); }
        }
        public struct Telephonestring : ITelephone<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Telephonestring (string value) { Value = value; }
            public static implicit operator Telephonestring (string value) { return new Telephonestring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ContactPoint";

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 306)]
        public OneOrManyAreaServed AreaServed { get; set; }

        /// <summary>
        /// A language someone may use with or at the item, service or place. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
        /// </summary>
        [DataMember(Name = "availableLanguage", Order = 307)]
        public OneOrManyAvailableLanguage AvailableLanguage { get; set; }

        /// <summary>
        /// An option available on this contact point (e.g. a toll-free number or support for hearing-impaired callers).
        /// </summary>
        [DataMember(Name = "contactOption", Order = 308)]
        public OneOrManyContactOption ContactOption { get; set; }

        /// <summary>
        /// A person or organization can have different contact points, for different purposes. For example, a sales contact point, a PR contact point and so on. This property is used to specify the kind of contact point.
        /// </summary>
        [DataMember(Name = "contactType", Order = 309)]
        public OneOrManyContactType ContactType { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [DataMember(Name = "email", Order = 310)]
        public OneOrManyEmail Email { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 311)]
        public OneOrManyFaxNumber FaxNumber { get; set; }

        /// <summary>
        /// The hours during which this service or contact is available.
        /// </summary>
        [DataMember(Name = "hoursAvailable", Order = 312)]
        public OneOrManyHoursAvailable HoursAvailable { get; set; }

        /// <summary>
        /// The product or service this support contact point is related to (such as product support for a particular product line). This can be a specific product or product line (e.g. "iPhone") or a general category of products or services (e.g. "smartphones").
        /// </summary>
        [DataMember(Name = "productSupported", Order = 313)]
        public OneOrManyProductSupported ProductSupported { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 314)]
        public OneOrManyTelephone Telephone { get; set; }
    }
}
