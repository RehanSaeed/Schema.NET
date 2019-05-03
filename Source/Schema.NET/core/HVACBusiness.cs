namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A business that provide Heating, Ventilation and Air Conditioning services.
    /// </summary>
    [DataContract]
    public partial class HVACBusiness : HomeAndConstructionBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HVACBusiness";
    }
}
