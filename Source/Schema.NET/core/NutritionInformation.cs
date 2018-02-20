namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
    [DataContract]
    public partial class NutritionInformation : StructuredValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "NutritionInformation";

        /// <summary>
        /// The number of calories.
        /// </summary>
        [DataMember(Name = "calories", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Calories { get; set; }

        /// <summary>
        /// The number of grams of carbohydrates.
        /// </summary>
        [DataMember(Name = "carbohydrateContent", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? CarbohydrateContent { get; set; }

        /// <summary>
        /// The number of milligrams of cholesterol.
        /// </summary>
        [DataMember(Name = "cholesterolContent", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? CholesterolContent { get; set; }

        /// <summary>
        /// The number of grams of fat.
        /// </summary>
        [DataMember(Name = "fatContent", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? FatContent { get; set; }

        /// <summary>
        /// The number of grams of fiber.
        /// </summary>
        [DataMember(Name = "fiberContent", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? FiberContent { get; set; }

        /// <summary>
        /// The number of grams of protein.
        /// </summary>
        [DataMember(Name = "proteinContent", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? ProteinContent { get; set; }

        /// <summary>
        /// The number of grams of saturated fat.
        /// </summary>
        [DataMember(Name = "saturatedFatContent", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? SaturatedFatContent { get; set; }

        /// <summary>
        /// The serving size, in terms of the number of volume or mass.
        /// </summary>
        [DataMember(Name = "servingSize", Order = 313)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? ServingSize { get; set; }

        /// <summary>
        /// The number of milligrams of sodium.
        /// </summary>
        [DataMember(Name = "sodiumContent", Order = 314)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? SodiumContent { get; set; }

        /// <summary>
        /// The number of grams of sugar.
        /// </summary>
        [DataMember(Name = "sugarContent", Order = 315)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? SugarContent { get; set; }

        /// <summary>
        /// The number of grams of trans fat.
        /// </summary>
        [DataMember(Name = "transFatContent", Order = 316)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? TransFatContent { get; set; }

        /// <summary>
        /// The number of grams of unsaturated fat.
        /// </summary>
        [DataMember(Name = "unsaturatedFatContent", Order = 317)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? UnsaturatedFatContent { get; set; }
    }
}
