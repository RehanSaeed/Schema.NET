namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Web page type: Collection page.
    /// </summary>
    public partial interface ICollectionPage : IWebPage
    {
    }

    /// <summary>
    /// Web page type: Collection page.
    /// </summary>
    [DataContract]
    public partial class CollectionPage : WebPage, ICollectionPage, IEquatable<CollectionPage>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CollectionPage";

        /// <inheritdoc/>
        public bool Equals(CollectionPage other)
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
        public override bool Equals(object obj) => this.Equals(obj as CollectionPage);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
