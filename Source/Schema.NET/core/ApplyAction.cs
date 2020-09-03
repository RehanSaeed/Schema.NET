namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of registering to an organization/service without the guarantee to receive it.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: Unlike RegisterAction, ApplyAction has no guarantees that the application will be accepted.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IApplyAction : IOrganizeAction
    {
    }

    /// <summary>
    /// The act of registering to an organization/service without the guarantee to receive it.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: Unlike RegisterAction, ApplyAction has no guarantees that the application will be accepted.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class ApplyAction : OrganizeAction, IApplyAction, IEquatable<ApplyAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ApplyAction";

        /// <inheritdoc/>
        public bool Equals(ApplyAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as ApplyAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
