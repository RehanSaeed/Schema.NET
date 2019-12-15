namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A synagogue.
    /// </summary>
    public partial interface ISynagogue : IPlaceOfWorship
    {
    }

    /// <summary>
    /// A synagogue.
    /// </summary>
    [DataContract]
    public partial class Synagogue : PlaceOfWorship, ISynagogue, IEquatable<Synagogue>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Synagogue";

        /// <inheritdoc/>
        public bool Equals(Synagogue other)
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
        public override bool Equals(object obj) => this.Equals(obj as Synagogue);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
