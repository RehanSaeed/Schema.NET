namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A plumbing service.
    /// </summary>
    [DataContract]
    public class Plumber : HomeAndConstructionBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Plumber";
    }
}
