namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A health profession of a person formally educated and trained in the care of the sick or infirm person.
    /// </summary>
    [DataContract]
    public class Nursing : MedicalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Nursing";
    }
}
