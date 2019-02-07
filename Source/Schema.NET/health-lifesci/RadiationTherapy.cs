namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A process of care using radiation aimed at improving a health condition.
    /// </summary>
    [DataContract]
    public partial class RadiationTherapy : MedicalTherapy
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RadiationTherapy";
    }
}
