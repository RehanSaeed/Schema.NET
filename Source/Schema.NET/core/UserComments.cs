namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

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
        [DataMember(Name = "commentText", Order = 305)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? CommentText { get; set; }

        /// <summary>
        /// The time at which the UserComment was made.
        /// </summary>
        [DataMember(Name = "commentTime", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? CommentTime { get; set; }

        /// <summary>
        /// The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.
        /// </summary>
        [DataMember(Name = "creator", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person, Organization>? Creator { get; set; }

        /// <summary>
        /// Specifies the CreativeWork associated with the UserComment.
        /// </summary>
        [DataMember(Name = "discusses", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? Discusses { get; set; }

        /// <summary>
        /// The URL at which a reply may be posted to the specified UserComment.
        /// </summary>
        [DataMember(Name = "replyToUrl", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? ReplyToUrl { get; set; }
    }
}
