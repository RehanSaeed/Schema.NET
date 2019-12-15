namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A medical laboratory that offers on-site or off-site diagnostic services.
    /// </summary>
    public partial interface IDiagnosticLab : IMedicalOrganization
    {
        /// <summary>
        /// A diagnostic test or procedure offered by this lab.
        /// </summary>
        OneOrMany<IMedicalTest> AvailableTest { get; set; }
    }

    /// <summary>
    /// A medical laboratory that offers on-site or off-site diagnostic services.
    /// </summary>
    [DataContract]
    public partial class DiagnosticLab : MedicalOrganization, IDiagnosticLab, IEquatable<DiagnosticLab>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DiagnosticLab";

        /// <summary>
        /// A diagnostic test or procedure offered by this lab.
        /// </summary>
        [DataMember(Name = "availableTest", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalTest> AvailableTest { get; set; }

        /// <inheritdoc/>
        public bool Equals(DiagnosticLab other)
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
                this.AvailableTest == other.AvailableTest &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as DiagnosticLab);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AvailableTest)
            .And(base.GetHashCode());
    }
}
