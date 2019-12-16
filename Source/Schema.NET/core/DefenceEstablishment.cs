namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A defence establishment, such as an army or navy base.
    /// </summary>
    public partial interface IDefenceEstablishment : IGovernmentBuilding
    {
    }

    /// <summary>
    /// A defence establishment, such as an army or navy base.
    /// </summary>
    [DataContract]
    public partial class DefenceEstablishment : GovernmentBuilding, IDefenceEstablishment, IEquatable<DefenceEstablishment>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DefenceEstablishment";

        /// <inheritdoc/>
        public bool Equals(DefenceEstablishment other)
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
        public override bool Equals(object obj) => this.Equals(obj as DefenceEstablishment);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
