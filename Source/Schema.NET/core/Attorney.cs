namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Professional service: Attorney. &lt;br/&gt;&lt;br/&gt;
    /// This type is deprecated - &lt;a class="localLink" href="http://schema.org/LegalService"&gt;LegalService&lt;/a&gt; is more inclusive and less ambiguous.
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
