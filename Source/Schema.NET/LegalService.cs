namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A LegalService is a business that provides legally-oriented services, advice and representation, e...
    /// </summary>
    [DataContract]
    public class LegalService : LocalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "LegalService";
    }
}
