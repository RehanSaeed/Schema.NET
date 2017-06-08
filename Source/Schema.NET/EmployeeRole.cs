namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A subclass of OrganizationRole used to describe employee relationships.
    /// </summary>
    [DataContract]
    public class EmployeeRole : OrganizationRole
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "EmployeeRole";

        /// <summary>
        /// The currency (coded using &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; ) used for the main salary information in this job posting or for this employee.
        /// </summary>
        [DataMember(Name = "salaryCurrency")]
        public string SalaryCurrency { get; set; }

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
    }
}
