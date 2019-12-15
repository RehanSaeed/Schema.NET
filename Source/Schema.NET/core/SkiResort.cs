namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A ski resort.
    /// </summary>
    public partial interface ISkiResort : ISportsActivityLocation
    {
    }

    /// <summary>
    /// A ski resort.
    /// </summary>
    [DataContract]
    public partial class SkiResort : SportsActivityLocation, ISkiResort, IEquatable<SkiResort>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SkiResort";

        /// <inheritdoc/>
        public bool Equals(SkiResort other)
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
        public override bool Equals(object obj) => this.Equals(obj as SkiResort);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
