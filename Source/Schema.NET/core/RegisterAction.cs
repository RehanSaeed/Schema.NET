namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of registering to be a user of a service, product or web page.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/JoinAction"&gt;JoinAction&lt;/a&gt;: Unlike JoinAction, RegisterAction implies you are registering to be a user of a service, &lt;em&gt;not&lt;/em&gt; a group/team of people.&lt;/li&gt;
    /// &lt;li&gt;[FollowAction]]: Unlike FollowAction, RegisterAction doesn't imply that the agent is expecting to poll for updates from the object.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/SubscribeAction"&gt;SubscribeAction&lt;/a&gt;: Unlike SubscribeAction, RegisterAction doesn't imply that the agent is expecting updates from the object.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IRegisterAction : IInteractAction
    {
    }

    /// <summary>
    /// The act of registering to be a user of a service, product or web page.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/JoinAction"&gt;JoinAction&lt;/a&gt;: Unlike JoinAction, RegisterAction implies you are registering to be a user of a service, &lt;em&gt;not&lt;/em&gt; a group/team of people.&lt;/li&gt;
    /// &lt;li&gt;[FollowAction]]: Unlike FollowAction, RegisterAction doesn't imply that the agent is expecting to poll for updates from the object.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/SubscribeAction"&gt;SubscribeAction&lt;/a&gt;: Unlike SubscribeAction, RegisterAction doesn't imply that the agent is expecting updates from the object.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class RegisterAction : InteractAction, IRegisterAction, IEquatable<RegisterAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RegisterAction";

        /// <inheritdoc/>
        public bool Equals(RegisterAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as RegisterAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
