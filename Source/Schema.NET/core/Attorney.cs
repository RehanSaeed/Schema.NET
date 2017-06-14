namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Professional service: Attorney.
    /// This type is deprecated - LegalService is more inclusive and less ambiguous.
    /// </summary>
    [DataContract]
    public partial class Attorney : LegalService
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Attorney";
    }
}
