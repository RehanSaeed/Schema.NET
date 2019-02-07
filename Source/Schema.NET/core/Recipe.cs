namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via &lt;a class="localLink" href="http://schema.org/suitableForDiet"&gt;suitableForDiet&lt;/a&gt;. The &lt;a class="localLink" href="http://schema.org/keywords"&gt;keywords&lt;/a&gt; property can also be used to add more detail.
    /// </summary>
    [DataContract]
    public partial class Recipe : HowTo
    {
        public interface ICookingMethod : IValue {}
        public interface ICookingMethod<T> : ICookingMethod { new T Value { get; } }
        public class OneOrManyCookingMethod : OneOrMany<ICookingMethod>
        {
            public OneOrManyCookingMethod(ICookingMethod item) : base(item) { }
            public OneOrManyCookingMethod(IEnumerable<ICookingMethod> items) : base(items) { }
            public static implicit operator OneOrManyCookingMethod (string value) { return new OneOrManyCookingMethod (new CookingMethodstring (value)); }
            public static implicit operator OneOrManyCookingMethod (string[] values) { return new OneOrManyCookingMethod (values.Select(v => (ICookingMethod) new CookingMethodstring (v))); }
            public static implicit operator OneOrManyCookingMethod (List<string> values) { return new OneOrManyCookingMethod (values.Select(v => (ICookingMethod) new CookingMethodstring (v))); }
        }
        public struct CookingMethodstring : ICookingMethod<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public CookingMethodstring (string value) { Value = value; }
            public static implicit operator CookingMethodstring (string value) { return new CookingMethodstring (value); }
        }

        public interface ICookTime : IValue {}
        public interface ICookTime<T> : ICookTime { new T Value { get; } }
        public class OneOrManyCookTime : OneOrMany<ICookTime>
        {
            public OneOrManyCookTime(ICookTime item) : base(item) { }
            public OneOrManyCookTime(IEnumerable<ICookTime> items) : base(items) { }
            public static implicit operator OneOrManyCookTime (TimeSpan value) { return new OneOrManyCookTime (new CookTimeTimeSpan (value)); }
            public static implicit operator OneOrManyCookTime (TimeSpan[] values) { return new OneOrManyCookTime (values.Select(v => (ICookTime) new CookTimeTimeSpan (v))); }
            public static implicit operator OneOrManyCookTime (List<TimeSpan> values) { return new OneOrManyCookTime (values.Select(v => (ICookTime) new CookTimeTimeSpan (v))); }
        }
        public struct CookTimeTimeSpan : ICookTime<TimeSpan>
        {
            object IValue.Value => this.Value;
            public TimeSpan Value { get; }
            public CookTimeTimeSpan (TimeSpan value) { Value = value; }
            public static implicit operator CookTimeTimeSpan (TimeSpan value) { return new CookTimeTimeSpan (value); }
        }

        public interface INutrition : IValue {}
        public interface INutrition<T> : INutrition { new T Value { get; } }
        public class OneOrManyNutrition : OneOrMany<INutrition>
        {
            public OneOrManyNutrition(INutrition item) : base(item) { }
            public OneOrManyNutrition(IEnumerable<INutrition> items) : base(items) { }
            public static implicit operator OneOrManyNutrition (NutritionInformation value) { return new OneOrManyNutrition (new NutritionNutritionInformation (value)); }
            public static implicit operator OneOrManyNutrition (NutritionInformation[] values) { return new OneOrManyNutrition (values.Select(v => (INutrition) new NutritionNutritionInformation (v))); }
            public static implicit operator OneOrManyNutrition (List<NutritionInformation> values) { return new OneOrManyNutrition (values.Select(v => (INutrition) new NutritionNutritionInformation (v))); }
        }
        public struct NutritionNutritionInformation : INutrition<NutritionInformation>
        {
            object IValue.Value => this.Value;
            public NutritionInformation Value { get; }
            public NutritionNutritionInformation (NutritionInformation value) { Value = value; }
            public static implicit operator NutritionNutritionInformation (NutritionInformation value) { return new NutritionNutritionInformation (value); }
        }

        public interface IRecipeCategory : IValue {}
        public interface IRecipeCategory<T> : IRecipeCategory { new T Value { get; } }
        public class OneOrManyRecipeCategory : OneOrMany<IRecipeCategory>
        {
            public OneOrManyRecipeCategory(IRecipeCategory item) : base(item) { }
            public OneOrManyRecipeCategory(IEnumerable<IRecipeCategory> items) : base(items) { }
            public static implicit operator OneOrManyRecipeCategory (string value) { return new OneOrManyRecipeCategory (new RecipeCategorystring (value)); }
            public static implicit operator OneOrManyRecipeCategory (string[] values) { return new OneOrManyRecipeCategory (values.Select(v => (IRecipeCategory) new RecipeCategorystring (v))); }
            public static implicit operator OneOrManyRecipeCategory (List<string> values) { return new OneOrManyRecipeCategory (values.Select(v => (IRecipeCategory) new RecipeCategorystring (v))); }
        }
        public struct RecipeCategorystring : IRecipeCategory<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public RecipeCategorystring (string value) { Value = value; }
            public static implicit operator RecipeCategorystring (string value) { return new RecipeCategorystring (value); }
        }

        public interface IRecipeCuisine : IValue {}
        public interface IRecipeCuisine<T> : IRecipeCuisine { new T Value { get; } }
        public class OneOrManyRecipeCuisine : OneOrMany<IRecipeCuisine>
        {
            public OneOrManyRecipeCuisine(IRecipeCuisine item) : base(item) { }
            public OneOrManyRecipeCuisine(IEnumerable<IRecipeCuisine> items) : base(items) { }
            public static implicit operator OneOrManyRecipeCuisine (string value) { return new OneOrManyRecipeCuisine (new RecipeCuisinestring (value)); }
            public static implicit operator OneOrManyRecipeCuisine (string[] values) { return new OneOrManyRecipeCuisine (values.Select(v => (IRecipeCuisine) new RecipeCuisinestring (v))); }
            public static implicit operator OneOrManyRecipeCuisine (List<string> values) { return new OneOrManyRecipeCuisine (values.Select(v => (IRecipeCuisine) new RecipeCuisinestring (v))); }
        }
        public struct RecipeCuisinestring : IRecipeCuisine<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public RecipeCuisinestring (string value) { Value = value; }
            public static implicit operator RecipeCuisinestring (string value) { return new RecipeCuisinestring (value); }
        }

        public interface IRecipeIngredient : IValue {}
        public interface IRecipeIngredient<T> : IRecipeIngredient { new T Value { get; } }
        public class OneOrManyRecipeIngredient : OneOrMany<IRecipeIngredient>
        {
            public OneOrManyRecipeIngredient(IRecipeIngredient item) : base(item) { }
            public OneOrManyRecipeIngredient(IEnumerable<IRecipeIngredient> items) : base(items) { }
            public static implicit operator OneOrManyRecipeIngredient (string value) { return new OneOrManyRecipeIngredient (new RecipeIngredientstring (value)); }
            public static implicit operator OneOrManyRecipeIngredient (string[] values) { return new OneOrManyRecipeIngredient (values.Select(v => (IRecipeIngredient) new RecipeIngredientstring (v))); }
            public static implicit operator OneOrManyRecipeIngredient (List<string> values) { return new OneOrManyRecipeIngredient (values.Select(v => (IRecipeIngredient) new RecipeIngredientstring (v))); }
        }
        public struct RecipeIngredientstring : IRecipeIngredient<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public RecipeIngredientstring (string value) { Value = value; }
            public static implicit operator RecipeIngredientstring (string value) { return new RecipeIngredientstring (value); }
        }

        public interface IRecipeInstructions : IValue {}
        public interface IRecipeInstructions<T> : IRecipeInstructions { new T Value { get; } }
        public class OneOrManyRecipeInstructions : OneOrMany<IRecipeInstructions>
        {
            public OneOrManyRecipeInstructions(IRecipeInstructions item) : base(item) { }
            public OneOrManyRecipeInstructions(IEnumerable<IRecipeInstructions> items) : base(items) { }
            public static implicit operator OneOrManyRecipeInstructions (CreativeWork value) { return new OneOrManyRecipeInstructions (new RecipeInstructionsCreativeWork (value)); }
            public static implicit operator OneOrManyRecipeInstructions (CreativeWork[] values) { return new OneOrManyRecipeInstructions (values.Select(v => (IRecipeInstructions) new RecipeInstructionsCreativeWork (v))); }
            public static implicit operator OneOrManyRecipeInstructions (List<CreativeWork> values) { return new OneOrManyRecipeInstructions (values.Select(v => (IRecipeInstructions) new RecipeInstructionsCreativeWork (v))); }
            public static implicit operator OneOrManyRecipeInstructions (ItemList value) { return new OneOrManyRecipeInstructions (new RecipeInstructionsItemList (value)); }
            public static implicit operator OneOrManyRecipeInstructions (ItemList[] values) { return new OneOrManyRecipeInstructions (values.Select(v => (IRecipeInstructions) new RecipeInstructionsItemList (v))); }
            public static implicit operator OneOrManyRecipeInstructions (List<ItemList> values) { return new OneOrManyRecipeInstructions (values.Select(v => (IRecipeInstructions) new RecipeInstructionsItemList (v))); }
            public static implicit operator OneOrManyRecipeInstructions (string value) { return new OneOrManyRecipeInstructions (new RecipeInstructionsstring (value)); }
            public static implicit operator OneOrManyRecipeInstructions (string[] values) { return new OneOrManyRecipeInstructions (values.Select(v => (IRecipeInstructions) new RecipeInstructionsstring (v))); }
            public static implicit operator OneOrManyRecipeInstructions (List<string> values) { return new OneOrManyRecipeInstructions (values.Select(v => (IRecipeInstructions) new RecipeInstructionsstring (v))); }
        }
        public struct RecipeInstructionsCreativeWork : IRecipeInstructions<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public RecipeInstructionsCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator RecipeInstructionsCreativeWork (CreativeWork value) { return new RecipeInstructionsCreativeWork (value); }
        }
        public struct RecipeInstructionsItemList : IRecipeInstructions<ItemList>
        {
            object IValue.Value => this.Value;
            public ItemList Value { get; }
            public RecipeInstructionsItemList (ItemList value) { Value = value; }
            public static implicit operator RecipeInstructionsItemList (ItemList value) { return new RecipeInstructionsItemList (value); }
        }
        public struct RecipeInstructionsstring : IRecipeInstructions<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public RecipeInstructionsstring (string value) { Value = value; }
            public static implicit operator RecipeInstructionsstring (string value) { return new RecipeInstructionsstring (value); }
        }

        public interface IRecipeYield : IValue {}
        public interface IRecipeYield<T> : IRecipeYield { new T Value { get; } }
        public class OneOrManyRecipeYield : OneOrMany<IRecipeYield>
        {
            public OneOrManyRecipeYield(IRecipeYield item) : base(item) { }
            public OneOrManyRecipeYield(IEnumerable<IRecipeYield> items) : base(items) { }
            public static implicit operator OneOrManyRecipeYield (QuantitativeValue value) { return new OneOrManyRecipeYield (new RecipeYieldQuantitativeValue (value)); }
            public static implicit operator OneOrManyRecipeYield (QuantitativeValue[] values) { return new OneOrManyRecipeYield (values.Select(v => (IRecipeYield) new RecipeYieldQuantitativeValue (v))); }
            public static implicit operator OneOrManyRecipeYield (List<QuantitativeValue> values) { return new OneOrManyRecipeYield (values.Select(v => (IRecipeYield) new RecipeYieldQuantitativeValue (v))); }
            public static implicit operator OneOrManyRecipeYield (string value) { return new OneOrManyRecipeYield (new RecipeYieldstring (value)); }
            public static implicit operator OneOrManyRecipeYield (string[] values) { return new OneOrManyRecipeYield (values.Select(v => (IRecipeYield) new RecipeYieldstring (v))); }
            public static implicit operator OneOrManyRecipeYield (List<string> values) { return new OneOrManyRecipeYield (values.Select(v => (IRecipeYield) new RecipeYieldstring (v))); }
        }
        public struct RecipeYieldQuantitativeValue : IRecipeYield<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public RecipeYieldQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator RecipeYieldQuantitativeValue (QuantitativeValue value) { return new RecipeYieldQuantitativeValue (value); }
        }
        public struct RecipeYieldstring : IRecipeYield<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public RecipeYieldstring (string value) { Value = value; }
            public static implicit operator RecipeYieldstring (string value) { return new RecipeYieldstring (value); }
        }

        public interface ISuitableForDiet : IValue {}
        public interface ISuitableForDiet<T> : ISuitableForDiet { new T Value { get; } }
        public class OneOrManySuitableForDiet : OneOrMany<ISuitableForDiet>
        {
            public OneOrManySuitableForDiet(ISuitableForDiet item) : base(item) { }
            public OneOrManySuitableForDiet(IEnumerable<ISuitableForDiet> items) : base(items) { }
            public static implicit operator OneOrManySuitableForDiet (RestrictedDiet value) { return new OneOrManySuitableForDiet (new SuitableForDietRestrictedDiet (value)); }
            public static implicit operator OneOrManySuitableForDiet (RestrictedDiet[] values) { return new OneOrManySuitableForDiet (values.Select(v => (ISuitableForDiet) new SuitableForDietRestrictedDiet (v))); }
            public static implicit operator OneOrManySuitableForDiet (List<RestrictedDiet> values) { return new OneOrManySuitableForDiet (values.Select(v => (ISuitableForDiet) new SuitableForDietRestrictedDiet (v))); }
        }
        public struct SuitableForDietRestrictedDiet : ISuitableForDiet<RestrictedDiet>
        {
            object IValue.Value => this.Value;
            public RestrictedDiet Value { get; }
            public SuitableForDietRestrictedDiet (RestrictedDiet value) { Value = value; }
            public static implicit operator SuitableForDietRestrictedDiet (RestrictedDiet value) { return new SuitableForDietRestrictedDiet (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Recipe";

        /// <summary>
        /// The method of cooking, such as Frying, Steaming, ...
        /// </summary>
        [DataMember(Name = "cookingMethod", Order = 306)]
        public OneOrManyCookingMethod CookingMethod { get; set; }

        /// <summary>
        /// The time it takes to actually cook the dish, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "cookTime", Order = 307)]
        public OneOrManyCookTime CookTime { get; set; }

        /// <summary>
        /// Nutrition information about the recipe or menu item.
        /// </summary>
        [DataMember(Name = "nutrition", Order = 308)]
        public OneOrManyNutrition Nutrition { get; set; }

        /// <summary>
        /// The category of the recipe—for example, appetizer, entree, etc.
        /// </summary>
        [DataMember(Name = "recipeCategory", Order = 309)]
        public OneOrManyRecipeCategory RecipeCategory { get; set; }

        /// <summary>
        /// The cuisine of the recipe (for example, French or Ethiopian).
        /// </summary>
        [DataMember(Name = "recipeCuisine", Order = 310)]
        public OneOrManyRecipeCuisine RecipeCuisine { get; set; }

        /// <summary>
        /// A single ingredient used in the recipe, e.g. sugar, flour or garlic.
        /// </summary>
        [DataMember(Name = "recipeIngredient", Order = 311)]
        public OneOrManyRecipeIngredient RecipeIngredient { get; set; }

        /// <summary>
        /// A step in making the recipe, in the form of a single item (document, video, etc.) or an ordered list with HowToStep and/or HowToSection items.
        /// </summary>
        [DataMember(Name = "recipeInstructions", Order = 312)]
        public OneOrManyRecipeInstructions RecipeInstructions { get; set; }

        /// <summary>
        /// The quantity produced by the recipe (for example, number of people served, number of servings, etc).
        /// </summary>
        [DataMember(Name = "recipeYield", Order = 313)]
        public OneOrManyRecipeYield RecipeYield { get; set; }

        /// <summary>
        /// Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.
        /// </summary>
        [DataMember(Name = "suitableForDiet", Order = 314)]
        public OneOrManySuitableForDiet SuitableForDiet { get; set; }
    }
}
