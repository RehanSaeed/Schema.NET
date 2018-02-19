using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
    [DataContract]
    public partial class Product : Thing
    {
        public interface IBrand : IWrapper { }
        public interface IBrand<T> : IBrand { new T Data { get; set; } }
        public class BrandBrand : IBrand<Brand>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Brand) value; } }
            public virtual Brand Data { get; set; }
            public BrandBrand () { }
            public BrandBrand (Brand data) { Data = data; }
            public static implicit operator BrandBrand (Brand data) { return new BrandBrand (data); }
        }

        public class BrandOrganization : IBrand<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public BrandOrganization () { }
            public BrandOrganization (Organization data) { Data = data; }
            public static implicit operator BrandOrganization (Organization data) { return new BrandOrganization (data); }
        }


        public interface ICategory : IWrapper { }
        public interface ICategory<T> : ICategory { new T Data { get; set; } }
        public class Categorystring : ICategory<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Categorystring () { }
            public Categorystring (string data) { Data = data; }
            public static implicit operator Categorystring (string data) { return new Categorystring (data); }
        }

        public class CategoryThing : ICategory<Thing>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Thing) value; } }
            public virtual Thing Data { get; set; }
            public CategoryThing () { }
            public CategoryThing (Thing data) { Data = data; }
            public static implicit operator CategoryThing (Thing data) { return new CategoryThing (data); }
        }


        public interface IDepth : IWrapper { }
        public interface IDepth<T> : IDepth { new T Data { get; set; } }
        public class Depthstring : IDepth<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Depthstring () { }
            public Depthstring (string data) { Data = data; }
            public static implicit operator Depthstring (string data) { return new Depthstring (data); }
        }

        public class DepthQuantitativeValue : IDepth<QuantitativeValue>
        {
            object IWrapper.Data { get { return Data; } set { Data = (QuantitativeValue) value; } }
            public virtual QuantitativeValue Data { get; set; }
            public DepthQuantitativeValue () { }
            public DepthQuantitativeValue (QuantitativeValue data) { Data = data; }
            public static implicit operator DepthQuantitativeValue (QuantitativeValue data) { return new DepthQuantitativeValue (data); }
        }


        public interface IHeight : IWrapper { }
        public interface IHeight<T> : IHeight { new T Data { get; set; } }
        public class Heightstring : IHeight<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Heightstring () { }
            public Heightstring (string data) { Data = data; }
            public static implicit operator Heightstring (string data) { return new Heightstring (data); }
        }

        public class HeightQuantitativeValue : IHeight<QuantitativeValue>
        {
            object IWrapper.Data { get { return Data; } set { Data = (QuantitativeValue) value; } }
            public virtual QuantitativeValue Data { get; set; }
            public HeightQuantitativeValue () { }
            public HeightQuantitativeValue (QuantitativeValue data) { Data = data; }
            public static implicit operator HeightQuantitativeValue (QuantitativeValue data) { return new HeightQuantitativeValue (data); }
        }


        public interface IIsRelatedTo : IWrapper { }
        public interface IIsRelatedTo<T> : IIsRelatedTo { new T Data { get; set; } }
        public class IsRelatedToProduct : IIsRelatedTo<Product>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Product) value; } }
            public virtual Product Data { get; set; }
            public IsRelatedToProduct () { }
            public IsRelatedToProduct (Product data) { Data = data; }
            public static implicit operator IsRelatedToProduct (Product data) { return new IsRelatedToProduct (data); }
        }

        public class IsRelatedToService : IIsRelatedTo<Service>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Service) value; } }
            public virtual Service Data { get; set; }
            public IsRelatedToService () { }
            public IsRelatedToService (Service data) { Data = data; }
            public static implicit operator IsRelatedToService (Service data) { return new IsRelatedToService (data); }
        }


        public interface IIsSimilarTo : IWrapper { }
        public interface IIsSimilarTo<T> : IIsSimilarTo { new T Data { get; set; } }
        public class IsSimilarToProduct : IIsSimilarTo<Product>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Product) value; } }
            public virtual Product Data { get; set; }
            public IsSimilarToProduct () { }
            public IsSimilarToProduct (Product data) { Data = data; }
            public static implicit operator IsSimilarToProduct (Product data) { return new IsSimilarToProduct (data); }
        }

        public class IsSimilarToService : IIsSimilarTo<Service>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Service) value; } }
            public virtual Service Data { get; set; }
            public IsSimilarToService () { }
            public IsSimilarToService (Service data) { Data = data; }
            public static implicit operator IsSimilarToService (Service data) { return new IsSimilarToService (data); }
        }


        public interface ILogo : IWrapper { }
        public interface ILogo<T> : ILogo { new T Data { get; set; } }
        public class LogoImageObject : ILogo<ImageObject>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ImageObject) value; } }
            public virtual ImageObject Data { get; set; }
            public LogoImageObject () { }
            public LogoImageObject (ImageObject data) { Data = data; }
            public static implicit operator LogoImageObject (ImageObject data) { return new LogoImageObject (data); }
        }

        public class LogoUri : ILogo<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public LogoUri () { }
            public LogoUri (Uri data) { Data = data; }
            public static implicit operator LogoUri (Uri data) { return new LogoUri (data); }
        }


        public interface IMaterial : IWrapper { }
        public interface IMaterial<T> : IMaterial { new T Data { get; set; } }
        public class MaterialProduct : IMaterial<Product>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Product) value; } }
            public virtual Product Data { get; set; }
            public MaterialProduct () { }
            public MaterialProduct (Product data) { Data = data; }
            public static implicit operator MaterialProduct (Product data) { return new MaterialProduct (data); }
        }

        public class Materialstring : IMaterial<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Materialstring () { }
            public Materialstring (string data) { Data = data; }
            public static implicit operator Materialstring (string data) { return new Materialstring (data); }
        }

        public class MaterialUri : IMaterial<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public MaterialUri () { }
            public MaterialUri (Uri data) { Data = data; }
            public static implicit operator MaterialUri (Uri data) { return new MaterialUri (data); }
        }


        public interface IModel : IWrapper { }
        public interface IModel<T> : IModel { new T Data { get; set; } }
        public class ModelProductModel : IModel<ProductModel>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ProductModel) value; } }
            public virtual ProductModel Data { get; set; }
            public ModelProductModel () { }
            public ModelProductModel (ProductModel data) { Data = data; }
            public static implicit operator ModelProductModel (ProductModel data) { return new ModelProductModel (data); }
        }

        public class Modelstring : IModel<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Modelstring () { }
            public Modelstring (string data) { Data = data; }
            public static implicit operator Modelstring (string data) { return new Modelstring (data); }
        }


        public interface IWidth : IWrapper { }
        public interface IWidth<T> : IWidth { new T Data { get; set; } }
        public class Widthstring : IWidth<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Widthstring () { }
            public Widthstring (string data) { Data = data; }
            public static implicit operator Widthstring (string data) { return new Widthstring (data); }
        }

        public class WidthQuantitativeValue : IWidth<QuantitativeValue>
        {
            object IWrapper.Data { get { return Data; } set { Data = (QuantitativeValue) value; } }
            public virtual QuantitativeValue Data { get; set; }
            public WidthQuantitativeValue () { }
            public WidthQuantitativeValue (QuantitativeValue data) { Data = data; }
            public static implicit operator WidthQuantitativeValue (QuantitativeValue data) { return new WidthQuantitativeValue (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Product";

        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;/p&gt;
        /// &lt;p&gt;Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        [DataMember(Name = "additionalProperty", Order = 106)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PropertyValue>? AdditionalProperty { get; set; } 

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 107)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AggregateRating>? AggregateRating { get; set; } 

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience", Order = 108)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Audience>? Audience { get; set; } 

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 109)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Award { get; set; } 

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 110)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IBrand>? Brand { get; set; } //Brand, Organization

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [DataMember(Name = "category", Order = 111)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ICategory>? Category { get; set; } //string, Thing

        /// <summary>
        /// The color of the product.
        /// </summary>
        [DataMember(Name = "color", Order = 112)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Color { get; set; } 

        /// <summary>
        /// The depth of the item.
        /// </summary>
        [DataMember(Name = "depth", Order = 113)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IDepth>? Depth { get; set; } //string, QuantitativeValue

        /// <summary>
        /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-12.aspx"&gt;GTIN-12&lt;/a&gt; code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin12", Order = 114)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Gtin12 { get; set; } 

        /// <summary>
        /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-13.aspx"&gt;GTIN-13&lt;/a&gt; code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin13", Order = 115)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Gtin13 { get; set; } 

        /// <summary>
        /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-14.aspx"&gt;GTIN-14&lt;/a&gt; code of the product, or the product to which the offer refers. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin14", Order = 116)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Gtin14 { get; set; } 

        /// <summary>
        /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-8.aspx"&gt;GTIN-8&lt;/a&gt; code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin8", Order = 117)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Gtin8 { get; set; } 

        /// <summary>
        /// The height of the item.
        /// </summary>
        [DataMember(Name = "height", Order = 118)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IHeight>? Height { get; set; } //string, QuantitativeValue

        /// <summary>
        /// A pointer to another product (or multiple products) for which this product is an accessory or spare part.
        /// </summary>
        [DataMember(Name = "isAccessoryOrSparePartFor", Order = 119)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Product>? IsAccessoryOrSparePartFor { get; set; } 

        /// <summary>
        /// A pointer to another product (or multiple products) for which this product is a consumable.
        /// </summary>
        [DataMember(Name = "isConsumableFor", Order = 120)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Product>? IsConsumableFor { get; set; } 

        /// <summary>
        /// A pointer to another, somehow related product (or multiple products).
        /// </summary>
        [DataMember(Name = "isRelatedTo", Order = 121)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IIsRelatedTo>? IsRelatedTo { get; set; } //Product, Service

        /// <summary>
        /// A pointer to another, functionally similar product (or multiple products).
        /// </summary>
        [DataMember(Name = "isSimilarTo", Order = 122)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IIsSimilarTo>? IsSimilarTo { get; set; } //Product, Service

        /// <summary>
        /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        /// </summary>
        [DataMember(Name = "itemCondition", Order = 123)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<OfferItemCondition>? ItemCondition { get; set; } 

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 124)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ILogo>? Logo { get; set; } //ImageObject, Uri

        /// <summary>
        /// The manufacturer of the product.
        /// </summary>
        [DataMember(Name = "manufacturer", Order = 125)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? Manufacturer { get; set; } 

        /// <summary>
        /// A material that something is made from, e.g. leather, wool, cotton, paper.
        /// </summary>
        [DataMember(Name = "material", Order = 126)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IMaterial>? Material { get; set; } //Product, string, Uri

        /// <summary>
        /// The model of the product. Use with the URL of a ProductModel or a textual representation of the model identifier. The URL of the ProductModel can be from an external source. It is recommended to additionally provide strong product identifiers via the gtin8/gtin13/gtin14 and mpn properties.
        /// </summary>
        [DataMember(Name = "model", Order = 127)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IModel>? Model { get; set; } //ProductModel, string

        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        [DataMember(Name = "mpn", Order = 128)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Mpn { get; set; } 

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers", Order = 129)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Offer>? Offers { get; set; } 

        /// <summary>
        /// The product identifier, such as ISBN. For example: &lt;code&gt;meta itemprop="productID" content="isbn:123-456-789"&lt;/code&gt;.
        /// </summary>
        [DataMember(Name = "productID", Order = 130)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ProductID { get; set; } 

        /// <summary>
        /// The date of production of the item, e.g. vehicle.
        /// </summary>
        [DataMember(Name = "productionDate", Order = 131)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<DateTimeOffset>? ProductionDate { get; set; } 

        /// <summary>
        /// The date the item e.g. vehicle was purchased by the current owner.
        /// </summary>
        [DataMember(Name = "purchaseDate", Order = 132)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<DateTimeOffset>? PurchaseDate { get; set; } 

        /// <summary>
        /// The release date of a product or product model. This can be used to distinguish the exact variant of a product.
        /// </summary>
        [DataMember(Name = "releaseDate", Order = 133)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? ReleaseDate { get; set; } 

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 134)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Review>? Review { get; set; } 

        /// <summary>
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        /// </summary>
        [DataMember(Name = "sku", Order = 135)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Sku { get; set; } 

        /// <summary>
        /// The weight of the product or person.
        /// </summary>
        [DataMember(Name = "weight", Order = 136)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? Weight { get; set; } 

        /// <summary>
        /// The width of the item.
        /// </summary>
        [DataMember(Name = "width", Order = 137)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IWidth>? Width { get; set; } //string, QuantitativeValue
    }
}
