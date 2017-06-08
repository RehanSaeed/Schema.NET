namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A taxi stand.
    /// </summary>
    [DataContract]
    public class TaxiStand : CivicStructure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "TaxiStand";
    }
}
