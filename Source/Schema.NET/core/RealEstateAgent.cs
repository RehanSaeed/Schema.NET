namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A real-estate agent.
    /// </summary>
    public partial interface IRealEstateAgent : ILocalBusiness
    {
    }

    /// <summary>
    /// A real-estate agent.
    /// </summary>
    [DataContract]
    public partial class RealEstateAgent : LocalBusiness, IRealEstateAgent, IEquatable<RealEstateAgent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RealEstateAgent";

        /// <inheritdoc/>
        public bool Equals(RealEstateAgent other)
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
        public override bool Equals(object obj) => this.Equals(obj as RealEstateAgent);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
