namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A fire station. With firemen.
    /// </summary>
    [DataContract]
    public class FireStation : EmergencyService
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "FireStation";
    }
}
