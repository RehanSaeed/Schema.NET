namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Individual comic issues are serially published as
    ///     part of a larger series...
    /// </summary>
    [DataContract]
    public class ComicIssue : PublicationIssue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ComicIssue";
    }
}
