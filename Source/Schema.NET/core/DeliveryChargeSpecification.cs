namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The price for the delivery of an offer using a particular delivery method.
    /// </summary>
    public partial interface IDeliveryChargeSpecification : IPriceSpecification
    {
        /// <summary>
        /// The delivery method(s) to which the delivery charge or payment charge specification applies.
        /// </summary>
        OneOrMany<DeliveryMethod?> AppliesToDeliveryMethod { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        Values<IAdministrativeArea, IGeoShape, IPlace, string> AreaServed { get; set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.&lt;br/&gt;&lt;br/&gt;
        /// See also &lt;a class="localLink" href="https://schema.org/ineligibleRegion"&gt;ineligibleRegion&lt;/a&gt;.
        /// </summary>
        Values<IGeoShape, IPlace, string> EligibleRegion { get; set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is not valid, e.g. a region where the transaction is not allowed.&lt;br/&gt;&lt;br/&gt;
        /// See also &lt;a class="localLink" href="https://schema.org/eligibleRegion"&gt;eligibleRegion&lt;/a&gt;.
        /// </summary>
        Values<IGeoShape, IPlace, string> IneligibleRegion { get; set; }
    }

    /// <summary>
    /// The price for the delivery of an offer using a particular delivery method.
    /// </summary>
    [DataContract]
    public partial class DeliveryChargeSpecification : PriceSpecification, IDeliveryChargeSpecification, IEquatable<DeliveryChargeSpecification>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DeliveryChargeSpecification";

        /// <summary>
        /// The delivery method(s) to which the delivery charge or payment charge specification applies.
        /// </summary>
        [DataMember(Name = "appliesToDeliveryMethod", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DeliveryMethod?> AppliesToDeliveryMethod { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 407)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAdministrativeArea, IGeoShape, IPlace, string> AreaServed { get; set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.&lt;br/&gt;&lt;br/&gt;
        /// See also &lt;a class="localLink" href="https://schema.org/ineligibleRegion"&gt;ineligibleRegion&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "eligibleRegion", Order = 408)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IGeoShape, IPlace, string> EligibleRegion { get; set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is not valid, e.g. a region where the transaction is not allowed.&lt;br/&gt;&lt;br/&gt;
        /// See also &lt;a class="localLink" href="https://schema.org/eligibleRegion"&gt;eligibleRegion&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "ineligibleRegion", Order = 409)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IGeoShape, IPlace, string> IneligibleRegion { get; set; }

        /// <inheritdoc/>
        public bool Equals(DeliveryChargeSpecification other)
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
                this.AppliesToDeliveryMethod == other.AppliesToDeliveryMethod &&
                this.AreaServed == other.AreaServed &&
                this.EligibleRegion == other.EligibleRegion &&
                this.IneligibleRegion == other.IneligibleRegion &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as DeliveryChargeSpecification);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AppliesToDeliveryMethod)
            .And(this.AreaServed)
            .And(this.EligibleRegion)
            .And(this.IneligibleRegion)
            .And(base.GetHashCode());
    }
}
