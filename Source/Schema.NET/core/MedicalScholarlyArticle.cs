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
        OneOrMany<string> PublicationType { get; set; }
    }

    /// <summary>
    /// A scholarly article in the medical domain.
    /// </summary>
    [DataContract]
    public partial class MedicalScholarlyArticle : ScholarlyArticle, IMedicalScholarlyArticle, IEquatable<MedicalScholarlyArticle>
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PublicationType { get; set; }

        /// <inheritdoc/>
        public bool Equals(MedicalScholarlyArticle other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.PublicationType == other.PublicationType &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MedicalScholarlyArticle);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.PublicationType)
            .And(base.GetHashCode());
    }
}
