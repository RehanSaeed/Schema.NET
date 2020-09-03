namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Organization: Sports team.
    /// </summary>
    public partial interface ISportsTeam : ISportsOrganization
    {
        /// <summary>
        /// A person that acts as performing member of a sports team; a player as opposed to a coach.
        /// </summary>
        OneOrMany<IPerson> Athlete { get; set; }

        /// <summary>
        /// A person that acts in a coaching role for a sports team.
        /// </summary>
        OneOrMany<IPerson> Coach { get; set; }

        /// <summary>
        /// Gender of something, typically a &lt;a class="localLink" href="https://schema.org/Person"&gt;Person&lt;/a&gt;, but possibly also fictional characters, animals, etc. While https://schema.org/Male and https://schema.org/Female may be used, text strings are also acceptable for people who do not identify as a binary gender. The &lt;a class="localLink" href="https://schema.org/gender"&gt;gender&lt;/a&gt; property can also be used in an extended sense to cover e.g. the gender of sports teams. As with the gender of individuals, we do not try to enumerate all possibilities. A mixed-gender &lt;a class="localLink" href="https://schema.org/SportsTeam"&gt;SportsTeam&lt;/a&gt; can be indicated with a text value of "Mixed".
        /// </summary>
        Values<GenderType?, string> Gender { get; set; }
    }

    /// <summary>
    /// Organization: Sports team.
    /// </summary>
    [DataContract]
    public partial class SportsTeam : SportsOrganization, ISportsTeam, IEquatable<SportsTeam>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SportsTeam";

        /// <summary>
        /// A person that acts as performing member of a sports team; a player as opposed to a coach.
        /// </summary>
        [DataMember(Name = "athlete", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Athlete { get; set; }

        /// <summary>
        /// A person that acts in a coaching role for a sports team.
        /// </summary>
        [DataMember(Name = "coach", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Coach { get; set; }

        /// <summary>
        /// Gender of something, typically a &lt;a class="localLink" href="https://schema.org/Person"&gt;Person&lt;/a&gt;, but possibly also fictional characters, animals, etc. While https://schema.org/Male and https://schema.org/Female may be used, text strings are also acceptable for people who do not identify as a binary gender. The &lt;a class="localLink" href="https://schema.org/gender"&gt;gender&lt;/a&gt; property can also be used in an extended sense to cover e.g. the gender of sports teams. As with the gender of individuals, we do not try to enumerate all possibilities. A mixed-gender &lt;a class="localLink" href="https://schema.org/SportsTeam"&gt;SportsTeam&lt;/a&gt; can be indicated with a text value of "Mixed".
        /// </summary>
        [DataMember(Name = "gender", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<GenderType?, string> Gender { get; set; }

        /// <inheritdoc/>
        public bool Equals(SportsTeam other)
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
                this.Athlete == other.Athlete &&
                this.Coach == other.Coach &&
                this.Gender == other.Gender &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as SportsTeam);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Athlete)
            .And(this.Coach)
            .And(this.Gender)
            .And(base.GetHashCode());
    }
}
