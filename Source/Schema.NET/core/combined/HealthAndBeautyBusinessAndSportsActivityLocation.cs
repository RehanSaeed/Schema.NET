namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// See HealthAndBeautyBusiness, SportsActivityLocation for more information.
    /// </summary>
    public partial interface IHealthAndBeautyBusinessAndSportsActivityLocation : IHealthAndBeautyBusiness, ISportsActivityLocation
    {
    }

    /// <summary>
    /// See HealthAndBeautyBusiness, SportsActivityLocation for more information.
    /// </summary>
    [DataContract]
    public abstract partial class HealthAndBeautyBusinessAndSportsActivityLocation : LocalBusiness, IHealthAndBeautyBusinessAndSportsActivityLocation, IEquatable<HealthAndBeautyBusinessAndSportsActivityLocation>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HealthAndBeautyBusinessAndSportsActivityLocation";

        /// <inheritdoc/>
        public bool Equals(HealthAndBeautyBusinessAndSportsActivityLocation other)
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
        public override bool Equals(object obj) => this.Equals(obj as HealthAndBeautyBusinessAndSportsActivityLocation);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
