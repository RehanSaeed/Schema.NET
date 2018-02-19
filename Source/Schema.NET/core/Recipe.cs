using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via &lt;a class="localLink" href="http://schema.org/suitableForDiet"&gt;suitableForDiet&lt;/a&gt;. The &lt;a class="localLink" href="http://schema.org/keywords"&gt;keywords&lt;/a&gt; property can also be used to add more detail.
    /// </summary>
    [DataContract]
    public partial class Recipe : HowTo
    {
        public interface IRecipeInstructions : IWrapper { }
        public interface IRecipeInstructions<T> : IRecipeInstructions { new T Data { get; set; } }
        public class RecipeInstructionsCreativeWork : IRecipeInstructions<CreativeWork>
        {
            object IWrapper.Data { get { return Data; } set { Data = (CreativeWork) value; } }
            public virtual CreativeWork Data { get; set; }
            public RecipeInstructionsCreativeWork () { }
            public RecipeInstructionsCreativeWork (CreativeWork data) { Data = data; }
            public static implicit operator RecipeInstructionsCreativeWork (CreativeWork data) { return new RecipeInstructionsCreativeWork (data); }
        }

        public class RecipeInstructionsItemList : IRecipeInstructions<ItemList>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ItemList) value; } }
            public virtual ItemList Data { get; set; }
            public RecipeInstructionsItemList () { }
            public RecipeInstructionsItemList (ItemList data) { Data = data; }
            public static implicit operator RecipeInstructionsItemList (ItemList data) { return new RecipeInstructionsItemList (data); }
        }

        public class RecipeInstructionsstring : IRecipeInstructions<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public RecipeInstructionsstring () { }
            public RecipeInstructionsstring (string data) { Data = data; }
            public static implicit operator RecipeInstructionsstring (string data) { return new RecipeInstructionsstring (data); }
        }


        public interface IRecipeYield : IWrapper { }
        public interface IRecipeYield<T> : IRecipeYield { new T Data { get; set; } }
        public class RecipeYieldQuantitativeValue : IRecipeYield<QuantitativeValue>
        {
            object IWrapper.Data { get { return Data; } set { Data = (QuantitativeValue) value; } }
            public virtual QuantitativeValue Data { get; set; }
            public RecipeYieldQuantitativeValue () { }
            public RecipeYieldQuantitativeValue (QuantitativeValue data) { Data = data; }
            public static implicit operator RecipeYieldQuantitativeValue (QuantitativeValue data) { return new RecipeYieldQuantitativeValue (data); }
        }

        public class RecipeYieldstring : IRecipeYield<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public RecipeYieldstring () { }
            public RecipeYieldstring (string data) { Data = data; }
            public static implicit operator RecipeYieldstring (string data) { return new RecipeYieldstring (data); }
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? CookingMethod { get; set; } 

        /// <summary>
        /// The time it takes to actually cook the dish, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "cookTime", Order = 307)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan>? CookTime { get; set; } 

        /// <summary>
        /// Nutrition information about the recipe or menu item.
        /// </summary>
        [DataMember(Name = "nutrition", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<NutritionInformation>? Nutrition { get; set; } 

        /// <summary>
        /// The category of the recipe—for example, appetizer, entree, etc.
        /// </summary>
        [DataMember(Name = "recipeCategory", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? RecipeCategory { get; set; } 

        /// <summary>
        /// The cuisine of the recipe (for example, French or Ethiopian).
        /// </summary>
        [DataMember(Name = "recipeCuisine", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? RecipeCuisine { get; set; } 

        /// <summary>
        /// A single ingredient used in the recipe, e.g. sugar, flour or garlic.
        /// </summary>
        [DataMember(Name = "recipeIngredient", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? RecipeIngredient { get; set; } 

        /// <summary>
        /// A step in making the recipe, in the form of a single item (document, video, etc.) or an ordered list with HowToStep and/or HowToSection items.
        /// </summary>
        [DataMember(Name = "recipeInstructions", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IRecipeInstructions>? RecipeInstructions { get; set; } //CreativeWork, ItemList, string

        /// <summary>
        /// The quantity produced by the recipe (for example, number of people served, number of servings, etc).
        /// </summary>
        [DataMember(Name = "recipeYield", Order = 313)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IRecipeYield>? RecipeYield { get; set; } //QuantitativeValue, string

        /// <summary>
        /// Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.
        /// </summary>
        [DataMember(Name = "suitableForDiet", Order = 314)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<RestrictedDiet>? SuitableForDiet { get; set; } 
    }
}
