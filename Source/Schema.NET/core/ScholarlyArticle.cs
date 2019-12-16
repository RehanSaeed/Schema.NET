namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A scholarly article.
    /// </summary>
    public partial interface IScholarlyArticle : IArticle
    {
    }

    /// <summary>
    /// A scholarly article.
    /// </summary>
    [DataContract]
    public partial class ScholarlyArticle : Article, IScholarlyArticle, IEquatable<ScholarlyArticle>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ScholarlyArticle";

        /// <inheritdoc/>
        public bool Equals(ScholarlyArticle other)
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
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as ScholarlyArticle);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
