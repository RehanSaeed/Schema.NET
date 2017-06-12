namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A construction business.
    /// A HomeAndConstructionBusiness is a LocalBusiness that provides services around homes and buildings...
    /// </summary>
    [DataContract]
    public partial class HomeAndConstructionBusiness : LocalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HomeAndConstructionBusiness";
    }
}
