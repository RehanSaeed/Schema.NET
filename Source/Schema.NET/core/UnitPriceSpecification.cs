namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The price asked for a given offer by the respective organization or person.
    /// </summary>
    [DataContract]
    public partial class UnitPriceSpecification : PriceSpecification
    {
        public interface IBillingIncrement : IValue {}
        public interface IBillingIncrement<T> : IBillingIncrement { new T Value { get; } }
        public class OneOrManyBillingIncrement : OneOrMany<IBillingIncrement>
        {
            public OneOrManyBillingIncrement(IBillingIncrement item) : base(item) { }
            public OneOrManyBillingIncrement(IEnumerable<IBillingIncrement> items) : base(items) { }
            public static implicit operator OneOrManyBillingIncrement (double value) { return new OneOrManyBillingIncrement (new BillingIncrementdouble (value)); }
            public static implicit operator OneOrManyBillingIncrement (double[] values) { return new OneOrManyBillingIncrement (values.Select(v => (IBillingIncrement) new BillingIncrementdouble (v))); }
            public static implicit operator OneOrManyBillingIncrement (List<double> values) { return new OneOrManyBillingIncrement (values.Select(v => (IBillingIncrement) new BillingIncrementdouble (v))); }
        }
        public struct BillingIncrementdouble : IBillingIncrement<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public BillingIncrementdouble (double value) { Value = value; }
            public static implicit operator BillingIncrementdouble (double value) { return new BillingIncrementdouble (value); }
        }

        public interface IPriceType : IValue {}
        public interface IPriceType<T> : IPriceType { new T Value { get; } }
        public class OneOrManyPriceType : OneOrMany<IPriceType>
        {
            public OneOrManyPriceType(IPriceType item) : base(item) { }
            public OneOrManyPriceType(IEnumerable<IPriceType> items) : base(items) { }
            public static implicit operator OneOrManyPriceType (string value) { return new OneOrManyPriceType (new PriceTypestring (value)); }
            public static implicit operator OneOrManyPriceType (string[] values) { return new OneOrManyPriceType (values.Select(v => (IPriceType) new PriceTypestring (v))); }
            public static implicit operator OneOrManyPriceType (List<string> values) { return new OneOrManyPriceType (values.Select(v => (IPriceType) new PriceTypestring (v))); }
        }
        public struct PriceTypestring : IPriceType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PriceTypestring (string value) { Value = value; }
            public static implicit operator PriceTypestring (string value) { return new PriceTypestring (value); }
        }

        public interface IReferenceQuantity : IValue {}
        public interface IReferenceQuantity<T> : IReferenceQuantity { new T Value { get; } }
        public class OneOrManyReferenceQuantity : OneOrMany<IReferenceQuantity>
        {
            public OneOrManyReferenceQuantity(IReferenceQuantity item) : base(item) { }
            public OneOrManyReferenceQuantity(IEnumerable<IReferenceQuantity> items) : base(items) { }
            public static implicit operator OneOrManyReferenceQuantity (QuantitativeValue value) { return new OneOrManyReferenceQuantity (new ReferenceQuantityQuantitativeValue (value)); }
            public static implicit operator OneOrManyReferenceQuantity (QuantitativeValue[] values) { return new OneOrManyReferenceQuantity (values.Select(v => (IReferenceQuantity) new ReferenceQuantityQuantitativeValue (v))); }
            public static implicit operator OneOrManyReferenceQuantity (List<QuantitativeValue> values) { return new OneOrManyReferenceQuantity (values.Select(v => (IReferenceQuantity) new ReferenceQuantityQuantitativeValue (v))); }
        }
        public struct ReferenceQuantityQuantitativeValue : IReferenceQuantity<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public ReferenceQuantityQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator ReferenceQuantityQuantitativeValue (QuantitativeValue value) { return new ReferenceQuantityQuantitativeValue (value); }
        }

        public interface IUnitCode : IValue {}
        public interface IUnitCode<T> : IUnitCode { new T Value { get; } }
        public class OneOrManyUnitCode : OneOrMany<IUnitCode>
        {
            public OneOrManyUnitCode(IUnitCode item) : base(item) { }
            public OneOrManyUnitCode(IEnumerable<IUnitCode> items) : base(items) { }
            public static implicit operator OneOrManyUnitCode (string value) { return new OneOrManyUnitCode (new UnitCodestring (value)); }
            public static implicit operator OneOrManyUnitCode (string[] values) { return new OneOrManyUnitCode (values.Select(v => (IUnitCode) new UnitCodestring (v))); }
            public static implicit operator OneOrManyUnitCode (List<string> values) { return new OneOrManyUnitCode (values.Select(v => (IUnitCode) new UnitCodestring (v))); }
            public static implicit operator OneOrManyUnitCode (Uri value) { return new OneOrManyUnitCode (new UnitCodeUri (value)); }
            public static implicit operator OneOrManyUnitCode (Uri[] values) { return new OneOrManyUnitCode (values.Select(v => (IUnitCode) new UnitCodeUri (v))); }
            public static implicit operator OneOrManyUnitCode (List<Uri> values) { return new OneOrManyUnitCode (values.Select(v => (IUnitCode) new UnitCodeUri (v))); }
        }
        public struct UnitCodestring : IUnitCode<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public UnitCodestring (string value) { Value = value; }
            public static implicit operator UnitCodestring (string value) { return new UnitCodestring (value); }
        }
        public struct UnitCodeUri : IUnitCode<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public UnitCodeUri (Uri value) { Value = value; }
            public static implicit operator UnitCodeUri (Uri value) { return new UnitCodeUri (value); }
        }

        public interface IUnitText : IValue {}
        public interface IUnitText<T> : IUnitText { new T Value { get; } }
        public class OneOrManyUnitText : OneOrMany<IUnitText>
        {
            public OneOrManyUnitText(IUnitText item) : base(item) { }
            public OneOrManyUnitText(IEnumerable<IUnitText> items) : base(items) { }
            public static implicit operator OneOrManyUnitText (string value) { return new OneOrManyUnitText (new UnitTextstring (value)); }
            public static implicit operator OneOrManyUnitText (string[] values) { return new OneOrManyUnitText (values.Select(v => (IUnitText) new UnitTextstring (v))); }
            public static implicit operator OneOrManyUnitText (List<string> values) { return new OneOrManyUnitText (values.Select(v => (IUnitText) new UnitTextstring (v))); }
        }
        public struct UnitTextstring : IUnitText<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public UnitTextstring (string value) { Value = value; }
            public static implicit operator UnitTextstring (string value) { return new UnitTextstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "UnitPriceSpecification";

        /// <summary>
        /// This property specifies the minimal quantity and rounding increment that will be the basis for the billing. The unit of measurement is specified by the unitCode property.
        /// </summary>
        [DataMember(Name = "billingIncrement", Order = 406)]
        public OneOrManyBillingIncrement BillingIncrement { get; set; }

        /// <summary>
        /// A short text or acronym indicating multiple price specifications for the same offer, e.g. SRP for the suggested retail price or INVOICE for the invoice price, mostly used in the car industry.
        /// </summary>
        [DataMember(Name = "priceType", Order = 407)]
        public OneOrManyPriceType PriceType { get; set; }

        /// <summary>
        /// The reference quantity for which a certain price applies, e.g. 1 EUR per 4 kWh of electricity. This property is a replacement for unitOfMeasurement for the advanced cases where the price does not relate to a standard unit.
        /// </summary>
        [DataMember(Name = "referenceQuantity", Order = 408)]
        public OneOrManyReferenceQuantity ReferenceQuantity { get; set; }

        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        [DataMember(Name = "unitCode", Order = 409)]
        public OneOrManyUnitCode UnitCode { get; set; }

        /// <summary>
        /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
        /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "unitText", Order = 410)]
        public OneOrManyUnitText UnitText { get; set; }
    }
}
