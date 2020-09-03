namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
    public partial interface IJobPosting : IIntangible
    {
        /// <summary>
        /// The title of the job.
        /// </summary>
        OneOrMany<string> Title { get; set; }

        /// <summary>
        /// The location(s) applicants can apply from. This is usually used for telecommuting jobs where the applicant does not need to be in a physical office. Note: This should not be used for citizenship or work visa requirements.
        /// </summary>
        OneOrMany<IAdministrativeArea> ApplicantLocationRequirements { get; set; }

        /// <summary>
        /// Contact details for further information relevant to this job posting.
        /// </summary>
        OneOrMany<IContactPoint> ApplicationContact { get; set; }

        /// <summary>
        /// The base salary of the job or of an employee in an EmployeeRole.
        /// </summary>
        Values<IMonetaryAmount, decimal?, IPriceSpecification> BaseSalary { get; set; }

        /// <summary>
        /// Publication date of an online listing.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> DatePosted { get; set; }

        /// <summary>
        /// Educational background needed for the position or Occupation.
        /// </summary>
        OneOrMany<string> EducationRequirements { get; set; }

        /// <summary>
        /// The legal requirements such as citizenship, visa and other documentation required for an applicant to this job.
        /// </summary>
        OneOrMany<string> EligibilityToWorkRequirement { get; set; }

        /// <summary>
        /// A description of the employer, career opportunities and work environment for this position.
        /// </summary>
        OneOrMany<string> EmployerOverview { get; set; }

        /// <summary>
        /// Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).
        /// </summary>
        OneOrMany<string> EmploymentType { get; set; }

        /// <summary>
        /// Indicates the department, unit and/or facility where the employee reports and/or in which the job is to be performed.
        /// </summary>
        OneOrMany<IOrganization> EmploymentUnit { get; set; }

        /// <summary>
        /// An estimated salary for a job posting or occupation, based on a variety of variables including, but not limited to industry, job title, and location. Estimated salaries  are often computed by outside organizations rather than the hiring organization, who may not have committed to the estimated value.
        /// </summary>
        Values<IMonetaryAmount, IMonetaryAmountDistribution, decimal?> EstimatedSalary { get; set; }

        /// <summary>
        /// Description of skills and experience needed for the position or Occupation.
        /// </summary>
        OneOrMany<string> ExperienceRequirements { get; set; }

        /// <summary>
        /// Organization offering the job position.
        /// </summary>
        OneOrMany<IOrganization> HiringOrganization { get; set; }

        /// <summary>
        /// Description of bonus and commission compensation aspects of the job.
        /// </summary>
        OneOrMany<string> IncentiveCompensation { get; set; }

        /// <summary>
        /// The industry associated with the job position.
        /// </summary>
        OneOrMany<string> Industry { get; set; }

        /// <summary>
        /// Description of benefits associated with the job.
        /// </summary>
        OneOrMany<string> JobBenefits { get; set; }

        /// <summary>
        /// An indicator as to whether a position is available for an immediate start.
        /// </summary>
        OneOrMany<bool?> JobImmediateStart { get; set; }

        /// <summary>
        /// A (typically single) geographic location associated with the job position.
        /// </summary>
        OneOrMany<IPlace> JobLocation { get; set; }

        /// <summary>
        /// A description of the job location (e.g TELECOMMUTE for telecommute jobs).
        /// </summary>
        OneOrMany<string> JobLocationType { get; set; }

        /// <summary>
        /// The date on which a successful applicant for this job would be expected to start work. Choose a specific date in the future or use the jobImmediateStart property to indicate the position is to be filled as soon as possible.
        /// </summary>
        Values<int?, DateTime?, string> JobStartDate { get; set; }

        /// <summary>
        /// A category describing the job, preferably using a term from a taxonomy such as &lt;a href="http://www.onetcenter.org/taxonomy.html"&gt;BLS O*NET-SOC&lt;/a&gt;, &lt;a href="https://www.ilo.org/public/english/bureau/stat/isco/isco08/"&gt;ISCO-08&lt;/a&gt; or similar, with the property repeated for each applicable value. Ideally the taxonomy should be identified, and both the textual label and formal code for the category should be provided.&lt;br/&gt;&lt;br/&gt;
        /// Note: for historical reasons, any textual label and formal code provided as a literal may be assumed to be from O*NET-SOC.
        /// </summary>
        OneOrMany<string> OccupationalCategory { get; set; }

        /// <summary>
        /// A description of the types of physical activity associated with the job. Defined terms such as those in O*net may be used, but note that there is no way to specify the level of ability as well as its nature when using a defined term.
        /// </summary>
        Values<string, Uri> PhysicalRequirement { get; set; }

        /// <summary>
        /// Specific qualifications required for this role or Occupation.
        /// </summary>
        OneOrMany<string> Qualifications { get; set; }

        /// <summary>
        /// The Occupation for the JobPosting.
        /// </summary>
        OneOrMany<IOccupation> RelevantOccupation { get; set; }

        /// <summary>
        /// Responsibilities associated with this role or Occupation.
        /// </summary>
        OneOrMany<string> Responsibilities { get; set; }

        /// <summary>
        /// The currency (coded using &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; ) used for the main salary information in this job posting or for this employee.
        /// </summary>
        OneOrMany<string> SalaryCurrency { get; set; }

        /// <summary>
        /// A description of any security clearance requirements of the job.
        /// </summary>
        Values<string, Uri> SecurityClearanceRequirement { get; set; }

        /// <summary>
        /// A description of any sensory requirements and levels necessary to function on the job, including hearing and vision. Defined terms such as those in O*net may be used, but note that there is no way to specify the level of ability as well as its nature when using a defined term.
        /// </summary>
        Values<string, Uri> SensoryRequirement { get; set; }

        /// <summary>
        /// A statement of knowledge, skill, ability, task or any other assertion expressing a competency that is desired or required to fulfill this role or to work in this occupation.
        /// </summary>
        OneOrMany<string> Skills { get; set; }

        /// <summary>
        /// Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.
        /// </summary>
        OneOrMany<string> SpecialCommitments { get; set; }

        /// <summary>
        /// The number of positions open for this job posting. Use a positive integer. Do not use if the number of positions is unclear or not known.
        /// </summary>
        OneOrMany<int?> TotalJobOpenings { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }

        /// <summary>
        /// The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).
        /// </summary>
        OneOrMany<string> WorkHours { get; set; }
    }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
    [DataContract]
    public partial class JobPosting : Intangible, IJobPosting, IEquatable<JobPosting>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "JobPosting";

        /// <summary>
        /// The title of the job.
        /// </summary>
        [DataMember(Name = "title", Order = 3)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Title { get; set; }

        /// <summary>
        /// The location(s) applicants can apply from. This is usually used for telecommuting jobs where the applicant does not need to be in a physical office. Note: This should not be used for citizenship or work visa requirements.
        /// </summary>
        [DataMember(Name = "applicantLocationRequirements", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAdministrativeArea> ApplicantLocationRequirements { get; set; }

        /// <summary>
        /// Contact details for further information relevant to this job posting.
        /// </summary>
        [DataMember(Name = "applicationContact", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IContactPoint> ApplicationContact { get; set; }

        /// <summary>
        /// The base salary of the job or of an employee in an EmployeeRole.
        /// </summary>
        [DataMember(Name = "baseSalary", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMonetaryAmount, decimal?, IPriceSpecification> BaseSalary { get; set; }

        /// <summary>
        /// Publication date of an online listing.
        /// </summary>
        [DataMember(Name = "datePosted", Order = 210)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> DatePosted { get; set; }

        /// <summary>
        /// Educational background needed for the position or Occupation.
        /// </summary>
        [DataMember(Name = "educationRequirements", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> EducationRequirements { get; set; }

        /// <summary>
        /// The legal requirements such as citizenship, visa and other documentation required for an applicant to this job.
        /// </summary>
        [DataMember(Name = "eligibilityToWorkRequirement", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> EligibilityToWorkRequirement { get; set; }

        /// <summary>
        /// A description of the employer, career opportunities and work environment for this position.
        /// </summary>
        [DataMember(Name = "employerOverview", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> EmployerOverview { get; set; }

        /// <summary>
        /// Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).
        /// </summary>
        [DataMember(Name = "employmentType", Order = 214)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> EmploymentType { get; set; }

        /// <summary>
        /// Indicates the department, unit and/or facility where the employee reports and/or in which the job is to be performed.
        /// </summary>
        [DataMember(Name = "employmentUnit", Order = 215)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> EmploymentUnit { get; set; }

        /// <summary>
        /// An estimated salary for a job posting or occupation, based on a variety of variables including, but not limited to industry, job title, and location. Estimated salaries  are often computed by outside organizations rather than the hiring organization, who may not have committed to the estimated value.
        /// </summary>
        [DataMember(Name = "estimatedSalary", Order = 216)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMonetaryAmount, IMonetaryAmountDistribution, decimal?> EstimatedSalary { get; set; }

        /// <summary>
        /// Description of skills and experience needed for the position or Occupation.
        /// </summary>
        [DataMember(Name = "experienceRequirements", Order = 217)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ExperienceRequirements { get; set; }

        /// <summary>
        /// Organization offering the job position.
        /// </summary>
        [DataMember(Name = "hiringOrganization", Order = 218)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> HiringOrganization { get; set; }

        /// <summary>
        /// Description of bonus and commission compensation aspects of the job.
        /// </summary>
        [DataMember(Name = "incentiveCompensation", Order = 219)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> IncentiveCompensation { get; set; }

        /// <summary>
        /// The industry associated with the job position.
        /// </summary>
        [DataMember(Name = "industry", Order = 220)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Industry { get; set; }

        /// <summary>
        /// Description of benefits associated with the job.
        /// </summary>
        [DataMember(Name = "jobBenefits", Order = 221)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> JobBenefits { get; set; }

        /// <summary>
        /// An indicator as to whether a position is available for an immediate start.
        /// </summary>
        [DataMember(Name = "jobImmediateStart", Order = 222)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> JobImmediateStart { get; set; }

        /// <summary>
        /// A (typically single) geographic location associated with the job position.
        /// </summary>
        [DataMember(Name = "jobLocation", Order = 223)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> JobLocation { get; set; }

        /// <summary>
        /// A description of the job location (e.g TELECOMMUTE for telecommute jobs).
        /// </summary>
        [DataMember(Name = "jobLocationType", Order = 224)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> JobLocationType { get; set; }

        /// <summary>
        /// The date on which a successful applicant for this job would be expected to start work. Choose a specific date in the future or use the jobImmediateStart property to indicate the position is to be filled as soon as possible.
        /// </summary>
        [DataMember(Name = "jobStartDate", Order = 225)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, string> JobStartDate { get; set; }

        /// <summary>
        /// A category describing the job, preferably using a term from a taxonomy such as &lt;a href="http://www.onetcenter.org/taxonomy.html"&gt;BLS O*NET-SOC&lt;/a&gt;, &lt;a href="https://www.ilo.org/public/english/bureau/stat/isco/isco08/"&gt;ISCO-08&lt;/a&gt; or similar, with the property repeated for each applicable value. Ideally the taxonomy should be identified, and both the textual label and formal code for the category should be provided.&lt;br/&gt;&lt;br/&gt;
        /// Note: for historical reasons, any textual label and formal code provided as a literal may be assumed to be from O*NET-SOC.
        /// </summary>
        [DataMember(Name = "occupationalCategory", Order = 226)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> OccupationalCategory { get; set; }

        /// <summary>
        /// A description of the types of physical activity associated with the job. Defined terms such as those in O*net may be used, but note that there is no way to specify the level of ability as well as its nature when using a defined term.
        /// </summary>
        [DataMember(Name = "physicalRequirement", Order = 227)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> PhysicalRequirement { get; set; }

        /// <summary>
        /// Specific qualifications required for this role or Occupation.
        /// </summary>
        [DataMember(Name = "qualifications", Order = 228)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Qualifications { get; set; }

        /// <summary>
        /// The Occupation for the JobPosting.
        /// </summary>
        [DataMember(Name = "relevantOccupation", Order = 229)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOccupation> RelevantOccupation { get; set; }

        /// <summary>
        /// Responsibilities associated with this role or Occupation.
        /// </summary>
        [DataMember(Name = "responsibilities", Order = 230)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Responsibilities { get; set; }

        /// <summary>
        /// The currency (coded using &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; ) used for the main salary information in this job posting or for this employee.
        /// </summary>
        [DataMember(Name = "salaryCurrency", Order = 231)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SalaryCurrency { get; set; }

        /// <summary>
        /// A description of any security clearance requirements of the job.
        /// </summary>
        [DataMember(Name = "securityClearanceRequirement", Order = 232)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> SecurityClearanceRequirement { get; set; }

        /// <summary>
        /// A description of any sensory requirements and levels necessary to function on the job, including hearing and vision. Defined terms such as those in O*net may be used, but note that there is no way to specify the level of ability as well as its nature when using a defined term.
        /// </summary>
        [DataMember(Name = "sensoryRequirement", Order = 233)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> SensoryRequirement { get; set; }

        /// <summary>
        /// A statement of knowledge, skill, ability, task or any other assertion expressing a competency that is desired or required to fulfill this role or to work in this occupation.
        /// </summary>
        [DataMember(Name = "skills", Order = 234)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Skills { get; set; }

        /// <summary>
        /// Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.
        /// </summary>
        [DataMember(Name = "specialCommitments", Order = 235)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SpecialCommitments { get; set; }

        /// <summary>
        /// The number of positions open for this job posting. Use a positive integer. Do not use if the number of positions is unclear or not known.
        /// </summary>
        [DataMember(Name = "totalJobOpenings", Order = 236)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> TotalJobOpenings { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough", Order = 237)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }

        /// <summary>
        /// The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).
        /// </summary>
        [DataMember(Name = "workHours", Order = 238)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> WorkHours { get; set; }

        /// <inheritdoc/>
        public bool Equals(JobPosting other)
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
                this.Title == other.Title &&
                this.ApplicantLocationRequirements == other.ApplicantLocationRequirements &&
                this.ApplicationContact == other.ApplicationContact &&
                this.BaseSalary == other.BaseSalary &&
                this.DatePosted == other.DatePosted &&
                this.EducationRequirements == other.EducationRequirements &&
                this.EligibilityToWorkRequirement == other.EligibilityToWorkRequirement &&
                this.EmployerOverview == other.EmployerOverview &&
                this.EmploymentType == other.EmploymentType &&
                this.EmploymentUnit == other.EmploymentUnit &&
                this.EstimatedSalary == other.EstimatedSalary &&
                this.ExperienceRequirements == other.ExperienceRequirements &&
                this.HiringOrganization == other.HiringOrganization &&
                this.IncentiveCompensation == other.IncentiveCompensation &&
                this.Industry == other.Industry &&
                this.JobBenefits == other.JobBenefits &&
                this.JobImmediateStart == other.JobImmediateStart &&
                this.JobLocation == other.JobLocation &&
                this.JobLocationType == other.JobLocationType &&
                this.JobStartDate == other.JobStartDate &&
                this.OccupationalCategory == other.OccupationalCategory &&
                this.PhysicalRequirement == other.PhysicalRequirement &&
                this.Qualifications == other.Qualifications &&
                this.RelevantOccupation == other.RelevantOccupation &&
                this.Responsibilities == other.Responsibilities &&
                this.SalaryCurrency == other.SalaryCurrency &&
                this.SecurityClearanceRequirement == other.SecurityClearanceRequirement &&
                this.SensoryRequirement == other.SensoryRequirement &&
                this.Skills == other.Skills &&
                this.SpecialCommitments == other.SpecialCommitments &&
                this.TotalJobOpenings == other.TotalJobOpenings &&
                this.ValidThrough == other.ValidThrough &&
                this.WorkHours == other.WorkHours &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as JobPosting);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Title)
            .And(this.ApplicantLocationRequirements)
            .And(this.ApplicationContact)
            .And(this.BaseSalary)
            .And(this.DatePosted)
            .And(this.EducationRequirements)
            .And(this.EligibilityToWorkRequirement)
            .And(this.EmployerOverview)
            .And(this.EmploymentType)
            .And(this.EmploymentUnit)
            .And(this.EstimatedSalary)
            .And(this.ExperienceRequirements)
            .And(this.HiringOrganization)
            .And(this.IncentiveCompensation)
            .And(this.Industry)
            .And(this.JobBenefits)
            .And(this.JobImmediateStart)
            .And(this.JobLocation)
            .And(this.JobLocationType)
            .And(this.JobStartDate)
            .And(this.OccupationalCategory)
            .And(this.PhysicalRequirement)
            .And(this.Qualifications)
            .And(this.RelevantOccupation)
            .And(this.Responsibilities)
            .And(this.SalaryCurrency)
            .And(this.SecurityClearanceRequirement)
            .And(this.SensoryRequirement)
            .And(this.Skills)
            .And(this.SpecialCommitments)
            .And(this.TotalJobOpenings)
            .And(this.ValidThrough)
            .And(this.WorkHours)
            .And(base.GetHashCode());
    }
}
