namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A process of care using radiation aimed at improving a health condition.
    /// </summary>
    public partial interface IRadiationTherapy : IMedicalTherapy
    {
    }

    /// <summary>
    /// A process of care using radiation aimed at improving a health condition.
    /// </summary>
    [DataContract]
    public partial class RadiationTherapy : MedicalTherapy, IRadiationTherapy
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RadiationTherapy";
    }
}
