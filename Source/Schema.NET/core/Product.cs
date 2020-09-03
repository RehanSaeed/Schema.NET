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
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. https://schema.org/width, https://schema.org/color, https://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
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
        Values<IBrand, IOrganization> Brand { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        Values<PhysicalActivityCategory?, string, IThing, Uri> Category { get; set; }

        /// <summary>
        /// The color of the product.
        /// </summary>
        OneOrMany<string> Color { get; set; }

        /// <summary>
        /// The depth of the item.
        /// </summary>
        Values<string, IQuantitativeValue> Depth { get; set; }

        /// <summary>
        /// A Global Trade Item Number (&lt;a href="https://www.gs1.org/standards/id-keys/gtin"&gt;GTIN&lt;/a&gt;). GTINs identify trade items, including products and services, using numeric identification codes. The &lt;a class="localLink" href="https://schema.org/gtin"&gt;gtin&lt;/a&gt; property generalizes the earlier &lt;a class="localLink" href="https://schema.org/gtin8"&gt;gtin8&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/gtin12"&gt;gtin12&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/gtin13"&gt;gtin13&lt;/a&gt;, and &lt;a class="localLink" href="https://schema.org/gtin14"&gt;gtin14&lt;/a&gt; properties. The GS1 &lt;a href="https://www.gs1.org/standards/Digital-Link/"&gt;digital link specifications&lt;/a&gt; express GTINs as URLs. A correct &lt;a class="localLink" href="https://schema.org/gtin"&gt;gtin&lt;/a&gt; value should be a valid GTIN, which means that it should be an all-numeric string of either 8, 12, 13 or 14 digits, or a "GS1 Digital Link" URL based on such a string. The numeric component should also have a &lt;a href="https://www.gs1.org/services/check-digit-calculator"&gt;valid GS1 check digit&lt;/a&gt; and meet the other rules for valid GTINs. See also &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1's GTIN Summary&lt;/a&gt; and &lt;a href="https://en.wikipedia.org/wiki/Global_Trade_Item_Number"&gt;Wikipedia&lt;/a&gt; for more details. Left-padding of the gtin values is not required or encouraged.
        /// </summary>
        OneOrMany<string> Gtin { get; set; }

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
        Values<string, IQuantitativeValue> Height { get; set; }

        /// <summary>
        /// Indicates the &lt;a class="localLink" href="https://schema.org/productGroupID"&gt;productGroupID&lt;/a&gt; for a &lt;a class="localLink" href="https://schema.org/ProductGroup"&gt;ProductGroup&lt;/a&gt; that this product &lt;a class="localLink" href="https://schema.org/isVariantOf"&gt;isVariantOf&lt;/a&gt;.
        /// </summary>
        OneOrMany<string> InProductGroupWithID { get; set; }

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
        Values<IProduct, IService> IsRelatedTo { get; set; }

        /// <summary>
        /// A pointer to another, functionally similar product (or multiple products).
        /// </summary>
        Values<IProduct, IService> IsSimilarTo { get; set; }

        /// <summary>
        /// Indicates the kind of product that this is a variant of. In the case of &lt;a class="localLink" href="https://schema.org/ProductModel"&gt;ProductModel&lt;/a&gt;, this is a pointer (from a ProductModel) to a base product from which this product is a variant. It is safe to infer that the variant inherits all product features from the base model, unless defined locally. This is not transitive. In the case of a &lt;a class="localLink" href="https://schema.org/ProductGroup"&gt;ProductGroup&lt;/a&gt;, the group description also serves as a template, representing a set of Products that vary on explicitly defined, specific dimensions only (so it defines both a set of variants, as well as which values distinguish amongst those variants). When used with &lt;a class="localLink" href="https://schema.org/ProductGroup"&gt;ProductGroup&lt;/a&gt;, this property can apply to any &lt;a class="localLink" href="https://schema.org/Product"&gt;Product&lt;/a&gt; included in the group.
        /// </summary>
        OneOrMany<IProductModel> IsVariantOf { get; set; }

        /// <summary>
        /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        /// </summary>
        OneOrMany<OfferItemCondition?> ItemCondition { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        Values<IImageObject, Uri> Logo { get; set; }

        /// <summary>
        /// The manufacturer of the product.
        /// </summary>
        OneOrMany<IOrganization> Manufacturer { get; set; }

        /// <summary>
        /// A material that something is made from, e.g. leather, wool, cotton, paper.
        /// </summary>
        Values<IProduct, string, Uri> Material { get; set; }

        /// <summary>
        /// The model of the product. Use with the URL of a ProductModel or a textual representation of the model identifier. The URL of the ProductModel can be from an external source. It is recommended to additionally provide strong product identifiers via the gtin8/gtin13/gtin14 and mpn properties.
        /// </summary>
        Values<IProductModel, string> Model { get; set; }

        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        OneOrMany<string> Mpn { get; set; }

        /// <summary>
        /// Indicates the &lt;a href="https://en.wikipedia.org/wiki/NATO_Stock_Number"&gt;NATO stock number&lt;/a&gt; (nsn) of a &lt;a class="localLink" href="https://schema.org/Product"&gt;Product&lt;/a&gt;.
        /// </summary>
        OneOrMany<string> Nsn { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event. Use &lt;a class="localLink" href="https://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; to indicate the kind of transaction offered, i.e. sell, lease, etc. This property can also be used to describe a &lt;a class="localLink" href="https://schema.org/Demand"&gt;Demand&lt;/a&gt;. While this property is listed as expected on a number of common types, it can be used in others. In that case, using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.
        /// </summary>
        Values<IDemand, IOffer> Offers { get; set; }

        /// <summary>
        /// A pattern that something has, for example 'polka dot', 'striped', 'Canadian flag'. Values are typically expressed as text, although links to controlled value schemes are also supported.
        /// </summary>
        OneOrMany<string> Pattern { get; set; }

        /// <summary>
        /// The product identifier, such as ISBN. For example: &lt;code&gt;meta itemprop="productID" content="isbn:123-456-789"&lt;/code&gt;.
        /// </summary>
        OneOrMany<string> ProductID { get; set; }

        /// <summary>
        /// The date of production of the item, e.g. vehicle.
        /// </summary>
        Values<int?, DateTime?> ProductionDate { get; set; }

        /// <summary>
        /// The date the item e.g. vehicle was purchased by the current owner.
        /// </summary>
        Values<int?, DateTime?> PurchaseDate { get; set; }

        /// <summary>
        /// The release date of a product or product model. This can be used to distinguish the exact variant of a product.
        /// </summary>
        Values<int?, DateTime?> ReleaseDate { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        OneOrMany<IReview> Review { get; set; }

        /// <summary>
        /// A standardized size of a product or creative work, often simplifying richer information into a simple textual string, either through referring to named sizes or (in the case of product markup), by adopting conventional simplifications. Use of QuantitativeValue with a unitCode or unitText can add more structure; in other cases, the /width, /height, /depth and /weight properties may be more applicable.
        /// </summary>
        Values<IQuantitativeValue, string> Size { get; set; }

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
        Values<string, IQuantitativeValue> Width { get; set; }
    }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
    [DataContract]
    public partial class Product : Thing, IProduct, IEquatable<Product>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Product";

        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;br/&gt;&lt;br/&gt;
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. https://schema.org/width, https://schema.org/color, https://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
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
        public Values<IBrand, IOrganization> Brand { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [DataMember(Name = "category", Order = 111)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<PhysicalActivityCategory?, string, IThing, Uri> Category { get; set; }

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
        public Values<string, IQuantitativeValue> Depth { get; set; }

        /// <summary>
        /// A Global Trade Item Number (&lt;a href="https://www.gs1.org/standards/id-keys/gtin"&gt;GTIN&lt;/a&gt;). GTINs identify trade items, including products and services, using numeric identification codes. The &lt;a class="localLink" href="https://schema.org/gtin"&gt;gtin&lt;/a&gt; property generalizes the earlier &lt;a class="localLink" href="https://schema.org/gtin8"&gt;gtin8&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/gtin12"&gt;gtin12&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/gtin13"&gt;gtin13&lt;/a&gt;, and &lt;a class="localLink" href="https://schema.org/gtin14"&gt;gtin14&lt;/a&gt; properties. The GS1 &lt;a href="https://www.gs1.org/standards/Digital-Link/"&gt;digital link specifications&lt;/a&gt; express GTINs as URLs. A correct &lt;a class="localLink" href="https://schema.org/gtin"&gt;gtin&lt;/a&gt; value should be a valid GTIN, which means that it should be an all-numeric string of either 8, 12, 13 or 14 digits, or a "GS1 Digital Link" URL based on such a string. The numeric component should also have a &lt;a href="https://www.gs1.org/services/check-digit-calculator"&gt;valid GS1 check digit&lt;/a&gt; and meet the other rules for valid GTINs. See also &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1's GTIN Summary&lt;/a&gt; and &lt;a href="https://en.wikipedia.org/wiki/Global_Trade_Item_Number"&gt;Wikipedia&lt;/a&gt; for more details. Left-padding of the gtin values is not required or encouraged.
        /// </summary>
        [DataMember(Name = "gtin", Order = 114)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin { get; set; }

        /// <summary>
        /// The GTIN-12 code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin12", Order = 115)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin12 { get; set; }

        /// <summary>
        /// The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin13", Order = 116)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin13 { get; set; }

        /// <summary>
        /// The GTIN-14 code of the product, or the product to which the offer refers. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin14", Order = 117)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin14 { get; set; }

        /// <summary>
        /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-8.aspx"&gt;GTIN-8&lt;/a&gt; code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin8", Order = 118)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin8 { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [DataMember(Name = "height", Order = 119)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IQuantitativeValue> Height { get; set; }

        /// <summary>
        /// Indicates the &lt;a class="localLink" href="https://schema.org/productGroupID"&gt;productGroupID&lt;/a&gt; for a &lt;a class="localLink" href="https://schema.org/ProductGroup"&gt;ProductGroup&lt;/a&gt; that this product &lt;a class="localLink" href="https://schema.org/isVariantOf"&gt;isVariantOf&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "inProductGroupWithID", Order = 120)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> InProductGroupWithID { get; set; }

        /// <summary>
        /// A pointer to another product (or multiple products) for which this product is an accessory or spare part.
        /// </summary>
        [DataMember(Name = "isAccessoryOrSparePartFor", Order = 121)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IProduct> IsAccessoryOrSparePartFor { get; set; }

        /// <summary>
        /// A pointer to another product (or multiple products) for which this product is a consumable.
        /// </summary>
        [DataMember(Name = "isConsumableFor", Order = 122)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IProduct> IsConsumableFor { get; set; }

        /// <summary>
        /// A pointer to another, somehow related product (or multiple products).
        /// </summary>
        [DataMember(Name = "isRelatedTo", Order = 123)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IProduct, IService> IsRelatedTo { get; set; }

        /// <summary>
        /// A pointer to another, functionally similar product (or multiple products).
        /// </summary>
        [DataMember(Name = "isSimilarTo", Order = 124)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IProduct, IService> IsSimilarTo { get; set; }

        /// <summary>
        /// Indicates the kind of product that this is a variant of. In the case of &lt;a class="localLink" href="https://schema.org/ProductModel"&gt;ProductModel&lt;/a&gt;, this is a pointer (from a ProductModel) to a base product from which this product is a variant. It is safe to infer that the variant inherits all product features from the base model, unless defined locally. This is not transitive. In the case of a &lt;a class="localLink" href="https://schema.org/ProductGroup"&gt;ProductGroup&lt;/a&gt;, the group description also serves as a template, representing a set of Products that vary on explicitly defined, specific dimensions only (so it defines both a set of variants, as well as which values distinguish amongst those variants). When used with &lt;a class="localLink" href="https://schema.org/ProductGroup"&gt;ProductGroup&lt;/a&gt;, this property can apply to any &lt;a class="localLink" href="https://schema.org/Product"&gt;Product&lt;/a&gt; included in the group.
        /// </summary>
        [DataMember(Name = "isVariantOf", Order = 125)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IProductModel> IsVariantOf { get; set; }

        /// <summary>
        /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        /// </summary>
        [DataMember(Name = "itemCondition", Order = 126)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<OfferItemCondition?> ItemCondition { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 127)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IImageObject, Uri> Logo { get; set; }

        /// <summary>
        /// The manufacturer of the product.
        /// </summary>
        [DataMember(Name = "manufacturer", Order = 128)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> Manufacturer { get; set; }

        /// <summary>
        /// A material that something is made from, e.g. leather, wool, cotton, paper.
        /// </summary>
        [DataMember(Name = "material", Order = 129)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IProduct, string, Uri> Material { get; set; }

        /// <summary>
        /// The model of the product. Use with the URL of a ProductModel or a textual representation of the model identifier. The URL of the ProductModel can be from an external source. It is recommended to additionally provide strong product identifiers via the gtin8/gtin13/gtin14 and mpn properties.
        /// </summary>
        [DataMember(Name = "model", Order = 130)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IProductModel, string> Model { get; set; }

        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        [DataMember(Name = "mpn", Order = 131)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Mpn { get; set; }

        /// <summary>
        /// Indicates the &lt;a href="https://en.wikipedia.org/wiki/NATO_Stock_Number"&gt;NATO stock number&lt;/a&gt; (nsn) of a &lt;a class="localLink" href="https://schema.org/Product"&gt;Product&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "nsn", Order = 132)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Nsn { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event. Use &lt;a class="localLink" href="https://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; to indicate the kind of transaction offered, i.e. sell, lease, etc. This property can also be used to describe a &lt;a class="localLink" href="https://schema.org/Demand"&gt;Demand&lt;/a&gt;. While this property is listed as expected on a number of common types, it can be used in others. In that case, using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.
        /// </summary>
        [DataMember(Name = "offers", Order = 133)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IDemand, IOffer> Offers { get; set; }

        /// <summary>
        /// A pattern that something has, for example 'polka dot', 'striped', 'Canadian flag'. Values are typically expressed as text, although links to controlled value schemes are also supported.
        /// </summary>
        [DataMember(Name = "pattern", Order = 134)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Pattern { get; set; }

        /// <summary>
        /// The product identifier, such as ISBN. For example: &lt;code&gt;meta itemprop="productID" content="isbn:123-456-789"&lt;/code&gt;.
        /// </summary>
        [DataMember(Name = "productID", Order = 135)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ProductID { get; set; }

        /// <summary>
        /// The date of production of the item, e.g. vehicle.
        /// </summary>
        [DataMember(Name = "productionDate", Order = 136)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public virtual Values<int?, DateTime?> ProductionDate { get; set; }

        /// <summary>
        /// The date the item e.g. vehicle was purchased by the current owner.
        /// </summary>
        [DataMember(Name = "purchaseDate", Order = 137)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public virtual Values<int?, DateTime?> PurchaseDate { get; set; }

        /// <summary>
        /// The release date of a product or product model. This can be used to distinguish the exact variant of a product.
        /// </summary>
        [DataMember(Name = "releaseDate", Order = 138)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> ReleaseDate { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 139)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IReview> Review { get; set; }

        /// <summary>
        /// A standardized size of a product or creative work, often simplifying richer information into a simple textual string, either through referring to named sizes or (in the case of product markup), by adopting conventional simplifications. Use of QuantitativeValue with a unitCode or unitText can add more structure; in other cases, the /width, /height, /depth and /weight properties may be more applicable.
        /// </summary>
        [DataMember(Name = "size", Order = 140)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IQuantitativeValue, string> Size { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        /// </summary>
        [DataMember(Name = "sku", Order = 141)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Sku { get; set; }

        /// <summary>
        /// A slogan or motto associated with the item.
        /// </summary>
        [DataMember(Name = "slogan", Order = 142)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Slogan { get; set; }

        /// <summary>
        /// The weight of the product or person.
        /// </summary>
        [DataMember(Name = "weight", Order = 143)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> Weight { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        [DataMember(Name = "width", Order = 144)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IQuantitativeValue> Width { get; set; }

        /// <inheritdoc/>
        public bool Equals(Product other)
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
                this.AdditionalProperty == other.AdditionalProperty &&
                this.AggregateRating == other.AggregateRating &&
                this.Audience == other.Audience &&
                this.Award == other.Award &&
                this.Brand == other.Brand &&
                this.Category == other.Category &&
                this.Color == other.Color &&
                this.Depth == other.Depth &&
                this.Gtin == other.Gtin &&
                this.Gtin12 == other.Gtin12 &&
                this.Gtin13 == other.Gtin13 &&
                this.Gtin14 == other.Gtin14 &&
                this.Gtin8 == other.Gtin8 &&
                this.Height == other.Height &&
                this.InProductGroupWithID == other.InProductGroupWithID &&
                this.IsAccessoryOrSparePartFor == other.IsAccessoryOrSparePartFor &&
                this.IsConsumableFor == other.IsConsumableFor &&
                this.IsRelatedTo == other.IsRelatedTo &&
                this.IsSimilarTo == other.IsSimilarTo &&
                this.IsVariantOf == other.IsVariantOf &&
                this.ItemCondition == other.ItemCondition &&
                this.Logo == other.Logo &&
                this.Manufacturer == other.Manufacturer &&
                this.Material == other.Material &&
                this.Model == other.Model &&
                this.Mpn == other.Mpn &&
                this.Nsn == other.Nsn &&
                this.Offers == other.Offers &&
                this.Pattern == other.Pattern &&
                this.ProductID == other.ProductID &&
                this.ProductionDate == other.ProductionDate &&
                this.PurchaseDate == other.PurchaseDate &&
                this.ReleaseDate == other.ReleaseDate &&
                this.Review == other.Review &&
                this.Size == other.Size &&
                this.Sku == other.Sku &&
                this.Slogan == other.Slogan &&
                this.Weight == other.Weight &&
                this.Width == other.Width &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Product);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AdditionalProperty)
            .And(this.AggregateRating)
            .And(this.Audience)
            .And(this.Award)
            .And(this.Brand)
            .And(this.Category)
            .And(this.Color)
            .And(this.Depth)
            .And(this.Gtin)
            .And(this.Gtin12)
            .And(this.Gtin13)
            .And(this.Gtin14)
            .And(this.Gtin8)
            .And(this.Height)
            .And(this.InProductGroupWithID)
            .And(this.IsAccessoryOrSparePartFor)
            .And(this.IsConsumableFor)
            .And(this.IsRelatedTo)
            .And(this.IsSimilarTo)
            .And(this.IsVariantOf)
            .And(this.ItemCondition)
            .And(this.Logo)
            .And(this.Manufacturer)
            .And(this.Material)
            .And(this.Model)
            .And(this.Mpn)
            .And(this.Nsn)
            .And(this.Offers)
            .And(this.Pattern)
            .And(this.ProductID)
            .And(this.ProductionDate)
            .And(this.PurchaseDate)
            .And(this.ReleaseDate)
            .And(this.Review)
            .And(this.Size)
            .And(this.Sku)
            .And(this.Slogan)
            .And(this.Weight)
            .And(this.Width)
            .And(base.GetHashCode());
    }
}
