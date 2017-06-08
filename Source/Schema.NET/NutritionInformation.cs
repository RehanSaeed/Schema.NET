namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
    [DataContract]
    public class NutritionInformation : StructuredValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "NutritionInformation";

        /// <summary>
        /// The number of grams of saturated fat.
        /// </summary>
        [DataMember(Name = "saturatedFatContent")]
        public Mass SaturatedFatContent { get; set; }

        /// <summary>
        /// The number of grams of fat.
        /// </summary>
        [DataMember(Name = "fatContent")]
        public Mass FatContent { get; set; }

        /// <summary>
        /// The number of grams of unsaturated fat.
        /// </summary>
        [DataMember(Name = "unsaturatedFatContent")]
        public Mass UnsaturatedFatContent { get; set; }

        /// <summary>
        /// The number of grams of sugar.
        /// </summary>
        [DataMember(Name = "sugarContent")]
        public Mass SugarContent { get; set; }

        /// <summary>
        /// The number of milligrams of cholesterol.
        /// </summary>
        [DataMember(Name = "cholesterolContent")]
        public Mass CholesterolContent { get; set; }

        /// <summary>
        /// The number of grams of carbohydrates.
        /// </summary>
        [DataMember(Name = "carbohydrateContent")]
        public Mass CarbohydrateContent { get; set; }

        /// <summary>
        /// The number of grams of protein.
        /// </summary>
        [DataMember(Name = "proteinContent")]
        public Mass ProteinContent { get; set; }

        /// <summary>
        /// The number of milligrams of sodium.
        /// </summary>
        [DataMember(Name = "sodiumContent")]
        public Mass SodiumContent { get; set; }

        /// <summary>
        /// The number of grams of trans fat.
        /// </summary>
        [DataMember(Name = "transFatContent")]
        public Mass TransFatContent { get; set; }

        /// <summary>
        /// The number of grams of fiber.
        /// </summary>
        [DataMember(Name = "fiberContent")]
        public Mass FiberContent { get; set; }

        /// <summary>
        /// The number of calories.
        /// </summary>
        [DataMember(Name = "calories")]
        public Energy Calories { get; set; }

        /// <summary>
        /// The serving size, in terms of the number of volume or mass.
        /// </summary>
        [DataMember(Name = "servingSize")]
        public string ServingSize { get; set; }
    }
}
