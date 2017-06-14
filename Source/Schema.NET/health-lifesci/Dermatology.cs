namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A specific branch of medical science that pertains to diagnosis and treatment of disorders of skin.
    /// </summary>
    [DataContract]
    public partial class Dermatology : MedicalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Dermatology";
    }
}
