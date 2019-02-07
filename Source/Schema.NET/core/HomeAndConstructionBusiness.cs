namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A construction business.&lt;br/&gt;&lt;br/&gt;
    /// A HomeAndConstructionBusiness is a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; that provides services around homes and buildings.&lt;br/&gt;&lt;br/&gt;
    /// As a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; it can be described as a &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; of one or more &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;(s).
    /// </summary>
    [DataContract]
    public partial class HomeAndConstructionBusiness : LocalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HomeAndConstructionBusiness";
    }
}
