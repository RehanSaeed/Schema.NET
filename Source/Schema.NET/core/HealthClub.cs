namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A health club.
    /// </summary>
    public partial interface IHealthClub : IHealthAndBeautyBusinessAndSportsActivityLocation
    {
    }

    /// <summary>
    /// A health club.
    /// </summary>
    [DataContract]
    public partial class HealthClub : HealthAndBeautyBusinessAndSportsActivityLocation, IHealthClub, IEquatable<HealthClub>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HealthClub";

        /// <inheritdoc/>
        public bool Equals(HealthClub other)
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
        public override bool Equals(object obj) => this.Equals(obj as HealthClub);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
