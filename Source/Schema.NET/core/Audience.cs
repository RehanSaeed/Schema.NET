namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Intended audience for an item, i.e. the group for whom the item was created.
    /// </summary>
    public partial interface IAudience : IIntangible
    {
        /// <summary>
        /// The target group associated with a given audience (e.g. veterans, car owners, musicians, etc.).
        /// </summary>
        OneOrMany<string> AudienceType { get; set; }

        /// <summary>
        /// The geographic area associated with the audience.
        /// </summary>
        OneOrMany<IAdministrativeArea> GeographicArea { get; set; }
    }

    /// <summary>
    /// Intended audience for an item, i.e. the group for whom the item was created.
    /// </summary>
    [DataContract]
    public partial class Audience : Intangible, IAudience, IEquatable<Audience>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Audience";

        /// <summary>
        /// The target group associated with a given audience (e.g. veterans, car owners, musicians, etc.).
        /// </summary>
        [DataMember(Name = "audienceType", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AudienceType { get; set; }

        /// <summary>
        /// The geographic area associated with the audience.
        /// </summary>
        [DataMember(Name = "geographicArea", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAdministrativeArea> GeographicArea { get; set; }

        /// <inheritdoc/>
        public bool Equals(Audience other)
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
                this.AudienceType == other.AudienceType &&
                this.GeographicArea == other.GeographicArea &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Audience);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AudienceType)
            .And(this.GeographicArea)
            .And(base.GetHashCode());
    }
}
