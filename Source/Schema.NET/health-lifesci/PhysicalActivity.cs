namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any bodily activity that enhances or maintains physical fitness and overall health and wellness...
    /// </summary>
    [DataContract]
    public partial class PhysicalActivity : LifestyleModification
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PhysicalActivity";
    }
}
