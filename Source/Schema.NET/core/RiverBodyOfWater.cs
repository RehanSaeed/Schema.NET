namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A river (for example, the broad majestic Shannon).
    /// </summary>
    public partial interface IRiverBodyOfWater : IBodyOfWater
    {
    }

    /// <summary>
    /// A river (for example, the broad majestic Shannon).
    /// </summary>
    [DataContract]
    public partial class RiverBodyOfWater : BodyOfWater, IRiverBodyOfWater, IEquatable<RiverBodyOfWater>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RiverBodyOfWater";

        /// <inheritdoc/>
        public bool Equals(RiverBodyOfWater other)
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
        public override bool Equals(object obj) => this.Equals(obj as RiverBodyOfWater);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
