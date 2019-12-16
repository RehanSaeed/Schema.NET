namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A day spa.
    /// </summary>
    public partial interface IDaySpa : IHealthAndBeautyBusiness
    {
    }

    /// <summary>
    /// A day spa.
    /// </summary>
    [DataContract]
    public partial class DaySpa : HealthAndBeautyBusiness, IDaySpa, IEquatable<DaySpa>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DaySpa";

        /// <inheritdoc/>
        public bool Equals(DaySpa other)
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
        public override bool Equals(object obj) => this.Equals(obj as DaySpa);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
