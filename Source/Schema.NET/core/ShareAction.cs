namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of distributing content to people for their amusement or edification.
    /// </summary>
    public partial interface IShareAction : ICommunicateAction
    {
    }

    /// <summary>
    /// The act of distributing content to people for their amusement or edification.
    /// </summary>
    [DataContract]
    public partial class ShareAction : CommunicateAction, IShareAction, IEquatable<ShareAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ShareAction";

        /// <inheritdoc/>
        public bool Equals(ShareAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as ShareAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
