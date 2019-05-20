namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Professional service: Attorney. &lt;br/&gt;&lt;br/&gt;
    /// This type is deprecated - &lt;a class="localLink" href="http://schema.org/LegalService"&gt;LegalService&lt;/a&gt; is more inclusive and less ambiguous.
    /// </summary>
    public partial interface IAttorney : ILegalService
    {
    }

    /// <summary>
    /// Professional service: Attorney. &lt;br/&gt;&lt;br/&gt;
    /// This type is deprecated - &lt;a class="localLink" href="http://schema.org/LegalService"&gt;LegalService&lt;/a&gt; is more inclusive and less ambiguous.
    /// </summary>
    [DataContract]
    public partial class Attorney : LegalService, IAttorney
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Attorney";
    }
}
