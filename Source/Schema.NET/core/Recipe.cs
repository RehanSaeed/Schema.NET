namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via &lt;a class="localLink" href="http://schema.org/suitableForDiet"&gt;suitableForDiet&lt;/a&gt;. The &lt;a class="localLink" href="http://schema.org/keywords"&gt;keywords&lt;/a&gt; property can also be used to add more detail.
    /// </summary>
    [DataContract]
    public partial class Recipe : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Recipe";

        /// <summary>
        /// The method of cooking, such as Frying, Steaming, ...
        /// </summary>
        [DataMember(Name = "cookingMethod", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? CookingMethod { get; set; }

        /// <summary>
        /// The time it takes to actually cook the dish, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "cookTime", Order = 207)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan?>? CookTime { get; set; }

        /// <summary>
        /// Nutrition information about the recipe or menu item.
        /// </summary>
        [DataMember(Name = "nutrition", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<NutritionInformation>? Nutrition { get; set; }

        /// <summary>
        /// The length of time it takes to prepare the recipe, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "prepTime", Order = 209)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan?>? PrepTime { get; set; }

        /// <summary>
        /// The category of the recipe—for example, appetizer, entree, etc.
        /// </summary>
        [DataMember(Name = "recipeCategory", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? RecipeCategory { get; set; }

        /// <summary>
        /// The cuisine of the recipe (for example, French or Ethiopian).
        /// </summary>
        [DataMember(Name = "recipeCuisine", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? RecipeCuisine { get; set; }

        /// <summary>
        /// A single ingredient used in the recipe, e.g. sugar, flour or garlic.
        /// </summary>
        [DataMember(Name = "recipeIngredient", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? RecipeIngredient { get; set; }

        /// <summary>
        /// A step or instruction involved in making the recipe.
        /// </summary>
        [DataMember(Name = "recipeInstructions", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ItemList, string>? RecipeInstructions { get; set; }

        /// <summary>
        /// The quantity produced by the recipe (for example, number of people served, number of servings, etc).
        /// </summary>
        [DataMember(Name = "recipeYield", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? RecipeYield { get; set; }

        /// <summary>
        /// Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.
        /// </summary>
        [DataMember(Name = "suitableForDiet", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<RestrictedDiet?>? SuitableForDiet { get; set; }

        /// <summary>
        /// The total time it takes to prepare and cook the recipe, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "totalTime", Order = 216)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan?>? TotalTime { get; set; }
    }
}
