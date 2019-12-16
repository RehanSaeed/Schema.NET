namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An advertising section of the page.
    /// </summary>
    public partial interface IWPAdBlock : IWebPageElement
    {
    }

    /// <summary>
    /// An advertising section of the page.
    /// </summary>
    [DataContract]
    public partial class WPAdBlock : WebPageElement, IWPAdBlock, IEquatable<WPAdBlock>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WPAdBlock";

        /// <inheritdoc/>
        public bool Equals(WPAdBlock other)
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
        public override bool Equals(object obj) => this.Equals(obj as WPAdBlock);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
