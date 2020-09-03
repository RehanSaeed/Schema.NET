namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A class of medical drugs, e.g., statins. Classes can represent general pharmacological class, common mechanisms of action, common physiological effects, etc.
    /// </summary>
    public partial interface IDrugClass : IMedicalEntity
    {
        /// <summary>
        /// Specifying a drug or medicine used in a medication procedure
        /// </summary>
        OneOrMany<IDrug> Drug { get; set; }
    }

    /// <summary>
    /// A class of medical drugs, e.g., statins. Classes can represent general pharmacological class, common mechanisms of action, common physiological effects, etc.
    /// </summary>
    [DataContract]
    public partial class DrugClass : MedicalEntity, IDrugClass, IEquatable<DrugClass>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DrugClass";

        /// <summary>
        /// Specifying a drug or medicine used in a medication procedure
        /// </summary>
        [DataMember(Name = "drug", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDrug> Drug { get; set; }

        /// <inheritdoc/>
        public bool Equals(DrugClass other)
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
                this.Drug == other.Drug &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as DrugClass);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Drug)
            .And(base.GetHashCode());
    }
}
