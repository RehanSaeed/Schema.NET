namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A treatment of people with physical, emotional, or social problems, using purposeful activity to help them overcome or learn to deal with their problems.
    /// </summary>
    [DataContract]
    public class OccupationalTherapy : MedicalTherapy
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "OccupationalTherapy";
    }
}
