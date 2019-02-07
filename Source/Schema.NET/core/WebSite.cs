namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A WebSite is a set of related web pages and other items typically served from a single web domain and accessible via URLs.
    /// </summary>
    [DataContract]
    public partial class WebSite : CreativeWork
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

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WebSite";

        /// <summary>
        /// The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.
        /// </summary>
        [DataMember(Name = "issn", Order = 206)]
        public OneOrManyIssn Issn { get; set; }
    }
}
