namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An agent leaves an event / group with participants/friends at a location.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/JoinAction"&gt;JoinAction&lt;/a&gt;: The antonym of LeaveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/UnRegisterAction"&gt;UnRegisterAction&lt;/a&gt;: Unlike UnRegisterAction, LeaveAction implies leaving a group/team of people rather than a service.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface ILeaveAction : IInteractAction
    {
        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        OneOrMany<IEvent> Events { get; set; }
    }

    /// <summary>
    /// An agent leaves an event / group with participants/friends at a location.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/JoinAction"&gt;JoinAction&lt;/a&gt;: The antonym of LeaveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/UnRegisterAction"&gt;UnRegisterAction&lt;/a&gt;: Unlike UnRegisterAction, LeaveAction implies leaving a group/team of people rather than a service.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class LeaveAction : InteractAction, ILeaveAction, IEquatable<LeaveAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LeaveAction";

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEvent> Events { get; set; }

        /// <inheritdoc/>
        public bool Equals(LeaveAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as LeaveAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Events)
            .And(base.GetHashCode());
    }
}
