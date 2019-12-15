namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A government building.
    /// </summary>
    public partial interface IGovernmentBuilding : ICivicStructure
    {
    }

    /// <summary>
    /// A government building.
    /// </summary>
    [DataContract]
    public partial class GovernmentBuilding : CivicStructure, IGovernmentBuilding, IEquatable<GovernmentBuilding>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GovernmentBuilding";

        /// <inheritdoc/>
        public bool Equals(GovernmentBuilding other)
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
        public override bool Equals(object obj) => this.Equals(obj as GovernmentBuilding);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
