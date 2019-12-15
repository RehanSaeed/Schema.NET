namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A navigation element of the page.
    /// </summary>
    public partial interface ISiteNavigationElement : IWebPageElement
    {
    }

    /// <summary>
    /// A navigation element of the page.
    /// </summary>
    [DataContract]
    public partial class SiteNavigationElement : WebPageElement, ISiteNavigationElement, IEquatable<SiteNavigationElement>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SiteNavigationElement";

        /// <inheritdoc/>
        public bool Equals(SiteNavigationElement other)
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
        public override bool Equals(object obj) => this.Equals(obj as SiteNavigationElement);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
