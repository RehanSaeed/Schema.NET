namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
    [DataContract]
    public partial class NutritionInformation : StructuredValue
    {
        public interface ICalories : IValue {}
        public interface ICalories<T> : ICalories { new T Value { get; } }
        public class OneOrManyCalories : OneOrMany<ICalories>
        {
            public OneOrManyCalories(ICalories item) : base(item) { }
            public OneOrManyCalories(IEnumerable<ICalories> items) : base(items) { }
            public static implicit operator OneOrManyCalories (string value) { return new OneOrManyCalories (new Caloriesstring (value)); }
            public static implicit operator OneOrManyCalories (string[] values) { return new OneOrManyCalories (values.Select(v => (ICalories) new Caloriesstring (v))); }
            public static implicit operator OneOrManyCalories (List<string> values) { return new OneOrManyCalories (values.Select(v => (ICalories) new Caloriesstring (v))); }
        }
        public struct Caloriesstring : ICalories<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Caloriesstring (string value) { Value = value; }
            public static implicit operator Caloriesstring (string value) { return new Caloriesstring (value); }
        }

        public interface ICarbohydrateContent : IValue {}
        public interface ICarbohydrateContent<T> : ICarbohydrateContent { new T Value { get; } }
        public class OneOrManyCarbohydrateContent : OneOrMany<ICarbohydrateContent>
        {
            public OneOrManyCarbohydrateContent(ICarbohydrateContent item) : base(item) { }
            public OneOrManyCarbohydrateContent(IEnumerable<ICarbohydrateContent> items) : base(items) { }
            public static implicit operator OneOrManyCarbohydrateContent (string value) { return new OneOrManyCarbohydrateContent (new CarbohydrateContentstring (value)); }
            public static implicit operator OneOrManyCarbohydrateContent (string[] values) { return new OneOrManyCarbohydrateContent (values.Select(v => (ICarbohydrateContent) new CarbohydrateContentstring (v))); }
            public static implicit operator OneOrManyCarbohydrateContent (List<string> values) { return new OneOrManyCarbohydrateContent (values.Select(v => (ICarbohydrateContent) new CarbohydrateContentstring (v))); }
        }
        public struct CarbohydrateContentstring : ICarbohydrateContent<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public CarbohydrateContentstring (string value) { Value = value; }
            public static implicit operator CarbohydrateContentstring (string value) { return new CarbohydrateContentstring (value); }
        }

        public interface ICholesterolContent : IValue {}
        public interface ICholesterolContent<T> : ICholesterolContent { new T Value { get; } }
        public class OneOrManyCholesterolContent : OneOrMany<ICholesterolContent>
        {
            public OneOrManyCholesterolContent(ICholesterolContent item) : base(item) { }
            public OneOrManyCholesterolContent(IEnumerable<ICholesterolContent> items) : base(items) { }
            public static implicit operator OneOrManyCholesterolContent (string value) { return new OneOrManyCholesterolContent (new CholesterolContentstring (value)); }
            public static implicit operator OneOrManyCholesterolContent (string[] values) { return new OneOrManyCholesterolContent (values.Select(v => (ICholesterolContent) new CholesterolContentstring (v))); }
            public static implicit operator OneOrManyCholesterolContent (List<string> values) { return new OneOrManyCholesterolContent (values.Select(v => (ICholesterolContent) new CholesterolContentstring (v))); }
        }
        public struct CholesterolContentstring : ICholesterolContent<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public CholesterolContentstring (string value) { Value = value; }
            public static implicit operator CholesterolContentstring (string value) { return new CholesterolContentstring (value); }
        }

        public interface IFatContent : IValue {}
        public interface IFatContent<T> : IFatContent { new T Value { get; } }
        public class OneOrManyFatContent : OneOrMany<IFatContent>
        {
            public OneOrManyFatContent(IFatContent item) : base(item) { }
            public OneOrManyFatContent(IEnumerable<IFatContent> items) : base(items) { }
            public static implicit operator OneOrManyFatContent (string value) { return new OneOrManyFatContent (new FatContentstring (value)); }
            public static implicit operator OneOrManyFatContent (string[] values) { return new OneOrManyFatContent (values.Select(v => (IFatContent) new FatContentstring (v))); }
            public static implicit operator OneOrManyFatContent (List<string> values) { return new OneOrManyFatContent (values.Select(v => (IFatContent) new FatContentstring (v))); }
        }
        public struct FatContentstring : IFatContent<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public FatContentstring (string value) { Value = value; }
            public static implicit operator FatContentstring (string value) { return new FatContentstring (value); }
        }

        public interface IFiberContent : IValue {}
        public interface IFiberContent<T> : IFiberContent { new T Value { get; } }
        public class OneOrManyFiberContent : OneOrMany<IFiberContent>
        {
            public OneOrManyFiberContent(IFiberContent item) : base(item) { }
            public OneOrManyFiberContent(IEnumerable<IFiberContent> items) : base(items) { }
            public static implicit operator OneOrManyFiberContent (string value) { return new OneOrManyFiberContent (new FiberContentstring (value)); }
            public static implicit operator OneOrManyFiberContent (string[] values) { return new OneOrManyFiberContent (values.Select(v => (IFiberContent) new FiberContentstring (v))); }
            public static implicit operator OneOrManyFiberContent (List<string> values) { return new OneOrManyFiberContent (values.Select(v => (IFiberContent) new FiberContentstring (v))); }
        }
        public struct FiberContentstring : IFiberContent<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public FiberContentstring (string value) { Value = value; }
            public static implicit operator FiberContentstring (string value) { return new FiberContentstring (value); }
        }

        public interface IProteinContent : IValue {}
        public interface IProteinContent<T> : IProteinContent { new T Value { get; } }
        public class OneOrManyProteinContent : OneOrMany<IProteinContent>
        {
            public OneOrManyProteinContent(IProteinContent item) : base(item) { }
            public OneOrManyProteinContent(IEnumerable<IProteinContent> items) : base(items) { }
            public static implicit operator OneOrManyProteinContent (string value) { return new OneOrManyProteinContent (new ProteinContentstring (value)); }
            public static implicit operator OneOrManyProteinContent (string[] values) { return new OneOrManyProteinContent (values.Select(v => (IProteinContent) new ProteinContentstring (v))); }
            public static implicit operator OneOrManyProteinContent (List<string> values) { return new OneOrManyProteinContent (values.Select(v => (IProteinContent) new ProteinContentstring (v))); }
        }
        public struct ProteinContentstring : IProteinContent<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ProteinContentstring (string value) { Value = value; }
            public static implicit operator ProteinContentstring (string value) { return new ProteinContentstring (value); }
        }

        public interface ISaturatedFatContent : IValue {}
        public interface ISaturatedFatContent<T> : ISaturatedFatContent { new T Value { get; } }
        public class OneOrManySaturatedFatContent : OneOrMany<ISaturatedFatContent>
        {
            public OneOrManySaturatedFatContent(ISaturatedFatContent item) : base(item) { }
            public OneOrManySaturatedFatContent(IEnumerable<ISaturatedFatContent> items) : base(items) { }
            public static implicit operator OneOrManySaturatedFatContent (string value) { return new OneOrManySaturatedFatContent (new SaturatedFatContentstring (value)); }
            public static implicit operator OneOrManySaturatedFatContent (string[] values) { return new OneOrManySaturatedFatContent (values.Select(v => (ISaturatedFatContent) new SaturatedFatContentstring (v))); }
            public static implicit operator OneOrManySaturatedFatContent (List<string> values) { return new OneOrManySaturatedFatContent (values.Select(v => (ISaturatedFatContent) new SaturatedFatContentstring (v))); }
        }
        public struct SaturatedFatContentstring : ISaturatedFatContent<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SaturatedFatContentstring (string value) { Value = value; }
            public static implicit operator SaturatedFatContentstring (string value) { return new SaturatedFatContentstring (value); }
        }

        public interface IServingSize : IValue {}
        public interface IServingSize<T> : IServingSize { new T Value { get; } }
        public class OneOrManyServingSize : OneOrMany<IServingSize>
        {
            public OneOrManyServingSize(IServingSize item) : base(item) { }
            public OneOrManyServingSize(IEnumerable<IServingSize> items) : base(items) { }
            public static implicit operator OneOrManyServingSize (string value) { return new OneOrManyServingSize (new ServingSizestring (value)); }
            public static implicit operator OneOrManyServingSize (string[] values) { return new OneOrManyServingSize (values.Select(v => (IServingSize) new ServingSizestring (v))); }
            public static implicit operator OneOrManyServingSize (List<string> values) { return new OneOrManyServingSize (values.Select(v => (IServingSize) new ServingSizestring (v))); }
        }
        public struct ServingSizestring : IServingSize<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ServingSizestring (string value) { Value = value; }
            public static implicit operator ServingSizestring (string value) { return new ServingSizestring (value); }
        }

        public interface ISodiumContent : IValue {}
        public interface ISodiumContent<T> : ISodiumContent { new T Value { get; } }
        public class OneOrManySodiumContent : OneOrMany<ISodiumContent>
        {
            public OneOrManySodiumContent(ISodiumContent item) : base(item) { }
            public OneOrManySodiumContent(IEnumerable<ISodiumContent> items) : base(items) { }
            public static implicit operator OneOrManySodiumContent (string value) { return new OneOrManySodiumContent (new SodiumContentstring (value)); }
            public static implicit operator OneOrManySodiumContent (string[] values) { return new OneOrManySodiumContent (values.Select(v => (ISodiumContent) new SodiumContentstring (v))); }
            public static implicit operator OneOrManySodiumContent (List<string> values) { return new OneOrManySodiumContent (values.Select(v => (ISodiumContent) new SodiumContentstring (v))); }
        }
        public struct SodiumContentstring : ISodiumContent<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SodiumContentstring (string value) { Value = value; }
            public static implicit operator SodiumContentstring (string value) { return new SodiumContentstring (value); }
        }

        public interface ISugarContent : IValue {}
        public interface ISugarContent<T> : ISugarContent { new T Value { get; } }
        public class OneOrManySugarContent : OneOrMany<ISugarContent>
        {
            public OneOrManySugarContent(ISugarContent item) : base(item) { }
            public OneOrManySugarContent(IEnumerable<ISugarContent> items) : base(items) { }
            public static implicit operator OneOrManySugarContent (string value) { return new OneOrManySugarContent (new SugarContentstring (value)); }
            public static implicit operator OneOrManySugarContent (string[] values) { return new OneOrManySugarContent (values.Select(v => (ISugarContent) new SugarContentstring (v))); }
            public static implicit operator OneOrManySugarContent (List<string> values) { return new OneOrManySugarContent (values.Select(v => (ISugarContent) new SugarContentstring (v))); }
        }
        public struct SugarContentstring : ISugarContent<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SugarContentstring (string value) { Value = value; }
            public static implicit operator SugarContentstring (string value) { return new SugarContentstring (value); }
        }

        public interface ITransFatContent : IValue {}
        public interface ITransFatContent<T> : ITransFatContent { new T Value { get; } }
        public class OneOrManyTransFatContent : OneOrMany<ITransFatContent>
        {
            public OneOrManyTransFatContent(ITransFatContent item) : base(item) { }
            public OneOrManyTransFatContent(IEnumerable<ITransFatContent> items) : base(items) { }
            public static implicit operator OneOrManyTransFatContent (string value) { return new OneOrManyTransFatContent (new TransFatContentstring (value)); }
            public static implicit operator OneOrManyTransFatContent (string[] values) { return new OneOrManyTransFatContent (values.Select(v => (ITransFatContent) new TransFatContentstring (v))); }
            public static implicit operator OneOrManyTransFatContent (List<string> values) { return new OneOrManyTransFatContent (values.Select(v => (ITransFatContent) new TransFatContentstring (v))); }
        }
        public struct TransFatContentstring : ITransFatContent<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public TransFatContentstring (string value) { Value = value; }
            public static implicit operator TransFatContentstring (string value) { return new TransFatContentstring (value); }
        }

        public interface IUnsaturatedFatContent : IValue {}
        public interface IUnsaturatedFatContent<T> : IUnsaturatedFatContent { new T Value { get; } }
        public class OneOrManyUnsaturatedFatContent : OneOrMany<IUnsaturatedFatContent>
        {
            public OneOrManyUnsaturatedFatContent(IUnsaturatedFatContent item) : base(item) { }
            public OneOrManyUnsaturatedFatContent(IEnumerable<IUnsaturatedFatContent> items) : base(items) { }
            public static implicit operator OneOrManyUnsaturatedFatContent (string value) { return new OneOrManyUnsaturatedFatContent (new UnsaturatedFatContentstring (value)); }
            public static implicit operator OneOrManyUnsaturatedFatContent (string[] values) { return new OneOrManyUnsaturatedFatContent (values.Select(v => (IUnsaturatedFatContent) new UnsaturatedFatContentstring (v))); }
            public static implicit operator OneOrManyUnsaturatedFatContent (List<string> values) { return new OneOrManyUnsaturatedFatContent (values.Select(v => (IUnsaturatedFatContent) new UnsaturatedFatContentstring (v))); }
        }
        public struct UnsaturatedFatContentstring : IUnsaturatedFatContent<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public UnsaturatedFatContentstring (string value) { Value = value; }
            public static implicit operator UnsaturatedFatContentstring (string value) { return new UnsaturatedFatContentstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "NutritionInformation";

        /// <summary>
        /// The number of calories.
        /// </summary>
        [DataMember(Name = "calories", Order = 306)]
        public OneOrManyCalories Calories { get; set; }

        /// <summary>
        /// The number of grams of carbohydrates.
        /// </summary>
        [DataMember(Name = "carbohydrateContent", Order = 307)]
        public OneOrManyCarbohydrateContent CarbohydrateContent { get; set; }

        /// <summary>
        /// The number of milligrams of cholesterol.
        /// </summary>
        [DataMember(Name = "cholesterolContent", Order = 308)]
        public OneOrManyCholesterolContent CholesterolContent { get; set; }

        /// <summary>
        /// The number of grams of fat.
        /// </summary>
        [DataMember(Name = "fatContent", Order = 309)]
        public OneOrManyFatContent FatContent { get; set; }

        /// <summary>
        /// The number of grams of fiber.
        /// </summary>
        [DataMember(Name = "fiberContent", Order = 310)]
        public OneOrManyFiberContent FiberContent { get; set; }

        /// <summary>
        /// The number of grams of protein.
        /// </summary>
        [DataMember(Name = "proteinContent", Order = 311)]
        public OneOrManyProteinContent ProteinContent { get; set; }

        /// <summary>
        /// The number of grams of saturated fat.
        /// </summary>
        [DataMember(Name = "saturatedFatContent", Order = 312)]
        public OneOrManySaturatedFatContent SaturatedFatContent { get; set; }

        /// <summary>
        /// The serving size, in terms of the number of volume or mass.
        /// </summary>
        [DataMember(Name = "servingSize", Order = 313)]
        public OneOrManyServingSize ServingSize { get; set; }

        /// <summary>
        /// The number of milligrams of sodium.
        /// </summary>
        [DataMember(Name = "sodiumContent", Order = 314)]
        public OneOrManySodiumContent SodiumContent { get; set; }

        /// <summary>
        /// The number of grams of sugar.
        /// </summary>
        [DataMember(Name = "sugarContent", Order = 315)]
        public OneOrManySugarContent SugarContent { get; set; }

        /// <summary>
        /// The number of grams of trans fat.
        /// </summary>
        [DataMember(Name = "transFatContent", Order = 316)]
        public OneOrManyTransFatContent TransFatContent { get; set; }

        /// <summary>
        /// The number of grams of unsaturated fat.
        /// </summary>
        [DataMember(Name = "unsaturatedFatContent", Order = 317)]
        public OneOrManyUnsaturatedFatContent UnsaturatedFatContent { get; set; }
    }
}
