using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A subclass of OrganizationRole used to describe employee relationships.
    /// </summary>
    [DataContract]
    public partial class EmployeeRole : OrganizationRole
    {
        public interface IBaseSalary : IWrapper { }
        public interface IBaseSalary<T> : IBaseSalary { new T Data { get; set; } }
        public class BaseSalaryMonetaryAmount : IBaseSalary<MonetaryAmount>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MonetaryAmount) value; } }
            public virtual MonetaryAmount Data { get; set; }
            public BaseSalaryMonetaryAmount () { }
            public BaseSalaryMonetaryAmount (MonetaryAmount data) { Data = data; }
            public static implicit operator BaseSalaryMonetaryAmount (MonetaryAmount data) { return new BaseSalaryMonetaryAmount (data); }
        }

        public class BaseSalarydecimal : IBaseSalary<decimal>
        {
            object IWrapper.Data { get { return Data; } set { Data = (decimal) value; } }
            public virtual decimal Data { get; set; }
            public BaseSalarydecimal () { }
            public BaseSalarydecimal (decimal data) { Data = data; }
            public static implicit operator BaseSalarydecimal (decimal data) { return new BaseSalarydecimal (data); }
        }

        public class BaseSalaryPriceSpecification : IBaseSalary<PriceSpecification>
        {
            object IWrapper.Data { get { return Data; } set { Data = (PriceSpecification) value; } }
            public virtual PriceSpecification Data { get; set; }
            public BaseSalaryPriceSpecification () { }
            public BaseSalaryPriceSpecification (PriceSpecification data) { Data = data; }
            public static implicit operator BaseSalaryPriceSpecification (PriceSpecification data) { return new BaseSalaryPriceSpecification (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EmployeeRole";

        /// <summary>
        /// The base salary of the job or of an employee in an EmployeeRole.
        /// </summary>
        [DataMember(Name = "baseSalary", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IBaseSalary>? BaseSalary { get; set; } //MonetaryAmount, decimal?, PriceSpecification

        /// <summary>
        /// The currency (coded using &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; ) used for the main salary information in this job posting or for this employee.
        /// </summary>
        [DataMember(Name = "salaryCurrency", Order = 407)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? SalaryCurrency { get; set; } 
    }
}
