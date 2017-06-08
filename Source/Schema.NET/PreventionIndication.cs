namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An indication for preventing an underlying condition, symptom, etc.
    /// </summary>
    [DataContract]
    public class PreventionIndication : MedicalIndication
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PreventionIndication";
    }
}
