namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An agent joins an event/group with participants/friends at a location.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: Unlike RegisterAction, JoinAction refers to joining a group/team of people.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/SubscribeAction"&gt;SubscribeAction&lt;/a&gt;: Unlike SubscribeAction, JoinAction does not imply that you'll be receiving updates.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/FollowAction"&gt;FollowAction&lt;/a&gt;: Unlike FollowAction, JoinAction does not imply that you'll be polling for updates.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IJoinAction : IInteractAction
    {
        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        OneOrMany<IEvent> Events { get; set; }
    }

    /// <summary>
    /// An agent joins an event/group with participants/friends at a location.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: Unlike RegisterAction, JoinAction refers to joining a group/team of people.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/SubscribeAction"&gt;SubscribeAction&lt;/a&gt;: Unlike SubscribeAction, JoinAction does not imply that you'll be receiving updates.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/FollowAction"&gt;FollowAction&lt;/a&gt;: Unlike FollowAction, JoinAction does not imply that you'll be polling for updates.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class JoinAction : InteractAction, IJoinAction, IEquatable<JoinAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "JoinAction";

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEvent> Events { get; set; }

        /// <inheritdoc/>
        public bool Equals(JoinAction other)
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
                this.Events == other.Events &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as JoinAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Events)
            .And(base.GetHashCode());
    }
}
