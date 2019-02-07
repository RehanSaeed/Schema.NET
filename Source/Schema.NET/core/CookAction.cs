namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of producing/preparing food.
    /// </summary>
    [DataContract]
    public partial class CookAction : CreateAction
    {
        public interface IFoodEstablishment : IValue {}
        public interface IFoodEstablishment<T> : IFoodEstablishment { new T Value { get; } }
        public class OneOrManyFoodEstablishment : OneOrMany<IFoodEstablishment>
        {
            public OneOrManyFoodEstablishment(IFoodEstablishment item) : base(item) { }
            public OneOrManyFoodEstablishment(IEnumerable<IFoodEstablishment> items) : base(items) { }
            public static implicit operator OneOrManyFoodEstablishment (FoodEstablishment value) { return new OneOrManyFoodEstablishment (new FoodEstablishmentFoodEstablishment (value)); }
            public static implicit operator OneOrManyFoodEstablishment (FoodEstablishment[] values) { return new OneOrManyFoodEstablishment (values.Select(v => (IFoodEstablishment) new FoodEstablishmentFoodEstablishment (v))); }
            public static implicit operator OneOrManyFoodEstablishment (List<FoodEstablishment> values) { return new OneOrManyFoodEstablishment (values.Select(v => (IFoodEstablishment) new FoodEstablishmentFoodEstablishment (v))); }
            public static implicit operator OneOrManyFoodEstablishment (Place value) { return new OneOrManyFoodEstablishment (new FoodEstablishmentPlace (value)); }
            public static implicit operator OneOrManyFoodEstablishment (Place[] values) { return new OneOrManyFoodEstablishment (values.Select(v => (IFoodEstablishment) new FoodEstablishmentPlace (v))); }
            public static implicit operator OneOrManyFoodEstablishment (List<Place> values) { return new OneOrManyFoodEstablishment (values.Select(v => (IFoodEstablishment) new FoodEstablishmentPlace (v))); }
        }
        public struct FoodEstablishmentFoodEstablishment : IFoodEstablishment<FoodEstablishment>
        {
            object IValue.Value => this.Value;
            public FoodEstablishment Value { get; }
            public FoodEstablishmentFoodEstablishment (FoodEstablishment value) { Value = value; }
            public static implicit operator FoodEstablishmentFoodEstablishment (FoodEstablishment value) { return new FoodEstablishmentFoodEstablishment (value); }
        }
        public struct FoodEstablishmentPlace : IFoodEstablishment<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public FoodEstablishmentPlace (Place value) { Value = value; }
            public static implicit operator FoodEstablishmentPlace (Place value) { return new FoodEstablishmentPlace (value); }
        }

        public interface IFoodEvent : IValue {}
        public interface IFoodEvent<T> : IFoodEvent { new T Value { get; } }
        public class OneOrManyFoodEvent : OneOrMany<IFoodEvent>
        {
            public OneOrManyFoodEvent(IFoodEvent item) : base(item) { }
            public OneOrManyFoodEvent(IEnumerable<IFoodEvent> items) : base(items) { }
            public static implicit operator OneOrManyFoodEvent (FoodEvent value) { return new OneOrManyFoodEvent (new FoodEventFoodEvent (value)); }
            public static implicit operator OneOrManyFoodEvent (FoodEvent[] values) { return new OneOrManyFoodEvent (values.Select(v => (IFoodEvent) new FoodEventFoodEvent (v))); }
            public static implicit operator OneOrManyFoodEvent (List<FoodEvent> values) { return new OneOrManyFoodEvent (values.Select(v => (IFoodEvent) new FoodEventFoodEvent (v))); }
        }
        public struct FoodEventFoodEvent : IFoodEvent<FoodEvent>
        {
            object IValue.Value => this.Value;
            public FoodEvent Value { get; }
            public FoodEventFoodEvent (FoodEvent value) { Value = value; }
            public static implicit operator FoodEventFoodEvent (FoodEvent value) { return new FoodEventFoodEvent (value); }
        }

        public interface IRecipe : IValue {}
        public interface IRecipe<T> : IRecipe { new T Value { get; } }
        public class OneOrManyRecipe : OneOrMany<IRecipe>
        {
            public OneOrManyRecipe(IRecipe item) : base(item) { }
            public OneOrManyRecipe(IEnumerable<IRecipe> items) : base(items) { }
            public static implicit operator OneOrManyRecipe (Recipe value) { return new OneOrManyRecipe (new RecipeRecipe (value)); }
            public static implicit operator OneOrManyRecipe (Recipe[] values) { return new OneOrManyRecipe (values.Select(v => (IRecipe) new RecipeRecipe (v))); }
            public static implicit operator OneOrManyRecipe (List<Recipe> values) { return new OneOrManyRecipe (values.Select(v => (IRecipe) new RecipeRecipe (v))); }
        }
        public struct RecipeRecipe : IRecipe<Recipe>
        {
            object IValue.Value => this.Value;
            public Recipe Value { get; }
            public RecipeRecipe (Recipe value) { Value = value; }
            public static implicit operator RecipeRecipe (Recipe value) { return new RecipeRecipe (value); }
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
        public OneOrManyFoodEstablishment FoodEstablishment { get; set; }

        /// <summary>
        /// A sub property of location. The specific food event where the action occurred.
        /// </summary>
        [DataMember(Name = "foodEvent", Order = 307)]
        public OneOrManyFoodEvent FoodEvent { get; set; }

        /// <summary>
        /// A sub property of instrument. The recipe/instructions used to perform the action.
        /// </summary>
        [DataMember(Name = "recipe", Order = 308)]
        public OneOrManyRecipe Recipe { get; set; }
    }
}
