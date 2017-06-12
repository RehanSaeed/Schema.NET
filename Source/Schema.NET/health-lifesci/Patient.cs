namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A patient is any person recipient of health care services.
    /// </summary>
    [DataContract]
    public partial class Patient : MedicalAudience
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Patient";
    }
}
