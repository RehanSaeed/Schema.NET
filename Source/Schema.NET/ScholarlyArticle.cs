namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A scholarly article.
    /// </summary>
    [DataContract]
    public class ScholarlyArticle : Article
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ScholarlyArticle";
    }
}
