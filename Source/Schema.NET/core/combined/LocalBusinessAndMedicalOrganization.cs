namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// See LocalBusiness, MedicalOrganization for more information.
    /// </summary>
    [DataContract]
    public abstract partial class LocalBusinessAndMedicalOrganization : OrganizationAndPlace
    {
        public interface ICurrenciesAccepted : IValue {}
        public interface ICurrenciesAccepted<T> : ICurrenciesAccepted { new T Value { get; } }
        public class OneOrManyCurrenciesAccepted : OneOrMany<ICurrenciesAccepted>
        {
            public OneOrManyCurrenciesAccepted(ICurrenciesAccepted item) : base(item) { }
            public OneOrManyCurrenciesAccepted(IEnumerable<ICurrenciesAccepted> items) : base(items) { }
            public static implicit operator OneOrManyCurrenciesAccepted (string value) { return new OneOrManyCurrenciesAccepted (new CurrenciesAcceptedstring (value)); }
            public static implicit operator OneOrManyCurrenciesAccepted (string[] values) { return new OneOrManyCurrenciesAccepted (values.Select(v => (ICurrenciesAccepted) new CurrenciesAcceptedstring (v))); }
            public static implicit operator OneOrManyCurrenciesAccepted (List<string> values) { return new OneOrManyCurrenciesAccepted (values.Select(v => (ICurrenciesAccepted) new CurrenciesAcceptedstring (v))); }
        }
        public struct CurrenciesAcceptedstring : ICurrenciesAccepted<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public CurrenciesAcceptedstring (string value) { Value = value; }
            public static implicit operator CurrenciesAcceptedstring (string value) { return new CurrenciesAcceptedstring (value); }
        }

        public interface IHealthPlanNetworkId : IValue {}
        public interface IHealthPlanNetworkId<T> : IHealthPlanNetworkId { new T Value { get; } }
        public class OneOrManyHealthPlanNetworkId : OneOrMany<IHealthPlanNetworkId>
        {
            public OneOrManyHealthPlanNetworkId(IHealthPlanNetworkId item) : base(item) { }
            public OneOrManyHealthPlanNetworkId(IEnumerable<IHealthPlanNetworkId> items) : base(items) { }
            public static implicit operator OneOrManyHealthPlanNetworkId (string value) { return new OneOrManyHealthPlanNetworkId (new HealthPlanNetworkIdstring (value)); }
            public static implicit operator OneOrManyHealthPlanNetworkId (string[] values) { return new OneOrManyHealthPlanNetworkId (values.Select(v => (IHealthPlanNetworkId) new HealthPlanNetworkIdstring (v))); }
            public static implicit operator OneOrManyHealthPlanNetworkId (List<string> values) { return new OneOrManyHealthPlanNetworkId (values.Select(v => (IHealthPlanNetworkId) new HealthPlanNetworkIdstring (v))); }
        }
        public struct HealthPlanNetworkIdstring : IHealthPlanNetworkId<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public HealthPlanNetworkIdstring (string value) { Value = value; }
            public static implicit operator HealthPlanNetworkIdstring (string value) { return new HealthPlanNetworkIdstring (value); }
        }

        public interface IIsAcceptingNewPatients : IValue {}
        public interface IIsAcceptingNewPatients<T> : IIsAcceptingNewPatients { new T Value { get; } }
        public class OneOrManyIsAcceptingNewPatients : OneOrMany<IIsAcceptingNewPatients>
        {
            public OneOrManyIsAcceptingNewPatients(IIsAcceptingNewPatients item) : base(item) { }
            public OneOrManyIsAcceptingNewPatients(IEnumerable<IIsAcceptingNewPatients> items) : base(items) { }
            public static implicit operator OneOrManyIsAcceptingNewPatients (bool value) { return new OneOrManyIsAcceptingNewPatients (new IsAcceptingNewPatientsbool (value)); }
            public static implicit operator OneOrManyIsAcceptingNewPatients (bool[] values) { return new OneOrManyIsAcceptingNewPatients (values.Select(v => (IIsAcceptingNewPatients) new IsAcceptingNewPatientsbool (v))); }
            public static implicit operator OneOrManyIsAcceptingNewPatients (List<bool> values) { return new OneOrManyIsAcceptingNewPatients (values.Select(v => (IIsAcceptingNewPatients) new IsAcceptingNewPatientsbool (v))); }
        }
        public struct IsAcceptingNewPatientsbool : IIsAcceptingNewPatients<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public IsAcceptingNewPatientsbool (bool value) { Value = value; }
            public static implicit operator IsAcceptingNewPatientsbool (bool value) { return new IsAcceptingNewPatientsbool (value); }
        }

        public interface IMedicalSpecialty : IValue {}
        public interface IMedicalSpecialty<T> : IMedicalSpecialty { new T Value { get; } }
        public class OneOrManyMedicalSpecialty : OneOrMany<IMedicalSpecialty>
        {
            public OneOrManyMedicalSpecialty(IMedicalSpecialty item) : base(item) { }
            public OneOrManyMedicalSpecialty(IEnumerable<IMedicalSpecialty> items) : base(items) { }
            public static implicit operator OneOrManyMedicalSpecialty (MedicalSpecialty value) { return new OneOrManyMedicalSpecialty (new MedicalSpecialtyMedicalSpecialty (value)); }
            public static implicit operator OneOrManyMedicalSpecialty (MedicalSpecialty[] values) { return new OneOrManyMedicalSpecialty (values.Select(v => (IMedicalSpecialty) new MedicalSpecialtyMedicalSpecialty (v))); }
            public static implicit operator OneOrManyMedicalSpecialty (List<MedicalSpecialty> values) { return new OneOrManyMedicalSpecialty (values.Select(v => (IMedicalSpecialty) new MedicalSpecialtyMedicalSpecialty (v))); }
        }
        public struct MedicalSpecialtyMedicalSpecialty : IMedicalSpecialty<MedicalSpecialty>
        {
            object IValue.Value => this.Value;
            public MedicalSpecialty Value { get; }
            public MedicalSpecialtyMedicalSpecialty (MedicalSpecialty value) { Value = value; }
            public static implicit operator MedicalSpecialtyMedicalSpecialty (MedicalSpecialty value) { return new MedicalSpecialtyMedicalSpecialty (value); }
        }

        public interface IOpeningHours : IValue {}
        public interface IOpeningHours<T> : IOpeningHours { new T Value { get; } }
        public class OneOrManyOpeningHours : OneOrMany<IOpeningHours>
        {
            public OneOrManyOpeningHours(IOpeningHours item) : base(item) { }
            public OneOrManyOpeningHours(IEnumerable<IOpeningHours> items) : base(items) { }
            public static implicit operator OneOrManyOpeningHours (string value) { return new OneOrManyOpeningHours (new OpeningHoursstring (value)); }
            public static implicit operator OneOrManyOpeningHours (string[] values) { return new OneOrManyOpeningHours (values.Select(v => (IOpeningHours) new OpeningHoursstring (v))); }
            public static implicit operator OneOrManyOpeningHours (List<string> values) { return new OneOrManyOpeningHours (values.Select(v => (IOpeningHours) new OpeningHoursstring (v))); }
        }
        public struct OpeningHoursstring : IOpeningHours<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public OpeningHoursstring (string value) { Value = value; }
            public static implicit operator OpeningHoursstring (string value) { return new OpeningHoursstring (value); }
        }

        public interface IPaymentAccepted : IValue {}
        public interface IPaymentAccepted<T> : IPaymentAccepted { new T Value { get; } }
        public class OneOrManyPaymentAccepted : OneOrMany<IPaymentAccepted>
        {
            public OneOrManyPaymentAccepted(IPaymentAccepted item) : base(item) { }
            public OneOrManyPaymentAccepted(IEnumerable<IPaymentAccepted> items) : base(items) { }
            public static implicit operator OneOrManyPaymentAccepted (string value) { return new OneOrManyPaymentAccepted (new PaymentAcceptedstring (value)); }
            public static implicit operator OneOrManyPaymentAccepted (string[] values) { return new OneOrManyPaymentAccepted (values.Select(v => (IPaymentAccepted) new PaymentAcceptedstring (v))); }
            public static implicit operator OneOrManyPaymentAccepted (List<string> values) { return new OneOrManyPaymentAccepted (values.Select(v => (IPaymentAccepted) new PaymentAcceptedstring (v))); }
        }
        public struct PaymentAcceptedstring : IPaymentAccepted<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PaymentAcceptedstring (string value) { Value = value; }
            public static implicit operator PaymentAcceptedstring (string value) { return new PaymentAcceptedstring (value); }
        }

        public interface IPriceRange : IValue {}
        public interface IPriceRange<T> : IPriceRange { new T Value { get; } }
        public class OneOrManyPriceRange : OneOrMany<IPriceRange>
        {
            public OneOrManyPriceRange(IPriceRange item) : base(item) { }
            public OneOrManyPriceRange(IEnumerable<IPriceRange> items) : base(items) { }
            public static implicit operator OneOrManyPriceRange (string value) { return new OneOrManyPriceRange (new PriceRangestring (value)); }
            public static implicit operator OneOrManyPriceRange (string[] values) { return new OneOrManyPriceRange (values.Select(v => (IPriceRange) new PriceRangestring (v))); }
            public static implicit operator OneOrManyPriceRange (List<string> values) { return new OneOrManyPriceRange (values.Select(v => (IPriceRange) new PriceRangestring (v))); }
        }
        public struct PriceRangestring : IPriceRange<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PriceRangestring (string value) { Value = value; }
            public static implicit operator PriceRangestring (string value) { return new PriceRangestring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LocalBusinessAndMedicalOrganization";

        /// <summary>
        /// The currency accepted.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        [DataMember(Name = "currenciesAccepted", Order = 206)]
        public OneOrManyCurrenciesAccepted CurrenciesAccepted { get; set; }

        /// <summary>
        /// Name or unique ID of network. (Networks are often reused across different insurance plans).
        /// </summary>
        [DataMember(Name = "healthPlanNetworkId", Order = 207)]
        public OneOrManyHealthPlanNetworkId HealthPlanNetworkId { get; set; }

        /// <summary>
        /// Whether the provider is accepting new patients.
        /// </summary>
        [DataMember(Name = "isAcceptingNewPatients", Order = 208)]
        public OneOrManyIsAcceptingNewPatients IsAcceptingNewPatients { get; set; }

        /// <summary>
        /// A medical specialty of the provider.
        /// </summary>
        [DataMember(Name = "medicalSpecialty", Order = 209)]
        public OneOrManyMedicalSpecialty MedicalSpecialty { get; set; }

        /// <summary>
        /// The general opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Days are specified using the following two-letter combinations: &lt;code&gt;Mo&lt;/code&gt;, &lt;code&gt;Tu&lt;/code&gt;, &lt;code&gt;We&lt;/code&gt;, &lt;code&gt;Th&lt;/code&gt;, &lt;code&gt;Fr&lt;/code&gt;, &lt;code&gt;Sa&lt;/code&gt;, &lt;code&gt;Su&lt;/code&gt;.&lt;/li&gt;
        /// &lt;li&gt;Times are specified using 24:00 time. For example, 3pm is specified as &lt;code&gt;15:00&lt;/code&gt;. &lt;/li&gt;
        /// &lt;li&gt;Here is an example: &lt;code&gt;&amp;lt;time itemprop="openingHours" datetime=&amp;quot;Tu,Th 16:00-20:00&amp;quot;&amp;gt;Tuesdays and Thursdays 4-8pm&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
        /// &lt;li&gt;If a business is open 7 days a week, then it can be specified as &lt;code&gt;&amp;lt;time itemprop=&amp;quot;openingHours&amp;quot; datetime=&amp;quot;Mo-Su&amp;quot;&amp;gt;Monday through Sunday, all day&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "openingHours", Order = 210)]
        public OneOrManyOpeningHours OpeningHours { get; set; }

        /// <summary>
        /// Cash, Credit Card, Cryptocurrency, Local Exchange Tradings System, etc.
        /// </summary>
        [DataMember(Name = "paymentAccepted", Order = 211)]
        public OneOrManyPaymentAccepted PaymentAccepted { get; set; }

        /// <summary>
        /// The price range of the business, for example &lt;code&gt;$$$&lt;/code&gt;.
        /// </summary>
        [DataMember(Name = "priceRange", Order = 212)]
        public OneOrManyPriceRange PriceRange { get; set; }
    }
}
