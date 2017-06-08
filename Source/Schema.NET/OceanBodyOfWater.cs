namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An ocean (for example, the Pacific).
    /// </summary>
    [DataContract]
    public class OceanBodyOfWater : BodyOfWater
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "OceanBodyOfWater";
    }
}
