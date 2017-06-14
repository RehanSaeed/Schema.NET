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
        [DataMember(Name = "calories", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Energy>? Calories { get; set; }

        /// <summary>
        /// The number of grams of carbohydrates.
        /// </summary>
        [DataMember(Name = "carbohydrateContent", Order = 3)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Mass>? CarbohydrateContent { get; set; }

        /// <summary>
        /// The number of milligrams of cholesterol.
        /// </summary>
        [DataMember(Name = "cholesterolContent", Order = 4)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Mass>? CholesterolContent { get; set; }

        /// <summary>
        /// The number of grams of fat.
        /// </summary>
        [DataMember(Name = "fatContent", Order = 5)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Mass>? FatContent { get; set; }

        /// <summary>
        /// The number of grams of fiber.
        /// </summary>
        [DataMember(Name = "fiberContent", Order = 6)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Mass>? FiberContent { get; set; }

        /// <summary>
        /// The number of grams of protein.
        /// </summary>
        [DataMember(Name = "proteinContent", Order = 7)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Mass>? ProteinContent { get; set; }

        /// <summary>
        /// The number of grams of saturated fat.
        /// </summary>
        [DataMember(Name = "saturatedFatContent", Order = 8)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Mass>? SaturatedFatContent { get; set; }

        /// <summary>
        /// The serving size, in terms of the number of volume or mass.
        /// </summary>
        [DataMember(Name = "servingSize", Order = 9)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ServingSize { get; set; }

        /// <summary>
        /// The number of milligrams of sodium.
        /// </summary>
        [DataMember(Name = "sodiumContent", Order = 10)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Mass>? SodiumContent { get; set; }

        /// <summary>
        /// The number of grams of sugar.
        /// </summary>
        [DataMember(Name = "sugarContent", Order = 11)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Mass>? SugarContent { get; set; }

        /// <summary>
        /// The number of grams of trans fat.
        /// </summary>
        [DataMember(Name = "transFatContent", Order = 12)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Mass>? TransFatContent { get; set; }

        /// <summary>
        /// The number of grams of unsaturated fat.
        /// </summary>
        [DataMember(Name = "unsaturatedFatContent", Order = 13)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Mass>? UnsaturatedFatContent { get; set; }
    }
}
