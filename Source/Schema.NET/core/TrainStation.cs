namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A train station.
    /// </summary>
    public partial interface ITrainStation : ICivicStructure
    {
    }

    /// <summary>
    /// A train station.
    /// </summary>
    [DataContract]
    public partial class TrainStation : CivicStructure, ITrainStation, IEquatable<TrainStation>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TrainStation";

        /// <inheritdoc/>
        public bool Equals(TrainStation other)
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
        public override bool Equals(object obj) => this.Equals(obj as TrainStation);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
