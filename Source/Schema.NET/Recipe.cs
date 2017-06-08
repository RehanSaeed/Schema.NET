namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via suitableForDiet...
    /// </summary>
    [DataContract]
    public class Recipe : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Recipe";

        /// <summary>
        /// The quantity produced by the recipe (for example, number of people served, number of servings, etc).
        /// </summary>
        [DataMember(Name = "recipeYield")]
        public string RecipeYield { get; set; }

        /// <summary>
        /// The category of the recipe—for example, appetizer, entree, etc.
        /// </summary>
        [DataMember(Name = "recipeCategory")]
        public string RecipeCategory { get; set; }

        /// <summary>
        /// The length of time it takes to prepare the recipe, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "prepTime")]
        public Duration PrepTime { get; set; }

        /// <summary>
        /// A single ingredient used in the recipe, e.g. sugar, flour or garlic.
        /// </summary>
        [DataMember(Name = "recipeIngredient")]
        public string RecipeIngredient { get; set; }

        /// <summary>
        /// A step or instruction involved in making the recipe.
        /// </summary>
        [DataMember(Name = "recipeInstructions")]
        public object RecipeInstructions { get; protected set; }

        /// <summary>
        /// A step or instruction involved in making the recipe.
        /// </summary>
        [IgnoreDataMember]
        public ItemList RecipeInstructionsItemList
        {
            get => this.RecipeInstructions as ItemList;
            set => this.RecipeInstructions = value;
        }

        /// <summary>
        /// A step or instruction involved in making the recipe.
        /// </summary>
        [IgnoreDataMember]
        public string RecipeInstructionsText
        {
            get => this.RecipeInstructions as string;
            set => this.RecipeInstructions = value;
        }

        /// <summary>
        /// Nutrition information about the recipe or menu item.
        /// </summary>
        [DataMember(Name = "nutrition")]
        public NutritionInformation Nutrition { get; set; }

        /// <summary>
        /// Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.
        /// </summary>
        [DataMember(Name = "suitableForDiet")]
        public RestrictedDiet SuitableForDiet { get; set; }

        /// <summary>
        /// The cuisine of the recipe (for example, French or Ethiopian).
        /// </summary>
        [DataMember(Name = "recipeCuisine")]
        public string RecipeCuisine { get; set; }

        /// <summary>
        /// The time it takes to actually cook the dish, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "cookTime")]
        public Duration CookTime { get; set; }

        /// <summary>
        /// The total time it takes to prepare and cook the recipe, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "totalTime")]
        public Duration TotalTime { get; set; }

        /// <summary>
        /// The method of cooking, such as Frying, Steaming, ...
        /// </summary>
        [DataMember(Name = "cookingMethod")]
        public string CookingMethod { get; set; }
    }
}
