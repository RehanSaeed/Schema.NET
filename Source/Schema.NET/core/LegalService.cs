namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A LegalService is a business that provides legally-oriented services, advice and representation, e.g. law firms.&lt;br/&gt;&lt;br/&gt;
    /// As a &lt;a class="localLink" href="https://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; it can be described as a &lt;a class="localLink" href="https://schema.org/provider"&gt;provider&lt;/a&gt; of one or more &lt;a class="localLink" href="https://schema.org/Service"&gt;Service&lt;/a&gt;(s).
    /// </summary>
    public partial interface ILegalService : ILocalBusiness
    {
    }

    /// <summary>
    /// A LegalService is a business that provides legally-oriented services, advice and representation, e.g. law firms.&lt;br/&gt;&lt;br/&gt;
    /// As a &lt;a class="localLink" href="https://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; it can be described as a &lt;a class="localLink" href="https://schema.org/provider"&gt;provider&lt;/a&gt; of one or more &lt;a class="localLink" href="https://schema.org/Service"&gt;Service&lt;/a&gt;(s).
    /// </summary>
    [DataContract]
    public partial class LegalService : LocalBusiness, ILegalService, IEquatable<LegalService>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LegalService";

        /// <inheritdoc/>
        public bool Equals(LegalService other)
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
        public override bool Equals(object obj) => this.Equals(obj as LegalService);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
