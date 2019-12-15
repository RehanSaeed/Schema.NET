namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A subway station.
    /// </summary>
    public partial interface ISubwayStation : ICivicStructure
    {
    }

    /// <summary>
    /// A subway station.
    /// </summary>
    [DataContract]
    public partial class SubwayStation : CivicStructure, ISubwayStation, IEquatable<SubwayStation>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SubwayStation";

        /// <inheritdoc/>
        public bool Equals(SubwayStation other)
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
        public override bool Equals(object obj) => this.Equals(obj as SubwayStation);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
