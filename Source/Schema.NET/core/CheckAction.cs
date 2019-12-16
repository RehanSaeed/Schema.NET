namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An agent inspects, determines, investigates, inquires, or examines an object's accuracy, quality, condition, or state.
    /// </summary>
    public partial interface ICheckAction : IFindAction
    {
    }

    /// <summary>
    /// An agent inspects, determines, investigates, inquires, or examines an object's accuracy, quality, condition, or state.
    /// </summary>
    [DataContract]
    public partial class CheckAction : FindAction, ICheckAction, IEquatable<CheckAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CheckAction";

        /// <inheritdoc/>
        public bool Equals(CheckAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as CheckAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
