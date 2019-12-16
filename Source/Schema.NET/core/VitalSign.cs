namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Vital signs are measures of various physiological functions in order to assess the most basic body functions.
    /// </summary>
    public partial interface IVitalSign : IMedicalSign
    {
    }

    /// <summary>
    /// Vital signs are measures of various physiological functions in order to assess the most basic body functions.
    /// </summary>
    [DataContract]
    public partial class VitalSign : MedicalSign, IVitalSign, IEquatable<VitalSign>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "VitalSign";

        /// <inheritdoc/>
        public bool Equals(VitalSign other)
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
        public override bool Equals(object obj) => this.Equals(obj as VitalSign);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
