namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of producing/preparing food.
    /// </summary>
    public partial interface ICookAction : ICreateAction
    {
        /// <summary>
        /// A sub property of location. The specific food establishment where the action occurred.
        /// </summary>
        Values<IFoodEstablishment, IPlace>? FoodEstablishment { get; set; }

        /// <summary>
        /// A sub property of location. The specific food event where the action occurred.
        /// </summary>
        OneOrMany<IFoodEvent> FoodEvent { get; set; }

        /// <summary>
        /// A sub property of instrument. The recipe/instructions used to perform the action.
        /// </summary>
        OneOrMany<IRecipe> Recipe { get; set; }
    }

    /// <summary>
    /// The act of producing/preparing food.
    /// </summary>
    [DataContract]
    public partial class CookAction : CreateAction, ICookAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CookAction";

        /// <summary>
        /// A sub property of location. The specific food establishment where the action occurred.
        /// </summary>
        [DataMember(Name = "foodEstablishment", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IFoodEstablishment, IPlace>? FoodEstablishment { get; set; }

        /// <summary>
        /// A sub property of location. The specific food event where the action occurred.
        /// </summary>
        [DataMember(Name = "foodEvent", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IFoodEvent> FoodEvent { get; set; }

        /// <summary>
        /// A sub property of instrument. The recipe/instructions used to perform the action.
        /// </summary>
        [DataMember(Name = "recipe", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IRecipe> Recipe { get; set; }
    }
}
