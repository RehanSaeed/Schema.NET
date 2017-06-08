namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of producing/preparing food.
    /// </summary>
    [DataContract]
    public class CookAction : CreateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "CookAction";

        /// <summary>
        /// A sub property of instrument. The recipe/instructions used to perform the action.
        /// </summary>
        [DataMember(Name = "recipe")]
        public Recipe Recipe { get; set; }

        /// <summary>
        /// A sub property of location. The specific food event where the action occurred.
        /// </summary>
        [DataMember(Name = "foodEvent")]
        public FoodEvent FoodEvent { get; set; }

        /// <summary>
        /// A sub property of location. The specific food establishment where the action occurred.
        /// </summary>
        [DataMember(Name = "foodEstablishment")]
        public object FoodEstablishment { get; protected set; }

        /// <summary>
        /// A sub property of location. The specific food establishment where the action occurred.
        /// </summary>
        [IgnoreDataMember]
        public FoodEstablishment FoodEstablishmentFoodEstablishment
        {
            get => this.FoodEstablishment as FoodEstablishment;
            set => this.FoodEstablishment = value;
        }

        /// <summary>
        /// A sub property of location. The specific food establishment where the action occurred.
        /// </summary>
        [IgnoreDataMember]
        public Place FoodEstablishmentPlace
        {
            get => this.FoodEstablishment as Place;
            set => this.FoodEstablishment = value;
        }
    }
}
