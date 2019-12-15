namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A patient-reported or observed dosing schedule for a drug or supplement.
    /// </summary>
    public partial interface IReportedDoseSchedule : IDoseSchedule
    {
    }

    /// <summary>
    /// A patient-reported or observed dosing schedule for a drug or supplement.
    /// </summary>
    [DataContract]
    public partial class ReportedDoseSchedule : DoseSchedule, IReportedDoseSchedule, IEquatable<ReportedDoseSchedule>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReportedDoseSchedule";

        /// <inheritdoc/>
        public bool Equals(ReportedDoseSchedule other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as ReportedDoseSchedule);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
