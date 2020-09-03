namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of forming a personal connection with someone/something (object) unidirectionally/asymmetrically to get updates polled from.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/BefriendAction"&gt;BefriendAction&lt;/a&gt;: Unlike BefriendAction, FollowAction implies that the connection is &lt;em&gt;not&lt;/em&gt; necessarily reciprocal.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/SubscribeAction"&gt;SubscribeAction&lt;/a&gt;: Unlike SubscribeAction, FollowAction implies that the follower acts as an active agent constantly/actively polling for updates.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: Unlike RegisterAction, FollowAction implies that the agent is interested in continuing receiving updates from the object.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/JoinAction"&gt;JoinAction&lt;/a&gt;: Unlike JoinAction, FollowAction implies that the agent is interested in getting updates from the object.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/TrackAction"&gt;TrackAction&lt;/a&gt;: Unlike TrackAction, FollowAction refers to the polling of updates of all aspects of animate objects rather than the location of inanimate objects (e.g. you track a package, but you don't follow it).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IFollowAction : IInteractAction
    {
        /// <summary>
        /// A sub property of object. The person or organization being followed.
        /// </summary>
        Values<IOrganization, IPerson> Followee { get; set; }
    }

    /// <summary>
    /// The act of forming a personal connection with someone/something (object) unidirectionally/asymmetrically to get updates polled from.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/BefriendAction"&gt;BefriendAction&lt;/a&gt;: Unlike BefriendAction, FollowAction implies that the connection is &lt;em&gt;not&lt;/em&gt; necessarily reciprocal.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/SubscribeAction"&gt;SubscribeAction&lt;/a&gt;: Unlike SubscribeAction, FollowAction implies that the follower acts as an active agent constantly/actively polling for updates.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: Unlike RegisterAction, FollowAction implies that the agent is interested in continuing receiving updates from the object.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/JoinAction"&gt;JoinAction&lt;/a&gt;: Unlike JoinAction, FollowAction implies that the agent is interested in getting updates from the object.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/TrackAction"&gt;TrackAction&lt;/a&gt;: Unlike TrackAction, FollowAction refers to the polling of updates of all aspects of animate objects rather than the location of inanimate objects (e.g. you track a package, but you don't follow it).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class FollowAction : InteractAction, IFollowAction, IEquatable<FollowAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FollowAction";

        /// <summary>
        /// A sub property of object. The person or organization being followed.
        /// </summary>
        [DataMember(Name = "followee", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Followee { get; set; }

        /// <inheritdoc/>
        public bool Equals(FollowAction other)
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
                this.Followee == other.Followee &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as FollowAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Followee)
            .And(base.GetHashCode());
    }
}
