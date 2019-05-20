namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A process of progressive physical care and rehabilitation aimed at improving a health condition.
    /// </summary>
    public partial interface IPhysicalTherapy : IMedicalTherapy
    {
    }

    /// <summary>
    /// A process of progressive physical care and rehabilitation aimed at improving a health condition.
    /// </summary>
    [DataContract]
    public partial class PhysicalTherapy : MedicalTherapy, IPhysicalTherapy
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PhysicalTherapy";
    }
}
