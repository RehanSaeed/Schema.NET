namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A volcano, like Fuji san.
    /// </summary>
    public partial interface IVolcano : ILandform
    {
    }

    /// <summary>
    /// A volcano, like Fuji san.
    /// </summary>
    [DataContract]
    public partial class Volcano : Landform, IVolcano, IEquatable<Volcano>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Volcano";

        /// <inheritdoc/>
        public bool Equals(Volcano other)
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
        public override bool Equals(object obj) => this.Equals(obj as Volcano);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
