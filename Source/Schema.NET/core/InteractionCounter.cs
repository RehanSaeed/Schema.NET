namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A summary of how users have interacted with this CreativeWork. In most cases, authors will use a subtype to specify the specific type of interaction.
    /// </summary>
    public partial interface IInteractionCounter : IStructuredValue
    {
        /// <summary>
        /// The WebSite or SoftwareApplication where the interactions took place.
        /// </summary>
        Values<ISoftwareApplication, IWebSite> InteractionService { get; set; }

        /// <summary>
        /// The Action representing the type of interaction. For up votes, +1s, etc. use &lt;a class="localLink" href="https://schema.org/LikeAction"&gt;LikeAction&lt;/a&gt;. For down votes use &lt;a class="localLink" href="https://schema.org/DislikeAction"&gt;DislikeAction&lt;/a&gt;. Otherwise, use the most specific Action.
        /// </summary>
        OneOrMany<IAction> InteractionType { get; set; }

        /// <summary>
        /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication.
        /// </summary>
        OneOrMany<int?> UserInteractionCount { get; set; }
    }

    /// <summary>
    /// A summary of how users have interacted with this CreativeWork. In most cases, authors will use a subtype to specify the specific type of interaction.
    /// </summary>
    [DataContract]
    public partial class InteractionCounter : StructuredValue, IInteractionCounter, IEquatable<InteractionCounter>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InteractionCounter";

        /// <summary>
        /// The WebSite or SoftwareApplication where the interactions took place.
        /// </summary>
        [DataMember(Name = "interactionService", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ISoftwareApplication, IWebSite> InteractionService { get; set; }

        /// <summary>
        /// The Action representing the type of interaction. For up votes, +1s, etc. use &lt;a class="localLink" href="https://schema.org/LikeAction"&gt;LikeAction&lt;/a&gt;. For down votes use &lt;a class="localLink" href="https://schema.org/DislikeAction"&gt;DislikeAction&lt;/a&gt;. Otherwise, use the most specific Action.
        /// </summary>
        [DataMember(Name = "interactionType", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAction> InteractionType { get; set; }

        /// <summary>
        /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication.
        /// </summary>
        [DataMember(Name = "userInteractionCount", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> UserInteractionCount { get; set; }

        /// <inheritdoc/>
        public bool Equals(InteractionCounter other)
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
                this.InteractionService == other.InteractionService &&
                this.InteractionType == other.InteractionType &&
                this.UserInteractionCount == other.UserInteractionCount &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as InteractionCounter);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.InteractionService)
            .And(this.InteractionType)
            .And(this.UserInteractionCount)
            .And(base.GetHashCode());
    }
}
