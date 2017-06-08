namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages...
    /// </summary>
    [DataContract]
    public class UserComments : UserInteraction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "UserComments";

        /// <summary>
        /// The text of the UserComment.
        /// </summary>
        [DataMember(Name = "commentText")]
        public string CommentText { get; set; }

        /// <summary>
        /// Specifies the CreativeWork associated with the UserComment.
        /// </summary>
        [DataMember(Name = "discusses")]
        public CreativeWork Discusses { get; set; }

        /// <summary>
        /// The time at which the UserComment was made.
        /// </summary>
        [DataMember(Name = "commentTime")]
        public DateTimeOffset CommentTime { get; set; }

        /// <summary>
        /// The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.
        /// </summary>
        [DataMember(Name = "creator")]
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
        /// The URL at which a reply may be posted to the specified UserComment.
        /// </summary>
        [DataMember(Name = "replyToUrl")]
        public Uri ReplyToUrl { get; set; }
    }
}
