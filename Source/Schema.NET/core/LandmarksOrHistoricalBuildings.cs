namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An historical landmark or building.
    /// </summary>
    public partial interface ILandmarksOrHistoricalBuildings : IPlace
    {
    }

    /// <summary>
    /// An historical landmark or building.
    /// </summary>
    [DataContract]
    public partial class LandmarksOrHistoricalBuildings : Place, ILandmarksOrHistoricalBuildings, IEquatable<LandmarksOrHistoricalBuildings>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LandmarksOrHistoricalBuildings";

        /// <inheritdoc/>
        public bool Equals(LandmarksOrHistoricalBuildings other)
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
        public override bool Equals(object obj) => this.Equals(obj as LandmarksOrHistoricalBuildings);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
