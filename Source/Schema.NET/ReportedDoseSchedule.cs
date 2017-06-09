namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A patient-reported or observed dosing schedule for a drug or supplement.
    /// </summary>
    [DataContract]
    public class ReportedDoseSchedule : DoseSchedule
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReportedDoseSchedule";
    }
}
