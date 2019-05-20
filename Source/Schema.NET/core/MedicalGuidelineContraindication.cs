namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A guideline contraindication that designates a process as harmful and where quality of the data supporting the contraindication is sound.
    /// </summary>
    public partial interface IMedicalGuidelineContraindication : IMedicalGuideline
    {
    }

    /// <summary>
    /// A guideline contraindication that designates a process as harmful and where quality of the data supporting the contraindication is sound.
    /// </summary>
    [DataContract]
    public partial class MedicalGuidelineContraindication : MedicalGuideline, IMedicalGuidelineContraindication
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalGuidelineContraindication";
    }
}
