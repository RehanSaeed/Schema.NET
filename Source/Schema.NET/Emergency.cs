namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A specific branch of medical science that deals with the evaluation and initial treatment of medical conditions caused by trauma or sudden illness.
    /// </summary>
    [DataContract]
    public class Emergency : MedicalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Emergency";
    }
}
