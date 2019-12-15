namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A motorcycle dealer.
    /// </summary>
    public partial interface IMotorcycleDealer : IAutomotiveBusiness
    {
    }

    /// <summary>
    /// A motorcycle dealer.
    /// </summary>
    [DataContract]
    public partial class MotorcycleDealer : AutomotiveBusiness, IMotorcycleDealer, IEquatable<MotorcycleDealer>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MotorcycleDealer";

        /// <inheritdoc/>
        public bool Equals(MotorcycleDealer other)
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
        public override bool Equals(object obj) => this.Equals(obj as MotorcycleDealer);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
