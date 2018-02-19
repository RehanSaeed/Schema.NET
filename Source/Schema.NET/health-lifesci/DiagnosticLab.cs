using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A medical laboratory that offers on-site or off-site diagnostic services.
    /// </summary>
    [DataContract]
    public partial class DiagnosticLab : MedicalOrganization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DiagnosticLab";

        /// <summary>
        /// A diagnostic test or procedure offered by this lab.
        /// </summary>
        [DataMember(Name = "availableTest", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalTest>? AvailableTest { get; set; } 
    }
}
