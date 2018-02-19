using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// The price for the delivery of an offer using a particular delivery method.
    /// </summary>
    [DataContract]
    public partial class DeliveryChargeSpecification : PriceSpecification
    {
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


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DeliveryChargeSpecification";

        /// <summary>
        /// The delivery method(s) to which the delivery charge or payment charge specification applies.
        /// </summary>
        [DataMember(Name = "appliesToDeliveryMethod", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DeliveryMethod>? AppliesToDeliveryMethod { get; set; } 

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 407)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAreaServed>? AreaServed { get; set; } //AdministrativeArea, GeoShape, Place, string

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.&lt;/p&gt;
        /// &lt;p&gt;See also &lt;a class="localLink" href="http://schema.org/ineligibleRegion"&gt;ineligibleRegion&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "eligibleRegion", Order = 408)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IEligibleRegion>? EligibleRegion { get; set; } //GeoShape, Place, string

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is not valid, e.g. a region where the transaction is not allowed.&lt;/p&gt;
        /// &lt;p&gt;See also &lt;a class="localLink" href="http://schema.org/eligibleRegion"&gt;eligibleRegion&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "ineligibleRegion", Order = 409)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IIneligibleRegion>? IneligibleRegion { get; set; } //GeoShape, Place, string
    }
}
