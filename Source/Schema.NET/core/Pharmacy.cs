namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A pharmacy or drugstore.
    /// </summary>
    public partial interface IPharmacy : IMedicalBusinessAndMedicalOrganization
    {
    }

    /// <summary>
    /// A pharmacy or drugstore.
    /// </summary>
    [DataContract]
    public partial class Pharmacy : MedicalBusinessAndMedicalOrganization, IPharmacy
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Pharmacy";
    }
}
