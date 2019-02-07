namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A CreativeWorkSeries in schema.org is a group of related items, typically but not necessarily of the same kind. CreativeWorkSeries are usually organized into some order, often chronological. Unlike &lt;a class="localLink" href="http://schema.org/ItemList"&gt;ItemList&lt;/a&gt; which is a general purpose data structure for lists of things, the emphasis with CreativeWorkSeries is on published materials (written e.g. books and periodicals, or media such as tv, radio and games).&lt;br/&gt;&lt;br/&gt;
    /// Specific subtypes are available for describing &lt;a class="localLink" href="http://schema.org/TVSeries"&gt;TVSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/RadioSeries"&gt;RadioSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/MovieSeries"&gt;MovieSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/BookSeries"&gt;BookSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Periodical"&gt;Periodical&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/VideoGameSeries"&gt;VideoGameSeries&lt;/a&gt;. In each case, the &lt;a class="localLink" href="http://schema.org/hasPart"&gt;hasPart&lt;/a&gt; / &lt;a class="localLink" href="http://schema.org/isPartOf"&gt;isPartOf&lt;/a&gt; properties can be used to relate the CreativeWorkSeries to its parts. The general CreativeWorkSeries type serves largely just to organize these more specific and practical subtypes.&lt;br/&gt;&lt;br/&gt;
    /// It is common for properties applicable to an item from the series to be usefully applied to the containing group. Schema.org attempts to anticipate some of these cases, but publishers should be free to apply properties of the series parts to the series as a whole wherever they seem appropriate.
    /// </summary>
    [DataContract]
    public partial class CreativeWorkSeries : CreativeWorkAndSeries
    {
        public interface IIssn : IValue {}
        public interface IIssn<T> : IIssn { new T Value { get; } }
        public class OneOrManyIssn : OneOrMany<IIssn>
        {
            public OneOrManyIssn(IIssn item) : base(item) { }
            public OneOrManyIssn(IEnumerable<IIssn> items) : base(items) { }
            public static implicit operator OneOrManyIssn (string value) { return new OneOrManyIssn (new Issnstring (value)); }
            public static implicit operator OneOrManyIssn (string[] values) { return new OneOrManyIssn (values.Select(v => (IIssn) new Issnstring (v))); }
            public static implicit operator OneOrManyIssn (List<string> values) { return new OneOrManyIssn (values.Select(v => (IIssn) new Issnstring (v))); }
        }
        public struct Issnstring : IIssn<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Issnstring (string value) { Value = value; }
            public static implicit operator Issnstring (string value) { return new Issnstring (value); }
        }

        public interface IStartDate : IValue {}
        public interface IStartDate<T> : IStartDate { new T Value { get; } }
        public class OneOrManyStartDate : OneOrMany<IStartDate>
        {
            public OneOrManyStartDate(IStartDate item) : base(item) { }
            public OneOrManyStartDate(IEnumerable<IStartDate> items) : base(items) { }
            public static implicit operator OneOrManyStartDate (DateTimeOffset value) { return new OneOrManyStartDate (new StartDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyStartDate (DateTimeOffset[] values) { return new OneOrManyStartDate (values.Select(v => (IStartDate) new StartDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyStartDate (List<DateTimeOffset> values) { return new OneOrManyStartDate (values.Select(v => (IStartDate) new StartDateDateTimeOffset (v))); }
        }
        public struct StartDateDateTimeOffset : IStartDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public StartDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator StartDateDateTimeOffset (DateTimeOffset value) { return new StartDateDateTimeOffset (value); }
        }

        public interface IEndDate : IValue {}
        public interface IEndDate<T> : IEndDate { new T Value { get; } }
        public class OneOrManyEndDate : OneOrMany<IEndDate>
        {
            public OneOrManyEndDate(IEndDate item) : base(item) { }
            public OneOrManyEndDate(IEnumerable<IEndDate> items) : base(items) { }
            public static implicit operator OneOrManyEndDate (DateTimeOffset value) { return new OneOrManyEndDate (new EndDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyEndDate (DateTimeOffset[] values) { return new OneOrManyEndDate (values.Select(v => (IEndDate) new EndDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyEndDate (List<DateTimeOffset> values) { return new OneOrManyEndDate (values.Select(v => (IEndDate) new EndDateDateTimeOffset (v))); }
        }
        public struct EndDateDateTimeOffset : IEndDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public EndDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator EndDateDateTimeOffset (DateTimeOffset value) { return new EndDateDateTimeOffset (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CreativeWorkSeries";

        /// <summary>
        /// The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.
        /// </summary>
        [DataMember(Name = "issn", Order = 306)]
        public OneOrManyIssn Issn { get; set; }

        /// <summary>
        /// The start date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "startDate", Order = 307)]
        public OneOrManyStartDate StartDate { get; set; }

        /// <summary>
        /// The end date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "endDate", Order = 308)]
        public OneOrManyEndDate EndDate { get; set; }
    }
}
