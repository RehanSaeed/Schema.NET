namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The most generic type of item.
    /// </summary>
    [DataContract]
    public partial class Thing
    {
        /// <summary>
        /// Gets the context for the object, specifying that it comes from schema.org.
        /// </summary>
        [DataMember(Name = "@context", Order = 0)]
        public override string Context => "http://schema.org";

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Thing";

        /// <summary>
        /// The name of the item.
        /// </summary>
        [DataMember(Name = "name", Order = 3)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Name { get; set; }

        /// <summary>
        /// A description of the item.
        /// </summary>
        [DataMember(Name = "description", Order = 4)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Description { get; set; }

        /// <summary>
        /// An additional type for the item, typically used for adding more specific types from external vocabularies in microdata syntax. This is a relationship between something and a class that the thing is in. In RDFa syntax, it is better to use the native RDFa syntax - the 'typeof' attribute - for multiple types. Schema.org tools may have only weaker understanding of extra types, in particular those defined externally.
        /// </summary>
        [DataMember(Name = "additionalType", Order = 7)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? AdditionalType { get; set; }

        /// <summary>
        /// An alias for the item.
        /// </summary>
        [DataMember(Name = "alternateName", Order = 8)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AlternateName { get; set; }

        /// <summary>
        /// A sub property of description. A short description of the item used to disambiguate from other, similar items. Information from other properties (in particular, name) may be necessary for the description to be useful for disambiguation.
        /// </summary>
        [DataMember(Name = "disambiguatingDescription", Order = 9)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? DisambiguatingDescription { get; set; }

        /// <summary>
        /// The identifier property represents any kind of identifier for any kind of &lt;a class="localLink" href="http://schema.org/Thing"&gt;Thing&lt;/a&gt;, such as ISBNs, GTIN codes, UUIDs etc. Schema.org provides dedicated properties for representing many of these, either as textual strings or as URL (URI) links. See &lt;a href="/docs/datamodel.html#identifierBg"&gt;background notes&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "identifier", Order = 10)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri, string, PropertyValue>? Identifier { get; set; }

        /// <summary>
        /// An image of the item. This can be a &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt; or a fully described &lt;a class="localLink" href="http://schema.org/ImageObject"&gt;ImageObject&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "image", Order = 11)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri, ImageObject>? Image { get; set; }

        /// <summary>
        /// Indicates a page (or other CreativeWork) for which this thing is the main entity being described. See &lt;a href="/docs/datamodel.html#mainEntityBackground"&gt;background notes&lt;/a&gt; for details.
        /// </summary>
        [DataMember(Name = "mainEntityOfPage", Order = 12)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork, Uri>? MainEntityOfPage { get; set; }

        /// <summary>
        /// Indicates a potential Action, which describes an idealized action in which this thing would play an 'object' role.
        /// </summary>
        [DataMember(Name = "potentialAction", Order = 13)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Action>? PotentialAction { get; set; }

        /// <summary>
        /// URL of a reference Web page that unambiguously indicates the item's identity. E.g. the URL of the item's Wikipedia page, Wikidata entry, or official website.
        /// </summary>
        [DataMember(Name = "sameAs", Order = 14)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? SameAs { get; set; }

        /// <summary>
        /// URL of the item.
        /// </summary>
        [DataMember(Name = "url", Order = 15)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? Url { get; set; }
    }
}
