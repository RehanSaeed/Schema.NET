namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A blog.
    /// </summary>
    [DataContract]
    public partial class Blog : CreativeWork
    {
        public interface IBlogPost : IValue {}
        public interface IBlogPost<T> : IBlogPost { new T Value { get; } }
        public class OneOrManyBlogPost : OneOrMany<IBlogPost>
        {
            public OneOrManyBlogPost(IBlogPost item) : base(item) { }
            public OneOrManyBlogPost(IEnumerable<IBlogPost> items) : base(items) { }
            public static implicit operator OneOrManyBlogPost (BlogPosting value) { return new OneOrManyBlogPost (new BlogPostBlogPosting (value)); }
            public static implicit operator OneOrManyBlogPost (BlogPosting[] values) { return new OneOrManyBlogPost (values.Select(v => (IBlogPost) new BlogPostBlogPosting (v))); }
            public static implicit operator OneOrManyBlogPost (List<BlogPosting> values) { return new OneOrManyBlogPost (values.Select(v => (IBlogPost) new BlogPostBlogPosting (v))); }
        }
        public struct BlogPostBlogPosting : IBlogPost<BlogPosting>
        {
            object IValue.Value => this.Value;
            public BlogPosting Value { get; }
            public BlogPostBlogPosting (BlogPosting value) { Value = value; }
            public static implicit operator BlogPostBlogPosting (BlogPosting value) { return new BlogPostBlogPosting (value); }
        }

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
        public override string Type => "Blog";

        /// <summary>
        /// A posting that is part of this blog.
        /// </summary>
        [DataMember(Name = "blogPost", Order = 206)]
        public OneOrManyBlogPost BlogPost { get; set; }

        /// <summary>
        /// The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.
        /// </summary>
        [DataMember(Name = "issn", Order = 207)]
        public OneOrManyIssn Issn { get; set; }
    }
}
