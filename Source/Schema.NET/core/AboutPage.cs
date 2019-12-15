namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Web page type: About page.
    /// </summary>
    public partial interface IAboutPage : IWebPage
    {
    }

    /// <summary>
    /// Web page type: About page.
    /// </summary>
    [DataContract]
    public partial class AboutPage : WebPage, IAboutPage, IEquatable<AboutPage>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AboutPage";

        /// <inheritdoc/>
        public bool Equals(AboutPage other)
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
        public override bool Equals(object obj) => this.Equals(obj as AboutPage);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
