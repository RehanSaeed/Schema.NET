namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A &lt;a class="localLink" href="https://schema.org/FAQPage"&gt;FAQPage&lt;/a&gt; is a &lt;a class="localLink" href="https://schema.org/WebPage"&gt;WebPage&lt;/a&gt; presenting one or more "&lt;a href="https://en.wikipedia.org/wiki/FAQ"&gt;Frequently asked questions&lt;/a&gt;" (see also &lt;a class="localLink" href="https://schema.org/QAPage"&gt;QAPage&lt;/a&gt;).
    /// </summary>
    public partial interface IFAQPage : IWebPage
    {
    }

    /// <summary>
    /// A &lt;a class="localLink" href="https://schema.org/FAQPage"&gt;FAQPage&lt;/a&gt; is a &lt;a class="localLink" href="https://schema.org/WebPage"&gt;WebPage&lt;/a&gt; presenting one or more "&lt;a href="https://en.wikipedia.org/wiki/FAQ"&gt;Frequently asked questions&lt;/a&gt;" (see also &lt;a class="localLink" href="https://schema.org/QAPage"&gt;QAPage&lt;/a&gt;).
    /// </summary>
    [DataContract]
    public partial class FAQPage : WebPage, IFAQPage, IEquatable<FAQPage>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FAQPage";

        /// <inheritdoc/>
        public bool Equals(FAQPage other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as FAQPage);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
