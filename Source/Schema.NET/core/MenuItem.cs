namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A food or drink item listed in a menu or menu section.
    /// </summary>
    [DataContract]
    public partial class MenuItem : Intangible
    {
        public interface IMenuAddOn : IValue {}
        public interface IMenuAddOn<T> : IMenuAddOn { new T Value { get; } }
        public class OneOrManyMenuAddOn : OneOrMany<IMenuAddOn>
        {
            public OneOrManyMenuAddOn(IMenuAddOn item) : base(item) { }
            public OneOrManyMenuAddOn(IEnumerable<IMenuAddOn> items) : base(items) { }
            public static implicit operator OneOrManyMenuAddOn (MenuItem value) { return new OneOrManyMenuAddOn (new MenuAddOnMenuItem (value)); }
            public static implicit operator OneOrManyMenuAddOn (MenuItem[] values) { return new OneOrManyMenuAddOn (values.Select(v => (IMenuAddOn) new MenuAddOnMenuItem (v))); }
            public static implicit operator OneOrManyMenuAddOn (List<MenuItem> values) { return new OneOrManyMenuAddOn (values.Select(v => (IMenuAddOn) new MenuAddOnMenuItem (v))); }
            public static implicit operator OneOrManyMenuAddOn (MenuSection value) { return new OneOrManyMenuAddOn (new MenuAddOnMenuSection (value)); }
            public static implicit operator OneOrManyMenuAddOn (MenuSection[] values) { return new OneOrManyMenuAddOn (values.Select(v => (IMenuAddOn) new MenuAddOnMenuSection (v))); }
            public static implicit operator OneOrManyMenuAddOn (List<MenuSection> values) { return new OneOrManyMenuAddOn (values.Select(v => (IMenuAddOn) new MenuAddOnMenuSection (v))); }
        }
        public struct MenuAddOnMenuItem : IMenuAddOn<MenuItem>
        {
            object IValue.Value => this.Value;
            public MenuItem Value { get; }
            public MenuAddOnMenuItem (MenuItem value) { Value = value; }
            public static implicit operator MenuAddOnMenuItem (MenuItem value) { return new MenuAddOnMenuItem (value); }
        }
        public struct MenuAddOnMenuSection : IMenuAddOn<MenuSection>
        {
            object IValue.Value => this.Value;
            public MenuSection Value { get; }
            public MenuAddOnMenuSection (MenuSection value) { Value = value; }
            public static implicit operator MenuAddOnMenuSection (MenuSection value) { return new MenuAddOnMenuSection (value); }
        }

        public interface INutrition : IValue {}
        public interface INutrition<T> : INutrition { new T Value { get; } }
        public class OneOrManyNutrition : OneOrMany<INutrition>
        {
            public OneOrManyNutrition(INutrition item) : base(item) { }
            public OneOrManyNutrition(IEnumerable<INutrition> items) : base(items) { }
            public static implicit operator OneOrManyNutrition (NutritionInformation value) { return new OneOrManyNutrition (new NutritionNutritionInformation (value)); }
            public static implicit operator OneOrManyNutrition (NutritionInformation[] values) { return new OneOrManyNutrition (values.Select(v => (INutrition) new NutritionNutritionInformation (v))); }
            public static implicit operator OneOrManyNutrition (List<NutritionInformation> values) { return new OneOrManyNutrition (values.Select(v => (INutrition) new NutritionNutritionInformation (v))); }
        }
        public struct NutritionNutritionInformation : INutrition<NutritionInformation>
        {
            object IValue.Value => this.Value;
            public NutritionInformation Value { get; }
            public NutritionNutritionInformation (NutritionInformation value) { Value = value; }
            public static implicit operator NutritionNutritionInformation (NutritionInformation value) { return new NutritionNutritionInformation (value); }
        }

        public interface IOffers : IValue {}
        public interface IOffers<T> : IOffers { new T Value { get; } }
        public class OneOrManyOffers : OneOrMany<IOffers>
        {
            public OneOrManyOffers(IOffers item) : base(item) { }
            public OneOrManyOffers(IEnumerable<IOffers> items) : base(items) { }
            public static implicit operator OneOrManyOffers (Offer value) { return new OneOrManyOffers (new OffersOffer (value)); }
            public static implicit operator OneOrManyOffers (Offer[] values) { return new OneOrManyOffers (values.Select(v => (IOffers) new OffersOffer (v))); }
            public static implicit operator OneOrManyOffers (List<Offer> values) { return new OneOrManyOffers (values.Select(v => (IOffers) new OffersOffer (v))); }
        }
        public struct OffersOffer : IOffers<Offer>
        {
            object IValue.Value => this.Value;
            public Offer Value { get; }
            public OffersOffer (Offer value) { Value = value; }
            public static implicit operator OffersOffer (Offer value) { return new OffersOffer (value); }
        }

        public interface ISuitableForDiet : IValue {}
        public interface ISuitableForDiet<T> : ISuitableForDiet { new T Value { get; } }
        public class OneOrManySuitableForDiet : OneOrMany<ISuitableForDiet>
        {
            public OneOrManySuitableForDiet(ISuitableForDiet item) : base(item) { }
            public OneOrManySuitableForDiet(IEnumerable<ISuitableForDiet> items) : base(items) { }
            public static implicit operator OneOrManySuitableForDiet (RestrictedDiet value) { return new OneOrManySuitableForDiet (new SuitableForDietRestrictedDiet (value)); }
            public static implicit operator OneOrManySuitableForDiet (RestrictedDiet[] values) { return new OneOrManySuitableForDiet (values.Select(v => (ISuitableForDiet) new SuitableForDietRestrictedDiet (v))); }
            public static implicit operator OneOrManySuitableForDiet (List<RestrictedDiet> values) { return new OneOrManySuitableForDiet (values.Select(v => (ISuitableForDiet) new SuitableForDietRestrictedDiet (v))); }
        }
        public struct SuitableForDietRestrictedDiet : ISuitableForDiet<RestrictedDiet>
        {
            object IValue.Value => this.Value;
            public RestrictedDiet Value { get; }
            public SuitableForDietRestrictedDiet (RestrictedDiet value) { Value = value; }
            public static implicit operator SuitableForDietRestrictedDiet (RestrictedDiet value) { return new SuitableForDietRestrictedDiet (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MenuItem";

        /// <summary>
        /// Additional menu item(s) such as a side dish of salad or side order of fries that can be added to this menu item. Additionally it can be a menu section containing allowed add-on menu items for this menu item.
        /// </summary>
        [DataMember(Name = "menuAddOn", Order = 206)]
        public OneOrManyMenuAddOn MenuAddOn { get; set; }

        /// <summary>
        /// Nutrition information about the recipe or menu item.
        /// </summary>
        [DataMember(Name = "nutrition", Order = 207)]
        public OneOrManyNutrition Nutrition { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers", Order = 208)]
        public OneOrManyOffers Offers { get; set; }

        /// <summary>
        /// Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.
        /// </summary>
        [DataMember(Name = "suitableForDiet", Order = 209)]
        public OneOrManySuitableForDiet SuitableForDiet { get; set; }
    }
}
