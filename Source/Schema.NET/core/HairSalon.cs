namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A hair salon.
    /// </summary>
    public partial interface IHairSalon : IHealthAndBeautyBusiness
    {
    }

    /// <summary>
    /// A hair salon.
    /// </summary>
    [DataContract]
    public partial class HairSalon : HealthAndBeautyBusiness, IHairSalon, IEquatable<HairSalon>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HairSalon";

        /// <inheritdoc/>
        public bool Equals(HairSalon other)
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
        public override bool Equals(object obj) => this.Equals(obj as HairSalon);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
