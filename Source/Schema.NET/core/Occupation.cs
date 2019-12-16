namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A profession, may involve prolonged training and/or a formal qualification.
    /// </summary>
    public partial interface IOccupation : IIntangible
    {
        /// <summary>
        /// Educational background needed for the position or Occupation.
        /// </summary>
        OneOrMany<string> EducationRequirements { get; set; }

        /// <summary>
        /// An estimated salary for a job posting or occupation, based on a variety of variables including, but not limited to industry, job title, and location. Estimated salaries  are often computed by outside organizations rather than the hiring organization, who may not have committed to the estimated value.
        /// </summary>
        Values<IMonetaryAmount, IMonetaryAmountDistribution, decimal?> EstimatedSalary { get; set; }

        /// <summary>
        /// Description of skills and experience needed for the position or Occupation.
        /// </summary>
        OneOrMany<string> ExperienceRequirements { get; set; }

        /// <summary>
        /// A category describing the job, preferably using a term from a taxonomy such as &lt;a href="http://www.onetcenter.org/taxonomy.html"&gt;BLS O*NET-SOC&lt;/a&gt;, &lt;a href="https://www.ilo.org/public/english/bureau/stat/isco/isco08/"&gt;ISCO-08&lt;/a&gt; or similar, with the property repeated for each applicable value. Ideally the taxonomy should be identified, and both the textual label and formal code for the category should be provided.&lt;br/&gt;&lt;br/&gt;
        /// Note: for historical reasons, any textual label and formal code provided as a literal may be assumed to be from O*NET-SOC.
        /// </summary>
        OneOrMany<string> OccupationalCategory { get; set; }

        /// <summary>
        /// The region/country for which this occupational description is appropriate. Note that educational requirements and qualifications can vary between jurisdictions.
        /// </summary>
        OneOrMany<IAdministrativeArea> OccupationLocation { get; set; }

        /// <summary>
        /// Specific qualifications required for this role or Occupation.
        /// </summary>
        OneOrMany<string> Qualifications { get; set; }

        /// <summary>
        /// Responsibilities associated with this role or Occupation.
        /// </summary>
        OneOrMany<string> Responsibilities { get; set; }

        /// <summary>
        /// A statement of knowledge, skill, ability, task or any other assertion expressing a competency that is desired or required to fulfill this role or to work in this occupation.
        /// </summary>
        OneOrMany<string> Skills { get; set; }
    }

    /// <summary>
    /// A profession, may involve prolonged training and/or a formal qualification.
    /// </summary>
    [DataContract]
    public partial class Occupation : Intangible, IOccupation, IEquatable<Occupation>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Occupation";

        /// <summary>
        /// Educational background needed for the position or Occupation.
        /// </summary>
        [DataMember(Name = "educationRequirements", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> EducationRequirements { get; set; }

        /// <summary>
        /// An estimated salary for a job posting or occupation, based on a variety of variables including, but not limited to industry, job title, and location. Estimated salaries  are often computed by outside organizations rather than the hiring organization, who may not have committed to the estimated value.
        /// </summary>
        [DataMember(Name = "estimatedSalary", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMonetaryAmount, IMonetaryAmountDistribution, decimal?> EstimatedSalary { get; set; }

        /// <summary>
        /// Description of skills and experience needed for the position or Occupation.
        /// </summary>
        [DataMember(Name = "experienceRequirements", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ExperienceRequirements { get; set; }

        /// <summary>
        /// A category describing the job, preferably using a term from a taxonomy such as &lt;a href="http://www.onetcenter.org/taxonomy.html"&gt;BLS O*NET-SOC&lt;/a&gt;, &lt;a href="https://www.ilo.org/public/english/bureau/stat/isco/isco08/"&gt;ISCO-08&lt;/a&gt; or similar, with the property repeated for each applicable value. Ideally the taxonomy should be identified, and both the textual label and formal code for the category should be provided.&lt;br/&gt;&lt;br/&gt;
        /// Note: for historical reasons, any textual label and formal code provided as a literal may be assumed to be from O*NET-SOC.
        /// </summary>
        [DataMember(Name = "occupationalCategory", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> OccupationalCategory { get; set; }

        /// <summary>
        /// The region/country for which this occupational description is appropriate. Note that educational requirements and qualifications can vary between jurisdictions.
        /// </summary>
        [DataMember(Name = "occupationLocation", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAdministrativeArea> OccupationLocation { get; set; }

        /// <summary>
        /// Specific qualifications required for this role or Occupation.
        /// </summary>
        [DataMember(Name = "qualifications", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Qualifications { get; set; }

        /// <summary>
        /// Responsibilities associated with this role or Occupation.
        /// </summary>
        [DataMember(Name = "responsibilities", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Responsibilities { get; set; }

        /// <summary>
        /// A statement of knowledge, skill, ability, task or any other assertion expressing a competency that is desired or required to fulfill this role or to work in this occupation.
        /// </summary>
        [DataMember(Name = "skills", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Skills { get; set; }

        /// <inheritdoc/>
        public bool Equals(Occupation other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.EducationRequirements == other.EducationRequirements &&
                this.EstimatedSalary == other.EstimatedSalary &&
                this.ExperienceRequirements == other.ExperienceRequirements &&
                this.OccupationalCategory == other.OccupationalCategory &&
                this.OccupationLocation == other.OccupationLocation &&
                this.Qualifications == other.Qualifications &&
                this.Responsibilities == other.Responsibilities &&
                this.Skills == other.Skills &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Occupation);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.EducationRequirements)
            .And(this.EstimatedSalary)
            .And(this.ExperienceRequirements)
            .And(this.OccupationalCategory)
            .And(this.OccupationLocation)
            .And(this.Qualifications)
            .And(this.Responsibilities)
            .And(this.Skills)
            .And(base.GetHashCode());
    }
}
