namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A day spa.
    /// </summary>
    [DataContract]
    public class DaySpa : HealthAndBeautyBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "DaySpa";
    }
}
