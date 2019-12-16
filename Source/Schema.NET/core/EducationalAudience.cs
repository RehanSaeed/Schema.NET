namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An EducationalAudience.
    /// </summary>
    public partial interface IEducationalAudience : IAudience
    {
        /// <summary>
        /// An educationalRole of an EducationalAudience.
        /// </summary>
        OneOrMany<string> EducationalRole { get; set; }
    }

    /// <summary>
    /// An EducationalAudience.
    /// </summary>
    [DataContract]
    public partial class EducationalAudience : Audience, IEducationalAudience, IEquatable<EducationalAudience>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EducationalAudience";

        /// <summary>
        /// An educationalRole of an EducationalAudience.
        /// </summary>
        [DataMember(Name = "educationalRole", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> EducationalRole { get; set; }

        /// <inheritdoc/>
        public bool Equals(EducationalAudience other)
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
                this.EducationalRole == other.EducationalRole &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as EducationalAudience);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.EducationalRole)
            .And(base.GetHashCode());
    }
}
