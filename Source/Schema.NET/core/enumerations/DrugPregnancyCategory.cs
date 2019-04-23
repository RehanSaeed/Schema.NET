namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Categories that represent an assessment of the risk of fetal injury due to a drug or pharmaceutical used as directed by the mother during pregnancy.
    /// </summary>
    public enum DrugPregnancyCategory
    {
        /// <summary>
        /// A designation by the US FDA signifying that adequate and well-controlled studies have failed to demonstrate a risk to the fetus in the first trimester of pregnancy (and there is no evidence of risk in later trimesters).
        /// </summary>
        [EnumMember(Value = "http://schema.org/FDAcategoryA")]
        FDAcategoryA,

        /// <summary>
        /// A designation by the US FDA signifying that animal reproduction studies have failed to demonstrate a risk to the fetus and there are no adequate and well-controlled studies in pregnant women.
        /// </summary>
        [EnumMember(Value = "http://schema.org/FDAcategoryB")]
        FDAcategoryB,

        /// <summary>
        /// A designation by the US FDA signifying that animal reproduction studies have shown an adverse effect on the fetus and there are no adequate and well-controlled studies in humans, but potential benefits may warrant use of the drug in pregnant women despite potential risks.
        /// </summary>
        [EnumMember(Value = "http://schema.org/FDAcategoryC")]
        FDAcategoryC,

        /// <summary>
        /// A designation by the US FDA signifying that there is positive evidence of human fetal risk based on adverse reaction data from investigational or marketing experience or studies in humans, but potential benefits may warrant use of the drug in pregnant women despite potential risks.
        /// </summary>
        [EnumMember(Value = "http://schema.org/FDAcategoryD")]
        FDAcategoryD,

        /// <summary>
        /// A designation by the US FDA signifying that studies in animals or humans have demonstrated fetal abnormalities and/or there is positive evidence of human fetal risk based on adverse reaction data from investigational or marketing experience, and the risks involved in use of the drug in pregnant women clearly outweigh potential benefits.
        /// </summary>
        [EnumMember(Value = "http://schema.org/FDAcategoryX")]
        FDAcategoryX,

        /// <summary>
        /// A designation that the drug in question has not been assigned a pregnancy category designation by the US FDA.
        /// </summary>
        [EnumMember(Value = "http://schema.org/FDAnotEvaluated")]
        FDAnotEvaluated
    }
}
