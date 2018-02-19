using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A part of a successively published publication such as a periodical or publication volume, often numbered, usually containing a grouping of works such as articles.&lt;/p&gt;
    /// &lt;p&gt;&lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class PublicationIssue : CreativeWork
    {
        public interface IIssueNumber : IWrapper { }
        public interface IIssueNumber<T> : IIssueNumber { new T Data { get; set; } }
        public class IssueNumberint : IIssueNumber<int>
        {
            object IWrapper.Data { get { return Data; } set { Data = (int) value; } }
            public virtual int Data { get; set; }
            public IssueNumberint () { }
            public IssueNumberint (int data) { Data = data; }
            public static implicit operator IssueNumberint (int data) { return new IssueNumberint (data); }
        }

        public class IssueNumberstring : IIssueNumber<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public IssueNumberstring () { }
            public IssueNumberstring (string data) { Data = data; }
            public static implicit operator IssueNumberstring (string data) { return new IssueNumberstring (data); }
        }


        public interface IPageEnd : IWrapper { }
        public interface IPageEnd<T> : IPageEnd { new T Data { get; set; } }
        public class PageEndint : IPageEnd<int>
        {
            object IWrapper.Data { get { return Data; } set { Data = (int) value; } }
            public virtual int Data { get; set; }
            public PageEndint () { }
            public PageEndint (int data) { Data = data; }
            public static implicit operator PageEndint (int data) { return new PageEndint (data); }
        }

        public class PageEndstring : IPageEnd<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public PageEndstring () { }
            public PageEndstring (string data) { Data = data; }
            public static implicit operator PageEndstring (string data) { return new PageEndstring (data); }
        }


        public interface IPageStart : IWrapper { }
        public interface IPageStart<T> : IPageStart { new T Data { get; set; } }
        public class PageStartint : IPageStart<int>
        {
            object IWrapper.Data { get { return Data; } set { Data = (int) value; } }
            public virtual int Data { get; set; }
            public PageStartint () { }
            public PageStartint (int data) { Data = data; }
            public static implicit operator PageStartint (int data) { return new PageStartint (data); }
        }

        public class PageStartstring : IPageStart<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public PageStartstring () { }
            public PageStartstring (string data) { Data = data; }
            public static implicit operator PageStartstring (string data) { return new PageStartstring (data); }
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IIssueNumber>? IssueNumber { get; set; } //int?, string

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [DataMember(Name = "pageEnd", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPageEnd>? PageEnd { get; set; } //int?, string

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [DataMember(Name = "pageStart", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPageStart>? PageStart { get; set; } //int?, string

        /// <summary>
        /// Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
        /// </summary>
        [DataMember(Name = "pagination", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Pagination { get; set; } 
    }
}
