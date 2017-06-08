namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A specific branch of medical science that specializes in the care of infants, children and adolescents.
    /// </summary>
    [DataContract]
    public class Pediatric : MedicalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Pediatric";
    }
}
