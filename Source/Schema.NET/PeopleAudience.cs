namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// </summary>
    [DataContract]
    public class PeopleAudience : Audience
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PeopleAudience";

        /// <summary>
        /// Maximal age recommended for viewing content.
        /// </summary>
        [DataMember(Name = "suggestedMaxAge")]
        public decimal SuggestedMaxAge { get; set; }

        /// <summary>
        /// Audiences defined by a person's minimum age.
        /// </summary>
        [DataMember(Name = "requiredMinAge")]
        public int RequiredMinAge { get; set; }

        /// <summary>
        /// Audiences defined by a person's gender.
        /// </summary>
        [DataMember(Name = "requiredGender")]
        public string RequiredGender { get; set; }

        /// <summary>
        /// The gender of the person or audience.
        /// </summary>
        [DataMember(Name = "suggestedGender")]
        public string SuggestedGender { get; set; }

        /// <summary>
        /// Audiences defined by a person's maximum age.
        /// </summary>
        [DataMember(Name = "requiredMaxAge")]
        public int RequiredMaxAge { get; set; }

        /// <summary>
        /// Minimal age recommended for viewing content.
        /// </summary>
        [DataMember(Name = "suggestedMinAge")]
        public decimal SuggestedMinAge { get; set; }
    }
}
