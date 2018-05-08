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
    public partial class SurgicalProcedure : MedicalProcedure, ISurgicalProcedure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SurgicalProcedure";
    }
}
