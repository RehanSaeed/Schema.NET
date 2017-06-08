namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A condition or factor that serves as a reason to withhold a certain medical therapy...
    /// </summary>
    [DataContract]
    public class MedicalContraindication : MedicalEntity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicalContraindication";
    }
}
