namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of dressing oneself in clothing.
    /// </summary>
    public partial interface IWearAction : IUseAction
    {
    }

    /// <summary>
    /// The act of dressing oneself in clothing.
    /// </summary>
    [DataContract]
    public partial class WearAction : UseAction, IWearAction, IEquatable<WearAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WearAction";

        /// <inheritdoc/>
        public bool Equals(WearAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as WearAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
