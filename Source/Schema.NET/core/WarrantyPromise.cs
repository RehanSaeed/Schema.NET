namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A structured value representing the duration and scope of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.
    /// </summary>
    [DataContract]
    public partial class WarrantyPromise : StructuredValue
    {
        public interface IDurationOfWarranty : IValue {}
        public interface IDurationOfWarranty<T> : IDurationOfWarranty { new T Value { get; } }
        public class OneOrManyDurationOfWarranty : OneOrMany<IDurationOfWarranty>
        {
            public OneOrManyDurationOfWarranty(IDurationOfWarranty item) : base(item) { }
            public OneOrManyDurationOfWarranty(IEnumerable<IDurationOfWarranty> items) : base(items) { }
            public static implicit operator OneOrManyDurationOfWarranty (QuantitativeValue value) { return new OneOrManyDurationOfWarranty (new DurationOfWarrantyQuantitativeValue (value)); }
            public static implicit operator OneOrManyDurationOfWarranty (QuantitativeValue[] values) { return new OneOrManyDurationOfWarranty (values.Select(v => (IDurationOfWarranty) new DurationOfWarrantyQuantitativeValue (v))); }
            public static implicit operator OneOrManyDurationOfWarranty (List<QuantitativeValue> values) { return new OneOrManyDurationOfWarranty (values.Select(v => (IDurationOfWarranty) new DurationOfWarrantyQuantitativeValue (v))); }
        }
        public struct DurationOfWarrantyQuantitativeValue : IDurationOfWarranty<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public DurationOfWarrantyQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator DurationOfWarrantyQuantitativeValue (QuantitativeValue value) { return new DurationOfWarrantyQuantitativeValue (value); }
        }

        public interface IWarrantyScope : IValue {}
        public interface IWarrantyScope<T> : IWarrantyScope { new T Value { get; } }
        public class OneOrManyWarrantyScope : OneOrMany<IWarrantyScope>
        {
            public OneOrManyWarrantyScope(IWarrantyScope item) : base(item) { }
            public OneOrManyWarrantyScope(IEnumerable<IWarrantyScope> items) : base(items) { }
            public static implicit operator OneOrManyWarrantyScope (WarrantyScope value) { return new OneOrManyWarrantyScope (new WarrantyScopeWarrantyScope (value)); }
            public static implicit operator OneOrManyWarrantyScope (WarrantyScope[] values) { return new OneOrManyWarrantyScope (values.Select(v => (IWarrantyScope) new WarrantyScopeWarrantyScope (v))); }
            public static implicit operator OneOrManyWarrantyScope (List<WarrantyScope> values) { return new OneOrManyWarrantyScope (values.Select(v => (IWarrantyScope) new WarrantyScopeWarrantyScope (v))); }
        }
        public struct WarrantyScopeWarrantyScope : IWarrantyScope<WarrantyScope>
        {
            object IValue.Value => this.Value;
            public WarrantyScope Value { get; }
            public WarrantyScopeWarrantyScope (WarrantyScope value) { Value = value; }
            public static implicit operator WarrantyScopeWarrantyScope (WarrantyScope value) { return new WarrantyScopeWarrantyScope (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WarrantyPromise";

        /// <summary>
        /// The duration of the warranty promise. Common unitCode values are ANN for year, MON for months, or DAY for days.
        /// </summary>
        [DataMember(Name = "durationOfWarranty", Order = 306)]
        public OneOrManyDurationOfWarranty DurationOfWarranty { get; set; }

        /// <summary>
        /// The scope of the warranty promise.
        /// </summary>
        [DataMember(Name = "warrantyScope", Order = 307)]
        public OneOrManyWarrantyScope WarrantyScope { get; set; }
    }
}
