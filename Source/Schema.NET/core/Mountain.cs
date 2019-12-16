namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A mountain, like Mount Whitney or Mount Everest.
    /// </summary>
    public partial interface IMountain : ILandform
    {
    }

    /// <summary>
    /// A mountain, like Mount Whitney or Mount Everest.
    /// </summary>
    [DataContract]
    public partial class Mountain : Landform, IMountain, IEquatable<Mountain>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Mountain";

        /// <inheritdoc/>
        public bool Equals(Mountain other)
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
        public override bool Equals(object obj) => this.Equals(obj as Mountain);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
