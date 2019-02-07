namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A scholarly article in the medical domain.
    /// </summary>
    [DataContract]
    public partial class MedicalScholarlyArticle : ScholarlyArticle
    {
        public interface IPublicationType : IValue {}
        public interface IPublicationType<T> : IPublicationType { new T Value { get; } }
        public class OneOrManyPublicationType : OneOrMany<IPublicationType>
        {
            public OneOrManyPublicationType(IPublicationType item) : base(item) { }
            public OneOrManyPublicationType(IEnumerable<IPublicationType> items) : base(items) { }
            public static implicit operator OneOrManyPublicationType (string value) { return new OneOrManyPublicationType (new PublicationTypestring (value)); }
            public static implicit operator OneOrManyPublicationType (string[] values) { return new OneOrManyPublicationType (values.Select(v => (IPublicationType) new PublicationTypestring (v))); }
            public static implicit operator OneOrManyPublicationType (List<string> values) { return new OneOrManyPublicationType (values.Select(v => (IPublicationType) new PublicationTypestring (v))); }
        }
        public struct PublicationTypestring : IPublicationType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PublicationTypestring (string value) { Value = value; }
            public static implicit operator PublicationTypestring (string value) { return new PublicationTypestring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalScholarlyArticle";

        /// <summary>
        /// The type of the medical article, taken from the US NLM MeSH publication type catalog. See also &lt;a href="http://www.nlm.nih.gov/mesh/pubtypes.html"&gt;MeSH documentation&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "publicationType", Order = 406)]
        public OneOrManyPublicationType PublicationType { get; set; }
    }
}
