namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of allocating an action/event/task to some destination (someone or something).
    /// </summary>
    public partial interface IAssignAction : IAllocateAction
    {
    }

    /// <summary>
    /// The act of allocating an action/event/task to some destination (someone or something).
    /// </summary>
    [DataContract]
    public partial class AssignAction : AllocateAction, IAssignAction, IEquatable<AssignAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AssignAction";

        /// <inheritdoc/>
        public bool Equals(AssignAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as AssignAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
