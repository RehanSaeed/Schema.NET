namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A vet's office.
    /// </summary>
    public partial interface IVeterinaryCare : IMedicalOrganization
    {
    }

    /// <summary>
    /// A vet's office.
    /// </summary>
    [DataContract]
    public partial class VeterinaryCare : MedicalOrganization, IVeterinaryCare
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "VeterinaryCare";
    }
}
