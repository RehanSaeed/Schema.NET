namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An EndorsementRating is a rating that expresses some level of endorsement, for example inclusion in a "critic's pick" blog, a
    /// "Like" or "+1" on a social network. It can be considered the &lt;a class="localLink" href="https://schema.org/result"&gt;result&lt;/a&gt; of an &lt;a class="localLink" href="https://schema.org/EndorseAction"&gt;EndorseAction&lt;/a&gt; in which the &lt;a class="localLink" href="https://schema.org/object"&gt;object&lt;/a&gt; of the action is rated positively by
    /// some &lt;a class="localLink" href="https://schema.org/agent"&gt;agent&lt;/a&gt;. As is common elsewhere in schema.org, it is sometimes more useful to describe the results of such an action without explicitly describing the &lt;a class="localLink" href="https://schema.org/Action"&gt;Action&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
    /// An &lt;a class="localLink" href="https://schema.org/EndorsementRating"&gt;EndorsementRating&lt;/a&gt; may be part of a numeric scale or organized system, but this is not required: having an explicit type for indicating a positive,
    /// endorsement rating is particularly useful in the absence of numeric scales as it helps consumers understand that the rating is broadly positive.
    /// </summary>
    public partial interface IEndorsementRating : IRating
    {
    }

    /// <summary>
    /// An EndorsementRating is a rating that expresses some level of endorsement, for example inclusion in a "critic's pick" blog, a
    /// "Like" or "+1" on a social network. It can be considered the &lt;a class="localLink" href="https://schema.org/result"&gt;result&lt;/a&gt; of an &lt;a class="localLink" href="https://schema.org/EndorseAction"&gt;EndorseAction&lt;/a&gt; in which the &lt;a class="localLink" href="https://schema.org/object"&gt;object&lt;/a&gt; of the action is rated positively by
    /// some &lt;a class="localLink" href="https://schema.org/agent"&gt;agent&lt;/a&gt;. As is common elsewhere in schema.org, it is sometimes more useful to describe the results of such an action without explicitly describing the &lt;a class="localLink" href="https://schema.org/Action"&gt;Action&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
    /// An &lt;a class="localLink" href="https://schema.org/EndorsementRating"&gt;EndorsementRating&lt;/a&gt; may be part of a numeric scale or organized system, but this is not required: having an explicit type for indicating a positive,
    /// endorsement rating is particularly useful in the absence of numeric scales as it helps consumers understand that the rating is broadly positive.
    /// </summary>
    [DataContract]
    public partial class EndorsementRating : Rating, IEndorsementRating, IEquatable<EndorsementRating>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EndorsementRating";

        /// <inheritdoc/>
        public bool Equals(EndorsementRating other)
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
        public override bool Equals(object obj) => this.Equals(obj as EndorsementRating);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
