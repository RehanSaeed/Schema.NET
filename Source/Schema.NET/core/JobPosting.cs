namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
    [DataContract]
    public partial class JobPosting : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "JobPosting";

        /// <summary>
        /// The base salary of the job or of an employee in an EmployeeRole.
        /// </summary>
        [DataMember(Name = "baseSalary", Order = 2)]
        public object BaseSalary { get; protected set; }

        /// <summary>
        /// The base salary of the job or of an employee in an EmployeeRole.
        /// </summary>
        [IgnoreDataMember]
        public decimal? BaseSalaryNumber
        {
            get => this.BaseSalary as decimal?;
            set => this.BaseSalary = value;
        }

        /// <summary>
        /// The base salary of the job or of an employee in an EmployeeRole.
        /// </summary>
        [IgnoreDataMember]
        public MonetaryAmount BaseSalaryMonetaryAmount
        {
            get => this.BaseSalary as MonetaryAmount;
            set => this.BaseSalary = value;
        }

        /// <summary>
        /// The base salary of the job or of an employee in an EmployeeRole.
        /// </summary>
        [IgnoreDataMember]
        public PriceSpecification BaseSalaryPriceSpecification
        {
            get => this.BaseSalary as PriceSpecification;
            set => this.BaseSalary = value;
        }

        /// <summary>
        /// Publication date for the job posting.
        /// </summary>
        [DataMember(Name = "datePosted", Order = 3)]
        public DateTimeOffset? DatePosted { get; set; }

        /// <summary>
        /// Educational background needed for the position.
        /// </summary>
        [DataMember(Name = "educationRequirements", Order = 4)]
        public string EducationRequirements { get; set; }

        /// <summary>
        /// Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).
        /// </summary>
        [DataMember(Name = "employmentType", Order = 5)]
        public string EmploymentType { get; set; }

        /// <summary>
        /// Description of skills and experience needed for the position.
        /// </summary>
        [DataMember(Name = "experienceRequirements", Order = 6)]
        public string ExperienceRequirements { get; set; }

        /// <summary>
        /// Organization offering the job position.
        /// </summary>
        [DataMember(Name = "hiringOrganization", Order = 7)]
        public Organization HiringOrganization { get; set; }

        /// <summary>
        /// Description of bonus and commission compensation aspects of the job.
        /// </summary>
        [DataMember(Name = "incentiveCompensation", Order = 8)]
        public string IncentiveCompensation { get; set; }

        /// <summary>
        /// The industry associated with the job position.
        /// </summary>
        [DataMember(Name = "industry", Order = 9)]
        public string Industry { get; set; }

        /// <summary>
        /// Description of benefits associated with the job.
        /// </summary>
        [DataMember(Name = "jobBenefits", Order = 10)]
        public string JobBenefits { get; set; }

        /// <summary>
        /// A (typically single) geographic location associated with the job position.
        /// </summary>
        [DataMember(Name = "jobLocation", Order = 11)]
        public Place JobLocation { get; set; }

        /// <summary>
        /// Category or categories describing the job. Use BLS O*NET-SOC taxonomy: http://www.onetcenter.org/taxonomy.html. Ideally includes textual label and formal code, with the property repeated for each applicable value.
        /// </summary>
        [DataMember(Name = "occupationalCategory", Order = 12)]
        public string OccupationalCategory { get; set; }

        /// <summary>
        /// Specific qualifications required for this role.
        /// </summary>
        [DataMember(Name = "qualifications", Order = 13)]
        public string Qualifications { get; set; }

        /// <summary>
        /// Responsibilities associated with this role.
        /// </summary>
        [DataMember(Name = "responsibilities", Order = 14)]
        public string Responsibilities { get; set; }

        /// <summary>
        /// The currency (coded using &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; ) used for the main salary information in this job posting or for this employee.
        /// </summary>
        [DataMember(Name = "salaryCurrency", Order = 15)]
        public string SalaryCurrency { get; set; }

        /// <summary>
        /// Skills required to fulfill this role.
        /// </summary>
        [DataMember(Name = "skills", Order = 16)]
        public string Skills { get; set; }

        /// <summary>
        /// Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.
        /// </summary>
        [DataMember(Name = "specialCommitments", Order = 17)]
        public string SpecialCommitments { get; set; }

        /// <summary>
        /// The title of the job.
        /// </summary>
        [DataMember(Name = "title", Order = 18)]
        public string Title { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough", Order = 19)]
        public DateTimeOffset? ValidThrough { get; set; }

        /// <summary>
        /// The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).
        /// </summary>
        [DataMember(Name = "workHours", Order = 20)]
        public string WorkHours { get; set; }
    }
}
