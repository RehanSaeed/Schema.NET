namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A Catholic church.
    /// </summary>
    public partial interface ICatholicChurch : IChurch
    {
    }

    /// <summary>
    /// A Catholic church.
    /// </summary>
    [DataContract]
    public partial class CatholicChurch : Church, ICatholicChurch, IEquatable<CatholicChurch>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CatholicChurch";

        /// <inheritdoc/>
        public bool Equals(CatholicChurch other)
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
        public override bool Equals(object obj) => this.Equals(obj as CatholicChurch);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
