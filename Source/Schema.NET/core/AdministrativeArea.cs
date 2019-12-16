namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A geographical region, typically under the jurisdiction of a particular government.
    /// </summary>
    public partial interface IAdministrativeArea : IPlace
    {
    }

    /// <summary>
    /// A geographical region, typically under the jurisdiction of a particular government.
    /// </summary>
    [DataContract]
    public partial class AdministrativeArea : Place, IAdministrativeArea, IEquatable<AdministrativeArea>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AdministrativeArea";

        /// <inheritdoc/>
        public bool Equals(AdministrativeArea other)
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
        public override bool Equals(object obj) => this.Equals(obj as AdministrativeArea);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
