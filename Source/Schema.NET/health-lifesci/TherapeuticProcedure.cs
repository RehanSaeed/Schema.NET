namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A medical procedure intended primarily for therapeutic purposes, aimed at improving a health condition.
    /// </summary>
    [DataContract]
    public class TherapeuticProcedure : MedicalProcedure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TherapeuticProcedure";
    }
}
