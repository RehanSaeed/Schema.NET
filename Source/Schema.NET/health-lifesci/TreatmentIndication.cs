using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// An indication for treating an underlying condition, symptom, etc.
    /// </summary>
    [DataContract]
    public partial class TreatmentIndication : MedicalIndication
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TreatmentIndication";
    }
}
