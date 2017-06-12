namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The most generic type of entity related to health and the practice of medicine.
    /// </summary>
    [DataContract]
    public class MedicalEntity : Thing
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalEntity";
    }
}
