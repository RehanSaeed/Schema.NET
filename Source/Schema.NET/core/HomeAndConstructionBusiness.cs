namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A construction business.&lt;br/&gt;&lt;br/&gt;
    /// A HomeAndConstructionBusiness is a &lt;a class="localLink" href="https://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; that provides services around homes and buildings.&lt;br/&gt;&lt;br/&gt;
    /// As a &lt;a class="localLink" href="https://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; it can be described as a &lt;a class="localLink" href="https://schema.org/provider"&gt;provider&lt;/a&gt; of one or more &lt;a class="localLink" href="https://schema.org/Service"&gt;Service&lt;/a&gt;(s).
    /// </summary>
    public partial interface IHomeAndConstructionBusiness : ILocalBusiness
    {
    }

    /// <summary>
    /// A construction business.&lt;br/&gt;&lt;br/&gt;
    /// A HomeAndConstructionBusiness is a &lt;a class="localLink" href="https://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; that provides services around homes and buildings.&lt;br/&gt;&lt;br/&gt;
    /// As a &lt;a class="localLink" href="https://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; it can be described as a &lt;a class="localLink" href="https://schema.org/provider"&gt;provider&lt;/a&gt; of one or more &lt;a class="localLink" href="https://schema.org/Service"&gt;Service&lt;/a&gt;(s).
    /// </summary>
    [DataContract]
    public partial class HomeAndConstructionBusiness : LocalBusiness, IHomeAndConstructionBusiness, IEquatable<HomeAndConstructionBusiness>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HomeAndConstructionBusiness";

        /// <inheritdoc/>
        public bool Equals(HomeAndConstructionBusiness other)
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
        public override bool Equals(object obj) => this.Equals(obj as HomeAndConstructionBusiness);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
