namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A medical procedure intended primarily for diagnostic, as opposed to therapeutic, purposes.
    /// </summary>
    public partial interface IDiagnosticProcedure : IMedicalProcedure
    {
    }

    /// <summary>
    /// A medical procedure intended primarily for diagnostic, as opposed to therapeutic, purposes.
    /// </summary>
    [DataContract]
    public partial class DiagnosticProcedure : MedicalProcedure, IDiagnosticProcedure, IEquatable<DiagnosticProcedure>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DiagnosticProcedure";

        /// <inheritdoc/>
        public bool Equals(DiagnosticProcedure other)
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
        public override bool Equals(object obj) => this.Equals(obj as DiagnosticProcedure);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
