namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The most generic type of item.
    /// </summary>
    [DataContract]
    public class Thing
    {
        /// <summary>
        /// Gets the context for the object, specifying that it comes from schema.org.
        /// </summary>
        [DataMember(Name = "@context")]
        public string Context => "http://schema.org";

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public virtual string Type => "Thing";

        /// <summary>
        /// URL of a reference Web page that unambiguously indicates the item's identity. E.g. the URL of the item's Wikipedia page, Wikidata entry, or official website.
        /// </summary>
        [DataMember(Name = "sameAs")]
        public Uri SameAs { get; set; }

        /// <summary>
        /// An alias for the item.
        /// </summary>
        [DataMember(Name = "alternateName")]
        public string AlternateName { get; set; }

        /// <summary>
        /// An image of the item. This can be a &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt; or a fully described &lt;a class="localLink" href="http://schema.org/ImageObject"&gt;ImageObject&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "image")]
        public object Image { get; protected set; }

        /// <summary>
        /// An image of the item. This can be a &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt; or a fully described &lt;a class="localLink" href="http://schema.org/ImageObject"&gt;ImageObject&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public Uri ImageURL
        {
            get => this.Image as Uri;
            set => this.Image = value;
        }

        /// <summary>
        /// An image of the item. This can be a &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt; or a fully described &lt;a class="localLink" href="http://schema.org/ImageObject"&gt;ImageObject&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public ImageObject ImageImageObject
        {
            get => this.Image as ImageObject;
            set => this.Image = value;
        }

        /// <summary>
        /// An additional type for the item, typically used for adding more specific types from external vocabularies in microdata syntax. This is a relationship between something and a class that the thing is in. In RDFa syntax, it is better to use the native RDFa syntax - the 'typeof' attribute - for multiple types. Schema.org tools may have only weaker understanding of extra types, in particular those defined externally.
        /// </summary>
        [DataMember(Name = "additionalType")]
        public Uri AdditionalType { get; set; }

        /// <summary>
        /// The name of the item.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The identifier property represents any kind of identifier for any kind of &lt;a class="localLink" href="http://schema.org/Thing"&gt;Thing&lt;/a&gt;, such as ISBNs, GTIN codes, UUIDs etc. Schema.org provides dedicated properties for representing many of these, either as textual strings or as URL (URI) links. See &lt;a href="/docs/datamodel.html#identifierBg"&gt;background notes&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "identifier")]
        public object Identifier { get; protected set; }

        /// <summary>
        /// The identifier property represents any kind of identifier for any kind of &lt;a class="localLink" href="http://schema.org/Thing"&gt;Thing&lt;/a&gt;, such as ISBNs, GTIN codes, UUIDs etc. Schema.org provides dedicated properties for representing many of these, either as textual strings or as URL (URI) links. See &lt;a href="/docs/datamodel.html#identifierBg"&gt;background notes&lt;/a&gt; for more details.
        /// </summary>
        [IgnoreDataMember]
        public Uri IdentifierURL
        {
            get => this.Identifier as Uri;
            set => this.Identifier = value;
        }

        /// <summary>
        /// The identifier property represents any kind of identifier for any kind of &lt;a class="localLink" href="http://schema.org/Thing"&gt;Thing&lt;/a&gt;, such as ISBNs, GTIN codes, UUIDs etc. Schema.org provides dedicated properties for representing many of these, either as textual strings or as URL (URI) links. See &lt;a href="/docs/datamodel.html#identifierBg"&gt;background notes&lt;/a&gt; for more details.
        /// </summary>
        [IgnoreDataMember]
        public string IdentifierText
        {
            get => this.Identifier as string;
            set => this.Identifier = value;
        }

        /// <summary>
        /// The identifier property represents any kind of identifier for any kind of &lt;a class="localLink" href="http://schema.org/Thing"&gt;Thing&lt;/a&gt;, such as ISBNs, GTIN codes, UUIDs etc. Schema.org provides dedicated properties for representing many of these, either as textual strings or as URL (URI) links. See &lt;a href="/docs/datamodel.html#identifierBg"&gt;background notes&lt;/a&gt; for more details.
        /// </summary>
        [IgnoreDataMember]
        public PropertyValue IdentifierPropertyValue
        {
            get => this.Identifier as PropertyValue;
            set => this.Identifier = value;
        }

        /// <summary>
        /// URL of the item.
        /// </summary>
        [DataMember(Name = "url")]
        public Uri Url { get; set; }

        /// <summary>
        /// Indicates a potential Action, which describes an idealized action in which this thing would play an 'object' role.
        /// </summary>
        [DataMember(Name = "potentialAction")]
        public Action PotentialAction { get; set; }

        /// <summary>
        /// Indicates a page (or other CreativeWork) for which this thing is the main entity being described. See &lt;a href="/docs/datamodel.html#mainEntityBackground"&gt;background notes&lt;/a&gt; for details.
        /// </summary>
        [DataMember(Name = "mainEntityOfPage")]
        public object MainEntityOfPage { get; protected set; }

        /// <summary>
        /// Indicates a page (or other CreativeWork) for which this thing is the main entity being described. See &lt;a href="/docs/datamodel.html#mainEntityBackground"&gt;background notes&lt;/a&gt; for details.
        /// </summary>
        [IgnoreDataMember]
        public CreativeWork MainEntityOfPageCreativeWork
        {
            get => this.MainEntityOfPage as CreativeWork;
            set => this.MainEntityOfPage = value;
        }

        /// <summary>
        /// Indicates a page (or other CreativeWork) for which this thing is the main entity being described. See &lt;a href="/docs/datamodel.html#mainEntityBackground"&gt;background notes&lt;/a&gt; for details.
        /// </summary>
        [IgnoreDataMember]
        public Uri MainEntityOfPageURL
        {
            get => this.MainEntityOfPage as Uri;
            set => this.MainEntityOfPage = value;
        }

        /// <summary>
        /// A description of the item.
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// A sub property of description. A short description of the item used to disambiguate from other, similar items. Information from other properties (in particular, name) may be necessary for the description to be useful for disambiguation.
        /// </summary>
        [DataMember(Name = "disambiguatingDescription")]
        public string DisambiguatingDescription { get; set; }
    }
}
