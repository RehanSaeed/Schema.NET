namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A subclass of OrganizationRole used to describe employee relationships.
    /// </summary>
    [DataContract]
    public partial class EmployeeRole : OrganizationRole
    {
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

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EmployeeRole";

        /// <summary>
        /// The base salary of the job or of an employee in an EmployeeRole.
        /// </summary>
        [DataMember(Name = "baseSalary", Order = 406)]
        public OneOrManyBaseSalary BaseSalary { get; set; }

        /// <summary>
        /// The currency (coded using &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; ) used for the main salary information in this job posting or for this employee.
        /// </summary>
        [DataMember(Name = "salaryCurrency", Order = 407)]
        public OneOrManySalaryCurrency SalaryCurrency { get; set; }
    }
}
