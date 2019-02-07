namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// </summary>
    [DataContract]
    public partial class MedicalCondition : MedicalEntity
    {
        public interface IAssociatedAnatomy : IValue {}
        public interface IAssociatedAnatomy<T> : IAssociatedAnatomy { new T Value { get; } }
        public class OneOrManyAssociatedAnatomy : OneOrMany<IAssociatedAnatomy>
        {
            public OneOrManyAssociatedAnatomy(IAssociatedAnatomy item) : base(item) { }
            public OneOrManyAssociatedAnatomy(IEnumerable<IAssociatedAnatomy> items) : base(items) { }
            public static implicit operator OneOrManyAssociatedAnatomy (AnatomicalStructure value) { return new OneOrManyAssociatedAnatomy (new AssociatedAnatomyAnatomicalStructure (value)); }
            public static implicit operator OneOrManyAssociatedAnatomy (AnatomicalStructure[] values) { return new OneOrManyAssociatedAnatomy (values.Select(v => (IAssociatedAnatomy) new AssociatedAnatomyAnatomicalStructure (v))); }
            public static implicit operator OneOrManyAssociatedAnatomy (List<AnatomicalStructure> values) { return new OneOrManyAssociatedAnatomy (values.Select(v => (IAssociatedAnatomy) new AssociatedAnatomyAnatomicalStructure (v))); }
            public static implicit operator OneOrManyAssociatedAnatomy (AnatomicalSystem value) { return new OneOrManyAssociatedAnatomy (new AssociatedAnatomyAnatomicalSystem (value)); }
            public static implicit operator OneOrManyAssociatedAnatomy (AnatomicalSystem[] values) { return new OneOrManyAssociatedAnatomy (values.Select(v => (IAssociatedAnatomy) new AssociatedAnatomyAnatomicalSystem (v))); }
            public static implicit operator OneOrManyAssociatedAnatomy (List<AnatomicalSystem> values) { return new OneOrManyAssociatedAnatomy (values.Select(v => (IAssociatedAnatomy) new AssociatedAnatomyAnatomicalSystem (v))); }
            public static implicit operator OneOrManyAssociatedAnatomy (SuperficialAnatomy value) { return new OneOrManyAssociatedAnatomy (new AssociatedAnatomySuperficialAnatomy (value)); }
            public static implicit operator OneOrManyAssociatedAnatomy (SuperficialAnatomy[] values) { return new OneOrManyAssociatedAnatomy (values.Select(v => (IAssociatedAnatomy) new AssociatedAnatomySuperficialAnatomy (v))); }
            public static implicit operator OneOrManyAssociatedAnatomy (List<SuperficialAnatomy> values) { return new OneOrManyAssociatedAnatomy (values.Select(v => (IAssociatedAnatomy) new AssociatedAnatomySuperficialAnatomy (v))); }
        }
        public struct AssociatedAnatomyAnatomicalStructure : IAssociatedAnatomy<AnatomicalStructure>
        {
            object IValue.Value => this.Value;
            public AnatomicalStructure Value { get; }
            public AssociatedAnatomyAnatomicalStructure (AnatomicalStructure value) { Value = value; }
            public static implicit operator AssociatedAnatomyAnatomicalStructure (AnatomicalStructure value) { return new AssociatedAnatomyAnatomicalStructure (value); }
        }
        public struct AssociatedAnatomyAnatomicalSystem : IAssociatedAnatomy<AnatomicalSystem>
        {
            object IValue.Value => this.Value;
            public AnatomicalSystem Value { get; }
            public AssociatedAnatomyAnatomicalSystem (AnatomicalSystem value) { Value = value; }
            public static implicit operator AssociatedAnatomyAnatomicalSystem (AnatomicalSystem value) { return new AssociatedAnatomyAnatomicalSystem (value); }
        }
        public struct AssociatedAnatomySuperficialAnatomy : IAssociatedAnatomy<SuperficialAnatomy>
        {
            object IValue.Value => this.Value;
            public SuperficialAnatomy Value { get; }
            public AssociatedAnatomySuperficialAnatomy (SuperficialAnatomy value) { Value = value; }
            public static implicit operator AssociatedAnatomySuperficialAnatomy (SuperficialAnatomy value) { return new AssociatedAnatomySuperficialAnatomy (value); }
        }

        public interface ICause : IValue {}
        public interface ICause<T> : ICause { new T Value { get; } }
        public class OneOrManyCause : OneOrMany<ICause>
        {
            public OneOrManyCause(ICause item) : base(item) { }
            public OneOrManyCause(IEnumerable<ICause> items) : base(items) { }
            public static implicit operator OneOrManyCause (MedicalCause value) { return new OneOrManyCause (new CauseMedicalCause (value)); }
            public static implicit operator OneOrManyCause (MedicalCause[] values) { return new OneOrManyCause (values.Select(v => (ICause) new CauseMedicalCause (v))); }
            public static implicit operator OneOrManyCause (List<MedicalCause> values) { return new OneOrManyCause (values.Select(v => (ICause) new CauseMedicalCause (v))); }
        }
        public struct CauseMedicalCause : ICause<MedicalCause>
        {
            object IValue.Value => this.Value;
            public MedicalCause Value { get; }
            public CauseMedicalCause (MedicalCause value) { Value = value; }
            public static implicit operator CauseMedicalCause (MedicalCause value) { return new CauseMedicalCause (value); }
        }

        public interface IDifferentialDiagnosis : IValue {}
        public interface IDifferentialDiagnosis<T> : IDifferentialDiagnosis { new T Value { get; } }
        public class OneOrManyDifferentialDiagnosis : OneOrMany<IDifferentialDiagnosis>
        {
            public OneOrManyDifferentialDiagnosis(IDifferentialDiagnosis item) : base(item) { }
            public OneOrManyDifferentialDiagnosis(IEnumerable<IDifferentialDiagnosis> items) : base(items) { }
            public static implicit operator OneOrManyDifferentialDiagnosis (DDxElement value) { return new OneOrManyDifferentialDiagnosis (new DifferentialDiagnosisDDxElement (value)); }
            public static implicit operator OneOrManyDifferentialDiagnosis (DDxElement[] values) { return new OneOrManyDifferentialDiagnosis (values.Select(v => (IDifferentialDiagnosis) new DifferentialDiagnosisDDxElement (v))); }
            public static implicit operator OneOrManyDifferentialDiagnosis (List<DDxElement> values) { return new OneOrManyDifferentialDiagnosis (values.Select(v => (IDifferentialDiagnosis) new DifferentialDiagnosisDDxElement (v))); }
        }
        public struct DifferentialDiagnosisDDxElement : IDifferentialDiagnosis<DDxElement>
        {
            object IValue.Value => this.Value;
            public DDxElement Value { get; }
            public DifferentialDiagnosisDDxElement (DDxElement value) { Value = value; }
            public static implicit operator DifferentialDiagnosisDDxElement (DDxElement value) { return new DifferentialDiagnosisDDxElement (value); }
        }

        public interface IDrug : IValue {}
        public interface IDrug<T> : IDrug { new T Value { get; } }
        public class OneOrManyDrug : OneOrMany<IDrug>
        {
            public OneOrManyDrug(IDrug item) : base(item) { }
            public OneOrManyDrug(IEnumerable<IDrug> items) : base(items) { }
            public static implicit operator OneOrManyDrug (Drug value) { return new OneOrManyDrug (new DrugDrug (value)); }
            public static implicit operator OneOrManyDrug (Drug[] values) { return new OneOrManyDrug (values.Select(v => (IDrug) new DrugDrug (v))); }
            public static implicit operator OneOrManyDrug (List<Drug> values) { return new OneOrManyDrug (values.Select(v => (IDrug) new DrugDrug (v))); }
        }
        public struct DrugDrug : IDrug<Drug>
        {
            object IValue.Value => this.Value;
            public Drug Value { get; }
            public DrugDrug (Drug value) { Value = value; }
            public static implicit operator DrugDrug (Drug value) { return new DrugDrug (value); }
        }

        public interface IEpidemiology : IValue {}
        public interface IEpidemiology<T> : IEpidemiology { new T Value { get; } }
        public class OneOrManyEpidemiology : OneOrMany<IEpidemiology>
        {
            public OneOrManyEpidemiology(IEpidemiology item) : base(item) { }
            public OneOrManyEpidemiology(IEnumerable<IEpidemiology> items) : base(items) { }
            public static implicit operator OneOrManyEpidemiology (string value) { return new OneOrManyEpidemiology (new Epidemiologystring (value)); }
            public static implicit operator OneOrManyEpidemiology (string[] values) { return new OneOrManyEpidemiology (values.Select(v => (IEpidemiology) new Epidemiologystring (v))); }
            public static implicit operator OneOrManyEpidemiology (List<string> values) { return new OneOrManyEpidemiology (values.Select(v => (IEpidemiology) new Epidemiologystring (v))); }
        }
        public struct Epidemiologystring : IEpidemiology<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Epidemiologystring (string value) { Value = value; }
            public static implicit operator Epidemiologystring (string value) { return new Epidemiologystring (value); }
        }

        public interface IExpectedPrognosis : IValue {}
        public interface IExpectedPrognosis<T> : IExpectedPrognosis { new T Value { get; } }
        public class OneOrManyExpectedPrognosis : OneOrMany<IExpectedPrognosis>
        {
            public OneOrManyExpectedPrognosis(IExpectedPrognosis item) : base(item) { }
            public OneOrManyExpectedPrognosis(IEnumerable<IExpectedPrognosis> items) : base(items) { }
            public static implicit operator OneOrManyExpectedPrognosis (string value) { return new OneOrManyExpectedPrognosis (new ExpectedPrognosisstring (value)); }
            public static implicit operator OneOrManyExpectedPrognosis (string[] values) { return new OneOrManyExpectedPrognosis (values.Select(v => (IExpectedPrognosis) new ExpectedPrognosisstring (v))); }
            public static implicit operator OneOrManyExpectedPrognosis (List<string> values) { return new OneOrManyExpectedPrognosis (values.Select(v => (IExpectedPrognosis) new ExpectedPrognosisstring (v))); }
        }
        public struct ExpectedPrognosisstring : IExpectedPrognosis<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ExpectedPrognosisstring (string value) { Value = value; }
            public static implicit operator ExpectedPrognosisstring (string value) { return new ExpectedPrognosisstring (value); }
        }

        public interface INaturalProgression : IValue {}
        public interface INaturalProgression<T> : INaturalProgression { new T Value { get; } }
        public class OneOrManyNaturalProgression : OneOrMany<INaturalProgression>
        {
            public OneOrManyNaturalProgression(INaturalProgression item) : base(item) { }
            public OneOrManyNaturalProgression(IEnumerable<INaturalProgression> items) : base(items) { }
            public static implicit operator OneOrManyNaturalProgression (string value) { return new OneOrManyNaturalProgression (new NaturalProgressionstring (value)); }
            public static implicit operator OneOrManyNaturalProgression (string[] values) { return new OneOrManyNaturalProgression (values.Select(v => (INaturalProgression) new NaturalProgressionstring (v))); }
            public static implicit operator OneOrManyNaturalProgression (List<string> values) { return new OneOrManyNaturalProgression (values.Select(v => (INaturalProgression) new NaturalProgressionstring (v))); }
        }
        public struct NaturalProgressionstring : INaturalProgression<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public NaturalProgressionstring (string value) { Value = value; }
            public static implicit operator NaturalProgressionstring (string value) { return new NaturalProgressionstring (value); }
        }

        public interface IPathophysiology : IValue {}
        public interface IPathophysiology<T> : IPathophysiology { new T Value { get; } }
        public class OneOrManyPathophysiology : OneOrMany<IPathophysiology>
        {
            public OneOrManyPathophysiology(IPathophysiology item) : base(item) { }
            public OneOrManyPathophysiology(IEnumerable<IPathophysiology> items) : base(items) { }
            public static implicit operator OneOrManyPathophysiology (string value) { return new OneOrManyPathophysiology (new Pathophysiologystring (value)); }
            public static implicit operator OneOrManyPathophysiology (string[] values) { return new OneOrManyPathophysiology (values.Select(v => (IPathophysiology) new Pathophysiologystring (v))); }
            public static implicit operator OneOrManyPathophysiology (List<string> values) { return new OneOrManyPathophysiology (values.Select(v => (IPathophysiology) new Pathophysiologystring (v))); }
        }
        public struct Pathophysiologystring : IPathophysiology<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Pathophysiologystring (string value) { Value = value; }
            public static implicit operator Pathophysiologystring (string value) { return new Pathophysiologystring (value); }
        }

        public interface IPossibleComplication : IValue {}
        public interface IPossibleComplication<T> : IPossibleComplication { new T Value { get; } }
        public class OneOrManyPossibleComplication : OneOrMany<IPossibleComplication>
        {
            public OneOrManyPossibleComplication(IPossibleComplication item) : base(item) { }
            public OneOrManyPossibleComplication(IEnumerable<IPossibleComplication> items) : base(items) { }
            public static implicit operator OneOrManyPossibleComplication (string value) { return new OneOrManyPossibleComplication (new PossibleComplicationstring (value)); }
            public static implicit operator OneOrManyPossibleComplication (string[] values) { return new OneOrManyPossibleComplication (values.Select(v => (IPossibleComplication) new PossibleComplicationstring (v))); }
            public static implicit operator OneOrManyPossibleComplication (List<string> values) { return new OneOrManyPossibleComplication (values.Select(v => (IPossibleComplication) new PossibleComplicationstring (v))); }
        }
        public struct PossibleComplicationstring : IPossibleComplication<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PossibleComplicationstring (string value) { Value = value; }
            public static implicit operator PossibleComplicationstring (string value) { return new PossibleComplicationstring (value); }
        }

        public interface IPossibleTreatment : IValue {}
        public interface IPossibleTreatment<T> : IPossibleTreatment { new T Value { get; } }
        public class OneOrManyPossibleTreatment : OneOrMany<IPossibleTreatment>
        {
            public OneOrManyPossibleTreatment(IPossibleTreatment item) : base(item) { }
            public OneOrManyPossibleTreatment(IEnumerable<IPossibleTreatment> items) : base(items) { }
            public static implicit operator OneOrManyPossibleTreatment (MedicalTherapy value) { return new OneOrManyPossibleTreatment (new PossibleTreatmentMedicalTherapy (value)); }
            public static implicit operator OneOrManyPossibleTreatment (MedicalTherapy[] values) { return new OneOrManyPossibleTreatment (values.Select(v => (IPossibleTreatment) new PossibleTreatmentMedicalTherapy (v))); }
            public static implicit operator OneOrManyPossibleTreatment (List<MedicalTherapy> values) { return new OneOrManyPossibleTreatment (values.Select(v => (IPossibleTreatment) new PossibleTreatmentMedicalTherapy (v))); }
        }
        public struct PossibleTreatmentMedicalTherapy : IPossibleTreatment<MedicalTherapy>
        {
            object IValue.Value => this.Value;
            public MedicalTherapy Value { get; }
            public PossibleTreatmentMedicalTherapy (MedicalTherapy value) { Value = value; }
            public static implicit operator PossibleTreatmentMedicalTherapy (MedicalTherapy value) { return new PossibleTreatmentMedicalTherapy (value); }
        }

        public interface IPrimaryPrevention : IValue {}
        public interface IPrimaryPrevention<T> : IPrimaryPrevention { new T Value { get; } }
        public class OneOrManyPrimaryPrevention : OneOrMany<IPrimaryPrevention>
        {
            public OneOrManyPrimaryPrevention(IPrimaryPrevention item) : base(item) { }
            public OneOrManyPrimaryPrevention(IEnumerable<IPrimaryPrevention> items) : base(items) { }
            public static implicit operator OneOrManyPrimaryPrevention (MedicalTherapy value) { return new OneOrManyPrimaryPrevention (new PrimaryPreventionMedicalTherapy (value)); }
            public static implicit operator OneOrManyPrimaryPrevention (MedicalTherapy[] values) { return new OneOrManyPrimaryPrevention (values.Select(v => (IPrimaryPrevention) new PrimaryPreventionMedicalTherapy (v))); }
            public static implicit operator OneOrManyPrimaryPrevention (List<MedicalTherapy> values) { return new OneOrManyPrimaryPrevention (values.Select(v => (IPrimaryPrevention) new PrimaryPreventionMedicalTherapy (v))); }
        }
        public struct PrimaryPreventionMedicalTherapy : IPrimaryPrevention<MedicalTherapy>
        {
            object IValue.Value => this.Value;
            public MedicalTherapy Value { get; }
            public PrimaryPreventionMedicalTherapy (MedicalTherapy value) { Value = value; }
            public static implicit operator PrimaryPreventionMedicalTherapy (MedicalTherapy value) { return new PrimaryPreventionMedicalTherapy (value); }
        }

        public interface IRiskFactor : IValue {}
        public interface IRiskFactor<T> : IRiskFactor { new T Value { get; } }
        public class OneOrManyRiskFactor : OneOrMany<IRiskFactor>
        {
            public OneOrManyRiskFactor(IRiskFactor item) : base(item) { }
            public OneOrManyRiskFactor(IEnumerable<IRiskFactor> items) : base(items) { }
            public static implicit operator OneOrManyRiskFactor (MedicalRiskFactor value) { return new OneOrManyRiskFactor (new RiskFactorMedicalRiskFactor (value)); }
            public static implicit operator OneOrManyRiskFactor (MedicalRiskFactor[] values) { return new OneOrManyRiskFactor (values.Select(v => (IRiskFactor) new RiskFactorMedicalRiskFactor (v))); }
            public static implicit operator OneOrManyRiskFactor (List<MedicalRiskFactor> values) { return new OneOrManyRiskFactor (values.Select(v => (IRiskFactor) new RiskFactorMedicalRiskFactor (v))); }
        }
        public struct RiskFactorMedicalRiskFactor : IRiskFactor<MedicalRiskFactor>
        {
            object IValue.Value => this.Value;
            public MedicalRiskFactor Value { get; }
            public RiskFactorMedicalRiskFactor (MedicalRiskFactor value) { Value = value; }
            public static implicit operator RiskFactorMedicalRiskFactor (MedicalRiskFactor value) { return new RiskFactorMedicalRiskFactor (value); }
        }

        public interface ISecondaryPrevention : IValue {}
        public interface ISecondaryPrevention<T> : ISecondaryPrevention { new T Value { get; } }
        public class OneOrManySecondaryPrevention : OneOrMany<ISecondaryPrevention>
        {
            public OneOrManySecondaryPrevention(ISecondaryPrevention item) : base(item) { }
            public OneOrManySecondaryPrevention(IEnumerable<ISecondaryPrevention> items) : base(items) { }
            public static implicit operator OneOrManySecondaryPrevention (MedicalTherapy value) { return new OneOrManySecondaryPrevention (new SecondaryPreventionMedicalTherapy (value)); }
            public static implicit operator OneOrManySecondaryPrevention (MedicalTherapy[] values) { return new OneOrManySecondaryPrevention (values.Select(v => (ISecondaryPrevention) new SecondaryPreventionMedicalTherapy (v))); }
            public static implicit operator OneOrManySecondaryPrevention (List<MedicalTherapy> values) { return new OneOrManySecondaryPrevention (values.Select(v => (ISecondaryPrevention) new SecondaryPreventionMedicalTherapy (v))); }
        }
        public struct SecondaryPreventionMedicalTherapy : ISecondaryPrevention<MedicalTherapy>
        {
            object IValue.Value => this.Value;
            public MedicalTherapy Value { get; }
            public SecondaryPreventionMedicalTherapy (MedicalTherapy value) { Value = value; }
            public static implicit operator SecondaryPreventionMedicalTherapy (MedicalTherapy value) { return new SecondaryPreventionMedicalTherapy (value); }
        }

        public interface ISignOrSymptom : IValue {}
        public interface ISignOrSymptom<T> : ISignOrSymptom { new T Value { get; } }
        public class OneOrManySignOrSymptom : OneOrMany<ISignOrSymptom>
        {
            public OneOrManySignOrSymptom(ISignOrSymptom item) : base(item) { }
            public OneOrManySignOrSymptom(IEnumerable<ISignOrSymptom> items) : base(items) { }
            public static implicit operator OneOrManySignOrSymptom (MedicalSignOrSymptom value) { return new OneOrManySignOrSymptom (new SignOrSymptomMedicalSignOrSymptom (value)); }
            public static implicit operator OneOrManySignOrSymptom (MedicalSignOrSymptom[] values) { return new OneOrManySignOrSymptom (values.Select(v => (ISignOrSymptom) new SignOrSymptomMedicalSignOrSymptom (v))); }
            public static implicit operator OneOrManySignOrSymptom (List<MedicalSignOrSymptom> values) { return new OneOrManySignOrSymptom (values.Select(v => (ISignOrSymptom) new SignOrSymptomMedicalSignOrSymptom (v))); }
        }
        public struct SignOrSymptomMedicalSignOrSymptom : ISignOrSymptom<MedicalSignOrSymptom>
        {
            object IValue.Value => this.Value;
            public MedicalSignOrSymptom Value { get; }
            public SignOrSymptomMedicalSignOrSymptom (MedicalSignOrSymptom value) { Value = value; }
            public static implicit operator SignOrSymptomMedicalSignOrSymptom (MedicalSignOrSymptom value) { return new SignOrSymptomMedicalSignOrSymptom (value); }
        }

        public interface IStage : IValue {}
        public interface IStage<T> : IStage { new T Value { get; } }
        public class OneOrManyStage : OneOrMany<IStage>
        {
            public OneOrManyStage(IStage item) : base(item) { }
            public OneOrManyStage(IEnumerable<IStage> items) : base(items) { }
            public static implicit operator OneOrManyStage (MedicalConditionStage value) { return new OneOrManyStage (new StageMedicalConditionStage (value)); }
            public static implicit operator OneOrManyStage (MedicalConditionStage[] values) { return new OneOrManyStage (values.Select(v => (IStage) new StageMedicalConditionStage (v))); }
            public static implicit operator OneOrManyStage (List<MedicalConditionStage> values) { return new OneOrManyStage (values.Select(v => (IStage) new StageMedicalConditionStage (v))); }
        }
        public struct StageMedicalConditionStage : IStage<MedicalConditionStage>
        {
            object IValue.Value => this.Value;
            public MedicalConditionStage Value { get; }
            public StageMedicalConditionStage (MedicalConditionStage value) { Value = value; }
            public static implicit operator StageMedicalConditionStage (MedicalConditionStage value) { return new StageMedicalConditionStage (value); }
        }

        public interface IStatus : IValue {}
        public interface IStatus<T> : IStatus { new T Value { get; } }
        public class OneOrManyStatus : OneOrMany<IStatus>
        {
            public OneOrManyStatus(IStatus item) : base(item) { }
            public OneOrManyStatus(IEnumerable<IStatus> items) : base(items) { }
            public static implicit operator OneOrManyStatus (EventStatusType value) { return new OneOrManyStatus (new StatusEventStatusType (value)); }
            public static implicit operator OneOrManyStatus (EventStatusType[] values) { return new OneOrManyStatus (values.Select(v => (IStatus) new StatusEventStatusType (v))); }
            public static implicit operator OneOrManyStatus (List<EventStatusType> values) { return new OneOrManyStatus (values.Select(v => (IStatus) new StatusEventStatusType (v))); }
            public static implicit operator OneOrManyStatus (MedicalStudyStatus value) { return new OneOrManyStatus (new StatusMedicalStudyStatus (value)); }
            public static implicit operator OneOrManyStatus (MedicalStudyStatus[] values) { return new OneOrManyStatus (values.Select(v => (IStatus) new StatusMedicalStudyStatus (v))); }
            public static implicit operator OneOrManyStatus (List<MedicalStudyStatus> values) { return new OneOrManyStatus (values.Select(v => (IStatus) new StatusMedicalStudyStatus (v))); }
            public static implicit operator OneOrManyStatus (string value) { return new OneOrManyStatus (new Statusstring (value)); }
            public static implicit operator OneOrManyStatus (string[] values) { return new OneOrManyStatus (values.Select(v => (IStatus) new Statusstring (v))); }
            public static implicit operator OneOrManyStatus (List<string> values) { return new OneOrManyStatus (values.Select(v => (IStatus) new Statusstring (v))); }
        }
        public struct StatusEventStatusType : IStatus<EventStatusType>
        {
            object IValue.Value => this.Value;
            public EventStatusType Value { get; }
            public StatusEventStatusType (EventStatusType value) { Value = value; }
            public static implicit operator StatusEventStatusType (EventStatusType value) { return new StatusEventStatusType (value); }
        }
        public struct StatusMedicalStudyStatus : IStatus<MedicalStudyStatus>
        {
            object IValue.Value => this.Value;
            public MedicalStudyStatus Value { get; }
            public StatusMedicalStudyStatus (MedicalStudyStatus value) { Value = value; }
            public static implicit operator StatusMedicalStudyStatus (MedicalStudyStatus value) { return new StatusMedicalStudyStatus (value); }
        }
        public struct Statusstring : IStatus<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Statusstring (string value) { Value = value; }
            public static implicit operator Statusstring (string value) { return new Statusstring (value); }
        }

        public interface ISubtype : IValue {}
        public interface ISubtype<T> : ISubtype { new T Value { get; } }
        public class OneOrManySubtype : OneOrMany<ISubtype>
        {
            public OneOrManySubtype(ISubtype item) : base(item) { }
            public OneOrManySubtype(IEnumerable<ISubtype> items) : base(items) { }
            public static implicit operator OneOrManySubtype (string value) { return new OneOrManySubtype (new Subtypestring (value)); }
            public static implicit operator OneOrManySubtype (string[] values) { return new OneOrManySubtype (values.Select(v => (ISubtype) new Subtypestring (v))); }
            public static implicit operator OneOrManySubtype (List<string> values) { return new OneOrManySubtype (values.Select(v => (ISubtype) new Subtypestring (v))); }
        }
        public struct Subtypestring : ISubtype<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Subtypestring (string value) { Value = value; }
            public static implicit operator Subtypestring (string value) { return new Subtypestring (value); }
        }

        public interface ITypicalTest : IValue {}
        public interface ITypicalTest<T> : ITypicalTest { new T Value { get; } }
        public class OneOrManyTypicalTest : OneOrMany<ITypicalTest>
        {
            public OneOrManyTypicalTest(ITypicalTest item) : base(item) { }
            public OneOrManyTypicalTest(IEnumerable<ITypicalTest> items) : base(items) { }
            public static implicit operator OneOrManyTypicalTest (MedicalTest value) { return new OneOrManyTypicalTest (new TypicalTestMedicalTest (value)); }
            public static implicit operator OneOrManyTypicalTest (MedicalTest[] values) { return new OneOrManyTypicalTest (values.Select(v => (ITypicalTest) new TypicalTestMedicalTest (v))); }
            public static implicit operator OneOrManyTypicalTest (List<MedicalTest> values) { return new OneOrManyTypicalTest (values.Select(v => (ITypicalTest) new TypicalTestMedicalTest (v))); }
        }
        public struct TypicalTestMedicalTest : ITypicalTest<MedicalTest>
        {
            object IValue.Value => this.Value;
            public MedicalTest Value { get; }
            public TypicalTestMedicalTest (MedicalTest value) { Value = value; }
            public static implicit operator TypicalTestMedicalTest (MedicalTest value) { return new TypicalTestMedicalTest (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalCondition";

        /// <summary>
        /// The anatomy of the underlying organ system or structures associated with this entity.
        /// </summary>
        [DataMember(Name = "associatedAnatomy", Order = 206)]
        public OneOrManyAssociatedAnatomy AssociatedAnatomy { get; set; }

        /// <summary>
        /// Specifying a cause of something in general. e.g in medicine , one of the causative agent(s) that are most directly responsible for the pathophysiologic process that eventually results in the occurrence.
        /// </summary>
        [DataMember(Name = "cause", Order = 207)]
        public virtual OneOrManyCause Cause { get; set; }

        /// <summary>
        /// One of a set of differential diagnoses for the condition. Specifically, a closely-related or competing diagnosis typically considered later in the cognitive process whereby this medical condition is distinguished from others most likely responsible for a similar collection of signs and symptoms to reach the most parsimonious diagnosis or diagnoses in a patient.
        /// </summary>
        [DataMember(Name = "differentialDiagnosis", Order = 208)]
        public OneOrManyDifferentialDiagnosis DifferentialDiagnosis { get; set; }

        /// <summary>
        /// Specifying a drug or medicine used in a medication procedure
        /// </summary>
        [DataMember(Name = "drug", Order = 209)]
        public OneOrManyDrug Drug { get; set; }

        /// <summary>
        /// The characteristics of associated patients, such as age, gender, race etc.
        /// </summary>
        [DataMember(Name = "epidemiology", Order = 210)]
        public OneOrManyEpidemiology Epidemiology { get; set; }

        /// <summary>
        /// The likely outcome in either the short term or long term of the medical condition.
        /// </summary>
        [DataMember(Name = "expectedPrognosis", Order = 211)]
        public OneOrManyExpectedPrognosis ExpectedPrognosis { get; set; }

        /// <summary>
        /// The expected progression of the condition if it is not treated and allowed to progress naturally.
        /// </summary>
        [DataMember(Name = "naturalProgression", Order = 212)]
        public OneOrManyNaturalProgression NaturalProgression { get; set; }

        /// <summary>
        /// Changes in the normal mechanical, physical, and biochemical functions that are associated with this activity or condition.
        /// </summary>
        [DataMember(Name = "pathophysiology", Order = 213)]
        public OneOrManyPathophysiology Pathophysiology { get; set; }

        /// <summary>
        /// A possible unexpected and unfavorable evolution of a medical condition. Complications may include worsening of the signs or symptoms of the disease, extension of the condition to other organ systems, etc.
        /// </summary>
        [DataMember(Name = "possibleComplication", Order = 214)]
        public OneOrManyPossibleComplication PossibleComplication { get; set; }

        /// <summary>
        /// A possible treatment to address this condition, sign or symptom.
        /// </summary>
        [DataMember(Name = "possibleTreatment", Order = 215)]
        public virtual OneOrManyPossibleTreatment PossibleTreatment { get; set; }

        /// <summary>
        /// A preventative therapy used to prevent an initial occurrence of the medical condition, such as vaccination.
        /// </summary>
        [DataMember(Name = "primaryPrevention", Order = 216)]
        public OneOrManyPrimaryPrevention PrimaryPrevention { get; set; }

        /// <summary>
        /// A modifiable or non-modifiable factor that increases the risk of a patient contracting this condition, e.g. age,  coexisting condition.
        /// </summary>
        [DataMember(Name = "riskFactor", Order = 217)]
        public OneOrManyRiskFactor RiskFactor { get; set; }

        /// <summary>
        /// A preventative therapy used to prevent reoccurrence of the medical condition after an initial episode of the condition.
        /// </summary>
        [DataMember(Name = "secondaryPrevention", Order = 218)]
        public OneOrManySecondaryPrevention SecondaryPrevention { get; set; }

        /// <summary>
        /// A sign or symptom of this condition. Signs are objective or physically observable manifestations of the medical condition while symptoms are the subjective experience of the medical condition.
        /// </summary>
        [DataMember(Name = "signOrSymptom", Order = 219)]
        public OneOrManySignOrSymptom SignOrSymptom { get; set; }

        /// <summary>
        /// The stage of the condition, if applicable.
        /// </summary>
        [DataMember(Name = "stage", Order = 220)]
        public OneOrManyStage Stage { get; set; }

        /// <summary>
        /// The status of the study (enumerated).
        /// </summary>
        [DataMember(Name = "status", Order = 221)]
        public OneOrManyStatus Status { get; set; }

        /// <summary>
        /// A more specific type of the condition, where applicable, for example 'Type 1 Diabetes', 'Type 2 Diabetes', or 'Gestational Diabetes' for Diabetes.
        /// </summary>
        [DataMember(Name = "subtype", Order = 222)]
        public OneOrManySubtype Subtype { get; set; }

        /// <summary>
        /// A medical test typically performed given this condition.
        /// </summary>
        [DataMember(Name = "typicalTest", Order = 223)]
        public OneOrManyTypicalTest TypicalTest { get; set; }
    }
}
