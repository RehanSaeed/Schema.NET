namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Beauty salon.
    /// </summary>
    public partial interface IBeautySalon : IHealthAndBeautyBusiness
    {
    }

    /// <summary>
    /// Beauty salon.
    /// </summary>
    [DataContract]
    public partial class BeautySalon : HealthAndBeautyBusiness, IBeautySalon
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BeautySalon";
    }
}
