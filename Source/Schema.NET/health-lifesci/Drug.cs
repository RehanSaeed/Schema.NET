namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge make a clear difference between them.
    /// </summary>
    [DataContract]
    public partial class Drug : Substance
    {

        public interface IAdministrationRoute : IValue {}
        public interface IAdministrationRoute<T> : IAdministrationRoute { new T Value { get; } }
        public class OneOrManyAdministrationRoute : OneOrMany<IAdministrationRoute>
        {
            public OneOrManyAdministrationRoute(IAdministrationRoute item) : base(item) { }
            public OneOrManyAdministrationRoute(IEnumerable<IAdministrationRoute> items) : base(items) { }
            public static implicit operator OneOrManyAdministrationRoute (string value) { return new OneOrManyAdministrationRoute (new AdministrationRoutestring (value)); }
            public static implicit operator OneOrManyAdministrationRoute (string[] values) { return new OneOrManyAdministrationRoute (values.Select(v => (IAdministrationRoute) new AdministrationRoutestring (v))); }
            public static implicit operator OneOrManyAdministrationRoute (List<string> values) { return new OneOrManyAdministrationRoute (values.Select(v => (IAdministrationRoute) new AdministrationRoutestring (v))); }
        }
        public struct AdministrationRoutestring : IAdministrationRoute<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AdministrationRoutestring (string value) { Value = value; }
            public static implicit operator AdministrationRoutestring (string value) { return new AdministrationRoutestring (value); }
        }

        public interface IAlcoholWarning : IValue {}
        public interface IAlcoholWarning<T> : IAlcoholWarning { new T Value { get; } }
        public class OneOrManyAlcoholWarning : OneOrMany<IAlcoholWarning>
        {
            public OneOrManyAlcoholWarning(IAlcoholWarning item) : base(item) { }
            public OneOrManyAlcoholWarning(IEnumerable<IAlcoholWarning> items) : base(items) { }
            public static implicit operator OneOrManyAlcoholWarning (string value) { return new OneOrManyAlcoholWarning (new AlcoholWarningstring (value)); }
            public static implicit operator OneOrManyAlcoholWarning (string[] values) { return new OneOrManyAlcoholWarning (values.Select(v => (IAlcoholWarning) new AlcoholWarningstring (v))); }
            public static implicit operator OneOrManyAlcoholWarning (List<string> values) { return new OneOrManyAlcoholWarning (values.Select(v => (IAlcoholWarning) new AlcoholWarningstring (v))); }
        }
        public struct AlcoholWarningstring : IAlcoholWarning<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AlcoholWarningstring (string value) { Value = value; }
            public static implicit operator AlcoholWarningstring (string value) { return new AlcoholWarningstring (value); }
        }

        public interface IAvailableStrength : IValue {}
        public interface IAvailableStrength<T> : IAvailableStrength { new T Value { get; } }
        public class OneOrManyAvailableStrength : OneOrMany<IAvailableStrength>
        {
            public OneOrManyAvailableStrength(IAvailableStrength item) : base(item) { }
            public OneOrManyAvailableStrength(IEnumerable<IAvailableStrength> items) : base(items) { }
            public static implicit operator OneOrManyAvailableStrength (DrugStrength value) { return new OneOrManyAvailableStrength (new AvailableStrengthDrugStrength (value)); }
            public static implicit operator OneOrManyAvailableStrength (DrugStrength[] values) { return new OneOrManyAvailableStrength (values.Select(v => (IAvailableStrength) new AvailableStrengthDrugStrength (v))); }
            public static implicit operator OneOrManyAvailableStrength (List<DrugStrength> values) { return new OneOrManyAvailableStrength (values.Select(v => (IAvailableStrength) new AvailableStrengthDrugStrength (v))); }
        }
        public struct AvailableStrengthDrugStrength : IAvailableStrength<DrugStrength>
        {
            object IValue.Value => this.Value;
            public DrugStrength Value { get; }
            public AvailableStrengthDrugStrength (DrugStrength value) { Value = value; }
            public static implicit operator AvailableStrengthDrugStrength (DrugStrength value) { return new AvailableStrengthDrugStrength (value); }
        }

        public interface IBreastfeedingWarning : IValue {}
        public interface IBreastfeedingWarning<T> : IBreastfeedingWarning { new T Value { get; } }
        public class OneOrManyBreastfeedingWarning : OneOrMany<IBreastfeedingWarning>
        {
            public OneOrManyBreastfeedingWarning(IBreastfeedingWarning item) : base(item) { }
            public OneOrManyBreastfeedingWarning(IEnumerable<IBreastfeedingWarning> items) : base(items) { }
            public static implicit operator OneOrManyBreastfeedingWarning (string value) { return new OneOrManyBreastfeedingWarning (new BreastfeedingWarningstring (value)); }
            public static implicit operator OneOrManyBreastfeedingWarning (string[] values) { return new OneOrManyBreastfeedingWarning (values.Select(v => (IBreastfeedingWarning) new BreastfeedingWarningstring (v))); }
            public static implicit operator OneOrManyBreastfeedingWarning (List<string> values) { return new OneOrManyBreastfeedingWarning (values.Select(v => (IBreastfeedingWarning) new BreastfeedingWarningstring (v))); }
        }
        public struct BreastfeedingWarningstring : IBreastfeedingWarning<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public BreastfeedingWarningstring (string value) { Value = value; }
            public static implicit operator BreastfeedingWarningstring (string value) { return new BreastfeedingWarningstring (value); }
        }

        public interface IClinicalPharmacology : IValue {}
        public interface IClinicalPharmacology<T> : IClinicalPharmacology { new T Value { get; } }
        public class OneOrManyClinicalPharmacology : OneOrMany<IClinicalPharmacology>
        {
            public OneOrManyClinicalPharmacology(IClinicalPharmacology item) : base(item) { }
            public OneOrManyClinicalPharmacology(IEnumerable<IClinicalPharmacology> items) : base(items) { }
            public static implicit operator OneOrManyClinicalPharmacology (string value) { return new OneOrManyClinicalPharmacology (new ClinicalPharmacologystring (value)); }
            public static implicit operator OneOrManyClinicalPharmacology (string[] values) { return new OneOrManyClinicalPharmacology (values.Select(v => (IClinicalPharmacology) new ClinicalPharmacologystring (v))); }
            public static implicit operator OneOrManyClinicalPharmacology (List<string> values) { return new OneOrManyClinicalPharmacology (values.Select(v => (IClinicalPharmacology) new ClinicalPharmacologystring (v))); }
        }
        public struct ClinicalPharmacologystring : IClinicalPharmacology<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ClinicalPharmacologystring (string value) { Value = value; }
            public static implicit operator ClinicalPharmacologystring (string value) { return new ClinicalPharmacologystring (value); }
        }

        public interface ICost : IValue {}
        public interface ICost<T> : ICost { new T Value { get; } }
        public class OneOrManyCost : OneOrMany<ICost>
        {
            public OneOrManyCost(ICost item) : base(item) { }
            public OneOrManyCost(IEnumerable<ICost> items) : base(items) { }
            public static implicit operator OneOrManyCost (DrugCost value) { return new OneOrManyCost (new CostDrugCost (value)); }
            public static implicit operator OneOrManyCost (DrugCost[] values) { return new OneOrManyCost (values.Select(v => (ICost) new CostDrugCost (v))); }
            public static implicit operator OneOrManyCost (List<DrugCost> values) { return new OneOrManyCost (values.Select(v => (ICost) new CostDrugCost (v))); }
        }
        public struct CostDrugCost : ICost<DrugCost>
        {
            object IValue.Value => this.Value;
            public DrugCost Value { get; }
            public CostDrugCost (DrugCost value) { Value = value; }
            public static implicit operator CostDrugCost (DrugCost value) { return new CostDrugCost (value); }
        }

        public interface IDosageForm : IValue {}
        public interface IDosageForm<T> : IDosageForm { new T Value { get; } }
        public class OneOrManyDosageForm : OneOrMany<IDosageForm>
        {
            public OneOrManyDosageForm(IDosageForm item) : base(item) { }
            public OneOrManyDosageForm(IEnumerable<IDosageForm> items) : base(items) { }
            public static implicit operator OneOrManyDosageForm (string value) { return new OneOrManyDosageForm (new DosageFormstring (value)); }
            public static implicit operator OneOrManyDosageForm (string[] values) { return new OneOrManyDosageForm (values.Select(v => (IDosageForm) new DosageFormstring (v))); }
            public static implicit operator OneOrManyDosageForm (List<string> values) { return new OneOrManyDosageForm (values.Select(v => (IDosageForm) new DosageFormstring (v))); }
        }
        public struct DosageFormstring : IDosageForm<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public DosageFormstring (string value) { Value = value; }
            public static implicit operator DosageFormstring (string value) { return new DosageFormstring (value); }
        }

        public interface IDoseSchedule : IValue {}
        public interface IDoseSchedule<T> : IDoseSchedule { new T Value { get; } }
        public class OneOrManyDoseSchedule : OneOrMany<IDoseSchedule>
        {
            public OneOrManyDoseSchedule(IDoseSchedule item) : base(item) { }
            public OneOrManyDoseSchedule(IEnumerable<IDoseSchedule> items) : base(items) { }
            public static implicit operator OneOrManyDoseSchedule (DoseSchedule value) { return new OneOrManyDoseSchedule (new DoseScheduleDoseSchedule (value)); }
            public static implicit operator OneOrManyDoseSchedule (DoseSchedule[] values) { return new OneOrManyDoseSchedule (values.Select(v => (IDoseSchedule) new DoseScheduleDoseSchedule (v))); }
            public static implicit operator OneOrManyDoseSchedule (List<DoseSchedule> values) { return new OneOrManyDoseSchedule (values.Select(v => (IDoseSchedule) new DoseScheduleDoseSchedule (v))); }
        }
        public struct DoseScheduleDoseSchedule : IDoseSchedule<DoseSchedule>
        {
            object IValue.Value => this.Value;
            public DoseSchedule Value { get; }
            public DoseScheduleDoseSchedule (DoseSchedule value) { Value = value; }
            public static implicit operator DoseScheduleDoseSchedule (DoseSchedule value) { return new DoseScheduleDoseSchedule (value); }
        }

        public interface IDrugClass : IValue {}
        public interface IDrugClass<T> : IDrugClass { new T Value { get; } }
        public class OneOrManyDrugClass : OneOrMany<IDrugClass>
        {
            public OneOrManyDrugClass(IDrugClass item) : base(item) { }
            public OneOrManyDrugClass(IEnumerable<IDrugClass> items) : base(items) { }
            public static implicit operator OneOrManyDrugClass (DrugClass value) { return new OneOrManyDrugClass (new DrugClassDrugClass (value)); }
            public static implicit operator OneOrManyDrugClass (DrugClass[] values) { return new OneOrManyDrugClass (values.Select(v => (IDrugClass) new DrugClassDrugClass (v))); }
            public static implicit operator OneOrManyDrugClass (List<DrugClass> values) { return new OneOrManyDrugClass (values.Select(v => (IDrugClass) new DrugClassDrugClass (v))); }
        }
        public struct DrugClassDrugClass : IDrugClass<DrugClass>
        {
            object IValue.Value => this.Value;
            public DrugClass Value { get; }
            public DrugClassDrugClass (DrugClass value) { Value = value; }
            public static implicit operator DrugClassDrugClass (DrugClass value) { return new DrugClassDrugClass (value); }
        }

        public interface IDrugUnit : IValue {}
        public interface IDrugUnit<T> : IDrugUnit { new T Value { get; } }
        public class OneOrManyDrugUnit : OneOrMany<IDrugUnit>
        {
            public OneOrManyDrugUnit(IDrugUnit item) : base(item) { }
            public OneOrManyDrugUnit(IEnumerable<IDrugUnit> items) : base(items) { }
            public static implicit operator OneOrManyDrugUnit (string value) { return new OneOrManyDrugUnit (new DrugUnitstring (value)); }
            public static implicit operator OneOrManyDrugUnit (string[] values) { return new OneOrManyDrugUnit (values.Select(v => (IDrugUnit) new DrugUnitstring (v))); }
            public static implicit operator OneOrManyDrugUnit (List<string> values) { return new OneOrManyDrugUnit (values.Select(v => (IDrugUnit) new DrugUnitstring (v))); }
        }
        public struct DrugUnitstring : IDrugUnit<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public DrugUnitstring (string value) { Value = value; }
            public static implicit operator DrugUnitstring (string value) { return new DrugUnitstring (value); }
        }

        public interface IFoodWarning : IValue {}
        public interface IFoodWarning<T> : IFoodWarning { new T Value { get; } }
        public class OneOrManyFoodWarning : OneOrMany<IFoodWarning>
        {
            public OneOrManyFoodWarning(IFoodWarning item) : base(item) { }
            public OneOrManyFoodWarning(IEnumerable<IFoodWarning> items) : base(items) { }
            public static implicit operator OneOrManyFoodWarning (string value) { return new OneOrManyFoodWarning (new FoodWarningstring (value)); }
            public static implicit operator OneOrManyFoodWarning (string[] values) { return new OneOrManyFoodWarning (values.Select(v => (IFoodWarning) new FoodWarningstring (v))); }
            public static implicit operator OneOrManyFoodWarning (List<string> values) { return new OneOrManyFoodWarning (values.Select(v => (IFoodWarning) new FoodWarningstring (v))); }
        }
        public struct FoodWarningstring : IFoodWarning<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public FoodWarningstring (string value) { Value = value; }
            public static implicit operator FoodWarningstring (string value) { return new FoodWarningstring (value); }
        }

        public interface IInteractingDrug : IValue {}
        public interface IInteractingDrug<T> : IInteractingDrug { new T Value { get; } }
        public class OneOrManyInteractingDrug : OneOrMany<IInteractingDrug>
        {
            public OneOrManyInteractingDrug(IInteractingDrug item) : base(item) { }
            public OneOrManyInteractingDrug(IEnumerable<IInteractingDrug> items) : base(items) { }
            public static implicit operator OneOrManyInteractingDrug (Drug value) { return new OneOrManyInteractingDrug (new InteractingDrugDrug (value)); }
            public static implicit operator OneOrManyInteractingDrug (Drug[] values) { return new OneOrManyInteractingDrug (values.Select(v => (IInteractingDrug) new InteractingDrugDrug (v))); }
            public static implicit operator OneOrManyInteractingDrug (List<Drug> values) { return new OneOrManyInteractingDrug (values.Select(v => (IInteractingDrug) new InteractingDrugDrug (v))); }
        }
        public struct InteractingDrugDrug : IInteractingDrug<Drug>
        {
            object IValue.Value => this.Value;
            public Drug Value { get; }
            public InteractingDrugDrug (Drug value) { Value = value; }
            public static implicit operator InteractingDrugDrug (Drug value) { return new InteractingDrugDrug (value); }
        }

        public interface IIsAvailableGenerically : IValue {}
        public interface IIsAvailableGenerically<T> : IIsAvailableGenerically { new T Value { get; } }
        public class OneOrManyIsAvailableGenerically : OneOrMany<IIsAvailableGenerically>
        {
            public OneOrManyIsAvailableGenerically(IIsAvailableGenerically item) : base(item) { }
            public OneOrManyIsAvailableGenerically(IEnumerable<IIsAvailableGenerically> items) : base(items) { }
            public static implicit operator OneOrManyIsAvailableGenerically (bool value) { return new OneOrManyIsAvailableGenerically (new IsAvailableGenericallybool (value)); }
            public static implicit operator OneOrManyIsAvailableGenerically (bool[] values) { return new OneOrManyIsAvailableGenerically (values.Select(v => (IIsAvailableGenerically) new IsAvailableGenericallybool (v))); }
            public static implicit operator OneOrManyIsAvailableGenerically (List<bool> values) { return new OneOrManyIsAvailableGenerically (values.Select(v => (IIsAvailableGenerically) new IsAvailableGenericallybool (v))); }
        }
        public struct IsAvailableGenericallybool : IIsAvailableGenerically<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public IsAvailableGenericallybool (bool value) { Value = value; }
            public static implicit operator IsAvailableGenericallybool (bool value) { return new IsAvailableGenericallybool (value); }
        }

        public interface IIsProprietary : IValue {}
        public interface IIsProprietary<T> : IIsProprietary { new T Value { get; } }
        public class OneOrManyIsProprietary : OneOrMany<IIsProprietary>
        {
            public OneOrManyIsProprietary(IIsProprietary item) : base(item) { }
            public OneOrManyIsProprietary(IEnumerable<IIsProprietary> items) : base(items) { }
            public static implicit operator OneOrManyIsProprietary (bool value) { return new OneOrManyIsProprietary (new IsProprietarybool (value)); }
            public static implicit operator OneOrManyIsProprietary (bool[] values) { return new OneOrManyIsProprietary (values.Select(v => (IIsProprietary) new IsProprietarybool (v))); }
            public static implicit operator OneOrManyIsProprietary (List<bool> values) { return new OneOrManyIsProprietary (values.Select(v => (IIsProprietary) new IsProprietarybool (v))); }
        }
        public struct IsProprietarybool : IIsProprietary<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public IsProprietarybool (bool value) { Value = value; }
            public static implicit operator IsProprietarybool (bool value) { return new IsProprietarybool (value); }
        }

        public interface ILabelDetails : IValue {}
        public interface ILabelDetails<T> : ILabelDetails { new T Value { get; } }
        public class OneOrManyLabelDetails : OneOrMany<ILabelDetails>
        {
            public OneOrManyLabelDetails(ILabelDetails item) : base(item) { }
            public OneOrManyLabelDetails(IEnumerable<ILabelDetails> items) : base(items) { }
            public static implicit operator OneOrManyLabelDetails (Uri value) { return new OneOrManyLabelDetails (new LabelDetailsUri (value)); }
            public static implicit operator OneOrManyLabelDetails (Uri[] values) { return new OneOrManyLabelDetails (values.Select(v => (ILabelDetails) new LabelDetailsUri (v))); }
            public static implicit operator OneOrManyLabelDetails (List<Uri> values) { return new OneOrManyLabelDetails (values.Select(v => (ILabelDetails) new LabelDetailsUri (v))); }
        }
        public struct LabelDetailsUri : ILabelDetails<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public LabelDetailsUri (Uri value) { Value = value; }
            public static implicit operator LabelDetailsUri (Uri value) { return new LabelDetailsUri (value); }
        }



        public interface IMechanismOfAction : IValue {}
        public interface IMechanismOfAction<T> : IMechanismOfAction { new T Value { get; } }
        public class OneOrManyMechanismOfAction : OneOrMany<IMechanismOfAction>
        {
            public OneOrManyMechanismOfAction(IMechanismOfAction item) : base(item) { }
            public OneOrManyMechanismOfAction(IEnumerable<IMechanismOfAction> items) : base(items) { }
            public static implicit operator OneOrManyMechanismOfAction (string value) { return new OneOrManyMechanismOfAction (new MechanismOfActionstring (value)); }
            public static implicit operator OneOrManyMechanismOfAction (string[] values) { return new OneOrManyMechanismOfAction (values.Select(v => (IMechanismOfAction) new MechanismOfActionstring (v))); }
            public static implicit operator OneOrManyMechanismOfAction (List<string> values) { return new OneOrManyMechanismOfAction (values.Select(v => (IMechanismOfAction) new MechanismOfActionstring (v))); }
        }
        public struct MechanismOfActionstring : IMechanismOfAction<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public MechanismOfActionstring (string value) { Value = value; }
            public static implicit operator MechanismOfActionstring (string value) { return new MechanismOfActionstring (value); }
        }

        public interface INonProprietaryName : IValue {}
        public interface INonProprietaryName<T> : INonProprietaryName { new T Value { get; } }
        public class OneOrManyNonProprietaryName : OneOrMany<INonProprietaryName>
        {
            public OneOrManyNonProprietaryName(INonProprietaryName item) : base(item) { }
            public OneOrManyNonProprietaryName(IEnumerable<INonProprietaryName> items) : base(items) { }
            public static implicit operator OneOrManyNonProprietaryName (string value) { return new OneOrManyNonProprietaryName (new NonProprietaryNamestring (value)); }
            public static implicit operator OneOrManyNonProprietaryName (string[] values) { return new OneOrManyNonProprietaryName (values.Select(v => (INonProprietaryName) new NonProprietaryNamestring (v))); }
            public static implicit operator OneOrManyNonProprietaryName (List<string> values) { return new OneOrManyNonProprietaryName (values.Select(v => (INonProprietaryName) new NonProprietaryNamestring (v))); }
        }
        public struct NonProprietaryNamestring : INonProprietaryName<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public NonProprietaryNamestring (string value) { Value = value; }
            public static implicit operator NonProprietaryNamestring (string value) { return new NonProprietaryNamestring (value); }
        }

        public interface IOverdosage : IValue {}
        public interface IOverdosage<T> : IOverdosage { new T Value { get; } }
        public class OneOrManyOverdosage : OneOrMany<IOverdosage>
        {
            public OneOrManyOverdosage(IOverdosage item) : base(item) { }
            public OneOrManyOverdosage(IEnumerable<IOverdosage> items) : base(items) { }
            public static implicit operator OneOrManyOverdosage (string value) { return new OneOrManyOverdosage (new Overdosagestring (value)); }
            public static implicit operator OneOrManyOverdosage (string[] values) { return new OneOrManyOverdosage (values.Select(v => (IOverdosage) new Overdosagestring (v))); }
            public static implicit operator OneOrManyOverdosage (List<string> values) { return new OneOrManyOverdosage (values.Select(v => (IOverdosage) new Overdosagestring (v))); }
        }
        public struct Overdosagestring : IOverdosage<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Overdosagestring (string value) { Value = value; }
            public static implicit operator Overdosagestring (string value) { return new Overdosagestring (value); }
        }

        public interface IPregnancyCategory : IValue {}
        public interface IPregnancyCategory<T> : IPregnancyCategory { new T Value { get; } }
        public class OneOrManyPregnancyCategory : OneOrMany<IPregnancyCategory>
        {
            public OneOrManyPregnancyCategory(IPregnancyCategory item) : base(item) { }
            public OneOrManyPregnancyCategory(IEnumerable<IPregnancyCategory> items) : base(items) { }
            public static implicit operator OneOrManyPregnancyCategory (DrugPregnancyCategory value) { return new OneOrManyPregnancyCategory (new PregnancyCategoryDrugPregnancyCategory (value)); }
            public static implicit operator OneOrManyPregnancyCategory (DrugPregnancyCategory[] values) { return new OneOrManyPregnancyCategory (values.Select(v => (IPregnancyCategory) new PregnancyCategoryDrugPregnancyCategory (v))); }
            public static implicit operator OneOrManyPregnancyCategory (List<DrugPregnancyCategory> values) { return new OneOrManyPregnancyCategory (values.Select(v => (IPregnancyCategory) new PregnancyCategoryDrugPregnancyCategory (v))); }
        }
        public struct PregnancyCategoryDrugPregnancyCategory : IPregnancyCategory<DrugPregnancyCategory>
        {
            object IValue.Value => this.Value;
            public DrugPregnancyCategory Value { get; }
            public PregnancyCategoryDrugPregnancyCategory (DrugPregnancyCategory value) { Value = value; }
            public static implicit operator PregnancyCategoryDrugPregnancyCategory (DrugPregnancyCategory value) { return new PregnancyCategoryDrugPregnancyCategory (value); }
        }

        public interface IPregnancyWarning : IValue {}
        public interface IPregnancyWarning<T> : IPregnancyWarning { new T Value { get; } }
        public class OneOrManyPregnancyWarning : OneOrMany<IPregnancyWarning>
        {
            public OneOrManyPregnancyWarning(IPregnancyWarning item) : base(item) { }
            public OneOrManyPregnancyWarning(IEnumerable<IPregnancyWarning> items) : base(items) { }
            public static implicit operator OneOrManyPregnancyWarning (string value) { return new OneOrManyPregnancyWarning (new PregnancyWarningstring (value)); }
            public static implicit operator OneOrManyPregnancyWarning (string[] values) { return new OneOrManyPregnancyWarning (values.Select(v => (IPregnancyWarning) new PregnancyWarningstring (v))); }
            public static implicit operator OneOrManyPregnancyWarning (List<string> values) { return new OneOrManyPregnancyWarning (values.Select(v => (IPregnancyWarning) new PregnancyWarningstring (v))); }
        }
        public struct PregnancyWarningstring : IPregnancyWarning<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PregnancyWarningstring (string value) { Value = value; }
            public static implicit operator PregnancyWarningstring (string value) { return new PregnancyWarningstring (value); }
        }

        public interface IPrescribingInfo : IValue {}
        public interface IPrescribingInfo<T> : IPrescribingInfo { new T Value { get; } }
        public class OneOrManyPrescribingInfo : OneOrMany<IPrescribingInfo>
        {
            public OneOrManyPrescribingInfo(IPrescribingInfo item) : base(item) { }
            public OneOrManyPrescribingInfo(IEnumerable<IPrescribingInfo> items) : base(items) { }
            public static implicit operator OneOrManyPrescribingInfo (Uri value) { return new OneOrManyPrescribingInfo (new PrescribingInfoUri (value)); }
            public static implicit operator OneOrManyPrescribingInfo (Uri[] values) { return new OneOrManyPrescribingInfo (values.Select(v => (IPrescribingInfo) new PrescribingInfoUri (v))); }
            public static implicit operator OneOrManyPrescribingInfo (List<Uri> values) { return new OneOrManyPrescribingInfo (values.Select(v => (IPrescribingInfo) new PrescribingInfoUri (v))); }
        }
        public struct PrescribingInfoUri : IPrescribingInfo<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public PrescribingInfoUri (Uri value) { Value = value; }
            public static implicit operator PrescribingInfoUri (Uri value) { return new PrescribingInfoUri (value); }
        }

        public interface IPrescriptionStatus : IValue {}
        public interface IPrescriptionStatus<T> : IPrescriptionStatus { new T Value { get; } }
        public class OneOrManyPrescriptionStatus : OneOrMany<IPrescriptionStatus>
        {
            public OneOrManyPrescriptionStatus(IPrescriptionStatus item) : base(item) { }
            public OneOrManyPrescriptionStatus(IEnumerable<IPrescriptionStatus> items) : base(items) { }
            public static implicit operator OneOrManyPrescriptionStatus (DrugPrescriptionStatus value) { return new OneOrManyPrescriptionStatus (new PrescriptionStatusDrugPrescriptionStatus (value)); }
            public static implicit operator OneOrManyPrescriptionStatus (DrugPrescriptionStatus[] values) { return new OneOrManyPrescriptionStatus (values.Select(v => (IPrescriptionStatus) new PrescriptionStatusDrugPrescriptionStatus (v))); }
            public static implicit operator OneOrManyPrescriptionStatus (List<DrugPrescriptionStatus> values) { return new OneOrManyPrescriptionStatus (values.Select(v => (IPrescriptionStatus) new PrescriptionStatusDrugPrescriptionStatus (v))); }
            public static implicit operator OneOrManyPrescriptionStatus (string value) { return new OneOrManyPrescriptionStatus (new PrescriptionStatusstring (value)); }
            public static implicit operator OneOrManyPrescriptionStatus (string[] values) { return new OneOrManyPrescriptionStatus (values.Select(v => (IPrescriptionStatus) new PrescriptionStatusstring (v))); }
            public static implicit operator OneOrManyPrescriptionStatus (List<string> values) { return new OneOrManyPrescriptionStatus (values.Select(v => (IPrescriptionStatus) new PrescriptionStatusstring (v))); }
        }
        public struct PrescriptionStatusDrugPrescriptionStatus : IPrescriptionStatus<DrugPrescriptionStatus>
        {
            object IValue.Value => this.Value;
            public DrugPrescriptionStatus Value { get; }
            public PrescriptionStatusDrugPrescriptionStatus (DrugPrescriptionStatus value) { Value = value; }
            public static implicit operator PrescriptionStatusDrugPrescriptionStatus (DrugPrescriptionStatus value) { return new PrescriptionStatusDrugPrescriptionStatus (value); }
        }
        public struct PrescriptionStatusstring : IPrescriptionStatus<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PrescriptionStatusstring (string value) { Value = value; }
            public static implicit operator PrescriptionStatusstring (string value) { return new PrescriptionStatusstring (value); }
        }

        public interface IProprietaryName : IValue {}
        public interface IProprietaryName<T> : IProprietaryName { new T Value { get; } }
        public class OneOrManyProprietaryName : OneOrMany<IProprietaryName>
        {
            public OneOrManyProprietaryName(IProprietaryName item) : base(item) { }
            public OneOrManyProprietaryName(IEnumerable<IProprietaryName> items) : base(items) { }
            public static implicit operator OneOrManyProprietaryName (string value) { return new OneOrManyProprietaryName (new ProprietaryNamestring (value)); }
            public static implicit operator OneOrManyProprietaryName (string[] values) { return new OneOrManyProprietaryName (values.Select(v => (IProprietaryName) new ProprietaryNamestring (v))); }
            public static implicit operator OneOrManyProprietaryName (List<string> values) { return new OneOrManyProprietaryName (values.Select(v => (IProprietaryName) new ProprietaryNamestring (v))); }
        }
        public struct ProprietaryNamestring : IProprietaryName<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ProprietaryNamestring (string value) { Value = value; }
            public static implicit operator ProprietaryNamestring (string value) { return new ProprietaryNamestring (value); }
        }

        public interface IRelatedDrug : IValue {}
        public interface IRelatedDrug<T> : IRelatedDrug { new T Value { get; } }
        public class OneOrManyRelatedDrug : OneOrMany<IRelatedDrug>
        {
            public OneOrManyRelatedDrug(IRelatedDrug item) : base(item) { }
            public OneOrManyRelatedDrug(IEnumerable<IRelatedDrug> items) : base(items) { }
            public static implicit operator OneOrManyRelatedDrug (Drug value) { return new OneOrManyRelatedDrug (new RelatedDrugDrug (value)); }
            public static implicit operator OneOrManyRelatedDrug (Drug[] values) { return new OneOrManyRelatedDrug (values.Select(v => (IRelatedDrug) new RelatedDrugDrug (v))); }
            public static implicit operator OneOrManyRelatedDrug (List<Drug> values) { return new OneOrManyRelatedDrug (values.Select(v => (IRelatedDrug) new RelatedDrugDrug (v))); }
        }
        public struct RelatedDrugDrug : IRelatedDrug<Drug>
        {
            object IValue.Value => this.Value;
            public Drug Value { get; }
            public RelatedDrugDrug (Drug value) { Value = value; }
            public static implicit operator RelatedDrugDrug (Drug value) { return new RelatedDrugDrug (value); }
        }

        public interface IRxcui : IValue {}
        public interface IRxcui<T> : IRxcui { new T Value { get; } }
        public class OneOrManyRxcui : OneOrMany<IRxcui>
        {
            public OneOrManyRxcui(IRxcui item) : base(item) { }
            public OneOrManyRxcui(IEnumerable<IRxcui> items) : base(items) { }
            public static implicit operator OneOrManyRxcui (string value) { return new OneOrManyRxcui (new Rxcuistring (value)); }
            public static implicit operator OneOrManyRxcui (string[] values) { return new OneOrManyRxcui (values.Select(v => (IRxcui) new Rxcuistring (v))); }
            public static implicit operator OneOrManyRxcui (List<string> values) { return new OneOrManyRxcui (values.Select(v => (IRxcui) new Rxcuistring (v))); }
        }
        public struct Rxcuistring : IRxcui<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Rxcuistring (string value) { Value = value; }
            public static implicit operator Rxcuistring (string value) { return new Rxcuistring (value); }
        }

        public interface IWarning : IValue {}
        public interface IWarning<T> : IWarning { new T Value { get; } }
        public class OneOrManyWarning : OneOrMany<IWarning>
        {
            public OneOrManyWarning(IWarning item) : base(item) { }
            public OneOrManyWarning(IEnumerable<IWarning> items) : base(items) { }
            public static implicit operator OneOrManyWarning (string value) { return new OneOrManyWarning (new Warningstring (value)); }
            public static implicit operator OneOrManyWarning (string[] values) { return new OneOrManyWarning (values.Select(v => (IWarning) new Warningstring (v))); }
            public static implicit operator OneOrManyWarning (List<string> values) { return new OneOrManyWarning (values.Select(v => (IWarning) new Warningstring (v))); }
            public static implicit operator OneOrManyWarning (Uri value) { return new OneOrManyWarning (new WarningUri (value)); }
            public static implicit operator OneOrManyWarning (Uri[] values) { return new OneOrManyWarning (values.Select(v => (IWarning) new WarningUri (v))); }
            public static implicit operator OneOrManyWarning (List<Uri> values) { return new OneOrManyWarning (values.Select(v => (IWarning) new WarningUri (v))); }
        }
        public struct Warningstring : IWarning<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Warningstring (string value) { Value = value; }
            public static implicit operator Warningstring (string value) { return new Warningstring (value); }
        }
        public struct WarningUri : IWarning<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public WarningUri (Uri value) { Value = value; }
            public static implicit operator WarningUri (Uri value) { return new WarningUri (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Drug";

        /// <summary>
        /// An active ingredient, typically chemical compounds and/or biologic substances.
        /// </summary>
        [DataMember(Name = "activeIngredient", Order = 306)]
        public override OneOrManyActiveIngredient ActiveIngredient { get; set; }

        /// <summary>
        /// A route by which this drug may be administered, e.g. 'oral'.
        /// </summary>
        [DataMember(Name = "administrationRoute", Order = 307)]
        public OneOrManyAdministrationRoute AdministrationRoute { get; set; }

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to consumption of alcohol while taking this drug.
        /// </summary>
        [DataMember(Name = "alcoholWarning", Order = 308)]
        public OneOrManyAlcoholWarning AlcoholWarning { get; set; }

        /// <summary>
        /// An available dosage strength for the drug.
        /// </summary>
        [DataMember(Name = "availableStrength", Order = 309)]
        public OneOrManyAvailableStrength AvailableStrength { get; set; }

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to this drug's use by breastfeeding mothers.
        /// </summary>
        [DataMember(Name = "breastfeedingWarning", Order = 310)]
        public OneOrManyBreastfeedingWarning BreastfeedingWarning { get; set; }

        /// <summary>
        /// Description of the absorption and elimination of drugs, including their concentration (pharmacokinetics, pK) and biological effects (pharmacodynamics, pD).
        /// </summary>
        [DataMember(Name = "clinicalPharmacology", Order = 311)]
        public OneOrManyClinicalPharmacology ClinicalPharmacology { get; set; }

        /// <summary>
        /// Cost per unit of the drug, as reported by the source being tagged.
        /// </summary>
        [DataMember(Name = "cost", Order = 312)]
        public OneOrManyCost Cost { get; set; }

        /// <summary>
        /// A dosage form in which this drug/supplement is available, e.g. 'tablet', 'suspension', 'injection'.
        /// </summary>
        [DataMember(Name = "dosageForm", Order = 313)]
        public OneOrManyDosageForm DosageForm { get; set; }

        /// <summary>
        /// A dosing schedule for the drug for a given population, either observed, recommended, or maximum dose based on the type used.
        /// </summary>
        [DataMember(Name = "doseSchedule", Order = 314)]
        public OneOrManyDoseSchedule DoseSchedule { get; set; }

        /// <summary>
        /// The class of drug this belongs to (e.g., statins).
        /// </summary>
        [DataMember(Name = "drugClass", Order = 315)]
        public OneOrManyDrugClass DrugClass { get; set; }

        /// <summary>
        /// The unit in which the drug is measured, e.g. '5 mg tablet'.
        /// </summary>
        [DataMember(Name = "drugUnit", Order = 316)]
        public OneOrManyDrugUnit DrugUnit { get; set; }

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to consumption of specific foods while taking this drug.
        /// </summary>
        [DataMember(Name = "foodWarning", Order = 317)]
        public OneOrManyFoodWarning FoodWarning { get; set; }

        /// <summary>
        /// Another drug that is known to interact with this drug in a way that impacts the effect of this drug or causes a risk to the patient. Note: disease interactions are typically captured as contraindications.
        /// </summary>
        [DataMember(Name = "interactingDrug", Order = 318)]
        public OneOrManyInteractingDrug InteractingDrug { get; set; }

        /// <summary>
        /// True if the drug is available in a generic form (regardless of name).
        /// </summary>
        [DataMember(Name = "isAvailableGenerically", Order = 319)]
        public OneOrManyIsAvailableGenerically IsAvailableGenerically { get; set; }

        /// <summary>
        /// True if this item's name is a proprietary/brand name (vs. generic name).
        /// </summary>
        [DataMember(Name = "isProprietary", Order = 320)]
        public OneOrManyIsProprietary IsProprietary { get; set; }

        /// <summary>
        /// Link to the drug's label details.
        /// </summary>
        [DataMember(Name = "labelDetails", Order = 321)]
        public OneOrManyLabelDetails LabelDetails { get; set; }

        /// <summary>
        /// The drug or supplement's legal status, including any controlled substance schedules that apply.
        /// </summary>
        [DataMember(Name = "legalStatus", Order = 322)]
        public override OneOrManyLegalStatus LegalStatus { get; set; }

        /// <summary>
        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        /// </summary>
        [DataMember(Name = "maximumIntake", Order = 323)]
        public override OneOrManyMaximumIntake MaximumIntake { get; set; }

        /// <summary>
        /// The specific biochemical interaction through which this drug or supplement produces its pharmacological effect.
        /// </summary>
        [DataMember(Name = "mechanismOfAction", Order = 324)]
        public OneOrManyMechanismOfAction MechanismOfAction { get; set; }

        /// <summary>
        /// The generic name of this drug or supplement.
        /// </summary>
        [DataMember(Name = "nonProprietaryName", Order = 325)]
        public OneOrManyNonProprietaryName NonProprietaryName { get; set; }

        /// <summary>
        /// Any information related to overdose on a drug, including signs or symptoms, treatments, contact information for emergency response.
        /// </summary>
        [DataMember(Name = "overdosage", Order = 326)]
        public OneOrManyOverdosage Overdosage { get; set; }

        /// <summary>
        /// Pregnancy category of this drug.
        /// </summary>
        [DataMember(Name = "pregnancyCategory", Order = 327)]
        public OneOrManyPregnancyCategory PregnancyCategory { get; set; }

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to this drug's use during pregnancy.
        /// </summary>
        [DataMember(Name = "pregnancyWarning", Order = 328)]
        public OneOrManyPregnancyWarning PregnancyWarning { get; set; }

        /// <summary>
        /// Link to prescribing information for the drug.
        /// </summary>
        [DataMember(Name = "prescribingInfo", Order = 329)]
        public OneOrManyPrescribingInfo PrescribingInfo { get; set; }

        /// <summary>
        /// Indicates the status of drug prescription eg. local catalogs classifications or whether the drug is available by prescription or over-the-counter, etc.
        /// </summary>
        [DataMember(Name = "prescriptionStatus", Order = 330)]
        public OneOrManyPrescriptionStatus PrescriptionStatus { get; set; }

        /// <summary>
        /// Proprietary name given to the diet plan, typically by its originator or creator.
        /// </summary>
        [DataMember(Name = "proprietaryName", Order = 331)]
        public OneOrManyProprietaryName ProprietaryName { get; set; }

        /// <summary>
        /// Any other drug related to this one, for example commonly-prescribed alternatives.
        /// </summary>
        [DataMember(Name = "relatedDrug", Order = 332)]
        public OneOrManyRelatedDrug RelatedDrug { get; set; }

        /// <summary>
        /// The RxCUI drug identifier from RXNORM.
        /// </summary>
        [DataMember(Name = "rxcui", Order = 333)]
        public OneOrManyRxcui Rxcui { get; set; }

        /// <summary>
        /// Any FDA or other warnings about the drug (text or URL).
        /// </summary>
        [DataMember(Name = "warning", Order = 334)]
        public OneOrManyWarning Warning { get; set; }
    }
}
