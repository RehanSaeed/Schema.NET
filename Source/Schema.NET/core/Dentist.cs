namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A dentist.
    /// </summary>
    public partial interface IDentist : ILocalBusinessAndMedicalOrganization
    {
    }

    /// <summary>
    /// A dentist.
    /// </summary>
    [DataContract]
    public partial class Dentist : LocalBusinessAndMedicalOrganization, IDentist
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Dentist";
    }
}
