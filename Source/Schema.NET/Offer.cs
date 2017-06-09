namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An offer to transfer some rights to an item or to provide a service — for example, an offer to sell tickets to an event, to rent the DVD of a movie, to stream a TV show over the internet, to repair a motorcycle, or to loan a book...
    /// </summary>
    [DataContract]
    public class Offer : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Offer";

        /// <summary>
        /// The payment method(s) accepted by seller for this offer.
        /// </summary>
        [DataMember(Name = "acceptedPaymentMethod", Order = 2)]
        public object AcceptedPaymentMethod { get; protected set; }

        /// <summary>
        /// The payment method(s) accepted by seller for this offer.
        /// </summary>
        [IgnoreDataMember]
        public LoanOrCredit AcceptedPaymentMethodLoanOrCredit
        {
            get => this.AcceptedPaymentMethod as LoanOrCredit;
            set => this.AcceptedPaymentMethod = value;
        }

        /// <summary>
        /// The payment method(s) accepted by seller for this offer.
        /// </summary>
        [IgnoreDataMember]
        public PaymentMethod AcceptedPaymentMethodPaymentMethod
        {
            get => this.AcceptedPaymentMethod as PaymentMethod;
            set => this.AcceptedPaymentMethod = value;
        }

        /// <summary>
        /// An additional offer that can only be obtained in combination with the first base offer (e.g. supplements and extensions that are available for a surcharge).
        /// </summary>
        [DataMember(Name = "addOn", Order = 3)]
        public Offer AddOn { get; set; }

        /// <summary>
        /// The amount of time that is required between accepting the offer and the actual usage of the resource or service.
        /// </summary>
        [DataMember(Name = "advanceBookingRequirement", Order = 4)]
        public QuantitativeValue AdvanceBookingRequirement { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 5)]
        public AggregateRating AggregateRating { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 6)]
        public object AreaServed { get; protected set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [IgnoreDataMember]
        public AdministrativeArea AreaServedAdministrativeArea
        {
            get => this.AreaServed as AdministrativeArea;
            set => this.AreaServed = value;
        }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [IgnoreDataMember]
        public GeoShape AreaServedGeoShape
        {
            get => this.AreaServed as GeoShape;
            set => this.AreaServed = value;
        }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [IgnoreDataMember]
        public Place AreaServedPlace
        {
            get => this.AreaServed as Place;
            set => this.AreaServed = value;
        }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [IgnoreDataMember]
        public string AreaServedText
        {
            get => this.AreaServed as string;
            set => this.AreaServed = value;
        }

        /// <summary>
        /// The availability of this item&amp;#x2014;for example In stock, Out of stock, Pre-order, etc.
        /// </summary>
        [DataMember(Name = "availability", Order = 7)]
        public ItemAvailability Availability { get; set; }

        /// <summary>
        /// The end of the availability of the product or service included in the offer.
        /// </summary>
        [DataMember(Name = "availabilityEnds", Order = 8)]
        public DateTimeOffset? AvailabilityEnds { get; set; }

        /// <summary>
        /// The beginning of the availability of the product or service included in the offer.
        /// </summary>
        [DataMember(Name = "availabilityStarts", Order = 9)]
        public DateTimeOffset? AvailabilityStarts { get; set; }

        /// <summary>
        /// The place(s) from which the offer can be obtained (e.g. store locations).
        /// </summary>
        [DataMember(Name = "availableAtOrFrom", Order = 10)]
        public Place AvailableAtOrFrom { get; set; }

        /// <summary>
        /// The delivery method(s) available for this offer.
        /// </summary>
        [DataMember(Name = "availableDeliveryMethod", Order = 11)]
        public DeliveryMethod AvailableDeliveryMethod { get; set; }

        /// <summary>
        /// The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
        /// </summary>
        [DataMember(Name = "businessFunction", Order = 12)]
        public BusinessFunction BusinessFunction { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [DataMember(Name = "category", Order = 13)]
        public object Category { get; protected set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [IgnoreDataMember]
        public Thing CategoryThing
        {
            get => this.Category as Thing;
            set => this.Category = value;
        }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [IgnoreDataMember]
        public string CategoryText
        {
            get => this.Category as string;
            set => this.Category = value;
        }

        /// <summary>
        /// The typical delay between the receipt of the order and the goods either leaving the warehouse or being prepared for pickup, in case the delivery method is on site pickup.
        /// </summary>
        [DataMember(Name = "deliveryLeadTime", Order = 14)]
        public QuantitativeValue DeliveryLeadTime { get; set; }

        /// <summary>
        /// The type(s) of customers for which the given offer is valid.
        /// </summary>
        [DataMember(Name = "eligibleCustomerType", Order = 15)]
        public BusinessEntityType EligibleCustomerType { get; set; }

        /// <summary>
        /// The duration for which the given offer is valid.
        /// </summary>
        [DataMember(Name = "eligibleDuration", Order = 16)]
        public QuantitativeValue EligibleDuration { get; set; }

        /// <summary>
        /// The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
        /// </summary>
        [DataMember(Name = "eligibleQuantity", Order = 17)]
        public QuantitativeValue EligibleQuantity { get; set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.&lt;/p&gt;
        /// &lt;p&gt;See also &lt;a class="localLink" href="http://schema.org/ineligibleRegion"&gt;ineligibleRegion&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "eligibleRegion", Order = 18)]
        public object EligibleRegion { get; protected set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.&lt;/p&gt;
        /// &lt;p&gt;See also &lt;a class="localLink" href="http://schema.org/ineligibleRegion"&gt;ineligibleRegion&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public GeoShape EligibleRegionGeoShape
        {
            get => this.EligibleRegion as GeoShape;
            set => this.EligibleRegion = value;
        }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.&lt;/p&gt;
        /// &lt;p&gt;See also &lt;a class="localLink" href="http://schema.org/ineligibleRegion"&gt;ineligibleRegion&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public Place EligibleRegionPlace
        {
            get => this.EligibleRegion as Place;
            set => this.EligibleRegion = value;
        }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.&lt;/p&gt;
        /// &lt;p&gt;See also &lt;a class="localLink" href="http://schema.org/ineligibleRegion"&gt;ineligibleRegion&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public string EligibleRegionText
        {
            get => this.EligibleRegion as string;
            set => this.EligibleRegion = value;
        }

        /// <summary>
        /// The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
        /// </summary>
        [DataMember(Name = "eligibleTransactionVolume", Order = 19)]
        public PriceSpecification EligibleTransactionVolume { get; set; }

        /// <summary>
        /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-12.aspx"&gt;GTIN-12&lt;/a&gt; code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin12", Order = 20)]
        public string Gtin12 { get; set; }

        /// <summary>
        /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-13.aspx"&gt;GTIN-13&lt;/a&gt; code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin13", Order = 21)]
        public string Gtin13 { get; set; }

        /// <summary>
        /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-14.aspx"&gt;GTIN-14&lt;/a&gt; code of the product, or the product to which the offer refers. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin14", Order = 22)]
        public string Gtin14 { get; set; }

        /// <summary>
        /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-8.aspx"&gt;GTIN-8&lt;/a&gt; code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin8", Order = 23)]
        public string Gtin8 { get; set; }

        /// <summary>
        /// This links to a node or nodes indicating the exact quantity of the products included in the offer.
        /// </summary>
        [DataMember(Name = "includesObject", Order = 24)]
        public TypeAndQuantityNode IncludesObject { get; set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is not valid, e.g. a region where the transaction is not allowed.&lt;/p&gt;
        /// &lt;p&gt;See also &lt;a class="localLink" href="http://schema.org/eligibleRegion"&gt;eligibleRegion&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "ineligibleRegion", Order = 25)]
        public object IneligibleRegion { get; protected set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is not valid, e.g. a region where the transaction is not allowed.&lt;/p&gt;
        /// &lt;p&gt;See also &lt;a class="localLink" href="http://schema.org/eligibleRegion"&gt;eligibleRegion&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public string IneligibleRegionText
        {
            get => this.IneligibleRegion as string;
            set => this.IneligibleRegion = value;
        }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is not valid, e.g. a region where the transaction is not allowed.&lt;/p&gt;
        /// &lt;p&gt;See also &lt;a class="localLink" href="http://schema.org/eligibleRegion"&gt;eligibleRegion&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public GeoShape IneligibleRegionGeoShape
        {
            get => this.IneligibleRegion as GeoShape;
            set => this.IneligibleRegion = value;
        }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is not valid, e.g. a region where the transaction is not allowed.&lt;/p&gt;
        /// &lt;p&gt;See also &lt;a class="localLink" href="http://schema.org/eligibleRegion"&gt;eligibleRegion&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public Place IneligibleRegionPlace
        {
            get => this.IneligibleRegion as Place;
            set => this.IneligibleRegion = value;
        }

        /// <summary>
        /// The current approximate inventory level for the item or items.
        /// </summary>
        [DataMember(Name = "inventoryLevel", Order = 26)]
        public QuantitativeValue InventoryLevel { get; set; }

        /// <summary>
        /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        /// </summary>
        [DataMember(Name = "itemCondition", Order = 27)]
        public OfferItemCondition ItemCondition { get; set; }

        /// <summary>
        /// The item being offered.
        /// </summary>
        [DataMember(Name = "itemOffered", Order = 28)]
        public object ItemOffered { get; protected set; }

        /// <summary>
        /// The item being offered.
        /// </summary>
        [IgnoreDataMember]
        public Service ItemOfferedService
        {
            get => this.ItemOffered as Service;
            set => this.ItemOffered = value;
        }

        /// <summary>
        /// The item being offered.
        /// </summary>
        [IgnoreDataMember]
        public Product ItemOfferedProduct
        {
            get => this.ItemOffered as Product;
            set => this.ItemOffered = value;
        }

        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        [DataMember(Name = "mpn", Order = 29)]
        public string Mpn { get; set; }

        /// <summary>
        /// A pointer to the organization or person making the offer.
        /// </summary>
        [DataMember(Name = "offeredBy", Order = 30)]
        public object OfferedBy { get; protected set; }

        /// <summary>
        /// A pointer to the organization or person making the offer.
        /// </summary>
        [IgnoreDataMember]
        public Person OfferedByPerson
        {
            get => this.OfferedBy as Person;
            set => this.OfferedBy = value;
        }

        /// <summary>
        /// A pointer to the organization or person making the offer.
        /// </summary>
        [IgnoreDataMember]
        public Organization OfferedByOrganization
        {
            get => this.OfferedBy as Organization;
            set => this.OfferedBy = value;
        }

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
        [DataMember(Name = "price", Order = 31)]
        public object Price { get; protected set; }

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
        [IgnoreDataMember]
        public string PriceText
        {
            get => this.Price as string;
            set => this.Price = value;
        }

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
        [IgnoreDataMember]
        public decimal? PriceNumber
        {
            get => this.Price as decimal?;
            set => this.Price = value;
        }

        /// <summary>
        /// The currency (in 3-letter ISO 4217 format) of the price or a price component, when attached to &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.
        /// </summary>
        [DataMember(Name = "priceCurrency", Order = 32)]
        public string PriceCurrency { get; set; }

        /// <summary>
        /// One or more detailed price specifications, indicating the unit price and delivery or payment charges.
        /// </summary>
        [DataMember(Name = "priceSpecification", Order = 33)]
        public PriceSpecification PriceSpecification { get; set; }

        /// <summary>
        /// The date after which the price is no longer available.
        /// </summary>
        [DataMember(Name = "priceValidUntil", Order = 34)]
        public DateTimeOffset? PriceValidUntil { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 35)]
        public Review Review { get; set; }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [DataMember(Name = "seller", Order = 36)]
        public object Seller { get; protected set; }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [IgnoreDataMember]
        public Organization SellerOrganization
        {
            get => this.Seller as Organization;
            set => this.Seller = value;
        }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [IgnoreDataMember]
        public Person SellerPerson
        {
            get => this.Seller as Person;
            set => this.Seller = value;
        }

        /// <summary>
        /// The serial number or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial number of the product included in the offer.
        /// </summary>
        [DataMember(Name = "serialNumber", Order = 37)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        /// </summary>
        [DataMember(Name = "sku", Order = 38)]
        public string Sku { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [DataMember(Name = "validFrom", Order = 39)]
        public DateTimeOffset? ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough", Order = 40)]
        public DateTimeOffset? ValidThrough { get; set; }

        /// <summary>
        /// The warranty promise(s) included in the offer.
        /// </summary>
        [DataMember(Name = "warranty", Order = 41)]
        public WarrantyPromise Warranty { get; set; }
    }
}
