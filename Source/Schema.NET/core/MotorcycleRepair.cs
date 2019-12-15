namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A motorcycle repair shop.
    /// </summary>
    public partial interface IMotorcycleRepair : IAutomotiveBusiness
    {
    }

    /// <summary>
    /// A motorcycle repair shop.
    /// </summary>
    [DataContract]
    public partial class MotorcycleRepair : AutomotiveBusiness, IMotorcycleRepair, IEquatable<MotorcycleRepair>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MotorcycleRepair";

        /// <inheritdoc/>
        public bool Equals(MotorcycleRepair other)
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
        public override bool Equals(object obj) => this.Equals(obj as MotorcycleRepair);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
