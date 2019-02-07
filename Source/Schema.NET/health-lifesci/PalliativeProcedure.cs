namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A medical procedure intended primarily for palliative purposes, aimed at relieving the symptoms of an underlying health condition.
    /// </summary>
    [DataContract]
    public partial class PalliativeProcedure : MedicalTherapy
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PalliativeProcedure";
    }
}
