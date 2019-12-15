namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An indication for treating an underlying condition, symptom, etc.
    /// </summary>
    public partial interface ITreatmentIndication : IMedicalIndication
    {
    }

    /// <summary>
    /// An indication for treating an underlying condition, symptom, etc.
    /// </summary>
    [DataContract]
    public partial class TreatmentIndication : MedicalIndication, ITreatmentIndication, IEquatable<TreatmentIndication>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TreatmentIndication";

        /// <inheritdoc/>
        public bool Equals(TreatmentIndication other)
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
        public override bool Equals(object obj) => this.Equals(obj as TreatmentIndication);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
