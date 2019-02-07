namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of searching for an object.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FindAction"&gt;FindAction&lt;/a&gt;: SearchAction generally leads to a FindAction, but not necessarily.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class SearchAction : Action
    {
        public interface IQuery : IValue {}
        public interface IQuery<T> : IQuery { new T Value { get; } }
        public class OneOrManyQuery : OneOrMany<IQuery>
        {
            public OneOrManyQuery(IQuery item) : base(item) { }
            public OneOrManyQuery(IEnumerable<IQuery> items) : base(items) { }
            public static implicit operator OneOrManyQuery (string value) { return new OneOrManyQuery (new Querystring (value)); }
            public static implicit operator OneOrManyQuery (string[] values) { return new OneOrManyQuery (values.Select(v => (IQuery) new Querystring (v))); }
            public static implicit operator OneOrManyQuery (List<string> values) { return new OneOrManyQuery (values.Select(v => (IQuery) new Querystring (v))); }
        }
        public struct Querystring : IQuery<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Querystring (string value) { Value = value; }
            public static implicit operator Querystring (string value) { return new Querystring (value); }
        }

        public interface IQueryInput : IValue {}
        public interface IQueryInput<T> : IQueryInput { new T Value { get; } }
        public class OneOrManyQueryInput : OneOrMany<IQueryInput>
        {
            public OneOrManyQueryInput(IQueryInput item) : base(item) { }
            public OneOrManyQueryInput(IEnumerable<IQueryInput> items) : base(items) { }
            public static implicit operator OneOrManyQueryInput (string value) { return new OneOrManyQueryInput (new QueryInputstring (value)); }
            public static implicit operator OneOrManyQueryInput (string[] values) { return new OneOrManyQueryInput (values.Select(v => (IQueryInput) new QueryInputstring (v))); }
            public static implicit operator OneOrManyQueryInput (List<string> values) { return new OneOrManyQueryInput (values.Select(v => (IQueryInput) new QueryInputstring (v))); }
            public static implicit operator OneOrManyQueryInput (PropertyValueSpecification value) { return new OneOrManyQueryInput (new QueryInputPropertyValueSpecification (value)); }
            public static implicit operator OneOrManyQueryInput (PropertyValueSpecification[] values) { return new OneOrManyQueryInput (values.Select(v => (IQueryInput) new QueryInputPropertyValueSpecification (v))); }
            public static implicit operator OneOrManyQueryInput (List<PropertyValueSpecification> values) { return new OneOrManyQueryInput (values.Select(v => (IQueryInput) new QueryInputPropertyValueSpecification (v))); }
        }
        public struct QueryInputstring : IQueryInput<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public QueryInputstring (string value) { Value = value; }
            public static implicit operator QueryInputstring (string value) { return new QueryInputstring (value); }
        }
        public struct QueryInputPropertyValueSpecification : IQueryInput<PropertyValueSpecification>
        {
            object IValue.Value => this.Value;
            public PropertyValueSpecification Value { get; }
            public QueryInputPropertyValueSpecification (PropertyValueSpecification value) { Value = value; }
            public static implicit operator QueryInputPropertyValueSpecification (PropertyValueSpecification value) { return new QueryInputPropertyValueSpecification (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SearchAction";

        /// <summary>
        /// A sub property of instrument. The query used on this action.
        /// </summary>
        [DataMember(Name = "query", Order = 206)]
        public OneOrManyQuery Query { get; set; }

        /// <summary>
        /// Gets or sets the query input search parameter.
        /// </summary>
        [DataMember(Name = "query-input", Order = 207)]
        public OneOrManyQueryInput QueryInput { get; set; }
    }
}
