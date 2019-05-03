namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A &lt;a class="localLink" href="http://schema.org/FAQPage"&gt;FAQPage&lt;/a&gt; is a &lt;a class="localLink" href="http://schema.org/WebPage"&gt;WebPage&lt;/a&gt; presenting one or more "&lt;a href="https://en.wikipedia.org/wiki/FAQ"&gt;Frequently asked questions&lt;/a&gt;" (see also &lt;a class="localLink" href="http://schema.org/QAPage"&gt;QAPage&lt;/a&gt;).
    /// </summary>
    [DataContract]
    public partial class FAQPage : WebPage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FAQPage";
    }
}
