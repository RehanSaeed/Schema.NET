namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A tattoo parlor.
    /// </summary>
    public partial interface ITattooParlor : IHealthAndBeautyBusiness
    {
    }

    /// <summary>
    /// A tattoo parlor.
    /// </summary>
    [DataContract]
    public partial class TattooParlor : HealthAndBeautyBusiness, ITattooParlor, IEquatable<TattooParlor>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TattooParlor";

        /// <inheritdoc/>
        public bool Equals(TattooParlor other)
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
        public override bool Equals(object obj) => this.Equals(obj as TattooParlor);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
