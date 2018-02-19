using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// An offer to transfer some rights to an item or to provide a service — for example, an offer to sell tickets to an event, to rent the DVD of a movie, to stream a TV show over the internet, to repair a motorcycle, or to loan a book.&lt;/p&gt;
    /// &lt;p&gt;For &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GTIN&lt;/a&gt;-related fields, see &lt;a href="http://www.gs1.org/barcodes/support/check_digit_calculator"&gt;Check Digit calculator&lt;/a&gt; and &lt;a href="http://www.gs1us.org/resources/standards/gtin-validation-guide"&gt;validation guide&lt;/a&gt; from &lt;a href="http://www.gs1.org/"&gt;GS1&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class Offer : Intangible
    {
        public interface IAcceptedPaymentMethod : IWrapper { }
        public interface IAcceptedPaymentMethod<T> : IAcceptedPaymentMethod { new T Data { get; set; } }
        public class AcceptedPaymentMethodLoanOrCredit : IAcceptedPaymentMethod<LoanOrCredit>
        {
            object IWrapper.Data { get { return Data; } set { Data = (LoanOrCredit) value; } }
            public virtual LoanOrCredit Data { get; set; }
            public AcceptedPaymentMethodLoanOrCredit () { }
            public AcceptedPaymentMethodLoanOrCredit (LoanOrCredit data) { Data = data; }
            public static implicit operator AcceptedPaymentMethodLoanOrCredit (LoanOrCredit data) { return new AcceptedPaymentMethodLoanOrCredit (data); }
        }

        public class AcceptedPaymentMethodPaymentMethod : IAcceptedPaymentMethod<PaymentMethod>
        {
            object IWrapper.Data { get { return Data; } set { Data = (PaymentMethod) value; } }
            public virtual PaymentMethod Data { get; set; }
            public AcceptedPaymentMethodPaymentMethod () { }
            public AcceptedPaymentMethodPaymentMethod (PaymentMethod data) { Data = data; }
            public static implicit operator AcceptedPaymentMethodPaymentMethod (PaymentMethod data) { return new AcceptedPaymentMethodPaymentMethod (data); }
        }


        public interface IAreaServed : IWrapper { }
        public interface IAreaServed<T> : IAreaServed { new T Data { get; set; } }
        public class AreaServedAdministrativeArea : IAreaServed<AdministrativeArea>
        {
            object IWrapper.Data { get { return Data; } set { Data = (AdministrativeArea) value; } }
            public virtual AdministrativeArea Data { get; set; }
            public AreaServedAdministrativeArea () { }
            public AreaServedAdministrativeArea (AdministrativeArea data) { Data = data; }
            public static implicit operator AreaServedAdministrativeArea (AdministrativeArea data) { return new AreaServedAdministrativeArea (data); }
        }

        public class AreaServedGeoShape : IAreaServed<GeoShape>
        {
            object IWrapper.Data { get { return Data; } set { Data = (GeoShape) value; } }
            public virtual GeoShape Data { get; set; }
            public AreaServedGeoShape () { }
            public AreaServedGeoShape (GeoShape data) { Data = data; }
            public static implicit operator AreaServedGeoShape (GeoShape data) { return new AreaServedGeoShape (data); }
        }

        public class AreaServedPlace : IAreaServed<Place>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Place) value; } }
            public virtual Place Data { get; set; }
            public AreaServedPlace () { }
            public AreaServedPlace (Place data) { Data = data; }
            public static implicit operator AreaServedPlace (Place data) { return new AreaServedPlace (data); }
        }

        public class AreaServedstring : IAreaServed<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public AreaServedstring () { }
            public AreaServedstring (string data) { Data = data; }
            public static implicit operator AreaServedstring (string data) { return new AreaServedstring (data); }
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


        public interface IEligibleRegion : IWrapper { }
        public interface IEligibleRegion<T> : IEligibleRegion { new T Data { get; set; } }
        public class EligibleRegionGeoShape : IEligibleRegion<GeoShape>
        {
            object IWrapper.Data { get { return Data; } set { Data = (GeoShape) value; } }
            public virtual GeoShape Data { get; set; }
            public EligibleRegionGeoShape () { }
            public EligibleRegionGeoShape (GeoShape data) { Data = data; }
            public static implicit operator EligibleRegionGeoShape (GeoShape data) { return new EligibleRegionGeoShape (data); }
        }

        public class EligibleRegionPlace : IEligibleRegion<Place>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Place) value; } }
            public virtual Place Data { get; set; }
            public EligibleRegionPlace () { }
            public EligibleRegionPlace (Place data) { Data = data; }
            public static implicit operator EligibleRegionPlace (Place data) { return new EligibleRegionPlace (data); }
        }

        public class EligibleRegionstring : IEligibleRegion<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public EligibleRegionstring () { }
            public EligibleRegionstring (string data) { Data = data; }
            public static implicit operator EligibleRegionstring (string data) { return new EligibleRegionstring (data); }
        }


        public interface IIneligibleRegion : IWrapper { }
        public interface IIneligibleRegion<T> : IIneligibleRegion { new T Data { get; set; } }
        public class IneligibleRegionGeoShape : IIneligibleRegion<GeoShape>
        {
            object IWrapper.Data { get { return Data; } set { Data = (GeoShape) value; } }
            public virtual GeoShape Data { get; set; }
            public IneligibleRegionGeoShape () { }
            public IneligibleRegionGeoShape (GeoShape data) { Data = data; }
            public static implicit operator IneligibleRegionGeoShape (GeoShape data) { return new IneligibleRegionGeoShape (data); }
        }

        public class IneligibleRegionPlace : IIneligibleRegion<Place>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Place) value; } }
            public virtual Place Data { get; set; }
            public IneligibleRegionPlace () { }
            public IneligibleRegionPlace (Place data) { Data = data; }
            public static implicit operator IneligibleRegionPlace (Place data) { return new IneligibleRegionPlace (data); }
        }

        public class IneligibleRegionstring : IIneligibleRegion<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public IneligibleRegionstring () { }
            public IneligibleRegionstring (string data) { Data = data; }
            public static implicit operator IneligibleRegionstring (string data) { return new IneligibleRegionstring (data); }
        }


        public interface IItemOffered : IWrapper { }
        public interface IItemOffered<T> : IItemOffered { new T Data { get; set; } }
        public class ItemOfferedProduct : IItemOffered<Product>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Product) value; } }
            public virtual Product Data { get; set; }
            public ItemOfferedProduct () { }
            public ItemOfferedProduct (Product data) { Data = data; }
            public static implicit operator ItemOfferedProduct (Product data) { return new ItemOfferedProduct (data); }
        }

        public class ItemOfferedService : IItemOffered<Service>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Service) value; } }
            public virtual Service Data { get; set; }
            public ItemOfferedService () { }
            public ItemOfferedService (Service data) { Data = data; }
            public static implicit operator ItemOfferedService (Service data) { return new ItemOfferedService (data); }
        }


        public interface IOfferedBy : IWrapper { }
        public interface IOfferedBy<T> : IOfferedBy { new T Data { get; set; } }
        public class OfferedByOrganization : IOfferedBy<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public OfferedByOrganization () { }
            public OfferedByOrganization (Organization data) { Data = data; }
            public static implicit operator OfferedByOrganization (Organization data) { return new OfferedByOrganization (data); }
        }

        public class OfferedByPerson : IOfferedBy<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public OfferedByPerson () { }
            public OfferedByPerson (Person data) { Data = data; }
            public static implicit operator OfferedByPerson (Person data) { return new OfferedByPerson (data); }
        }


        public interface IPrice : IWrapper { }
        public interface IPrice<T> : IPrice { new T Data { get; set; } }
        public class Pricedecimal : IPrice<decimal>
        {
            object IWrapper.Data { get { return Data; } set { Data = (decimal) value; } }
            public virtual decimal Data { get; set; }
            public Pricedecimal () { }
            public Pricedecimal (decimal data) { Data = data; }
            public static implicit operator Pricedecimal (decimal data) { return new Pricedecimal (data); }
        }

        public class Pricestring : IPrice<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Pricestring () { }
            public Pricestring (string data) { Data = data; }
            public static implicit operator Pricestring (string data) { return new Pricestring (data); }
        }


        public interface ISeller : IWrapper { }
        public interface ISeller<T> : ISeller { new T Data { get; set; } }
        public class SellerOrganization : ISeller<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public SellerOrganization () { }
            public SellerOrganization (Organization data) { Data = data; }
            public static implicit operator SellerOrganization (Organization data) { return new SellerOrganization (data); }
        }

        public class SellerPerson : ISeller<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public SellerPerson () { }
            public SellerPerson (Person data) { Data = data; }
            public static implicit operator SellerPerson (Person data) { return new SellerPerson (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Offer";

        /// <summary>
        /// The payment method(s) accepted by seller for this offer.
        /// </summary>
        [DataMember(Name = "acceptedPaymentMethod", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAcceptedPaymentMethod>? AcceptedPaymentMethod { get; set; } //LoanOrCredit, PaymentMethod?

        /// <summary>
        /// An additional offer that can only be obtained in combination with the first base offer (e.g. supplements and extensions that are available for a surcharge).
        /// </summary>
        [DataMember(Name = "addOn", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Offer>? AddOn { get; set; } 

        /// <summary>
        /// The amount of time that is required between accepting the offer and the actual usage of the resource or service.
        /// </summary>
        [DataMember(Name = "advanceBookingRequirement", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? AdvanceBookingRequirement { get; set; } 

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AggregateRating>? AggregateRating { get; set; } 

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAreaServed>? AreaServed { get; set; } //AdministrativeArea, GeoShape, Place, string

        /// <summary>
        /// The availability of this item&amp;#x2014;for example In stock, Out of stock, Pre-order, etc.
        /// </summary>
        [DataMember(Name = "availability", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ItemAvailability>? Availability { get; set; } 

        /// <summary>
        /// The end of the availability of the product or service included in the offer.
        /// </summary>
        [DataMember(Name = "availabilityEnds", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? AvailabilityEnds { get; set; } 

        /// <summary>
        /// The beginning of the availability of the product or service included in the offer.
        /// </summary>
        [DataMember(Name = "availabilityStarts", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? AvailabilityStarts { get; set; } 

        /// <summary>
        /// The place(s) from which the offer can be obtained (e.g. store locations).
        /// </summary>
        [DataMember(Name = "availableAtOrFrom", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? AvailableAtOrFrom { get; set; } 

        /// <summary>
        /// The delivery method(s) available for this offer.
        /// </summary>
        [DataMember(Name = "availableDeliveryMethod", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DeliveryMethod>? AvailableDeliveryMethod { get; set; } 

        /// <summary>
        /// The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
        /// </summary>
        [DataMember(Name = "businessFunction", Order = 216)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<BusinessFunction>? BusinessFunction { get; set; } 

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [DataMember(Name = "category", Order = 217)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ICategory>? Category { get; set; } //string, Thing

        /// <summary>
        /// The typical delay between the receipt of the order and the goods either leaving the warehouse or being prepared for pickup, in case the delivery method is on site pickup.
        /// </summary>
        [DataMember(Name = "deliveryLeadTime", Order = 218)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? DeliveryLeadTime { get; set; } 

        /// <summary>
        /// The type(s) of customers for which the given offer is valid.
        /// </summary>
        [DataMember(Name = "eligibleCustomerType", Order = 219)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<BusinessEntityType>? EligibleCustomerType { get; set; } 

        /// <summary>
        /// The duration for which the given offer is valid.
        /// </summary>
        [DataMember(Name = "eligibleDuration", Order = 220)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? EligibleDuration { get; set; } 

        /// <summary>
        /// The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
        /// </summary>
        [DataMember(Name = "eligibleQuantity", Order = 221)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? EligibleQuantity { get; set; } 

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.&lt;/p&gt;
        /// &lt;p&gt;See also &lt;a class="localLink" href="http://schema.org/ineligibleRegion"&gt;ineligibleRegion&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "eligibleRegion", Order = 222)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IEligibleRegion>? EligibleRegion { get; set; } //GeoShape, Place, string

        /// <summary>
        /// The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
        /// </summary>
        [DataMember(Name = "eligibleTransactionVolume", Order = 223)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PriceSpecification>? EligibleTransactionVolume { get; set; } 

        /// <summary>
        /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-12.aspx"&gt;GTIN-12&lt;/a&gt; code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin12", Order = 224)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Gtin12 { get; set; } 

        /// <summary>
        /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-13.aspx"&gt;GTIN-13&lt;/a&gt; code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin13", Order = 225)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Gtin13 { get; set; } 

        /// <summary>
        /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-14.aspx"&gt;GTIN-14&lt;/a&gt; code of the product, or the product to which the offer refers. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin14", Order = 226)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Gtin14 { get; set; } 

        /// <summary>
        /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-8.aspx"&gt;GTIN-8&lt;/a&gt; code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin8", Order = 227)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Gtin8 { get; set; } 

        /// <summary>
        /// This links to a node or nodes indicating the exact quantity of the products included in the offer.
        /// </summary>
        [DataMember(Name = "includesObject", Order = 228)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<TypeAndQuantityNode>? IncludesObject { get; set; } 

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is not valid, e.g. a region where the transaction is not allowed.&lt;/p&gt;
        /// &lt;p&gt;See also &lt;a class="localLink" href="http://schema.org/eligibleRegion"&gt;eligibleRegion&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "ineligibleRegion", Order = 229)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IIneligibleRegion>? IneligibleRegion { get; set; } //GeoShape, Place, string

        /// <summary>
        /// The current approximate inventory level for the item or items.
        /// </summary>
        [DataMember(Name = "inventoryLevel", Order = 230)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? InventoryLevel { get; set; } 

        /// <summary>
        /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        /// </summary>
        [DataMember(Name = "itemCondition", Order = 231)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<OfferItemCondition>? ItemCondition { get; set; } 

        /// <summary>
        /// The item being offered.
        /// </summary>
        [DataMember(Name = "itemOffered", Order = 232)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IItemOffered>? ItemOffered { get; set; } //Product, Service

        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        [DataMember(Name = "mpn", Order = 233)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Mpn { get; set; } 

        /// <summary>
        /// A pointer to the organization or person making the offer.
        /// </summary>
        [DataMember(Name = "offeredBy", Order = 234)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IOfferedBy>? OfferedBy { get; set; } //Organization, Person

        /// <summary>
        /// &lt;p&gt;The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes.&lt;/p&gt;
        /// &lt;p&gt;Usage guidelines:&lt;/p&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Use the &lt;a class="localLink" href="http://schema.org/priceCurrency"&gt;priceCurrency&lt;/a&gt; property (with &lt;a href="http://en.wikipedia.org/wiki/ISO_4217#Active_codes"&gt;ISO 4217 codes&lt;/a&gt; e.g. "USD") instead of
        ///   including &lt;a href="http://en.wikipedia.org/wiki/Dollar_sign#Currencies_that_use_the_dollar_or_peso_sign"&gt;ambiguous symbols&lt;/a&gt; such as '$' in the value.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;li&gt;Note that both &lt;a href="http://www.w3.org/TR/xhtml-rdfa-primer/#using-the-content-attribute"&gt;RDFa&lt;/a&gt; and Microdata syntax allow the use of a "content=" attribute for publishing simple machine-readable values alongside more human-friendly formatting.&lt;/li&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "price", Order = 235)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPrice>? Price { get; set; } //decimal?, string

        /// <summary>
        /// The currency (in 3-letter ISO 4217 format) of the price or a price component, when attached to &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.
        /// </summary>
        [DataMember(Name = "priceCurrency", Order = 236)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PriceCurrency { get; set; } 

        /// <summary>
        /// One or more detailed price specifications, indicating the unit price and delivery or payment charges.
        /// </summary>
        [DataMember(Name = "priceSpecification", Order = 237)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PriceSpecification>? PriceSpecification { get; set; } 

        /// <summary>
        /// The date after which the price is no longer available.
        /// </summary>
        [DataMember(Name = "priceValidUntil", Order = 238)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? PriceValidUntil { get; set; } 

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 239)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Review>? Review { get; set; } 

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [DataMember(Name = "seller", Order = 240)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ISeller>? Seller { get; set; } //Organization, Person

        /// <summary>
        /// The serial number or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial number of the product included in the offer.
        /// </summary>
        [DataMember(Name = "serialNumber", Order = 241)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? SerialNumber { get; set; } 

        /// <summary>
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        /// </summary>
        [DataMember(Name = "sku", Order = 242)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Sku { get; set; } 

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [DataMember(Name = "validFrom", Order = 243)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? ValidFrom { get; set; } 

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough", Order = 244)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? ValidThrough { get; set; } 

        /// <summary>
        /// The warranty promise(s) included in the offer.
        /// </summary>
        [DataMember(Name = "warranty", Order = 245)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<WarrantyPromise>? Warranty { get; set; } 
    }
}
