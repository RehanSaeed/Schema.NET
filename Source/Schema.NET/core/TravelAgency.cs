namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A travel agency.
    /// </summary>
    public partial interface ITravelAgency : ILocalBusiness
    {
    }

    /// <summary>
    /// A travel agency.
    /// </summary>
    [DataContract]
    public partial class TravelAgency : LocalBusiness, ITravelAgency, IEquatable<TravelAgency>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TravelAgency";

        /// <inheritdoc/>
        public bool Equals(TravelAgency other)
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
        public override bool Equals(object obj) => this.Equals(obj as TravelAgency);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
