namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of notifying someone that a future event/action is going to happen as expected.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/CancelAction"&gt;CancelAction&lt;/a&gt;: The antonym of ConfirmAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IConfirmAction : IInformAction
    {
    }

    /// <summary>
    /// The act of notifying someone that a future event/action is going to happen as expected.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/CancelAction"&gt;CancelAction&lt;/a&gt;: The antonym of ConfirmAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class ConfirmAction : InformAction, IConfirmAction, IEquatable<ConfirmAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ConfirmAction";

        /// <inheritdoc/>
        public bool Equals(ConfirmAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as ConfirmAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
