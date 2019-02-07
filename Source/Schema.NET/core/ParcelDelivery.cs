namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// </summary>
    [DataContract]
    public partial class ParcelDelivery : Intangible
    {
        public interface IDeliveryAddress : IValue {}
        public interface IDeliveryAddress<T> : IDeliveryAddress { new T Value { get; } }
        public class OneOrManyDeliveryAddress : OneOrMany<IDeliveryAddress>
        {
            public OneOrManyDeliveryAddress(IDeliveryAddress item) : base(item) { }
            public OneOrManyDeliveryAddress(IEnumerable<IDeliveryAddress> items) : base(items) { }
            public static implicit operator OneOrManyDeliveryAddress (PostalAddress value) { return new OneOrManyDeliveryAddress (new DeliveryAddressPostalAddress (value)); }
            public static implicit operator OneOrManyDeliveryAddress (PostalAddress[] values) { return new OneOrManyDeliveryAddress (values.Select(v => (IDeliveryAddress) new DeliveryAddressPostalAddress (v))); }
            public static implicit operator OneOrManyDeliveryAddress (List<PostalAddress> values) { return new OneOrManyDeliveryAddress (values.Select(v => (IDeliveryAddress) new DeliveryAddressPostalAddress (v))); }
        }
        public struct DeliveryAddressPostalAddress : IDeliveryAddress<PostalAddress>
        {
            object IValue.Value => this.Value;
            public PostalAddress Value { get; }
            public DeliveryAddressPostalAddress (PostalAddress value) { Value = value; }
            public static implicit operator DeliveryAddressPostalAddress (PostalAddress value) { return new DeliveryAddressPostalAddress (value); }
        }

        public interface IDeliveryStatus : IValue {}
        public interface IDeliveryStatus<T> : IDeliveryStatus { new T Value { get; } }
        public class OneOrManyDeliveryStatus : OneOrMany<IDeliveryStatus>
        {
            public OneOrManyDeliveryStatus(IDeliveryStatus item) : base(item) { }
            public OneOrManyDeliveryStatus(IEnumerable<IDeliveryStatus> items) : base(items) { }
            public static implicit operator OneOrManyDeliveryStatus (DeliveryEvent value) { return new OneOrManyDeliveryStatus (new DeliveryStatusDeliveryEvent (value)); }
            public static implicit operator OneOrManyDeliveryStatus (DeliveryEvent[] values) { return new OneOrManyDeliveryStatus (values.Select(v => (IDeliveryStatus) new DeliveryStatusDeliveryEvent (v))); }
            public static implicit operator OneOrManyDeliveryStatus (List<DeliveryEvent> values) { return new OneOrManyDeliveryStatus (values.Select(v => (IDeliveryStatus) new DeliveryStatusDeliveryEvent (v))); }
        }
        public struct DeliveryStatusDeliveryEvent : IDeliveryStatus<DeliveryEvent>
        {
            object IValue.Value => this.Value;
            public DeliveryEvent Value { get; }
            public DeliveryStatusDeliveryEvent (DeliveryEvent value) { Value = value; }
            public static implicit operator DeliveryStatusDeliveryEvent (DeliveryEvent value) { return new DeliveryStatusDeliveryEvent (value); }
        }

        public interface IExpectedArrivalFrom : IValue {}
        public interface IExpectedArrivalFrom<T> : IExpectedArrivalFrom { new T Value { get; } }
        public class OneOrManyExpectedArrivalFrom : OneOrMany<IExpectedArrivalFrom>
        {
            public OneOrManyExpectedArrivalFrom(IExpectedArrivalFrom item) : base(item) { }
            public OneOrManyExpectedArrivalFrom(IEnumerable<IExpectedArrivalFrom> items) : base(items) { }
            public static implicit operator OneOrManyExpectedArrivalFrom (DateTimeOffset value) { return new OneOrManyExpectedArrivalFrom (new ExpectedArrivalFromDateTimeOffset (value)); }
            public static implicit operator OneOrManyExpectedArrivalFrom (DateTimeOffset[] values) { return new OneOrManyExpectedArrivalFrom (values.Select(v => (IExpectedArrivalFrom) new ExpectedArrivalFromDateTimeOffset (v))); }
            public static implicit operator OneOrManyExpectedArrivalFrom (List<DateTimeOffset> values) { return new OneOrManyExpectedArrivalFrom (values.Select(v => (IExpectedArrivalFrom) new ExpectedArrivalFromDateTimeOffset (v))); }
        }
        public struct ExpectedArrivalFromDateTimeOffset : IExpectedArrivalFrom<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public ExpectedArrivalFromDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator ExpectedArrivalFromDateTimeOffset (DateTimeOffset value) { return new ExpectedArrivalFromDateTimeOffset (value); }
        }

        public interface IExpectedArrivalUntil : IValue {}
        public interface IExpectedArrivalUntil<T> : IExpectedArrivalUntil { new T Value { get; } }
        public class OneOrManyExpectedArrivalUntil : OneOrMany<IExpectedArrivalUntil>
        {
            public OneOrManyExpectedArrivalUntil(IExpectedArrivalUntil item) : base(item) { }
            public OneOrManyExpectedArrivalUntil(IEnumerable<IExpectedArrivalUntil> items) : base(items) { }
            public static implicit operator OneOrManyExpectedArrivalUntil (DateTimeOffset value) { return new OneOrManyExpectedArrivalUntil (new ExpectedArrivalUntilDateTimeOffset (value)); }
            public static implicit operator OneOrManyExpectedArrivalUntil (DateTimeOffset[] values) { return new OneOrManyExpectedArrivalUntil (values.Select(v => (IExpectedArrivalUntil) new ExpectedArrivalUntilDateTimeOffset (v))); }
            public static implicit operator OneOrManyExpectedArrivalUntil (List<DateTimeOffset> values) { return new OneOrManyExpectedArrivalUntil (values.Select(v => (IExpectedArrivalUntil) new ExpectedArrivalUntilDateTimeOffset (v))); }
        }
        public struct ExpectedArrivalUntilDateTimeOffset : IExpectedArrivalUntil<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public ExpectedArrivalUntilDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator ExpectedArrivalUntilDateTimeOffset (DateTimeOffset value) { return new ExpectedArrivalUntilDateTimeOffset (value); }
        }

        public interface IHasDeliveryMethod : IValue {}
        public interface IHasDeliveryMethod<T> : IHasDeliveryMethod { new T Value { get; } }
        public class OneOrManyHasDeliveryMethod : OneOrMany<IHasDeliveryMethod>
        {
            public OneOrManyHasDeliveryMethod(IHasDeliveryMethod item) : base(item) { }
            public OneOrManyHasDeliveryMethod(IEnumerable<IHasDeliveryMethod> items) : base(items) { }
            public static implicit operator OneOrManyHasDeliveryMethod (DeliveryMethod value) { return new OneOrManyHasDeliveryMethod (new HasDeliveryMethodDeliveryMethod (value)); }
            public static implicit operator OneOrManyHasDeliveryMethod (DeliveryMethod[] values) { return new OneOrManyHasDeliveryMethod (values.Select(v => (IHasDeliveryMethod) new HasDeliveryMethodDeliveryMethod (v))); }
            public static implicit operator OneOrManyHasDeliveryMethod (List<DeliveryMethod> values) { return new OneOrManyHasDeliveryMethod (values.Select(v => (IHasDeliveryMethod) new HasDeliveryMethodDeliveryMethod (v))); }
        }
        public struct HasDeliveryMethodDeliveryMethod : IHasDeliveryMethod<DeliveryMethod>
        {
            object IValue.Value => this.Value;
            public DeliveryMethod Value { get; }
            public HasDeliveryMethodDeliveryMethod (DeliveryMethod value) { Value = value; }
            public static implicit operator HasDeliveryMethodDeliveryMethod (DeliveryMethod value) { return new HasDeliveryMethodDeliveryMethod (value); }
        }

        public interface IItemShipped : IValue {}
        public interface IItemShipped<T> : IItemShipped { new T Value { get; } }
        public class OneOrManyItemShipped : OneOrMany<IItemShipped>
        {
            public OneOrManyItemShipped(IItemShipped item) : base(item) { }
            public OneOrManyItemShipped(IEnumerable<IItemShipped> items) : base(items) { }
            public static implicit operator OneOrManyItemShipped (Product value) { return new OneOrManyItemShipped (new ItemShippedProduct (value)); }
            public static implicit operator OneOrManyItemShipped (Product[] values) { return new OneOrManyItemShipped (values.Select(v => (IItemShipped) new ItemShippedProduct (v))); }
            public static implicit operator OneOrManyItemShipped (List<Product> values) { return new OneOrManyItemShipped (values.Select(v => (IItemShipped) new ItemShippedProduct (v))); }
        }
        public struct ItemShippedProduct : IItemShipped<Product>
        {
            object IValue.Value => this.Value;
            public Product Value { get; }
            public ItemShippedProduct (Product value) { Value = value; }
            public static implicit operator ItemShippedProduct (Product value) { return new ItemShippedProduct (value); }
        }

        public interface IOriginAddress : IValue {}
        public interface IOriginAddress<T> : IOriginAddress { new T Value { get; } }
        public class OneOrManyOriginAddress : OneOrMany<IOriginAddress>
        {
            public OneOrManyOriginAddress(IOriginAddress item) : base(item) { }
            public OneOrManyOriginAddress(IEnumerable<IOriginAddress> items) : base(items) { }
            public static implicit operator OneOrManyOriginAddress (PostalAddress value) { return new OneOrManyOriginAddress (new OriginAddressPostalAddress (value)); }
            public static implicit operator OneOrManyOriginAddress (PostalAddress[] values) { return new OneOrManyOriginAddress (values.Select(v => (IOriginAddress) new OriginAddressPostalAddress (v))); }
            public static implicit operator OneOrManyOriginAddress (List<PostalAddress> values) { return new OneOrManyOriginAddress (values.Select(v => (IOriginAddress) new OriginAddressPostalAddress (v))); }
        }
        public struct OriginAddressPostalAddress : IOriginAddress<PostalAddress>
        {
            object IValue.Value => this.Value;
            public PostalAddress Value { get; }
            public OriginAddressPostalAddress (PostalAddress value) { Value = value; }
            public static implicit operator OriginAddressPostalAddress (PostalAddress value) { return new OriginAddressPostalAddress (value); }
        }

        public interface IPartOfOrder : IValue {}
        public interface IPartOfOrder<T> : IPartOfOrder { new T Value { get; } }
        public class OneOrManyPartOfOrder : OneOrMany<IPartOfOrder>
        {
            public OneOrManyPartOfOrder(IPartOfOrder item) : base(item) { }
            public OneOrManyPartOfOrder(IEnumerable<IPartOfOrder> items) : base(items) { }
            public static implicit operator OneOrManyPartOfOrder (Order value) { return new OneOrManyPartOfOrder (new PartOfOrderOrder (value)); }
            public static implicit operator OneOrManyPartOfOrder (Order[] values) { return new OneOrManyPartOfOrder (values.Select(v => (IPartOfOrder) new PartOfOrderOrder (v))); }
            public static implicit operator OneOrManyPartOfOrder (List<Order> values) { return new OneOrManyPartOfOrder (values.Select(v => (IPartOfOrder) new PartOfOrderOrder (v))); }
        }
        public struct PartOfOrderOrder : IPartOfOrder<Order>
        {
            object IValue.Value => this.Value;
            public Order Value { get; }
            public PartOfOrderOrder (Order value) { Value = value; }
            public static implicit operator PartOfOrderOrder (Order value) { return new PartOfOrderOrder (value); }
        }

        public interface IProvider : IValue {}
        public interface IProvider<T> : IProvider { new T Value { get; } }
        public class OneOrManyProvider : OneOrMany<IProvider>
        {
            public OneOrManyProvider(IProvider item) : base(item) { }
            public OneOrManyProvider(IEnumerable<IProvider> items) : base(items) { }
            public static implicit operator OneOrManyProvider (Organization value) { return new OneOrManyProvider (new ProviderOrganization (value)); }
            public static implicit operator OneOrManyProvider (Organization[] values) { return new OneOrManyProvider (values.Select(v => (IProvider) new ProviderOrganization (v))); }
            public static implicit operator OneOrManyProvider (List<Organization> values) { return new OneOrManyProvider (values.Select(v => (IProvider) new ProviderOrganization (v))); }
            public static implicit operator OneOrManyProvider (Person value) { return new OneOrManyProvider (new ProviderPerson (value)); }
            public static implicit operator OneOrManyProvider (Person[] values) { return new OneOrManyProvider (values.Select(v => (IProvider) new ProviderPerson (v))); }
            public static implicit operator OneOrManyProvider (List<Person> values) { return new OneOrManyProvider (values.Select(v => (IProvider) new ProviderPerson (v))); }
        }
        public struct ProviderOrganization : IProvider<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public ProviderOrganization (Organization value) { Value = value; }
            public static implicit operator ProviderOrganization (Organization value) { return new ProviderOrganization (value); }
        }
        public struct ProviderPerson : IProvider<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ProviderPerson (Person value) { Value = value; }
            public static implicit operator ProviderPerson (Person value) { return new ProviderPerson (value); }
        }

        public interface ITrackingNumber : IValue {}
        public interface ITrackingNumber<T> : ITrackingNumber { new T Value { get; } }
        public class OneOrManyTrackingNumber : OneOrMany<ITrackingNumber>
        {
            public OneOrManyTrackingNumber(ITrackingNumber item) : base(item) { }
            public OneOrManyTrackingNumber(IEnumerable<ITrackingNumber> items) : base(items) { }
            public static implicit operator OneOrManyTrackingNumber (string value) { return new OneOrManyTrackingNumber (new TrackingNumberstring (value)); }
            public static implicit operator OneOrManyTrackingNumber (string[] values) { return new OneOrManyTrackingNumber (values.Select(v => (ITrackingNumber) new TrackingNumberstring (v))); }
            public static implicit operator OneOrManyTrackingNumber (List<string> values) { return new OneOrManyTrackingNumber (values.Select(v => (ITrackingNumber) new TrackingNumberstring (v))); }
        }
        public struct TrackingNumberstring : ITrackingNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public TrackingNumberstring (string value) { Value = value; }
            public static implicit operator TrackingNumberstring (string value) { return new TrackingNumberstring (value); }
        }

        public interface ITrackingUrl : IValue {}
        public interface ITrackingUrl<T> : ITrackingUrl { new T Value { get; } }
        public class OneOrManyTrackingUrl : OneOrMany<ITrackingUrl>
        {
            public OneOrManyTrackingUrl(ITrackingUrl item) : base(item) { }
            public OneOrManyTrackingUrl(IEnumerable<ITrackingUrl> items) : base(items) { }
            public static implicit operator OneOrManyTrackingUrl (Uri value) { return new OneOrManyTrackingUrl (new TrackingUrlUri (value)); }
            public static implicit operator OneOrManyTrackingUrl (Uri[] values) { return new OneOrManyTrackingUrl (values.Select(v => (ITrackingUrl) new TrackingUrlUri (v))); }
            public static implicit operator OneOrManyTrackingUrl (List<Uri> values) { return new OneOrManyTrackingUrl (values.Select(v => (ITrackingUrl) new TrackingUrlUri (v))); }
        }
        public struct TrackingUrlUri : ITrackingUrl<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public TrackingUrlUri (Uri value) { Value = value; }
            public static implicit operator TrackingUrlUri (Uri value) { return new TrackingUrlUri (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ParcelDelivery";

        /// <summary>
        /// Destination address.
        /// </summary>
        [DataMember(Name = "deliveryAddress", Order = 206)]
        public OneOrManyDeliveryAddress DeliveryAddress { get; set; }

        /// <summary>
        /// New entry added as the package passes through each leg of its journey (from shipment to final delivery).
        /// </summary>
        [DataMember(Name = "deliveryStatus", Order = 207)]
        public OneOrManyDeliveryStatus DeliveryStatus { get; set; }

        /// <summary>
        /// The earliest date the package may arrive.
        /// </summary>
        [DataMember(Name = "expectedArrivalFrom", Order = 208)]
        public OneOrManyExpectedArrivalFrom ExpectedArrivalFrom { get; set; }

        /// <summary>
        /// The latest date the package may arrive.
        /// </summary>
        [DataMember(Name = "expectedArrivalUntil", Order = 209)]
        public OneOrManyExpectedArrivalUntil ExpectedArrivalUntil { get; set; }

        /// <summary>
        /// Method used for delivery or shipping.
        /// </summary>
        [DataMember(Name = "hasDeliveryMethod", Order = 210)]
        public OneOrManyHasDeliveryMethod HasDeliveryMethod { get; set; }

        /// <summary>
        /// Item(s) being shipped.
        /// </summary>
        [DataMember(Name = "itemShipped", Order = 211)]
        public OneOrManyItemShipped ItemShipped { get; set; }

        /// <summary>
        /// Shipper's address.
        /// </summary>
        [DataMember(Name = "originAddress", Order = 212)]
        public OneOrManyOriginAddress OriginAddress { get; set; }

        /// <summary>
        /// The overall order the items in this delivery were included in.
        /// </summary>
        [DataMember(Name = "partOfOrder", Order = 213)]
        public OneOrManyPartOfOrder PartOfOrder { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 214)]
        public OneOrManyProvider Provider { get; set; }

        /// <summary>
        /// Shipper tracking number.
        /// </summary>
        [DataMember(Name = "trackingNumber", Order = 215)]
        public OneOrManyTrackingNumber TrackingNumber { get; set; }

        /// <summary>
        /// Tracking url for the parcel delivery.
        /// </summary>
        [DataMember(Name = "trackingUrl", Order = 216)]
        public OneOrManyTrackingUrl TrackingUrl { get; set; }
    }
}
