namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A nail salon.
    /// </summary>
    public partial interface INailSalon : IHealthAndBeautyBusiness
    {
    }

    /// <summary>
    /// A nail salon.
    /// </summary>
    [DataContract]
    public partial class NailSalon : HealthAndBeautyBusiness, INailSalon
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "NailSalon";
    }
}
