namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A medical trial is a type of medical study that uses scientific process used to compare the safety and efficacy of medical therapies or medical procedures...
    /// </summary>
    [DataContract]
    public class MedicalTrial : MedicalStudy
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicalTrial";
    }
}
