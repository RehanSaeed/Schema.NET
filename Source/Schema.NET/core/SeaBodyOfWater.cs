namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A sea (for example, the Caspian sea).
    /// </summary>
    public partial interface ISeaBodyOfWater : IBodyOfWater
    {
    }

    /// <summary>
    /// A sea (for example, the Caspian sea).
    /// </summary>
    [DataContract]
    public partial class SeaBodyOfWater : BodyOfWater, ISeaBodyOfWater, IEquatable<SeaBodyOfWater>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SeaBodyOfWater";

        /// <inheritdoc/>
        public bool Equals(SeaBodyOfWater other)
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
        public override bool Equals(object obj) => this.Equals(obj as SeaBodyOfWater);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
