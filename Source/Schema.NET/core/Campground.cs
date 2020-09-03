namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A camping site, campsite, or &lt;a class="localLink" href="https://schema.org/Campground"&gt;Campground&lt;/a&gt; is a place used for overnight stay in the outdoors, typically containing individual &lt;a class="localLink" href="https://schema.org/CampingPitch"&gt;CampingPitch&lt;/a&gt; locations. &lt;br/&gt;&lt;br/&gt;
    /// In British English a campsite is an area, usually divided into a number of pitches, where people can camp overnight using tents or camper vans or caravans; this British English use of the word is synonymous with the American English expression campground. In American English the term campsite generally means an area where an individual, family, group, or military unit can pitch a tent or park a camper; a campground may contain many campsites (Source: Wikipedia see &lt;a href="https://en.wikipedia.org/wiki/Campsite"&gt;https://en.wikipedia.org/wiki/Campsite&lt;/a&gt;).&lt;br/&gt;&lt;br/&gt;
    /// See also the dedicated &lt;a href="/docs/hotels.html"&gt;document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// </summary>
    public partial interface ICampground : ICivicStructureAndLodgingBusiness
    {
    }

    /// <summary>
    /// A camping site, campsite, or &lt;a class="localLink" href="https://schema.org/Campground"&gt;Campground&lt;/a&gt; is a place used for overnight stay in the outdoors, typically containing individual &lt;a class="localLink" href="https://schema.org/CampingPitch"&gt;CampingPitch&lt;/a&gt; locations. &lt;br/&gt;&lt;br/&gt;
    /// In British English a campsite is an area, usually divided into a number of pitches, where people can camp overnight using tents or camper vans or caravans; this British English use of the word is synonymous with the American English expression campground. In American English the term campsite generally means an area where an individual, family, group, or military unit can pitch a tent or park a camper; a campground may contain many campsites (Source: Wikipedia see &lt;a href="https://en.wikipedia.org/wiki/Campsite"&gt;https://en.wikipedia.org/wiki/Campsite&lt;/a&gt;).&lt;br/&gt;&lt;br/&gt;
    /// See also the dedicated &lt;a href="/docs/hotels.html"&gt;document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class Campground : CivicStructureAndLodgingBusiness, ICampground, IEquatable<Campground>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Campground";

        /// <inheritdoc/>
        public bool Equals(Campground other)
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
        public override bool Equals(object obj) => this.Equals(obj as Campground);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
