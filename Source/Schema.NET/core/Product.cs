namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
    [DataContract]
    public partial class Product : Thing
    {
        public interface IAdditionalProperty : IValue {}
        public interface IAdditionalProperty<T> : IAdditionalProperty { new T Value { get; } }
        public class OneOrManyAdditionalProperty : OneOrMany<IAdditionalProperty>
        {
            public OneOrManyAdditionalProperty(IAdditionalProperty item) : base(item) { }
            public OneOrManyAdditionalProperty(IEnumerable<IAdditionalProperty> items) : base(items) { }
            public static implicit operator OneOrManyAdditionalProperty (PropertyValue value) { return new OneOrManyAdditionalProperty (new AdditionalPropertyPropertyValue (value)); }
            public static implicit operator OneOrManyAdditionalProperty (PropertyValue[] values) { return new OneOrManyAdditionalProperty (values.Select(v => (IAdditionalProperty) new AdditionalPropertyPropertyValue (v))); }
            public static implicit operator OneOrManyAdditionalProperty (List<PropertyValue> values) { return new OneOrManyAdditionalProperty (values.Select(v => (IAdditionalProperty) new AdditionalPropertyPropertyValue (v))); }
        }
        public struct AdditionalPropertyPropertyValue : IAdditionalProperty<PropertyValue>
        {
            object IValue.Value => this.Value;
            public PropertyValue Value { get; }
            public AdditionalPropertyPropertyValue (PropertyValue value) { Value = value; }
            public static implicit operator AdditionalPropertyPropertyValue (PropertyValue value) { return new AdditionalPropertyPropertyValue (value); }
        }

        public interface IAggregateRating : IValue {}
        public interface IAggregateRating<T> : IAggregateRating { new T Value { get; } }
        public class OneOrManyAggregateRating : OneOrMany<IAggregateRating>
        {
            public OneOrManyAggregateRating(IAggregateRating item) : base(item) { }
            public OneOrManyAggregateRating(IEnumerable<IAggregateRating> items) : base(items) { }
            public static implicit operator OneOrManyAggregateRating (AggregateRating value) { return new OneOrManyAggregateRating (new AggregateRatingAggregateRating (value)); }
            public static implicit operator OneOrManyAggregateRating (AggregateRating[] values) { return new OneOrManyAggregateRating (values.Select(v => (IAggregateRating) new AggregateRatingAggregateRating (v))); }
            public static implicit operator OneOrManyAggregateRating (List<AggregateRating> values) { return new OneOrManyAggregateRating (values.Select(v => (IAggregateRating) new AggregateRatingAggregateRating (v))); }
        }
        public struct AggregateRatingAggregateRating : IAggregateRating<AggregateRating>
        {
            object IValue.Value => this.Value;
            public AggregateRating Value { get; }
            public AggregateRatingAggregateRating (AggregateRating value) { Value = value; }
            public static implicit operator AggregateRatingAggregateRating (AggregateRating value) { return new AggregateRatingAggregateRating (value); }
        }

        public interface IAudience : IValue {}
        public interface IAudience<T> : IAudience { new T Value { get; } }
        public class OneOrManyAudience : OneOrMany<IAudience>
        {
            public OneOrManyAudience(IAudience item) : base(item) { }
            public OneOrManyAudience(IEnumerable<IAudience> items) : base(items) { }
            public static implicit operator OneOrManyAudience (Audience value) { return new OneOrManyAudience (new AudienceAudience (value)); }
            public static implicit operator OneOrManyAudience (Audience[] values) { return new OneOrManyAudience (values.Select(v => (IAudience) new AudienceAudience (v))); }
            public static implicit operator OneOrManyAudience (List<Audience> values) { return new OneOrManyAudience (values.Select(v => (IAudience) new AudienceAudience (v))); }
        }
        public struct AudienceAudience : IAudience<Audience>
        {
            object IValue.Value => this.Value;
            public Audience Value { get; }
            public AudienceAudience (Audience value) { Value = value; }
            public static implicit operator AudienceAudience (Audience value) { return new AudienceAudience (value); }
        }

        public interface IAward : IValue {}
        public interface IAward<T> : IAward { new T Value { get; } }
        public class OneOrManyAward : OneOrMany<IAward>
        {
            public OneOrManyAward(IAward item) : base(item) { }
            public OneOrManyAward(IEnumerable<IAward> items) : base(items) { }
            public static implicit operator OneOrManyAward (string value) { return new OneOrManyAward (new Awardstring (value)); }
            public static implicit operator OneOrManyAward (string[] values) { return new OneOrManyAward (values.Select(v => (IAward) new Awardstring (v))); }
            public static implicit operator OneOrManyAward (List<string> values) { return new OneOrManyAward (values.Select(v => (IAward) new Awardstring (v))); }
        }
        public struct Awardstring : IAward<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Awardstring (string value) { Value = value; }
            public static implicit operator Awardstring (string value) { return new Awardstring (value); }
        }

        public interface IBrand : IValue {}
        public interface IBrand<T> : IBrand { new T Value { get; } }
        public class OneOrManyBrand : OneOrMany<IBrand>
        {
            public OneOrManyBrand(IBrand item) : base(item) { }
            public OneOrManyBrand(IEnumerable<IBrand> items) : base(items) { }
            public static implicit operator OneOrManyBrand (Brand value) { return new OneOrManyBrand (new BrandBrand (value)); }
            public static implicit operator OneOrManyBrand (Brand[] values) { return new OneOrManyBrand (values.Select(v => (IBrand) new BrandBrand (v))); }
            public static implicit operator OneOrManyBrand (List<Brand> values) { return new OneOrManyBrand (values.Select(v => (IBrand) new BrandBrand (v))); }
            public static implicit operator OneOrManyBrand (Organization value) { return new OneOrManyBrand (new BrandOrganization (value)); }
            public static implicit operator OneOrManyBrand (Organization[] values) { return new OneOrManyBrand (values.Select(v => (IBrand) new BrandOrganization (v))); }
            public static implicit operator OneOrManyBrand (List<Organization> values) { return new OneOrManyBrand (values.Select(v => (IBrand) new BrandOrganization (v))); }
        }
        public struct BrandBrand : IBrand<Brand>
        {
            object IValue.Value => this.Value;
            public Brand Value { get; }
            public BrandBrand (Brand value) { Value = value; }
            public static implicit operator BrandBrand (Brand value) { return new BrandBrand (value); }
        }
        public struct BrandOrganization : IBrand<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public BrandOrganization (Organization value) { Value = value; }
            public static implicit operator BrandOrganization (Organization value) { return new BrandOrganization (value); }
        }

        public interface ICategory : IValue {}
        public interface ICategory<T> : ICategory { new T Value { get; } }
        public class OneOrManyCategory : OneOrMany<ICategory>
        {
            public OneOrManyCategory(ICategory item) : base(item) { }
            public OneOrManyCategory(IEnumerable<ICategory> items) : base(items) { }
            public static implicit operator OneOrManyCategory (string value) { return new OneOrManyCategory (new Categorystring (value)); }
            public static implicit operator OneOrManyCategory (string[] values) { return new OneOrManyCategory (values.Select(v => (ICategory) new Categorystring (v))); }
            public static implicit operator OneOrManyCategory (List<string> values) { return new OneOrManyCategory (values.Select(v => (ICategory) new Categorystring (v))); }
            public static implicit operator OneOrManyCategory (Thing value) { return new OneOrManyCategory (new CategoryThing (value)); }
            public static implicit operator OneOrManyCategory (Thing[] values) { return new OneOrManyCategory (values.Select(v => (ICategory) new CategoryThing (v))); }
            public static implicit operator OneOrManyCategory (List<Thing> values) { return new OneOrManyCategory (values.Select(v => (ICategory) new CategoryThing (v))); }
        }
        public struct Categorystring : ICategory<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Categorystring (string value) { Value = value; }
            public static implicit operator Categorystring (string value) { return new Categorystring (value); }
        }
        public struct CategoryThing : ICategory<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public CategoryThing (Thing value) { Value = value; }
            public static implicit operator CategoryThing (Thing value) { return new CategoryThing (value); }
        }

        public interface IColor : IValue {}
        public interface IColor<T> : IColor { new T Value { get; } }
        public class OneOrManyColor : OneOrMany<IColor>
        {
            public OneOrManyColor(IColor item) : base(item) { }
            public OneOrManyColor(IEnumerable<IColor> items) : base(items) { }
            public static implicit operator OneOrManyColor (string value) { return new OneOrManyColor (new Colorstring (value)); }
            public static implicit operator OneOrManyColor (string[] values) { return new OneOrManyColor (values.Select(v => (IColor) new Colorstring (v))); }
            public static implicit operator OneOrManyColor (List<string> values) { return new OneOrManyColor (values.Select(v => (IColor) new Colorstring (v))); }
        }
        public struct Colorstring : IColor<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Colorstring (string value) { Value = value; }
            public static implicit operator Colorstring (string value) { return new Colorstring (value); }
        }

        public interface IDepth : IValue {}
        public interface IDepth<T> : IDepth { new T Value { get; } }
        public class OneOrManyDepth : OneOrMany<IDepth>
        {
            public OneOrManyDepth(IDepth item) : base(item) { }
            public OneOrManyDepth(IEnumerable<IDepth> items) : base(items) { }
            public static implicit operator OneOrManyDepth (string value) { return new OneOrManyDepth (new Depthstring (value)); }
            public static implicit operator OneOrManyDepth (string[] values) { return new OneOrManyDepth (values.Select(v => (IDepth) new Depthstring (v))); }
            public static implicit operator OneOrManyDepth (List<string> values) { return new OneOrManyDepth (values.Select(v => (IDepth) new Depthstring (v))); }
            public static implicit operator OneOrManyDepth (QuantitativeValue value) { return new OneOrManyDepth (new DepthQuantitativeValue (value)); }
            public static implicit operator OneOrManyDepth (QuantitativeValue[] values) { return new OneOrManyDepth (values.Select(v => (IDepth) new DepthQuantitativeValue (v))); }
            public static implicit operator OneOrManyDepth (List<QuantitativeValue> values) { return new OneOrManyDepth (values.Select(v => (IDepth) new DepthQuantitativeValue (v))); }
        }
        public struct Depthstring : IDepth<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Depthstring (string value) { Value = value; }
            public static implicit operator Depthstring (string value) { return new Depthstring (value); }
        }
        public struct DepthQuantitativeValue : IDepth<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public DepthQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator DepthQuantitativeValue (QuantitativeValue value) { return new DepthQuantitativeValue (value); }
        }

        public interface IGtin12 : IValue {}
        public interface IGtin12<T> : IGtin12 { new T Value { get; } }
        public class OneOrManyGtin12 : OneOrMany<IGtin12>
        {
            public OneOrManyGtin12(IGtin12 item) : base(item) { }
            public OneOrManyGtin12(IEnumerable<IGtin12> items) : base(items) { }
            public static implicit operator OneOrManyGtin12 (string value) { return new OneOrManyGtin12 (new Gtin12string (value)); }
            public static implicit operator OneOrManyGtin12 (string[] values) { return new OneOrManyGtin12 (values.Select(v => (IGtin12) new Gtin12string (v))); }
            public static implicit operator OneOrManyGtin12 (List<string> values) { return new OneOrManyGtin12 (values.Select(v => (IGtin12) new Gtin12string (v))); }
        }
        public struct Gtin12string : IGtin12<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Gtin12string (string value) { Value = value; }
            public static implicit operator Gtin12string (string value) { return new Gtin12string (value); }
        }

        public interface IGtin13 : IValue {}
        public interface IGtin13<T> : IGtin13 { new T Value { get; } }
        public class OneOrManyGtin13 : OneOrMany<IGtin13>
        {
            public OneOrManyGtin13(IGtin13 item) : base(item) { }
            public OneOrManyGtin13(IEnumerable<IGtin13> items) : base(items) { }
            public static implicit operator OneOrManyGtin13 (string value) { return new OneOrManyGtin13 (new Gtin13string (value)); }
            public static implicit operator OneOrManyGtin13 (string[] values) { return new OneOrManyGtin13 (values.Select(v => (IGtin13) new Gtin13string (v))); }
            public static implicit operator OneOrManyGtin13 (List<string> values) { return new OneOrManyGtin13 (values.Select(v => (IGtin13) new Gtin13string (v))); }
        }
        public struct Gtin13string : IGtin13<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Gtin13string (string value) { Value = value; }
            public static implicit operator Gtin13string (string value) { return new Gtin13string (value); }
        }

        public interface IGtin14 : IValue {}
        public interface IGtin14<T> : IGtin14 { new T Value { get; } }
        public class OneOrManyGtin14 : OneOrMany<IGtin14>
        {
            public OneOrManyGtin14(IGtin14 item) : base(item) { }
            public OneOrManyGtin14(IEnumerable<IGtin14> items) : base(items) { }
            public static implicit operator OneOrManyGtin14 (string value) { return new OneOrManyGtin14 (new Gtin14string (value)); }
            public static implicit operator OneOrManyGtin14 (string[] values) { return new OneOrManyGtin14 (values.Select(v => (IGtin14) new Gtin14string (v))); }
            public static implicit operator OneOrManyGtin14 (List<string> values) { return new OneOrManyGtin14 (values.Select(v => (IGtin14) new Gtin14string (v))); }
        }
        public struct Gtin14string : IGtin14<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Gtin14string (string value) { Value = value; }
            public static implicit operator Gtin14string (string value) { return new Gtin14string (value); }
        }

        public interface IGtin8 : IValue {}
        public interface IGtin8<T> : IGtin8 { new T Value { get; } }
        public class OneOrManyGtin8 : OneOrMany<IGtin8>
        {
            public OneOrManyGtin8(IGtin8 item) : base(item) { }
            public OneOrManyGtin8(IEnumerable<IGtin8> items) : base(items) { }
            public static implicit operator OneOrManyGtin8 (string value) { return new OneOrManyGtin8 (new Gtin8string (value)); }
            public static implicit operator OneOrManyGtin8 (string[] values) { return new OneOrManyGtin8 (values.Select(v => (IGtin8) new Gtin8string (v))); }
            public static implicit operator OneOrManyGtin8 (List<string> values) { return new OneOrManyGtin8 (values.Select(v => (IGtin8) new Gtin8string (v))); }
        }
        public struct Gtin8string : IGtin8<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Gtin8string (string value) { Value = value; }
            public static implicit operator Gtin8string (string value) { return new Gtin8string (value); }
        }

        public interface IHeight : IValue {}
        public interface IHeight<T> : IHeight { new T Value { get; } }
        public class OneOrManyHeight : OneOrMany<IHeight>
        {
            public OneOrManyHeight(IHeight item) : base(item) { }
            public OneOrManyHeight(IEnumerable<IHeight> items) : base(items) { }
            public static implicit operator OneOrManyHeight (string value) { return new OneOrManyHeight (new Heightstring (value)); }
            public static implicit operator OneOrManyHeight (string[] values) { return new OneOrManyHeight (values.Select(v => (IHeight) new Heightstring (v))); }
            public static implicit operator OneOrManyHeight (List<string> values) { return new OneOrManyHeight (values.Select(v => (IHeight) new Heightstring (v))); }
            public static implicit operator OneOrManyHeight (QuantitativeValue value) { return new OneOrManyHeight (new HeightQuantitativeValue (value)); }
            public static implicit operator OneOrManyHeight (QuantitativeValue[] values) { return new OneOrManyHeight (values.Select(v => (IHeight) new HeightQuantitativeValue (v))); }
            public static implicit operator OneOrManyHeight (List<QuantitativeValue> values) { return new OneOrManyHeight (values.Select(v => (IHeight) new HeightQuantitativeValue (v))); }
        }
        public struct Heightstring : IHeight<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Heightstring (string value) { Value = value; }
            public static implicit operator Heightstring (string value) { return new Heightstring (value); }
        }
        public struct HeightQuantitativeValue : IHeight<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public HeightQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator HeightQuantitativeValue (QuantitativeValue value) { return new HeightQuantitativeValue (value); }
        }

        public interface IIsAccessoryOrSparePartFor : IValue {}
        public interface IIsAccessoryOrSparePartFor<T> : IIsAccessoryOrSparePartFor { new T Value { get; } }
        public class OneOrManyIsAccessoryOrSparePartFor : OneOrMany<IIsAccessoryOrSparePartFor>
        {
            public OneOrManyIsAccessoryOrSparePartFor(IIsAccessoryOrSparePartFor item) : base(item) { }
            public OneOrManyIsAccessoryOrSparePartFor(IEnumerable<IIsAccessoryOrSparePartFor> items) : base(items) { }
            public static implicit operator OneOrManyIsAccessoryOrSparePartFor (Product value) { return new OneOrManyIsAccessoryOrSparePartFor (new IsAccessoryOrSparePartForProduct (value)); }
            public static implicit operator OneOrManyIsAccessoryOrSparePartFor (Product[] values) { return new OneOrManyIsAccessoryOrSparePartFor (values.Select(v => (IIsAccessoryOrSparePartFor) new IsAccessoryOrSparePartForProduct (v))); }
            public static implicit operator OneOrManyIsAccessoryOrSparePartFor (List<Product> values) { return new OneOrManyIsAccessoryOrSparePartFor (values.Select(v => (IIsAccessoryOrSparePartFor) new IsAccessoryOrSparePartForProduct (v))); }
        }
        public struct IsAccessoryOrSparePartForProduct : IIsAccessoryOrSparePartFor<Product>
        {
            object IValue.Value => this.Value;
            public Product Value { get; }
            public IsAccessoryOrSparePartForProduct (Product value) { Value = value; }
            public static implicit operator IsAccessoryOrSparePartForProduct (Product value) { return new IsAccessoryOrSparePartForProduct (value); }
        }

        public interface IIsConsumableFor : IValue {}
        public interface IIsConsumableFor<T> : IIsConsumableFor { new T Value { get; } }
        public class OneOrManyIsConsumableFor : OneOrMany<IIsConsumableFor>
        {
            public OneOrManyIsConsumableFor(IIsConsumableFor item) : base(item) { }
            public OneOrManyIsConsumableFor(IEnumerable<IIsConsumableFor> items) : base(items) { }
            public static implicit operator OneOrManyIsConsumableFor (Product value) { return new OneOrManyIsConsumableFor (new IsConsumableForProduct (value)); }
            public static implicit operator OneOrManyIsConsumableFor (Product[] values) { return new OneOrManyIsConsumableFor (values.Select(v => (IIsConsumableFor) new IsConsumableForProduct (v))); }
            public static implicit operator OneOrManyIsConsumableFor (List<Product> values) { return new OneOrManyIsConsumableFor (values.Select(v => (IIsConsumableFor) new IsConsumableForProduct (v))); }
        }
        public struct IsConsumableForProduct : IIsConsumableFor<Product>
        {
            object IValue.Value => this.Value;
            public Product Value { get; }
            public IsConsumableForProduct (Product value) { Value = value; }
            public static implicit operator IsConsumableForProduct (Product value) { return new IsConsumableForProduct (value); }
        }

        public interface IIsRelatedTo : IValue {}
        public interface IIsRelatedTo<T> : IIsRelatedTo { new T Value { get; } }
        public class OneOrManyIsRelatedTo : OneOrMany<IIsRelatedTo>
        {
            public OneOrManyIsRelatedTo(IIsRelatedTo item) : base(item) { }
            public OneOrManyIsRelatedTo(IEnumerable<IIsRelatedTo> items) : base(items) { }
            public static implicit operator OneOrManyIsRelatedTo (Product value) { return new OneOrManyIsRelatedTo (new IsRelatedToProduct (value)); }
            public static implicit operator OneOrManyIsRelatedTo (Product[] values) { return new OneOrManyIsRelatedTo (values.Select(v => (IIsRelatedTo) new IsRelatedToProduct (v))); }
            public static implicit operator OneOrManyIsRelatedTo (List<Product> values) { return new OneOrManyIsRelatedTo (values.Select(v => (IIsRelatedTo) new IsRelatedToProduct (v))); }
            public static implicit operator OneOrManyIsRelatedTo (Service value) { return new OneOrManyIsRelatedTo (new IsRelatedToService (value)); }
            public static implicit operator OneOrManyIsRelatedTo (Service[] values) { return new OneOrManyIsRelatedTo (values.Select(v => (IIsRelatedTo) new IsRelatedToService (v))); }
            public static implicit operator OneOrManyIsRelatedTo (List<Service> values) { return new OneOrManyIsRelatedTo (values.Select(v => (IIsRelatedTo) new IsRelatedToService (v))); }
        }
        public struct IsRelatedToProduct : IIsRelatedTo<Product>
        {
            object IValue.Value => this.Value;
            public Product Value { get; }
            public IsRelatedToProduct (Product value) { Value = value; }
            public static implicit operator IsRelatedToProduct (Product value) { return new IsRelatedToProduct (value); }
        }
        public struct IsRelatedToService : IIsRelatedTo<Service>
        {
            object IValue.Value => this.Value;
            public Service Value { get; }
            public IsRelatedToService (Service value) { Value = value; }
            public static implicit operator IsRelatedToService (Service value) { return new IsRelatedToService (value); }
        }

        public interface IIsSimilarTo : IValue {}
        public interface IIsSimilarTo<T> : IIsSimilarTo { new T Value { get; } }
        public class OneOrManyIsSimilarTo : OneOrMany<IIsSimilarTo>
        {
            public OneOrManyIsSimilarTo(IIsSimilarTo item) : base(item) { }
            public OneOrManyIsSimilarTo(IEnumerable<IIsSimilarTo> items) : base(items) { }
            public static implicit operator OneOrManyIsSimilarTo (Product value) { return new OneOrManyIsSimilarTo (new IsSimilarToProduct (value)); }
            public static implicit operator OneOrManyIsSimilarTo (Product[] values) { return new OneOrManyIsSimilarTo (values.Select(v => (IIsSimilarTo) new IsSimilarToProduct (v))); }
            public static implicit operator OneOrManyIsSimilarTo (List<Product> values) { return new OneOrManyIsSimilarTo (values.Select(v => (IIsSimilarTo) new IsSimilarToProduct (v))); }
            public static implicit operator OneOrManyIsSimilarTo (Service value) { return new OneOrManyIsSimilarTo (new IsSimilarToService (value)); }
            public static implicit operator OneOrManyIsSimilarTo (Service[] values) { return new OneOrManyIsSimilarTo (values.Select(v => (IIsSimilarTo) new IsSimilarToService (v))); }
            public static implicit operator OneOrManyIsSimilarTo (List<Service> values) { return new OneOrManyIsSimilarTo (values.Select(v => (IIsSimilarTo) new IsSimilarToService (v))); }
        }
        public struct IsSimilarToProduct : IIsSimilarTo<Product>
        {
            object IValue.Value => this.Value;
            public Product Value { get; }
            public IsSimilarToProduct (Product value) { Value = value; }
            public static implicit operator IsSimilarToProduct (Product value) { return new IsSimilarToProduct (value); }
        }
        public struct IsSimilarToService : IIsSimilarTo<Service>
        {
            object IValue.Value => this.Value;
            public Service Value { get; }
            public IsSimilarToService (Service value) { Value = value; }
            public static implicit operator IsSimilarToService (Service value) { return new IsSimilarToService (value); }
        }

        public interface IItemCondition : IValue {}
        public interface IItemCondition<T> : IItemCondition { new T Value { get; } }
        public class OneOrManyItemCondition : OneOrMany<IItemCondition>
        {
            public OneOrManyItemCondition(IItemCondition item) : base(item) { }
            public OneOrManyItemCondition(IEnumerable<IItemCondition> items) : base(items) { }
            public static implicit operator OneOrManyItemCondition (OfferItemCondition value) { return new OneOrManyItemCondition (new ItemConditionOfferItemCondition (value)); }
            public static implicit operator OneOrManyItemCondition (OfferItemCondition[] values) { return new OneOrManyItemCondition (values.Select(v => (IItemCondition) new ItemConditionOfferItemCondition (v))); }
            public static implicit operator OneOrManyItemCondition (List<OfferItemCondition> values) { return new OneOrManyItemCondition (values.Select(v => (IItemCondition) new ItemConditionOfferItemCondition (v))); }
        }
        public struct ItemConditionOfferItemCondition : IItemCondition<OfferItemCondition>
        {
            object IValue.Value => this.Value;
            public OfferItemCondition Value { get; }
            public ItemConditionOfferItemCondition (OfferItemCondition value) { Value = value; }
            public static implicit operator ItemConditionOfferItemCondition (OfferItemCondition value) { return new ItemConditionOfferItemCondition (value); }
        }

        public interface ILogo : IValue {}
        public interface ILogo<T> : ILogo { new T Value { get; } }
        public class OneOrManyLogo : OneOrMany<ILogo>
        {
            public OneOrManyLogo(ILogo item) : base(item) { }
            public OneOrManyLogo(IEnumerable<ILogo> items) : base(items) { }
            public static implicit operator OneOrManyLogo (ImageObject value) { return new OneOrManyLogo (new LogoImageObject (value)); }
            public static implicit operator OneOrManyLogo (ImageObject[] values) { return new OneOrManyLogo (values.Select(v => (ILogo) new LogoImageObject (v))); }
            public static implicit operator OneOrManyLogo (List<ImageObject> values) { return new OneOrManyLogo (values.Select(v => (ILogo) new LogoImageObject (v))); }
            public static implicit operator OneOrManyLogo (Uri value) { return new OneOrManyLogo (new LogoUri (value)); }
            public static implicit operator OneOrManyLogo (Uri[] values) { return new OneOrManyLogo (values.Select(v => (ILogo) new LogoUri (v))); }
            public static implicit operator OneOrManyLogo (List<Uri> values) { return new OneOrManyLogo (values.Select(v => (ILogo) new LogoUri (v))); }
        }
        public struct LogoImageObject : ILogo<ImageObject>
        {
            object IValue.Value => this.Value;
            public ImageObject Value { get; }
            public LogoImageObject (ImageObject value) { Value = value; }
            public static implicit operator LogoImageObject (ImageObject value) { return new LogoImageObject (value); }
        }
        public struct LogoUri : ILogo<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public LogoUri (Uri value) { Value = value; }
            public static implicit operator LogoUri (Uri value) { return new LogoUri (value); }
        }

        public interface IManufacturer : IValue {}
        public interface IManufacturer<T> : IManufacturer { new T Value { get; } }
        public class OneOrManyManufacturer : OneOrMany<IManufacturer>
        {
            public OneOrManyManufacturer(IManufacturer item) : base(item) { }
            public OneOrManyManufacturer(IEnumerable<IManufacturer> items) : base(items) { }
            public static implicit operator OneOrManyManufacturer (Organization value) { return new OneOrManyManufacturer (new ManufacturerOrganization (value)); }
            public static implicit operator OneOrManyManufacturer (Organization[] values) { return new OneOrManyManufacturer (values.Select(v => (IManufacturer) new ManufacturerOrganization (v))); }
            public static implicit operator OneOrManyManufacturer (List<Organization> values) { return new OneOrManyManufacturer (values.Select(v => (IManufacturer) new ManufacturerOrganization (v))); }
        }
        public struct ManufacturerOrganization : IManufacturer<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public ManufacturerOrganization (Organization value) { Value = value; }
            public static implicit operator ManufacturerOrganization (Organization value) { return new ManufacturerOrganization (value); }
        }

        public interface IMaterial : IValue {}
        public interface IMaterial<T> : IMaterial { new T Value { get; } }
        public class OneOrManyMaterial : OneOrMany<IMaterial>
        {
            public OneOrManyMaterial(IMaterial item) : base(item) { }
            public OneOrManyMaterial(IEnumerable<IMaterial> items) : base(items) { }
            public static implicit operator OneOrManyMaterial (Product value) { return new OneOrManyMaterial (new MaterialProduct (value)); }
            public static implicit operator OneOrManyMaterial (Product[] values) { return new OneOrManyMaterial (values.Select(v => (IMaterial) new MaterialProduct (v))); }
            public static implicit operator OneOrManyMaterial (List<Product> values) { return new OneOrManyMaterial (values.Select(v => (IMaterial) new MaterialProduct (v))); }
            public static implicit operator OneOrManyMaterial (string value) { return new OneOrManyMaterial (new Materialstring (value)); }
            public static implicit operator OneOrManyMaterial (string[] values) { return new OneOrManyMaterial (values.Select(v => (IMaterial) new Materialstring (v))); }
            public static implicit operator OneOrManyMaterial (List<string> values) { return new OneOrManyMaterial (values.Select(v => (IMaterial) new Materialstring (v))); }
            public static implicit operator OneOrManyMaterial (Uri value) { return new OneOrManyMaterial (new MaterialUri (value)); }
            public static implicit operator OneOrManyMaterial (Uri[] values) { return new OneOrManyMaterial (values.Select(v => (IMaterial) new MaterialUri (v))); }
            public static implicit operator OneOrManyMaterial (List<Uri> values) { return new OneOrManyMaterial (values.Select(v => (IMaterial) new MaterialUri (v))); }
        }
        public struct MaterialProduct : IMaterial<Product>
        {
            object IValue.Value => this.Value;
            public Product Value { get; }
            public MaterialProduct (Product value) { Value = value; }
            public static implicit operator MaterialProduct (Product value) { return new MaterialProduct (value); }
        }
        public struct Materialstring : IMaterial<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Materialstring (string value) { Value = value; }
            public static implicit operator Materialstring (string value) { return new Materialstring (value); }
        }
        public struct MaterialUri : IMaterial<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public MaterialUri (Uri value) { Value = value; }
            public static implicit operator MaterialUri (Uri value) { return new MaterialUri (value); }
        }

        public interface IModel : IValue {}
        public interface IModel<T> : IModel { new T Value { get; } }
        public class OneOrManyModel : OneOrMany<IModel>
        {
            public OneOrManyModel(IModel item) : base(item) { }
            public OneOrManyModel(IEnumerable<IModel> items) : base(items) { }
            public static implicit operator OneOrManyModel (ProductModel value) { return new OneOrManyModel (new ModelProductModel (value)); }
            public static implicit operator OneOrManyModel (ProductModel[] values) { return new OneOrManyModel (values.Select(v => (IModel) new ModelProductModel (v))); }
            public static implicit operator OneOrManyModel (List<ProductModel> values) { return new OneOrManyModel (values.Select(v => (IModel) new ModelProductModel (v))); }
            public static implicit operator OneOrManyModel (string value) { return new OneOrManyModel (new Modelstring (value)); }
            public static implicit operator OneOrManyModel (string[] values) { return new OneOrManyModel (values.Select(v => (IModel) new Modelstring (v))); }
            public static implicit operator OneOrManyModel (List<string> values) { return new OneOrManyModel (values.Select(v => (IModel) new Modelstring (v))); }
        }
        public struct ModelProductModel : IModel<ProductModel>
        {
            object IValue.Value => this.Value;
            public ProductModel Value { get; }
            public ModelProductModel (ProductModel value) { Value = value; }
            public static implicit operator ModelProductModel (ProductModel value) { return new ModelProductModel (value); }
        }
        public struct Modelstring : IModel<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Modelstring (string value) { Value = value; }
            public static implicit operator Modelstring (string value) { return new Modelstring (value); }
        }

        public interface IMpn : IValue {}
        public interface IMpn<T> : IMpn { new T Value { get; } }
        public class OneOrManyMpn : OneOrMany<IMpn>
        {
            public OneOrManyMpn(IMpn item) : base(item) { }
            public OneOrManyMpn(IEnumerable<IMpn> items) : base(items) { }
            public static implicit operator OneOrManyMpn (string value) { return new OneOrManyMpn (new Mpnstring (value)); }
            public static implicit operator OneOrManyMpn (string[] values) { return new OneOrManyMpn (values.Select(v => (IMpn) new Mpnstring (v))); }
            public static implicit operator OneOrManyMpn (List<string> values) { return new OneOrManyMpn (values.Select(v => (IMpn) new Mpnstring (v))); }
        }
        public struct Mpnstring : IMpn<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Mpnstring (string value) { Value = value; }
            public static implicit operator Mpnstring (string value) { return new Mpnstring (value); }
        }

        public interface IOffers : IValue {}
        public interface IOffers<T> : IOffers { new T Value { get; } }
        public class OneOrManyOffers : OneOrMany<IOffers>
        {
            public OneOrManyOffers(IOffers item) : base(item) { }
            public OneOrManyOffers(IEnumerable<IOffers> items) : base(items) { }
            public static implicit operator OneOrManyOffers (Offer value) { return new OneOrManyOffers (new OffersOffer (value)); }
            public static implicit operator OneOrManyOffers (Offer[] values) { return new OneOrManyOffers (values.Select(v => (IOffers) new OffersOffer (v))); }
            public static implicit operator OneOrManyOffers (List<Offer> values) { return new OneOrManyOffers (values.Select(v => (IOffers) new OffersOffer (v))); }
        }
        public struct OffersOffer : IOffers<Offer>
        {
            object IValue.Value => this.Value;
            public Offer Value { get; }
            public OffersOffer (Offer value) { Value = value; }
            public static implicit operator OffersOffer (Offer value) { return new OffersOffer (value); }
        }

        public interface IProductID : IValue {}
        public interface IProductID<T> : IProductID { new T Value { get; } }
        public class OneOrManyProductID : OneOrMany<IProductID>
        {
            public OneOrManyProductID(IProductID item) : base(item) { }
            public OneOrManyProductID(IEnumerable<IProductID> items) : base(items) { }
            public static implicit operator OneOrManyProductID (string value) { return new OneOrManyProductID (new ProductIDstring (value)); }
            public static implicit operator OneOrManyProductID (string[] values) { return new OneOrManyProductID (values.Select(v => (IProductID) new ProductIDstring (v))); }
            public static implicit operator OneOrManyProductID (List<string> values) { return new OneOrManyProductID (values.Select(v => (IProductID) new ProductIDstring (v))); }
        }
        public struct ProductIDstring : IProductID<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ProductIDstring (string value) { Value = value; }
            public static implicit operator ProductIDstring (string value) { return new ProductIDstring (value); }
        }

        public interface IProductionDate : IValue {}
        public interface IProductionDate<T> : IProductionDate { new T Value { get; } }
        public class OneOrManyProductionDate : OneOrMany<IProductionDate>
        {
            public OneOrManyProductionDate(IProductionDate item) : base(item) { }
            public OneOrManyProductionDate(IEnumerable<IProductionDate> items) : base(items) { }
            public static implicit operator OneOrManyProductionDate (DateTimeOffset value) { return new OneOrManyProductionDate (new ProductionDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyProductionDate (DateTimeOffset[] values) { return new OneOrManyProductionDate (values.Select(v => (IProductionDate) new ProductionDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyProductionDate (List<DateTimeOffset> values) { return new OneOrManyProductionDate (values.Select(v => (IProductionDate) new ProductionDateDateTimeOffset (v))); }
        }
        public struct ProductionDateDateTimeOffset : IProductionDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public ProductionDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator ProductionDateDateTimeOffset (DateTimeOffset value) { return new ProductionDateDateTimeOffset (value); }
        }

        public interface IPurchaseDate : IValue {}
        public interface IPurchaseDate<T> : IPurchaseDate { new T Value { get; } }
        public class OneOrManyPurchaseDate : OneOrMany<IPurchaseDate>
        {
            public OneOrManyPurchaseDate(IPurchaseDate item) : base(item) { }
            public OneOrManyPurchaseDate(IEnumerable<IPurchaseDate> items) : base(items) { }
            public static implicit operator OneOrManyPurchaseDate (DateTimeOffset value) { return new OneOrManyPurchaseDate (new PurchaseDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyPurchaseDate (DateTimeOffset[] values) { return new OneOrManyPurchaseDate (values.Select(v => (IPurchaseDate) new PurchaseDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyPurchaseDate (List<DateTimeOffset> values) { return new OneOrManyPurchaseDate (values.Select(v => (IPurchaseDate) new PurchaseDateDateTimeOffset (v))); }
        }
        public struct PurchaseDateDateTimeOffset : IPurchaseDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public PurchaseDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator PurchaseDateDateTimeOffset (DateTimeOffset value) { return new PurchaseDateDateTimeOffset (value); }
        }

        public interface IReleaseDate : IValue {}
        public interface IReleaseDate<T> : IReleaseDate { new T Value { get; } }
        public class OneOrManyReleaseDate : OneOrMany<IReleaseDate>
        {
            public OneOrManyReleaseDate(IReleaseDate item) : base(item) { }
            public OneOrManyReleaseDate(IEnumerable<IReleaseDate> items) : base(items) { }
            public static implicit operator OneOrManyReleaseDate (DateTimeOffset value) { return new OneOrManyReleaseDate (new ReleaseDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyReleaseDate (DateTimeOffset[] values) { return new OneOrManyReleaseDate (values.Select(v => (IReleaseDate) new ReleaseDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyReleaseDate (List<DateTimeOffset> values) { return new OneOrManyReleaseDate (values.Select(v => (IReleaseDate) new ReleaseDateDateTimeOffset (v))); }
        }
        public struct ReleaseDateDateTimeOffset : IReleaseDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public ReleaseDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator ReleaseDateDateTimeOffset (DateTimeOffset value) { return new ReleaseDateDateTimeOffset (value); }
        }

        public interface IReview : IValue {}
        public interface IReview<T> : IReview { new T Value { get; } }
        public class OneOrManyReview : OneOrMany<IReview>
        {
            public OneOrManyReview(IReview item) : base(item) { }
            public OneOrManyReview(IEnumerable<IReview> items) : base(items) { }
            public static implicit operator OneOrManyReview (Review value) { return new OneOrManyReview (new ReviewReview (value)); }
            public static implicit operator OneOrManyReview (Review[] values) { return new OneOrManyReview (values.Select(v => (IReview) new ReviewReview (v))); }
            public static implicit operator OneOrManyReview (List<Review> values) { return new OneOrManyReview (values.Select(v => (IReview) new ReviewReview (v))); }
        }
        public struct ReviewReview : IReview<Review>
        {
            object IValue.Value => this.Value;
            public Review Value { get; }
            public ReviewReview (Review value) { Value = value; }
            public static implicit operator ReviewReview (Review value) { return new ReviewReview (value); }
        }

        public interface ISku : IValue {}
        public interface ISku<T> : ISku { new T Value { get; } }
        public class OneOrManySku : OneOrMany<ISku>
        {
            public OneOrManySku(ISku item) : base(item) { }
            public OneOrManySku(IEnumerable<ISku> items) : base(items) { }
            public static implicit operator OneOrManySku (string value) { return new OneOrManySku (new Skustring (value)); }
            public static implicit operator OneOrManySku (string[] values) { return new OneOrManySku (values.Select(v => (ISku) new Skustring (v))); }
            public static implicit operator OneOrManySku (List<string> values) { return new OneOrManySku (values.Select(v => (ISku) new Skustring (v))); }
        }
        public struct Skustring : ISku<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Skustring (string value) { Value = value; }
            public static implicit operator Skustring (string value) { return new Skustring (value); }
        }

        public interface IWeight : IValue {}
        public interface IWeight<T> : IWeight { new T Value { get; } }
        public class OneOrManyWeight : OneOrMany<IWeight>
        {
            public OneOrManyWeight(IWeight item) : base(item) { }
            public OneOrManyWeight(IEnumerable<IWeight> items) : base(items) { }
            public static implicit operator OneOrManyWeight (QuantitativeValue value) { return new OneOrManyWeight (new WeightQuantitativeValue (value)); }
            public static implicit operator OneOrManyWeight (QuantitativeValue[] values) { return new OneOrManyWeight (values.Select(v => (IWeight) new WeightQuantitativeValue (v))); }
            public static implicit operator OneOrManyWeight (List<QuantitativeValue> values) { return new OneOrManyWeight (values.Select(v => (IWeight) new WeightQuantitativeValue (v))); }
        }
        public struct WeightQuantitativeValue : IWeight<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public WeightQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator WeightQuantitativeValue (QuantitativeValue value) { return new WeightQuantitativeValue (value); }
        }

        public interface IWidth : IValue {}
        public interface IWidth<T> : IWidth { new T Value { get; } }
        public class OneOrManyWidth : OneOrMany<IWidth>
        {
            public OneOrManyWidth(IWidth item) : base(item) { }
            public OneOrManyWidth(IEnumerable<IWidth> items) : base(items) { }
            public static implicit operator OneOrManyWidth (string value) { return new OneOrManyWidth (new Widthstring (value)); }
            public static implicit operator OneOrManyWidth (string[] values) { return new OneOrManyWidth (values.Select(v => (IWidth) new Widthstring (v))); }
            public static implicit operator OneOrManyWidth (List<string> values) { return new OneOrManyWidth (values.Select(v => (IWidth) new Widthstring (v))); }
            public static implicit operator OneOrManyWidth (QuantitativeValue value) { return new OneOrManyWidth (new WidthQuantitativeValue (value)); }
            public static implicit operator OneOrManyWidth (QuantitativeValue[] values) { return new OneOrManyWidth (values.Select(v => (IWidth) new WidthQuantitativeValue (v))); }
            public static implicit operator OneOrManyWidth (List<QuantitativeValue> values) { return new OneOrManyWidth (values.Select(v => (IWidth) new WidthQuantitativeValue (v))); }
        }
        public struct Widthstring : IWidth<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Widthstring (string value) { Value = value; }
            public static implicit operator Widthstring (string value) { return new Widthstring (value); }
        }
        public struct WidthQuantitativeValue : IWidth<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public WidthQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator WidthQuantitativeValue (QuantitativeValue value) { return new WidthQuantitativeValue (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Product";

        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;br/&gt;&lt;br/&gt;
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        [DataMember(Name = "additionalProperty", Order = 106)]
        public OneOrManyAdditionalProperty AdditionalProperty { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 107)]
        public OneOrManyAggregateRating AggregateRating { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience", Order = 108)]
        public OneOrManyAudience Audience { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 109)]
        public OneOrManyAward Award { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 110)]
        public OneOrManyBrand Brand { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [DataMember(Name = "category", Order = 111)]
        public OneOrManyCategory Category { get; set; }

        /// <summary>
        /// The color of the product.
        /// </summary>
        [DataMember(Name = "color", Order = 112)]
        public OneOrManyColor Color { get; set; }

        /// <summary>
        /// The depth of the item.
        /// </summary>
        [DataMember(Name = "depth", Order = 113)]
        public OneOrManyDepth Depth { get; set; }

        /// <summary>
        /// The GTIN-12 code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin12", Order = 114)]
        public OneOrManyGtin12 Gtin12 { get; set; }

        /// <summary>
        /// The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin13", Order = 115)]
        public OneOrManyGtin13 Gtin13 { get; set; }

        /// <summary>
        /// The GTIN-14 code of the product, or the product to which the offer refers. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin14", Order = 116)]
        public OneOrManyGtin14 Gtin14 { get; set; }

        /// <summary>
        /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-8.aspx"&gt;GTIN-8&lt;/a&gt; code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "gtin8", Order = 117)]
        public OneOrManyGtin8 Gtin8 { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [DataMember(Name = "height", Order = 118)]
        public OneOrManyHeight Height { get; set; }

        /// <summary>
        /// A pointer to another product (or multiple products) for which this product is an accessory or spare part.
        /// </summary>
        [DataMember(Name = "isAccessoryOrSparePartFor", Order = 119)]
        public OneOrManyIsAccessoryOrSparePartFor IsAccessoryOrSparePartFor { get; set; }

        /// <summary>
        /// A pointer to another product (or multiple products) for which this product is a consumable.
        /// </summary>
        [DataMember(Name = "isConsumableFor", Order = 120)]
        public OneOrManyIsConsumableFor IsConsumableFor { get; set; }

        /// <summary>
        /// A pointer to another, somehow related product (or multiple products).
        /// </summary>
        [DataMember(Name = "isRelatedTo", Order = 121)]
        public OneOrManyIsRelatedTo IsRelatedTo { get; set; }

        /// <summary>
        /// A pointer to another, functionally similar product (or multiple products).
        /// </summary>
        [DataMember(Name = "isSimilarTo", Order = 122)]
        public OneOrManyIsSimilarTo IsSimilarTo { get; set; }

        /// <summary>
        /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        /// </summary>
        [DataMember(Name = "itemCondition", Order = 123)]
        public OneOrManyItemCondition ItemCondition { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 124)]
        public OneOrManyLogo Logo { get; set; }

        /// <summary>
        /// The manufacturer of the product.
        /// </summary>
        [DataMember(Name = "manufacturer", Order = 125)]
        public OneOrManyManufacturer Manufacturer { get; set; }

        /// <summary>
        /// A material that something is made from, e.g. leather, wool, cotton, paper.
        /// </summary>
        [DataMember(Name = "material", Order = 126)]
        public OneOrManyMaterial Material { get; set; }

        /// <summary>
        /// The model of the product. Use with the URL of a ProductModel or a textual representation of the model identifier. The URL of the ProductModel can be from an external source. It is recommended to additionally provide strong product identifiers via the gtin8/gtin13/gtin14 and mpn properties.
        /// </summary>
        [DataMember(Name = "model", Order = 127)]
        public OneOrManyModel Model { get; set; }

        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        [DataMember(Name = "mpn", Order = 128)]
        public OneOrManyMpn Mpn { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers", Order = 129)]
        public OneOrManyOffers Offers { get; set; }

        /// <summary>
        /// The product identifier, such as ISBN. For example: &lt;code&gt;meta itemprop="productID" content="isbn:123-456-789"&lt;/code&gt;.
        /// </summary>
        [DataMember(Name = "productID", Order = 130)]
        public OneOrManyProductID ProductID { get; set; }

        /// <summary>
        /// The date of production of the item, e.g. vehicle.
        /// </summary>
        [DataMember(Name = "productionDate", Order = 131)]
        public virtual OneOrManyProductionDate ProductionDate { get; set; }

        /// <summary>
        /// The date the item e.g. vehicle was purchased by the current owner.
        /// </summary>
        [DataMember(Name = "purchaseDate", Order = 132)]
        public virtual OneOrManyPurchaseDate PurchaseDate { get; set; }

        /// <summary>
        /// The release date of a product or product model. This can be used to distinguish the exact variant of a product.
        /// </summary>
        [DataMember(Name = "releaseDate", Order = 133)]
        public OneOrManyReleaseDate ReleaseDate { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 134)]
        public OneOrManyReview Review { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        /// </summary>
        [DataMember(Name = "sku", Order = 135)]
        public OneOrManySku Sku { get; set; }

        /// <summary>
        /// The weight of the product or person.
        /// </summary>
        [DataMember(Name = "weight", Order = 136)]
        public OneOrManyWeight Weight { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        [DataMember(Name = "width", Order = 137)]
        public OneOrManyWidth Width { get; set; }
    }
}
