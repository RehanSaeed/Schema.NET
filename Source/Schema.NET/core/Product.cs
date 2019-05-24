namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
    public partial interface IProduct : IThing
    {
        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;br/&gt;&lt;br/&gt;
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        OneOrMany<IPropertyValue> AdditionalProperty { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        OneOrMany<IAggregateRating> AggregateRating { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        OneOrMany<IAudience> Audience { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        OneOrMany<string> Award { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        Values<IBrand, IOrganization>? Brand { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        Values<PhysicalActivityCategory?, string, IThing>? Category { get; set; }

        /// <summary>
        /// The color of the product.
        /// </summary>
        OneOrMany<string> Color { get; set; }

        /// <summary>
        /// The depth of the item.
        /// </summary>
        Values<string, IQuantitativeValue>? Depth { get; set; }

        /// <summary>
        /// The GTIN-12 code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        OneOrMany<string> Gtin12 { get; set; }

        /// <summary>
        /// The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        OneOrMany<string> Gtin13 { get; set; }

        /// <summary>
        /// The GTIN-14 code of the product, or the product to which the offer refers. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        OneOrMany<string> Gtin14 { get; set; }

        /// <summary>
        /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-8.aspx"&gt;GTIN-8&lt;/a&gt; code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        OneOrMany<string> Gtin8 { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        Values<string, IQuantitativeValue>? Height { get; set; }

        /// <summary>
        /// A pointer to another product (or multiple products) for which this product is an accessory or spare part.
        /// </summary>
        OneOrMany<IProduct> IsAccessoryOrSparePartFor { get; set; }

        /// <summary>
        /// A pointer to another product (or multiple products) for which this product is a consumable.
        /// </summary>
        OneOrMany<IProduct> IsConsumableFor { get; set; }

        /// <summary>
        /// A pointer to another, somehow related product (or multiple products).
        /// </summary>
        Values<IProduct, IService>? IsRelatedTo { get; set; }

        /// <summary>
        /// A pointer to another, functionally similar product (or multiple products).
        /// </summary>
        Values<IProduct, IService>? IsSimilarTo { get; set; }

        /// <summary>
        /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        /// </summary>
        OneOrMany<OfferItemCondition?> ItemCondition { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        Values<IImageObject, Uri>? Logo { get; set; }

        /// <summary>
        /// The manufacturer of the product.
        /// </summary>
        OneOrMany<IOrganization> Manufacturer { get; set; }

        /// <summary>
        /// A material that something is made from, e.g. leather, wool, cotton, paper.
        /// </summary>
        Values<IProduct, string, Uri>? Material { get; set; }

        /// <summary>
        /// The model of the product. Use with the URL of a ProductModel or a textual representation of the model identifier. The URL of the ProductModel can be from an external source. It is recommended to additionally provide strong product identifiers via the gtin8/gtin13/gtin14 and mpn properties.
        /// </summary>
        Values<IProductModel, string>? Model { get; set; }

        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        OneOrMany<string> Mpn { get; set; }

        /// <summary>
        /// Indicates the &lt;a href="https://en.wikipedia.org/wiki/NATO_Stock_Number"&gt;NATO stock number&lt;/a&gt; (nsn) of a &lt;a class="localLink" href="http://schema.org/Product"&gt;Product&lt;/a&gt;.
        /// </summary>
        OneOrMany<string> Nsn { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        OneOrMany<IOffer> Offers { get; set; }

        /// <summary>
        /// The product identifier, such as ISBN. For example: &lt;code&gt;meta itemprop="productID" content="isbn:123-456-789"&lt;/code&gt;.
        /// </summary>
        OneOrMany<string> ProductID { get; set; }

        /// <summary>
        /// The date of production of the item, e.g. vehicle.
        /// </summary>
        OneOrMany<DateTimeOffset?> ProductionDate { get; set; }

        /// <summary>
        /// The date the item e.g. vehicle was purchased by the current owner.
        /// </summary>
        OneOrMany<DateTimeOffset?> PurchaseDate { get; set; }

        /// <summary>
        /// The release date of a product or product model. This can be used to distinguish the exact variant of a product.
        /// </summary>
        OneOrMany<DateTimeOffset?> ReleaseDate { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        OneOrMany<IReview> Review { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        /// </summary>
        OneOrMany<string> Sku { get; set; }

        /// <summary>
        /// A slogan or motto associated with the item.
        /// </summary>
        OneOrMany<string> Slogan { get; set; }

        /// <summary>
        /// The weight of the product or person.
        /// </summary>
        OneOrMany<IQuantitativeValue> Weight { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        Values<string, IQuantitativeValue>? Width { get; set; }
    }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
    [DataContract]
    public partial class Product : Thing, IProduct
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Product";

        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;br/&gt;&lt;br/&gt;
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        [DataMember(Name = "additionalProperty", Order = 106)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPropertyValue> AdditionalProperty { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 107)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAggregateRating> AggregateRating { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience", Order = 108)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAudience> Audience { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 109)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Award { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 110)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IBrand, IOrganization>? Brand { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [DataMember(Name = "category", Order = 111)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<PhysicalActivityCategory?, string, IThing>? Category { get; set; }

        /// <summary>
        /// The color of the product.
        /// </summary>
        [DataMember(Name = "color", Order = 112)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Color { get; set; }

        /// <summary>
        /// The depth of the item.
        /// </summary>
        [DataMember(Name = "depth", Order = 113)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IQuantitativeValue>? Depth { get; set; }

        /// <summary>
        /// The GTIN-12 code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin12", Order = 114)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin12 { get; set; }

        /// <summary>
        /// The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin13", Order = 115)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin13 { get; set; }

        /// <summary>
        /// The GTIN-14 code of the product, or the product to which the offer refers. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin14", Order = 116)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin14 { get; set; }

        /// <summary>
        /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-8.aspx"&gt;GTIN-8&lt;/a&gt; code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin8", Order = 117)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin8 { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [DataMember(Name = "height", Order = 118)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IQuantitativeValue>? Height { get; set; }

        /// <summary>
        /// A pointer to another product (or multiple products) for which this product is an accessory or spare part.
        /// </summary>
        [DataMember(Name = "isAccessoryOrSparePartFor", Order = 119)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IProduct> IsAccessoryOrSparePartFor { get; set; }

        /// <summary>
        /// A pointer to another product (or multiple products) for which this product is a consumable.
        /// </summary>
        [DataMember(Name = "isConsumableFor", Order = 120)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IProduct> IsConsumableFor { get; set; }

        /// <summary>
        /// A pointer to another, somehow related product (or multiple products).
        /// </summary>
        [DataMember(Name = "isRelatedTo", Order = 121)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IProduct, IService>? IsRelatedTo { get; set; }

        /// <summary>
        /// A pointer to another, functionally similar product (or multiple products).
        /// </summary>
        [DataMember(Name = "isSimilarTo", Order = 122)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IProduct, IService>? IsSimilarTo { get; set; }

        /// <summary>
        /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        /// </summary>
        [DataMember(Name = "itemCondition", Order = 123)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<OfferItemCondition?> ItemCondition { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 124)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IImageObject, Uri>? Logo { get; set; }

        /// <summary>
        /// The manufacturer of the product.
        /// </summary>
        [DataMember(Name = "manufacturer", Order = 125)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> Manufacturer { get; set; }

        /// <summary>
        /// A material that something is made from, e.g. leather, wool, cotton, paper.
        /// </summary>
        [DataMember(Name = "material", Order = 126)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IProduct, string, Uri>? Material { get; set; }

        /// <summary>
        /// The model of the product. Use with the URL of a ProductModel or a textual representation of the model identifier. The URL of the ProductModel can be from an external source. It is recommended to additionally provide strong product identifiers via the gtin8/gtin13/gtin14 and mpn properties.
        /// </summary>
        [DataMember(Name = "model", Order = 127)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IProductModel, string>? Model { get; set; }

        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        [DataMember(Name = "mpn", Order = 128)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Mpn { get; set; }

        /// <summary>
        /// Indicates the &lt;a href="https://en.wikipedia.org/wiki/NATO_Stock_Number"&gt;NATO stock number&lt;/a&gt; (nsn) of a &lt;a class="localLink" href="http://schema.org/Product"&gt;Product&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "nsn", Order = 129)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Nsn { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers", Order = 130)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOffer> Offers { get; set; }

        /// <summary>
        /// The product identifier, such as ISBN. For example: &lt;code&gt;meta itemprop="productID" content="isbn:123-456-789"&lt;/code&gt;.
        /// </summary>
        [DataMember(Name = "productID", Order = 131)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ProductID { get; set; }

        /// <summary>
        /// The date of production of the item, e.g. vehicle.
        /// </summary>
        [DataMember(Name = "productionDate", Order = 132)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<DateTimeOffset?> ProductionDate { get; set; }

        /// <summary>
        /// The date the item e.g. vehicle was purchased by the current owner.
        /// </summary>
        [DataMember(Name = "purchaseDate", Order = 133)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<DateTimeOffset?> PurchaseDate { get; set; }

        /// <summary>
        /// The release date of a product or product model. This can be used to distinguish the exact variant of a product.
        /// </summary>
        [DataMember(Name = "releaseDate", Order = 134)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> ReleaseDate { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 135)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IReview> Review { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        /// </summary>
        [DataMember(Name = "sku", Order = 136)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Sku { get; set; }

        /// <summary>
        /// A slogan or motto associated with the item.
        /// </summary>
        [DataMember(Name = "slogan", Order = 137)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Slogan { get; set; }

        /// <summary>
        /// The weight of the product or person.
        /// </summary>
        [DataMember(Name = "weight", Order = 138)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> Weight { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        [DataMember(Name = "width", Order = 139)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IQuantitativeValue>? Width { get; set; }
    }
}
