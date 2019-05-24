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
    public partial class TreatmentIndication : MedicalIndication, ITreatmentIndication
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TreatmentIndication";
    }
}
