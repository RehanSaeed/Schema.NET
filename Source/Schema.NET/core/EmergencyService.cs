namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An emergency service, such as a fire station or ER.
    /// </summary>
    public partial interface IEmergencyService : ILocalBusiness
    {
    }

    /// <summary>
    /// An emergency service, such as a fire station or ER.
    /// </summary>
    [DataContract]
    public partial class EmergencyService : LocalBusiness, IEmergencyService, IEquatable<EmergencyService>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EmergencyService";

        /// <inheritdoc/>
        public bool Equals(EmergencyService other)
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
        public override bool Equals(object obj) => this.Equals(obj as EmergencyService);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
