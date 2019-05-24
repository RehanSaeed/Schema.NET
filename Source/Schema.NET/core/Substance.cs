namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Any matter of defined composition that has discrete existence, whose origin may be biological, mineral or chemical.
    /// </summary>
    public partial interface ISubstance : IMedicalEntity
    {
        /// <summary>
        /// An active ingredient, typically chemical compounds and/or biologic substances.
        /// </summary>
        OneOrMany<string> ActiveIngredient { get; set; }

        /// <summary>
        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        /// </summary>
        OneOrMany<IMaximumDoseSchedule> MaximumIntake { get; set; }
    }

    /// <summary>
    /// Any matter of defined composition that has discrete existence, whose origin may be biological, mineral or chemical.
    /// </summary>
    [DataContract]
    public partial class Substance : MedicalEntity, ISubstance
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Substance";

        /// <summary>
        /// An active ingredient, typically chemical compounds and/or biologic substances.
        /// </summary>
        [DataMember(Name = "activeIngredient", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<string> ActiveIngredient { get; set; }

        /// <summary>
        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        /// </summary>
        [DataMember(Name = "maximumIntake", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IMaximumDoseSchedule> MaximumIntake { get; set; }
    }
}
