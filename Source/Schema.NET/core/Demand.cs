namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
    [DataContract]
    public partial class Demand : Intangible
    {
        public interface IAcceptedPaymentMethod : IValue {}
        public interface IAcceptedPaymentMethod<T> : IAcceptedPaymentMethod { new T Value { get; } }
        public class OneOrManyAcceptedPaymentMethod : OneOrMany<IAcceptedPaymentMethod>
        {
            public OneOrManyAcceptedPaymentMethod(IAcceptedPaymentMethod item) : base(item) { }
            public OneOrManyAcceptedPaymentMethod(IEnumerable<IAcceptedPaymentMethod> items) : base(items) { }
            public static implicit operator OneOrManyAcceptedPaymentMethod (LoanOrCredit value) { return new OneOrManyAcceptedPaymentMethod (new AcceptedPaymentMethodLoanOrCredit (value)); }
            public static implicit operator OneOrManyAcceptedPaymentMethod (LoanOrCredit[] values) { return new OneOrManyAcceptedPaymentMethod (values.Select(v => (IAcceptedPaymentMethod) new AcceptedPaymentMethodLoanOrCredit (v))); }
            public static implicit operator OneOrManyAcceptedPaymentMethod (List<LoanOrCredit> values) { return new OneOrManyAcceptedPaymentMethod (values.Select(v => (IAcceptedPaymentMethod) new AcceptedPaymentMethodLoanOrCredit (v))); }
            public static implicit operator OneOrManyAcceptedPaymentMethod (PaymentMethod value) { return new OneOrManyAcceptedPaymentMethod (new AcceptedPaymentMethodPaymentMethod (value)); }
            public static implicit operator OneOrManyAcceptedPaymentMethod (PaymentMethod[] values) { return new OneOrManyAcceptedPaymentMethod (values.Select(v => (IAcceptedPaymentMethod) new AcceptedPaymentMethodPaymentMethod (v))); }
            public static implicit operator OneOrManyAcceptedPaymentMethod (List<PaymentMethod> values) { return new OneOrManyAcceptedPaymentMethod (values.Select(v => (IAcceptedPaymentMethod) new AcceptedPaymentMethodPaymentMethod (v))); }
        }
        public struct AcceptedPaymentMethodLoanOrCredit : IAcceptedPaymentMethod<LoanOrCredit>
        {
            object IValue.Value => this.Value;
            public LoanOrCredit Value { get; }
            public AcceptedPaymentMethodLoanOrCredit (LoanOrCredit value) { Value = value; }
            public static implicit operator AcceptedPaymentMethodLoanOrCredit (LoanOrCredit value) { return new AcceptedPaymentMethodLoanOrCredit (value); }
        }
        public struct AcceptedPaymentMethodPaymentMethod : IAcceptedPaymentMethod<PaymentMethod>
        {
            object IValue.Value => this.Value;
            public PaymentMethod Value { get; }
            public AcceptedPaymentMethodPaymentMethod (PaymentMethod value) { Value = value; }
            public static implicit operator AcceptedPaymentMethodPaymentMethod (PaymentMethod value) { return new AcceptedPaymentMethodPaymentMethod (value); }
        }

        public interface IAdvanceBookingRequirement : IValue {}
        public interface IAdvanceBookingRequirement<T> : IAdvanceBookingRequirement { new T Value { get; } }
        public class OneOrManyAdvanceBookingRequirement : OneOrMany<IAdvanceBookingRequirement>
        {
            public OneOrManyAdvanceBookingRequirement(IAdvanceBookingRequirement item) : base(item) { }
            public OneOrManyAdvanceBookingRequirement(IEnumerable<IAdvanceBookingRequirement> items) : base(items) { }
            public static implicit operator OneOrManyAdvanceBookingRequirement (QuantitativeValue value) { return new OneOrManyAdvanceBookingRequirement (new AdvanceBookingRequirementQuantitativeValue (value)); }
            public static implicit operator OneOrManyAdvanceBookingRequirement (QuantitativeValue[] values) { return new OneOrManyAdvanceBookingRequirement (values.Select(v => (IAdvanceBookingRequirement) new AdvanceBookingRequirementQuantitativeValue (v))); }
            public static implicit operator OneOrManyAdvanceBookingRequirement (List<QuantitativeValue> values) { return new OneOrManyAdvanceBookingRequirement (values.Select(v => (IAdvanceBookingRequirement) new AdvanceBookingRequirementQuantitativeValue (v))); }
        }
        public struct AdvanceBookingRequirementQuantitativeValue : IAdvanceBookingRequirement<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public AdvanceBookingRequirementQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator AdvanceBookingRequirementQuantitativeValue (QuantitativeValue value) { return new AdvanceBookingRequirementQuantitativeValue (value); }
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

        public interface IAvailability : IValue {}
        public interface IAvailability<T> : IAvailability { new T Value { get; } }
        public class OneOrManyAvailability : OneOrMany<IAvailability>
        {
            public OneOrManyAvailability(IAvailability item) : base(item) { }
            public OneOrManyAvailability(IEnumerable<IAvailability> items) : base(items) { }
            public static implicit operator OneOrManyAvailability (ItemAvailability value) { return new OneOrManyAvailability (new AvailabilityItemAvailability (value)); }
            public static implicit operator OneOrManyAvailability (ItemAvailability[] values) { return new OneOrManyAvailability (values.Select(v => (IAvailability) new AvailabilityItemAvailability (v))); }
            public static implicit operator OneOrManyAvailability (List<ItemAvailability> values) { return new OneOrManyAvailability (values.Select(v => (IAvailability) new AvailabilityItemAvailability (v))); }
        }
        public struct AvailabilityItemAvailability : IAvailability<ItemAvailability>
        {
            object IValue.Value => this.Value;
            public ItemAvailability Value { get; }
            public AvailabilityItemAvailability (ItemAvailability value) { Value = value; }
            public static implicit operator AvailabilityItemAvailability (ItemAvailability value) { return new AvailabilityItemAvailability (value); }
        }

        public interface IAvailabilityEnds : IValue {}
        public interface IAvailabilityEnds<T> : IAvailabilityEnds { new T Value { get; } }
        public class OneOrManyAvailabilityEnds : OneOrMany<IAvailabilityEnds>
        {
            public OneOrManyAvailabilityEnds(IAvailabilityEnds item) : base(item) { }
            public OneOrManyAvailabilityEnds(IEnumerable<IAvailabilityEnds> items) : base(items) { }
            public static implicit operator OneOrManyAvailabilityEnds (DateTimeOffset value) { return new OneOrManyAvailabilityEnds (new AvailabilityEndsDateTimeOffset (value)); }
            public static implicit operator OneOrManyAvailabilityEnds (DateTimeOffset[] values) { return new OneOrManyAvailabilityEnds (values.Select(v => (IAvailabilityEnds) new AvailabilityEndsDateTimeOffset (v))); }
            public static implicit operator OneOrManyAvailabilityEnds (List<DateTimeOffset> values) { return new OneOrManyAvailabilityEnds (values.Select(v => (IAvailabilityEnds) new AvailabilityEndsDateTimeOffset (v))); }
        }
        public struct AvailabilityEndsDateTimeOffset : IAvailabilityEnds<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public AvailabilityEndsDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator AvailabilityEndsDateTimeOffset (DateTimeOffset value) { return new AvailabilityEndsDateTimeOffset (value); }
        }

        public interface IAvailabilityStarts : IValue {}
        public interface IAvailabilityStarts<T> : IAvailabilityStarts { new T Value { get; } }
        public class OneOrManyAvailabilityStarts : OneOrMany<IAvailabilityStarts>
        {
            public OneOrManyAvailabilityStarts(IAvailabilityStarts item) : base(item) { }
            public OneOrManyAvailabilityStarts(IEnumerable<IAvailabilityStarts> items) : base(items) { }
            public static implicit operator OneOrManyAvailabilityStarts (DateTimeOffset value) { return new OneOrManyAvailabilityStarts (new AvailabilityStartsDateTimeOffset (value)); }
            public static implicit operator OneOrManyAvailabilityStarts (DateTimeOffset[] values) { return new OneOrManyAvailabilityStarts (values.Select(v => (IAvailabilityStarts) new AvailabilityStartsDateTimeOffset (v))); }
            public static implicit operator OneOrManyAvailabilityStarts (List<DateTimeOffset> values) { return new OneOrManyAvailabilityStarts (values.Select(v => (IAvailabilityStarts) new AvailabilityStartsDateTimeOffset (v))); }
        }
        public struct AvailabilityStartsDateTimeOffset : IAvailabilityStarts<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public AvailabilityStartsDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator AvailabilityStartsDateTimeOffset (DateTimeOffset value) { return new AvailabilityStartsDateTimeOffset (value); }
        }

        public interface IAvailableAtOrFrom : IValue {}
        public interface IAvailableAtOrFrom<T> : IAvailableAtOrFrom { new T Value { get; } }
        public class OneOrManyAvailableAtOrFrom : OneOrMany<IAvailableAtOrFrom>
        {
            public OneOrManyAvailableAtOrFrom(IAvailableAtOrFrom item) : base(item) { }
            public OneOrManyAvailableAtOrFrom(IEnumerable<IAvailableAtOrFrom> items) : base(items) { }
            public static implicit operator OneOrManyAvailableAtOrFrom (Place value) { return new OneOrManyAvailableAtOrFrom (new AvailableAtOrFromPlace (value)); }
            public static implicit operator OneOrManyAvailableAtOrFrom (Place[] values) { return new OneOrManyAvailableAtOrFrom (values.Select(v => (IAvailableAtOrFrom) new AvailableAtOrFromPlace (v))); }
            public static implicit operator OneOrManyAvailableAtOrFrom (List<Place> values) { return new OneOrManyAvailableAtOrFrom (values.Select(v => (IAvailableAtOrFrom) new AvailableAtOrFromPlace (v))); }
        }
        public struct AvailableAtOrFromPlace : IAvailableAtOrFrom<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public AvailableAtOrFromPlace (Place value) { Value = value; }
            public static implicit operator AvailableAtOrFromPlace (Place value) { return new AvailableAtOrFromPlace (value); }
        }

        public interface IAvailableDeliveryMethod : IValue {}
        public interface IAvailableDeliveryMethod<T> : IAvailableDeliveryMethod { new T Value { get; } }
        public class OneOrManyAvailableDeliveryMethod : OneOrMany<IAvailableDeliveryMethod>
        {
            public OneOrManyAvailableDeliveryMethod(IAvailableDeliveryMethod item) : base(item) { }
            public OneOrManyAvailableDeliveryMethod(IEnumerable<IAvailableDeliveryMethod> items) : base(items) { }
            public static implicit operator OneOrManyAvailableDeliveryMethod (DeliveryMethod value) { return new OneOrManyAvailableDeliveryMethod (new AvailableDeliveryMethodDeliveryMethod (value)); }
            public static implicit operator OneOrManyAvailableDeliveryMethod (DeliveryMethod[] values) { return new OneOrManyAvailableDeliveryMethod (values.Select(v => (IAvailableDeliveryMethod) new AvailableDeliveryMethodDeliveryMethod (v))); }
            public static implicit operator OneOrManyAvailableDeliveryMethod (List<DeliveryMethod> values) { return new OneOrManyAvailableDeliveryMethod (values.Select(v => (IAvailableDeliveryMethod) new AvailableDeliveryMethodDeliveryMethod (v))); }
        }
        public struct AvailableDeliveryMethodDeliveryMethod : IAvailableDeliveryMethod<DeliveryMethod>
        {
            object IValue.Value => this.Value;
            public DeliveryMethod Value { get; }
            public AvailableDeliveryMethodDeliveryMethod (DeliveryMethod value) { Value = value; }
            public static implicit operator AvailableDeliveryMethodDeliveryMethod (DeliveryMethod value) { return new AvailableDeliveryMethodDeliveryMethod (value); }
        }

        public interface IBusinessFunction : IValue {}
        public interface IBusinessFunction<T> : IBusinessFunction { new T Value { get; } }
        public class OneOrManyBusinessFunction : OneOrMany<IBusinessFunction>
        {
            public OneOrManyBusinessFunction(IBusinessFunction item) : base(item) { }
            public OneOrManyBusinessFunction(IEnumerable<IBusinessFunction> items) : base(items) { }
            public static implicit operator OneOrManyBusinessFunction (BusinessFunction value) { return new OneOrManyBusinessFunction (new BusinessFunctionBusinessFunction (value)); }
            public static implicit operator OneOrManyBusinessFunction (BusinessFunction[] values) { return new OneOrManyBusinessFunction (values.Select(v => (IBusinessFunction) new BusinessFunctionBusinessFunction (v))); }
            public static implicit operator OneOrManyBusinessFunction (List<BusinessFunction> values) { return new OneOrManyBusinessFunction (values.Select(v => (IBusinessFunction) new BusinessFunctionBusinessFunction (v))); }
        }
        public struct BusinessFunctionBusinessFunction : IBusinessFunction<BusinessFunction>
        {
            object IValue.Value => this.Value;
            public BusinessFunction Value { get; }
            public BusinessFunctionBusinessFunction (BusinessFunction value) { Value = value; }
            public static implicit operator BusinessFunctionBusinessFunction (BusinessFunction value) { return new BusinessFunctionBusinessFunction (value); }
        }

        public interface IDeliveryLeadTime : IValue {}
        public interface IDeliveryLeadTime<T> : IDeliveryLeadTime { new T Value { get; } }
        public class OneOrManyDeliveryLeadTime : OneOrMany<IDeliveryLeadTime>
        {
            public OneOrManyDeliveryLeadTime(IDeliveryLeadTime item) : base(item) { }
            public OneOrManyDeliveryLeadTime(IEnumerable<IDeliveryLeadTime> items) : base(items) { }
            public static implicit operator OneOrManyDeliveryLeadTime (QuantitativeValue value) { return new OneOrManyDeliveryLeadTime (new DeliveryLeadTimeQuantitativeValue (value)); }
            public static implicit operator OneOrManyDeliveryLeadTime (QuantitativeValue[] values) { return new OneOrManyDeliveryLeadTime (values.Select(v => (IDeliveryLeadTime) new DeliveryLeadTimeQuantitativeValue (v))); }
            public static implicit operator OneOrManyDeliveryLeadTime (List<QuantitativeValue> values) { return new OneOrManyDeliveryLeadTime (values.Select(v => (IDeliveryLeadTime) new DeliveryLeadTimeQuantitativeValue (v))); }
        }
        public struct DeliveryLeadTimeQuantitativeValue : IDeliveryLeadTime<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public DeliveryLeadTimeQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator DeliveryLeadTimeQuantitativeValue (QuantitativeValue value) { return new DeliveryLeadTimeQuantitativeValue (value); }
        }

        public interface IEligibleCustomerType : IValue {}
        public interface IEligibleCustomerType<T> : IEligibleCustomerType { new T Value { get; } }
        public class OneOrManyEligibleCustomerType : OneOrMany<IEligibleCustomerType>
        {
            public OneOrManyEligibleCustomerType(IEligibleCustomerType item) : base(item) { }
            public OneOrManyEligibleCustomerType(IEnumerable<IEligibleCustomerType> items) : base(items) { }
            public static implicit operator OneOrManyEligibleCustomerType (BusinessEntityType value) { return new OneOrManyEligibleCustomerType (new EligibleCustomerTypeBusinessEntityType (value)); }
            public static implicit operator OneOrManyEligibleCustomerType (BusinessEntityType[] values) { return new OneOrManyEligibleCustomerType (values.Select(v => (IEligibleCustomerType) new EligibleCustomerTypeBusinessEntityType (v))); }
            public static implicit operator OneOrManyEligibleCustomerType (List<BusinessEntityType> values) { return new OneOrManyEligibleCustomerType (values.Select(v => (IEligibleCustomerType) new EligibleCustomerTypeBusinessEntityType (v))); }
        }
        public struct EligibleCustomerTypeBusinessEntityType : IEligibleCustomerType<BusinessEntityType>
        {
            object IValue.Value => this.Value;
            public BusinessEntityType Value { get; }
            public EligibleCustomerTypeBusinessEntityType (BusinessEntityType value) { Value = value; }
            public static implicit operator EligibleCustomerTypeBusinessEntityType (BusinessEntityType value) { return new EligibleCustomerTypeBusinessEntityType (value); }
        }

        public interface IEligibleDuration : IValue {}
        public interface IEligibleDuration<T> : IEligibleDuration { new T Value { get; } }
        public class OneOrManyEligibleDuration : OneOrMany<IEligibleDuration>
        {
            public OneOrManyEligibleDuration(IEligibleDuration item) : base(item) { }
            public OneOrManyEligibleDuration(IEnumerable<IEligibleDuration> items) : base(items) { }
            public static implicit operator OneOrManyEligibleDuration (QuantitativeValue value) { return new OneOrManyEligibleDuration (new EligibleDurationQuantitativeValue (value)); }
            public static implicit operator OneOrManyEligibleDuration (QuantitativeValue[] values) { return new OneOrManyEligibleDuration (values.Select(v => (IEligibleDuration) new EligibleDurationQuantitativeValue (v))); }
            public static implicit operator OneOrManyEligibleDuration (List<QuantitativeValue> values) { return new OneOrManyEligibleDuration (values.Select(v => (IEligibleDuration) new EligibleDurationQuantitativeValue (v))); }
        }
        public struct EligibleDurationQuantitativeValue : IEligibleDuration<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public EligibleDurationQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator EligibleDurationQuantitativeValue (QuantitativeValue value) { return new EligibleDurationQuantitativeValue (value); }
        }

        public interface IEligibleQuantity : IValue {}
        public interface IEligibleQuantity<T> : IEligibleQuantity { new T Value { get; } }
        public class OneOrManyEligibleQuantity : OneOrMany<IEligibleQuantity>
        {
            public OneOrManyEligibleQuantity(IEligibleQuantity item) : base(item) { }
            public OneOrManyEligibleQuantity(IEnumerable<IEligibleQuantity> items) : base(items) { }
            public static implicit operator OneOrManyEligibleQuantity (QuantitativeValue value) { return new OneOrManyEligibleQuantity (new EligibleQuantityQuantitativeValue (value)); }
            public static implicit operator OneOrManyEligibleQuantity (QuantitativeValue[] values) { return new OneOrManyEligibleQuantity (values.Select(v => (IEligibleQuantity) new EligibleQuantityQuantitativeValue (v))); }
            public static implicit operator OneOrManyEligibleQuantity (List<QuantitativeValue> values) { return new OneOrManyEligibleQuantity (values.Select(v => (IEligibleQuantity) new EligibleQuantityQuantitativeValue (v))); }
        }
        public struct EligibleQuantityQuantitativeValue : IEligibleQuantity<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public EligibleQuantityQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator EligibleQuantityQuantitativeValue (QuantitativeValue value) { return new EligibleQuantityQuantitativeValue (value); }
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

        public interface IEligibleTransactionVolume : IValue {}
        public interface IEligibleTransactionVolume<T> : IEligibleTransactionVolume { new T Value { get; } }
        public class OneOrManyEligibleTransactionVolume : OneOrMany<IEligibleTransactionVolume>
        {
            public OneOrManyEligibleTransactionVolume(IEligibleTransactionVolume item) : base(item) { }
            public OneOrManyEligibleTransactionVolume(IEnumerable<IEligibleTransactionVolume> items) : base(items) { }
            public static implicit operator OneOrManyEligibleTransactionVolume (PriceSpecification value) { return new OneOrManyEligibleTransactionVolume (new EligibleTransactionVolumePriceSpecification (value)); }
            public static implicit operator OneOrManyEligibleTransactionVolume (PriceSpecification[] values) { return new OneOrManyEligibleTransactionVolume (values.Select(v => (IEligibleTransactionVolume) new EligibleTransactionVolumePriceSpecification (v))); }
            public static implicit operator OneOrManyEligibleTransactionVolume (List<PriceSpecification> values) { return new OneOrManyEligibleTransactionVolume (values.Select(v => (IEligibleTransactionVolume) new EligibleTransactionVolumePriceSpecification (v))); }
        }
        public struct EligibleTransactionVolumePriceSpecification : IEligibleTransactionVolume<PriceSpecification>
        {
            object IValue.Value => this.Value;
            public PriceSpecification Value { get; }
            public EligibleTransactionVolumePriceSpecification (PriceSpecification value) { Value = value; }
            public static implicit operator EligibleTransactionVolumePriceSpecification (PriceSpecification value) { return new EligibleTransactionVolumePriceSpecification (value); }
        }

        public interface IGtin12 : IValue {}
        public interface IGtin12<T> : IGtin12 { new T Value { get; } }
        public class OneOrManyGtin12 : OneOrMany<IGtin12>
        {
            public OneOrManyGtin12(IGtin12 item) : base(item) { }
            public OneOrManyGtin12(IEnumerable<IGtin12> items) : base(items) { }
            public static implicit operator OneOrManyGtin12 (string value) { return new OneOrManyGtin12 (new Gtin12string (value)); }
            public static implicit operator OneOrManyGtin12 (string[] values) { return new OneOrManyGtin12 (values.Select(v => (IGtin12) new Gtin12string (v))); }
            public static implicit operator OneOrManyGtin12 (List<string> values) { return new OneOrManyGtin12 (values.Select(v => (IGtin12) new Gtin12string (v))); }
        }
        public struct Gtin12string : IGtin12<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Gtin12string (string value) { Value = value; }
            public static implicit operator Gtin12string (string value) { return new Gtin12string (value); }
        }

        public interface IGtin13 : IValue {}
        public interface IGtin13<T> : IGtin13 { new T Value { get; } }
        public class OneOrManyGtin13 : OneOrMany<IGtin13>
        {
            public OneOrManyGtin13(IGtin13 item) : base(item) { }
            public OneOrManyGtin13(IEnumerable<IGtin13> items) : base(items) { }
            public static implicit operator OneOrManyGtin13 (string value) { return new OneOrManyGtin13 (new Gtin13string (value)); }
            public static implicit operator OneOrManyGtin13 (string[] values) { return new OneOrManyGtin13 (values.Select(v => (IGtin13) new Gtin13string (v))); }
            public static implicit operator OneOrManyGtin13 (List<string> values) { return new OneOrManyGtin13 (values.Select(v => (IGtin13) new Gtin13string (v))); }
        }
        public struct Gtin13string : IGtin13<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Gtin13string (string value) { Value = value; }
            public static implicit operator Gtin13string (string value) { return new Gtin13string (value); }
        }

        public interface IGtin14 : IValue {}
        public interface IGtin14<T> : IGtin14 { new T Value { get; } }
        public class OneOrManyGtin14 : OneOrMany<IGtin14>
        {
            public OneOrManyGtin14(IGtin14 item) : base(item) { }
            public OneOrManyGtin14(IEnumerable<IGtin14> items) : base(items) { }
            public static implicit operator OneOrManyGtin14 (string value) { return new OneOrManyGtin14 (new Gtin14string (value)); }
            public static implicit operator OneOrManyGtin14 (string[] values) { return new OneOrManyGtin14 (values.Select(v => (IGtin14) new Gtin14string (v))); }
            public static implicit operator OneOrManyGtin14 (List<string> values) { return new OneOrManyGtin14 (values.Select(v => (IGtin14) new Gtin14string (v))); }
        }
        public struct Gtin14string : IGtin14<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Gtin14string (string value) { Value = value; }
            public static implicit operator Gtin14string (string value) { return new Gtin14string (value); }
        }

        public interface IGtin8 : IValue {}
        public interface IGtin8<T> : IGtin8 { new T Value { get; } }
        public class OneOrManyGtin8 : OneOrMany<IGtin8>
        {
            public OneOrManyGtin8(IGtin8 item) : base(item) { }
            public OneOrManyGtin8(IEnumerable<IGtin8> items) : base(items) { }
            public static implicit operator OneOrManyGtin8 (string value) { return new OneOrManyGtin8 (new Gtin8string (value)); }
            public static implicit operator OneOrManyGtin8 (string[] values) { return new OneOrManyGtin8 (values.Select(v => (IGtin8) new Gtin8string (v))); }
            public static implicit operator OneOrManyGtin8 (List<string> values) { return new OneOrManyGtin8 (values.Select(v => (IGtin8) new Gtin8string (v))); }
        }
        public struct Gtin8string : IGtin8<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Gtin8string (string value) { Value = value; }
            public static implicit operator Gtin8string (string value) { return new Gtin8string (value); }
        }

        public interface IIncludesObject : IValue {}
        public interface IIncludesObject<T> : IIncludesObject { new T Value { get; } }
        public class OneOrManyIncludesObject : OneOrMany<IIncludesObject>
        {
            public OneOrManyIncludesObject(IIncludesObject item) : base(item) { }
            public OneOrManyIncludesObject(IEnumerable<IIncludesObject> items) : base(items) { }
            public static implicit operator OneOrManyIncludesObject (TypeAndQuantityNode value) { return new OneOrManyIncludesObject (new IncludesObjectTypeAndQuantityNode (value)); }
            public static implicit operator OneOrManyIncludesObject (TypeAndQuantityNode[] values) { return new OneOrManyIncludesObject (values.Select(v => (IIncludesObject) new IncludesObjectTypeAndQuantityNode (v))); }
            public static implicit operator OneOrManyIncludesObject (List<TypeAndQuantityNode> values) { return new OneOrManyIncludesObject (values.Select(v => (IIncludesObject) new IncludesObjectTypeAndQuantityNode (v))); }
        }
        public struct IncludesObjectTypeAndQuantityNode : IIncludesObject<TypeAndQuantityNode>
        {
            object IValue.Value => this.Value;
            public TypeAndQuantityNode Value { get; }
            public IncludesObjectTypeAndQuantityNode (TypeAndQuantityNode value) { Value = value; }
            public static implicit operator IncludesObjectTypeAndQuantityNode (TypeAndQuantityNode value) { return new IncludesObjectTypeAndQuantityNode (value); }
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

        public interface IInventoryLevel : IValue {}
        public interface IInventoryLevel<T> : IInventoryLevel { new T Value { get; } }
        public class OneOrManyInventoryLevel : OneOrMany<IInventoryLevel>
        {
            public OneOrManyInventoryLevel(IInventoryLevel item) : base(item) { }
            public OneOrManyInventoryLevel(IEnumerable<IInventoryLevel> items) : base(items) { }
            public static implicit operator OneOrManyInventoryLevel (QuantitativeValue value) { return new OneOrManyInventoryLevel (new InventoryLevelQuantitativeValue (value)); }
            public static implicit operator OneOrManyInventoryLevel (QuantitativeValue[] values) { return new OneOrManyInventoryLevel (values.Select(v => (IInventoryLevel) new InventoryLevelQuantitativeValue (v))); }
            public static implicit operator OneOrManyInventoryLevel (List<QuantitativeValue> values) { return new OneOrManyInventoryLevel (values.Select(v => (IInventoryLevel) new InventoryLevelQuantitativeValue (v))); }
        }
        public struct InventoryLevelQuantitativeValue : IInventoryLevel<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public InventoryLevelQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator InventoryLevelQuantitativeValue (QuantitativeValue value) { return new InventoryLevelQuantitativeValue (value); }
        }

        public interface IItemCondition : IValue {}
        public interface IItemCondition<T> : IItemCondition { new T Value { get; } }
        public class OneOrManyItemCondition : OneOrMany<IItemCondition>
        {
            public OneOrManyItemCondition(IItemCondition item) : base(item) { }
            public OneOrManyItemCondition(IEnumerable<IItemCondition> items) : base(items) { }
            public static implicit operator OneOrManyItemCondition (OfferItemCondition value) { return new OneOrManyItemCondition (new ItemConditionOfferItemCondition (value)); }
            public static implicit operator OneOrManyItemCondition (OfferItemCondition[] values) { return new OneOrManyItemCondition (values.Select(v => (IItemCondition) new ItemConditionOfferItemCondition (v))); }
            public static implicit operator OneOrManyItemCondition (List<OfferItemCondition> values) { return new OneOrManyItemCondition (values.Select(v => (IItemCondition) new ItemConditionOfferItemCondition (v))); }
        }
        public struct ItemConditionOfferItemCondition : IItemCondition<OfferItemCondition>
        {
            object IValue.Value => this.Value;
            public OfferItemCondition Value { get; }
            public ItemConditionOfferItemCondition (OfferItemCondition value) { Value = value; }
            public static implicit operator ItemConditionOfferItemCondition (OfferItemCondition value) { return new ItemConditionOfferItemCondition (value); }
        }

        public interface IItemOffered : IValue {}
        public interface IItemOffered<T> : IItemOffered { new T Value { get; } }
        public class OneOrManyItemOffered : OneOrMany<IItemOffered>
        {
            public OneOrManyItemOffered(IItemOffered item) : base(item) { }
            public OneOrManyItemOffered(IEnumerable<IItemOffered> items) : base(items) { }
            public static implicit operator OneOrManyItemOffered (Product value) { return new OneOrManyItemOffered (new ItemOfferedProduct (value)); }
            public static implicit operator OneOrManyItemOffered (Product[] values) { return new OneOrManyItemOffered (values.Select(v => (IItemOffered) new ItemOfferedProduct (v))); }
            public static implicit operator OneOrManyItemOffered (List<Product> values) { return new OneOrManyItemOffered (values.Select(v => (IItemOffered) new ItemOfferedProduct (v))); }
            public static implicit operator OneOrManyItemOffered (Service value) { return new OneOrManyItemOffered (new ItemOfferedService (value)); }
            public static implicit operator OneOrManyItemOffered (Service[] values) { return new OneOrManyItemOffered (values.Select(v => (IItemOffered) new ItemOfferedService (v))); }
            public static implicit operator OneOrManyItemOffered (List<Service> values) { return new OneOrManyItemOffered (values.Select(v => (IItemOffered) new ItemOfferedService (v))); }
        }
        public struct ItemOfferedProduct : IItemOffered<Product>
        {
            object IValue.Value => this.Value;
            public Product Value { get; }
            public ItemOfferedProduct (Product value) { Value = value; }
            public static implicit operator ItemOfferedProduct (Product value) { return new ItemOfferedProduct (value); }
        }
        public struct ItemOfferedService : IItemOffered<Service>
        {
            object IValue.Value => this.Value;
            public Service Value { get; }
            public ItemOfferedService (Service value) { Value = value; }
            public static implicit operator ItemOfferedService (Service value) { return new ItemOfferedService (value); }
        }

        public interface IMpn : IValue {}
        public interface IMpn<T> : IMpn { new T Value { get; } }
        public class OneOrManyMpn : OneOrMany<IMpn>
        {
            public OneOrManyMpn(IMpn item) : base(item) { }
            public OneOrManyMpn(IEnumerable<IMpn> items) : base(items) { }
            public static implicit operator OneOrManyMpn (string value) { return new OneOrManyMpn (new Mpnstring (value)); }
            public static implicit operator OneOrManyMpn (string[] values) { return new OneOrManyMpn (values.Select(v => (IMpn) new Mpnstring (v))); }
            public static implicit operator OneOrManyMpn (List<string> values) { return new OneOrManyMpn (values.Select(v => (IMpn) new Mpnstring (v))); }
        }
        public struct Mpnstring : IMpn<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Mpnstring (string value) { Value = value; }
            public static implicit operator Mpnstring (string value) { return new Mpnstring (value); }
        }

        public interface IPriceSpecification : IValue {}
        public interface IPriceSpecification<T> : IPriceSpecification { new T Value { get; } }
        public class OneOrManyPriceSpecification : OneOrMany<IPriceSpecification>
        {
            public OneOrManyPriceSpecification(IPriceSpecification item) : base(item) { }
            public OneOrManyPriceSpecification(IEnumerable<IPriceSpecification> items) : base(items) { }
            public static implicit operator OneOrManyPriceSpecification (PriceSpecification value) { return new OneOrManyPriceSpecification (new PriceSpecificationPriceSpecification (value)); }
            public static implicit operator OneOrManyPriceSpecification (PriceSpecification[] values) { return new OneOrManyPriceSpecification (values.Select(v => (IPriceSpecification) new PriceSpecificationPriceSpecification (v))); }
            public static implicit operator OneOrManyPriceSpecification (List<PriceSpecification> values) { return new OneOrManyPriceSpecification (values.Select(v => (IPriceSpecification) new PriceSpecificationPriceSpecification (v))); }
        }
        public struct PriceSpecificationPriceSpecification : IPriceSpecification<PriceSpecification>
        {
            object IValue.Value => this.Value;
            public PriceSpecification Value { get; }
            public PriceSpecificationPriceSpecification (PriceSpecification value) { Value = value; }
            public static implicit operator PriceSpecificationPriceSpecification (PriceSpecification value) { return new PriceSpecificationPriceSpecification (value); }
        }

        public interface ISeller : IValue {}
        public interface ISeller<T> : ISeller { new T Value { get; } }
        public class OneOrManySeller : OneOrMany<ISeller>
        {
            public OneOrManySeller(ISeller item) : base(item) { }
            public OneOrManySeller(IEnumerable<ISeller> items) : base(items) { }
            public static implicit operator OneOrManySeller (Organization value) { return new OneOrManySeller (new SellerOrganization (value)); }
            public static implicit operator OneOrManySeller (Organization[] values) { return new OneOrManySeller (values.Select(v => (ISeller) new SellerOrganization (v))); }
            public static implicit operator OneOrManySeller (List<Organization> values) { return new OneOrManySeller (values.Select(v => (ISeller) new SellerOrganization (v))); }
            public static implicit operator OneOrManySeller (Person value) { return new OneOrManySeller (new SellerPerson (value)); }
            public static implicit operator OneOrManySeller (Person[] values) { return new OneOrManySeller (values.Select(v => (ISeller) new SellerPerson (v))); }
            public static implicit operator OneOrManySeller (List<Person> values) { return new OneOrManySeller (values.Select(v => (ISeller) new SellerPerson (v))); }
        }
        public struct SellerOrganization : ISeller<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public SellerOrganization (Organization value) { Value = value; }
            public static implicit operator SellerOrganization (Organization value) { return new SellerOrganization (value); }
        }
        public struct SellerPerson : ISeller<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public SellerPerson (Person value) { Value = value; }
            public static implicit operator SellerPerson (Person value) { return new SellerPerson (value); }
        }

        public interface ISerialNumber : IValue {}
        public interface ISerialNumber<T> : ISerialNumber { new T Value { get; } }
        public class OneOrManySerialNumber : OneOrMany<ISerialNumber>
        {
            public OneOrManySerialNumber(ISerialNumber item) : base(item) { }
            public OneOrManySerialNumber(IEnumerable<ISerialNumber> items) : base(items) { }
            public static implicit operator OneOrManySerialNumber (string value) { return new OneOrManySerialNumber (new SerialNumberstring (value)); }
            public static implicit operator OneOrManySerialNumber (string[] values) { return new OneOrManySerialNumber (values.Select(v => (ISerialNumber) new SerialNumberstring (v))); }
            public static implicit operator OneOrManySerialNumber (List<string> values) { return new OneOrManySerialNumber (values.Select(v => (ISerialNumber) new SerialNumberstring (v))); }
        }
        public struct SerialNumberstring : ISerialNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SerialNumberstring (string value) { Value = value; }
            public static implicit operator SerialNumberstring (string value) { return new SerialNumberstring (value); }
        }

        public interface ISku : IValue {}
        public interface ISku<T> : ISku { new T Value { get; } }
        public class OneOrManySku : OneOrMany<ISku>
        {
            public OneOrManySku(ISku item) : base(item) { }
            public OneOrManySku(IEnumerable<ISku> items) : base(items) { }
            public static implicit operator OneOrManySku (string value) { return new OneOrManySku (new Skustring (value)); }
            public static implicit operator OneOrManySku (string[] values) { return new OneOrManySku (values.Select(v => (ISku) new Skustring (v))); }
            public static implicit operator OneOrManySku (List<string> values) { return new OneOrManySku (values.Select(v => (ISku) new Skustring (v))); }
        }
        public struct Skustring : ISku<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Skustring (string value) { Value = value; }
            public static implicit operator Skustring (string value) { return new Skustring (value); }
        }

        public interface IValidFrom : IValue {}
        public interface IValidFrom<T> : IValidFrom { new T Value { get; } }
        public class OneOrManyValidFrom : OneOrMany<IValidFrom>
        {
            public OneOrManyValidFrom(IValidFrom item) : base(item) { }
            public OneOrManyValidFrom(IEnumerable<IValidFrom> items) : base(items) { }
            public static implicit operator OneOrManyValidFrom (DateTimeOffset value) { return new OneOrManyValidFrom (new ValidFromDateTimeOffset (value)); }
            public static implicit operator OneOrManyValidFrom (DateTimeOffset[] values) { return new OneOrManyValidFrom (values.Select(v => (IValidFrom) new ValidFromDateTimeOffset (v))); }
            public static implicit operator OneOrManyValidFrom (List<DateTimeOffset> values) { return new OneOrManyValidFrom (values.Select(v => (IValidFrom) new ValidFromDateTimeOffset (v))); }
        }
        public struct ValidFromDateTimeOffset : IValidFrom<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public ValidFromDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator ValidFromDateTimeOffset (DateTimeOffset value) { return new ValidFromDateTimeOffset (value); }
        }

        public interface IValidThrough : IValue {}
        public interface IValidThrough<T> : IValidThrough { new T Value { get; } }
        public class OneOrManyValidThrough : OneOrMany<IValidThrough>
        {
            public OneOrManyValidThrough(IValidThrough item) : base(item) { }
            public OneOrManyValidThrough(IEnumerable<IValidThrough> items) : base(items) { }
            public static implicit operator OneOrManyValidThrough (DateTimeOffset value) { return new OneOrManyValidThrough (new ValidThroughDateTimeOffset (value)); }
            public static implicit operator OneOrManyValidThrough (DateTimeOffset[] values) { return new OneOrManyValidThrough (values.Select(v => (IValidThrough) new ValidThroughDateTimeOffset (v))); }
            public static implicit operator OneOrManyValidThrough (List<DateTimeOffset> values) { return new OneOrManyValidThrough (values.Select(v => (IValidThrough) new ValidThroughDateTimeOffset (v))); }
        }
        public struct ValidThroughDateTimeOffset : IValidThrough<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public ValidThroughDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator ValidThroughDateTimeOffset (DateTimeOffset value) { return new ValidThroughDateTimeOffset (value); }
        }

        public interface IWarranty : IValue {}
        public interface IWarranty<T> : IWarranty { new T Value { get; } }
        public class OneOrManyWarranty : OneOrMany<IWarranty>
        {
            public OneOrManyWarranty(IWarranty item) : base(item) { }
            public OneOrManyWarranty(IEnumerable<IWarranty> items) : base(items) { }
            public static implicit operator OneOrManyWarranty (WarrantyPromise value) { return new OneOrManyWarranty (new WarrantyWarrantyPromise (value)); }
            public static implicit operator OneOrManyWarranty (WarrantyPromise[] values) { return new OneOrManyWarranty (values.Select(v => (IWarranty) new WarrantyWarrantyPromise (v))); }
            public static implicit operator OneOrManyWarranty (List<WarrantyPromise> values) { return new OneOrManyWarranty (values.Select(v => (IWarranty) new WarrantyWarrantyPromise (v))); }
        }
        public struct WarrantyWarrantyPromise : IWarranty<WarrantyPromise>
        {
            object IValue.Value => this.Value;
            public WarrantyPromise Value { get; }
            public WarrantyWarrantyPromise (WarrantyPromise value) { Value = value; }
            public static implicit operator WarrantyWarrantyPromise (WarrantyPromise value) { return new WarrantyWarrantyPromise (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Demand";

        /// <summary>
        /// The payment method(s) accepted by seller for this offer.
        /// </summary>
        [DataMember(Name = "acceptedPaymentMethod", Order = 206)]
        public OneOrManyAcceptedPaymentMethod AcceptedPaymentMethod { get; set; }

        /// <summary>
        /// The amount of time that is required between accepting the offer and the actual usage of the resource or service.
        /// </summary>
        [DataMember(Name = "advanceBookingRequirement", Order = 207)]
        public OneOrManyAdvanceBookingRequirement AdvanceBookingRequirement { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 208)]
        public OneOrManyAreaServed AreaServed { get; set; }

        /// <summary>
        /// The availability of this item&amp;#x2014;for example In stock, Out of stock, Pre-order, etc.
        /// </summary>
        [DataMember(Name = "availability", Order = 209)]
        public OneOrManyAvailability Availability { get; set; }

        /// <summary>
        /// The end of the availability of the product or service included in the offer.
        /// </summary>
        [DataMember(Name = "availabilityEnds", Order = 210)]
        public OneOrManyAvailabilityEnds AvailabilityEnds { get; set; }

        /// <summary>
        /// The beginning of the availability of the product or service included in the offer.
        /// </summary>
        [DataMember(Name = "availabilityStarts", Order = 211)]
        public OneOrManyAvailabilityStarts AvailabilityStarts { get; set; }

        /// <summary>
        /// The place(s) from which the offer can be obtained (e.g. store locations).
        /// </summary>
        [DataMember(Name = "availableAtOrFrom", Order = 212)]
        public OneOrManyAvailableAtOrFrom AvailableAtOrFrom { get; set; }

        /// <summary>
        /// The delivery method(s) available for this offer.
        /// </summary>
        [DataMember(Name = "availableDeliveryMethod", Order = 213)]
        public OneOrManyAvailableDeliveryMethod AvailableDeliveryMethod { get; set; }

        /// <summary>
        /// The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
        /// </summary>
        [DataMember(Name = "businessFunction", Order = 214)]
        public OneOrManyBusinessFunction BusinessFunction { get; set; }

        /// <summary>
        /// The typical delay between the receipt of the order and the goods either leaving the warehouse or being prepared for pickup, in case the delivery method is on site pickup.
        /// </summary>
        [DataMember(Name = "deliveryLeadTime", Order = 215)]
        public OneOrManyDeliveryLeadTime DeliveryLeadTime { get; set; }

        /// <summary>
        /// The type(s) of customers for which the given offer is valid.
        /// </summary>
        [DataMember(Name = "eligibleCustomerType", Order = 216)]
        public OneOrManyEligibleCustomerType EligibleCustomerType { get; set; }

        /// <summary>
        /// The duration for which the given offer is valid.
        /// </summary>
        [DataMember(Name = "eligibleDuration", Order = 217)]
        public OneOrManyEligibleDuration EligibleDuration { get; set; }

        /// <summary>
        /// The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
        /// </summary>
        [DataMember(Name = "eligibleQuantity", Order = 218)]
        public OneOrManyEligibleQuantity EligibleQuantity { get; set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.&lt;br/&gt;&lt;br/&gt;
        /// See also &lt;a class="localLink" href="http://schema.org/ineligibleRegion"&gt;ineligibleRegion&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "eligibleRegion", Order = 219)]
        public OneOrManyEligibleRegion EligibleRegion { get; set; }

        /// <summary>
        /// The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
        /// </summary>
        [DataMember(Name = "eligibleTransactionVolume", Order = 220)]
        public OneOrManyEligibleTransactionVolume EligibleTransactionVolume { get; set; }

        /// <summary>
        /// The GTIN-12 code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin12", Order = 221)]
        public OneOrManyGtin12 Gtin12 { get; set; }

        /// <summary>
        /// The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin13", Order = 222)]
        public OneOrManyGtin13 Gtin13 { get; set; }

        /// <summary>
        /// The GTIN-14 code of the product, or the product to which the offer refers. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin14", Order = 223)]
        public OneOrManyGtin14 Gtin14 { get; set; }

        /// <summary>
        /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-8.aspx"&gt;GTIN-8&lt;/a&gt; code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin8", Order = 224)]
        public OneOrManyGtin8 Gtin8 { get; set; }

        /// <summary>
        /// This links to a node or nodes indicating the exact quantity of the products included in the offer.
        /// </summary>
        [DataMember(Name = "includesObject", Order = 225)]
        public OneOrManyIncludesObject IncludesObject { get; set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is not valid, e.g. a region where the transaction is not allowed.&lt;br/&gt;&lt;br/&gt;
        /// See also &lt;a class="localLink" href="http://schema.org/eligibleRegion"&gt;eligibleRegion&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "ineligibleRegion", Order = 226)]
        public OneOrManyIneligibleRegion IneligibleRegion { get; set; }

        /// <summary>
        /// The current approximate inventory level for the item or items.
        /// </summary>
        [DataMember(Name = "inventoryLevel", Order = 227)]
        public OneOrManyInventoryLevel InventoryLevel { get; set; }

        /// <summary>
        /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        /// </summary>
        [DataMember(Name = "itemCondition", Order = 228)]
        public OneOrManyItemCondition ItemCondition { get; set; }

        /// <summary>
        /// The item being offered.
        /// </summary>
        [DataMember(Name = "itemOffered", Order = 229)]
        public OneOrManyItemOffered ItemOffered { get; set; }

        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        [DataMember(Name = "mpn", Order = 230)]
        public OneOrManyMpn Mpn { get; set; }

        /// <summary>
        /// One or more detailed price specifications, indicating the unit price and delivery or payment charges.
        /// </summary>
        [DataMember(Name = "priceSpecification", Order = 231)]
        public OneOrManyPriceSpecification PriceSpecification { get; set; }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [DataMember(Name = "seller", Order = 232)]
        public OneOrManySeller Seller { get; set; }

        /// <summary>
        /// The serial number or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial number of the product included in the offer.
        /// </summary>
        [DataMember(Name = "serialNumber", Order = 233)]
        public OneOrManySerialNumber SerialNumber { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        /// </summary>
        [DataMember(Name = "sku", Order = 234)]
        public OneOrManySku Sku { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [DataMember(Name = "validFrom", Order = 235)]
        public OneOrManyValidFrom ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough", Order = 236)]
        public OneOrManyValidThrough ValidThrough { get; set; }

        /// <summary>
        /// The warranty promise(s) included in the offer.
        /// </summary>
        [DataMember(Name = "warranty", Order = 237)]
        public OneOrManyWarranty Warranty { get; set; }
    }
}
