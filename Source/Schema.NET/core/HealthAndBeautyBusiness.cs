namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Health and beauty.
    /// </summary>
    public partial interface IHealthAndBeautyBusiness : ILocalBusiness
    {
    }

    /// <summary>
    /// Health and beauty.
    /// </summary>
    [DataContract]
    public partial class HealthAndBeautyBusiness : LocalBusiness, IHealthAndBeautyBusiness, IEquatable<HealthAndBeautyBusiness>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HealthAndBeautyBusiness";

        /// <inheritdoc/>
        public bool Equals(HealthAndBeautyBusiness other)
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
        public override bool Equals(object obj) => this.Equals(obj as HealthAndBeautyBusiness);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
