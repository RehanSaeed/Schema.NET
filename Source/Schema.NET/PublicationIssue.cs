namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A part of a successively published publication such as a periodical or publication volume, often numbered, usually containing a grouping of works such as articles...
    /// </summary>
    [DataContract]
    public class PublicationIssue : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PublicationIssue";

        /// <summary>
        /// Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
        /// </summary>
        [DataMember(Name = "pagination")]
        public string Pagination { get; set; }

        /// <summary>
        /// Identifies the issue of publication; for example, "iii" or "2".
        /// </summary>
        [DataMember(Name = "issueNumber")]
        public object IssueNumber { get; protected set; }

        /// <summary>
        /// Identifies the issue of publication; for example, "iii" or "2".
        /// </summary>
        [IgnoreDataMember]
        public string IssueNumberText
        {
            get => this.IssueNumber as string;
            set => this.IssueNumber = value;
        }

        /// <summary>
        /// Identifies the issue of publication; for example, "iii" or "2".
        /// </summary>
        [IgnoreDataMember]
        public int? IssueNumberInteger
        {
            get => this.IssueNumber as int?;
            set => this.IssueNumber = value;
        }

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [DataMember(Name = "pageEnd")]
        public object PageEnd { get; protected set; }

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [IgnoreDataMember]
        public string PageEndText
        {
            get => this.PageEnd as string;
            set => this.PageEnd = value;
        }

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [IgnoreDataMember]
        public int? PageEndInteger
        {
            get => this.PageEnd as int?;
            set => this.PageEnd = value;
        }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [DataMember(Name = "pageStart")]
        public object PageStart { get; protected set; }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [IgnoreDataMember]
        public int? PageStartInteger
        {
            get => this.PageStart as int?;
            set => this.PageStart = value;
        }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [IgnoreDataMember]
        public string PageStartText
        {
            get => this.PageStart as string;
            set => this.PageStart = value;
        }
    }
}
