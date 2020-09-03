namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Professional service: Attorney. &lt;br/&gt;&lt;br/&gt;
    /// This type is deprecated - &lt;a class="localLink" href="https://schema.org/LegalService"&gt;LegalService&lt;/a&gt; is more inclusive and less ambiguous.
    /// </summary>
    public partial interface IAttorney : ILegalService
    {
    }

    /// <summary>
    /// Professional service: Attorney. &lt;br/&gt;&lt;br/&gt;
    /// This type is deprecated - &lt;a class="localLink" href="https://schema.org/LegalService"&gt;LegalService&lt;/a&gt; is more inclusive and less ambiguous.
    /// </summary>
    [DataContract]
    public partial class Attorney : LegalService, IAttorney, IEquatable<Attorney>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Attorney";

        /// <inheritdoc/>
        public bool Equals(Attorney other)
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
        public override bool Equals(object obj) => this.Equals(obj as Attorney);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
