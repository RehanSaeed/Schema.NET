namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A public swimming pool.
    /// </summary>
    public partial interface IPublicSwimmingPool : ISportsActivityLocation
    {
    }

    /// <summary>
    /// A public swimming pool.
    /// </summary>
    [DataContract]
    public partial class PublicSwimmingPool : SportsActivityLocation, IPublicSwimmingPool, IEquatable<PublicSwimmingPool>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PublicSwimmingPool";

        /// <inheritdoc/>
        public bool Equals(PublicSwimmingPool other)
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
        public override bool Equals(object obj) => this.Equals(obj as PublicSwimmingPool);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
