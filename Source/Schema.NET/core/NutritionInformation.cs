﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
    public partial interface INutritionInformation : IStructuredValue
    {
        /// <summary>
        /// The number of calories.
        /// </summary>
        OneOrMany<string> Calories { get; set; }

        /// <summary>
        /// The number of grams of carbohydrates.
        /// </summary>
        OneOrMany<string> CarbohydrateContent { get; set; }

        /// <summary>
        /// The number of milligrams of cholesterol.
        /// </summary>
        OneOrMany<string> CholesterolContent { get; set; }

        /// <summary>
        /// The number of grams of fat.
        /// </summary>
        OneOrMany<string> FatContent { get; set; }

        /// <summary>
        /// The number of grams of fiber.
        /// </summary>
        OneOrMany<string> FiberContent { get; set; }

        /// <summary>
        /// The number of grams of protein.
        /// </summary>
        OneOrMany<string> ProteinContent { get; set; }

        /// <summary>
        /// The number of grams of saturated fat.
        /// </summary>
        OneOrMany<string> SaturatedFatContent { get; set; }

        /// <summary>
        /// The serving size, in terms of the number of volume or mass.
        /// </summary>
        OneOrMany<string> ServingSize { get; set; }

        /// <summary>
        /// The number of milligrams of sodium.
        /// </summary>
        OneOrMany<string> SodiumContent { get; set; }

        /// <summary>
        /// The number of grams of sugar.
        /// </summary>
        OneOrMany<string> SugarContent { get; set; }

        /// <summary>
        /// The number of grams of trans fat.
        /// </summary>
        OneOrMany<string> TransFatContent { get; set; }

        /// <summary>
        /// The number of grams of unsaturated fat.
        /// </summary>
        OneOrMany<string> UnsaturatedFatContent { get; set; }
    }

    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
    [DataContract]
    public partial class NutritionInformation : StructuredValue, INutritionInformation, IEquatable<NutritionInformation>
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Calories { get; set; }

        /// <summary>
        /// The number of grams of carbohydrates.
        /// </summary>
        [DataMember(Name = "carbohydrateContent", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CarbohydrateContent { get; set; }

        /// <summary>
        /// The number of milligrams of cholesterol.
        /// </summary>
        [DataMember(Name = "cholesterolContent", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CholesterolContent { get; set; }

        /// <summary>
        /// The number of grams of fat.
        /// </summary>
        [DataMember(Name = "fatContent", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> FatContent { get; set; }

        /// <summary>
        /// The number of grams of fiber.
        /// </summary>
        [DataMember(Name = "fiberContent", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> FiberContent { get; set; }

        /// <summary>
        /// The number of grams of protein.
        /// </summary>
        [DataMember(Name = "proteinContent", Order = 311)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ProteinContent { get; set; }

        /// <summary>
        /// The number of grams of saturated fat.
        /// </summary>
        [DataMember(Name = "saturatedFatContent", Order = 312)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SaturatedFatContent { get; set; }

        /// <summary>
        /// The serving size, in terms of the number of volume or mass.
        /// </summary>
        [DataMember(Name = "servingSize", Order = 313)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ServingSize { get; set; }

        /// <summary>
        /// The number of milligrams of sodium.
        /// </summary>
        [DataMember(Name = "sodiumContent", Order = 314)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SodiumContent { get; set; }

        /// <summary>
        /// The number of grams of sugar.
        /// </summary>
        [DataMember(Name = "sugarContent", Order = 315)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SugarContent { get; set; }

        /// <summary>
        /// The number of grams of trans fat.
        /// </summary>
        [DataMember(Name = "transFatContent", Order = 316)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TransFatContent { get; set; }

        /// <summary>
        /// The number of grams of unsaturated fat.
        /// </summary>
        [DataMember(Name = "unsaturatedFatContent", Order = 317)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> UnsaturatedFatContent { get; set; }

        /// <inheritdoc/>
        public bool Equals(NutritionInformation other)
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
                this.Calories == other.Calories &&
                this.CarbohydrateContent == other.CarbohydrateContent &&
                this.CholesterolContent == other.CholesterolContent &&
                this.FatContent == other.FatContent &&
                this.FiberContent == other.FiberContent &&
                this.ProteinContent == other.ProteinContent &&
                this.SaturatedFatContent == other.SaturatedFatContent &&
                this.ServingSize == other.ServingSize &&
                this.SodiumContent == other.SodiumContent &&
                this.SugarContent == other.SugarContent &&
                this.TransFatContent == other.TransFatContent &&
                this.UnsaturatedFatContent == other.UnsaturatedFatContent &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as NutritionInformation);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Calories)
            .And(this.CarbohydrateContent)
            .And(this.CholesterolContent)
            .And(this.FatContent)
            .And(this.FiberContent)
            .And(this.ProteinContent)
            .And(this.SaturatedFatContent)
            .And(this.ServingSize)
            .And(this.SodiumContent)
            .And(this.SugarContent)
            .And(this.TransFatContent)
            .And(this.UnsaturatedFatContent)
            .And(base.GetHashCode());
    }
}
