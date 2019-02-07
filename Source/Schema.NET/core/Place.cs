namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
    [DataContract]
    public partial class Place : Thing
    {
        public interface IAdditionalProperty : IValue {}
        public interface IAdditionalProperty<T> : IAdditionalProperty { new T Value { get; } }
        public class OneOrManyAdditionalProperty : OneOrMany<IAdditionalProperty>
        {
            public OneOrManyAdditionalProperty(IAdditionalProperty item) : base(item) { }
            public OneOrManyAdditionalProperty(IEnumerable<IAdditionalProperty> items) : base(items) { }
            public static implicit operator OneOrManyAdditionalProperty (PropertyValue value) { return new OneOrManyAdditionalProperty (new AdditionalPropertyPropertyValue (value)); }
            public static implicit operator OneOrManyAdditionalProperty (PropertyValue[] values) { return new OneOrManyAdditionalProperty (values.Select(v => (IAdditionalProperty) new AdditionalPropertyPropertyValue (v))); }
            public static implicit operator OneOrManyAdditionalProperty (List<PropertyValue> values) { return new OneOrManyAdditionalProperty (values.Select(v => (IAdditionalProperty) new AdditionalPropertyPropertyValue (v))); }
        }
        public struct AdditionalPropertyPropertyValue : IAdditionalProperty<PropertyValue>
        {
            object IValue.Value => this.Value;
            public PropertyValue Value { get; }
            public AdditionalPropertyPropertyValue (PropertyValue value) { Value = value; }
            public static implicit operator AdditionalPropertyPropertyValue (PropertyValue value) { return new AdditionalPropertyPropertyValue (value); }
        }

        public interface IAddress : IValue {}
        public interface IAddress<T> : IAddress { new T Value { get; } }
        public class OneOrManyAddress : OneOrMany<IAddress>
        {
            public OneOrManyAddress(IAddress item) : base(item) { }
            public OneOrManyAddress(IEnumerable<IAddress> items) : base(items) { }
            public static implicit operator OneOrManyAddress (PostalAddress value) { return new OneOrManyAddress (new AddressPostalAddress (value)); }
            public static implicit operator OneOrManyAddress (PostalAddress[] values) { return new OneOrManyAddress (values.Select(v => (IAddress) new AddressPostalAddress (v))); }
            public static implicit operator OneOrManyAddress (List<PostalAddress> values) { return new OneOrManyAddress (values.Select(v => (IAddress) new AddressPostalAddress (v))); }
            public static implicit operator OneOrManyAddress (string value) { return new OneOrManyAddress (new Addressstring (value)); }
            public static implicit operator OneOrManyAddress (string[] values) { return new OneOrManyAddress (values.Select(v => (IAddress) new Addressstring (v))); }
            public static implicit operator OneOrManyAddress (List<string> values) { return new OneOrManyAddress (values.Select(v => (IAddress) new Addressstring (v))); }
        }
        public struct AddressPostalAddress : IAddress<PostalAddress>
        {
            object IValue.Value => this.Value;
            public PostalAddress Value { get; }
            public AddressPostalAddress (PostalAddress value) { Value = value; }
            public static implicit operator AddressPostalAddress (PostalAddress value) { return new AddressPostalAddress (value); }
        }
        public struct Addressstring : IAddress<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Addressstring (string value) { Value = value; }
            public static implicit operator Addressstring (string value) { return new Addressstring (value); }
        }

        public interface IAggregateRating : IValue {}
        public interface IAggregateRating<T> : IAggregateRating { new T Value { get; } }
        public class OneOrManyAggregateRating : OneOrMany<IAggregateRating>
        {
            public OneOrManyAggregateRating(IAggregateRating item) : base(item) { }
            public OneOrManyAggregateRating(IEnumerable<IAggregateRating> items) : base(items) { }
            public static implicit operator OneOrManyAggregateRating (AggregateRating value) { return new OneOrManyAggregateRating (new AggregateRatingAggregateRating (value)); }
            public static implicit operator OneOrManyAggregateRating (AggregateRating[] values) { return new OneOrManyAggregateRating (values.Select(v => (IAggregateRating) new AggregateRatingAggregateRating (v))); }
            public static implicit operator OneOrManyAggregateRating (List<AggregateRating> values) { return new OneOrManyAggregateRating (values.Select(v => (IAggregateRating) new AggregateRatingAggregateRating (v))); }
        }
        public struct AggregateRatingAggregateRating : IAggregateRating<AggregateRating>
        {
            object IValue.Value => this.Value;
            public AggregateRating Value { get; }
            public AggregateRatingAggregateRating (AggregateRating value) { Value = value; }
            public static implicit operator AggregateRatingAggregateRating (AggregateRating value) { return new AggregateRatingAggregateRating (value); }
        }

        public interface IAmenityFeature : IValue {}
        public interface IAmenityFeature<T> : IAmenityFeature { new T Value { get; } }
        public class OneOrManyAmenityFeature : OneOrMany<IAmenityFeature>
        {
            public OneOrManyAmenityFeature(IAmenityFeature item) : base(item) { }
            public OneOrManyAmenityFeature(IEnumerable<IAmenityFeature> items) : base(items) { }
            public static implicit operator OneOrManyAmenityFeature (LocationFeatureSpecification value) { return new OneOrManyAmenityFeature (new AmenityFeatureLocationFeatureSpecification (value)); }
            public static implicit operator OneOrManyAmenityFeature (LocationFeatureSpecification[] values) { return new OneOrManyAmenityFeature (values.Select(v => (IAmenityFeature) new AmenityFeatureLocationFeatureSpecification (v))); }
            public static implicit operator OneOrManyAmenityFeature (List<LocationFeatureSpecification> values) { return new OneOrManyAmenityFeature (values.Select(v => (IAmenityFeature) new AmenityFeatureLocationFeatureSpecification (v))); }
        }
        public struct AmenityFeatureLocationFeatureSpecification : IAmenityFeature<LocationFeatureSpecification>
        {
            object IValue.Value => this.Value;
            public LocationFeatureSpecification Value { get; }
            public AmenityFeatureLocationFeatureSpecification (LocationFeatureSpecification value) { Value = value; }
            public static implicit operator AmenityFeatureLocationFeatureSpecification (LocationFeatureSpecification value) { return new AmenityFeatureLocationFeatureSpecification (value); }
        }

        public interface IBranchCode : IValue {}
        public interface IBranchCode<T> : IBranchCode { new T Value { get; } }
        public class OneOrManyBranchCode : OneOrMany<IBranchCode>
        {
            public OneOrManyBranchCode(IBranchCode item) : base(item) { }
            public OneOrManyBranchCode(IEnumerable<IBranchCode> items) : base(items) { }
            public static implicit operator OneOrManyBranchCode (string value) { return new OneOrManyBranchCode (new BranchCodestring (value)); }
            public static implicit operator OneOrManyBranchCode (string[] values) { return new OneOrManyBranchCode (values.Select(v => (IBranchCode) new BranchCodestring (v))); }
            public static implicit operator OneOrManyBranchCode (List<string> values) { return new OneOrManyBranchCode (values.Select(v => (IBranchCode) new BranchCodestring (v))); }
        }
        public struct BranchCodestring : IBranchCode<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public BranchCodestring (string value) { Value = value; }
            public static implicit operator BranchCodestring (string value) { return new BranchCodestring (value); }
        }

        public interface IContainedInPlace : IValue {}
        public interface IContainedInPlace<T> : IContainedInPlace { new T Value { get; } }
        public class OneOrManyContainedInPlace : OneOrMany<IContainedInPlace>
        {
            public OneOrManyContainedInPlace(IContainedInPlace item) : base(item) { }
            public OneOrManyContainedInPlace(IEnumerable<IContainedInPlace> items) : base(items) { }
            public static implicit operator OneOrManyContainedInPlace (Place value) { return new OneOrManyContainedInPlace (new ContainedInPlacePlace (value)); }
            public static implicit operator OneOrManyContainedInPlace (Place[] values) { return new OneOrManyContainedInPlace (values.Select(v => (IContainedInPlace) new ContainedInPlacePlace (v))); }
            public static implicit operator OneOrManyContainedInPlace (List<Place> values) { return new OneOrManyContainedInPlace (values.Select(v => (IContainedInPlace) new ContainedInPlacePlace (v))); }
        }
        public struct ContainedInPlacePlace : IContainedInPlace<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public ContainedInPlacePlace (Place value) { Value = value; }
            public static implicit operator ContainedInPlacePlace (Place value) { return new ContainedInPlacePlace (value); }
        }

        public interface IContainsPlace : IValue {}
        public interface IContainsPlace<T> : IContainsPlace { new T Value { get; } }
        public class OneOrManyContainsPlace : OneOrMany<IContainsPlace>
        {
            public OneOrManyContainsPlace(IContainsPlace item) : base(item) { }
            public OneOrManyContainsPlace(IEnumerable<IContainsPlace> items) : base(items) { }
            public static implicit operator OneOrManyContainsPlace (Place value) { return new OneOrManyContainsPlace (new ContainsPlacePlace (value)); }
            public static implicit operator OneOrManyContainsPlace (Place[] values) { return new OneOrManyContainsPlace (values.Select(v => (IContainsPlace) new ContainsPlacePlace (v))); }
            public static implicit operator OneOrManyContainsPlace (List<Place> values) { return new OneOrManyContainsPlace (values.Select(v => (IContainsPlace) new ContainsPlacePlace (v))); }
        }
        public struct ContainsPlacePlace : IContainsPlace<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public ContainsPlacePlace (Place value) { Value = value; }
            public static implicit operator ContainsPlacePlace (Place value) { return new ContainsPlacePlace (value); }
        }

        public interface IEvent : IValue {}
        public interface IEvent<T> : IEvent { new T Value { get; } }
        public class OneOrManyEvent : OneOrMany<IEvent>
        {
            public OneOrManyEvent(IEvent item) : base(item) { }
            public OneOrManyEvent(IEnumerable<IEvent> items) : base(items) { }
            public static implicit operator OneOrManyEvent (Event value) { return new OneOrManyEvent (new EventEvent (value)); }
            public static implicit operator OneOrManyEvent (Event[] values) { return new OneOrManyEvent (values.Select(v => (IEvent) new EventEvent (v))); }
            public static implicit operator OneOrManyEvent (List<Event> values) { return new OneOrManyEvent (values.Select(v => (IEvent) new EventEvent (v))); }
        }
        public struct EventEvent : IEvent<Event>
        {
            object IValue.Value => this.Value;
            public Event Value { get; }
            public EventEvent (Event value) { Value = value; }
            public static implicit operator EventEvent (Event value) { return new EventEvent (value); }
        }

        public interface IFaxNumber : IValue {}
        public interface IFaxNumber<T> : IFaxNumber { new T Value { get; } }
        public class OneOrManyFaxNumber : OneOrMany<IFaxNumber>
        {
            public OneOrManyFaxNumber(IFaxNumber item) : base(item) { }
            public OneOrManyFaxNumber(IEnumerable<IFaxNumber> items) : base(items) { }
            public static implicit operator OneOrManyFaxNumber (string value) { return new OneOrManyFaxNumber (new FaxNumberstring (value)); }
            public static implicit operator OneOrManyFaxNumber (string[] values) { return new OneOrManyFaxNumber (values.Select(v => (IFaxNumber) new FaxNumberstring (v))); }
            public static implicit operator OneOrManyFaxNumber (List<string> values) { return new OneOrManyFaxNumber (values.Select(v => (IFaxNumber) new FaxNumberstring (v))); }
        }
        public struct FaxNumberstring : IFaxNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public FaxNumberstring (string value) { Value = value; }
            public static implicit operator FaxNumberstring (string value) { return new FaxNumberstring (value); }
        }

        public interface IGeo : IValue {}
        public interface IGeo<T> : IGeo { new T Value { get; } }
        public class OneOrManyGeo : OneOrMany<IGeo>
        {
            public OneOrManyGeo(IGeo item) : base(item) { }
            public OneOrManyGeo(IEnumerable<IGeo> items) : base(items) { }
            public static implicit operator OneOrManyGeo (GeoCoordinates value) { return new OneOrManyGeo (new GeoGeoCoordinates (value)); }
            public static implicit operator OneOrManyGeo (GeoCoordinates[] values) { return new OneOrManyGeo (values.Select(v => (IGeo) new GeoGeoCoordinates (v))); }
            public static implicit operator OneOrManyGeo (List<GeoCoordinates> values) { return new OneOrManyGeo (values.Select(v => (IGeo) new GeoGeoCoordinates (v))); }
            public static implicit operator OneOrManyGeo (GeoShape value) { return new OneOrManyGeo (new GeoGeoShape (value)); }
            public static implicit operator OneOrManyGeo (GeoShape[] values) { return new OneOrManyGeo (values.Select(v => (IGeo) new GeoGeoShape (v))); }
            public static implicit operator OneOrManyGeo (List<GeoShape> values) { return new OneOrManyGeo (values.Select(v => (IGeo) new GeoGeoShape (v))); }
        }
        public struct GeoGeoCoordinates : IGeo<GeoCoordinates>
        {
            object IValue.Value => this.Value;
            public GeoCoordinates Value { get; }
            public GeoGeoCoordinates (GeoCoordinates value) { Value = value; }
            public static implicit operator GeoGeoCoordinates (GeoCoordinates value) { return new GeoGeoCoordinates (value); }
        }
        public struct GeoGeoShape : IGeo<GeoShape>
        {
            object IValue.Value => this.Value;
            public GeoShape Value { get; }
            public GeoGeoShape (GeoShape value) { Value = value; }
            public static implicit operator GeoGeoShape (GeoShape value) { return new GeoGeoShape (value); }
        }

        public interface IGeospatiallyContains : IValue {}
        public interface IGeospatiallyContains<T> : IGeospatiallyContains { new T Value { get; } }
        public class OneOrManyGeospatiallyContains : OneOrMany<IGeospatiallyContains>
        {
            public OneOrManyGeospatiallyContains(IGeospatiallyContains item) : base(item) { }
            public OneOrManyGeospatiallyContains(IEnumerable<IGeospatiallyContains> items) : base(items) { }
            public static implicit operator OneOrManyGeospatiallyContains (Place value) { return new OneOrManyGeospatiallyContains (new GeospatiallyContainsPlace (value)); }
            public static implicit operator OneOrManyGeospatiallyContains (Place[] values) { return new OneOrManyGeospatiallyContains (values.Select(v => (IGeospatiallyContains) new GeospatiallyContainsPlace (v))); }
            public static implicit operator OneOrManyGeospatiallyContains (List<Place> values) { return new OneOrManyGeospatiallyContains (values.Select(v => (IGeospatiallyContains) new GeospatiallyContainsPlace (v))); }
        }
        public struct GeospatiallyContainsPlace : IGeospatiallyContains<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public GeospatiallyContainsPlace (Place value) { Value = value; }
            public static implicit operator GeospatiallyContainsPlace (Place value) { return new GeospatiallyContainsPlace (value); }
        }

        public interface IGeospatiallyCoveredBy : IValue {}
        public interface IGeospatiallyCoveredBy<T> : IGeospatiallyCoveredBy { new T Value { get; } }
        public class OneOrManyGeospatiallyCoveredBy : OneOrMany<IGeospatiallyCoveredBy>
        {
            public OneOrManyGeospatiallyCoveredBy(IGeospatiallyCoveredBy item) : base(item) { }
            public OneOrManyGeospatiallyCoveredBy(IEnumerable<IGeospatiallyCoveredBy> items) : base(items) { }
            public static implicit operator OneOrManyGeospatiallyCoveredBy (Place value) { return new OneOrManyGeospatiallyCoveredBy (new GeospatiallyCoveredByPlace (value)); }
            public static implicit operator OneOrManyGeospatiallyCoveredBy (Place[] values) { return new OneOrManyGeospatiallyCoveredBy (values.Select(v => (IGeospatiallyCoveredBy) new GeospatiallyCoveredByPlace (v))); }
            public static implicit operator OneOrManyGeospatiallyCoveredBy (List<Place> values) { return new OneOrManyGeospatiallyCoveredBy (values.Select(v => (IGeospatiallyCoveredBy) new GeospatiallyCoveredByPlace (v))); }
        }
        public struct GeospatiallyCoveredByPlace : IGeospatiallyCoveredBy<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public GeospatiallyCoveredByPlace (Place value) { Value = value; }
            public static implicit operator GeospatiallyCoveredByPlace (Place value) { return new GeospatiallyCoveredByPlace (value); }
        }

        public interface IGeospatiallyCovers : IValue {}
        public interface IGeospatiallyCovers<T> : IGeospatiallyCovers { new T Value { get; } }
        public class OneOrManyGeospatiallyCovers : OneOrMany<IGeospatiallyCovers>
        {
            public OneOrManyGeospatiallyCovers(IGeospatiallyCovers item) : base(item) { }
            public OneOrManyGeospatiallyCovers(IEnumerable<IGeospatiallyCovers> items) : base(items) { }
            public static implicit operator OneOrManyGeospatiallyCovers (Place value) { return new OneOrManyGeospatiallyCovers (new GeospatiallyCoversPlace (value)); }
            public static implicit operator OneOrManyGeospatiallyCovers (Place[] values) { return new OneOrManyGeospatiallyCovers (values.Select(v => (IGeospatiallyCovers) new GeospatiallyCoversPlace (v))); }
            public static implicit operator OneOrManyGeospatiallyCovers (List<Place> values) { return new OneOrManyGeospatiallyCovers (values.Select(v => (IGeospatiallyCovers) new GeospatiallyCoversPlace (v))); }
        }
        public struct GeospatiallyCoversPlace : IGeospatiallyCovers<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public GeospatiallyCoversPlace (Place value) { Value = value; }
            public static implicit operator GeospatiallyCoversPlace (Place value) { return new GeospatiallyCoversPlace (value); }
        }

        public interface IGeospatiallyCrosses : IValue {}
        public interface IGeospatiallyCrosses<T> : IGeospatiallyCrosses { new T Value { get; } }
        public class OneOrManyGeospatiallyCrosses : OneOrMany<IGeospatiallyCrosses>
        {
            public OneOrManyGeospatiallyCrosses(IGeospatiallyCrosses item) : base(item) { }
            public OneOrManyGeospatiallyCrosses(IEnumerable<IGeospatiallyCrosses> items) : base(items) { }
            public static implicit operator OneOrManyGeospatiallyCrosses (Place value) { return new OneOrManyGeospatiallyCrosses (new GeospatiallyCrossesPlace (value)); }
            public static implicit operator OneOrManyGeospatiallyCrosses (Place[] values) { return new OneOrManyGeospatiallyCrosses (values.Select(v => (IGeospatiallyCrosses) new GeospatiallyCrossesPlace (v))); }
            public static implicit operator OneOrManyGeospatiallyCrosses (List<Place> values) { return new OneOrManyGeospatiallyCrosses (values.Select(v => (IGeospatiallyCrosses) new GeospatiallyCrossesPlace (v))); }
        }
        public struct GeospatiallyCrossesPlace : IGeospatiallyCrosses<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public GeospatiallyCrossesPlace (Place value) { Value = value; }
            public static implicit operator GeospatiallyCrossesPlace (Place value) { return new GeospatiallyCrossesPlace (value); }
        }

        public interface IGeospatiallyDisjoint : IValue {}
        public interface IGeospatiallyDisjoint<T> : IGeospatiallyDisjoint { new T Value { get; } }
        public class OneOrManyGeospatiallyDisjoint : OneOrMany<IGeospatiallyDisjoint>
        {
            public OneOrManyGeospatiallyDisjoint(IGeospatiallyDisjoint item) : base(item) { }
            public OneOrManyGeospatiallyDisjoint(IEnumerable<IGeospatiallyDisjoint> items) : base(items) { }
            public static implicit operator OneOrManyGeospatiallyDisjoint (Place value) { return new OneOrManyGeospatiallyDisjoint (new GeospatiallyDisjointPlace (value)); }
            public static implicit operator OneOrManyGeospatiallyDisjoint (Place[] values) { return new OneOrManyGeospatiallyDisjoint (values.Select(v => (IGeospatiallyDisjoint) new GeospatiallyDisjointPlace (v))); }
            public static implicit operator OneOrManyGeospatiallyDisjoint (List<Place> values) { return new OneOrManyGeospatiallyDisjoint (values.Select(v => (IGeospatiallyDisjoint) new GeospatiallyDisjointPlace (v))); }
        }
        public struct GeospatiallyDisjointPlace : IGeospatiallyDisjoint<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public GeospatiallyDisjointPlace (Place value) { Value = value; }
            public static implicit operator GeospatiallyDisjointPlace (Place value) { return new GeospatiallyDisjointPlace (value); }
        }

        public interface IGeospatiallyEquals : IValue {}
        public interface IGeospatiallyEquals<T> : IGeospatiallyEquals { new T Value { get; } }
        public class OneOrManyGeospatiallyEquals : OneOrMany<IGeospatiallyEquals>
        {
            public OneOrManyGeospatiallyEquals(IGeospatiallyEquals item) : base(item) { }
            public OneOrManyGeospatiallyEquals(IEnumerable<IGeospatiallyEquals> items) : base(items) { }
            public static implicit operator OneOrManyGeospatiallyEquals (Place value) { return new OneOrManyGeospatiallyEquals (new GeospatiallyEqualsPlace (value)); }
            public static implicit operator OneOrManyGeospatiallyEquals (Place[] values) { return new OneOrManyGeospatiallyEquals (values.Select(v => (IGeospatiallyEquals) new GeospatiallyEqualsPlace (v))); }
            public static implicit operator OneOrManyGeospatiallyEquals (List<Place> values) { return new OneOrManyGeospatiallyEquals (values.Select(v => (IGeospatiallyEquals) new GeospatiallyEqualsPlace (v))); }
        }
        public struct GeospatiallyEqualsPlace : IGeospatiallyEquals<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public GeospatiallyEqualsPlace (Place value) { Value = value; }
            public static implicit operator GeospatiallyEqualsPlace (Place value) { return new GeospatiallyEqualsPlace (value); }
        }

        public interface IGeospatiallyIntersects : IValue {}
        public interface IGeospatiallyIntersects<T> : IGeospatiallyIntersects { new T Value { get; } }
        public class OneOrManyGeospatiallyIntersects : OneOrMany<IGeospatiallyIntersects>
        {
            public OneOrManyGeospatiallyIntersects(IGeospatiallyIntersects item) : base(item) { }
            public OneOrManyGeospatiallyIntersects(IEnumerable<IGeospatiallyIntersects> items) : base(items) { }
            public static implicit operator OneOrManyGeospatiallyIntersects (Place value) { return new OneOrManyGeospatiallyIntersects (new GeospatiallyIntersectsPlace (value)); }
            public static implicit operator OneOrManyGeospatiallyIntersects (Place[] values) { return new OneOrManyGeospatiallyIntersects (values.Select(v => (IGeospatiallyIntersects) new GeospatiallyIntersectsPlace (v))); }
            public static implicit operator OneOrManyGeospatiallyIntersects (List<Place> values) { return new OneOrManyGeospatiallyIntersects (values.Select(v => (IGeospatiallyIntersects) new GeospatiallyIntersectsPlace (v))); }
        }
        public struct GeospatiallyIntersectsPlace : IGeospatiallyIntersects<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public GeospatiallyIntersectsPlace (Place value) { Value = value; }
            public static implicit operator GeospatiallyIntersectsPlace (Place value) { return new GeospatiallyIntersectsPlace (value); }
        }

        public interface IGeospatiallyOverlaps : IValue {}
        public interface IGeospatiallyOverlaps<T> : IGeospatiallyOverlaps { new T Value { get; } }
        public class OneOrManyGeospatiallyOverlaps : OneOrMany<IGeospatiallyOverlaps>
        {
            public OneOrManyGeospatiallyOverlaps(IGeospatiallyOverlaps item) : base(item) { }
            public OneOrManyGeospatiallyOverlaps(IEnumerable<IGeospatiallyOverlaps> items) : base(items) { }
            public static implicit operator OneOrManyGeospatiallyOverlaps (Place value) { return new OneOrManyGeospatiallyOverlaps (new GeospatiallyOverlapsPlace (value)); }
            public static implicit operator OneOrManyGeospatiallyOverlaps (Place[] values) { return new OneOrManyGeospatiallyOverlaps (values.Select(v => (IGeospatiallyOverlaps) new GeospatiallyOverlapsPlace (v))); }
            public static implicit operator OneOrManyGeospatiallyOverlaps (List<Place> values) { return new OneOrManyGeospatiallyOverlaps (values.Select(v => (IGeospatiallyOverlaps) new GeospatiallyOverlapsPlace (v))); }
        }
        public struct GeospatiallyOverlapsPlace : IGeospatiallyOverlaps<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public GeospatiallyOverlapsPlace (Place value) { Value = value; }
            public static implicit operator GeospatiallyOverlapsPlace (Place value) { return new GeospatiallyOverlapsPlace (value); }
        }

        public interface IGeospatiallyTouches : IValue {}
        public interface IGeospatiallyTouches<T> : IGeospatiallyTouches { new T Value { get; } }
        public class OneOrManyGeospatiallyTouches : OneOrMany<IGeospatiallyTouches>
        {
            public OneOrManyGeospatiallyTouches(IGeospatiallyTouches item) : base(item) { }
            public OneOrManyGeospatiallyTouches(IEnumerable<IGeospatiallyTouches> items) : base(items) { }
            public static implicit operator OneOrManyGeospatiallyTouches (Place value) { return new OneOrManyGeospatiallyTouches (new GeospatiallyTouchesPlace (value)); }
            public static implicit operator OneOrManyGeospatiallyTouches (Place[] values) { return new OneOrManyGeospatiallyTouches (values.Select(v => (IGeospatiallyTouches) new GeospatiallyTouchesPlace (v))); }
            public static implicit operator OneOrManyGeospatiallyTouches (List<Place> values) { return new OneOrManyGeospatiallyTouches (values.Select(v => (IGeospatiallyTouches) new GeospatiallyTouchesPlace (v))); }
        }
        public struct GeospatiallyTouchesPlace : IGeospatiallyTouches<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public GeospatiallyTouchesPlace (Place value) { Value = value; }
            public static implicit operator GeospatiallyTouchesPlace (Place value) { return new GeospatiallyTouchesPlace (value); }
        }

        public interface IGeospatiallyWithin : IValue {}
        public interface IGeospatiallyWithin<T> : IGeospatiallyWithin { new T Value { get; } }
        public class OneOrManyGeospatiallyWithin : OneOrMany<IGeospatiallyWithin>
        {
            public OneOrManyGeospatiallyWithin(IGeospatiallyWithin item) : base(item) { }
            public OneOrManyGeospatiallyWithin(IEnumerable<IGeospatiallyWithin> items) : base(items) { }
            public static implicit operator OneOrManyGeospatiallyWithin (Place value) { return new OneOrManyGeospatiallyWithin (new GeospatiallyWithinPlace (value)); }
            public static implicit operator OneOrManyGeospatiallyWithin (Place[] values) { return new OneOrManyGeospatiallyWithin (values.Select(v => (IGeospatiallyWithin) new GeospatiallyWithinPlace (v))); }
            public static implicit operator OneOrManyGeospatiallyWithin (List<Place> values) { return new OneOrManyGeospatiallyWithin (values.Select(v => (IGeospatiallyWithin) new GeospatiallyWithinPlace (v))); }
        }
        public struct GeospatiallyWithinPlace : IGeospatiallyWithin<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public GeospatiallyWithinPlace (Place value) { Value = value; }
            public static implicit operator GeospatiallyWithinPlace (Place value) { return new GeospatiallyWithinPlace (value); }
        }

        public interface IGlobalLocationNumber : IValue {}
        public interface IGlobalLocationNumber<T> : IGlobalLocationNumber { new T Value { get; } }
        public class OneOrManyGlobalLocationNumber : OneOrMany<IGlobalLocationNumber>
        {
            public OneOrManyGlobalLocationNumber(IGlobalLocationNumber item) : base(item) { }
            public OneOrManyGlobalLocationNumber(IEnumerable<IGlobalLocationNumber> items) : base(items) { }
            public static implicit operator OneOrManyGlobalLocationNumber (string value) { return new OneOrManyGlobalLocationNumber (new GlobalLocationNumberstring (value)); }
            public static implicit operator OneOrManyGlobalLocationNumber (string[] values) { return new OneOrManyGlobalLocationNumber (values.Select(v => (IGlobalLocationNumber) new GlobalLocationNumberstring (v))); }
            public static implicit operator OneOrManyGlobalLocationNumber (List<string> values) { return new OneOrManyGlobalLocationNumber (values.Select(v => (IGlobalLocationNumber) new GlobalLocationNumberstring (v))); }
        }
        public struct GlobalLocationNumberstring : IGlobalLocationNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public GlobalLocationNumberstring (string value) { Value = value; }
            public static implicit operator GlobalLocationNumberstring (string value) { return new GlobalLocationNumberstring (value); }
        }

        public interface IHasMap : IValue {}
        public interface IHasMap<T> : IHasMap { new T Value { get; } }
        public class OneOrManyHasMap : OneOrMany<IHasMap>
        {
            public OneOrManyHasMap(IHasMap item) : base(item) { }
            public OneOrManyHasMap(IEnumerable<IHasMap> items) : base(items) { }
            public static implicit operator OneOrManyHasMap (Map value) { return new OneOrManyHasMap (new HasMapMap (value)); }
            public static implicit operator OneOrManyHasMap (Map[] values) { return new OneOrManyHasMap (values.Select(v => (IHasMap) new HasMapMap (v))); }
            public static implicit operator OneOrManyHasMap (List<Map> values) { return new OneOrManyHasMap (values.Select(v => (IHasMap) new HasMapMap (v))); }
            public static implicit operator OneOrManyHasMap (Uri value) { return new OneOrManyHasMap (new HasMapUri (value)); }
            public static implicit operator OneOrManyHasMap (Uri[] values) { return new OneOrManyHasMap (values.Select(v => (IHasMap) new HasMapUri (v))); }
            public static implicit operator OneOrManyHasMap (List<Uri> values) { return new OneOrManyHasMap (values.Select(v => (IHasMap) new HasMapUri (v))); }
        }
        public struct HasMapMap : IHasMap<Map>
        {
            object IValue.Value => this.Value;
            public Map Value { get; }
            public HasMapMap (Map value) { Value = value; }
            public static implicit operator HasMapMap (Map value) { return new HasMapMap (value); }
        }
        public struct HasMapUri : IHasMap<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public HasMapUri (Uri value) { Value = value; }
            public static implicit operator HasMapUri (Uri value) { return new HasMapUri (value); }
        }

        public interface IIsAccessibleForFree : IValue {}
        public interface IIsAccessibleForFree<T> : IIsAccessibleForFree { new T Value { get; } }
        public class OneOrManyIsAccessibleForFree : OneOrMany<IIsAccessibleForFree>
        {
            public OneOrManyIsAccessibleForFree(IIsAccessibleForFree item) : base(item) { }
            public OneOrManyIsAccessibleForFree(IEnumerable<IIsAccessibleForFree> items) : base(items) { }
            public static implicit operator OneOrManyIsAccessibleForFree (bool value) { return new OneOrManyIsAccessibleForFree (new IsAccessibleForFreebool (value)); }
            public static implicit operator OneOrManyIsAccessibleForFree (bool[] values) { return new OneOrManyIsAccessibleForFree (values.Select(v => (IIsAccessibleForFree) new IsAccessibleForFreebool (v))); }
            public static implicit operator OneOrManyIsAccessibleForFree (List<bool> values) { return new OneOrManyIsAccessibleForFree (values.Select(v => (IIsAccessibleForFree) new IsAccessibleForFreebool (v))); }
        }
        public struct IsAccessibleForFreebool : IIsAccessibleForFree<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public IsAccessibleForFreebool (bool value) { Value = value; }
            public static implicit operator IsAccessibleForFreebool (bool value) { return new IsAccessibleForFreebool (value); }
        }

        public interface IIsicV4 : IValue {}
        public interface IIsicV4<T> : IIsicV4 { new T Value { get; } }
        public class OneOrManyIsicV4 : OneOrMany<IIsicV4>
        {
            public OneOrManyIsicV4(IIsicV4 item) : base(item) { }
            public OneOrManyIsicV4(IEnumerable<IIsicV4> items) : base(items) { }
            public static implicit operator OneOrManyIsicV4 (string value) { return new OneOrManyIsicV4 (new IsicV4string (value)); }
            public static implicit operator OneOrManyIsicV4 (string[] values) { return new OneOrManyIsicV4 (values.Select(v => (IIsicV4) new IsicV4string (v))); }
            public static implicit operator OneOrManyIsicV4 (List<string> values) { return new OneOrManyIsicV4 (values.Select(v => (IIsicV4) new IsicV4string (v))); }
        }
        public struct IsicV4string : IIsicV4<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public IsicV4string (string value) { Value = value; }
            public static implicit operator IsicV4string (string value) { return new IsicV4string (value); }
        }

        public interface ILogo : IValue {}
        public interface ILogo<T> : ILogo { new T Value { get; } }
        public class OneOrManyLogo : OneOrMany<ILogo>
        {
            public OneOrManyLogo(ILogo item) : base(item) { }
            public OneOrManyLogo(IEnumerable<ILogo> items) : base(items) { }
            public static implicit operator OneOrManyLogo (ImageObject value) { return new OneOrManyLogo (new LogoImageObject (value)); }
            public static implicit operator OneOrManyLogo (ImageObject[] values) { return new OneOrManyLogo (values.Select(v => (ILogo) new LogoImageObject (v))); }
            public static implicit operator OneOrManyLogo (List<ImageObject> values) { return new OneOrManyLogo (values.Select(v => (ILogo) new LogoImageObject (v))); }
            public static implicit operator OneOrManyLogo (Uri value) { return new OneOrManyLogo (new LogoUri (value)); }
            public static implicit operator OneOrManyLogo (Uri[] values) { return new OneOrManyLogo (values.Select(v => (ILogo) new LogoUri (v))); }
            public static implicit operator OneOrManyLogo (List<Uri> values) { return new OneOrManyLogo (values.Select(v => (ILogo) new LogoUri (v))); }
        }
        public struct LogoImageObject : ILogo<ImageObject>
        {
            object IValue.Value => this.Value;
            public ImageObject Value { get; }
            public LogoImageObject (ImageObject value) { Value = value; }
            public static implicit operator LogoImageObject (ImageObject value) { return new LogoImageObject (value); }
        }
        public struct LogoUri : ILogo<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public LogoUri (Uri value) { Value = value; }
            public static implicit operator LogoUri (Uri value) { return new LogoUri (value); }
        }

        public interface IMaximumAttendeeCapacity : IValue {}
        public interface IMaximumAttendeeCapacity<T> : IMaximumAttendeeCapacity { new T Value { get; } }
        public class OneOrManyMaximumAttendeeCapacity : OneOrMany<IMaximumAttendeeCapacity>
        {
            public OneOrManyMaximumAttendeeCapacity(IMaximumAttendeeCapacity item) : base(item) { }
            public OneOrManyMaximumAttendeeCapacity(IEnumerable<IMaximumAttendeeCapacity> items) : base(items) { }
            public static implicit operator OneOrManyMaximumAttendeeCapacity (int value) { return new OneOrManyMaximumAttendeeCapacity (new MaximumAttendeeCapacityint (value)); }
            public static implicit operator OneOrManyMaximumAttendeeCapacity (int[] values) { return new OneOrManyMaximumAttendeeCapacity (values.Select(v => (IMaximumAttendeeCapacity) new MaximumAttendeeCapacityint (v))); }
            public static implicit operator OneOrManyMaximumAttendeeCapacity (List<int> values) { return new OneOrManyMaximumAttendeeCapacity (values.Select(v => (IMaximumAttendeeCapacity) new MaximumAttendeeCapacityint (v))); }
        }
        public struct MaximumAttendeeCapacityint : IMaximumAttendeeCapacity<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public MaximumAttendeeCapacityint (int value) { Value = value; }
            public static implicit operator MaximumAttendeeCapacityint (int value) { return new MaximumAttendeeCapacityint (value); }
        }

        public interface IOpeningHoursSpecification : IValue {}
        public interface IOpeningHoursSpecification<T> : IOpeningHoursSpecification { new T Value { get; } }
        public class OneOrManyOpeningHoursSpecification : OneOrMany<IOpeningHoursSpecification>
        {
            public OneOrManyOpeningHoursSpecification(IOpeningHoursSpecification item) : base(item) { }
            public OneOrManyOpeningHoursSpecification(IEnumerable<IOpeningHoursSpecification> items) : base(items) { }
            public static implicit operator OneOrManyOpeningHoursSpecification (OpeningHoursSpecification value) { return new OneOrManyOpeningHoursSpecification (new OpeningHoursSpecificationOpeningHoursSpecification (value)); }
            public static implicit operator OneOrManyOpeningHoursSpecification (OpeningHoursSpecification[] values) { return new OneOrManyOpeningHoursSpecification (values.Select(v => (IOpeningHoursSpecification) new OpeningHoursSpecificationOpeningHoursSpecification (v))); }
            public static implicit operator OneOrManyOpeningHoursSpecification (List<OpeningHoursSpecification> values) { return new OneOrManyOpeningHoursSpecification (values.Select(v => (IOpeningHoursSpecification) new OpeningHoursSpecificationOpeningHoursSpecification (v))); }
        }
        public struct OpeningHoursSpecificationOpeningHoursSpecification : IOpeningHoursSpecification<OpeningHoursSpecification>
        {
            object IValue.Value => this.Value;
            public OpeningHoursSpecification Value { get; }
            public OpeningHoursSpecificationOpeningHoursSpecification (OpeningHoursSpecification value) { Value = value; }
            public static implicit operator OpeningHoursSpecificationOpeningHoursSpecification (OpeningHoursSpecification value) { return new OpeningHoursSpecificationOpeningHoursSpecification (value); }
        }

        public interface IPhoto : IValue {}
        public interface IPhoto<T> : IPhoto { new T Value { get; } }
        public class OneOrManyPhoto : OneOrMany<IPhoto>
        {
            public OneOrManyPhoto(IPhoto item) : base(item) { }
            public OneOrManyPhoto(IEnumerable<IPhoto> items) : base(items) { }
            public static implicit operator OneOrManyPhoto (ImageObject value) { return new OneOrManyPhoto (new PhotoImageObject (value)); }
            public static implicit operator OneOrManyPhoto (ImageObject[] values) { return new OneOrManyPhoto (values.Select(v => (IPhoto) new PhotoImageObject (v))); }
            public static implicit operator OneOrManyPhoto (List<ImageObject> values) { return new OneOrManyPhoto (values.Select(v => (IPhoto) new PhotoImageObject (v))); }
            public static implicit operator OneOrManyPhoto (Photograph value) { return new OneOrManyPhoto (new PhotoPhotograph (value)); }
            public static implicit operator OneOrManyPhoto (Photograph[] values) { return new OneOrManyPhoto (values.Select(v => (IPhoto) new PhotoPhotograph (v))); }
            public static implicit operator OneOrManyPhoto (List<Photograph> values) { return new OneOrManyPhoto (values.Select(v => (IPhoto) new PhotoPhotograph (v))); }
        }
        public struct PhotoImageObject : IPhoto<ImageObject>
        {
            object IValue.Value => this.Value;
            public ImageObject Value { get; }
            public PhotoImageObject (ImageObject value) { Value = value; }
            public static implicit operator PhotoImageObject (ImageObject value) { return new PhotoImageObject (value); }
        }
        public struct PhotoPhotograph : IPhoto<Photograph>
        {
            object IValue.Value => this.Value;
            public Photograph Value { get; }
            public PhotoPhotograph (Photograph value) { Value = value; }
            public static implicit operator PhotoPhotograph (Photograph value) { return new PhotoPhotograph (value); }
        }

        public interface IPublicAccess : IValue {}
        public interface IPublicAccess<T> : IPublicAccess { new T Value { get; } }
        public class OneOrManyPublicAccess : OneOrMany<IPublicAccess>
        {
            public OneOrManyPublicAccess(IPublicAccess item) : base(item) { }
            public OneOrManyPublicAccess(IEnumerable<IPublicAccess> items) : base(items) { }
            public static implicit operator OneOrManyPublicAccess (bool value) { return new OneOrManyPublicAccess (new PublicAccessbool (value)); }
            public static implicit operator OneOrManyPublicAccess (bool[] values) { return new OneOrManyPublicAccess (values.Select(v => (IPublicAccess) new PublicAccessbool (v))); }
            public static implicit operator OneOrManyPublicAccess (List<bool> values) { return new OneOrManyPublicAccess (values.Select(v => (IPublicAccess) new PublicAccessbool (v))); }
        }
        public struct PublicAccessbool : IPublicAccess<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public PublicAccessbool (bool value) { Value = value; }
            public static implicit operator PublicAccessbool (bool value) { return new PublicAccessbool (value); }
        }

        public interface IReview : IValue {}
        public interface IReview<T> : IReview { new T Value { get; } }
        public class OneOrManyReview : OneOrMany<IReview>
        {
            public OneOrManyReview(IReview item) : base(item) { }
            public OneOrManyReview(IEnumerable<IReview> items) : base(items) { }
            public static implicit operator OneOrManyReview (Review value) { return new OneOrManyReview (new ReviewReview (value)); }
            public static implicit operator OneOrManyReview (Review[] values) { return new OneOrManyReview (values.Select(v => (IReview) new ReviewReview (v))); }
            public static implicit operator OneOrManyReview (List<Review> values) { return new OneOrManyReview (values.Select(v => (IReview) new ReviewReview (v))); }
        }
        public struct ReviewReview : IReview<Review>
        {
            object IValue.Value => this.Value;
            public Review Value { get; }
            public ReviewReview (Review value) { Value = value; }
            public static implicit operator ReviewReview (Review value) { return new ReviewReview (value); }
        }

        public interface ISmokingAllowed : IValue {}
        public interface ISmokingAllowed<T> : ISmokingAllowed { new T Value { get; } }
        public class OneOrManySmokingAllowed : OneOrMany<ISmokingAllowed>
        {
            public OneOrManySmokingAllowed(ISmokingAllowed item) : base(item) { }
            public OneOrManySmokingAllowed(IEnumerable<ISmokingAllowed> items) : base(items) { }
            public static implicit operator OneOrManySmokingAllowed (bool value) { return new OneOrManySmokingAllowed (new SmokingAllowedbool (value)); }
            public static implicit operator OneOrManySmokingAllowed (bool[] values) { return new OneOrManySmokingAllowed (values.Select(v => (ISmokingAllowed) new SmokingAllowedbool (v))); }
            public static implicit operator OneOrManySmokingAllowed (List<bool> values) { return new OneOrManySmokingAllowed (values.Select(v => (ISmokingAllowed) new SmokingAllowedbool (v))); }
        }
        public struct SmokingAllowedbool : ISmokingAllowed<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public SmokingAllowedbool (bool value) { Value = value; }
            public static implicit operator SmokingAllowedbool (bool value) { return new SmokingAllowedbool (value); }
        }

        public interface ISpecialOpeningHoursSpecification : IValue {}
        public interface ISpecialOpeningHoursSpecification<T> : ISpecialOpeningHoursSpecification { new T Value { get; } }
        public class OneOrManySpecialOpeningHoursSpecification : OneOrMany<ISpecialOpeningHoursSpecification>
        {
            public OneOrManySpecialOpeningHoursSpecification(ISpecialOpeningHoursSpecification item) : base(item) { }
            public OneOrManySpecialOpeningHoursSpecification(IEnumerable<ISpecialOpeningHoursSpecification> items) : base(items) { }
            public static implicit operator OneOrManySpecialOpeningHoursSpecification (OpeningHoursSpecification value) { return new OneOrManySpecialOpeningHoursSpecification (new SpecialOpeningHoursSpecificationOpeningHoursSpecification (value)); }
            public static implicit operator OneOrManySpecialOpeningHoursSpecification (OpeningHoursSpecification[] values) { return new OneOrManySpecialOpeningHoursSpecification (values.Select(v => (ISpecialOpeningHoursSpecification) new SpecialOpeningHoursSpecificationOpeningHoursSpecification (v))); }
            public static implicit operator OneOrManySpecialOpeningHoursSpecification (List<OpeningHoursSpecification> values) { return new OneOrManySpecialOpeningHoursSpecification (values.Select(v => (ISpecialOpeningHoursSpecification) new SpecialOpeningHoursSpecificationOpeningHoursSpecification (v))); }
        }
        public struct SpecialOpeningHoursSpecificationOpeningHoursSpecification : ISpecialOpeningHoursSpecification<OpeningHoursSpecification>
        {
            object IValue.Value => this.Value;
            public OpeningHoursSpecification Value { get; }
            public SpecialOpeningHoursSpecificationOpeningHoursSpecification (OpeningHoursSpecification value) { Value = value; }
            public static implicit operator SpecialOpeningHoursSpecificationOpeningHoursSpecification (OpeningHoursSpecification value) { return new SpecialOpeningHoursSpecificationOpeningHoursSpecification (value); }
        }

        public interface ITelephone : IValue {}
        public interface ITelephone<T> : ITelephone { new T Value { get; } }
        public class OneOrManyTelephone : OneOrMany<ITelephone>
        {
            public OneOrManyTelephone(ITelephone item) : base(item) { }
            public OneOrManyTelephone(IEnumerable<ITelephone> items) : base(items) { }
            public static implicit operator OneOrManyTelephone (string value) { return new OneOrManyTelephone (new Telephonestring (value)); }
            public static implicit operator OneOrManyTelephone (string[] values) { return new OneOrManyTelephone (values.Select(v => (ITelephone) new Telephonestring (v))); }
            public static implicit operator OneOrManyTelephone (List<string> values) { return new OneOrManyTelephone (values.Select(v => (ITelephone) new Telephonestring (v))); }
        }
        public struct Telephonestring : ITelephone<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Telephonestring (string value) { Value = value; }
            public static implicit operator Telephonestring (string value) { return new Telephonestring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Place";

        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;br/&gt;&lt;br/&gt;
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        [DataMember(Name = "additionalProperty", Order = 106)]
        public OneOrManyAdditionalProperty AdditionalProperty { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 107)]
        public OneOrManyAddress Address { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 108)]
        public OneOrManyAggregateRating AggregateRating { get; set; }

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [DataMember(Name = "amenityFeature", Order = 109)]
        public virtual OneOrManyAmenityFeature AmenityFeature { get; set; }

        /// <summary>
        /// A short textual code (also called "store code") that uniquely identifies a place of business. The code is typically assigned by the parentOrganization and used in structured URLs.&lt;br/&gt;&lt;br/&gt;
        /// For example, in the URL http://www.starbucks.co.uk/store-locator/etc/detail/3047 the code "3047" is a branchCode for a particular branch.
        /// </summary>
        [DataMember(Name = "branchCode", Order = 110)]
        public OneOrManyBranchCode BranchCode { get; set; }

        /// <summary>
        /// The basic containment relation between a place and one that contains it.
        /// </summary>
        [DataMember(Name = "containedInPlace", Order = 111)]
        public OneOrManyContainedInPlace ContainedInPlace { get; set; }

        /// <summary>
        /// The basic containment relation between a place and another that it contains.
        /// </summary>
        [DataMember(Name = "containsPlace", Order = 112)]
        public OneOrManyContainsPlace ContainsPlace { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 113)]
        public OneOrManyEvent Event { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 114)]
        public OneOrManyFaxNumber FaxNumber { get; set; }

        /// <summary>
        /// The geo coordinates of the place.
        /// </summary>
        [DataMember(Name = "geo", Order = 115)]
        public OneOrManyGeo Geo { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a containing geometry to a contained geometry. "a contains b iff no points of b lie in the exterior of a, and at least one point of the interior of b lies in the interior of a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyContains", Order = 116)]
        public OneOrManyGeospatiallyContains GeospatiallyContains { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that covers it. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyCoveredBy", Order = 117)]
        public OneOrManyGeospatiallyCoveredBy GeospatiallyCoveredBy { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a covering geometry to a covered geometry. "Every point of b is a point of (the interior or boundary of) a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyCovers", Order = 118)]
        public OneOrManyGeospatiallyCovers GeospatiallyCovers { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that crosses it: "a crosses b: they have some but not all interior points in common, and the dimension of the intersection is less than that of at least one of them". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyCrosses", Order = 119)]
        public OneOrManyGeospatiallyCrosses GeospatiallyCrosses { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically disjoint: they have no point in common. They form a set of disconnected geometries." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;)
        /// </summary>
        [DataMember(Name = "geospatiallyDisjoint", Order = 120)]
        public OneOrManyGeospatiallyDisjoint GeospatiallyDisjoint { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically equal, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;. "Two geometries are topologically equal if their interiors intersect and no part of the interior or boundary of one geometry intersects the exterior of the other" (a symmetric relationship)
        /// </summary>
        [DataMember(Name = "geospatiallyEquals", Order = 121)]
        public OneOrManyGeospatiallyEquals GeospatiallyEquals { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) have at least one point in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyIntersects", Order = 122)]
        public OneOrManyGeospatiallyIntersects GeospatiallyIntersects { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that geospatially overlaps it, i.e. they have some but not all points in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyOverlaps", Order = 123)]
        public OneOrManyGeospatiallyOverlaps GeospatiallyOverlaps { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) touch: they have at least one boundary point in common, but no interior points." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt; )
        /// </summary>
        [DataMember(Name = "geospatiallyTouches", Order = 124)]
        public OneOrManyGeospatiallyTouches GeospatiallyTouches { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to one that contains it, i.e. it is inside (i.e. within) its interior. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyWithin", Order = 125)]
        public OneOrManyGeospatiallyWithin GeospatiallyWithin { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber", Order = 126)]
        public OneOrManyGlobalLocationNumber GlobalLocationNumber { get; set; }

        /// <summary>
        /// A URL to a map of the place.
        /// </summary>
        [DataMember(Name = "hasMap", Order = 127)]
        public OneOrManyHasMap HasMap { get; set; }

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree", Order = 128)]
        public OneOrManyIsAccessibleForFree IsAccessibleForFree { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4", Order = 129)]
        public OneOrManyIsicV4 IsicV4 { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 130)]
        public OneOrManyLogo Logo { get; set; }

        /// <summary>
        /// The total number of individuals that may attend an event or venue.
        /// </summary>
        [DataMember(Name = "maximumAttendeeCapacity", Order = 131)]
        public OneOrManyMaximumAttendeeCapacity MaximumAttendeeCapacity { get; set; }

        /// <summary>
        /// The opening hours of a certain place.
        /// </summary>
        [DataMember(Name = "openingHoursSpecification", Order = 132)]
        public OneOrManyOpeningHoursSpecification OpeningHoursSpecification { get; set; }

        /// <summary>
        /// A photograph of this place.
        /// </summary>
        [DataMember(Name = "photo", Order = 133)]
        public OneOrManyPhoto Photo { get; set; }

        /// <summary>
        /// A flag to signal that the &lt;a class="localLink" href="http://schema.org/Place"&gt;Place&lt;/a&gt; is open to public visitors.  If this property is omitted there is no assumed default boolean value
        /// </summary>
        [DataMember(Name = "publicAccess", Order = 134)]
        public OneOrManyPublicAccess PublicAccess { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 135)]
        public OneOrManyReview Review { get; set; }

        /// <summary>
        /// Indicates whether it is allowed to smoke in the place, e.g. in the restaurant, hotel or hotel room.
        /// </summary>
        [DataMember(Name = "smokingAllowed", Order = 136)]
        public OneOrManySmokingAllowed SmokingAllowed { get; set; }

        /// <summary>
        /// The special opening hours of a certain place.&lt;br/&gt;&lt;br/&gt;
        /// Use this to explicitly override general opening hours brought in scope by &lt;a class="localLink" href="http://schema.org/openingHoursSpecification"&gt;openingHoursSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/openingHours"&gt;openingHours&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "specialOpeningHoursSpecification", Order = 137)]
        public OneOrManySpecialOpeningHoursSpecification SpecialOpeningHoursSpecification { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 138)]
        public OneOrManyTelephone Telephone { get; set; }
    }
}
