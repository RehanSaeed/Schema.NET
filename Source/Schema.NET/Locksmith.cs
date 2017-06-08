namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A locksmith.
    /// </summary>
    [DataContract]
    public class Locksmith : HomeAndConstructionBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Locksmith";
    }
}
