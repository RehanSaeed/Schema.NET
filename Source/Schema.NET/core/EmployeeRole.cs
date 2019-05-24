namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A subclass of OrganizationRole used to describe employee relationships.
    /// </summary>
    public partial interface IEmployeeRole : IOrganizationRole
    {
        /// <summary>
        /// The base salary of the job or of an employee in an EmployeeRole.
        /// </summary>
        Values<IMonetaryAmount, decimal?, IPriceSpecification>? BaseSalary { get; set; }

        /// <summary>
        /// The currency (coded using &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; ) used for the main salary information in this job posting or for this employee.
        /// </summary>
        OneOrMany<string> SalaryCurrency { get; set; }
    }

    /// <summary>
    /// A subclass of OrganizationRole used to describe employee relationships.
    /// </summary>
    [DataContract]
    public partial class EmployeeRole : OrganizationRole, IEmployeeRole
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EmployeeRole";

        /// <summary>
        /// The base salary of the job or of an employee in an EmployeeRole.
        /// </summary>
        [DataMember(Name = "baseSalary", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMonetaryAmount, decimal?, IPriceSpecification>? BaseSalary { get; set; }

        /// <summary>
        /// The currency (coded using &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; ) used for the main salary information in this job posting or for this employee.
        /// </summary>
        [DataMember(Name = "salaryCurrency", Order = 407)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SalaryCurrency { get; set; }
    }
}
