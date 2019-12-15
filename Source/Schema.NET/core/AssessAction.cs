namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of forming one's opinion, reaction or sentiment.
    /// </summary>
    public partial interface IAssessAction : IAction
    {
    }

    /// <summary>
    /// The act of forming one's opinion, reaction or sentiment.
    /// </summary>
    [DataContract]
    public partial class AssessAction : Action, IAssessAction, IEquatable<AssessAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AssessAction";

        /// <inheritdoc/>
        public bool Equals(AssessAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as AssessAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
