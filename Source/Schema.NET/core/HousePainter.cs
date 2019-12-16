namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A house painting service.
    /// </summary>
    public partial interface IHousePainter : IHomeAndConstructionBusiness
    {
    }

    /// <summary>
    /// A house painting service.
    /// </summary>
    [DataContract]
    public partial class HousePainter : HomeAndConstructionBusiness, IHousePainter, IEquatable<HousePainter>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HousePainter";

        /// <inheritdoc/>
        public bool Equals(HousePainter other)
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
        public override bool Equals(object obj) => this.Equals(obj as HousePainter);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
