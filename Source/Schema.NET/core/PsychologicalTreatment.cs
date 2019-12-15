namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A process of care relying upon counseling, dialogue and communication  aimed at improving a mental health condition without use of drugs.
    /// </summary>
    public partial interface IPsychologicalTreatment : ITherapeuticProcedure
    {
    }

    /// <summary>
    /// A process of care relying upon counseling, dialogue and communication  aimed at improving a mental health condition without use of drugs.
    /// </summary>
    [DataContract]
    public partial class PsychologicalTreatment : TherapeuticProcedure, IPsychologicalTreatment, IEquatable<PsychologicalTreatment>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PsychologicalTreatment";

        /// <inheritdoc/>
        public bool Equals(PsychologicalTreatment other)
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
        public override bool Equals(object obj) => this.Equals(obj as PsychologicalTreatment);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
