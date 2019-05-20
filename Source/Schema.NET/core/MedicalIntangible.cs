namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A utility class that serves as the umbrella for a number of 'intangible' things in the medical space.
    /// </summary>
    public partial interface IMedicalIntangible : IMedicalEntity
    {
    }

    /// <summary>
    /// A utility class that serves as the umbrella for a number of 'intangible' things in the medical space.
    /// </summary>
    [DataContract]
    public partial class MedicalIntangible : MedicalEntity, IMedicalIntangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalIntangible";
    }
}
