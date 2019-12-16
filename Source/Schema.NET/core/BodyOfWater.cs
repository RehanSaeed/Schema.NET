namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A body of water, such as a sea, ocean, or lake.
    /// </summary>
    public partial interface IBodyOfWater : ILandform
    {
    }

    /// <summary>
    /// A body of water, such as a sea, ocean, or lake.
    /// </summary>
    [DataContract]
    public partial class BodyOfWater : Landform, IBodyOfWater, IEquatable<BodyOfWater>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BodyOfWater";

        /// <inheritdoc/>
        public bool Equals(BodyOfWater other)
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
        public override bool Equals(object obj) => this.Equals(obj as BodyOfWater);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
