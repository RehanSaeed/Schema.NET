namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of un-registering from a service.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: antonym of UnRegisterAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/LeaveAction"&gt;LeaveAction&lt;/a&gt;: Unlike LeaveAction, UnRegisterAction implies that you are unregistering from a service you werer previously registered, rather than leaving a team/group of people.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IUnRegisterAction : IInteractAction
    {
    }

    /// <summary>
    /// The act of un-registering from a service.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: antonym of UnRegisterAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/LeaveAction"&gt;LeaveAction&lt;/a&gt;: Unlike LeaveAction, UnRegisterAction implies that you are unregistering from a service you werer previously registered, rather than leaving a team/group of people.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class UnRegisterAction : InteractAction, IUnRegisterAction, IEquatable<UnRegisterAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "UnRegisterAction";

        /// <inheritdoc/>
        public bool Equals(UnRegisterAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as UnRegisterAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
