namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
    [DataContract]
    public partial class Person : Thing
    {
        public interface IAdditionalName : IValue {}
        public interface IAdditionalName<T> : IAdditionalName { new T Value { get; } }
        public class OneOrManyAdditionalName : OneOrMany<IAdditionalName>
        {
            public OneOrManyAdditionalName(IAdditionalName item) : base(item) { }
            public OneOrManyAdditionalName(IEnumerable<IAdditionalName> items) : base(items) { }
            public static implicit operator OneOrManyAdditionalName (string value) { return new OneOrManyAdditionalName (new AdditionalNamestring (value)); }
            public static implicit operator OneOrManyAdditionalName (string[] values) { return new OneOrManyAdditionalName (values.Select(v => (IAdditionalName) new AdditionalNamestring (v))); }
            public static implicit operator OneOrManyAdditionalName (List<string> values) { return new OneOrManyAdditionalName (values.Select(v => (IAdditionalName) new AdditionalNamestring (v))); }
        }
        public struct AdditionalNamestring : IAdditionalName<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AdditionalNamestring (string value) { Value = value; }
            public static implicit operator AdditionalNamestring (string value) { return new AdditionalNamestring (value); }
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

        public interface IAffiliation : IValue {}
        public interface IAffiliation<T> : IAffiliation { new T Value { get; } }
        public class OneOrManyAffiliation : OneOrMany<IAffiliation>
        {
            public OneOrManyAffiliation(IAffiliation item) : base(item) { }
            public OneOrManyAffiliation(IEnumerable<IAffiliation> items) : base(items) { }
            public static implicit operator OneOrManyAffiliation (Organization value) { return new OneOrManyAffiliation (new AffiliationOrganization (value)); }
            public static implicit operator OneOrManyAffiliation (Organization[] values) { return new OneOrManyAffiliation (values.Select(v => (IAffiliation) new AffiliationOrganization (v))); }
            public static implicit operator OneOrManyAffiliation (List<Organization> values) { return new OneOrManyAffiliation (values.Select(v => (IAffiliation) new AffiliationOrganization (v))); }
        }
        public struct AffiliationOrganization : IAffiliation<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public AffiliationOrganization (Organization value) { Value = value; }
            public static implicit operator AffiliationOrganization (Organization value) { return new AffiliationOrganization (value); }
        }

        public interface IAlumniOf : IValue {}
        public interface IAlumniOf<T> : IAlumniOf { new T Value { get; } }
        public class OneOrManyAlumniOf : OneOrMany<IAlumniOf>
        {
            public OneOrManyAlumniOf(IAlumniOf item) : base(item) { }
            public OneOrManyAlumniOf(IEnumerable<IAlumniOf> items) : base(items) { }
            public static implicit operator OneOrManyAlumniOf (EducationalOrganization value) { return new OneOrManyAlumniOf (new AlumniOfEducationalOrganization (value)); }
            public static implicit operator OneOrManyAlumniOf (EducationalOrganization[] values) { return new OneOrManyAlumniOf (values.Select(v => (IAlumniOf) new AlumniOfEducationalOrganization (v))); }
            public static implicit operator OneOrManyAlumniOf (List<EducationalOrganization> values) { return new OneOrManyAlumniOf (values.Select(v => (IAlumniOf) new AlumniOfEducationalOrganization (v))); }
            public static implicit operator OneOrManyAlumniOf (Organization value) { return new OneOrManyAlumniOf (new AlumniOfOrganization (value)); }
            public static implicit operator OneOrManyAlumniOf (Organization[] values) { return new OneOrManyAlumniOf (values.Select(v => (IAlumniOf) new AlumniOfOrganization (v))); }
            public static implicit operator OneOrManyAlumniOf (List<Organization> values) { return new OneOrManyAlumniOf (values.Select(v => (IAlumniOf) new AlumniOfOrganization (v))); }
        }
        public struct AlumniOfEducationalOrganization : IAlumniOf<EducationalOrganization>
        {
            object IValue.Value => this.Value;
            public EducationalOrganization Value { get; }
            public AlumniOfEducationalOrganization (EducationalOrganization value) { Value = value; }
            public static implicit operator AlumniOfEducationalOrganization (EducationalOrganization value) { return new AlumniOfEducationalOrganization (value); }
        }
        public struct AlumniOfOrganization : IAlumniOf<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public AlumniOfOrganization (Organization value) { Value = value; }
            public static implicit operator AlumniOfOrganization (Organization value) { return new AlumniOfOrganization (value); }
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

        public interface IBirthDate : IValue {}
        public interface IBirthDate<T> : IBirthDate { new T Value { get; } }
        public class OneOrManyBirthDate : OneOrMany<IBirthDate>
        {
            public OneOrManyBirthDate(IBirthDate item) : base(item) { }
            public OneOrManyBirthDate(IEnumerable<IBirthDate> items) : base(items) { }
            public static implicit operator OneOrManyBirthDate (DateTimeOffset value) { return new OneOrManyBirthDate (new BirthDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyBirthDate (DateTimeOffset[] values) { return new OneOrManyBirthDate (values.Select(v => (IBirthDate) new BirthDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyBirthDate (List<DateTimeOffset> values) { return new OneOrManyBirthDate (values.Select(v => (IBirthDate) new BirthDateDateTimeOffset (v))); }
        }
        public struct BirthDateDateTimeOffset : IBirthDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public BirthDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator BirthDateDateTimeOffset (DateTimeOffset value) { return new BirthDateDateTimeOffset (value); }
        }

        public interface IBirthPlace : IValue {}
        public interface IBirthPlace<T> : IBirthPlace { new T Value { get; } }
        public class OneOrManyBirthPlace : OneOrMany<IBirthPlace>
        {
            public OneOrManyBirthPlace(IBirthPlace item) : base(item) { }
            public OneOrManyBirthPlace(IEnumerable<IBirthPlace> items) : base(items) { }
            public static implicit operator OneOrManyBirthPlace (Place value) { return new OneOrManyBirthPlace (new BirthPlacePlace (value)); }
            public static implicit operator OneOrManyBirthPlace (Place[] values) { return new OneOrManyBirthPlace (values.Select(v => (IBirthPlace) new BirthPlacePlace (v))); }
            public static implicit operator OneOrManyBirthPlace (List<Place> values) { return new OneOrManyBirthPlace (values.Select(v => (IBirthPlace) new BirthPlacePlace (v))); }
        }
        public struct BirthPlacePlace : IBirthPlace<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public BirthPlacePlace (Place value) { Value = value; }
            public static implicit operator BirthPlacePlace (Place value) { return new BirthPlacePlace (value); }
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

        public interface IChildren : IValue {}
        public interface IChildren<T> : IChildren { new T Value { get; } }
        public class OneOrManyChildren : OneOrMany<IChildren>
        {
            public OneOrManyChildren(IChildren item) : base(item) { }
            public OneOrManyChildren(IEnumerable<IChildren> items) : base(items) { }
            public static implicit operator OneOrManyChildren (Person value) { return new OneOrManyChildren (new ChildrenPerson (value)); }
            public static implicit operator OneOrManyChildren (Person[] values) { return new OneOrManyChildren (values.Select(v => (IChildren) new ChildrenPerson (v))); }
            public static implicit operator OneOrManyChildren (List<Person> values) { return new OneOrManyChildren (values.Select(v => (IChildren) new ChildrenPerson (v))); }
        }
        public struct ChildrenPerson : IChildren<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ChildrenPerson (Person value) { Value = value; }
            public static implicit operator ChildrenPerson (Person value) { return new ChildrenPerson (value); }
        }

        public interface IColleague : IValue {}
        public interface IColleague<T> : IColleague { new T Value { get; } }
        public class OneOrManyColleague : OneOrMany<IColleague>
        {
            public OneOrManyColleague(IColleague item) : base(item) { }
            public OneOrManyColleague(IEnumerable<IColleague> items) : base(items) { }
            public static implicit operator OneOrManyColleague (Person value) { return new OneOrManyColleague (new ColleaguePerson (value)); }
            public static implicit operator OneOrManyColleague (Person[] values) { return new OneOrManyColleague (values.Select(v => (IColleague) new ColleaguePerson (v))); }
            public static implicit operator OneOrManyColleague (List<Person> values) { return new OneOrManyColleague (values.Select(v => (IColleague) new ColleaguePerson (v))); }
            public static implicit operator OneOrManyColleague (Uri value) { return new OneOrManyColleague (new ColleagueUri (value)); }
            public static implicit operator OneOrManyColleague (Uri[] values) { return new OneOrManyColleague (values.Select(v => (IColleague) new ColleagueUri (v))); }
            public static implicit operator OneOrManyColleague (List<Uri> values) { return new OneOrManyColleague (values.Select(v => (IColleague) new ColleagueUri (v))); }
        }
        public struct ColleaguePerson : IColleague<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ColleaguePerson (Person value) { Value = value; }
            public static implicit operator ColleaguePerson (Person value) { return new ColleaguePerson (value); }
        }
        public struct ColleagueUri : IColleague<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public ColleagueUri (Uri value) { Value = value; }
            public static implicit operator ColleagueUri (Uri value) { return new ColleagueUri (value); }
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

        public interface IDeathDate : IValue {}
        public interface IDeathDate<T> : IDeathDate { new T Value { get; } }
        public class OneOrManyDeathDate : OneOrMany<IDeathDate>
        {
            public OneOrManyDeathDate(IDeathDate item) : base(item) { }
            public OneOrManyDeathDate(IEnumerable<IDeathDate> items) : base(items) { }
            public static implicit operator OneOrManyDeathDate (DateTimeOffset value) { return new OneOrManyDeathDate (new DeathDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyDeathDate (DateTimeOffset[] values) { return new OneOrManyDeathDate (values.Select(v => (IDeathDate) new DeathDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyDeathDate (List<DateTimeOffset> values) { return new OneOrManyDeathDate (values.Select(v => (IDeathDate) new DeathDateDateTimeOffset (v))); }
        }
        public struct DeathDateDateTimeOffset : IDeathDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public DeathDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator DeathDateDateTimeOffset (DateTimeOffset value) { return new DeathDateDateTimeOffset (value); }
        }

        public interface IDeathPlace : IValue {}
        public interface IDeathPlace<T> : IDeathPlace { new T Value { get; } }
        public class OneOrManyDeathPlace : OneOrMany<IDeathPlace>
        {
            public OneOrManyDeathPlace(IDeathPlace item) : base(item) { }
            public OneOrManyDeathPlace(IEnumerable<IDeathPlace> items) : base(items) { }
            public static implicit operator OneOrManyDeathPlace (Place value) { return new OneOrManyDeathPlace (new DeathPlacePlace (value)); }
            public static implicit operator OneOrManyDeathPlace (Place[] values) { return new OneOrManyDeathPlace (values.Select(v => (IDeathPlace) new DeathPlacePlace (v))); }
            public static implicit operator OneOrManyDeathPlace (List<Place> values) { return new OneOrManyDeathPlace (values.Select(v => (IDeathPlace) new DeathPlacePlace (v))); }
        }
        public struct DeathPlacePlace : IDeathPlace<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public DeathPlacePlace (Place value) { Value = value; }
            public static implicit operator DeathPlacePlace (Place value) { return new DeathPlacePlace (value); }
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

        public interface IFamilyName : IValue {}
        public interface IFamilyName<T> : IFamilyName { new T Value { get; } }
        public class OneOrManyFamilyName : OneOrMany<IFamilyName>
        {
            public OneOrManyFamilyName(IFamilyName item) : base(item) { }
            public OneOrManyFamilyName(IEnumerable<IFamilyName> items) : base(items) { }
            public static implicit operator OneOrManyFamilyName (string value) { return new OneOrManyFamilyName (new FamilyNamestring (value)); }
            public static implicit operator OneOrManyFamilyName (string[] values) { return new OneOrManyFamilyName (values.Select(v => (IFamilyName) new FamilyNamestring (v))); }
            public static implicit operator OneOrManyFamilyName (List<string> values) { return new OneOrManyFamilyName (values.Select(v => (IFamilyName) new FamilyNamestring (v))); }
        }
        public struct FamilyNamestring : IFamilyName<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public FamilyNamestring (string value) { Value = value; }
            public static implicit operator FamilyNamestring (string value) { return new FamilyNamestring (value); }
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

        public interface IFollows : IValue {}
        public interface IFollows<T> : IFollows { new T Value { get; } }
        public class OneOrManyFollows : OneOrMany<IFollows>
        {
            public OneOrManyFollows(IFollows item) : base(item) { }
            public OneOrManyFollows(IEnumerable<IFollows> items) : base(items) { }
            public static implicit operator OneOrManyFollows (Person value) { return new OneOrManyFollows (new FollowsPerson (value)); }
            public static implicit operator OneOrManyFollows (Person[] values) { return new OneOrManyFollows (values.Select(v => (IFollows) new FollowsPerson (v))); }
            public static implicit operator OneOrManyFollows (List<Person> values) { return new OneOrManyFollows (values.Select(v => (IFollows) new FollowsPerson (v))); }
        }
        public struct FollowsPerson : IFollows<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public FollowsPerson (Person value) { Value = value; }
            public static implicit operator FollowsPerson (Person value) { return new FollowsPerson (value); }
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

        public interface IGender : IValue {}
        public interface IGender<T> : IGender { new T Value { get; } }
        public class OneOrManyGender : OneOrMany<IGender>
        {
            public OneOrManyGender(IGender item) : base(item) { }
            public OneOrManyGender(IEnumerable<IGender> items) : base(items) { }
            public static implicit operator OneOrManyGender (GenderType value) { return new OneOrManyGender (new GenderGenderType (value)); }
            public static implicit operator OneOrManyGender (GenderType[] values) { return new OneOrManyGender (values.Select(v => (IGender) new GenderGenderType (v))); }
            public static implicit operator OneOrManyGender (List<GenderType> values) { return new OneOrManyGender (values.Select(v => (IGender) new GenderGenderType (v))); }
            public static implicit operator OneOrManyGender (string value) { return new OneOrManyGender (new Genderstring (value)); }
            public static implicit operator OneOrManyGender (string[] values) { return new OneOrManyGender (values.Select(v => (IGender) new Genderstring (v))); }
            public static implicit operator OneOrManyGender (List<string> values) { return new OneOrManyGender (values.Select(v => (IGender) new Genderstring (v))); }
        }
        public struct GenderGenderType : IGender<GenderType>
        {
            object IValue.Value => this.Value;
            public GenderType Value { get; }
            public GenderGenderType (GenderType value) { Value = value; }
            public static implicit operator GenderGenderType (GenderType value) { return new GenderGenderType (value); }
        }
        public struct Genderstring : IGender<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Genderstring (string value) { Value = value; }
            public static implicit operator Genderstring (string value) { return new Genderstring (value); }
        }

        public interface IGivenName : IValue {}
        public interface IGivenName<T> : IGivenName { new T Value { get; } }
        public class OneOrManyGivenName : OneOrMany<IGivenName>
        {
            public OneOrManyGivenName(IGivenName item) : base(item) { }
            public OneOrManyGivenName(IEnumerable<IGivenName> items) : base(items) { }
            public static implicit operator OneOrManyGivenName (string value) { return new OneOrManyGivenName (new GivenNamestring (value)); }
            public static implicit operator OneOrManyGivenName (string[] values) { return new OneOrManyGivenName (values.Select(v => (IGivenName) new GivenNamestring (v))); }
            public static implicit operator OneOrManyGivenName (List<string> values) { return new OneOrManyGivenName (values.Select(v => (IGivenName) new GivenNamestring (v))); }
        }
        public struct GivenNamestring : IGivenName<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public GivenNamestring (string value) { Value = value; }
            public static implicit operator GivenNamestring (string value) { return new GivenNamestring (value); }
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

        public interface IHeight : IValue {}
        public interface IHeight<T> : IHeight { new T Value { get; } }
        public class OneOrManyHeight : OneOrMany<IHeight>
        {
            public OneOrManyHeight(IHeight item) : base(item) { }
            public OneOrManyHeight(IEnumerable<IHeight> items) : base(items) { }
            public static implicit operator OneOrManyHeight (string value) { return new OneOrManyHeight (new Heightstring (value)); }
            public static implicit operator OneOrManyHeight (string[] values) { return new OneOrManyHeight (values.Select(v => (IHeight) new Heightstring (v))); }
            public static implicit operator OneOrManyHeight (List<string> values) { return new OneOrManyHeight (values.Select(v => (IHeight) new Heightstring (v))); }
            public static implicit operator OneOrManyHeight (QuantitativeValue value) { return new OneOrManyHeight (new HeightQuantitativeValue (value)); }
            public static implicit operator OneOrManyHeight (QuantitativeValue[] values) { return new OneOrManyHeight (values.Select(v => (IHeight) new HeightQuantitativeValue (v))); }
            public static implicit operator OneOrManyHeight (List<QuantitativeValue> values) { return new OneOrManyHeight (values.Select(v => (IHeight) new HeightQuantitativeValue (v))); }
        }
        public struct Heightstring : IHeight<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Heightstring (string value) { Value = value; }
            public static implicit operator Heightstring (string value) { return new Heightstring (value); }
        }
        public struct HeightQuantitativeValue : IHeight<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public HeightQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator HeightQuantitativeValue (QuantitativeValue value) { return new HeightQuantitativeValue (value); }
        }

        public interface IHomeLocation : IValue {}
        public interface IHomeLocation<T> : IHomeLocation { new T Value { get; } }
        public class OneOrManyHomeLocation : OneOrMany<IHomeLocation>
        {
            public OneOrManyHomeLocation(IHomeLocation item) : base(item) { }
            public OneOrManyHomeLocation(IEnumerable<IHomeLocation> items) : base(items) { }
            public static implicit operator OneOrManyHomeLocation (ContactPoint value) { return new OneOrManyHomeLocation (new HomeLocationContactPoint (value)); }
            public static implicit operator OneOrManyHomeLocation (ContactPoint[] values) { return new OneOrManyHomeLocation (values.Select(v => (IHomeLocation) new HomeLocationContactPoint (v))); }
            public static implicit operator OneOrManyHomeLocation (List<ContactPoint> values) { return new OneOrManyHomeLocation (values.Select(v => (IHomeLocation) new HomeLocationContactPoint (v))); }
            public static implicit operator OneOrManyHomeLocation (Place value) { return new OneOrManyHomeLocation (new HomeLocationPlace (value)); }
            public static implicit operator OneOrManyHomeLocation (Place[] values) { return new OneOrManyHomeLocation (values.Select(v => (IHomeLocation) new HomeLocationPlace (v))); }
            public static implicit operator OneOrManyHomeLocation (List<Place> values) { return new OneOrManyHomeLocation (values.Select(v => (IHomeLocation) new HomeLocationPlace (v))); }
        }
        public struct HomeLocationContactPoint : IHomeLocation<ContactPoint>
        {
            object IValue.Value => this.Value;
            public ContactPoint Value { get; }
            public HomeLocationContactPoint (ContactPoint value) { Value = value; }
            public static implicit operator HomeLocationContactPoint (ContactPoint value) { return new HomeLocationContactPoint (value); }
        }
        public struct HomeLocationPlace : IHomeLocation<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public HomeLocationPlace (Place value) { Value = value; }
            public static implicit operator HomeLocationPlace (Place value) { return new HomeLocationPlace (value); }
        }

        public interface IHonorificPrefix : IValue {}
        public interface IHonorificPrefix<T> : IHonorificPrefix { new T Value { get; } }
        public class OneOrManyHonorificPrefix : OneOrMany<IHonorificPrefix>
        {
            public OneOrManyHonorificPrefix(IHonorificPrefix item) : base(item) { }
            public OneOrManyHonorificPrefix(IEnumerable<IHonorificPrefix> items) : base(items) { }
            public static implicit operator OneOrManyHonorificPrefix (string value) { return new OneOrManyHonorificPrefix (new HonorificPrefixstring (value)); }
            public static implicit operator OneOrManyHonorificPrefix (string[] values) { return new OneOrManyHonorificPrefix (values.Select(v => (IHonorificPrefix) new HonorificPrefixstring (v))); }
            public static implicit operator OneOrManyHonorificPrefix (List<string> values) { return new OneOrManyHonorificPrefix (values.Select(v => (IHonorificPrefix) new HonorificPrefixstring (v))); }
        }
        public struct HonorificPrefixstring : IHonorificPrefix<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public HonorificPrefixstring (string value) { Value = value; }
            public static implicit operator HonorificPrefixstring (string value) { return new HonorificPrefixstring (value); }
        }

        public interface IHonorificSuffix : IValue {}
        public interface IHonorificSuffix<T> : IHonorificSuffix { new T Value { get; } }
        public class OneOrManyHonorificSuffix : OneOrMany<IHonorificSuffix>
        {
            public OneOrManyHonorificSuffix(IHonorificSuffix item) : base(item) { }
            public OneOrManyHonorificSuffix(IEnumerable<IHonorificSuffix> items) : base(items) { }
            public static implicit operator OneOrManyHonorificSuffix (string value) { return new OneOrManyHonorificSuffix (new HonorificSuffixstring (value)); }
            public static implicit operator OneOrManyHonorificSuffix (string[] values) { return new OneOrManyHonorificSuffix (values.Select(v => (IHonorificSuffix) new HonorificSuffixstring (v))); }
            public static implicit operator OneOrManyHonorificSuffix (List<string> values) { return new OneOrManyHonorificSuffix (values.Select(v => (IHonorificSuffix) new HonorificSuffixstring (v))); }
        }
        public struct HonorificSuffixstring : IHonorificSuffix<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public HonorificSuffixstring (string value) { Value = value; }
            public static implicit operator HonorificSuffixstring (string value) { return new HonorificSuffixstring (value); }
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

        public interface IJobTitle : IValue {}
        public interface IJobTitle<T> : IJobTitle { new T Value { get; } }
        public class OneOrManyJobTitle : OneOrMany<IJobTitle>
        {
            public OneOrManyJobTitle(IJobTitle item) : base(item) { }
            public OneOrManyJobTitle(IEnumerable<IJobTitle> items) : base(items) { }
            public static implicit operator OneOrManyJobTitle (string value) { return new OneOrManyJobTitle (new JobTitlestring (value)); }
            public static implicit operator OneOrManyJobTitle (string[] values) { return new OneOrManyJobTitle (values.Select(v => (IJobTitle) new JobTitlestring (v))); }
            public static implicit operator OneOrManyJobTitle (List<string> values) { return new OneOrManyJobTitle (values.Select(v => (IJobTitle) new JobTitlestring (v))); }
        }
        public struct JobTitlestring : IJobTitle<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public JobTitlestring (string value) { Value = value; }
            public static implicit operator JobTitlestring (string value) { return new JobTitlestring (value); }
        }

        public interface IKnows : IValue {}
        public interface IKnows<T> : IKnows { new T Value { get; } }
        public class OneOrManyKnows : OneOrMany<IKnows>
        {
            public OneOrManyKnows(IKnows item) : base(item) { }
            public OneOrManyKnows(IEnumerable<IKnows> items) : base(items) { }
            public static implicit operator OneOrManyKnows (Person value) { return new OneOrManyKnows (new KnowsPerson (value)); }
            public static implicit operator OneOrManyKnows (Person[] values) { return new OneOrManyKnows (values.Select(v => (IKnows) new KnowsPerson (v))); }
            public static implicit operator OneOrManyKnows (List<Person> values) { return new OneOrManyKnows (values.Select(v => (IKnows) new KnowsPerson (v))); }
        }
        public struct KnowsPerson : IKnows<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public KnowsPerson (Person value) { Value = value; }
            public static implicit operator KnowsPerson (Person value) { return new KnowsPerson (value); }
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

        public interface INationality : IValue {}
        public interface INationality<T> : INationality { new T Value { get; } }
        public class OneOrManyNationality : OneOrMany<INationality>
        {
            public OneOrManyNationality(INationality item) : base(item) { }
            public OneOrManyNationality(IEnumerable<INationality> items) : base(items) { }
            public static implicit operator OneOrManyNationality (Country value) { return new OneOrManyNationality (new NationalityCountry (value)); }
            public static implicit operator OneOrManyNationality (Country[] values) { return new OneOrManyNationality (values.Select(v => (INationality) new NationalityCountry (v))); }
            public static implicit operator OneOrManyNationality (List<Country> values) { return new OneOrManyNationality (values.Select(v => (INationality) new NationalityCountry (v))); }
        }
        public struct NationalityCountry : INationality<Country>
        {
            object IValue.Value => this.Value;
            public Country Value { get; }
            public NationalityCountry (Country value) { Value = value; }
            public static implicit operator NationalityCountry (Country value) { return new NationalityCountry (value); }
        }

        public interface INetWorth : IValue {}
        public interface INetWorth<T> : INetWorth { new T Value { get; } }
        public class OneOrManyNetWorth : OneOrMany<INetWorth>
        {
            public OneOrManyNetWorth(INetWorth item) : base(item) { }
            public OneOrManyNetWorth(IEnumerable<INetWorth> items) : base(items) { }
            public static implicit operator OneOrManyNetWorth (MonetaryAmount value) { return new OneOrManyNetWorth (new NetWorthMonetaryAmount (value)); }
            public static implicit operator OneOrManyNetWorth (MonetaryAmount[] values) { return new OneOrManyNetWorth (values.Select(v => (INetWorth) new NetWorthMonetaryAmount (v))); }
            public static implicit operator OneOrManyNetWorth (List<MonetaryAmount> values) { return new OneOrManyNetWorth (values.Select(v => (INetWorth) new NetWorthMonetaryAmount (v))); }
            public static implicit operator OneOrManyNetWorth (PriceSpecification value) { return new OneOrManyNetWorth (new NetWorthPriceSpecification (value)); }
            public static implicit operator OneOrManyNetWorth (PriceSpecification[] values) { return new OneOrManyNetWorth (values.Select(v => (INetWorth) new NetWorthPriceSpecification (v))); }
            public static implicit operator OneOrManyNetWorth (List<PriceSpecification> values) { return new OneOrManyNetWorth (values.Select(v => (INetWorth) new NetWorthPriceSpecification (v))); }
        }
        public struct NetWorthMonetaryAmount : INetWorth<MonetaryAmount>
        {
            object IValue.Value => this.Value;
            public MonetaryAmount Value { get; }
            public NetWorthMonetaryAmount (MonetaryAmount value) { Value = value; }
            public static implicit operator NetWorthMonetaryAmount (MonetaryAmount value) { return new NetWorthMonetaryAmount (value); }
        }
        public struct NetWorthPriceSpecification : INetWorth<PriceSpecification>
        {
            object IValue.Value => this.Value;
            public PriceSpecification Value { get; }
            public NetWorthPriceSpecification (PriceSpecification value) { Value = value; }
            public static implicit operator NetWorthPriceSpecification (PriceSpecification value) { return new NetWorthPriceSpecification (value); }
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

        public interface IParent : IValue {}
        public interface IParent<T> : IParent { new T Value { get; } }
        public class OneOrManyParent : OneOrMany<IParent>
        {
            public OneOrManyParent(IParent item) : base(item) { }
            public OneOrManyParent(IEnumerable<IParent> items) : base(items) { }
            public static implicit operator OneOrManyParent (Person value) { return new OneOrManyParent (new ParentPerson (value)); }
            public static implicit operator OneOrManyParent (Person[] values) { return new OneOrManyParent (values.Select(v => (IParent) new ParentPerson (v))); }
            public static implicit operator OneOrManyParent (List<Person> values) { return new OneOrManyParent (values.Select(v => (IParent) new ParentPerson (v))); }
        }
        public struct ParentPerson : IParent<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ParentPerson (Person value) { Value = value; }
            public static implicit operator ParentPerson (Person value) { return new ParentPerson (value); }
        }

        public interface IPerformerIn : IValue {}
        public interface IPerformerIn<T> : IPerformerIn { new T Value { get; } }
        public class OneOrManyPerformerIn : OneOrMany<IPerformerIn>
        {
            public OneOrManyPerformerIn(IPerformerIn item) : base(item) { }
            public OneOrManyPerformerIn(IEnumerable<IPerformerIn> items) : base(items) { }
            public static implicit operator OneOrManyPerformerIn (Event value) { return new OneOrManyPerformerIn (new PerformerInEvent (value)); }
            public static implicit operator OneOrManyPerformerIn (Event[] values) { return new OneOrManyPerformerIn (values.Select(v => (IPerformerIn) new PerformerInEvent (v))); }
            public static implicit operator OneOrManyPerformerIn (List<Event> values) { return new OneOrManyPerformerIn (values.Select(v => (IPerformerIn) new PerformerInEvent (v))); }
        }
        public struct PerformerInEvent : IPerformerIn<Event>
        {
            object IValue.Value => this.Value;
            public Event Value { get; }
            public PerformerInEvent (Event value) { Value = value; }
            public static implicit operator PerformerInEvent (Event value) { return new PerformerInEvent (value); }
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

        public interface IRelatedTo : IValue {}
        public interface IRelatedTo<T> : IRelatedTo { new T Value { get; } }
        public class OneOrManyRelatedTo : OneOrMany<IRelatedTo>
        {
            public OneOrManyRelatedTo(IRelatedTo item) : base(item) { }
            public OneOrManyRelatedTo(IEnumerable<IRelatedTo> items) : base(items) { }
            public static implicit operator OneOrManyRelatedTo (Person value) { return new OneOrManyRelatedTo (new RelatedToPerson (value)); }
            public static implicit operator OneOrManyRelatedTo (Person[] values) { return new OneOrManyRelatedTo (values.Select(v => (IRelatedTo) new RelatedToPerson (v))); }
            public static implicit operator OneOrManyRelatedTo (List<Person> values) { return new OneOrManyRelatedTo (values.Select(v => (IRelatedTo) new RelatedToPerson (v))); }
        }
        public struct RelatedToPerson : IRelatedTo<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public RelatedToPerson (Person value) { Value = value; }
            public static implicit operator RelatedToPerson (Person value) { return new RelatedToPerson (value); }
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

        public interface ISibling : IValue {}
        public interface ISibling<T> : ISibling { new T Value { get; } }
        public class OneOrManySibling : OneOrMany<ISibling>
        {
            public OneOrManySibling(ISibling item) : base(item) { }
            public OneOrManySibling(IEnumerable<ISibling> items) : base(items) { }
            public static implicit operator OneOrManySibling (Person value) { return new OneOrManySibling (new SiblingPerson (value)); }
            public static implicit operator OneOrManySibling (Person[] values) { return new OneOrManySibling (values.Select(v => (ISibling) new SiblingPerson (v))); }
            public static implicit operator OneOrManySibling (List<Person> values) { return new OneOrManySibling (values.Select(v => (ISibling) new SiblingPerson (v))); }
        }
        public struct SiblingPerson : ISibling<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public SiblingPerson (Person value) { Value = value; }
            public static implicit operator SiblingPerson (Person value) { return new SiblingPerson (value); }
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

        public interface ISpouse : IValue {}
        public interface ISpouse<T> : ISpouse { new T Value { get; } }
        public class OneOrManySpouse : OneOrMany<ISpouse>
        {
            public OneOrManySpouse(ISpouse item) : base(item) { }
            public OneOrManySpouse(IEnumerable<ISpouse> items) : base(items) { }
            public static implicit operator OneOrManySpouse (Person value) { return new OneOrManySpouse (new SpousePerson (value)); }
            public static implicit operator OneOrManySpouse (Person[] values) { return new OneOrManySpouse (values.Select(v => (ISpouse) new SpousePerson (v))); }
            public static implicit operator OneOrManySpouse (List<Person> values) { return new OneOrManySpouse (values.Select(v => (ISpouse) new SpousePerson (v))); }
        }
        public struct SpousePerson : ISpouse<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public SpousePerson (Person value) { Value = value; }
            public static implicit operator SpousePerson (Person value) { return new SpousePerson (value); }
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

        public interface IWeight : IValue {}
        public interface IWeight<T> : IWeight { new T Value { get; } }
        public class OneOrManyWeight : OneOrMany<IWeight>
        {
            public OneOrManyWeight(IWeight item) : base(item) { }
            public OneOrManyWeight(IEnumerable<IWeight> items) : base(items) { }
            public static implicit operator OneOrManyWeight (QuantitativeValue value) { return new OneOrManyWeight (new WeightQuantitativeValue (value)); }
            public static implicit operator OneOrManyWeight (QuantitativeValue[] values) { return new OneOrManyWeight (values.Select(v => (IWeight) new WeightQuantitativeValue (v))); }
            public static implicit operator OneOrManyWeight (List<QuantitativeValue> values) { return new OneOrManyWeight (values.Select(v => (IWeight) new WeightQuantitativeValue (v))); }
        }
        public struct WeightQuantitativeValue : IWeight<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public WeightQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator WeightQuantitativeValue (QuantitativeValue value) { return new WeightQuantitativeValue (value); }
        }

        public interface IWorkLocation : IValue {}
        public interface IWorkLocation<T> : IWorkLocation { new T Value { get; } }
        public class OneOrManyWorkLocation : OneOrMany<IWorkLocation>
        {
            public OneOrManyWorkLocation(IWorkLocation item) : base(item) { }
            public OneOrManyWorkLocation(IEnumerable<IWorkLocation> items) : base(items) { }
            public static implicit operator OneOrManyWorkLocation (ContactPoint value) { return new OneOrManyWorkLocation (new WorkLocationContactPoint (value)); }
            public static implicit operator OneOrManyWorkLocation (ContactPoint[] values) { return new OneOrManyWorkLocation (values.Select(v => (IWorkLocation) new WorkLocationContactPoint (v))); }
            public static implicit operator OneOrManyWorkLocation (List<ContactPoint> values) { return new OneOrManyWorkLocation (values.Select(v => (IWorkLocation) new WorkLocationContactPoint (v))); }
            public static implicit operator OneOrManyWorkLocation (Place value) { return new OneOrManyWorkLocation (new WorkLocationPlace (value)); }
            public static implicit operator OneOrManyWorkLocation (Place[] values) { return new OneOrManyWorkLocation (values.Select(v => (IWorkLocation) new WorkLocationPlace (v))); }
            public static implicit operator OneOrManyWorkLocation (List<Place> values) { return new OneOrManyWorkLocation (values.Select(v => (IWorkLocation) new WorkLocationPlace (v))); }
        }
        public struct WorkLocationContactPoint : IWorkLocation<ContactPoint>
        {
            object IValue.Value => this.Value;
            public ContactPoint Value { get; }
            public WorkLocationContactPoint (ContactPoint value) { Value = value; }
            public static implicit operator WorkLocationContactPoint (ContactPoint value) { return new WorkLocationContactPoint (value); }
        }
        public struct WorkLocationPlace : IWorkLocation<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public WorkLocationPlace (Place value) { Value = value; }
            public static implicit operator WorkLocationPlace (Place value) { return new WorkLocationPlace (value); }
        }

        public interface IWorksFor : IValue {}
        public interface IWorksFor<T> : IWorksFor { new T Value { get; } }
        public class OneOrManyWorksFor : OneOrMany<IWorksFor>
        {
            public OneOrManyWorksFor(IWorksFor item) : base(item) { }
            public OneOrManyWorksFor(IEnumerable<IWorksFor> items) : base(items) { }
            public static implicit operator OneOrManyWorksFor (Organization value) { return new OneOrManyWorksFor (new WorksForOrganization (value)); }
            public static implicit operator OneOrManyWorksFor (Organization[] values) { return new OneOrManyWorksFor (values.Select(v => (IWorksFor) new WorksForOrganization (v))); }
            public static implicit operator OneOrManyWorksFor (List<Organization> values) { return new OneOrManyWorksFor (values.Select(v => (IWorksFor) new WorksForOrganization (v))); }
        }
        public struct WorksForOrganization : IWorksFor<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public WorksForOrganization (Organization value) { Value = value; }
            public static implicit operator WorksForOrganization (Organization value) { return new WorksForOrganization (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Person";

        /// <summary>
        /// An additional name for a Person, can be used for a middle name.
        /// </summary>
        [DataMember(Name = "additionalName", Order = 106)]
        public OneOrManyAdditionalName AdditionalName { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 107)]
        public OneOrManyAddress Address { get; set; }

        /// <summary>
        /// An organization that this person is affiliated with. For example, a school/university, a club, or a team.
        /// </summary>
        [DataMember(Name = "affiliation", Order = 108)]
        public OneOrManyAffiliation Affiliation { get; set; }

        /// <summary>
        /// An organization that the person is an alumni of.
        /// </summary>
        [DataMember(Name = "alumniOf", Order = 109)]
        public OneOrManyAlumniOf AlumniOf { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 110)]
        public OneOrManyAward Award { get; set; }

        /// <summary>
        /// Date of birth.
        /// </summary>
        [DataMember(Name = "birthDate", Order = 111)]
        public OneOrManyBirthDate BirthDate { get; set; }

        /// <summary>
        /// The place where the person was born.
        /// </summary>
        [DataMember(Name = "birthPlace", Order = 112)]
        public OneOrManyBirthPlace BirthPlace { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 113)]
        public OneOrManyBrand Brand { get; set; }

        /// <summary>
        /// A child of the person.
        /// </summary>
        [DataMember(Name = "children", Order = 114)]
        public OneOrManyChildren Children { get; set; }

        /// <summary>
        /// A colleague of the person.
        /// </summary>
        [DataMember(Name = "colleague", Order = 115)]
        public OneOrManyColleague Colleague { get; set; }

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        [DataMember(Name = "contactPoint", Order = 116)]
        public OneOrManyContactPoint ContactPoint { get; set; }

        /// <summary>
        /// Date of death.
        /// </summary>
        [DataMember(Name = "deathDate", Order = 117)]
        public OneOrManyDeathDate DeathDate { get; set; }

        /// <summary>
        /// The place where the person died.
        /// </summary>
        [DataMember(Name = "deathPlace", Order = 118)]
        public OneOrManyDeathPlace DeathPlace { get; set; }

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
        /// Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the name property.
        /// </summary>
        [DataMember(Name = "familyName", Order = 121)]
        public OneOrManyFamilyName FamilyName { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 122)]
        public OneOrManyFaxNumber FaxNumber { get; set; }

        /// <summary>
        /// The most generic uni-directional social relation.
        /// </summary>
        [DataMember(Name = "follows", Order = 123)]
        public OneOrManyFollows Follows { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 124)]
        public OneOrManyFunder Funder { get; set; }

        /// <summary>
        /// Gender of the person. While http://schema.org/Male and http://schema.org/Female may be used, text strings are also acceptable for people who do not identify as a binary gender.
        /// </summary>
        [DataMember(Name = "gender", Order = 125)]
        public OneOrManyGender Gender { get; set; }

        /// <summary>
        /// Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the name property.
        /// </summary>
        [DataMember(Name = "givenName", Order = 126)]
        public OneOrManyGivenName GivenName { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber", Order = 127)]
        public OneOrManyGlobalLocationNumber GlobalLocationNumber { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [DataMember(Name = "hasOfferCatalog", Order = 128)]
        public OneOrManyHasOfferCatalog HasOfferCatalog { get; set; }

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        [DataMember(Name = "hasPOS", Order = 129)]
        public OneOrManyHasPOS HasPOS { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [DataMember(Name = "height", Order = 130)]
        public OneOrManyHeight Height { get; set; }

        /// <summary>
        /// A contact location for a person's residence.
        /// </summary>
        [DataMember(Name = "homeLocation", Order = 131)]
        public OneOrManyHomeLocation HomeLocation { get; set; }

        /// <summary>
        /// An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.
        /// </summary>
        [DataMember(Name = "honorificPrefix", Order = 132)]
        public OneOrManyHonorificPrefix HonorificPrefix { get; set; }

        /// <summary>
        /// An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.
        /// </summary>
        [DataMember(Name = "honorificSuffix", Order = 133)]
        public OneOrManyHonorificSuffix HonorificSuffix { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4", Order = 134)]
        public OneOrManyIsicV4 IsicV4 { get; set; }

        /// <summary>
        /// The job title of the person (for example, Financial Manager).
        /// </summary>
        [DataMember(Name = "jobTitle", Order = 135)]
        public OneOrManyJobTitle JobTitle { get; set; }

        /// <summary>
        /// The most generic bi-directional social/work relation.
        /// </summary>
        [DataMember(Name = "knows", Order = 136)]
        public OneOrManyKnows Knows { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a topic that is known about - suggesting possible expertise but not implying it. We do not distinguish skill levels here, or yet relate this to educational content, events, objectives or &lt;a class="localLink" href="http://schema.org/JobPosting"&gt;JobPosting&lt;/a&gt; descriptions.
        /// </summary>
        [DataMember(Name = "knowsAbout", Order = 137)]
        public OneOrManyKnowsAbout KnowsAbout { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a known language. We do not distinguish skill levels or reading/writing/speaking/signing here. Use language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "knowsLanguage", Order = 138)]
        public OneOrManyKnowsLanguage KnowsLanguage { get; set; }

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        [DataMember(Name = "makesOffer", Order = 139)]
        public OneOrManyMakesOffer MakesOffer { get; set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        [DataMember(Name = "memberOf", Order = 140)]
        public OneOrManyMemberOf MemberOf { get; set; }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        [DataMember(Name = "naics", Order = 141)]
        public OneOrManyNaics Naics { get; set; }

        /// <summary>
        /// Nationality of the person.
        /// </summary>
        [DataMember(Name = "nationality", Order = 142)]
        public OneOrManyNationality Nationality { get; set; }

        /// <summary>
        /// The total financial value of the person as calculated by subtracting assets from liabilities.
        /// </summary>
        [DataMember(Name = "netWorth", Order = 143)]
        public OneOrManyNetWorth NetWorth { get; set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        [DataMember(Name = "owns", Order = 144)]
        public OneOrManyOwns Owns { get; set; }

        /// <summary>
        /// A parent of this person.
        /// </summary>
        [DataMember(Name = "parent", Order = 145)]
        public OneOrManyParent Parent { get; set; }

        /// <summary>
        /// Event that this person is a performer or participant in.
        /// </summary>
        [DataMember(Name = "performerIn", Order = 146)]
        public OneOrManyPerformerIn PerformerIn { get; set; }

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        [DataMember(Name = "publishingPrinciples", Order = 147)]
        public OneOrManyPublishingPrinciples PublishingPrinciples { get; set; }

        /// <summary>
        /// The most generic familial relation.
        /// </summary>
        [DataMember(Name = "relatedTo", Order = 148)]
        public OneOrManyRelatedTo RelatedTo { get; set; }

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        [DataMember(Name = "seeks", Order = 149)]
        public OneOrManySeeks Seeks { get; set; }

        /// <summary>
        /// A sibling of the person.
        /// </summary>
        [DataMember(Name = "sibling", Order = 150)]
        public OneOrManySibling Sibling { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 151)]
        public OneOrManySponsor Sponsor { get; set; }

        /// <summary>
        /// The person's spouse.
        /// </summary>
        [DataMember(Name = "spouse", Order = 152)]
        public OneOrManySpouse Spouse { get; set; }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [DataMember(Name = "taxID", Order = 153)]
        public OneOrManyTaxID TaxID { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 154)]
        public OneOrManyTelephone Telephone { get; set; }

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        [DataMember(Name = "vatID", Order = 155)]
        public OneOrManyVatID VatID { get; set; }

        /// <summary>
        /// The weight of the product or person.
        /// </summary>
        [DataMember(Name = "weight", Order = 156)]
        public OneOrManyWeight Weight { get; set; }

        /// <summary>
        /// A contact location for a person's place of work.
        /// </summary>
        [DataMember(Name = "workLocation", Order = 157)]
        public OneOrManyWorkLocation WorkLocation { get; set; }

        /// <summary>
        /// Organizations that the person works for.
        /// </summary>
        [DataMember(Name = "worksFor", Order = 158)]
        public OneOrManyWorksFor WorksFor { get; set; }
    }
}
