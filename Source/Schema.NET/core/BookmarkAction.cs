namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An agent bookmarks/flags/labels/tags/marks an object.
    /// </summary>
    public partial interface IBookmarkAction : IOrganizeAction
    {
    }

    /// <summary>
    /// An agent bookmarks/flags/labels/tags/marks an object.
    /// </summary>
    [DataContract]
    public partial class BookmarkAction : OrganizeAction, IBookmarkAction, IEquatable<BookmarkAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BookmarkAction";

        /// <inheritdoc/>
        public bool Equals(BookmarkAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as BookmarkAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
