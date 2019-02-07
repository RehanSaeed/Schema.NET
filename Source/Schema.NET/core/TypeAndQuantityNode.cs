namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A structured value indicating the quantity, unit of measurement, and business function of goods included in a bundle offer.
    /// </summary>
    [DataContract]
    public partial class TypeAndQuantityNode : StructuredValue
    {
        public interface IAmountOfThisGood : IValue {}
        public interface IAmountOfThisGood<T> : IAmountOfThisGood { new T Value { get; } }
        public class OneOrManyAmountOfThisGood : OneOrMany<IAmountOfThisGood>
        {
            public OneOrManyAmountOfThisGood(IAmountOfThisGood item) : base(item) { }
            public OneOrManyAmountOfThisGood(IEnumerable<IAmountOfThisGood> items) : base(items) { }
            public static implicit operator OneOrManyAmountOfThisGood (decimal value) { return new OneOrManyAmountOfThisGood (new AmountOfThisGooddecimal (value)); }
            public static implicit operator OneOrManyAmountOfThisGood (decimal[] values) { return new OneOrManyAmountOfThisGood (values.Select(v => (IAmountOfThisGood) new AmountOfThisGooddecimal (v))); }
            public static implicit operator OneOrManyAmountOfThisGood (List<decimal> values) { return new OneOrManyAmountOfThisGood (values.Select(v => (IAmountOfThisGood) new AmountOfThisGooddecimal (v))); }
        }
        public struct AmountOfThisGooddecimal : IAmountOfThisGood<decimal>
        {
            object IValue.Value => this.Value;
            public decimal Value { get; }
            public AmountOfThisGooddecimal (decimal value) { Value = value; }
            public static implicit operator AmountOfThisGooddecimal (decimal value) { return new AmountOfThisGooddecimal (value); }
        }

        public interface IBusinessFunction : IValue {}
        public interface IBusinessFunction<T> : IBusinessFunction { new T Value { get; } }
        public class OneOrManyBusinessFunction : OneOrMany<IBusinessFunction>
        {
            public OneOrManyBusinessFunction(IBusinessFunction item) : base(item) { }
            public OneOrManyBusinessFunction(IEnumerable<IBusinessFunction> items) : base(items) { }
            public static implicit operator OneOrManyBusinessFunction (BusinessFunction value) { return new OneOrManyBusinessFunction (new BusinessFunctionBusinessFunction (value)); }
            public static implicit operator OneOrManyBusinessFunction (BusinessFunction[] values) { return new OneOrManyBusinessFunction (values.Select(v => (IBusinessFunction) new BusinessFunctionBusinessFunction (v))); }
            public static implicit operator OneOrManyBusinessFunction (List<BusinessFunction> values) { return new OneOrManyBusinessFunction (values.Select(v => (IBusinessFunction) new BusinessFunctionBusinessFunction (v))); }
        }
        public struct BusinessFunctionBusinessFunction : IBusinessFunction<BusinessFunction>
        {
            object IValue.Value => this.Value;
            public BusinessFunction Value { get; }
            public BusinessFunctionBusinessFunction (BusinessFunction value) { Value = value; }
            public static implicit operator BusinessFunctionBusinessFunction (BusinessFunction value) { return new BusinessFunctionBusinessFunction (value); }
        }

        public interface ITypeOfGood : IValue {}
        public interface ITypeOfGood<T> : ITypeOfGood { new T Value { get; } }
        public class OneOrManyTypeOfGood : OneOrMany<ITypeOfGood>
        {
            public OneOrManyTypeOfGood(ITypeOfGood item) : base(item) { }
            public OneOrManyTypeOfGood(IEnumerable<ITypeOfGood> items) : base(items) { }
            public static implicit operator OneOrManyTypeOfGood (Product value) { return new OneOrManyTypeOfGood (new TypeOfGoodProduct (value)); }
            public static implicit operator OneOrManyTypeOfGood (Product[] values) { return new OneOrManyTypeOfGood (values.Select(v => (ITypeOfGood) new TypeOfGoodProduct (v))); }
            public static implicit operator OneOrManyTypeOfGood (List<Product> values) { return new OneOrManyTypeOfGood (values.Select(v => (ITypeOfGood) new TypeOfGoodProduct (v))); }
            public static implicit operator OneOrManyTypeOfGood (Service value) { return new OneOrManyTypeOfGood (new TypeOfGoodService (value)); }
            public static implicit operator OneOrManyTypeOfGood (Service[] values) { return new OneOrManyTypeOfGood (values.Select(v => (ITypeOfGood) new TypeOfGoodService (v))); }
            public static implicit operator OneOrManyTypeOfGood (List<Service> values) { return new OneOrManyTypeOfGood (values.Select(v => (ITypeOfGood) new TypeOfGoodService (v))); }
        }
        public struct TypeOfGoodProduct : ITypeOfGood<Product>
        {
            object IValue.Value => this.Value;
            public Product Value { get; }
            public TypeOfGoodProduct (Product value) { Value = value; }
            public static implicit operator TypeOfGoodProduct (Product value) { return new TypeOfGoodProduct (value); }
        }
        public struct TypeOfGoodService : ITypeOfGood<Service>
        {
            object IValue.Value => this.Value;
            public Service Value { get; }
            public TypeOfGoodService (Service value) { Value = value; }
            public static implicit operator TypeOfGoodService (Service value) { return new TypeOfGoodService (value); }
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
        public override string Type => "TypeAndQuantityNode";

        /// <summary>
        /// The quantity of the goods included in the offer.
        /// </summary>
        [DataMember(Name = "amountOfThisGood", Order = 306)]
        public OneOrManyAmountOfThisGood AmountOfThisGood { get; set; }

        /// <summary>
        /// The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
        /// </summary>
        [DataMember(Name = "businessFunction", Order = 307)]
        public OneOrManyBusinessFunction BusinessFunction { get; set; }

        /// <summary>
        /// The product that this structured value is referring to.
        /// </summary>
        [DataMember(Name = "typeOfGood", Order = 308)]
        public OneOrManyTypeOfGood TypeOfGood { get; set; }

        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        [DataMember(Name = "unitCode", Order = 309)]
        public OneOrManyUnitCode UnitCode { get; set; }

        /// <summary>
        /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
        /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "unitText", Order = 310)]
        public OneOrManyUnitText UnitText { get; set; }
    }
}
