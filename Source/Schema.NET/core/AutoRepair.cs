namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Car repair business.
    /// </summary>
    public partial interface IAutoRepair : IAutomotiveBusiness
    {
    }

    /// <summary>
    /// Car repair business.
    /// </summary>
    [DataContract]
    public partial class AutoRepair : AutomotiveBusiness, IAutoRepair, IEquatable<AutoRepair>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AutoRepair";

        /// <inheritdoc/>
        public bool Equals(AutoRepair other)
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
        public override bool Equals(object obj) => this.Equals(obj as AutoRepair);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
