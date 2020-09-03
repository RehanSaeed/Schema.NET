namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A code for a medical entity.
    /// </summary>
    public partial interface IMedicalCode : IMedicalIntangible
    {
        /// <summary>
        /// A short textual code that uniquely identifies the value.
        /// </summary>
        OneOrMany<string> CodeValue { get; set; }

        /// <summary>
        /// The coding system, e.g. 'ICD-10'.
        /// </summary>
        OneOrMany<string> CodingSystem { get; set; }
    }

    /// <summary>
    /// A code for a medical entity.
    /// </summary>
    [DataContract]
    public partial class MedicalCode : MedicalIntangible, IMedicalCode, IEquatable<MedicalCode>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalCode";

        /// <summary>
        /// A short textual code that uniquely identifies the value.
        /// </summary>
        [DataMember(Name = "codeValue", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CodeValue { get; set; }

        /// <summary>
        /// The coding system, e.g. 'ICD-10'.
        /// </summary>
        [DataMember(Name = "codingSystem", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CodingSystem { get; set; }

        /// <inheritdoc/>
        public bool Equals(MedicalCode other)
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
                this.CodeValue == other.CodeValue &&
                this.CodingSystem == other.CodingSystem &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MedicalCode);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.CodeValue)
            .And(this.CodingSystem)
            .And(base.GetHashCode());
    }
}
