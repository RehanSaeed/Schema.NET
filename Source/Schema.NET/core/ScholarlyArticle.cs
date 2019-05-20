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
    public partial class ScholarlyArticle : Article, IScholarlyArticle
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ScholarlyArticle";
    }
}
