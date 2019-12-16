namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of interacting with another person or organization.
    /// </summary>
    public partial interface IInteractAction : IAction
    {
    }

    /// <summary>
    /// The act of interacting with another person or organization.
    /// </summary>
    [DataContract]
    public partial class InteractAction : Action, IInteractAction, IEquatable<InteractAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InteractAction";

        /// <inheritdoc/>
        public bool Equals(InteractAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as InteractAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
