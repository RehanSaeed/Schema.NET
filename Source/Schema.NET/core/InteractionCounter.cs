namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A summary of how users have interacted with this CreativeWork...
    /// </summary>
    [DataContract]
    public partial class InteractionCounter : StructuredValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InteractionCounter";

        /// <summary>
        /// The WebSite or SoftwareApplication where the interactions took place.
        /// </summary>
        [DataMember(Name = "interactionService", Order = 2)]
        public object InteractionService { get; protected set; }

        /// <summary>
        /// The WebSite or SoftwareApplication where the interactions took place.
        /// </summary>
        [IgnoreDataMember]
        public SoftwareApplication InteractionServiceSoftwareApplication
        {
            get => this.InteractionService as SoftwareApplication;
            set => this.InteractionService = value;
        }

        /// <summary>
        /// The WebSite or SoftwareApplication where the interactions took place.
        /// </summary>
        [IgnoreDataMember]
        public WebSite InteractionServiceWebSite
        {
            get => this.InteractionService as WebSite;
            set => this.InteractionService = value;
        }

        /// <summary>
        /// The Action representing the type of interaction. For up votes, +1s, etc. use &lt;a class="localLink" href="http://schema.org/LikeAction"&gt;LikeAction&lt;/a&gt;. For down votes use &lt;a class="localLink" href="http://schema.org/DislikeAction"&gt;DislikeAction&lt;/a&gt;. Otherwise, use the most specific Action.
        /// </summary>
        [DataMember(Name = "interactionType", Order = 3)]
        public Action InteractionType { get; set; }

        /// <summary>
        /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication.
        /// </summary>
        [DataMember(Name = "userInteractionCount", Order = 4)]
        public int? UserInteractionCount { get; set; }
    }
}
