namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A bowling alley.
    /// </summary>
    public partial interface IBowlingAlley : ISportsActivityLocation
    {
    }

    /// <summary>
    /// A bowling alley.
    /// </summary>
    [DataContract]
    public partial class BowlingAlley : SportsActivityLocation, IBowlingAlley, IEquatable<BowlingAlley>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BowlingAlley";

        /// <inheritdoc/>
        public bool Equals(BowlingAlley other)
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
        public override bool Equals(object obj) => this.Equals(obj as BowlingAlley);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
