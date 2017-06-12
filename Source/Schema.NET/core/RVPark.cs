namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A place offering space for "Recreational Vehicles", Caravans, mobile homes and the like.
    /// </summary>
    [DataContract]
    public class RVPark : CivicStructure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RVPark";
    }
}
