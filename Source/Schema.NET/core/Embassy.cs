namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An embassy.
    /// </summary>
    public partial interface IEmbassy : IGovernmentBuilding
    {
    }

    /// <summary>
    /// An embassy.
    /// </summary>
    [DataContract]
    public partial class Embassy : GovernmentBuilding, IEmbassy, IEquatable<Embassy>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Embassy";

        /// <inheritdoc/>
        public bool Equals(Embassy other)
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
        public override bool Equals(object obj) => this.Equals(obj as Embassy);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
