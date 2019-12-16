namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of expressing a negative sentiment about the object. An agent dislikes an object (a proposition, topic or theme) with participants.
    /// </summary>
    public partial interface IDislikeAction : IReactAction
    {
    }

    /// <summary>
    /// The act of expressing a negative sentiment about the object. An agent dislikes an object (a proposition, topic or theme) with participants.
    /// </summary>
    [DataContract]
    public partial class DislikeAction : ReactAction, IDislikeAction, IEquatable<DislikeAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DislikeAction";

        /// <inheritdoc/>
        public bool Equals(DislikeAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as DislikeAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
