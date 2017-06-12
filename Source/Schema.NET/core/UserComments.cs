namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages...
    /// </summary>
    [DataContract]
    public partial class UserComments : UserInteraction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "UserComments";

        /// <summary>
        /// The text of the UserComment.
        /// </summary>
        [DataMember(Name = "commentText", Order = 2)]
        public string CommentText { get; set; }

        /// <summary>
        /// The time at which the UserComment was made.
        /// </summary>
        [DataMember(Name = "commentTime", Order = 3)]
        public DateTimeOffset? CommentTime { get; set; }

        /// <summary>
        /// The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.
        /// </summary>
        [DataMember(Name = "creator", Order = 4)]
        public object Creator { get; protected set; }

        /// <summary>
        /// The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.
        /// </summary>
        [IgnoreDataMember]
        public Person CreatorPerson
        {
            get => this.Creator as Person;
            set => this.Creator = value;
        }

        /// <summary>
        /// The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.
        /// </summary>
        [IgnoreDataMember]
        public Organization CreatorOrganization
        {
            get => this.Creator as Organization;
            set => this.Creator = value;
        }

        /// <summary>
        /// Specifies the CreativeWork associated with the UserComment.
        /// </summary>
        [DataMember(Name = "discusses", Order = 5)]
        public CreativeWork Discusses { get; set; }

        /// <summary>
        /// The URL at which a reply may be posted to the specified UserComment.
        /// </summary>
        [DataMember(Name = "replyToUrl", Order = 6)]
        public Uri ReplyToUrl { get; set; }
    }
}
