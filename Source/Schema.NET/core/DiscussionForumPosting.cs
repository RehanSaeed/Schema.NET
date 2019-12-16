namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A posting to a discussion forum.
    /// </summary>
    public partial interface IDiscussionForumPosting : ISocialMediaPosting
    {
    }

    /// <summary>
    /// A posting to a discussion forum.
    /// </summary>
    [DataContract]
    public partial class DiscussionForumPosting : SocialMediaPosting, IDiscussionForumPosting, IEquatable<DiscussionForumPosting>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DiscussionForumPosting";

        /// <inheritdoc/>
        public bool Equals(DiscussionForumPosting other)
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
        public override bool Equals(object obj) => this.Equals(obj as DiscussionForumPosting);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
