namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A graveyard.
    /// </summary>
    public partial interface ICemetery : ICivicStructure
    {
    }

    /// <summary>
    /// A graveyard.
    /// </summary>
    [DataContract]
    public partial class Cemetery : CivicStructure, ICemetery, IEquatable<Cemetery>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Cemetery";

        /// <inheritdoc/>
        public bool Equals(Cemetery other)
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
        public override bool Equals(object obj) => this.Equals(obj as Cemetery);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
