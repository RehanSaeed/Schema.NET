namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The price for the delivery of an offer using a particular delivery method.
    /// </summary>
    [DataContract]
    public partial class DeliveryChargeSpecification : PriceSpecification
    {
        public interface IAppliesToDeliveryMethod : IValue {}
        public interface IAppliesToDeliveryMethod<T> : IAppliesToDeliveryMethod { new T Value { get; } }
        public class OneOrManyAppliesToDeliveryMethod : OneOrMany<IAppliesToDeliveryMethod>
        {
            public OneOrManyAppliesToDeliveryMethod(IAppliesToDeliveryMethod item) : base(item) { }
            public OneOrManyAppliesToDeliveryMethod(IEnumerable<IAppliesToDeliveryMethod> items) : base(items) { }
            public static implicit operator OneOrManyAppliesToDeliveryMethod (DeliveryMethod value) { return new OneOrManyAppliesToDeliveryMethod (new AppliesToDeliveryMethodDeliveryMethod (value)); }
            public static implicit operator OneOrManyAppliesToDeliveryMethod (DeliveryMethod[] values) { return new OneOrManyAppliesToDeliveryMethod (values.Select(v => (IAppliesToDeliveryMethod) new AppliesToDeliveryMethodDeliveryMethod (v))); }
            public static implicit operator OneOrManyAppliesToDeliveryMethod (List<DeliveryMethod> values) { return new OneOrManyAppliesToDeliveryMethod (values.Select(v => (IAppliesToDeliveryMethod) new AppliesToDeliveryMethodDeliveryMethod (v))); }
        }
        public struct AppliesToDeliveryMethodDeliveryMethod : IAppliesToDeliveryMethod<DeliveryMethod>
        {
            object IValue.Value => this.Value;
            public DeliveryMethod Value { get; }
            public AppliesToDeliveryMethodDeliveryMethod (DeliveryMethod value) { Value = value; }
            public static implicit operator AppliesToDeliveryMethodDeliveryMethod (DeliveryMethod value) { return new AppliesToDeliveryMethodDeliveryMethod (value); }
        }

        public interface IAreaServed : IValue {}
        public interface IAreaServed<T> : IAreaServed { new T Value { get; } }
        public class OneOrManyAreaServed : OneOrMany<IAreaServed>
        {
            public OneOrManyAreaServed(IAreaServed item) : base(item) { }
            public OneOrManyAreaServed(IEnumerable<IAreaServed> items) : base(items) { }
            public static implicit operator OneOrManyAreaServed (AdministrativeArea value) { return new OneOrManyAreaServed (new AreaServedAdministrativeArea (value)); }
            public static implicit operator OneOrManyAreaServed (AdministrativeArea[] values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedAdministrativeArea (v))); }
            public static implicit operator OneOrManyAreaServed (List<AdministrativeArea> values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedAdministrativeArea (v))); }
            public static implicit operator OneOrManyAreaServed (GeoShape value) { return new OneOrManyAreaServed (new AreaServedGeoShape (value)); }
            public static implicit operator OneOrManyAreaServed (GeoShape[] values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedGeoShape (v))); }
            public static implicit operator OneOrManyAreaServed (List<GeoShape> values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedGeoShape (v))); }
            public static implicit operator OneOrManyAreaServed (Place value) { return new OneOrManyAreaServed (new AreaServedPlace (value)); }
            public static implicit operator OneOrManyAreaServed (Place[] values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedPlace (v))); }
            public static implicit operator OneOrManyAreaServed (List<Place> values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedPlace (v))); }
            public static implicit operator OneOrManyAreaServed (string value) { return new OneOrManyAreaServed (new AreaServedstring (value)); }
            public static implicit operator OneOrManyAreaServed (string[] values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedstring (v))); }
            public static implicit operator OneOrManyAreaServed (List<string> values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedstring (v))); }
        }
        public struct AreaServedAdministrativeArea : IAreaServed<AdministrativeArea>
        {
            object IValue.Value => this.Value;
            public AdministrativeArea Value { get; }
            public AreaServedAdministrativeArea (AdministrativeArea value) { Value = value; }
            public static implicit operator AreaServedAdministrativeArea (AdministrativeArea value) { return new AreaServedAdministrativeArea (value); }
        }
        public struct AreaServedGeoShape : IAreaServed<GeoShape>
        {
            object IValue.Value => this.Value;
            public GeoShape Value { get; }
            public AreaServedGeoShape (GeoShape value) { Value = value; }
            public static implicit operator AreaServedGeoShape (GeoShape value) { return new AreaServedGeoShape (value); }
        }
        public struct AreaServedPlace : IAreaServed<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public AreaServedPlace (Place value) { Value = value; }
            public static implicit operator AreaServedPlace (Place value) { return new AreaServedPlace (value); }
        }
        public struct AreaServedstring : IAreaServed<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AreaServedstring (string value) { Value = value; }
            public static implicit operator AreaServedstring (string value) { return new AreaServedstring (value); }
        }

        public interface IEligibleRegion : IValue {}
        public interface IEligibleRegion<T> : IEligibleRegion { new T Value { get; } }
        public class OneOrManyEligibleRegion : OneOrMany<IEligibleRegion>
        {
            public OneOrManyEligibleRegion(IEligibleRegion item) : base(item) { }
            public OneOrManyEligibleRegion(IEnumerable<IEligibleRegion> items) : base(items) { }
            public static implicit operator OneOrManyEligibleRegion (GeoShape value) { return new OneOrManyEligibleRegion (new EligibleRegionGeoShape (value)); }
            public static implicit operator OneOrManyEligibleRegion (GeoShape[] values) { return new OneOrManyEligibleRegion (values.Select(v => (IEligibleRegion) new EligibleRegionGeoShape (v))); }
            public static implicit operator OneOrManyEligibleRegion (List<GeoShape> values) { return new OneOrManyEligibleRegion (values.Select(v => (IEligibleRegion) new EligibleRegionGeoShape (v))); }
            public static implicit operator OneOrManyEligibleRegion (Place value) { return new OneOrManyEligibleRegion (new EligibleRegionPlace (value)); }
            public static implicit operator OneOrManyEligibleRegion (Place[] values) { return new OneOrManyEligibleRegion (values.Select(v => (IEligibleRegion) new EligibleRegionPlace (v))); }
            public static implicit operator OneOrManyEligibleRegion (List<Place> values) { return new OneOrManyEligibleRegion (values.Select(v => (IEligibleRegion) new EligibleRegionPlace (v))); }
            public static implicit operator OneOrManyEligibleRegion (string value) { return new OneOrManyEligibleRegion (new EligibleRegionstring (value)); }
            public static implicit operator OneOrManyEligibleRegion (string[] values) { return new OneOrManyEligibleRegion (values.Select(v => (IEligibleRegion) new EligibleRegionstring (v))); }
            public static implicit operator OneOrManyEligibleRegion (List<string> values) { return new OneOrManyEligibleRegion (values.Select(v => (IEligibleRegion) new EligibleRegionstring (v))); }
        }
        public struct EligibleRegionGeoShape : IEligibleRegion<GeoShape>
        {
            object IValue.Value => this.Value;
            public GeoShape Value { get; }
            public EligibleRegionGeoShape (GeoShape value) { Value = value; }
            public static implicit operator EligibleRegionGeoShape (GeoShape value) { return new EligibleRegionGeoShape (value); }
        }
        public struct EligibleRegionPlace : IEligibleRegion<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public EligibleRegionPlace (Place value) { Value = value; }
            public static implicit operator EligibleRegionPlace (Place value) { return new EligibleRegionPlace (value); }
        }
        public struct EligibleRegionstring : IEligibleRegion<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public EligibleRegionstring (string value) { Value = value; }
            public static implicit operator EligibleRegionstring (string value) { return new EligibleRegionstring (value); }
        }

        public interface IIneligibleRegion : IValue {}
        public interface IIneligibleRegion<T> : IIneligibleRegion { new T Value { get; } }
        public class OneOrManyIneligibleRegion : OneOrMany<IIneligibleRegion>
        {
            public OneOrManyIneligibleRegion(IIneligibleRegion item) : base(item) { }
            public OneOrManyIneligibleRegion(IEnumerable<IIneligibleRegion> items) : base(items) { }
            public static implicit operator OneOrManyIneligibleRegion (GeoShape value) { return new OneOrManyIneligibleRegion (new IneligibleRegionGeoShape (value)); }
            public static implicit operator OneOrManyIneligibleRegion (GeoShape[] values) { return new OneOrManyIneligibleRegion (values.Select(v => (IIneligibleRegion) new IneligibleRegionGeoShape (v))); }
            public static implicit operator OneOrManyIneligibleRegion (List<GeoShape> values) { return new OneOrManyIneligibleRegion (values.Select(v => (IIneligibleRegion) new IneligibleRegionGeoShape (v))); }
            public static implicit operator OneOrManyIneligibleRegion (Place value) { return new OneOrManyIneligibleRegion (new IneligibleRegionPlace (value)); }
            public static implicit operator OneOrManyIneligibleRegion (Place[] values) { return new OneOrManyIneligibleRegion (values.Select(v => (IIneligibleRegion) new IneligibleRegionPlace (v))); }
            public static implicit operator OneOrManyIneligibleRegion (List<Place> values) { return new OneOrManyIneligibleRegion (values.Select(v => (IIneligibleRegion) new IneligibleRegionPlace (v))); }
            public static implicit operator OneOrManyIneligibleRegion (string value) { return new OneOrManyIneligibleRegion (new IneligibleRegionstring (value)); }
            public static implicit operator OneOrManyIneligibleRegion (string[] values) { return new OneOrManyIneligibleRegion (values.Select(v => (IIneligibleRegion) new IneligibleRegionstring (v))); }
            public static implicit operator OneOrManyIneligibleRegion (List<string> values) { return new OneOrManyIneligibleRegion (values.Select(v => (IIneligibleRegion) new IneligibleRegionstring (v))); }
        }
        public struct IneligibleRegionGeoShape : IIneligibleRegion<GeoShape>
        {
            object IValue.Value => this.Value;
            public GeoShape Value { get; }
            public IneligibleRegionGeoShape (GeoShape value) { Value = value; }
            public static implicit operator IneligibleRegionGeoShape (GeoShape value) { return new IneligibleRegionGeoShape (value); }
        }
        public struct IneligibleRegionPlace : IIneligibleRegion<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public IneligibleRegionPlace (Place value) { Value = value; }
            public static implicit operator IneligibleRegionPlace (Place value) { return new IneligibleRegionPlace (value); }
        }
        public struct IneligibleRegionstring : IIneligibleRegion<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public IneligibleRegionstring (string value) { Value = value; }
            public static implicit operator IneligibleRegionstring (string value) { return new IneligibleRegionstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DeliveryChargeSpecification";

        /// <summary>
        /// The delivery method(s) to which the delivery charge or payment charge specification applies.
        /// </summary>
        [DataMember(Name = "appliesToDeliveryMethod", Order = 406)]
        public OneOrManyAppliesToDeliveryMethod AppliesToDeliveryMethod { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 407)]
        public OneOrManyAreaServed AreaServed { get; set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.&lt;br/&gt;&lt;br/&gt;
        /// See also &lt;a class="localLink" href="http://schema.org/ineligibleRegion"&gt;ineligibleRegion&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "eligibleRegion", Order = 408)]
        public OneOrManyEligibleRegion EligibleRegion { get; set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is not valid, e.g. a region where the transaction is not allowed.&lt;br/&gt;&lt;br/&gt;
        /// See also &lt;a class="localLink" href="http://schema.org/eligibleRegion"&gt;eligibleRegion&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "ineligibleRegion", Order = 409)]
        public OneOrManyIneligibleRegion IneligibleRegion { get; set; }
    }
}
