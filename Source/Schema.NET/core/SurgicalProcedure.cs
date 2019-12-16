namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A medical procedure involving an incision with instruments; performed for diagnose, or therapeutic purposes.
    /// </summary>
    public partial interface ISurgicalProcedure : IMedicalProcedure
    {
    }

    /// <summary>
    /// A medical procedure involving an incision with instruments; performed for diagnose, or therapeutic purposes.
    /// </summary>
    [DataContract]
    public partial class SurgicalProcedure : MedicalProcedure, ISurgicalProcedure, IEquatable<SurgicalProcedure>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SurgicalProcedure";

        /// <inheritdoc/>
        public bool Equals(SurgicalProcedure other)
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
        public override bool Equals(object obj) => this.Equals(obj as SurgicalProcedure);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
