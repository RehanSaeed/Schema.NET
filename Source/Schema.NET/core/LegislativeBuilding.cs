namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A legislative building&amp;#x2014;for example, the state capitol.
    /// </summary>
    public partial interface ILegislativeBuilding : IGovernmentBuilding
    {
    }

    /// <summary>
    /// A legislative building&amp;#x2014;for example, the state capitol.
    /// </summary>
    [DataContract]
    public partial class LegislativeBuilding : GovernmentBuilding, ILegislativeBuilding, IEquatable<LegislativeBuilding>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LegislativeBuilding";

        /// <inheritdoc/>
        public bool Equals(LegislativeBuilding other)
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
        public override bool Equals(object obj) => this.Equals(obj as LegislativeBuilding);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
