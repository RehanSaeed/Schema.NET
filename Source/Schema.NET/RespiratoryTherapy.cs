namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The therapy that is concerned with the maintenance or improvement of respiratory function (as in patients with pulmonary disease).
    /// </summary>
    [DataContract]
    public class RespiratoryTherapy : MedicalTherapy
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RespiratoryTherapy";
    }
}
