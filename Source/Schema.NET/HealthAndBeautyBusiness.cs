namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Health and beauty.
    /// </summary>
    [DataContract]
    public class HealthAndBeautyBusiness : LocalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "HealthAndBeautyBusiness";
    }
}
