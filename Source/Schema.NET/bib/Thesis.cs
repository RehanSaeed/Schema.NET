using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A thesis or dissertation document submitted in support of candidature for an academic degree or professional qualification.
    /// </summary>
    [DataContract]
    public partial class Thesis : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Thesis";

        /// <summary>
        /// Qualification, candidature, degree, application that Thesis supports.
        /// </summary>
        [DataMember(Name = "inSupportOf", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? InSupportOf { get; set; } 
    }
}
