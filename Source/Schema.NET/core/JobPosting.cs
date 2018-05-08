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
        OneOrMany<string>? Title { get; set; }

        /// <summary>
        /// The base salary of the job or of an employee in an EmployeeRole.
        /// </summary>
        Values<IMonetaryAmount, decimal?, IPriceSpecification>? BaseSalary { get; set; }

        /// <summary>
        /// Publication date for the job posting.
        /// </summary>
        OneOrMany<DateTimeOffset?>? DatePosted { get; set; }

        /// <summary>
        /// Educational background needed for the position.
        /// </summary>
        OneOrMany<string>? EducationRequirements { get; set; }

        /// <summary>
        /// Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).
        /// </summary>
        OneOrMany<string>? EmploymentType { get; set; }

        /// <summary>
        /// A property describing the estimated salary for a job posting based on a variety of variables including, but not limited to industry, job title, and location. The estimated salary is usually computed by outside organizations and therefore the hiring organization is not bound to this estimated salary.
        /// </summary>
        Values<IMonetaryAmount, decimal?, IPriceSpecification>? EstimatedSalary { get; set; }

        /// <summary>
        /// Description of skills and experience needed for the position.
        /// </summary>
        OneOrMany<string>? ExperienceRequirements { get; set; }

        /// <summary>
        /// Organization offering the job position.
        /// </summary>
        OneOrMany<IOrganization>? HiringOrganization { get; set; }

        /// <summary>
        /// Description of bonus and commission compensation aspects of the job.
        /// </summary>
        OneOrMany<string>? IncentiveCompensation { get; set; }

        /// <summary>
        /// The industry associated with the job position.
        /// </summary>
        OneOrMany<string>? Industry { get; set; }

        /// <summary>
        /// Description of benefits associated with the job.
        /// </summary>
        OneOrMany<string>? JobBenefits { get; set; }

        /// <summary>
        /// A (typically single) geographic location associated with the job position.
        /// </summary>
        OneOrMany<IPlace>? JobLocation { get; set; }

        /// <summary>
        /// Category or categories describing the job. Use BLS O*NET-SOC taxonomy: http://www.onetcenter.org/taxonomy.html. Ideally includes textual label and formal code, with the property repeated for each applicable value.
        /// </summary>
        OneOrMany<string>? OccupationalCategory { get; set; }

        /// <summary>
        /// Specific qualifications required for this role.
        /// </summary>
        OneOrMany<string>? Qualifications { get; set; }

        /// <summary>
        /// Responsibilities associated with this role.
        /// </summary>
        OneOrMany<string>? Responsibilities { get; set; }

        /// <summary>
        /// The currency (coded using &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; ) used for the main salary information in this job posting or for this employee.
        /// </summary>
        OneOrMany<string>? SalaryCurrency { get; set; }

        /// <summary>
        /// Skills required to fulfill this role.
        /// </summary>
        OneOrMany<string>? Skills { get; set; }

        /// <summary>
        /// Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.
        /// </summary>
        OneOrMany<string>? SpecialCommitments { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        OneOrMany<DateTimeOffset?>? ValidThrough { get; set; }

        /// <summary>
        /// The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).
        /// </summary>
        OneOrMany<string>? WorkHours { get; set; }
    }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
    [DataContract]
    public partial class JobPosting : Intangible, IJobPosting
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
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Title { get; set; }

        /// <summary>
        /// The base salary of the job or of an employee in an EmployeeRole.
        /// </summary>
        [DataMember(Name = "baseSalary", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IMonetaryAmount, decimal?, IPriceSpecification>? BaseSalary { get; set; }

        /// <summary>
        /// Publication date for the job posting.
        /// </summary>
        [DataMember(Name = "datePosted", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? DatePosted { get; set; }

        /// <summary>
        /// Educational background needed for the position.
        /// </summary>
        [DataMember(Name = "educationRequirements", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? EducationRequirements { get; set; }

        /// <summary>
        /// Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).
        /// </summary>
        [DataMember(Name = "employmentType", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? EmploymentType { get; set; }

        /// <summary>
        /// A property describing the estimated salary for a job posting based on a variety of variables including, but not limited to industry, job title, and location. The estimated salary is usually computed by outside organizations and therefore the hiring organization is not bound to this estimated salary.
        /// </summary>
        [DataMember(Name = "estimatedSalary", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IMonetaryAmount, decimal?, IPriceSpecification>? EstimatedSalary { get; set; }

        /// <summary>
        /// Description of skills and experience needed for the position.
        /// </summary>
        [DataMember(Name = "experienceRequirements", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? ExperienceRequirements { get; set; }

        /// <summary>
        /// Organization offering the job position.
        /// </summary>
        [DataMember(Name = "hiringOrganization", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IOrganization>? HiringOrganization { get; set; }

        /// <summary>
        /// Description of bonus and commission compensation aspects of the job.
        /// </summary>
        [DataMember(Name = "incentiveCompensation", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? IncentiveCompensation { get; set; }

        /// <summary>
        /// The industry associated with the job position.
        /// </summary>
        [DataMember(Name = "industry", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Industry { get; set; }

        /// <summary>
        /// Description of benefits associated with the job.
        /// </summary>
        [DataMember(Name = "jobBenefits", Order = 216)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? JobBenefits { get; set; }

        /// <summary>
        /// A (typically single) geographic location associated with the job position.
        /// </summary>
        [DataMember(Name = "jobLocation", Order = 217)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPlace>? JobLocation { get; set; }

        /// <summary>
        /// Category or categories describing the job. Use BLS O*NET-SOC taxonomy: http://www.onetcenter.org/taxonomy.html. Ideally includes textual label and formal code, with the property repeated for each applicable value.
        /// </summary>
        [DataMember(Name = "occupationalCategory", Order = 218)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? OccupationalCategory { get; set; }

        /// <summary>
        /// Specific qualifications required for this role.
        /// </summary>
        [DataMember(Name = "qualifications", Order = 219)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Qualifications { get; set; }

        /// <summary>
        /// Responsibilities associated with this role.
        /// </summary>
        [DataMember(Name = "responsibilities", Order = 220)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Responsibilities { get; set; }

        /// <summary>
        /// The currency (coded using &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; ) used for the main salary information in this job posting or for this employee.
        /// </summary>
        [DataMember(Name = "salaryCurrency", Order = 221)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? SalaryCurrency { get; set; }

        /// <summary>
        /// Skills required to fulfill this role.
        /// </summary>
        [DataMember(Name = "skills", Order = 222)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Skills { get; set; }

        /// <summary>
        /// Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.
        /// </summary>
        [DataMember(Name = "specialCommitments", Order = 223)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? SpecialCommitments { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough", Order = 224)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? ValidThrough { get; set; }

        /// <summary>
        /// The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).
        /// </summary>
        [DataMember(Name = "workHours", Order = 225)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? WorkHours { get; set; }
    }
}
