using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// The act of producing/preparing food.
    /// </summary>
    [DataContract]
    public partial class CookAction : CreateAction
    {
        public interface IFoodEstablishment : IWrapper { }
        public interface IFoodEstablishment<T> : IFoodEstablishment { new T Data { get; set; } }
        public class FoodEstablishmentFoodEstablishment : IFoodEstablishment<FoodEstablishment>
        {
            object IWrapper.Data { get { return Data; } set { Data = (FoodEstablishment) value; } }
            public virtual FoodEstablishment Data { get; set; }
            public FoodEstablishmentFoodEstablishment () { }
            public FoodEstablishmentFoodEstablishment (FoodEstablishment data) { Data = data; }
            public static implicit operator FoodEstablishmentFoodEstablishment (FoodEstablishment data) { return new FoodEstablishmentFoodEstablishment (data); }
        }

        public class FoodEstablishmentPlace : IFoodEstablishment<Place>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Place) value; } }
            public virtual Place Data { get; set; }
            public FoodEstablishmentPlace () { }
            public FoodEstablishmentPlace (Place data) { Data = data; }
            public static implicit operator FoodEstablishmentPlace (Place data) { return new FoodEstablishmentPlace (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CookAction";

        /// <summary>
        /// A sub property of location. The specific food establishment where the action occurred.
        /// </summary>
        [DataMember(Name = "foodEstablishment", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IFoodEstablishment>? FoodEstablishment { get; set; } //FoodEstablishment, Place

        /// <summary>
        /// A sub property of location. The specific food event where the action occurred.
        /// </summary>
        [DataMember(Name = "foodEvent", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<FoodEvent>? FoodEvent { get; set; } 

        /// <summary>
        /// A sub property of instrument. The recipe/instructions used to perform the action.
        /// </summary>
        [DataMember(Name = "recipe", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Recipe>? Recipe { get; set; } 
    }
}
