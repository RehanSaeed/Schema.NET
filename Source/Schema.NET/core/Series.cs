namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A Series in schema.org is a group of related items, typically but not necessarily of the same kind. See also &lt;a class="localLink" href="http://schema.org/CreativeWorkSeries"&gt;CreativeWorkSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/EventSeries"&gt;EventSeries&lt;/a&gt;.
    /// </summary>
    public partial interface ISeries : IIntangible
    {
    }

    /// <summary>
    /// A Series in schema.org is a group of related items, typically but not necessarily of the same kind. See also &lt;a class="localLink" href="http://schema.org/CreativeWorkSeries"&gt;CreativeWorkSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/EventSeries"&gt;EventSeries&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class Series : Intangible, ISeries, IEquatable<Series>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Series";
    }
}
