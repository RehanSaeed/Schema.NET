namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A tennis complex.
    /// </summary>
    public partial interface ITennisComplex : ISportsActivityLocation
    {
    }

    /// <summary>
    /// A tennis complex.
    /// </summary>
    [DataContract]
    public partial class TennisComplex : SportsActivityLocation, ITennisComplex, IEquatable<TennisComplex>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TennisComplex";

        /// <inheritdoc/>
        public bool Equals(TennisComplex other)
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
        public override bool Equals(object obj) => this.Equals(obj as TennisComplex);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
