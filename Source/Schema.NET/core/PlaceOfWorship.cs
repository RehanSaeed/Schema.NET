namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Place of worship, such as a church, synagogue, or mosque.
    /// </summary>
    public partial interface IPlaceOfWorship : ICivicStructure
    {
    }

    /// <summary>
    /// Place of worship, such as a church, synagogue, or mosque.
    /// </summary>
    [DataContract]
    public partial class PlaceOfWorship : CivicStructure, IPlaceOfWorship, IEquatable<PlaceOfWorship>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PlaceOfWorship";

        /// <inheritdoc/>
        public bool Equals(PlaceOfWorship other)
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
        public override bool Equals(object obj) => this.Equals(obj as PlaceOfWorship);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
