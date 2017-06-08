namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A business that provide Heating, Ventilation and Air Conditioning services.
    /// </summary>
    [DataContract]
    public class HVACBusiness : HomeAndConstructionBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "HVACBusiness";
    }
}
