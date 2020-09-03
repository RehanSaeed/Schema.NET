namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via &lt;a class="localLink" href="https://schema.org/suitableForDiet"&gt;suitableForDiet&lt;/a&gt;. The &lt;a class="localLink" href="https://schema.org/keywords"&gt;keywords&lt;/a&gt; property can also be used to add more detail.
    /// </summary>
    public partial interface IRecipe : IHowTo
    {
        /// <summary>
        /// The method of cooking, such as Frying, Steaming, ...
        /// </summary>
        OneOrMany<string> CookingMethod { get; set; }

        /// <summary>
        /// The time it takes to actually cook the dish, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        OneOrMany<TimeSpan?> CookTime { get; set; }

        /// <summary>
        /// Nutrition information about the recipe or menu item.
        /// </summary>
        OneOrMany<INutritionInformation> Nutrition { get; set; }

        /// <summary>
        /// The category of the recipe—for example, appetizer, entree, etc.
        /// </summary>
        OneOrMany<string> RecipeCategory { get; set; }

        /// <summary>
        /// The cuisine of the recipe (for example, French or Ethiopian).
        /// </summary>
        OneOrMany<string> RecipeCuisine { get; set; }

        /// <summary>
        /// A single ingredient used in the recipe, e.g. sugar, flour or garlic.
        /// </summary>
        OneOrMany<string> RecipeIngredient { get; set; }

        /// <summary>
        /// A step in making the recipe, in the form of a single item (document, video, etc.) or an ordered list with HowToStep and/or HowToSection items.
        /// </summary>
        Values<ICreativeWork, IItemList, string> RecipeInstructions { get; set; }

        /// <summary>
        /// The quantity produced by the recipe (for example, number of people served, number of servings, etc).
        /// </summary>
        Values<IQuantitativeValue, string> RecipeYield { get; set; }

        /// <summary>
        /// Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.
        /// </summary>
        OneOrMany<RestrictedDiet?> SuitableForDiet { get; set; }
    }

    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via &lt;a class="localLink" href="https://schema.org/suitableForDiet"&gt;suitableForDiet&lt;/a&gt;. The &lt;a class="localLink" href="https://schema.org/keywords"&gt;keywords&lt;/a&gt; property can also be used to add more detail.
    /// </summary>
    [DataContract]
    public partial class Recipe : HowTo, IRecipe, IEquatable<Recipe>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Recipe";

        /// <summary>
        /// The method of cooking, such as Frying, Steaming, ...
        /// </summary>
        [DataMember(Name = "cookingMethod", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CookingMethod { get; set; }

        /// <summary>
        /// The time it takes to actually cook the dish, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "cookTime", Order = 307)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public OneOrMany<TimeSpan?> CookTime { get; set; }

        /// <summary>
        /// Nutrition information about the recipe or menu item.
        /// </summary>
        [DataMember(Name = "nutrition", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<INutritionInformation> Nutrition { get; set; }

        /// <summary>
        /// The category of the recipe—for example, appetizer, entree, etc.
        /// </summary>
        [DataMember(Name = "recipeCategory", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> RecipeCategory { get; set; }

        /// <summary>
        /// The cuisine of the recipe (for example, French or Ethiopian).
        /// </summary>
        [DataMember(Name = "recipeCuisine", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> RecipeCuisine { get; set; }

        /// <summary>
        /// A single ingredient used in the recipe, e.g. sugar, flour or garlic.
        /// </summary>
        [DataMember(Name = "recipeIngredient", Order = 311)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> RecipeIngredient { get; set; }

        /// <summary>
        /// A step in making the recipe, in the form of a single item (document, video, etc.) or an ordered list with HowToStep and/or HowToSection items.
        /// </summary>
        [DataMember(Name = "recipeInstructions", Order = 312)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, IItemList, string> RecipeInstructions { get; set; }

        /// <summary>
        /// The quantity produced by the recipe (for example, number of people served, number of servings, etc).
        /// </summary>
        [DataMember(Name = "recipeYield", Order = 313)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IQuantitativeValue, string> RecipeYield { get; set; }

        /// <summary>
        /// Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.
        /// </summary>
        [DataMember(Name = "suitableForDiet", Order = 314)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<RestrictedDiet?> SuitableForDiet { get; set; }

        /// <inheritdoc/>
        public bool Equals(Recipe other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.CookingMethod == other.CookingMethod &&
                this.CookTime == other.CookTime &&
                this.Nutrition == other.Nutrition &&
                this.RecipeCategory == other.RecipeCategory &&
                this.RecipeCuisine == other.RecipeCuisine &&
                this.RecipeIngredient == other.RecipeIngredient &&
                this.RecipeInstructions == other.RecipeInstructions &&
                this.RecipeYield == other.RecipeYield &&
                this.SuitableForDiet == other.SuitableForDiet &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Recipe);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.CookingMethod)
            .And(this.CookTime)
            .And(this.Nutrition)
            .And(this.RecipeCategory)
            .And(this.RecipeCuisine)
            .And(this.RecipeIngredient)
            .And(this.RecipeInstructions)
            .And(this.RecipeYield)
            .And(this.SuitableForDiet)
            .And(base.GetHashCode());
    }
}
