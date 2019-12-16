namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of reaching a draw in a competitive activity.
    /// </summary>
    public partial interface ITieAction : IAchieveAction
    {
    }

    /// <summary>
    /// The act of reaching a draw in a competitive activity.
    /// </summary>
    [DataContract]
    public partial class TieAction : AchieveAction, ITieAction, IEquatable<TieAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TieAction";

        /// <inheritdoc/>
        public bool Equals(TieAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as TieAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
