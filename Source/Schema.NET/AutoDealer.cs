namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An car dealership.
    /// </summary>
    [DataContract]
    public class AutoDealer : AutomotiveBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "AutoDealer";
    }
}
