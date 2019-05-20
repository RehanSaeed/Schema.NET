namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A notary.
    /// </summary>
    public partial interface INotary : ILegalService
    {
    }

    /// <summary>
    /// A notary.
    /// </summary>
    [DataContract]
    public partial class Notary : LegalService, INotary
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Notary";
    }
}
