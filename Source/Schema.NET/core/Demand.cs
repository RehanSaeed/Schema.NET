namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
    public partial interface IDemand : IIntangible
    {
        /// <summary>
        /// The payment method(s) accepted by seller for this offer.
        /// </summary>
        Values<ILoanOrCredit, PaymentMethod?> AcceptedPaymentMethod { get; set; }

        /// <summary>
        /// The amount of time that is required between accepting the offer and the actual usage of the resource or service.
        /// </summary>
        OneOrMany<IQuantitativeValue> AdvanceBookingRequirement { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        Values<IAdministrativeArea, IGeoShape, IPlace, string> AreaServed { get; set; }

        /// <summary>
        /// The availability of this item&amp;#x2014;for example In stock, Out of stock, Pre-order, etc.
        /// </summary>
        OneOrMany<ItemAvailability?> Availability { get; set; }

        /// <summary>
        /// The end of the availability of the product or service included in the offer.
        /// </summary>
        OneOrMany<DateTimeOffset?> AvailabilityEnds { get; set; }

        /// <summary>
        /// The beginning of the availability of the product or service included in the offer.
        /// </summary>
        OneOrMany<DateTimeOffset?> AvailabilityStarts { get; set; }

        /// <summary>
        /// The place(s) from which the offer can be obtained (e.g. store locations).
        /// </summary>
        OneOrMany<IPlace> AvailableAtOrFrom { get; set; }

        /// <summary>
        /// The delivery method(s) available for this offer.
        /// </summary>
        OneOrMany<DeliveryMethod?> AvailableDeliveryMethod { get; set; }

        /// <summary>
        /// The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
        /// </summary>
        OneOrMany<BusinessFunction?> BusinessFunction { get; set; }

        /// <summary>
        /// The typical delay between the receipt of the order and the goods either leaving the warehouse or being prepared for pickup, in case the delivery method is on site pickup.
        /// </summary>
        OneOrMany<IQuantitativeValue> DeliveryLeadTime { get; set; }

        /// <summary>
        /// The type(s) of customers for which the given offer is valid.
        /// </summary>
        OneOrMany<BusinessEntityType?> EligibleCustomerType { get; set; }

        /// <summary>
        /// The duration for which the given offer is valid.
        /// </summary>
        OneOrMany<IQuantitativeValue> EligibleDuration { get; set; }

        /// <summary>
        /// The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
        /// </summary>
        OneOrMany<IQuantitativeValue> EligibleQuantity { get; set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.&lt;br/&gt;&lt;br/&gt;
        /// See also &lt;a class="localLink" href="http://schema.org/ineligibleRegion"&gt;ineligibleRegion&lt;/a&gt;.
        /// </summary>
        Values<IGeoShape, IPlace, string> EligibleRegion { get; set; }

        /// <summary>
        /// The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
        /// </summary>
        OneOrMany<IPriceSpecification> EligibleTransactionVolume { get; set; }

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
        /// This links to a node or nodes indicating the exact quantity of the products included in the offer.
        /// </summary>
        OneOrMany<ITypeAndQuantityNode> IncludesObject { get; set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is not valid, e.g. a region where the transaction is not allowed.&lt;br/&gt;&lt;br/&gt;
        /// See also &lt;a class="localLink" href="http://schema.org/eligibleRegion"&gt;eligibleRegion&lt;/a&gt;.
        /// </summary>
        Values<IGeoShape, IPlace, string> IneligibleRegion { get; set; }

        /// <summary>
        /// The current approximate inventory level for the item or items.
        /// </summary>
        OneOrMany<IQuantitativeValue> InventoryLevel { get; set; }

        /// <summary>
        /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        /// </summary>
        OneOrMany<OfferItemCondition?> ItemCondition { get; set; }

        /// <summary>
        /// The item being offered.
        /// </summary>
        Values<IProduct, IService> ItemOffered { get; set; }

        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        OneOrMany<string> Mpn { get; set; }

        /// <summary>
        /// One or more detailed price specifications, indicating the unit price and delivery or payment charges.
        /// </summary>
        OneOrMany<IPriceSpecification> PriceSpecification { get; set; }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        Values<IOrganization, IPerson> Seller { get; set; }

        /// <summary>
        /// The serial number or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial number of the product included in the offer.
        /// </summary>
        OneOrMany<string> SerialNumber { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        /// </summary>
        OneOrMany<string> Sku { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        OneOrMany<DateTimeOffset?> ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        OneOrMany<DateTimeOffset?> ValidThrough { get; set; }

        /// <summary>
        /// The warranty promise(s) included in the offer.
        /// </summary>
        OneOrMany<IWarrantyPromise> Warranty { get; set; }
    }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
    [DataContract]
    public partial class Demand : Intangible, IDemand
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Demand";

        /// <summary>
        /// The payment method(s) accepted by seller for this offer.
        /// </summary>
        [DataMember(Name = "acceptedPaymentMethod", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ILoanOrCredit, PaymentMethod?> AcceptedPaymentMethod { get; set; }

        /// <summary>
        /// The amount of time that is required between accepting the offer and the actual usage of the resource or service.
        /// </summary>
        [DataMember(Name = "advanceBookingRequirement", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> AdvanceBookingRequirement { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAdministrativeArea, IGeoShape, IPlace, string> AreaServed { get; set; }

        /// <summary>
        /// The availability of this item&amp;#x2014;for example In stock, Out of stock, Pre-order, etc.
        /// </summary>
        [DataMember(Name = "availability", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ItemAvailability?> Availability { get; set; }

        /// <summary>
        /// The end of the availability of the product or service included in the offer.
        /// </summary>
        [DataMember(Name = "availabilityEnds", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> AvailabilityEnds { get; set; }

        /// <summary>
        /// The beginning of the availability of the product or service included in the offer.
        /// </summary>
        [DataMember(Name = "availabilityStarts", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> AvailabilityStarts { get; set; }

        /// <summary>
        /// The place(s) from which the offer can be obtained (e.g. store locations).
        /// </summary>
        [DataMember(Name = "availableAtOrFrom", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> AvailableAtOrFrom { get; set; }

        /// <summary>
        /// The delivery method(s) available for this offer.
        /// </summary>
        [DataMember(Name = "availableDeliveryMethod", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DeliveryMethod?> AvailableDeliveryMethod { get; set; }

        /// <summary>
        /// The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
        /// </summary>
        [DataMember(Name = "businessFunction", Order = 214)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<BusinessFunction?> BusinessFunction { get; set; }

        /// <summary>
        /// The typical delay between the receipt of the order and the goods either leaving the warehouse or being prepared for pickup, in case the delivery method is on site pickup.
        /// </summary>
        [DataMember(Name = "deliveryLeadTime", Order = 215)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> DeliveryLeadTime { get; set; }

        /// <summary>
        /// The type(s) of customers for which the given offer is valid.
        /// </summary>
        [DataMember(Name = "eligibleCustomerType", Order = 216)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<BusinessEntityType?> EligibleCustomerType { get; set; }

        /// <summary>
        /// The duration for which the given offer is valid.
        /// </summary>
        [DataMember(Name = "eligibleDuration", Order = 217)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> EligibleDuration { get; set; }

        /// <summary>
        /// The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
        /// </summary>
        [DataMember(Name = "eligibleQuantity", Order = 218)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> EligibleQuantity { get; set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.&lt;br/&gt;&lt;br/&gt;
        /// See also &lt;a class="localLink" href="http://schema.org/ineligibleRegion"&gt;ineligibleRegion&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "eligibleRegion", Order = 219)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IGeoShape, IPlace, string> EligibleRegion { get; set; }

        /// <summary>
        /// The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
        /// </summary>
        [DataMember(Name = "eligibleTransactionVolume", Order = 220)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPriceSpecification> EligibleTransactionVolume { get; set; }

        /// <summary>
        /// The GTIN-12 code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin12", Order = 221)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin12 { get; set; }

        /// <summary>
        /// The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin13", Order = 222)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin13 { get; set; }

        /// <summary>
        /// The GTIN-14 code of the product, or the product to which the offer refers. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin14", Order = 223)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin14 { get; set; }

        /// <summary>
        /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-8.aspx"&gt;GTIN-8&lt;/a&gt; code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin8", Order = 224)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin8 { get; set; }

        /// <summary>
        /// This links to a node or nodes indicating the exact quantity of the products included in the offer.
        /// </summary>
        [DataMember(Name = "includesObject", Order = 225)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ITypeAndQuantityNode> IncludesObject { get; set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is not valid, e.g. a region where the transaction is not allowed.&lt;br/&gt;&lt;br/&gt;
        /// See also &lt;a class="localLink" href="http://schema.org/eligibleRegion"&gt;eligibleRegion&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "ineligibleRegion", Order = 226)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IGeoShape, IPlace, string> IneligibleRegion { get; set; }

        /// <summary>
        /// The current approximate inventory level for the item or items.
        /// </summary>
        [DataMember(Name = "inventoryLevel", Order = 227)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> InventoryLevel { get; set; }

        /// <summary>
        /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        /// </summary>
        [DataMember(Name = "itemCondition", Order = 228)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<OfferItemCondition?> ItemCondition { get; set; }

        /// <summary>
        /// The item being offered.
        /// </summary>
        [DataMember(Name = "itemOffered", Order = 229)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IProduct, IService> ItemOffered { get; set; }

        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        [DataMember(Name = "mpn", Order = 230)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Mpn { get; set; }

        /// <summary>
        /// One or more detailed price specifications, indicating the unit price and delivery or payment charges.
        /// </summary>
        [DataMember(Name = "priceSpecification", Order = 231)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPriceSpecification> PriceSpecification { get; set; }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [DataMember(Name = "seller", Order = 232)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Seller { get; set; }

        /// <summary>
        /// The serial number or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial number of the product included in the offer.
        /// </summary>
        [DataMember(Name = "serialNumber", Order = 233)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SerialNumber { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        /// </summary>
        [DataMember(Name = "sku", Order = 234)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Sku { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [DataMember(Name = "validFrom", Order = 235)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough", Order = 236)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> ValidThrough { get; set; }

        /// <summary>
        /// The warranty promise(s) included in the offer.
        /// </summary>
        [DataMember(Name = "warranty", Order = 237)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IWarrantyPromise> Warranty { get; set; }
    }
}
