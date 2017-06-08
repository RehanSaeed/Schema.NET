namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A medical procedure intended primarily for palliative purposes, aimed at relieving the symptoms of an underlying health condition.
    /// </summary>
    [DataContract]
    public class PalliativeProcedure : MedicalProcedure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PalliativeProcedure";
    }
}
