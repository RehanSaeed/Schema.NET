namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An anatomical system is a group of anatomical structures that work together to perform a certain task...
    /// </summary>
    [DataContract]
    public partial class AnatomicalSystem : MedicalEntity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AnatomicalSystem";
    }
}
