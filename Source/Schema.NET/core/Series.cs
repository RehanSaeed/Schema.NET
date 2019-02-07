namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A Series in schema.org is a group of related items, typically but not necessarily of the same kind. See also &lt;a class="localLink" href="http://schema.org/CreativeWorkSeries"&gt;CreativeWorkSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/EventSeries"&gt;EventSeries&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class Series : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Series";
    }
}
