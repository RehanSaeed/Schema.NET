namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A scholarly article in the medical domain.
    /// </summary>
    public partial interface IMedicalScholarlyArticle : IScholarlyArticle
    {
        /// <summary>
        /// The type of the medical article, taken from the US NLM MeSH publication type catalog. See also &lt;a href="http://www.nlm.nih.gov/mesh/pubtypes.html"&gt;MeSH documentation&lt;/a&gt;.
        /// </summary>
        OneOrMany<string>? PublicationType { get; set; }
    }

    /// <summary>
    /// A scholarly article in the medical domain.
    /// </summary>
    [DataContract]
    public partial class MedicalScholarlyArticle : ScholarlyArticle, IMedicalScholarlyArticle
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalScholarlyArticle";

        /// <summary>
        /// The type of the medical article, taken from the US NLM MeSH publication type catalog. See also &lt;a href="http://www.nlm.nih.gov/mesh/pubtypes.html"&gt;MeSH documentation&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "publicationType", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? PublicationType { get; set; }
    }
}
