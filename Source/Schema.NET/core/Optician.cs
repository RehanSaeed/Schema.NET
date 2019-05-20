namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A store that sells reading glasses and similar devices for improving vision.
    /// </summary>
    public partial interface IOptician : IMedicalBusiness
    {
    }

    /// <summary>
    /// A store that sells reading glasses and similar devices for improving vision.
    /// </summary>
    [DataContract]
    public partial class Optician : MedicalBusiness, IOptician
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Optician";
    }
}
