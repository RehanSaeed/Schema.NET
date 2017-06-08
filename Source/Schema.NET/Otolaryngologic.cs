namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A specific branch of medical science that is concerned with the ear, nose and throat and their respective disease states.
    /// </summary>
    [DataContract]
    public class Otolaryngologic : MedicalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Otolaryngologic";
    }
}
