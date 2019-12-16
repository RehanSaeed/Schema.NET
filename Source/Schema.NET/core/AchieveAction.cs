namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of accomplishing something via previous efforts. It is an instantaneous action rather than an ongoing process.
    /// </summary>
    public partial interface IAchieveAction : IAction
    {
    }

    /// <summary>
    /// The act of accomplishing something via previous efforts. It is an instantaneous action rather than an ongoing process.
    /// </summary>
    [DataContract]
    public partial class AchieveAction : Action, IAchieveAction, IEquatable<AchieveAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AchieveAction";

        /// <inheritdoc/>
        public bool Equals(AchieveAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as AchieveAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
