namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A medical procedure intended primarily for palliative purposes, aimed at relieving the symptoms of an underlying health condition.
    /// </summary>
    public partial interface IPalliativeProcedure : IMedicalTherapy
    {
    }

    /// <summary>
    /// A medical procedure intended primarily for palliative purposes, aimed at relieving the symptoms of an underlying health condition.
    /// </summary>
    [DataContract]
    public partial class PalliativeProcedure : MedicalTherapy, IPalliativeProcedure, IEquatable<PalliativeProcedure>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PalliativeProcedure";

        /// <inheritdoc/>
        public bool Equals(PalliativeProcedure other)
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
        public override bool Equals(object obj) => this.Equals(obj as PalliativeProcedure);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
