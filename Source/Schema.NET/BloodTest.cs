namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A medical test performed on a sample of a patient's blood.
    /// </summary>
    [DataContract]
    public class BloodTest : MedicalTest
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "BloodTest";
    }
}
