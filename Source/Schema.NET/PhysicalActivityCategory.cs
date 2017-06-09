namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Categories of physical activity, organized by physiologic classification.
    /// </summary>
    [DataContract]
    public class PhysicalActivityCategory : Enumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PhysicalActivityCategory";
    }
}
