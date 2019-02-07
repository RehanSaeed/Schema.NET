namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
    [DataContract]
    public partial class JobPosting : Intangible
    {
        public interface ITitle : IValue {}
        public interface ITitle<T> : ITitle { new T Value { get; } }
        public class OneOrManyTitle : OneOrMany<ITitle>
        {
            public OneOrManyTitle(ITitle item) : base(item) { }
            public OneOrManyTitle(IEnumerable<ITitle> items) : base(items) { }
            public static implicit operator OneOrManyTitle (string value) { return new OneOrManyTitle (new Titlestring (value)); }
            public static implicit operator OneOrManyTitle (string[] values) { return new OneOrManyTitle (values.Select(v => (ITitle) new Titlestring (v))); }
            public static implicit operator OneOrManyTitle (List<string> values) { return new OneOrManyTitle (values.Select(v => (ITitle) new Titlestring (v))); }
        }
        public struct Titlestring : ITitle<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Titlestring (string value) { Value = value; }
            public static implicit operator Titlestring (string value) { return new Titlestring (value); }
        }

        public interface IBaseSalary : IValue {}
        public interface IBaseSalary<T> : IBaseSalary { new T Value { get; } }
        public class OneOrManyBaseSalary : OneOrMany<IBaseSalary>
        {
            public OneOrManyBaseSalary(IBaseSalary item) : base(item) { }
            public OneOrManyBaseSalary(IEnumerable<IBaseSalary> items) : base(items) { }
            public static implicit operator OneOrManyBaseSalary (MonetaryAmount value) { return new OneOrManyBaseSalary (new BaseSalaryMonetaryAmount (value)); }
            public static implicit operator OneOrManyBaseSalary (MonetaryAmount[] values) { return new OneOrManyBaseSalary (values.Select(v => (IBaseSalary) new BaseSalaryMonetaryAmount (v))); }
            public static implicit operator OneOrManyBaseSalary (List<MonetaryAmount> values) { return new OneOrManyBaseSalary (values.Select(v => (IBaseSalary) new BaseSalaryMonetaryAmount (v))); }
            public static implicit operator OneOrManyBaseSalary (decimal value) { return new OneOrManyBaseSalary (new BaseSalarydecimal (value)); }
            public static implicit operator OneOrManyBaseSalary (decimal[] values) { return new OneOrManyBaseSalary (values.Select(v => (IBaseSalary) new BaseSalarydecimal (v))); }
            public static implicit operator OneOrManyBaseSalary (List<decimal> values) { return new OneOrManyBaseSalary (values.Select(v => (IBaseSalary) new BaseSalarydecimal (v))); }
            public static implicit operator OneOrManyBaseSalary (PriceSpecification value) { return new OneOrManyBaseSalary (new BaseSalaryPriceSpecification (value)); }
            public static implicit operator OneOrManyBaseSalary (PriceSpecification[] values) { return new OneOrManyBaseSalary (values.Select(v => (IBaseSalary) new BaseSalaryPriceSpecification (v))); }
            public static implicit operator OneOrManyBaseSalary (List<PriceSpecification> values) { return new OneOrManyBaseSalary (values.Select(v => (IBaseSalary) new BaseSalaryPriceSpecification (v))); }
        }
        public struct BaseSalaryMonetaryAmount : IBaseSalary<MonetaryAmount>
        {
            object IValue.Value => this.Value;
            public MonetaryAmount Value { get; }
            public BaseSalaryMonetaryAmount (MonetaryAmount value) { Value = value; }
            public static implicit operator BaseSalaryMonetaryAmount (MonetaryAmount value) { return new BaseSalaryMonetaryAmount (value); }
        }
        public struct BaseSalarydecimal : IBaseSalary<decimal>
        {
            object IValue.Value => this.Value;
            public decimal Value { get; }
            public BaseSalarydecimal (decimal value) { Value = value; }
            public static implicit operator BaseSalarydecimal (decimal value) { return new BaseSalarydecimal (value); }
        }
        public struct BaseSalaryPriceSpecification : IBaseSalary<PriceSpecification>
        {
            object IValue.Value => this.Value;
            public PriceSpecification Value { get; }
            public BaseSalaryPriceSpecification (PriceSpecification value) { Value = value; }
            public static implicit operator BaseSalaryPriceSpecification (PriceSpecification value) { return new BaseSalaryPriceSpecification (value); }
        }

        public interface IDatePosted : IValue {}
        public interface IDatePosted<T> : IDatePosted { new T Value { get; } }
        public class OneOrManyDatePosted : OneOrMany<IDatePosted>
        {
            public OneOrManyDatePosted(IDatePosted item) : base(item) { }
            public OneOrManyDatePosted(IEnumerable<IDatePosted> items) : base(items) { }
            public static implicit operator OneOrManyDatePosted (DateTimeOffset value) { return new OneOrManyDatePosted (new DatePostedDateTimeOffset (value)); }
            public static implicit operator OneOrManyDatePosted (DateTimeOffset[] values) { return new OneOrManyDatePosted (values.Select(v => (IDatePosted) new DatePostedDateTimeOffset (v))); }
            public static implicit operator OneOrManyDatePosted (List<DateTimeOffset> values) { return new OneOrManyDatePosted (values.Select(v => (IDatePosted) new DatePostedDateTimeOffset (v))); }
        }
        public struct DatePostedDateTimeOffset : IDatePosted<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public DatePostedDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator DatePostedDateTimeOffset (DateTimeOffset value) { return new DatePostedDateTimeOffset (value); }
        }

        public interface IEducationRequirements : IValue {}
        public interface IEducationRequirements<T> : IEducationRequirements { new T Value { get; } }
        public class OneOrManyEducationRequirements : OneOrMany<IEducationRequirements>
        {
            public OneOrManyEducationRequirements(IEducationRequirements item) : base(item) { }
            public OneOrManyEducationRequirements(IEnumerable<IEducationRequirements> items) : base(items) { }
            public static implicit operator OneOrManyEducationRequirements (string value) { return new OneOrManyEducationRequirements (new EducationRequirementsstring (value)); }
            public static implicit operator OneOrManyEducationRequirements (string[] values) { return new OneOrManyEducationRequirements (values.Select(v => (IEducationRequirements) new EducationRequirementsstring (v))); }
            public static implicit operator OneOrManyEducationRequirements (List<string> values) { return new OneOrManyEducationRequirements (values.Select(v => (IEducationRequirements) new EducationRequirementsstring (v))); }
        }
        public struct EducationRequirementsstring : IEducationRequirements<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public EducationRequirementsstring (string value) { Value = value; }
            public static implicit operator EducationRequirementsstring (string value) { return new EducationRequirementsstring (value); }
        }

        public interface IEmploymentType : IValue {}
        public interface IEmploymentType<T> : IEmploymentType { new T Value { get; } }
        public class OneOrManyEmploymentType : OneOrMany<IEmploymentType>
        {
            public OneOrManyEmploymentType(IEmploymentType item) : base(item) { }
            public OneOrManyEmploymentType(IEnumerable<IEmploymentType> items) : base(items) { }
            public static implicit operator OneOrManyEmploymentType (string value) { return new OneOrManyEmploymentType (new EmploymentTypestring (value)); }
            public static implicit operator OneOrManyEmploymentType (string[] values) { return new OneOrManyEmploymentType (values.Select(v => (IEmploymentType) new EmploymentTypestring (v))); }
            public static implicit operator OneOrManyEmploymentType (List<string> values) { return new OneOrManyEmploymentType (values.Select(v => (IEmploymentType) new EmploymentTypestring (v))); }
        }
        public struct EmploymentTypestring : IEmploymentType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public EmploymentTypestring (string value) { Value = value; }
            public static implicit operator EmploymentTypestring (string value) { return new EmploymentTypestring (value); }
        }

        public interface IEstimatedSalary : IValue {}
        public interface IEstimatedSalary<T> : IEstimatedSalary { new T Value { get; } }
        public class OneOrManyEstimatedSalary : OneOrMany<IEstimatedSalary>
        {
            public OneOrManyEstimatedSalary(IEstimatedSalary item) : base(item) { }
            public OneOrManyEstimatedSalary(IEnumerable<IEstimatedSalary> items) : base(items) { }
            public static implicit operator OneOrManyEstimatedSalary (MonetaryAmount value) { return new OneOrManyEstimatedSalary (new EstimatedSalaryMonetaryAmount (value)); }
            public static implicit operator OneOrManyEstimatedSalary (MonetaryAmount[] values) { return new OneOrManyEstimatedSalary (values.Select(v => (IEstimatedSalary) new EstimatedSalaryMonetaryAmount (v))); }
            public static implicit operator OneOrManyEstimatedSalary (List<MonetaryAmount> values) { return new OneOrManyEstimatedSalary (values.Select(v => (IEstimatedSalary) new EstimatedSalaryMonetaryAmount (v))); }
            public static implicit operator OneOrManyEstimatedSalary (decimal value) { return new OneOrManyEstimatedSalary (new EstimatedSalarydecimal (value)); }
            public static implicit operator OneOrManyEstimatedSalary (decimal[] values) { return new OneOrManyEstimatedSalary (values.Select(v => (IEstimatedSalary) new EstimatedSalarydecimal (v))); }
            public static implicit operator OneOrManyEstimatedSalary (List<decimal> values) { return new OneOrManyEstimatedSalary (values.Select(v => (IEstimatedSalary) new EstimatedSalarydecimal (v))); }
            public static implicit operator OneOrManyEstimatedSalary (PriceSpecification value) { return new OneOrManyEstimatedSalary (new EstimatedSalaryPriceSpecification (value)); }
            public static implicit operator OneOrManyEstimatedSalary (PriceSpecification[] values) { return new OneOrManyEstimatedSalary (values.Select(v => (IEstimatedSalary) new EstimatedSalaryPriceSpecification (v))); }
            public static implicit operator OneOrManyEstimatedSalary (List<PriceSpecification> values) { return new OneOrManyEstimatedSalary (values.Select(v => (IEstimatedSalary) new EstimatedSalaryPriceSpecification (v))); }
        }
        public struct EstimatedSalaryMonetaryAmount : IEstimatedSalary<MonetaryAmount>
        {
            object IValue.Value => this.Value;
            public MonetaryAmount Value { get; }
            public EstimatedSalaryMonetaryAmount (MonetaryAmount value) { Value = value; }
            public static implicit operator EstimatedSalaryMonetaryAmount (MonetaryAmount value) { return new EstimatedSalaryMonetaryAmount (value); }
        }
        public struct EstimatedSalarydecimal : IEstimatedSalary<decimal>
        {
            object IValue.Value => this.Value;
            public decimal Value { get; }
            public EstimatedSalarydecimal (decimal value) { Value = value; }
            public static implicit operator EstimatedSalarydecimal (decimal value) { return new EstimatedSalarydecimal (value); }
        }
        public struct EstimatedSalaryPriceSpecification : IEstimatedSalary<PriceSpecification>
        {
            object IValue.Value => this.Value;
            public PriceSpecification Value { get; }
            public EstimatedSalaryPriceSpecification (PriceSpecification value) { Value = value; }
            public static implicit operator EstimatedSalaryPriceSpecification (PriceSpecification value) { return new EstimatedSalaryPriceSpecification (value); }
        }

        public interface IExperienceRequirements : IValue {}
        public interface IExperienceRequirements<T> : IExperienceRequirements { new T Value { get; } }
        public class OneOrManyExperienceRequirements : OneOrMany<IExperienceRequirements>
        {
            public OneOrManyExperienceRequirements(IExperienceRequirements item) : base(item) { }
            public OneOrManyExperienceRequirements(IEnumerable<IExperienceRequirements> items) : base(items) { }
            public static implicit operator OneOrManyExperienceRequirements (string value) { return new OneOrManyExperienceRequirements (new ExperienceRequirementsstring (value)); }
            public static implicit operator OneOrManyExperienceRequirements (string[] values) { return new OneOrManyExperienceRequirements (values.Select(v => (IExperienceRequirements) new ExperienceRequirementsstring (v))); }
            public static implicit operator OneOrManyExperienceRequirements (List<string> values) { return new OneOrManyExperienceRequirements (values.Select(v => (IExperienceRequirements) new ExperienceRequirementsstring (v))); }
        }
        public struct ExperienceRequirementsstring : IExperienceRequirements<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ExperienceRequirementsstring (string value) { Value = value; }
            public static implicit operator ExperienceRequirementsstring (string value) { return new ExperienceRequirementsstring (value); }
        }

        public interface IHiringOrganization : IValue {}
        public interface IHiringOrganization<T> : IHiringOrganization { new T Value { get; } }
        public class OneOrManyHiringOrganization : OneOrMany<IHiringOrganization>
        {
            public OneOrManyHiringOrganization(IHiringOrganization item) : base(item) { }
            public OneOrManyHiringOrganization(IEnumerable<IHiringOrganization> items) : base(items) { }
            public static implicit operator OneOrManyHiringOrganization (Organization value) { return new OneOrManyHiringOrganization (new HiringOrganizationOrganization (value)); }
            public static implicit operator OneOrManyHiringOrganization (Organization[] values) { return new OneOrManyHiringOrganization (values.Select(v => (IHiringOrganization) new HiringOrganizationOrganization (v))); }
            public static implicit operator OneOrManyHiringOrganization (List<Organization> values) { return new OneOrManyHiringOrganization (values.Select(v => (IHiringOrganization) new HiringOrganizationOrganization (v))); }
        }
        public struct HiringOrganizationOrganization : IHiringOrganization<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public HiringOrganizationOrganization (Organization value) { Value = value; }
            public static implicit operator HiringOrganizationOrganization (Organization value) { return new HiringOrganizationOrganization (value); }
        }

        public interface IIncentiveCompensation : IValue {}
        public interface IIncentiveCompensation<T> : IIncentiveCompensation { new T Value { get; } }
        public class OneOrManyIncentiveCompensation : OneOrMany<IIncentiveCompensation>
        {
            public OneOrManyIncentiveCompensation(IIncentiveCompensation item) : base(item) { }
            public OneOrManyIncentiveCompensation(IEnumerable<IIncentiveCompensation> items) : base(items) { }
            public static implicit operator OneOrManyIncentiveCompensation (string value) { return new OneOrManyIncentiveCompensation (new IncentiveCompensationstring (value)); }
            public static implicit operator OneOrManyIncentiveCompensation (string[] values) { return new OneOrManyIncentiveCompensation (values.Select(v => (IIncentiveCompensation) new IncentiveCompensationstring (v))); }
            public static implicit operator OneOrManyIncentiveCompensation (List<string> values) { return new OneOrManyIncentiveCompensation (values.Select(v => (IIncentiveCompensation) new IncentiveCompensationstring (v))); }
        }
        public struct IncentiveCompensationstring : IIncentiveCompensation<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public IncentiveCompensationstring (string value) { Value = value; }
            public static implicit operator IncentiveCompensationstring (string value) { return new IncentiveCompensationstring (value); }
        }

        public interface IIndustry : IValue {}
        public interface IIndustry<T> : IIndustry { new T Value { get; } }
        public class OneOrManyIndustry : OneOrMany<IIndustry>
        {
            public OneOrManyIndustry(IIndustry item) : base(item) { }
            public OneOrManyIndustry(IEnumerable<IIndustry> items) : base(items) { }
            public static implicit operator OneOrManyIndustry (string value) { return new OneOrManyIndustry (new Industrystring (value)); }
            public static implicit operator OneOrManyIndustry (string[] values) { return new OneOrManyIndustry (values.Select(v => (IIndustry) new Industrystring (v))); }
            public static implicit operator OneOrManyIndustry (List<string> values) { return new OneOrManyIndustry (values.Select(v => (IIndustry) new Industrystring (v))); }
        }
        public struct Industrystring : IIndustry<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Industrystring (string value) { Value = value; }
            public static implicit operator Industrystring (string value) { return new Industrystring (value); }
        }

        public interface IJobBenefits : IValue {}
        public interface IJobBenefits<T> : IJobBenefits { new T Value { get; } }
        public class OneOrManyJobBenefits : OneOrMany<IJobBenefits>
        {
            public OneOrManyJobBenefits(IJobBenefits item) : base(item) { }
            public OneOrManyJobBenefits(IEnumerable<IJobBenefits> items) : base(items) { }
            public static implicit operator OneOrManyJobBenefits (string value) { return new OneOrManyJobBenefits (new JobBenefitsstring (value)); }
            public static implicit operator OneOrManyJobBenefits (string[] values) { return new OneOrManyJobBenefits (values.Select(v => (IJobBenefits) new JobBenefitsstring (v))); }
            public static implicit operator OneOrManyJobBenefits (List<string> values) { return new OneOrManyJobBenefits (values.Select(v => (IJobBenefits) new JobBenefitsstring (v))); }
        }
        public struct JobBenefitsstring : IJobBenefits<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public JobBenefitsstring (string value) { Value = value; }
            public static implicit operator JobBenefitsstring (string value) { return new JobBenefitsstring (value); }
        }

        public interface IJobLocation : IValue {}
        public interface IJobLocation<T> : IJobLocation { new T Value { get; } }
        public class OneOrManyJobLocation : OneOrMany<IJobLocation>
        {
            public OneOrManyJobLocation(IJobLocation item) : base(item) { }
            public OneOrManyJobLocation(IEnumerable<IJobLocation> items) : base(items) { }
            public static implicit operator OneOrManyJobLocation (Place value) { return new OneOrManyJobLocation (new JobLocationPlace (value)); }
            public static implicit operator OneOrManyJobLocation (Place[] values) { return new OneOrManyJobLocation (values.Select(v => (IJobLocation) new JobLocationPlace (v))); }
            public static implicit operator OneOrManyJobLocation (List<Place> values) { return new OneOrManyJobLocation (values.Select(v => (IJobLocation) new JobLocationPlace (v))); }
        }
        public struct JobLocationPlace : IJobLocation<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public JobLocationPlace (Place value) { Value = value; }
            public static implicit operator JobLocationPlace (Place value) { return new JobLocationPlace (value); }
        }

        public interface IOccupationalCategory : IValue {}
        public interface IOccupationalCategory<T> : IOccupationalCategory { new T Value { get; } }
        public class OneOrManyOccupationalCategory : OneOrMany<IOccupationalCategory>
        {
            public OneOrManyOccupationalCategory(IOccupationalCategory item) : base(item) { }
            public OneOrManyOccupationalCategory(IEnumerable<IOccupationalCategory> items) : base(items) { }
            public static implicit operator OneOrManyOccupationalCategory (string value) { return new OneOrManyOccupationalCategory (new OccupationalCategorystring (value)); }
            public static implicit operator OneOrManyOccupationalCategory (string[] values) { return new OneOrManyOccupationalCategory (values.Select(v => (IOccupationalCategory) new OccupationalCategorystring (v))); }
            public static implicit operator OneOrManyOccupationalCategory (List<string> values) { return new OneOrManyOccupationalCategory (values.Select(v => (IOccupationalCategory) new OccupationalCategorystring (v))); }
        }
        public struct OccupationalCategorystring : IOccupationalCategory<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public OccupationalCategorystring (string value) { Value = value; }
            public static implicit operator OccupationalCategorystring (string value) { return new OccupationalCategorystring (value); }
        }

        public interface IQualifications : IValue {}
        public interface IQualifications<T> : IQualifications { new T Value { get; } }
        public class OneOrManyQualifications : OneOrMany<IQualifications>
        {
            public OneOrManyQualifications(IQualifications item) : base(item) { }
            public OneOrManyQualifications(IEnumerable<IQualifications> items) : base(items) { }
            public static implicit operator OneOrManyQualifications (string value) { return new OneOrManyQualifications (new Qualificationsstring (value)); }
            public static implicit operator OneOrManyQualifications (string[] values) { return new OneOrManyQualifications (values.Select(v => (IQualifications) new Qualificationsstring (v))); }
            public static implicit operator OneOrManyQualifications (List<string> values) { return new OneOrManyQualifications (values.Select(v => (IQualifications) new Qualificationsstring (v))); }
        }
        public struct Qualificationsstring : IQualifications<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Qualificationsstring (string value) { Value = value; }
            public static implicit operator Qualificationsstring (string value) { return new Qualificationsstring (value); }
        }

        public interface IResponsibilities : IValue {}
        public interface IResponsibilities<T> : IResponsibilities { new T Value { get; } }
        public class OneOrManyResponsibilities : OneOrMany<IResponsibilities>
        {
            public OneOrManyResponsibilities(IResponsibilities item) : base(item) { }
            public OneOrManyResponsibilities(IEnumerable<IResponsibilities> items) : base(items) { }
            public static implicit operator OneOrManyResponsibilities (string value) { return new OneOrManyResponsibilities (new Responsibilitiesstring (value)); }
            public static implicit operator OneOrManyResponsibilities (string[] values) { return new OneOrManyResponsibilities (values.Select(v => (IResponsibilities) new Responsibilitiesstring (v))); }
            public static implicit operator OneOrManyResponsibilities (List<string> values) { return new OneOrManyResponsibilities (values.Select(v => (IResponsibilities) new Responsibilitiesstring (v))); }
        }
        public struct Responsibilitiesstring : IResponsibilities<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Responsibilitiesstring (string value) { Value = value; }
            public static implicit operator Responsibilitiesstring (string value) { return new Responsibilitiesstring (value); }
        }

        public interface ISalaryCurrency : IValue {}
        public interface ISalaryCurrency<T> : ISalaryCurrency { new T Value { get; } }
        public class OneOrManySalaryCurrency : OneOrMany<ISalaryCurrency>
        {
            public OneOrManySalaryCurrency(ISalaryCurrency item) : base(item) { }
            public OneOrManySalaryCurrency(IEnumerable<ISalaryCurrency> items) : base(items) { }
            public static implicit operator OneOrManySalaryCurrency (string value) { return new OneOrManySalaryCurrency (new SalaryCurrencystring (value)); }
            public static implicit operator OneOrManySalaryCurrency (string[] values) { return new OneOrManySalaryCurrency (values.Select(v => (ISalaryCurrency) new SalaryCurrencystring (v))); }
            public static implicit operator OneOrManySalaryCurrency (List<string> values) { return new OneOrManySalaryCurrency (values.Select(v => (ISalaryCurrency) new SalaryCurrencystring (v))); }
        }
        public struct SalaryCurrencystring : ISalaryCurrency<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SalaryCurrencystring (string value) { Value = value; }
            public static implicit operator SalaryCurrencystring (string value) { return new SalaryCurrencystring (value); }
        }

        public interface ISkills : IValue {}
        public interface ISkills<T> : ISkills { new T Value { get; } }
        public class OneOrManySkills : OneOrMany<ISkills>
        {
            public OneOrManySkills(ISkills item) : base(item) { }
            public OneOrManySkills(IEnumerable<ISkills> items) : base(items) { }
            public static implicit operator OneOrManySkills (string value) { return new OneOrManySkills (new Skillsstring (value)); }
            public static implicit operator OneOrManySkills (string[] values) { return new OneOrManySkills (values.Select(v => (ISkills) new Skillsstring (v))); }
            public static implicit operator OneOrManySkills (List<string> values) { return new OneOrManySkills (values.Select(v => (ISkills) new Skillsstring (v))); }
        }
        public struct Skillsstring : ISkills<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Skillsstring (string value) { Value = value; }
            public static implicit operator Skillsstring (string value) { return new Skillsstring (value); }
        }

        public interface ISpecialCommitments : IValue {}
        public interface ISpecialCommitments<T> : ISpecialCommitments { new T Value { get; } }
        public class OneOrManySpecialCommitments : OneOrMany<ISpecialCommitments>
        {
            public OneOrManySpecialCommitments(ISpecialCommitments item) : base(item) { }
            public OneOrManySpecialCommitments(IEnumerable<ISpecialCommitments> items) : base(items) { }
            public static implicit operator OneOrManySpecialCommitments (string value) { return new OneOrManySpecialCommitments (new SpecialCommitmentsstring (value)); }
            public static implicit operator OneOrManySpecialCommitments (string[] values) { return new OneOrManySpecialCommitments (values.Select(v => (ISpecialCommitments) new SpecialCommitmentsstring (v))); }
            public static implicit operator OneOrManySpecialCommitments (List<string> values) { return new OneOrManySpecialCommitments (values.Select(v => (ISpecialCommitments) new SpecialCommitmentsstring (v))); }
        }
        public struct SpecialCommitmentsstring : ISpecialCommitments<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SpecialCommitmentsstring (string value) { Value = value; }
            public static implicit operator SpecialCommitmentsstring (string value) { return new SpecialCommitmentsstring (value); }
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

        public interface IWorkHours : IValue {}
        public interface IWorkHours<T> : IWorkHours { new T Value { get; } }
        public class OneOrManyWorkHours : OneOrMany<IWorkHours>
        {
            public OneOrManyWorkHours(IWorkHours item) : base(item) { }
            public OneOrManyWorkHours(IEnumerable<IWorkHours> items) : base(items) { }
            public static implicit operator OneOrManyWorkHours (string value) { return new OneOrManyWorkHours (new WorkHoursstring (value)); }
            public static implicit operator OneOrManyWorkHours (string[] values) { return new OneOrManyWorkHours (values.Select(v => (IWorkHours) new WorkHoursstring (v))); }
            public static implicit operator OneOrManyWorkHours (List<string> values) { return new OneOrManyWorkHours (values.Select(v => (IWorkHours) new WorkHoursstring (v))); }
        }
        public struct WorkHoursstring : IWorkHours<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public WorkHoursstring (string value) { Value = value; }
            public static implicit operator WorkHoursstring (string value) { return new WorkHoursstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "JobPosting";

        /// <summary>
        /// The title of the job.
        /// </summary>
        [DataMember(Name = "title", Order = 3)]
        public OneOrManyTitle Title { get; set; }

        /// <summary>
        /// The base salary of the job or of an employee in an EmployeeRole.
        /// </summary>
        [DataMember(Name = "baseSalary", Order = 207)]
        public OneOrManyBaseSalary BaseSalary { get; set; }

        /// <summary>
        /// Publication date for the job posting.
        /// </summary>
        [DataMember(Name = "datePosted", Order = 208)]
        public OneOrManyDatePosted DatePosted { get; set; }

        /// <summary>
        /// Educational background needed for the position.
        /// </summary>
        [DataMember(Name = "educationRequirements", Order = 209)]
        public OneOrManyEducationRequirements EducationRequirements { get; set; }

        /// <summary>
        /// Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).
        /// </summary>
        [DataMember(Name = "employmentType", Order = 210)]
        public OneOrManyEmploymentType EmploymentType { get; set; }

        /// <summary>
        /// The estimated salary for this occupation in the given occupationLocation.
        /// </summary>
        [DataMember(Name = "estimatedSalary", Order = 211)]
        public OneOrManyEstimatedSalary EstimatedSalary { get; set; }

        /// <summary>
        /// Description of skills and experience needed for the position.
        /// </summary>
        [DataMember(Name = "experienceRequirements", Order = 212)]
        public OneOrManyExperienceRequirements ExperienceRequirements { get; set; }

        /// <summary>
        /// Organization offering the job position.
        /// </summary>
        [DataMember(Name = "hiringOrganization", Order = 213)]
        public OneOrManyHiringOrganization HiringOrganization { get; set; }

        /// <summary>
        /// Description of bonus and commission compensation aspects of the job.
        /// </summary>
        [DataMember(Name = "incentiveCompensation", Order = 214)]
        public OneOrManyIncentiveCompensation IncentiveCompensation { get; set; }

        /// <summary>
        /// The industry associated with the job position.
        /// </summary>
        [DataMember(Name = "industry", Order = 215)]
        public OneOrManyIndustry Industry { get; set; }

        /// <summary>
        /// Description of benefits associated with the job.
        /// </summary>
        [DataMember(Name = "jobBenefits", Order = 216)]
        public OneOrManyJobBenefits JobBenefits { get; set; }

        /// <summary>
        /// A (typically single) geographic location associated with the job position.
        /// </summary>
        [DataMember(Name = "jobLocation", Order = 217)]
        public OneOrManyJobLocation JobLocation { get; set; }

        /// <summary>
        /// Category or categories describing the job. Use BLS O*NET-SOC taxonomy: http://www.onetcenter.org/taxonomy.html. Ideally includes textual label and formal code, with the property repeated for each applicable value.
        /// </summary>
        [DataMember(Name = "occupationalCategory", Order = 218)]
        public OneOrManyOccupationalCategory OccupationalCategory { get; set; }

        /// <summary>
        /// Specific qualifications required for this role.
        /// </summary>
        [DataMember(Name = "qualifications", Order = 219)]
        public OneOrManyQualifications Qualifications { get; set; }

        /// <summary>
        /// Responsibilities associated with this role.
        /// </summary>
        [DataMember(Name = "responsibilities", Order = 220)]
        public OneOrManyResponsibilities Responsibilities { get; set; }

        /// <summary>
        /// The currency (coded using &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; ) used for the main salary information in this job posting or for this employee.
        /// </summary>
        [DataMember(Name = "salaryCurrency", Order = 221)]
        public OneOrManySalaryCurrency SalaryCurrency { get; set; }

        /// <summary>
        /// Skills required to fulfill this role.
        /// </summary>
        [DataMember(Name = "skills", Order = 222)]
        public OneOrManySkills Skills { get; set; }

        /// <summary>
        /// Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.
        /// </summary>
        [DataMember(Name = "specialCommitments", Order = 223)]
        public OneOrManySpecialCommitments SpecialCommitments { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough", Order = 224)]
        public OneOrManyValidThrough ValidThrough { get; set; }

        /// <summary>
        /// The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).
        /// </summary>
        [DataMember(Name = "workHours", Order = 225)]
        public OneOrManyWorkHours WorkHours { get; set; }
    }
}
