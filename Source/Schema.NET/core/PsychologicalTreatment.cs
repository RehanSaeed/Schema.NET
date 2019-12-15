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
    }
}
