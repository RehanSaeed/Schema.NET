namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// See Organization, Place for more information.
    /// </summary>
    [DataContract]
    public abstract partial class OrganizationAndPlace : Thing
    {
        public interface IActionableFeedbackPolicy : IValue {}
        public interface IActionableFeedbackPolicy<T> : IActionableFeedbackPolicy { new T Value { get; } }
        public class OneOrManyActionableFeedbackPolicy : OneOrMany<IActionableFeedbackPolicy>
        {
            public OneOrManyActionableFeedbackPolicy(IActionableFeedbackPolicy item) : base(item) { }
            public OneOrManyActionableFeedbackPolicy(IEnumerable<IActionableFeedbackPolicy> items) : base(items) { }
            public static implicit operator OneOrManyActionableFeedbackPolicy (CreativeWork value) { return new OneOrManyActionableFeedbackPolicy (new ActionableFeedbackPolicyCreativeWork (value)); }
            public static implicit operator OneOrManyActionableFeedbackPolicy (CreativeWork[] values) { return new OneOrManyActionableFeedbackPolicy (values.Select(v => (IActionableFeedbackPolicy) new ActionableFeedbackPolicyCreativeWork (v))); }
            public static implicit operator OneOrManyActionableFeedbackPolicy (List<CreativeWork> values) { return new OneOrManyActionableFeedbackPolicy (values.Select(v => (IActionableFeedbackPolicy) new ActionableFeedbackPolicyCreativeWork (v))); }
            public static implicit operator OneOrManyActionableFeedbackPolicy (Uri value) { return new OneOrManyActionableFeedbackPolicy (new ActionableFeedbackPolicyUri (value)); }
            public static implicit operator OneOrManyActionableFeedbackPolicy (Uri[] values) { return new OneOrManyActionableFeedbackPolicy (values.Select(v => (IActionableFeedbackPolicy) new ActionableFeedbackPolicyUri (v))); }
            public static implicit operator OneOrManyActionableFeedbackPolicy (List<Uri> values) { return new OneOrManyActionableFeedbackPolicy (values.Select(v => (IActionableFeedbackPolicy) new ActionableFeedbackPolicyUri (v))); }
        }
        public struct ActionableFeedbackPolicyCreativeWork : IActionableFeedbackPolicy<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public ActionableFeedbackPolicyCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator ActionableFeedbackPolicyCreativeWork (CreativeWork value) { return new ActionableFeedbackPolicyCreativeWork (value); }
        }
        public struct ActionableFeedbackPolicyUri : IActionableFeedbackPolicy<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public ActionableFeedbackPolicyUri (Uri value) { Value = value; }
            public static implicit operator ActionableFeedbackPolicyUri (Uri value) { return new ActionableFeedbackPolicyUri (value); }
        }

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

        public interface IAlumni : IValue {}
        public interface IAlumni<T> : IAlumni { new T Value { get; } }
        public class OneOrManyAlumni : OneOrMany<IAlumni>
        {
            public OneOrManyAlumni(IAlumni item) : base(item) { }
            public OneOrManyAlumni(IEnumerable<IAlumni> items) : base(items) { }
            public static implicit operator OneOrManyAlumni (Person value) { return new OneOrManyAlumni (new AlumniPerson (value)); }
            public static implicit operator OneOrManyAlumni (Person[] values) { return new OneOrManyAlumni (values.Select(v => (IAlumni) new AlumniPerson (v))); }
            public static implicit operator OneOrManyAlumni (List<Person> values) { return new OneOrManyAlumni (values.Select(v => (IAlumni) new AlumniPerson (v))); }
        }
        public struct AlumniPerson : IAlumni<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public AlumniPerson (Person value) { Value = value; }
            public static implicit operator AlumniPerson (Person value) { return new AlumniPerson (value); }
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

        public interface IAward : IValue {}
        public interface IAward<T> : IAward { new T Value { get; } }
        public class OneOrManyAward : OneOrMany<IAward>
        {
            public OneOrManyAward(IAward item) : base(item) { }
            public OneOrManyAward(IEnumerable<IAward> items) : base(items) { }
            public static implicit operator OneOrManyAward (string value) { return new OneOrManyAward (new Awardstring (value)); }
            public static implicit operator OneOrManyAward (string[] values) { return new OneOrManyAward (values.Select(v => (IAward) new Awardstring (v))); }
            public static implicit operator OneOrManyAward (List<string> values) { return new OneOrManyAward (values.Select(v => (IAward) new Awardstring (v))); }
        }
        public struct Awardstring : IAward<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Awardstring (string value) { Value = value; }
            public static implicit operator Awardstring (string value) { return new Awardstring (value); }
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

        public interface IBrand : IValue {}
        public interface IBrand<T> : IBrand { new T Value { get; } }
        public class OneOrManyBrand : OneOrMany<IBrand>
        {
            public OneOrManyBrand(IBrand item) : base(item) { }
            public OneOrManyBrand(IEnumerable<IBrand> items) : base(items) { }
            public static implicit operator OneOrManyBrand (Brand value) { return new OneOrManyBrand (new BrandBrand (value)); }
            public static implicit operator OneOrManyBrand (Brand[] values) { return new OneOrManyBrand (values.Select(v => (IBrand) new BrandBrand (v))); }
            public static implicit operator OneOrManyBrand (List<Brand> values) { return new OneOrManyBrand (values.Select(v => (IBrand) new BrandBrand (v))); }
            public static implicit operator OneOrManyBrand (Organization value) { return new OneOrManyBrand (new BrandOrganization (value)); }
            public static implicit operator OneOrManyBrand (Organization[] values) { return new OneOrManyBrand (values.Select(v => (IBrand) new BrandOrganization (v))); }
            public static implicit operator OneOrManyBrand (List<Organization> values) { return new OneOrManyBrand (values.Select(v => (IBrand) new BrandOrganization (v))); }
        }
        public struct BrandBrand : IBrand<Brand>
        {
            object IValue.Value => this.Value;
            public Brand Value { get; }
            public BrandBrand (Brand value) { Value = value; }
            public static implicit operator BrandBrand (Brand value) { return new BrandBrand (value); }
        }
        public struct BrandOrganization : IBrand<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public BrandOrganization (Organization value) { Value = value; }
            public static implicit operator BrandOrganization (Organization value) { return new BrandOrganization (value); }
        }

        public interface IContactPoint : IValue {}
        public interface IContactPoint<T> : IContactPoint { new T Value { get; } }
        public class OneOrManyContactPoint : OneOrMany<IContactPoint>
        {
            public OneOrManyContactPoint(IContactPoint item) : base(item) { }
            public OneOrManyContactPoint(IEnumerable<IContactPoint> items) : base(items) { }
            public static implicit operator OneOrManyContactPoint (ContactPoint value) { return new OneOrManyContactPoint (new ContactPointContactPoint (value)); }
            public static implicit operator OneOrManyContactPoint (ContactPoint[] values) { return new OneOrManyContactPoint (values.Select(v => (IContactPoint) new ContactPointContactPoint (v))); }
            public static implicit operator OneOrManyContactPoint (List<ContactPoint> values) { return new OneOrManyContactPoint (values.Select(v => (IContactPoint) new ContactPointContactPoint (v))); }
        }
        public struct ContactPointContactPoint : IContactPoint<ContactPoint>
        {
            object IValue.Value => this.Value;
            public ContactPoint Value { get; }
            public ContactPointContactPoint (ContactPoint value) { Value = value; }
            public static implicit operator ContactPointContactPoint (ContactPoint value) { return new ContactPointContactPoint (value); }
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

        public interface ICorrectionsPolicy : IValue {}
        public interface ICorrectionsPolicy<T> : ICorrectionsPolicy { new T Value { get; } }
        public class OneOrManyCorrectionsPolicy : OneOrMany<ICorrectionsPolicy>
        {
            public OneOrManyCorrectionsPolicy(ICorrectionsPolicy item) : base(item) { }
            public OneOrManyCorrectionsPolicy(IEnumerable<ICorrectionsPolicy> items) : base(items) { }
            public static implicit operator OneOrManyCorrectionsPolicy (CreativeWork value) { return new OneOrManyCorrectionsPolicy (new CorrectionsPolicyCreativeWork (value)); }
            public static implicit operator OneOrManyCorrectionsPolicy (CreativeWork[] values) { return new OneOrManyCorrectionsPolicy (values.Select(v => (ICorrectionsPolicy) new CorrectionsPolicyCreativeWork (v))); }
            public static implicit operator OneOrManyCorrectionsPolicy (List<CreativeWork> values) { return new OneOrManyCorrectionsPolicy (values.Select(v => (ICorrectionsPolicy) new CorrectionsPolicyCreativeWork (v))); }
            public static implicit operator OneOrManyCorrectionsPolicy (Uri value) { return new OneOrManyCorrectionsPolicy (new CorrectionsPolicyUri (value)); }
            public static implicit operator OneOrManyCorrectionsPolicy (Uri[] values) { return new OneOrManyCorrectionsPolicy (values.Select(v => (ICorrectionsPolicy) new CorrectionsPolicyUri (v))); }
            public static implicit operator OneOrManyCorrectionsPolicy (List<Uri> values) { return new OneOrManyCorrectionsPolicy (values.Select(v => (ICorrectionsPolicy) new CorrectionsPolicyUri (v))); }
        }
        public struct CorrectionsPolicyCreativeWork : ICorrectionsPolicy<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public CorrectionsPolicyCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator CorrectionsPolicyCreativeWork (CreativeWork value) { return new CorrectionsPolicyCreativeWork (value); }
        }
        public struct CorrectionsPolicyUri : ICorrectionsPolicy<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public CorrectionsPolicyUri (Uri value) { Value = value; }
            public static implicit operator CorrectionsPolicyUri (Uri value) { return new CorrectionsPolicyUri (value); }
        }

        public interface IDepartment : IValue {}
        public interface IDepartment<T> : IDepartment { new T Value { get; } }
        public class OneOrManyDepartment : OneOrMany<IDepartment>
        {
            public OneOrManyDepartment(IDepartment item) : base(item) { }
            public OneOrManyDepartment(IEnumerable<IDepartment> items) : base(items) { }
            public static implicit operator OneOrManyDepartment (Organization value) { return new OneOrManyDepartment (new DepartmentOrganization (value)); }
            public static implicit operator OneOrManyDepartment (Organization[] values) { return new OneOrManyDepartment (values.Select(v => (IDepartment) new DepartmentOrganization (v))); }
            public static implicit operator OneOrManyDepartment (List<Organization> values) { return new OneOrManyDepartment (values.Select(v => (IDepartment) new DepartmentOrganization (v))); }
        }
        public struct DepartmentOrganization : IDepartment<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public DepartmentOrganization (Organization value) { Value = value; }
            public static implicit operator DepartmentOrganization (Organization value) { return new DepartmentOrganization (value); }
        }

        public interface IDissolutionDate : IValue {}
        public interface IDissolutionDate<T> : IDissolutionDate { new T Value { get; } }
        public class OneOrManyDissolutionDate : OneOrMany<IDissolutionDate>
        {
            public OneOrManyDissolutionDate(IDissolutionDate item) : base(item) { }
            public OneOrManyDissolutionDate(IEnumerable<IDissolutionDate> items) : base(items) { }
            public static implicit operator OneOrManyDissolutionDate (DateTimeOffset value) { return new OneOrManyDissolutionDate (new DissolutionDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyDissolutionDate (DateTimeOffset[] values) { return new OneOrManyDissolutionDate (values.Select(v => (IDissolutionDate) new DissolutionDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyDissolutionDate (List<DateTimeOffset> values) { return new OneOrManyDissolutionDate (values.Select(v => (IDissolutionDate) new DissolutionDateDateTimeOffset (v))); }
        }
        public struct DissolutionDateDateTimeOffset : IDissolutionDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public DissolutionDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator DissolutionDateDateTimeOffset (DateTimeOffset value) { return new DissolutionDateDateTimeOffset (value); }
        }

        public interface IDiversityPolicy : IValue {}
        public interface IDiversityPolicy<T> : IDiversityPolicy { new T Value { get; } }
        public class OneOrManyDiversityPolicy : OneOrMany<IDiversityPolicy>
        {
            public OneOrManyDiversityPolicy(IDiversityPolicy item) : base(item) { }
            public OneOrManyDiversityPolicy(IEnumerable<IDiversityPolicy> items) : base(items) { }
            public static implicit operator OneOrManyDiversityPolicy (CreativeWork value) { return new OneOrManyDiversityPolicy (new DiversityPolicyCreativeWork (value)); }
            public static implicit operator OneOrManyDiversityPolicy (CreativeWork[] values) { return new OneOrManyDiversityPolicy (values.Select(v => (IDiversityPolicy) new DiversityPolicyCreativeWork (v))); }
            public static implicit operator OneOrManyDiversityPolicy (List<CreativeWork> values) { return new OneOrManyDiversityPolicy (values.Select(v => (IDiversityPolicy) new DiversityPolicyCreativeWork (v))); }
            public static implicit operator OneOrManyDiversityPolicy (Uri value) { return new OneOrManyDiversityPolicy (new DiversityPolicyUri (value)); }
            public static implicit operator OneOrManyDiversityPolicy (Uri[] values) { return new OneOrManyDiversityPolicy (values.Select(v => (IDiversityPolicy) new DiversityPolicyUri (v))); }
            public static implicit operator OneOrManyDiversityPolicy (List<Uri> values) { return new OneOrManyDiversityPolicy (values.Select(v => (IDiversityPolicy) new DiversityPolicyUri (v))); }
        }
        public struct DiversityPolicyCreativeWork : IDiversityPolicy<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public DiversityPolicyCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator DiversityPolicyCreativeWork (CreativeWork value) { return new DiversityPolicyCreativeWork (value); }
        }
        public struct DiversityPolicyUri : IDiversityPolicy<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public DiversityPolicyUri (Uri value) { Value = value; }
            public static implicit operator DiversityPolicyUri (Uri value) { return new DiversityPolicyUri (value); }
        }

        public interface IDiversityStaffingReport : IValue {}
        public interface IDiversityStaffingReport<T> : IDiversityStaffingReport { new T Value { get; } }
        public class OneOrManyDiversityStaffingReport : OneOrMany<IDiversityStaffingReport>
        {
            public OneOrManyDiversityStaffingReport(IDiversityStaffingReport item) : base(item) { }
            public OneOrManyDiversityStaffingReport(IEnumerable<IDiversityStaffingReport> items) : base(items) { }
            public static implicit operator OneOrManyDiversityStaffingReport (Article value) { return new OneOrManyDiversityStaffingReport (new DiversityStaffingReportArticle (value)); }
            public static implicit operator OneOrManyDiversityStaffingReport (Article[] values) { return new OneOrManyDiversityStaffingReport (values.Select(v => (IDiversityStaffingReport) new DiversityStaffingReportArticle (v))); }
            public static implicit operator OneOrManyDiversityStaffingReport (List<Article> values) { return new OneOrManyDiversityStaffingReport (values.Select(v => (IDiversityStaffingReport) new DiversityStaffingReportArticle (v))); }
            public static implicit operator OneOrManyDiversityStaffingReport (Uri value) { return new OneOrManyDiversityStaffingReport (new DiversityStaffingReportUri (value)); }
            public static implicit operator OneOrManyDiversityStaffingReport (Uri[] values) { return new OneOrManyDiversityStaffingReport (values.Select(v => (IDiversityStaffingReport) new DiversityStaffingReportUri (v))); }
            public static implicit operator OneOrManyDiversityStaffingReport (List<Uri> values) { return new OneOrManyDiversityStaffingReport (values.Select(v => (IDiversityStaffingReport) new DiversityStaffingReportUri (v))); }
        }
        public struct DiversityStaffingReportArticle : IDiversityStaffingReport<Article>
        {
            object IValue.Value => this.Value;
            public Article Value { get; }
            public DiversityStaffingReportArticle (Article value) { Value = value; }
            public static implicit operator DiversityStaffingReportArticle (Article value) { return new DiversityStaffingReportArticle (value); }
        }
        public struct DiversityStaffingReportUri : IDiversityStaffingReport<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public DiversityStaffingReportUri (Uri value) { Value = value; }
            public static implicit operator DiversityStaffingReportUri (Uri value) { return new DiversityStaffingReportUri (value); }
        }

        public interface IDuns : IValue {}
        public interface IDuns<T> : IDuns { new T Value { get; } }
        public class OneOrManyDuns : OneOrMany<IDuns>
        {
            public OneOrManyDuns(IDuns item) : base(item) { }
            public OneOrManyDuns(IEnumerable<IDuns> items) : base(items) { }
            public static implicit operator OneOrManyDuns (string value) { return new OneOrManyDuns (new Dunsstring (value)); }
            public static implicit operator OneOrManyDuns (string[] values) { return new OneOrManyDuns (values.Select(v => (IDuns) new Dunsstring (v))); }
            public static implicit operator OneOrManyDuns (List<string> values) { return new OneOrManyDuns (values.Select(v => (IDuns) new Dunsstring (v))); }
        }
        public struct Dunsstring : IDuns<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Dunsstring (string value) { Value = value; }
            public static implicit operator Dunsstring (string value) { return new Dunsstring (value); }
        }

        public interface IEmail : IValue {}
        public interface IEmail<T> : IEmail { new T Value { get; } }
        public class OneOrManyEmail : OneOrMany<IEmail>
        {
            public OneOrManyEmail(IEmail item) : base(item) { }
            public OneOrManyEmail(IEnumerable<IEmail> items) : base(items) { }
            public static implicit operator OneOrManyEmail (string value) { return new OneOrManyEmail (new Emailstring (value)); }
            public static implicit operator OneOrManyEmail (string[] values) { return new OneOrManyEmail (values.Select(v => (IEmail) new Emailstring (v))); }
            public static implicit operator OneOrManyEmail (List<string> values) { return new OneOrManyEmail (values.Select(v => (IEmail) new Emailstring (v))); }
        }
        public struct Emailstring : IEmail<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Emailstring (string value) { Value = value; }
            public static implicit operator Emailstring (string value) { return new Emailstring (value); }
        }

        public interface IEmployee : IValue {}
        public interface IEmployee<T> : IEmployee { new T Value { get; } }
        public class OneOrManyEmployee : OneOrMany<IEmployee>
        {
            public OneOrManyEmployee(IEmployee item) : base(item) { }
            public OneOrManyEmployee(IEnumerable<IEmployee> items) : base(items) { }
            public static implicit operator OneOrManyEmployee (Person value) { return new OneOrManyEmployee (new EmployeePerson (value)); }
            public static implicit operator OneOrManyEmployee (Person[] values) { return new OneOrManyEmployee (values.Select(v => (IEmployee) new EmployeePerson (v))); }
            public static implicit operator OneOrManyEmployee (List<Person> values) { return new OneOrManyEmployee (values.Select(v => (IEmployee) new EmployeePerson (v))); }
        }
        public struct EmployeePerson : IEmployee<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public EmployeePerson (Person value) { Value = value; }
            public static implicit operator EmployeePerson (Person value) { return new EmployeePerson (value); }
        }

        public interface IEthicsPolicy : IValue {}
        public interface IEthicsPolicy<T> : IEthicsPolicy { new T Value { get; } }
        public class OneOrManyEthicsPolicy : OneOrMany<IEthicsPolicy>
        {
            public OneOrManyEthicsPolicy(IEthicsPolicy item) : base(item) { }
            public OneOrManyEthicsPolicy(IEnumerable<IEthicsPolicy> items) : base(items) { }
            public static implicit operator OneOrManyEthicsPolicy (CreativeWork value) { return new OneOrManyEthicsPolicy (new EthicsPolicyCreativeWork (value)); }
            public static implicit operator OneOrManyEthicsPolicy (CreativeWork[] values) { return new OneOrManyEthicsPolicy (values.Select(v => (IEthicsPolicy) new EthicsPolicyCreativeWork (v))); }
            public static implicit operator OneOrManyEthicsPolicy (List<CreativeWork> values) { return new OneOrManyEthicsPolicy (values.Select(v => (IEthicsPolicy) new EthicsPolicyCreativeWork (v))); }
            public static implicit operator OneOrManyEthicsPolicy (Uri value) { return new OneOrManyEthicsPolicy (new EthicsPolicyUri (value)); }
            public static implicit operator OneOrManyEthicsPolicy (Uri[] values) { return new OneOrManyEthicsPolicy (values.Select(v => (IEthicsPolicy) new EthicsPolicyUri (v))); }
            public static implicit operator OneOrManyEthicsPolicy (List<Uri> values) { return new OneOrManyEthicsPolicy (values.Select(v => (IEthicsPolicy) new EthicsPolicyUri (v))); }
        }
        public struct EthicsPolicyCreativeWork : IEthicsPolicy<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public EthicsPolicyCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator EthicsPolicyCreativeWork (CreativeWork value) { return new EthicsPolicyCreativeWork (value); }
        }
        public struct EthicsPolicyUri : IEthicsPolicy<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public EthicsPolicyUri (Uri value) { Value = value; }
            public static implicit operator EthicsPolicyUri (Uri value) { return new EthicsPolicyUri (value); }
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

        public interface IFounder : IValue {}
        public interface IFounder<T> : IFounder { new T Value { get; } }
        public class OneOrManyFounder : OneOrMany<IFounder>
        {
            public OneOrManyFounder(IFounder item) : base(item) { }
            public OneOrManyFounder(IEnumerable<IFounder> items) : base(items) { }
            public static implicit operator OneOrManyFounder (Person value) { return new OneOrManyFounder (new FounderPerson (value)); }
            public static implicit operator OneOrManyFounder (Person[] values) { return new OneOrManyFounder (values.Select(v => (IFounder) new FounderPerson (v))); }
            public static implicit operator OneOrManyFounder (List<Person> values) { return new OneOrManyFounder (values.Select(v => (IFounder) new FounderPerson (v))); }
        }
        public struct FounderPerson : IFounder<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public FounderPerson (Person value) { Value = value; }
            public static implicit operator FounderPerson (Person value) { return new FounderPerson (value); }
        }

        public interface IFoundingDate : IValue {}
        public interface IFoundingDate<T> : IFoundingDate { new T Value { get; } }
        public class OneOrManyFoundingDate : OneOrMany<IFoundingDate>
        {
            public OneOrManyFoundingDate(IFoundingDate item) : base(item) { }
            public OneOrManyFoundingDate(IEnumerable<IFoundingDate> items) : base(items) { }
            public static implicit operator OneOrManyFoundingDate (DateTimeOffset value) { return new OneOrManyFoundingDate (new FoundingDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyFoundingDate (DateTimeOffset[] values) { return new OneOrManyFoundingDate (values.Select(v => (IFoundingDate) new FoundingDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyFoundingDate (List<DateTimeOffset> values) { return new OneOrManyFoundingDate (values.Select(v => (IFoundingDate) new FoundingDateDateTimeOffset (v))); }
        }
        public struct FoundingDateDateTimeOffset : IFoundingDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public FoundingDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator FoundingDateDateTimeOffset (DateTimeOffset value) { return new FoundingDateDateTimeOffset (value); }
        }

        public interface IFoundingLocation : IValue {}
        public interface IFoundingLocation<T> : IFoundingLocation { new T Value { get; } }
        public class OneOrManyFoundingLocation : OneOrMany<IFoundingLocation>
        {
            public OneOrManyFoundingLocation(IFoundingLocation item) : base(item) { }
            public OneOrManyFoundingLocation(IEnumerable<IFoundingLocation> items) : base(items) { }
            public static implicit operator OneOrManyFoundingLocation (Place value) { return new OneOrManyFoundingLocation (new FoundingLocationPlace (value)); }
            public static implicit operator OneOrManyFoundingLocation (Place[] values) { return new OneOrManyFoundingLocation (values.Select(v => (IFoundingLocation) new FoundingLocationPlace (v))); }
            public static implicit operator OneOrManyFoundingLocation (List<Place> values) { return new OneOrManyFoundingLocation (values.Select(v => (IFoundingLocation) new FoundingLocationPlace (v))); }
        }
        public struct FoundingLocationPlace : IFoundingLocation<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public FoundingLocationPlace (Place value) { Value = value; }
            public static implicit operator FoundingLocationPlace (Place value) { return new FoundingLocationPlace (value); }
        }

        public interface IFunder : IValue {}
        public interface IFunder<T> : IFunder { new T Value { get; } }
        public class OneOrManyFunder : OneOrMany<IFunder>
        {
            public OneOrManyFunder(IFunder item) : base(item) { }
            public OneOrManyFunder(IEnumerable<IFunder> items) : base(items) { }
            public static implicit operator OneOrManyFunder (Organization value) { return new OneOrManyFunder (new FunderOrganization (value)); }
            public static implicit operator OneOrManyFunder (Organization[] values) { return new OneOrManyFunder (values.Select(v => (IFunder) new FunderOrganization (v))); }
            public static implicit operator OneOrManyFunder (List<Organization> values) { return new OneOrManyFunder (values.Select(v => (IFunder) new FunderOrganization (v))); }
            public static implicit operator OneOrManyFunder (Person value) { return new OneOrManyFunder (new FunderPerson (value)); }
            public static implicit operator OneOrManyFunder (Person[] values) { return new OneOrManyFunder (values.Select(v => (IFunder) new FunderPerson (v))); }
            public static implicit operator OneOrManyFunder (List<Person> values) { return new OneOrManyFunder (values.Select(v => (IFunder) new FunderPerson (v))); }
        }
        public struct FunderOrganization : IFunder<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public FunderOrganization (Organization value) { Value = value; }
            public static implicit operator FunderOrganization (Organization value) { return new FunderOrganization (value); }
        }
        public struct FunderPerson : IFunder<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public FunderPerson (Person value) { Value = value; }
            public static implicit operator FunderPerson (Person value) { return new FunderPerson (value); }
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

        public interface IHasOfferCatalog : IValue {}
        public interface IHasOfferCatalog<T> : IHasOfferCatalog { new T Value { get; } }
        public class OneOrManyHasOfferCatalog : OneOrMany<IHasOfferCatalog>
        {
            public OneOrManyHasOfferCatalog(IHasOfferCatalog item) : base(item) { }
            public OneOrManyHasOfferCatalog(IEnumerable<IHasOfferCatalog> items) : base(items) { }
            public static implicit operator OneOrManyHasOfferCatalog (OfferCatalog value) { return new OneOrManyHasOfferCatalog (new HasOfferCatalogOfferCatalog (value)); }
            public static implicit operator OneOrManyHasOfferCatalog (OfferCatalog[] values) { return new OneOrManyHasOfferCatalog (values.Select(v => (IHasOfferCatalog) new HasOfferCatalogOfferCatalog (v))); }
            public static implicit operator OneOrManyHasOfferCatalog (List<OfferCatalog> values) { return new OneOrManyHasOfferCatalog (values.Select(v => (IHasOfferCatalog) new HasOfferCatalogOfferCatalog (v))); }
        }
        public struct HasOfferCatalogOfferCatalog : IHasOfferCatalog<OfferCatalog>
        {
            object IValue.Value => this.Value;
            public OfferCatalog Value { get; }
            public HasOfferCatalogOfferCatalog (OfferCatalog value) { Value = value; }
            public static implicit operator HasOfferCatalogOfferCatalog (OfferCatalog value) { return new HasOfferCatalogOfferCatalog (value); }
        }

        public interface IHasPOS : IValue {}
        public interface IHasPOS<T> : IHasPOS { new T Value { get; } }
        public class OneOrManyHasPOS : OneOrMany<IHasPOS>
        {
            public OneOrManyHasPOS(IHasPOS item) : base(item) { }
            public OneOrManyHasPOS(IEnumerable<IHasPOS> items) : base(items) { }
            public static implicit operator OneOrManyHasPOS (Place value) { return new OneOrManyHasPOS (new HasPOSPlace (value)); }
            public static implicit operator OneOrManyHasPOS (Place[] values) { return new OneOrManyHasPOS (values.Select(v => (IHasPOS) new HasPOSPlace (v))); }
            public static implicit operator OneOrManyHasPOS (List<Place> values) { return new OneOrManyHasPOS (values.Select(v => (IHasPOS) new HasPOSPlace (v))); }
        }
        public struct HasPOSPlace : IHasPOS<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public HasPOSPlace (Place value) { Value = value; }
            public static implicit operator HasPOSPlace (Place value) { return new HasPOSPlace (value); }
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

        public interface IKnowsAbout : IValue {}
        public interface IKnowsAbout<T> : IKnowsAbout { new T Value { get; } }
        public class OneOrManyKnowsAbout : OneOrMany<IKnowsAbout>
        {
            public OneOrManyKnowsAbout(IKnowsAbout item) : base(item) { }
            public OneOrManyKnowsAbout(IEnumerable<IKnowsAbout> items) : base(items) { }
            public static implicit operator OneOrManyKnowsAbout (string value) { return new OneOrManyKnowsAbout (new KnowsAboutstring (value)); }
            public static implicit operator OneOrManyKnowsAbout (string[] values) { return new OneOrManyKnowsAbout (values.Select(v => (IKnowsAbout) new KnowsAboutstring (v))); }
            public static implicit operator OneOrManyKnowsAbout (List<string> values) { return new OneOrManyKnowsAbout (values.Select(v => (IKnowsAbout) new KnowsAboutstring (v))); }
            public static implicit operator OneOrManyKnowsAbout (Thing value) { return new OneOrManyKnowsAbout (new KnowsAboutThing (value)); }
            public static implicit operator OneOrManyKnowsAbout (Thing[] values) { return new OneOrManyKnowsAbout (values.Select(v => (IKnowsAbout) new KnowsAboutThing (v))); }
            public static implicit operator OneOrManyKnowsAbout (List<Thing> values) { return new OneOrManyKnowsAbout (values.Select(v => (IKnowsAbout) new KnowsAboutThing (v))); }
            public static implicit operator OneOrManyKnowsAbout (Uri value) { return new OneOrManyKnowsAbout (new KnowsAboutUri (value)); }
            public static implicit operator OneOrManyKnowsAbout (Uri[] values) { return new OneOrManyKnowsAbout (values.Select(v => (IKnowsAbout) new KnowsAboutUri (v))); }
            public static implicit operator OneOrManyKnowsAbout (List<Uri> values) { return new OneOrManyKnowsAbout (values.Select(v => (IKnowsAbout) new KnowsAboutUri (v))); }
        }
        public struct KnowsAboutstring : IKnowsAbout<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public KnowsAboutstring (string value) { Value = value; }
            public static implicit operator KnowsAboutstring (string value) { return new KnowsAboutstring (value); }
        }
        public struct KnowsAboutThing : IKnowsAbout<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public KnowsAboutThing (Thing value) { Value = value; }
            public static implicit operator KnowsAboutThing (Thing value) { return new KnowsAboutThing (value); }
        }
        public struct KnowsAboutUri : IKnowsAbout<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public KnowsAboutUri (Uri value) { Value = value; }
            public static implicit operator KnowsAboutUri (Uri value) { return new KnowsAboutUri (value); }
        }

        public interface IKnowsLanguage : IValue {}
        public interface IKnowsLanguage<T> : IKnowsLanguage { new T Value { get; } }
        public class OneOrManyKnowsLanguage : OneOrMany<IKnowsLanguage>
        {
            public OneOrManyKnowsLanguage(IKnowsLanguage item) : base(item) { }
            public OneOrManyKnowsLanguage(IEnumerable<IKnowsLanguage> items) : base(items) { }
            public static implicit operator OneOrManyKnowsLanguage (Language value) { return new OneOrManyKnowsLanguage (new KnowsLanguageLanguage (value)); }
            public static implicit operator OneOrManyKnowsLanguage (Language[] values) { return new OneOrManyKnowsLanguage (values.Select(v => (IKnowsLanguage) new KnowsLanguageLanguage (v))); }
            public static implicit operator OneOrManyKnowsLanguage (List<Language> values) { return new OneOrManyKnowsLanguage (values.Select(v => (IKnowsLanguage) new KnowsLanguageLanguage (v))); }
            public static implicit operator OneOrManyKnowsLanguage (string value) { return new OneOrManyKnowsLanguage (new KnowsLanguagestring (value)); }
            public static implicit operator OneOrManyKnowsLanguage (string[] values) { return new OneOrManyKnowsLanguage (values.Select(v => (IKnowsLanguage) new KnowsLanguagestring (v))); }
            public static implicit operator OneOrManyKnowsLanguage (List<string> values) { return new OneOrManyKnowsLanguage (values.Select(v => (IKnowsLanguage) new KnowsLanguagestring (v))); }
        }
        public struct KnowsLanguageLanguage : IKnowsLanguage<Language>
        {
            object IValue.Value => this.Value;
            public Language Value { get; }
            public KnowsLanguageLanguage (Language value) { Value = value; }
            public static implicit operator KnowsLanguageLanguage (Language value) { return new KnowsLanguageLanguage (value); }
        }
        public struct KnowsLanguagestring : IKnowsLanguage<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public KnowsLanguagestring (string value) { Value = value; }
            public static implicit operator KnowsLanguagestring (string value) { return new KnowsLanguagestring (value); }
        }

        public interface ILegalName : IValue {}
        public interface ILegalName<T> : ILegalName { new T Value { get; } }
        public class OneOrManyLegalName : OneOrMany<ILegalName>
        {
            public OneOrManyLegalName(ILegalName item) : base(item) { }
            public OneOrManyLegalName(IEnumerable<ILegalName> items) : base(items) { }
            public static implicit operator OneOrManyLegalName (string value) { return new OneOrManyLegalName (new LegalNamestring (value)); }
            public static implicit operator OneOrManyLegalName (string[] values) { return new OneOrManyLegalName (values.Select(v => (ILegalName) new LegalNamestring (v))); }
            public static implicit operator OneOrManyLegalName (List<string> values) { return new OneOrManyLegalName (values.Select(v => (ILegalName) new LegalNamestring (v))); }
        }
        public struct LegalNamestring : ILegalName<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public LegalNamestring (string value) { Value = value; }
            public static implicit operator LegalNamestring (string value) { return new LegalNamestring (value); }
        }

        public interface ILeiCode : IValue {}
        public interface ILeiCode<T> : ILeiCode { new T Value { get; } }
        public class OneOrManyLeiCode : OneOrMany<ILeiCode>
        {
            public OneOrManyLeiCode(ILeiCode item) : base(item) { }
            public OneOrManyLeiCode(IEnumerable<ILeiCode> items) : base(items) { }
            public static implicit operator OneOrManyLeiCode (string value) { return new OneOrManyLeiCode (new LeiCodestring (value)); }
            public static implicit operator OneOrManyLeiCode (string[] values) { return new OneOrManyLeiCode (values.Select(v => (ILeiCode) new LeiCodestring (v))); }
            public static implicit operator OneOrManyLeiCode (List<string> values) { return new OneOrManyLeiCode (values.Select(v => (ILeiCode) new LeiCodestring (v))); }
        }
        public struct LeiCodestring : ILeiCode<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public LeiCodestring (string value) { Value = value; }
            public static implicit operator LeiCodestring (string value) { return new LeiCodestring (value); }
        }

        public interface ILocation : IValue {}
        public interface ILocation<T> : ILocation { new T Value { get; } }
        public class OneOrManyLocation : OneOrMany<ILocation>
        {
            public OneOrManyLocation(ILocation item) : base(item) { }
            public OneOrManyLocation(IEnumerable<ILocation> items) : base(items) { }
            public static implicit operator OneOrManyLocation (Place value) { return new OneOrManyLocation (new LocationPlace (value)); }
            public static implicit operator OneOrManyLocation (Place[] values) { return new OneOrManyLocation (values.Select(v => (ILocation) new LocationPlace (v))); }
            public static implicit operator OneOrManyLocation (List<Place> values) { return new OneOrManyLocation (values.Select(v => (ILocation) new LocationPlace (v))); }
            public static implicit operator OneOrManyLocation (PostalAddress value) { return new OneOrManyLocation (new LocationPostalAddress (value)); }
            public static implicit operator OneOrManyLocation (PostalAddress[] values) { return new OneOrManyLocation (values.Select(v => (ILocation) new LocationPostalAddress (v))); }
            public static implicit operator OneOrManyLocation (List<PostalAddress> values) { return new OneOrManyLocation (values.Select(v => (ILocation) new LocationPostalAddress (v))); }
            public static implicit operator OneOrManyLocation (string value) { return new OneOrManyLocation (new Locationstring (value)); }
            public static implicit operator OneOrManyLocation (string[] values) { return new OneOrManyLocation (values.Select(v => (ILocation) new Locationstring (v))); }
            public static implicit operator OneOrManyLocation (List<string> values) { return new OneOrManyLocation (values.Select(v => (ILocation) new Locationstring (v))); }
        }
        public struct LocationPlace : ILocation<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public LocationPlace (Place value) { Value = value; }
            public static implicit operator LocationPlace (Place value) { return new LocationPlace (value); }
        }
        public struct LocationPostalAddress : ILocation<PostalAddress>
        {
            object IValue.Value => this.Value;
            public PostalAddress Value { get; }
            public LocationPostalAddress (PostalAddress value) { Value = value; }
            public static implicit operator LocationPostalAddress (PostalAddress value) { return new LocationPostalAddress (value); }
        }
        public struct Locationstring : ILocation<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Locationstring (string value) { Value = value; }
            public static implicit operator Locationstring (string value) { return new Locationstring (value); }
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

        public interface IMakesOffer : IValue {}
        public interface IMakesOffer<T> : IMakesOffer { new T Value { get; } }
        public class OneOrManyMakesOffer : OneOrMany<IMakesOffer>
        {
            public OneOrManyMakesOffer(IMakesOffer item) : base(item) { }
            public OneOrManyMakesOffer(IEnumerable<IMakesOffer> items) : base(items) { }
            public static implicit operator OneOrManyMakesOffer (Offer value) { return new OneOrManyMakesOffer (new MakesOfferOffer (value)); }
            public static implicit operator OneOrManyMakesOffer (Offer[] values) { return new OneOrManyMakesOffer (values.Select(v => (IMakesOffer) new MakesOfferOffer (v))); }
            public static implicit operator OneOrManyMakesOffer (List<Offer> values) { return new OneOrManyMakesOffer (values.Select(v => (IMakesOffer) new MakesOfferOffer (v))); }
        }
        public struct MakesOfferOffer : IMakesOffer<Offer>
        {
            object IValue.Value => this.Value;
            public Offer Value { get; }
            public MakesOfferOffer (Offer value) { Value = value; }
            public static implicit operator MakesOfferOffer (Offer value) { return new MakesOfferOffer (value); }
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

        public interface IMember : IValue {}
        public interface IMember<T> : IMember { new T Value { get; } }
        public class OneOrManyMember : OneOrMany<IMember>
        {
            public OneOrManyMember(IMember item) : base(item) { }
            public OneOrManyMember(IEnumerable<IMember> items) : base(items) { }
            public static implicit operator OneOrManyMember (Organization value) { return new OneOrManyMember (new MemberOrganization (value)); }
            public static implicit operator OneOrManyMember (Organization[] values) { return new OneOrManyMember (values.Select(v => (IMember) new MemberOrganization (v))); }
            public static implicit operator OneOrManyMember (List<Organization> values) { return new OneOrManyMember (values.Select(v => (IMember) new MemberOrganization (v))); }
            public static implicit operator OneOrManyMember (Person value) { return new OneOrManyMember (new MemberPerson (value)); }
            public static implicit operator OneOrManyMember (Person[] values) { return new OneOrManyMember (values.Select(v => (IMember) new MemberPerson (v))); }
            public static implicit operator OneOrManyMember (List<Person> values) { return new OneOrManyMember (values.Select(v => (IMember) new MemberPerson (v))); }
        }
        public struct MemberOrganization : IMember<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public MemberOrganization (Organization value) { Value = value; }
            public static implicit operator MemberOrganization (Organization value) { return new MemberOrganization (value); }
        }
        public struct MemberPerson : IMember<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public MemberPerson (Person value) { Value = value; }
            public static implicit operator MemberPerson (Person value) { return new MemberPerson (value); }
        }

        public interface IMemberOf : IValue {}
        public interface IMemberOf<T> : IMemberOf { new T Value { get; } }
        public class OneOrManyMemberOf : OneOrMany<IMemberOf>
        {
            public OneOrManyMemberOf(IMemberOf item) : base(item) { }
            public OneOrManyMemberOf(IEnumerable<IMemberOf> items) : base(items) { }
            public static implicit operator OneOrManyMemberOf (Organization value) { return new OneOrManyMemberOf (new MemberOfOrganization (value)); }
            public static implicit operator OneOrManyMemberOf (Organization[] values) { return new OneOrManyMemberOf (values.Select(v => (IMemberOf) new MemberOfOrganization (v))); }
            public static implicit operator OneOrManyMemberOf (List<Organization> values) { return new OneOrManyMemberOf (values.Select(v => (IMemberOf) new MemberOfOrganization (v))); }
            public static implicit operator OneOrManyMemberOf (ProgramMembership value) { return new OneOrManyMemberOf (new MemberOfProgramMembership (value)); }
            public static implicit operator OneOrManyMemberOf (ProgramMembership[] values) { return new OneOrManyMemberOf (values.Select(v => (IMemberOf) new MemberOfProgramMembership (v))); }
            public static implicit operator OneOrManyMemberOf (List<ProgramMembership> values) { return new OneOrManyMemberOf (values.Select(v => (IMemberOf) new MemberOfProgramMembership (v))); }
        }
        public struct MemberOfOrganization : IMemberOf<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public MemberOfOrganization (Organization value) { Value = value; }
            public static implicit operator MemberOfOrganization (Organization value) { return new MemberOfOrganization (value); }
        }
        public struct MemberOfProgramMembership : IMemberOf<ProgramMembership>
        {
            object IValue.Value => this.Value;
            public ProgramMembership Value { get; }
            public MemberOfProgramMembership (ProgramMembership value) { Value = value; }
            public static implicit operator MemberOfProgramMembership (ProgramMembership value) { return new MemberOfProgramMembership (value); }
        }

        public interface INaics : IValue {}
        public interface INaics<T> : INaics { new T Value { get; } }
        public class OneOrManyNaics : OneOrMany<INaics>
        {
            public OneOrManyNaics(INaics item) : base(item) { }
            public OneOrManyNaics(IEnumerable<INaics> items) : base(items) { }
            public static implicit operator OneOrManyNaics (string value) { return new OneOrManyNaics (new Naicsstring (value)); }
            public static implicit operator OneOrManyNaics (string[] values) { return new OneOrManyNaics (values.Select(v => (INaics) new Naicsstring (v))); }
            public static implicit operator OneOrManyNaics (List<string> values) { return new OneOrManyNaics (values.Select(v => (INaics) new Naicsstring (v))); }
        }
        public struct Naicsstring : INaics<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Naicsstring (string value) { Value = value; }
            public static implicit operator Naicsstring (string value) { return new Naicsstring (value); }
        }

        public interface INumberOfEmployees : IValue {}
        public interface INumberOfEmployees<T> : INumberOfEmployees { new T Value { get; } }
        public class OneOrManyNumberOfEmployees : OneOrMany<INumberOfEmployees>
        {
            public OneOrManyNumberOfEmployees(INumberOfEmployees item) : base(item) { }
            public OneOrManyNumberOfEmployees(IEnumerable<INumberOfEmployees> items) : base(items) { }
            public static implicit operator OneOrManyNumberOfEmployees (QuantitativeValue value) { return new OneOrManyNumberOfEmployees (new NumberOfEmployeesQuantitativeValue (value)); }
            public static implicit operator OneOrManyNumberOfEmployees (QuantitativeValue[] values) { return new OneOrManyNumberOfEmployees (values.Select(v => (INumberOfEmployees) new NumberOfEmployeesQuantitativeValue (v))); }
            public static implicit operator OneOrManyNumberOfEmployees (List<QuantitativeValue> values) { return new OneOrManyNumberOfEmployees (values.Select(v => (INumberOfEmployees) new NumberOfEmployeesQuantitativeValue (v))); }
        }
        public struct NumberOfEmployeesQuantitativeValue : INumberOfEmployees<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public NumberOfEmployeesQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator NumberOfEmployeesQuantitativeValue (QuantitativeValue value) { return new NumberOfEmployeesQuantitativeValue (value); }
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

        public interface IOwnershipFundingInfo : IValue {}
        public interface IOwnershipFundingInfo<T> : IOwnershipFundingInfo { new T Value { get; } }
        public class OneOrManyOwnershipFundingInfo : OneOrMany<IOwnershipFundingInfo>
        {
            public OneOrManyOwnershipFundingInfo(IOwnershipFundingInfo item) : base(item) { }
            public OneOrManyOwnershipFundingInfo(IEnumerable<IOwnershipFundingInfo> items) : base(items) { }
            public static implicit operator OneOrManyOwnershipFundingInfo (AboutPage value) { return new OneOrManyOwnershipFundingInfo (new OwnershipFundingInfoAboutPage (value)); }
            public static implicit operator OneOrManyOwnershipFundingInfo (AboutPage[] values) { return new OneOrManyOwnershipFundingInfo (values.Select(v => (IOwnershipFundingInfo) new OwnershipFundingInfoAboutPage (v))); }
            public static implicit operator OneOrManyOwnershipFundingInfo (List<AboutPage> values) { return new OneOrManyOwnershipFundingInfo (values.Select(v => (IOwnershipFundingInfo) new OwnershipFundingInfoAboutPage (v))); }
            public static implicit operator OneOrManyOwnershipFundingInfo (CreativeWork value) { return new OneOrManyOwnershipFundingInfo (new OwnershipFundingInfoCreativeWork (value)); }
            public static implicit operator OneOrManyOwnershipFundingInfo (CreativeWork[] values) { return new OneOrManyOwnershipFundingInfo (values.Select(v => (IOwnershipFundingInfo) new OwnershipFundingInfoCreativeWork (v))); }
            public static implicit operator OneOrManyOwnershipFundingInfo (List<CreativeWork> values) { return new OneOrManyOwnershipFundingInfo (values.Select(v => (IOwnershipFundingInfo) new OwnershipFundingInfoCreativeWork (v))); }
            public static implicit operator OneOrManyOwnershipFundingInfo (string value) { return new OneOrManyOwnershipFundingInfo (new OwnershipFundingInfostring (value)); }
            public static implicit operator OneOrManyOwnershipFundingInfo (string[] values) { return new OneOrManyOwnershipFundingInfo (values.Select(v => (IOwnershipFundingInfo) new OwnershipFundingInfostring (v))); }
            public static implicit operator OneOrManyOwnershipFundingInfo (List<string> values) { return new OneOrManyOwnershipFundingInfo (values.Select(v => (IOwnershipFundingInfo) new OwnershipFundingInfostring (v))); }
            public static implicit operator OneOrManyOwnershipFundingInfo (Uri value) { return new OneOrManyOwnershipFundingInfo (new OwnershipFundingInfoUri (value)); }
            public static implicit operator OneOrManyOwnershipFundingInfo (Uri[] values) { return new OneOrManyOwnershipFundingInfo (values.Select(v => (IOwnershipFundingInfo) new OwnershipFundingInfoUri (v))); }
            public static implicit operator OneOrManyOwnershipFundingInfo (List<Uri> values) { return new OneOrManyOwnershipFundingInfo (values.Select(v => (IOwnershipFundingInfo) new OwnershipFundingInfoUri (v))); }
        }
        public struct OwnershipFundingInfoAboutPage : IOwnershipFundingInfo<AboutPage>
        {
            object IValue.Value => this.Value;
            public AboutPage Value { get; }
            public OwnershipFundingInfoAboutPage (AboutPage value) { Value = value; }
            public static implicit operator OwnershipFundingInfoAboutPage (AboutPage value) { return new OwnershipFundingInfoAboutPage (value); }
        }
        public struct OwnershipFundingInfoCreativeWork : IOwnershipFundingInfo<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public OwnershipFundingInfoCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator OwnershipFundingInfoCreativeWork (CreativeWork value) { return new OwnershipFundingInfoCreativeWork (value); }
        }
        public struct OwnershipFundingInfostring : IOwnershipFundingInfo<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public OwnershipFundingInfostring (string value) { Value = value; }
            public static implicit operator OwnershipFundingInfostring (string value) { return new OwnershipFundingInfostring (value); }
        }
        public struct OwnershipFundingInfoUri : IOwnershipFundingInfo<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public OwnershipFundingInfoUri (Uri value) { Value = value; }
            public static implicit operator OwnershipFundingInfoUri (Uri value) { return new OwnershipFundingInfoUri (value); }
        }

        public interface IOwns : IValue {}
        public interface IOwns<T> : IOwns { new T Value { get; } }
        public class OneOrManyOwns : OneOrMany<IOwns>
        {
            public OneOrManyOwns(IOwns item) : base(item) { }
            public OneOrManyOwns(IEnumerable<IOwns> items) : base(items) { }
            public static implicit operator OneOrManyOwns (OwnershipInfo value) { return new OneOrManyOwns (new OwnsOwnershipInfo (value)); }
            public static implicit operator OneOrManyOwns (OwnershipInfo[] values) { return new OneOrManyOwns (values.Select(v => (IOwns) new OwnsOwnershipInfo (v))); }
            public static implicit operator OneOrManyOwns (List<OwnershipInfo> values) { return new OneOrManyOwns (values.Select(v => (IOwns) new OwnsOwnershipInfo (v))); }
            public static implicit operator OneOrManyOwns (Product value) { return new OneOrManyOwns (new OwnsProduct (value)); }
            public static implicit operator OneOrManyOwns (Product[] values) { return new OneOrManyOwns (values.Select(v => (IOwns) new OwnsProduct (v))); }
            public static implicit operator OneOrManyOwns (List<Product> values) { return new OneOrManyOwns (values.Select(v => (IOwns) new OwnsProduct (v))); }
        }
        public struct OwnsOwnershipInfo : IOwns<OwnershipInfo>
        {
            object IValue.Value => this.Value;
            public OwnershipInfo Value { get; }
            public OwnsOwnershipInfo (OwnershipInfo value) { Value = value; }
            public static implicit operator OwnsOwnershipInfo (OwnershipInfo value) { return new OwnsOwnershipInfo (value); }
        }
        public struct OwnsProduct : IOwns<Product>
        {
            object IValue.Value => this.Value;
            public Product Value { get; }
            public OwnsProduct (Product value) { Value = value; }
            public static implicit operator OwnsProduct (Product value) { return new OwnsProduct (value); }
        }

        public interface IParentOrganization : IValue {}
        public interface IParentOrganization<T> : IParentOrganization { new T Value { get; } }
        public class OneOrManyParentOrganization : OneOrMany<IParentOrganization>
        {
            public OneOrManyParentOrganization(IParentOrganization item) : base(item) { }
            public OneOrManyParentOrganization(IEnumerable<IParentOrganization> items) : base(items) { }
            public static implicit operator OneOrManyParentOrganization (Organization value) { return new OneOrManyParentOrganization (new ParentOrganizationOrganization (value)); }
            public static implicit operator OneOrManyParentOrganization (Organization[] values) { return new OneOrManyParentOrganization (values.Select(v => (IParentOrganization) new ParentOrganizationOrganization (v))); }
            public static implicit operator OneOrManyParentOrganization (List<Organization> values) { return new OneOrManyParentOrganization (values.Select(v => (IParentOrganization) new ParentOrganizationOrganization (v))); }
        }
        public struct ParentOrganizationOrganization : IParentOrganization<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public ParentOrganizationOrganization (Organization value) { Value = value; }
            public static implicit operator ParentOrganizationOrganization (Organization value) { return new ParentOrganizationOrganization (value); }
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

        public interface IPublishingPrinciples : IValue {}
        public interface IPublishingPrinciples<T> : IPublishingPrinciples { new T Value { get; } }
        public class OneOrManyPublishingPrinciples : OneOrMany<IPublishingPrinciples>
        {
            public OneOrManyPublishingPrinciples(IPublishingPrinciples item) : base(item) { }
            public OneOrManyPublishingPrinciples(IEnumerable<IPublishingPrinciples> items) : base(items) { }
            public static implicit operator OneOrManyPublishingPrinciples (CreativeWork value) { return new OneOrManyPublishingPrinciples (new PublishingPrinciplesCreativeWork (value)); }
            public static implicit operator OneOrManyPublishingPrinciples (CreativeWork[] values) { return new OneOrManyPublishingPrinciples (values.Select(v => (IPublishingPrinciples) new PublishingPrinciplesCreativeWork (v))); }
            public static implicit operator OneOrManyPublishingPrinciples (List<CreativeWork> values) { return new OneOrManyPublishingPrinciples (values.Select(v => (IPublishingPrinciples) new PublishingPrinciplesCreativeWork (v))); }
            public static implicit operator OneOrManyPublishingPrinciples (Uri value) { return new OneOrManyPublishingPrinciples (new PublishingPrinciplesUri (value)); }
            public static implicit operator OneOrManyPublishingPrinciples (Uri[] values) { return new OneOrManyPublishingPrinciples (values.Select(v => (IPublishingPrinciples) new PublishingPrinciplesUri (v))); }
            public static implicit operator OneOrManyPublishingPrinciples (List<Uri> values) { return new OneOrManyPublishingPrinciples (values.Select(v => (IPublishingPrinciples) new PublishingPrinciplesUri (v))); }
        }
        public struct PublishingPrinciplesCreativeWork : IPublishingPrinciples<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public PublishingPrinciplesCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator PublishingPrinciplesCreativeWork (CreativeWork value) { return new PublishingPrinciplesCreativeWork (value); }
        }
        public struct PublishingPrinciplesUri : IPublishingPrinciples<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public PublishingPrinciplesUri (Uri value) { Value = value; }
            public static implicit operator PublishingPrinciplesUri (Uri value) { return new PublishingPrinciplesUri (value); }
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

        public interface ISeeks : IValue {}
        public interface ISeeks<T> : ISeeks { new T Value { get; } }
        public class OneOrManySeeks : OneOrMany<ISeeks>
        {
            public OneOrManySeeks(ISeeks item) : base(item) { }
            public OneOrManySeeks(IEnumerable<ISeeks> items) : base(items) { }
            public static implicit operator OneOrManySeeks (Demand value) { return new OneOrManySeeks (new SeeksDemand (value)); }
            public static implicit operator OneOrManySeeks (Demand[] values) { return new OneOrManySeeks (values.Select(v => (ISeeks) new SeeksDemand (v))); }
            public static implicit operator OneOrManySeeks (List<Demand> values) { return new OneOrManySeeks (values.Select(v => (ISeeks) new SeeksDemand (v))); }
        }
        public struct SeeksDemand : ISeeks<Demand>
        {
            object IValue.Value => this.Value;
            public Demand Value { get; }
            public SeeksDemand (Demand value) { Value = value; }
            public static implicit operator SeeksDemand (Demand value) { return new SeeksDemand (value); }
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

        public interface ISponsor : IValue {}
        public interface ISponsor<T> : ISponsor { new T Value { get; } }
        public class OneOrManySponsor : OneOrMany<ISponsor>
        {
            public OneOrManySponsor(ISponsor item) : base(item) { }
            public OneOrManySponsor(IEnumerable<ISponsor> items) : base(items) { }
            public static implicit operator OneOrManySponsor (Organization value) { return new OneOrManySponsor (new SponsorOrganization (value)); }
            public static implicit operator OneOrManySponsor (Organization[] values) { return new OneOrManySponsor (values.Select(v => (ISponsor) new SponsorOrganization (v))); }
            public static implicit operator OneOrManySponsor (List<Organization> values) { return new OneOrManySponsor (values.Select(v => (ISponsor) new SponsorOrganization (v))); }
            public static implicit operator OneOrManySponsor (Person value) { return new OneOrManySponsor (new SponsorPerson (value)); }
            public static implicit operator OneOrManySponsor (Person[] values) { return new OneOrManySponsor (values.Select(v => (ISponsor) new SponsorPerson (v))); }
            public static implicit operator OneOrManySponsor (List<Person> values) { return new OneOrManySponsor (values.Select(v => (ISponsor) new SponsorPerson (v))); }
        }
        public struct SponsorOrganization : ISponsor<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public SponsorOrganization (Organization value) { Value = value; }
            public static implicit operator SponsorOrganization (Organization value) { return new SponsorOrganization (value); }
        }
        public struct SponsorPerson : ISponsor<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public SponsorPerson (Person value) { Value = value; }
            public static implicit operator SponsorPerson (Person value) { return new SponsorPerson (value); }
        }

        public interface ISubOrganization : IValue {}
        public interface ISubOrganization<T> : ISubOrganization { new T Value { get; } }
        public class OneOrManySubOrganization : OneOrMany<ISubOrganization>
        {
            public OneOrManySubOrganization(ISubOrganization item) : base(item) { }
            public OneOrManySubOrganization(IEnumerable<ISubOrganization> items) : base(items) { }
            public static implicit operator OneOrManySubOrganization (Organization value) { return new OneOrManySubOrganization (new SubOrganizationOrganization (value)); }
            public static implicit operator OneOrManySubOrganization (Organization[] values) { return new OneOrManySubOrganization (values.Select(v => (ISubOrganization) new SubOrganizationOrganization (v))); }
            public static implicit operator OneOrManySubOrganization (List<Organization> values) { return new OneOrManySubOrganization (values.Select(v => (ISubOrganization) new SubOrganizationOrganization (v))); }
        }
        public struct SubOrganizationOrganization : ISubOrganization<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public SubOrganizationOrganization (Organization value) { Value = value; }
            public static implicit operator SubOrganizationOrganization (Organization value) { return new SubOrganizationOrganization (value); }
        }

        public interface ITaxID : IValue {}
        public interface ITaxID<T> : ITaxID { new T Value { get; } }
        public class OneOrManyTaxID : OneOrMany<ITaxID>
        {
            public OneOrManyTaxID(ITaxID item) : base(item) { }
            public OneOrManyTaxID(IEnumerable<ITaxID> items) : base(items) { }
            public static implicit operator OneOrManyTaxID (string value) { return new OneOrManyTaxID (new TaxIDstring (value)); }
            public static implicit operator OneOrManyTaxID (string[] values) { return new OneOrManyTaxID (values.Select(v => (ITaxID) new TaxIDstring (v))); }
            public static implicit operator OneOrManyTaxID (List<string> values) { return new OneOrManyTaxID (values.Select(v => (ITaxID) new TaxIDstring (v))); }
        }
        public struct TaxIDstring : ITaxID<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public TaxIDstring (string value) { Value = value; }
            public static implicit operator TaxIDstring (string value) { return new TaxIDstring (value); }
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

        public interface IUnnamedSourcesPolicy : IValue {}
        public interface IUnnamedSourcesPolicy<T> : IUnnamedSourcesPolicy { new T Value { get; } }
        public class OneOrManyUnnamedSourcesPolicy : OneOrMany<IUnnamedSourcesPolicy>
        {
            public OneOrManyUnnamedSourcesPolicy(IUnnamedSourcesPolicy item) : base(item) { }
            public OneOrManyUnnamedSourcesPolicy(IEnumerable<IUnnamedSourcesPolicy> items) : base(items) { }
            public static implicit operator OneOrManyUnnamedSourcesPolicy (CreativeWork value) { return new OneOrManyUnnamedSourcesPolicy (new UnnamedSourcesPolicyCreativeWork (value)); }
            public static implicit operator OneOrManyUnnamedSourcesPolicy (CreativeWork[] values) { return new OneOrManyUnnamedSourcesPolicy (values.Select(v => (IUnnamedSourcesPolicy) new UnnamedSourcesPolicyCreativeWork (v))); }
            public static implicit operator OneOrManyUnnamedSourcesPolicy (List<CreativeWork> values) { return new OneOrManyUnnamedSourcesPolicy (values.Select(v => (IUnnamedSourcesPolicy) new UnnamedSourcesPolicyCreativeWork (v))); }
            public static implicit operator OneOrManyUnnamedSourcesPolicy (Uri value) { return new OneOrManyUnnamedSourcesPolicy (new UnnamedSourcesPolicyUri (value)); }
            public static implicit operator OneOrManyUnnamedSourcesPolicy (Uri[] values) { return new OneOrManyUnnamedSourcesPolicy (values.Select(v => (IUnnamedSourcesPolicy) new UnnamedSourcesPolicyUri (v))); }
            public static implicit operator OneOrManyUnnamedSourcesPolicy (List<Uri> values) { return new OneOrManyUnnamedSourcesPolicy (values.Select(v => (IUnnamedSourcesPolicy) new UnnamedSourcesPolicyUri (v))); }
        }
        public struct UnnamedSourcesPolicyCreativeWork : IUnnamedSourcesPolicy<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public UnnamedSourcesPolicyCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator UnnamedSourcesPolicyCreativeWork (CreativeWork value) { return new UnnamedSourcesPolicyCreativeWork (value); }
        }
        public struct UnnamedSourcesPolicyUri : IUnnamedSourcesPolicy<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public UnnamedSourcesPolicyUri (Uri value) { Value = value; }
            public static implicit operator UnnamedSourcesPolicyUri (Uri value) { return new UnnamedSourcesPolicyUri (value); }
        }

        public interface IVatID : IValue {}
        public interface IVatID<T> : IVatID { new T Value { get; } }
        public class OneOrManyVatID : OneOrMany<IVatID>
        {
            public OneOrManyVatID(IVatID item) : base(item) { }
            public OneOrManyVatID(IEnumerable<IVatID> items) : base(items) { }
            public static implicit operator OneOrManyVatID (string value) { return new OneOrManyVatID (new VatIDstring (value)); }
            public static implicit operator OneOrManyVatID (string[] values) { return new OneOrManyVatID (values.Select(v => (IVatID) new VatIDstring (v))); }
            public static implicit operator OneOrManyVatID (List<string> values) { return new OneOrManyVatID (values.Select(v => (IVatID) new VatIDstring (v))); }
        }
        public struct VatIDstring : IVatID<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public VatIDstring (string value) { Value = value; }
            public static implicit operator VatIDstring (string value) { return new VatIDstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OrganizationAndPlace";

        /// <summary>
        /// For a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt; or other news-related &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, a statement about public engagement activities (for news media, the newsroom’s), including involving the public - digitally or otherwise -- in coverage decisions, reporting and activities after publication.
        /// </summary>
        [DataMember(Name = "actionableFeedbackPolicy", Order = 106)]
        public virtual OneOrManyActionableFeedbackPolicy ActionableFeedbackPolicy { get; set; }

        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;br/&gt;&lt;br/&gt;
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        [DataMember(Name = "additionalProperty", Order = 107)]
        public virtual OneOrManyAdditionalProperty AdditionalProperty { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 108)]
        public virtual OneOrManyAddress Address { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 109)]
        public virtual OneOrManyAggregateRating AggregateRating { get; set; }

        /// <summary>
        /// Alumni of an organization.
        /// </summary>
        [DataMember(Name = "alumni", Order = 110)]
        public virtual OneOrManyAlumni Alumni { get; set; }

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [DataMember(Name = "amenityFeature", Order = 111)]
        public virtual OneOrManyAmenityFeature AmenityFeature { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 112)]
        public virtual OneOrManyAreaServed AreaServed { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 113)]
        public virtual OneOrManyAward Award { get; set; }

        /// <summary>
        /// A short textual code (also called "store code") that uniquely identifies a place of business. The code is typically assigned by the parentOrganization and used in structured URLs.&lt;br/&gt;&lt;br/&gt;
        /// For example, in the URL http://www.starbucks.co.uk/store-locator/etc/detail/3047 the code "3047" is a branchCode for a particular branch.
        /// </summary>
        [DataMember(Name = "branchCode", Order = 114)]
        public virtual OneOrManyBranchCode BranchCode { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 115)]
        public virtual OneOrManyBrand Brand { get; set; }

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        [DataMember(Name = "contactPoint", Order = 116)]
        public virtual OneOrManyContactPoint ContactPoint { get; set; }

        /// <summary>
        /// The basic containment relation between a place and one that contains it.
        /// </summary>
        [DataMember(Name = "containedInPlace", Order = 117)]
        public virtual OneOrManyContainedInPlace ContainedInPlace { get; set; }

        /// <summary>
        /// The basic containment relation between a place and another that it contains.
        /// </summary>
        [DataMember(Name = "containsPlace", Order = 118)]
        public virtual OneOrManyContainsPlace ContainsPlace { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a statement describing (in news media, the newsroom’s) disclosure and correction policy for errors.
        /// </summary>
        [DataMember(Name = "correctionsPolicy", Order = 119)]
        public virtual OneOrManyCorrectionsPolicy CorrectionsPolicy { get; set; }

        /// <summary>
        /// A relationship between an organization and a department of that organization, also described as an organization (allowing different urls, logos, opening hours). For example: a store with a pharmacy, or a bakery with a cafe.
        /// </summary>
        [DataMember(Name = "department", Order = 120)]
        public virtual OneOrManyDepartment Department { get; set; }

        /// <summary>
        /// The date that this organization was dissolved.
        /// </summary>
        [DataMember(Name = "dissolutionDate", Order = 121)]
        public virtual OneOrManyDissolutionDate DissolutionDate { get; set; }

        /// <summary>
        /// Statement on diversity policy by an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; e.g. a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;. For a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;, a statement describing the newsroom’s diversity policy on both staffing and sources, typically providing staffing data.
        /// </summary>
        [DataMember(Name = "diversityPolicy", Order = 122)]
        public virtual OneOrManyDiversityPolicy DiversityPolicy { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (often but not necessarily a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a report on staffing diversity issues. In a news context this might be for example ASNE or RTDNA (US) reports, or self-reported.
        /// </summary>
        [DataMember(Name = "diversityStaffingReport", Order = 123)]
        public virtual OneOrManyDiversityStaffingReport DiversityStaffingReport { get; set; }

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        [DataMember(Name = "duns", Order = 124)]
        public virtual OneOrManyDuns Duns { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [DataMember(Name = "email", Order = 125)]
        public virtual OneOrManyEmail Email { get; set; }

        /// <summary>
        /// Someone working for this organization.
        /// </summary>
        [DataMember(Name = "employee", Order = 126)]
        public virtual OneOrManyEmployee Employee { get; set; }

        /// <summary>
        /// Statement about ethics policy, e.g. of a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt; regarding journalistic and publishing practices, or of a &lt;a class="localLink" href="http://schema.org/Restaurant"&gt;Restaurant&lt;/a&gt;, a page describing food source policies. In the case of a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;, an ethicsPolicy is typically a statement describing the personal, organizational, and corporate standards of behavior expected by the organization.
        /// </summary>
        [DataMember(Name = "ethicsPolicy", Order = 127)]
        public virtual OneOrManyEthicsPolicy EthicsPolicy { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 128)]
        public virtual OneOrManyEvent Event { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 129)]
        public virtual OneOrManyFaxNumber FaxNumber { get; set; }

        /// <summary>
        /// A person who founded this organization.
        /// </summary>
        [DataMember(Name = "founder", Order = 130)]
        public virtual OneOrManyFounder Founder { get; set; }

        /// <summary>
        /// The date that this organization was founded.
        /// </summary>
        [DataMember(Name = "foundingDate", Order = 131)]
        public virtual OneOrManyFoundingDate FoundingDate { get; set; }

        /// <summary>
        /// The place where the Organization was founded.
        /// </summary>
        [DataMember(Name = "foundingLocation", Order = 132)]
        public virtual OneOrManyFoundingLocation FoundingLocation { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 133)]
        public virtual OneOrManyFunder Funder { get; set; }

        /// <summary>
        /// The geo coordinates of the place.
        /// </summary>
        [DataMember(Name = "geo", Order = 134)]
        public virtual OneOrManyGeo Geo { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a containing geometry to a contained geometry. "a contains b iff no points of b lie in the exterior of a, and at least one point of the interior of b lies in the interior of a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyContains", Order = 135)]
        public virtual OneOrManyGeospatiallyContains GeospatiallyContains { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that covers it. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyCoveredBy", Order = 136)]
        public virtual OneOrManyGeospatiallyCoveredBy GeospatiallyCoveredBy { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a covering geometry to a covered geometry. "Every point of b is a point of (the interior or boundary of) a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyCovers", Order = 137)]
        public virtual OneOrManyGeospatiallyCovers GeospatiallyCovers { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that crosses it: "a crosses b: they have some but not all interior points in common, and the dimension of the intersection is less than that of at least one of them". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyCrosses", Order = 138)]
        public virtual OneOrManyGeospatiallyCrosses GeospatiallyCrosses { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically disjoint: they have no point in common. They form a set of disconnected geometries." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;)
        /// </summary>
        [DataMember(Name = "geospatiallyDisjoint", Order = 139)]
        public virtual OneOrManyGeospatiallyDisjoint GeospatiallyDisjoint { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically equal, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;. "Two geometries are topologically equal if their interiors intersect and no part of the interior or boundary of one geometry intersects the exterior of the other" (a symmetric relationship)
        /// </summary>
        [DataMember(Name = "geospatiallyEquals", Order = 140)]
        public virtual OneOrManyGeospatiallyEquals GeospatiallyEquals { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) have at least one point in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyIntersects", Order = 141)]
        public virtual OneOrManyGeospatiallyIntersects GeospatiallyIntersects { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that geospatially overlaps it, i.e. they have some but not all points in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyOverlaps", Order = 142)]
        public virtual OneOrManyGeospatiallyOverlaps GeospatiallyOverlaps { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) touch: they have at least one boundary point in common, but no interior points." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt; )
        /// </summary>
        [DataMember(Name = "geospatiallyTouches", Order = 143)]
        public virtual OneOrManyGeospatiallyTouches GeospatiallyTouches { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to one that contains it, i.e. it is inside (i.e. within) its interior. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyWithin", Order = 144)]
        public virtual OneOrManyGeospatiallyWithin GeospatiallyWithin { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber", Order = 145)]
        public virtual OneOrManyGlobalLocationNumber GlobalLocationNumber { get; set; }

        /// <summary>
        /// A URL to a map of the place.
        /// </summary>
        [DataMember(Name = "hasMap", Order = 146)]
        public virtual OneOrManyHasMap HasMap { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [DataMember(Name = "hasOfferCatalog", Order = 147)]
        public virtual OneOrManyHasOfferCatalog HasOfferCatalog { get; set; }

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        [DataMember(Name = "hasPOS", Order = 148)]
        public virtual OneOrManyHasPOS HasPOS { get; set; }

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree", Order = 149)]
        public virtual OneOrManyIsAccessibleForFree IsAccessibleForFree { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4", Order = 150)]
        public virtual OneOrManyIsicV4 IsicV4 { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a topic that is known about - suggesting possible expertise but not implying it. We do not distinguish skill levels here, or yet relate this to educational content, events, objectives or &lt;a class="localLink" href="http://schema.org/JobPosting"&gt;JobPosting&lt;/a&gt; descriptions.
        /// </summary>
        [DataMember(Name = "knowsAbout", Order = 151)]
        public virtual OneOrManyKnowsAbout KnowsAbout { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a known language. We do not distinguish skill levels or reading/writing/speaking/signing here. Use language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "knowsLanguage", Order = 152)]
        public virtual OneOrManyKnowsLanguage KnowsLanguage { get; set; }

        /// <summary>
        /// The official name of the organization, e.g. the registered company name.
        /// </summary>
        [DataMember(Name = "legalName", Order = 153)]
        public virtual OneOrManyLegalName LegalName { get; set; }

        /// <summary>
        /// An organization identifier that uniquely identifies a legal entity as defined in ISO 17442.
        /// </summary>
        [DataMember(Name = "leiCode", Order = 154)]
        public virtual OneOrManyLeiCode LeiCode { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [DataMember(Name = "location", Order = 155)]
        public virtual OneOrManyLocation Location { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 156)]
        public virtual OneOrManyLogo Logo { get; set; }

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        [DataMember(Name = "makesOffer", Order = 157)]
        public virtual OneOrManyMakesOffer MakesOffer { get; set; }

        /// <summary>
        /// The total number of individuals that may attend an event or venue.
        /// </summary>
        [DataMember(Name = "maximumAttendeeCapacity", Order = 158)]
        public virtual OneOrManyMaximumAttendeeCapacity MaximumAttendeeCapacity { get; set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [DataMember(Name = "member", Order = 159)]
        public virtual OneOrManyMember Member { get; set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        [DataMember(Name = "memberOf", Order = 160)]
        public virtual OneOrManyMemberOf MemberOf { get; set; }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        [DataMember(Name = "naics", Order = 161)]
        public virtual OneOrManyNaics Naics { get; set; }

        /// <summary>
        /// The number of employees in an organization e.g. business.
        /// </summary>
        [DataMember(Name = "numberOfEmployees", Order = 162)]
        public virtual OneOrManyNumberOfEmployees NumberOfEmployees { get; set; }

        /// <summary>
        /// The opening hours of a certain place.
        /// </summary>
        [DataMember(Name = "openingHoursSpecification", Order = 163)]
        public virtual OneOrManyOpeningHoursSpecification OpeningHoursSpecification { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (often but not necessarily a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a description of organizational ownership structure; funding and grants. In a news/media setting, this is with particular reference to editorial independence.   Note that the &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt; is also available and can be used to make basic funder information machine-readable.
        /// </summary>
        [DataMember(Name = "ownershipFundingInfo", Order = 164)]
        public virtual OneOrManyOwnershipFundingInfo OwnershipFundingInfo { get; set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        [DataMember(Name = "owns", Order = 165)]
        public virtual OneOrManyOwns Owns { get; set; }

        /// <summary>
        /// The larger organization that this organization is a &lt;a class="localLink" href="http://schema.org/subOrganization"&gt;subOrganization&lt;/a&gt; of, if any.
        /// </summary>
        [DataMember(Name = "parentOrganization", Order = 166)]
        public virtual OneOrManyParentOrganization ParentOrganization { get; set; }

        /// <summary>
        /// A photograph of this place.
        /// </summary>
        [DataMember(Name = "photo", Order = 167)]
        public virtual OneOrManyPhoto Photo { get; set; }

        /// <summary>
        /// A flag to signal that the &lt;a class="localLink" href="http://schema.org/Place"&gt;Place&lt;/a&gt; is open to public visitors.  If this property is omitted there is no assumed default boolean value
        /// </summary>
        [DataMember(Name = "publicAccess", Order = 168)]
        public virtual OneOrManyPublicAccess PublicAccess { get; set; }

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        [DataMember(Name = "publishingPrinciples", Order = 169)]
        public virtual OneOrManyPublishingPrinciples PublishingPrinciples { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 170)]
        public virtual OneOrManyReview Review { get; set; }

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        [DataMember(Name = "seeks", Order = 171)]
        public virtual OneOrManySeeks Seeks { get; set; }

        /// <summary>
        /// Indicates whether it is allowed to smoke in the place, e.g. in the restaurant, hotel or hotel room.
        /// </summary>
        [DataMember(Name = "smokingAllowed", Order = 172)]
        public virtual OneOrManySmokingAllowed SmokingAllowed { get; set; }

        /// <summary>
        /// The special opening hours of a certain place.&lt;br/&gt;&lt;br/&gt;
        /// Use this to explicitly override general opening hours brought in scope by &lt;a class="localLink" href="http://schema.org/openingHoursSpecification"&gt;openingHoursSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/openingHours"&gt;openingHours&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "specialOpeningHoursSpecification", Order = 173)]
        public virtual OneOrManySpecialOpeningHoursSpecification SpecialOpeningHoursSpecification { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 174)]
        public virtual OneOrManySponsor Sponsor { get; set; }

        /// <summary>
        /// A relationship between two organizations where the first includes the second, e.g., as a subsidiary. See also: the more specific 'department' property.
        /// </summary>
        [DataMember(Name = "subOrganization", Order = 175)]
        public virtual OneOrManySubOrganization SubOrganization { get; set; }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [DataMember(Name = "taxID", Order = 176)]
        public virtual OneOrManyTaxID TaxID { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 177)]
        public virtual OneOrManyTelephone Telephone { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (typically a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a statement about policy on use of unnamed sources and the decision process required.
        /// </summary>
        [DataMember(Name = "unnamedSourcesPolicy", Order = 178)]
        public virtual OneOrManyUnnamedSourcesPolicy UnnamedSourcesPolicy { get; set; }

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        [DataMember(Name = "vatID", Order = 179)]
        public virtual OneOrManyVatID VatID { get; set; }
    }
}
