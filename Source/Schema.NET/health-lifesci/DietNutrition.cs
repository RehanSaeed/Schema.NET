namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Dietetic and nutrition as a medical speciality.
    /// </summary>
    [DataContract]
    public class DietNutrition : MedicalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DietNutrition";
    }
}
