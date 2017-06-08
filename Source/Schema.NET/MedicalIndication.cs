namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A condition or factor that indicates use of a medical therapy, including signs, symptoms, risk factors, anatomical states, etc.
    /// </summary>
    [DataContract]
    public class MedicalIndication : MedicalEntity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicalIndication";
    }
}
