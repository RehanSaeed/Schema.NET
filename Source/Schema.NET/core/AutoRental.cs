namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A car rental business.
    /// </summary>
    public partial interface IAutoRental : IAutomotiveBusiness
    {
    }

    /// <summary>
    /// A car rental business.
    /// </summary>
    [DataContract]
    public partial class AutoRental : AutomotiveBusiness, IAutoRental, IEquatable<AutoRental>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AutoRental";

        /// <inheritdoc/>
        public bool Equals(AutoRental other)
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
        public override bool Equals(object obj) => this.Equals(obj as AutoRental);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
