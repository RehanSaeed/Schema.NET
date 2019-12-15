namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A city hall.
    /// </summary>
    public partial interface ICityHall : IGovernmentBuilding
    {
    }

    /// <summary>
    /// A city hall.
    /// </summary>
    [DataContract]
    public partial class CityHall : GovernmentBuilding, ICityHall, IEquatable<CityHall>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CityHall";

        /// <inheritdoc/>
        public bool Equals(CityHall other)
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
        public override bool Equals(object obj) => this.Equals(obj as CityHall);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
