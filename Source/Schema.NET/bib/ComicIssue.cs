namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Individual comic issues are serially published as
    ///     part of a larger series...
    /// </summary>
    [DataContract]
    public partial class ComicIssue : PublicationIssue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ComicIssue";
    }
}
