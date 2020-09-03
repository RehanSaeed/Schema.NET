namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An offer to transfer some rights to an item or to provide a service — for example, an offer to sell tickets to an event, to rent the DVD of a movie, to stream a TV show over the internet, to repair a motorcycle, or to loan a book.&lt;br/&gt;&lt;br/&gt;
    /// Note: As the &lt;a class="localLink" href="https://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; property, which identifies the form of offer (e.g. sell, lease, repair, dispose), defaults to http://purl.org/goodrelations/v1#Sell; an Offer without a defined businessFunction value can be assumed to be an offer to sell.&lt;br/&gt;&lt;br/&gt;
    /// For &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GTIN&lt;/a&gt;-related fields, see &lt;a href="http://www.gs1.org/barcodes/support/check_digit_calculator"&gt;Check Digit calculator&lt;/a&gt; and &lt;a href="http://www.gs1us.org/resources/standards/gtin-validation-guide"&gt;validation guide&lt;/a&gt; from &lt;a href="http://www.gs1.org/"&gt;GS1&lt;/a&gt;.
    /// </summary>
    public partial interface IOffer : IIntangible
    {
        /// <summary>
        /// The payment method(s) accepted by seller for this offer.
        /// </summary>
        Values<ILoanOrCredit, PaymentMethod?> AcceptedPaymentMethod { get; set; }

        /// <summary>
        /// An additional offer that can only be obtained in combination with the first base offer (e.g. supplements and extensions that are available for a surcharge).
        /// </summary>
        OneOrMany<IOffer> AddOn { get; set; }

        /// <summary>
        /// The amount of time that is required between accepting the offer and the actual usage of the resource or service.
        /// </summary>
        OneOrMany<IQuantitativeValue> AdvanceBookingRequirement { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        OneOrMany<IAggregateRating> AggregateRating { get; set; }

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
        Values<int?, DateTime?, DateTimeOffset?, TimeSpan?> AvailabilityEnds { get; set; }

        /// <summary>
        /// The beginning of the availability of the product or service included in the offer.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?, TimeSpan?> AvailabilityStarts { get; set; }

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
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        Values<PhysicalActivityCategory?, string, IThing, Uri> Category { get; set; }

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
        /// See also &lt;a class="localLink" href="https://schema.org/ineligibleRegion"&gt;ineligibleRegion&lt;/a&gt;.
        /// </summary>
        Values<IGeoShape, IPlace, string> EligibleRegion { get; set; }

        /// <summary>
        /// The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
        /// </summary>
        OneOrMany<IPriceSpecification> EligibleTransactionVolume { get; set; }

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
        /// This links to a node or nodes indicating the exact quantity of the products included in  an &lt;a class="localLink" href="https://schema.org/Offer"&gt;Offer&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/ProductCollection"&gt;ProductCollection&lt;/a&gt;.
        /// </summary>
        OneOrMany<ITypeAndQuantityNode> IncludesObject { get; set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is not valid, e.g. a region where the transaction is not allowed.&lt;br/&gt;&lt;br/&gt;
        /// See also &lt;a class="localLink" href="https://schema.org/eligibleRegion"&gt;eligibleRegion&lt;/a&gt;.
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
        /// An item being offered (or demanded). The transactional nature of the offer or demand is documented using &lt;a class="localLink" href="https://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt;, e.g. sell, lease etc. While several common expected types are listed explicitly in this definition, others can be used. Using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.
        /// </summary>
        Values<IAggregateOffer, ICreativeWork, IEvent, IMenuItem, IProduct, IService, ITrip> ItemOffered { get; set; }

        /// <summary>
        /// Length of the lease for some &lt;a class="localLink" href="https://schema.org/Accommodation"&gt;Accommodation&lt;/a&gt;, either particular to some &lt;a class="localLink" href="https://schema.org/Offer"&gt;Offer&lt;/a&gt; or in some cases intrinsic to the property.
        /// </summary>
        Values<TimeSpan?, IQuantitativeValue> LeaseLength { get; set; }

        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        OneOrMany<string> Mpn { get; set; }

        /// <summary>
        /// A pointer to the organization or person making the offer.
        /// </summary>
        Values<IOrganization, IPerson> OfferedBy { get; set; }

        /// <summary>
        /// The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes.&lt;br/&gt;&lt;br/&gt;
        /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Use the &lt;a class="localLink" href="https://schema.org/priceCurrency"&gt;priceCurrency&lt;/a&gt; property (with standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR") instead of including &lt;a href="http://en.wikipedia.org/wiki/Dollar_sign#Currencies_that_use_the_dollar_or_peso_sign"&gt;ambiguous symbols&lt;/a&gt; such as '$' in the value.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;li&gt;Note that both &lt;a href="http://www.w3.org/TR/xhtml-rdfa-primer/#using-the-content-attribute"&gt;RDFa&lt;/a&gt; and Microdata syntax allow the use of a "content=" attribute for publishing simple machine-readable values alongside more human-friendly formatting.&lt;/li&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        Values<decimal?, string> Price { get; set; }

        /// <summary>
        /// The currency of the price, or a price component when attached to &lt;a class="localLink" href="https://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        OneOrMany<string> PriceCurrency { get; set; }

        /// <summary>
        /// One or more detailed price specifications, indicating the unit price and delivery or payment charges.
        /// </summary>
        OneOrMany<IPriceSpecification> PriceSpecification { get; set; }

        /// <summary>
        /// The date after which the price is no longer available.
        /// </summary>
        Values<int?, DateTime?> PriceValidUntil { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        OneOrMany<IReview> Review { get; set; }

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
        Values<int?, DateTime?, DateTimeOffset?> ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }

        /// <summary>
        /// The warranty promise(s) included in the offer.
        /// </summary>
        OneOrMany<IWarrantyPromise> Warranty { get; set; }
    }

    /// <summary>
    /// An offer to transfer some rights to an item or to provide a service — for example, an offer to sell tickets to an event, to rent the DVD of a movie, to stream a TV show over the internet, to repair a motorcycle, or to loan a book.&lt;br/&gt;&lt;br/&gt;
    /// Note: As the &lt;a class="localLink" href="https://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; property, which identifies the form of offer (e.g. sell, lease, repair, dispose), defaults to http://purl.org/goodrelations/v1#Sell; an Offer without a defined businessFunction value can be assumed to be an offer to sell.&lt;br/&gt;&lt;br/&gt;
    /// For &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GTIN&lt;/a&gt;-related fields, see &lt;a href="http://www.gs1.org/barcodes/support/check_digit_calculator"&gt;Check Digit calculator&lt;/a&gt; and &lt;a href="http://www.gs1us.org/resources/standards/gtin-validation-guide"&gt;validation guide&lt;/a&gt; from &lt;a href="http://www.gs1.org/"&gt;GS1&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class Offer : Intangible, IOffer, IEquatable<Offer>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Offer";

        /// <summary>
        /// The payment method(s) accepted by seller for this offer.
        /// </summary>
        [DataMember(Name = "acceptedPaymentMethod", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ILoanOrCredit, PaymentMethod?> AcceptedPaymentMethod { get; set; }

        /// <summary>
        /// An additional offer that can only be obtained in combination with the first base offer (e.g. supplements and extensions that are available for a surcharge).
        /// </summary>
        [DataMember(Name = "addOn", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOffer> AddOn { get; set; }

        /// <summary>
        /// The amount of time that is required between accepting the offer and the actual usage of the resource or service.
        /// </summary>
        [DataMember(Name = "advanceBookingRequirement", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> AdvanceBookingRequirement { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAggregateRating> AggregateRating { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAdministrativeArea, IGeoShape, IPlace, string> AreaServed { get; set; }

        /// <summary>
        /// The availability of this item&amp;#x2014;for example In stock, Out of stock, Pre-order, etc.
        /// </summary>
        [DataMember(Name = "availability", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ItemAvailability?> Availability { get; set; }

        /// <summary>
        /// The end of the availability of the product or service included in the offer.
        /// </summary>
        [DataMember(Name = "availabilityEnds", Order = 212)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?, TimeSpan?> AvailabilityEnds { get; set; }

        /// <summary>
        /// The beginning of the availability of the product or service included in the offer.
        /// </summary>
        [DataMember(Name = "availabilityStarts", Order = 213)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?, TimeSpan?> AvailabilityStarts { get; set; }

        /// <summary>
        /// The place(s) from which the offer can be obtained (e.g. store locations).
        /// </summary>
        [DataMember(Name = "availableAtOrFrom", Order = 214)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> AvailableAtOrFrom { get; set; }

        /// <summary>
        /// The delivery method(s) available for this offer.
        /// </summary>
        [DataMember(Name = "availableDeliveryMethod", Order = 215)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DeliveryMethod?> AvailableDeliveryMethod { get; set; }

        /// <summary>
        /// The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
        /// </summary>
        [DataMember(Name = "businessFunction", Order = 216)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<BusinessFunction?> BusinessFunction { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [DataMember(Name = "category", Order = 217)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<PhysicalActivityCategory?, string, IThing, Uri> Category { get; set; }

        /// <summary>
        /// The typical delay between the receipt of the order and the goods either leaving the warehouse or being prepared for pickup, in case the delivery method is on site pickup.
        /// </summary>
        [DataMember(Name = "deliveryLeadTime", Order = 218)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> DeliveryLeadTime { get; set; }

        /// <summary>
        /// The type(s) of customers for which the given offer is valid.
        /// </summary>
        [DataMember(Name = "eligibleCustomerType", Order = 219)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<BusinessEntityType?> EligibleCustomerType { get; set; }

        /// <summary>
        /// The duration for which the given offer is valid.
        /// </summary>
        [DataMember(Name = "eligibleDuration", Order = 220)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> EligibleDuration { get; set; }

        /// <summary>
        /// The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
        /// </summary>
        [DataMember(Name = "eligibleQuantity", Order = 221)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> EligibleQuantity { get; set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.&lt;br/&gt;&lt;br/&gt;
        /// See also &lt;a class="localLink" href="https://schema.org/ineligibleRegion"&gt;ineligibleRegion&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "eligibleRegion", Order = 222)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IGeoShape, IPlace, string> EligibleRegion { get; set; }

        /// <summary>
        /// The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
        /// </summary>
        [DataMember(Name = "eligibleTransactionVolume", Order = 223)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPriceSpecification> EligibleTransactionVolume { get; set; }

        /// <summary>
        /// A Global Trade Item Number (&lt;a href="https://www.gs1.org/standards/id-keys/gtin"&gt;GTIN&lt;/a&gt;). GTINs identify trade items, including products and services, using numeric identification codes. The &lt;a class="localLink" href="https://schema.org/gtin"&gt;gtin&lt;/a&gt; property generalizes the earlier &lt;a class="localLink" href="https://schema.org/gtin8"&gt;gtin8&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/gtin12"&gt;gtin12&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/gtin13"&gt;gtin13&lt;/a&gt;, and &lt;a class="localLink" href="https://schema.org/gtin14"&gt;gtin14&lt;/a&gt; properties. The GS1 &lt;a href="https://www.gs1.org/standards/Digital-Link/"&gt;digital link specifications&lt;/a&gt; express GTINs as URLs. A correct &lt;a class="localLink" href="https://schema.org/gtin"&gt;gtin&lt;/a&gt; value should be a valid GTIN, which means that it should be an all-numeric string of either 8, 12, 13 or 14 digits, or a "GS1 Digital Link" URL based on such a string. The numeric component should also have a &lt;a href="https://www.gs1.org/services/check-digit-calculator"&gt;valid GS1 check digit&lt;/a&gt; and meet the other rules for valid GTINs. See also &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1's GTIN Summary&lt;/a&gt; and &lt;a href="https://en.wikipedia.org/wiki/Global_Trade_Item_Number"&gt;Wikipedia&lt;/a&gt; for more details. Left-padding of the gtin values is not required or encouraged.
        /// </summary>
        [DataMember(Name = "gtin", Order = 224)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin { get; set; }

        /// <summary>
        /// The GTIN-12 code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin12", Order = 225)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin12 { get; set; }

        /// <summary>
        /// The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin13", Order = 226)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin13 { get; set; }

        /// <summary>
        /// The GTIN-14 code of the product, or the product to which the offer refers. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin14", Order = 227)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin14 { get; set; }

        /// <summary>
        /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-8.aspx"&gt;GTIN-8&lt;/a&gt; code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin8", Order = 228)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin8 { get; set; }

        /// <summary>
        /// This links to a node or nodes indicating the exact quantity of the products included in  an &lt;a class="localLink" href="https://schema.org/Offer"&gt;Offer&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/ProductCollection"&gt;ProductCollection&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "includesObject", Order = 229)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ITypeAndQuantityNode> IncludesObject { get; set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is not valid, e.g. a region where the transaction is not allowed.&lt;br/&gt;&lt;br/&gt;
        /// See also &lt;a class="localLink" href="https://schema.org/eligibleRegion"&gt;eligibleRegion&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "ineligibleRegion", Order = 230)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IGeoShape, IPlace, string> IneligibleRegion { get; set; }

        /// <summary>
        /// The current approximate inventory level for the item or items.
        /// </summary>
        [DataMember(Name = "inventoryLevel", Order = 231)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> InventoryLevel { get; set; }

        /// <summary>
        /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        /// </summary>
        [DataMember(Name = "itemCondition", Order = 232)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<OfferItemCondition?> ItemCondition { get; set; }

        /// <summary>
        /// An item being offered (or demanded). The transactional nature of the offer or demand is documented using &lt;a class="localLink" href="https://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt;, e.g. sell, lease etc. While several common expected types are listed explicitly in this definition, others can be used. Using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.
        /// </summary>
        [DataMember(Name = "itemOffered", Order = 233)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAggregateOffer, ICreativeWork, IEvent, IMenuItem, IProduct, IService, ITrip> ItemOffered { get; set; }

        /// <summary>
        /// Length of the lease for some &lt;a class="localLink" href="https://schema.org/Accommodation"&gt;Accommodation&lt;/a&gt;, either particular to some &lt;a class="localLink" href="https://schema.org/Offer"&gt;Offer&lt;/a&gt; or in some cases intrinsic to the property.
        /// </summary>
        [DataMember(Name = "leaseLength", Order = 234)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public Values<TimeSpan?, IQuantitativeValue> LeaseLength { get; set; }

        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        [DataMember(Name = "mpn", Order = 235)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Mpn { get; set; }

        /// <summary>
        /// A pointer to the organization or person making the offer.
        /// </summary>
        [DataMember(Name = "offeredBy", Order = 236)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> OfferedBy { get; set; }

        /// <summary>
        /// The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes.&lt;br/&gt;&lt;br/&gt;
        /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Use the &lt;a class="localLink" href="https://schema.org/priceCurrency"&gt;priceCurrency&lt;/a&gt; property (with standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR") instead of including &lt;a href="http://en.wikipedia.org/wiki/Dollar_sign#Currencies_that_use_the_dollar_or_peso_sign"&gt;ambiguous symbols&lt;/a&gt; such as '$' in the value.&lt;/li&gt;
        /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
        /// &lt;li&gt;Note that both &lt;a href="http://www.w3.org/TR/xhtml-rdfa-primer/#using-the-content-attribute"&gt;RDFa&lt;/a&gt; and Microdata syntax allow the use of a "content=" attribute for publishing simple machine-readable values alongside more human-friendly formatting.&lt;/li&gt;
        /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "price", Order = 237)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<decimal?, string> Price { get; set; }

        /// <summary>
        /// The currency of the price, or a price component when attached to &lt;a class="localLink" href="https://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        [DataMember(Name = "priceCurrency", Order = 238)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PriceCurrency { get; set; }

        /// <summary>
        /// One or more detailed price specifications, indicating the unit price and delivery or payment charges.
        /// </summary>
        [DataMember(Name = "priceSpecification", Order = 239)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPriceSpecification> PriceSpecification { get; set; }

        /// <summary>
        /// The date after which the price is no longer available.
        /// </summary>
        [DataMember(Name = "priceValidUntil", Order = 240)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> PriceValidUntil { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 241)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IReview> Review { get; set; }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [DataMember(Name = "seller", Order = 242)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Seller { get; set; }

        /// <summary>
        /// The serial number or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial number of the product included in the offer.
        /// </summary>
        [DataMember(Name = "serialNumber", Order = 243)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SerialNumber { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        /// </summary>
        [DataMember(Name = "sku", Order = 244)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Sku { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [DataMember(Name = "validFrom", Order = 245)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough", Order = 246)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }

        /// <summary>
        /// The warranty promise(s) included in the offer.
        /// </summary>
        [DataMember(Name = "warranty", Order = 247)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IWarrantyPromise> Warranty { get; set; }

        /// <inheritdoc/>
        public bool Equals(Offer other)
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
                this.AcceptedPaymentMethod == other.AcceptedPaymentMethod &&
                this.AddOn == other.AddOn &&
                this.AdvanceBookingRequirement == other.AdvanceBookingRequirement &&
                this.AggregateRating == other.AggregateRating &&
                this.AreaServed == other.AreaServed &&
                this.Availability == other.Availability &&
                this.AvailabilityEnds == other.AvailabilityEnds &&
                this.AvailabilityStarts == other.AvailabilityStarts &&
                this.AvailableAtOrFrom == other.AvailableAtOrFrom &&
                this.AvailableDeliveryMethod == other.AvailableDeliveryMethod &&
                this.BusinessFunction == other.BusinessFunction &&
                this.Category == other.Category &&
                this.DeliveryLeadTime == other.DeliveryLeadTime &&
                this.EligibleCustomerType == other.EligibleCustomerType &&
                this.EligibleDuration == other.EligibleDuration &&
                this.EligibleQuantity == other.EligibleQuantity &&
                this.EligibleRegion == other.EligibleRegion &&
                this.EligibleTransactionVolume == other.EligibleTransactionVolume &&
                this.Gtin == other.Gtin &&
                this.Gtin12 == other.Gtin12 &&
                this.Gtin13 == other.Gtin13 &&
                this.Gtin14 == other.Gtin14 &&
                this.Gtin8 == other.Gtin8 &&
                this.IncludesObject == other.IncludesObject &&
                this.IneligibleRegion == other.IneligibleRegion &&
                this.InventoryLevel == other.InventoryLevel &&
                this.ItemCondition == other.ItemCondition &&
                this.ItemOffered == other.ItemOffered &&
                this.LeaseLength == other.LeaseLength &&
                this.Mpn == other.Mpn &&
                this.OfferedBy == other.OfferedBy &&
                this.Price == other.Price &&
                this.PriceCurrency == other.PriceCurrency &&
                this.PriceSpecification == other.PriceSpecification &&
                this.PriceValidUntil == other.PriceValidUntil &&
                this.Review == other.Review &&
                this.Seller == other.Seller &&
                this.SerialNumber == other.SerialNumber &&
                this.Sku == other.Sku &&
                this.ValidFrom == other.ValidFrom &&
                this.ValidThrough == other.ValidThrough &&
                this.Warranty == other.Warranty &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Offer);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AcceptedPaymentMethod)
            .And(this.AddOn)
            .And(this.AdvanceBookingRequirement)
            .And(this.AggregateRating)
            .And(this.AreaServed)
            .And(this.Availability)
            .And(this.AvailabilityEnds)
            .And(this.AvailabilityStarts)
            .And(this.AvailableAtOrFrom)
            .And(this.AvailableDeliveryMethod)
            .And(this.BusinessFunction)
            .And(this.Category)
            .And(this.DeliveryLeadTime)
            .And(this.EligibleCustomerType)
            .And(this.EligibleDuration)
            .And(this.EligibleQuantity)
            .And(this.EligibleRegion)
            .And(this.EligibleTransactionVolume)
            .And(this.Gtin)
            .And(this.Gtin12)
            .And(this.Gtin13)
            .And(this.Gtin14)
            .And(this.Gtin8)
            .And(this.IncludesObject)
            .And(this.IneligibleRegion)
            .And(this.InventoryLevel)
            .And(this.ItemCondition)
            .And(this.ItemOffered)
            .And(this.LeaseLength)
            .And(this.Mpn)
            .And(this.OfferedBy)
            .And(this.Price)
            .And(this.PriceCurrency)
            .And(this.PriceSpecification)
            .And(this.PriceValidUntil)
            .And(this.Review)
            .And(this.Seller)
            .And(this.SerialNumber)
            .And(this.Sku)
            .And(this.ValidFrom)
            .And(this.ValidThrough)
            .And(this.Warranty)
            .And(base.GetHashCode());
    }
}
