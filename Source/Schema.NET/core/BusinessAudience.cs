namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A set of characteristics belonging to businesses, e.g. who compose an item's target audience.
    /// </summary>
    [DataContract]
    public partial class BusinessAudience : Audience
    {
        public interface INumberOfEmployees : IValue {}
        public interface INumberOfEmployees<T> : INumberOfEmployees { new T Value { get; } }
        public class OneOrManyNumberOfEmployees : OneOrMany<INumberOfEmployees>
        {
            public OneOrManyNumberOfEmployees(INumberOfEmployees item) : base(item) { }
            public OneOrManyNumberOfEmployees(IEnumerable<INumberOfEmployees> items) : base(items) { }
            public static implicit operator OneOrManyNumberOfEmployees (QuantitativeValue value) { return new OneOrManyNumberOfEmployees (new NumberOfEmployeesQuantitativeValue (value)); }
            public static implicit operator OneOrManyNumberOfEmployees (QuantitativeValue[] values) { return new OneOrManyNumberOfEmployees (values.Select(v => (INumberOfEmployees) new NumberOfEmployeesQuantitativeValue (v))); }
            public static implicit operator OneOrManyNumberOfEmployees (List<QuantitativeValue> values) { return new OneOrManyNumberOfEmployees (values.Select(v => (INumberOfEmployees) new NumberOfEmployeesQuantitativeValue (v))); }
        }
        public struct NumberOfEmployeesQuantitativeValue : INumberOfEmployees<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public NumberOfEmployeesQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator NumberOfEmployeesQuantitativeValue (QuantitativeValue value) { return new NumberOfEmployeesQuantitativeValue (value); }
        }

        public interface IYearlyRevenue : IValue {}
        public interface IYearlyRevenue<T> : IYearlyRevenue { new T Value { get; } }
        public class OneOrManyYearlyRevenue : OneOrMany<IYearlyRevenue>
        {
            public OneOrManyYearlyRevenue(IYearlyRevenue item) : base(item) { }
            public OneOrManyYearlyRevenue(IEnumerable<IYearlyRevenue> items) : base(items) { }
            public static implicit operator OneOrManyYearlyRevenue (QuantitativeValue value) { return new OneOrManyYearlyRevenue (new YearlyRevenueQuantitativeValue (value)); }
            public static implicit operator OneOrManyYearlyRevenue (QuantitativeValue[] values) { return new OneOrManyYearlyRevenue (values.Select(v => (IYearlyRevenue) new YearlyRevenueQuantitativeValue (v))); }
            public static implicit operator OneOrManyYearlyRevenue (List<QuantitativeValue> values) { return new OneOrManyYearlyRevenue (values.Select(v => (IYearlyRevenue) new YearlyRevenueQuantitativeValue (v))); }
        }
        public struct YearlyRevenueQuantitativeValue : IYearlyRevenue<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public YearlyRevenueQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator YearlyRevenueQuantitativeValue (QuantitativeValue value) { return new YearlyRevenueQuantitativeValue (value); }
        }

        public interface IYearsInOperation : IValue {}
        public interface IYearsInOperation<T> : IYearsInOperation { new T Value { get; } }
        public class OneOrManyYearsInOperation : OneOrMany<IYearsInOperation>
        {
            public OneOrManyYearsInOperation(IYearsInOperation item) : base(item) { }
            public OneOrManyYearsInOperation(IEnumerable<IYearsInOperation> items) : base(items) { }
            public static implicit operator OneOrManyYearsInOperation (QuantitativeValue value) { return new OneOrManyYearsInOperation (new YearsInOperationQuantitativeValue (value)); }
            public static implicit operator OneOrManyYearsInOperation (QuantitativeValue[] values) { return new OneOrManyYearsInOperation (values.Select(v => (IYearsInOperation) new YearsInOperationQuantitativeValue (v))); }
            public static implicit operator OneOrManyYearsInOperation (List<QuantitativeValue> values) { return new OneOrManyYearsInOperation (values.Select(v => (IYearsInOperation) new YearsInOperationQuantitativeValue (v))); }
        }
        public struct YearsInOperationQuantitativeValue : IYearsInOperation<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public YearsInOperationQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator YearsInOperationQuantitativeValue (QuantitativeValue value) { return new YearsInOperationQuantitativeValue (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BusinessAudience";

        /// <summary>
        /// The number of employees in an organization e.g. business.
        /// </summary>
        [DataMember(Name = "numberOfEmployees", Order = 306)]
        public OneOrManyNumberOfEmployees NumberOfEmployees { get; set; }

        /// <summary>
        /// The size of the business in annual revenue.
        /// </summary>
        [DataMember(Name = "yearlyRevenue", Order = 307)]
        public OneOrManyYearlyRevenue YearlyRevenue { get; set; }

        /// <summary>
        /// The age of the business.
        /// </summary>
        [DataMember(Name = "yearsInOperation", Order = 308)]
        public OneOrManyYearsInOperation YearsInOperation { get; set; }
    }
}
