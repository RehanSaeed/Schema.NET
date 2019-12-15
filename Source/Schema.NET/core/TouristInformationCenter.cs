namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A tourist information center.
    /// </summary>
    public partial interface ITouristInformationCenter : ILocalBusiness
    {
    }

    /// <summary>
    /// A tourist information center.
    /// </summary>
    [DataContract]
    public partial class TouristInformationCenter : LocalBusiness, ITouristInformationCenter, IEquatable<TouristInformationCenter>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TouristInformationCenter";

        /// <inheritdoc/>
        public bool Equals(TouristInformationCenter other)
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
        public override bool Equals(object obj) => this.Equals(obj as TouristInformationCenter);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
