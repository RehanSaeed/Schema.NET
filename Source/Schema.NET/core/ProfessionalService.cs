namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Original definition: "provider of professional services."
    /// The general ProfessionalService type for local businesses was deprecated due to confusion with Service...
    /// </summary>
    [DataContract]
    public partial class ProfessionalService : LocalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ProfessionalService";
    }
}
