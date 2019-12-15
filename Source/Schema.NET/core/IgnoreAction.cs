namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of intentionally disregarding the object. An agent ignores an object.
    /// </summary>
    public partial interface IIgnoreAction : IAssessAction
    {
    }

    /// <summary>
    /// The act of intentionally disregarding the object. An agent ignores an object.
    /// </summary>
    [DataContract]
    public partial class IgnoreAction : AssessAction, IIgnoreAction, IEquatable<IgnoreAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "IgnoreAction";

        /// <inheritdoc/>
        public bool Equals(IgnoreAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as IgnoreAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
