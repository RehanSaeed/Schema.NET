namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A stadium.
    /// </summary>
    public partial interface IStadiumOrArena : ICivicStructureAndSportsActivityLocation
    {
    }

    /// <summary>
    /// A stadium.
    /// </summary>
    [DataContract]
    public partial class StadiumOrArena : CivicStructureAndSportsActivityLocation, IStadiumOrArena, IEquatable<StadiumOrArena>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "StadiumOrArena";

        /// <inheritdoc/>
        public bool Equals(StadiumOrArena other)
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
        public override bool Equals(object obj) => this.Equals(obj as StadiumOrArena);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
