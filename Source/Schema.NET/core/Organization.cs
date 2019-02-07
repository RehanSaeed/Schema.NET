namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
    [DataContract]
    public partial class Organization : Thing
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
        public override string Type => "Organization";

        /// <summary>
        /// For a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt; or other news-related &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, a statement about public engagement activities (for news media, the newsroom’s), including involving the public - digitally or otherwise -- in coverage decisions, reporting and activities after publication.
        /// </summary>
        [DataMember(Name = "actionableFeedbackPolicy", Order = 106)]
        public OneOrManyActionableFeedbackPolicy ActionableFeedbackPolicy { get; set; }

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
        /// Alumni of an organization.
        /// </summary>
        [DataMember(Name = "alumni", Order = 109)]
        public virtual OneOrManyAlumni Alumni { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 110)]
        public OneOrManyAreaServed AreaServed { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 111)]
        public OneOrManyAward Award { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 112)]
        public OneOrManyBrand Brand { get; set; }

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        [DataMember(Name = "contactPoint", Order = 113)]
        public OneOrManyContactPoint ContactPoint { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a statement describing (in news media, the newsroom’s) disclosure and correction policy for errors.
        /// </summary>
        [DataMember(Name = "correctionsPolicy", Order = 114)]
        public OneOrManyCorrectionsPolicy CorrectionsPolicy { get; set; }

        /// <summary>
        /// A relationship between an organization and a department of that organization, also described as an organization (allowing different urls, logos, opening hours). For example: a store with a pharmacy, or a bakery with a cafe.
        /// </summary>
        [DataMember(Name = "department", Order = 115)]
        public OneOrManyDepartment Department { get; set; }

        /// <summary>
        /// The date that this organization was dissolved.
        /// </summary>
        [DataMember(Name = "dissolutionDate", Order = 116)]
        public OneOrManyDissolutionDate DissolutionDate { get; set; }

        /// <summary>
        /// Statement on diversity policy by an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; e.g. a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;. For a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;, a statement describing the newsroom’s diversity policy on both staffing and sources, typically providing staffing data.
        /// </summary>
        [DataMember(Name = "diversityPolicy", Order = 117)]
        public OneOrManyDiversityPolicy DiversityPolicy { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (often but not necessarily a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a report on staffing diversity issues. In a news context this might be for example ASNE or RTDNA (US) reports, or self-reported.
        /// </summary>
        [DataMember(Name = "diversityStaffingReport", Order = 118)]
        public OneOrManyDiversityStaffingReport DiversityStaffingReport { get; set; }

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        [DataMember(Name = "duns", Order = 119)]
        public OneOrManyDuns Duns { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [DataMember(Name = "email", Order = 120)]
        public OneOrManyEmail Email { get; set; }

        /// <summary>
        /// Someone working for this organization.
        /// </summary>
        [DataMember(Name = "employee", Order = 121)]
        public OneOrManyEmployee Employee { get; set; }

        /// <summary>
        /// Statement about ethics policy, e.g. of a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt; regarding journalistic and publishing practices, or of a &lt;a class="localLink" href="http://schema.org/Restaurant"&gt;Restaurant&lt;/a&gt;, a page describing food source policies. In the case of a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;, an ethicsPolicy is typically a statement describing the personal, organizational, and corporate standards of behavior expected by the organization.
        /// </summary>
        [DataMember(Name = "ethicsPolicy", Order = 122)]
        public OneOrManyEthicsPolicy EthicsPolicy { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 123)]
        public OneOrManyEvent Event { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 124)]
        public OneOrManyFaxNumber FaxNumber { get; set; }

        /// <summary>
        /// A person who founded this organization.
        /// </summary>
        [DataMember(Name = "founder", Order = 125)]
        public OneOrManyFounder Founder { get; set; }

        /// <summary>
        /// The date that this organization was founded.
        /// </summary>
        [DataMember(Name = "foundingDate", Order = 126)]
        public OneOrManyFoundingDate FoundingDate { get; set; }

        /// <summary>
        /// The place where the Organization was founded.
        /// </summary>
        [DataMember(Name = "foundingLocation", Order = 127)]
        public OneOrManyFoundingLocation FoundingLocation { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 128)]
        public OneOrManyFunder Funder { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber", Order = 129)]
        public OneOrManyGlobalLocationNumber GlobalLocationNumber { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [DataMember(Name = "hasOfferCatalog", Order = 130)]
        public OneOrManyHasOfferCatalog HasOfferCatalog { get; set; }

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        [DataMember(Name = "hasPOS", Order = 131)]
        public OneOrManyHasPOS HasPOS { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4", Order = 132)]
        public OneOrManyIsicV4 IsicV4 { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a topic that is known about - suggesting possible expertise but not implying it. We do not distinguish skill levels here, or yet relate this to educational content, events, objectives or &lt;a class="localLink" href="http://schema.org/JobPosting"&gt;JobPosting&lt;/a&gt; descriptions.
        /// </summary>
        [DataMember(Name = "knowsAbout", Order = 133)]
        public OneOrManyKnowsAbout KnowsAbout { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a known language. We do not distinguish skill levels or reading/writing/speaking/signing here. Use language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "knowsLanguage", Order = 134)]
        public OneOrManyKnowsLanguage KnowsLanguage { get; set; }

        /// <summary>
        /// The official name of the organization, e.g. the registered company name.
        /// </summary>
        [DataMember(Name = "legalName", Order = 135)]
        public OneOrManyLegalName LegalName { get; set; }

        /// <summary>
        /// An organization identifier that uniquely identifies a legal entity as defined in ISO 17442.
        /// </summary>
        [DataMember(Name = "leiCode", Order = 136)]
        public OneOrManyLeiCode LeiCode { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [DataMember(Name = "location", Order = 137)]
        public OneOrManyLocation Location { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 138)]
        public OneOrManyLogo Logo { get; set; }

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        [DataMember(Name = "makesOffer", Order = 139)]
        public OneOrManyMakesOffer MakesOffer { get; set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [DataMember(Name = "member", Order = 140)]
        public OneOrManyMember Member { get; set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        [DataMember(Name = "memberOf", Order = 141)]
        public OneOrManyMemberOf MemberOf { get; set; }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        [DataMember(Name = "naics", Order = 142)]
        public OneOrManyNaics Naics { get; set; }

        /// <summary>
        /// The number of employees in an organization e.g. business.
        /// </summary>
        [DataMember(Name = "numberOfEmployees", Order = 143)]
        public OneOrManyNumberOfEmployees NumberOfEmployees { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (often but not necessarily a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a description of organizational ownership structure; funding and grants. In a news/media setting, this is with particular reference to editorial independence.   Note that the &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt; is also available and can be used to make basic funder information machine-readable.
        /// </summary>
        [DataMember(Name = "ownershipFundingInfo", Order = 144)]
        public OneOrManyOwnershipFundingInfo OwnershipFundingInfo { get; set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        [DataMember(Name = "owns", Order = 145)]
        public OneOrManyOwns Owns { get; set; }

        /// <summary>
        /// The larger organization that this organization is a &lt;a class="localLink" href="http://schema.org/subOrganization"&gt;subOrganization&lt;/a&gt; of, if any.
        /// </summary>
        [DataMember(Name = "parentOrganization", Order = 146)]
        public OneOrManyParentOrganization ParentOrganization { get; set; }

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        [DataMember(Name = "publishingPrinciples", Order = 147)]
        public OneOrManyPublishingPrinciples PublishingPrinciples { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 148)]
        public OneOrManyReview Review { get; set; }

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        [DataMember(Name = "seeks", Order = 149)]
        public OneOrManySeeks Seeks { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 150)]
        public OneOrManySponsor Sponsor { get; set; }

        /// <summary>
        /// A relationship between two organizations where the first includes the second, e.g., as a subsidiary. See also: the more specific 'department' property.
        /// </summary>
        [DataMember(Name = "subOrganization", Order = 151)]
        public OneOrManySubOrganization SubOrganization { get; set; }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [DataMember(Name = "taxID", Order = 152)]
        public OneOrManyTaxID TaxID { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 153)]
        public OneOrManyTelephone Telephone { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (typically a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a statement about policy on use of unnamed sources and the decision process required.
        /// </summary>
        [DataMember(Name = "unnamedSourcesPolicy", Order = 154)]
        public OneOrManyUnnamedSourcesPolicy UnnamedSourcesPolicy { get; set; }

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        [DataMember(Name = "vatID", Order = 155)]
        public OneOrManyVatID VatID { get; set; }
    }
}
