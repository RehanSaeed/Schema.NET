namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A part of a successively published publication such as a periodical or publication volume, often numbered, usually containing a grouping of works such as articles.&lt;br/&gt;&lt;br/&gt;
    /// &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class PublicationIssue : CreativeWork
    {
        public interface IIssueNumber : IValue {}
        public interface IIssueNumber<T> : IIssueNumber { new T Value { get; } }
        public class OneOrManyIssueNumber : OneOrMany<IIssueNumber>
        {
            public OneOrManyIssueNumber(IIssueNumber item) : base(item) { }
            public OneOrManyIssueNumber(IEnumerable<IIssueNumber> items) : base(items) { }
            public static implicit operator OneOrManyIssueNumber (int value) { return new OneOrManyIssueNumber (new IssueNumberint (value)); }
            public static implicit operator OneOrManyIssueNumber (int[] values) { return new OneOrManyIssueNumber (values.Select(v => (IIssueNumber) new IssueNumberint (v))); }
            public static implicit operator OneOrManyIssueNumber (List<int> values) { return new OneOrManyIssueNumber (values.Select(v => (IIssueNumber) new IssueNumberint (v))); }
            public static implicit operator OneOrManyIssueNumber (string value) { return new OneOrManyIssueNumber (new IssueNumberstring (value)); }
            public static implicit operator OneOrManyIssueNumber (string[] values) { return new OneOrManyIssueNumber (values.Select(v => (IIssueNumber) new IssueNumberstring (v))); }
            public static implicit operator OneOrManyIssueNumber (List<string> values) { return new OneOrManyIssueNumber (values.Select(v => (IIssueNumber) new IssueNumberstring (v))); }
        }
        public struct IssueNumberint : IIssueNumber<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public IssueNumberint (int value) { Value = value; }
            public static implicit operator IssueNumberint (int value) { return new IssueNumberint (value); }
        }
        public struct IssueNumberstring : IIssueNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public IssueNumberstring (string value) { Value = value; }
            public static implicit operator IssueNumberstring (string value) { return new IssueNumberstring (value); }
        }

        public interface IPageEnd : IValue {}
        public interface IPageEnd<T> : IPageEnd { new T Value { get; } }
        public class OneOrManyPageEnd : OneOrMany<IPageEnd>
        {
            public OneOrManyPageEnd(IPageEnd item) : base(item) { }
            public OneOrManyPageEnd(IEnumerable<IPageEnd> items) : base(items) { }
            public static implicit operator OneOrManyPageEnd (int value) { return new OneOrManyPageEnd (new PageEndint (value)); }
            public static implicit operator OneOrManyPageEnd (int[] values) { return new OneOrManyPageEnd (values.Select(v => (IPageEnd) new PageEndint (v))); }
            public static implicit operator OneOrManyPageEnd (List<int> values) { return new OneOrManyPageEnd (values.Select(v => (IPageEnd) new PageEndint (v))); }
            public static implicit operator OneOrManyPageEnd (string value) { return new OneOrManyPageEnd (new PageEndstring (value)); }
            public static implicit operator OneOrManyPageEnd (string[] values) { return new OneOrManyPageEnd (values.Select(v => (IPageEnd) new PageEndstring (v))); }
            public static implicit operator OneOrManyPageEnd (List<string> values) { return new OneOrManyPageEnd (values.Select(v => (IPageEnd) new PageEndstring (v))); }
        }
        public struct PageEndint : IPageEnd<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public PageEndint (int value) { Value = value; }
            public static implicit operator PageEndint (int value) { return new PageEndint (value); }
        }
        public struct PageEndstring : IPageEnd<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PageEndstring (string value) { Value = value; }
            public static implicit operator PageEndstring (string value) { return new PageEndstring (value); }
        }

        public interface IPageStart : IValue {}
        public interface IPageStart<T> : IPageStart { new T Value { get; } }
        public class OneOrManyPageStart : OneOrMany<IPageStart>
        {
            public OneOrManyPageStart(IPageStart item) : base(item) { }
            public OneOrManyPageStart(IEnumerable<IPageStart> items) : base(items) { }
            public static implicit operator OneOrManyPageStart (int value) { return new OneOrManyPageStart (new PageStartint (value)); }
            public static implicit operator OneOrManyPageStart (int[] values) { return new OneOrManyPageStart (values.Select(v => (IPageStart) new PageStartint (v))); }
            public static implicit operator OneOrManyPageStart (List<int> values) { return new OneOrManyPageStart (values.Select(v => (IPageStart) new PageStartint (v))); }
            public static implicit operator OneOrManyPageStart (string value) { return new OneOrManyPageStart (new PageStartstring (value)); }
            public static implicit operator OneOrManyPageStart (string[] values) { return new OneOrManyPageStart (values.Select(v => (IPageStart) new PageStartstring (v))); }
            public static implicit operator OneOrManyPageStart (List<string> values) { return new OneOrManyPageStart (values.Select(v => (IPageStart) new PageStartstring (v))); }
        }
        public struct PageStartint : IPageStart<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public PageStartint (int value) { Value = value; }
            public static implicit operator PageStartint (int value) { return new PageStartint (value); }
        }
        public struct PageStartstring : IPageStart<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PageStartstring (string value) { Value = value; }
            public static implicit operator PageStartstring (string value) { return new PageStartstring (value); }
        }

        public interface IPagination : IValue {}
        public interface IPagination<T> : IPagination { new T Value { get; } }
        public class OneOrManyPagination : OneOrMany<IPagination>
        {
            public OneOrManyPagination(IPagination item) : base(item) { }
            public OneOrManyPagination(IEnumerable<IPagination> items) : base(items) { }
            public static implicit operator OneOrManyPagination (string value) { return new OneOrManyPagination (new Paginationstring (value)); }
            public static implicit operator OneOrManyPagination (string[] values) { return new OneOrManyPagination (values.Select(v => (IPagination) new Paginationstring (v))); }
            public static implicit operator OneOrManyPagination (List<string> values) { return new OneOrManyPagination (values.Select(v => (IPagination) new Paginationstring (v))); }
        }
        public struct Paginationstring : IPagination<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Paginationstring (string value) { Value = value; }
            public static implicit operator Paginationstring (string value) { return new Paginationstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PublicationIssue";

        /// <summary>
        /// Identifies the issue of publication; for example, "iii" or "2".
        /// </summary>
        [DataMember(Name = "issueNumber", Order = 206)]
        public OneOrManyIssueNumber IssueNumber { get; set; }

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [DataMember(Name = "pageEnd", Order = 207)]
        public OneOrManyPageEnd PageEnd { get; set; }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [DataMember(Name = "pageStart", Order = 208)]
        public OneOrManyPageStart PageStart { get; set; }

        /// <summary>
        /// Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
        /// </summary>
        [DataMember(Name = "pagination", Order = 209)]
        public OneOrManyPagination Pagination { get; set; }
    }
}
