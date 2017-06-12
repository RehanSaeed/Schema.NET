namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A store that sells reading glasses and similar devices for improving vision.
    /// </summary>
    [DataContract]
    public partial class Optician : MedicalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Optician";
    }
}
