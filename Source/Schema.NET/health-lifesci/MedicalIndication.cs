namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A condition or factor that indicates use of a medical therapy, including signs, symptoms, risk factors, anatomical states, etc.
    /// </summary>
    [DataContract]
    public partial class MedicalIndication : MedicalEntity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalIndication";
    }
}
