namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A car wash business.
    /// </summary>
    public partial interface IAutoWash : IAutomotiveBusiness
    {
    }

    /// <summary>
    /// A car wash business.
    /// </summary>
    [DataContract]
    public partial class AutoWash : AutomotiveBusiness, IAutoWash, IEquatable<AutoWash>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AutoWash";

        /// <inheritdoc/>
        public bool Equals(AutoWash other)
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
        public override bool Equals(object obj) => this.Equals(obj as AutoWash);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
