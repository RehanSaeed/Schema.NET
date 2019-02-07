namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A particular physical business or branch of an organization. Examples of LocalBusiness include a restaurant, a particular branch of a restaurant chain, a branch of a bank, a medical practice, a club, a bowling alley, etc.
    /// </summary>
    [DataContract]
    public partial class LocalBusiness : OrganizationAndPlace
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
        public override string Type => "LocalBusiness";

        /// <summary>
        /// The currency accepted.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        [DataMember(Name = "currenciesAccepted", Order = 206)]
        public OneOrManyCurrenciesAccepted CurrenciesAccepted { get; set; }

        /// <summary>
        /// The general opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Days are specified using the following two-letter combinations: &lt;code&gt;Mo&lt;/code&gt;, &lt;code&gt;Tu&lt;/code&gt;, &lt;code&gt;We&lt;/code&gt;, &lt;code&gt;Th&lt;/code&gt;, &lt;code&gt;Fr&lt;/code&gt;, &lt;code&gt;Sa&lt;/code&gt;, &lt;code&gt;Su&lt;/code&gt;.&lt;/li&gt;
        /// &lt;li&gt;Times are specified using 24:00 time. For example, 3pm is specified as &lt;code&gt;15:00&lt;/code&gt;. &lt;/li&gt;
        /// &lt;li&gt;Here is an example: &lt;code&gt;&amp;lt;time itemprop="openingHours" datetime=&amp;quot;Tu,Th 16:00-20:00&amp;quot;&amp;gt;Tuesdays and Thursdays 4-8pm&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
        /// &lt;li&gt;If a business is open 7 days a week, then it can be specified as &lt;code&gt;&amp;lt;time itemprop=&amp;quot;openingHours&amp;quot; datetime=&amp;quot;Mo-Su&amp;quot;&amp;gt;Monday through Sunday, all day&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "openingHours", Order = 207)]
        public virtual OneOrManyOpeningHours OpeningHours { get; set; }

        /// <summary>
        /// Cash, Credit Card, Cryptocurrency, Local Exchange Tradings System, etc.
        /// </summary>
        [DataMember(Name = "paymentAccepted", Order = 208)]
        public OneOrManyPaymentAccepted PaymentAccepted { get; set; }

        /// <summary>
        /// The price range of the business, for example &lt;code&gt;$$$&lt;/code&gt;.
        /// </summary>
        [DataMember(Name = "priceRange", Order = 209)]
        public OneOrManyPriceRange PriceRange { get; set; }
    }
}
