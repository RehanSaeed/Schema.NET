namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A hair salon.
    /// </summary>
    [DataContract]
    public class HairSalon : HealthAndBeautyBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "HairSalon";
    }
}
