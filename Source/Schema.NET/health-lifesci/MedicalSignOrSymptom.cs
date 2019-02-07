namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any feature associated or not with a medical condition. In medicine a symptom is generally subjective while a sign is objective.
    /// </summary>
    [DataContract]
    public partial class MedicalSignOrSymptom : MedicalCondition
    {


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalSignOrSymptom";

        /// <summary>
        /// Specifying a cause of something in general. e.g in medicine , one of the causative agent(s) that are most directly responsible for the pathophysiologic process that eventually results in the occurrence.
        /// </summary>
        [DataMember(Name = "cause", Order = 306)]
        public override OneOrManyCause Cause { get; set; }

        /// <summary>
        /// A possible treatment to address this condition, sign or symptom.
        /// </summary>
        [DataMember(Name = "possibleTreatment", Order = 307)]
        public override OneOrManyPossibleTreatment PossibleTreatment { get; set; }
    }
}
