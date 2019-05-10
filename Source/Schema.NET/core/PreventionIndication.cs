namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An indication for preventing an underlying condition, symptom, etc.
    /// </summary>
    public partial interface IPreventionIndication : IMedicalIndication
    {
    }

    /// <summary>
    /// An indication for preventing an underlying condition, symptom, etc.
    /// </summary>
    [DataContract]
    public partial class PreventionIndication : MedicalIndication, IPreventionIndication
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PreventionIndication";
    }
}
