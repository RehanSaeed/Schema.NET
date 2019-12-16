namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The anatomical location at which two or more bones make contact.
    /// </summary>
    public partial interface IJoint : IAnatomicalStructure
    {
        /// <summary>
        /// The biomechanical properties of the bone.
        /// </summary>
        OneOrMany<string> BiomechnicalClass { get; set; }

        /// <summary>
        /// The degree of mobility the joint allows.
        /// </summary>
        Values<IMedicalEntity, string> FunctionalClass { get; set; }

        /// <summary>
        /// The name given to how bone physically connects to each other.
        /// </summary>
        OneOrMany<string> StructuralClass { get; set; }
    }

    /// <summary>
    /// The anatomical location at which two or more bones make contact.
    /// </summary>
    [DataContract]
    public partial class Joint : AnatomicalStructure, IJoint, IEquatable<Joint>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Joint";

        /// <summary>
        /// The biomechanical properties of the bone.
        /// </summary>
        [DataMember(Name = "biomechnicalClass", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BiomechnicalClass { get; set; }

        /// <summary>
        /// The degree of mobility the joint allows.
        /// </summary>
        [DataMember(Name = "functionalClass", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMedicalEntity, string> FunctionalClass { get; set; }

        /// <summary>
        /// The name given to how bone physically connects to each other.
        /// </summary>
        [DataMember(Name = "structuralClass", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> StructuralClass { get; set; }

        /// <inheritdoc/>
        public bool Equals(Joint other)
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
                this.BiomechnicalClass == other.BiomechnicalClass &&
                this.FunctionalClass == other.FunctionalClass &&
                this.StructuralClass == other.StructuralClass &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Joint);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.BiomechnicalClass)
            .And(this.FunctionalClass)
            .And(this.StructuralClass)
            .And(base.GetHashCode());
    }
}
