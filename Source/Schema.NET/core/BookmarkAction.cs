namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An agent bookmarks/flags/labels/tags/marks an object.
    /// </summary>
    [DataContract]
    public partial class BookmarkAction : OrganizeAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BookmarkAction";
    }
}
