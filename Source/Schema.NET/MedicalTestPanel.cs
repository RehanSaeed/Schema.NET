namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any collection of tests commonly ordered together.
    /// </summary>
    [DataContract]
    public class MedicalTestPanel : MedicalTest
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicalTestPanel";
    }
}
