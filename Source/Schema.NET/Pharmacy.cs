namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A pharmacy or drugstore.
    /// </summary>
    [DataContract]
    public class Pharmacy : MedicalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Pharmacy";
    }
}
