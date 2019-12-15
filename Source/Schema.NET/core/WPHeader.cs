namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The header section of the page.
    /// </summary>
    public partial interface IWPHeader : IWebPageElement
    {
    }

    /// <summary>
    /// The header section of the page.
    /// </summary>
    [DataContract]
    public partial class WPHeader : WebPageElement, IWPHeader, IEquatable<WPHeader>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WPHeader";

        /// <inheritdoc/>
        public bool Equals(WPHeader other)
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
        public override bool Equals(object obj) => this.Equals(obj as WPHeader);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
