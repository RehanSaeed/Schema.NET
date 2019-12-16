namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A service for a vehicle for hire with a driver for local travel. Fares are usually calculated based on distance traveled.
    /// </summary>
    public partial interface ITaxiService : IService
    {
    }

    /// <summary>
    /// A service for a vehicle for hire with a driver for local travel. Fares are usually calculated based on distance traveled.
    /// </summary>
    [DataContract]
    public partial class TaxiService : Service, ITaxiService, IEquatable<TaxiService>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TaxiService";

        /// <inheritdoc/>
        public bool Equals(TaxiService other)
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
        public override bool Equals(object obj) => this.Equals(obj as TaxiService);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
