namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
    [DataContract]
    public class JobPosting : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "JobPosting";

        /// <summary>
        /// A (typically single) geographic location associated with the job position.
        /// </summary>
        [DataMember(Name = "jobLocation")]
        public Place JobLocation { get; set; }

        /// <summary>
        /// Specific qualifications required for this role.
        /// </summary>
        [DataMember(Name = "qualifications")]
        public string Qualifications { get; set; }

        /// <summary>
        /// Description of bonus and commission compensation aspects of the job.
        /// </summary>
        [DataMember(Name = "incentiveCompensation")]
        public string IncentiveCompensation { get; set; }

        /// <summary>
        /// The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).
        /// </summary>
        [DataMember(Name = "workHours")]
        public string WorkHours { get; set; }

        /// <summary>
        /// The currency (coded using &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; ) used for the main salary information in this job posting or for this employee.
        /// </summary>
        [DataMember(Name = "salaryCurrency")]
        public string SalaryCurrency { get; set; }

        /// <summary>
        /// Description of benefits associated with the job.
        /// </summary>
        [DataMember(Name = "jobBenefits")]
        public string JobBenefits { get; set; }

        /// <summary>
        /// Publication date for the job posting.
        /// </summary>
        [DataMember(Name = "datePosted")]
        public DateTimeOffset DatePosted { get; set; }

        /// <summary>
        /// Skills required to fulfill this role.
        /// </summary>
        [DataMember(Name = "skills")]
        public string Skills { get; set; }

        /// <summary>
        /// Educational background needed for the position.
        /// </summary>
        [DataMember(Name = "educationRequirements")]
        public string EducationRequirements { get; set; }

        /// <summary>
        /// Responsibilities associated with this role.
        /// </summary>
        [DataMember(Name = "responsibilities")]
        public string Responsibilities { get; set; }

        /// <summary>
        /// The base salary of the job or of an employee in an EmployeeRole.
        /// </summary>
        [DataMember(Name = "baseSalary")]
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
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough")]
        public DateTimeOffset ValidThrough { get; set; }

        /// <summary>
        /// Organization offering the job position.
        /// </summary>
        [DataMember(Name = "hiringOrganization")]
        public Organization HiringOrganization { get; set; }

        /// <summary>
        /// Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.
        /// </summary>
        [DataMember(Name = "specialCommitments")]
        public string SpecialCommitments { get; set; }

        /// <summary>
        /// Category or categories describing the job. Use BLS O*NET-SOC taxonomy: http://www.onetcenter.org/taxonomy.html. Ideally includes textual label and formal code, with the property repeated for each applicable value.
        /// </summary>
        [DataMember(Name = "occupationalCategory")]
        public string OccupationalCategory { get; set; }

        /// <summary>
        /// Description of skills and experience needed for the position.
        /// </summary>
        [DataMember(Name = "experienceRequirements")]
        public string ExperienceRequirements { get; set; }

        /// <summary>
        /// Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).
        /// </summary>
        [DataMember(Name = "employmentType")]
        public string EmploymentType { get; set; }

        /// <summary>
        /// The title of the job.
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// The industry associated with the job position.
        /// </summary>
        [DataMember(Name = "industry")]
        public string Industry { get; set; }
    }
}
