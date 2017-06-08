namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents additional information about a relationship or property...
    /// </summary>
    [DataContract]
    public class Role : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Role";

        /// <summary>
        /// The end date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "endDate")]
        public DateTimeOffset EndDate { get; set; }

        /// <summary>
        /// The start date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "startDate")]
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// A role played, performed or filled by a person or organization. For example, the team of creators for a comic book might fill the roles named 'inker', 'penciller', and 'letterer'; or an athlete in a SportsTeam might play in the position named 'Quarterback'.
        /// </summary>
        [DataMember(Name = "roleName")]
        public object RoleName { get; protected set; }

        /// <summary>
        /// A role played, performed or filled by a person or organization. For example, the team of creators for a comic book might fill the roles named 'inker', 'penciller', and 'letterer'; or an athlete in a SportsTeam might play in the position named 'Quarterback'.
        /// </summary>
        [IgnoreDataMember]
        public string RoleNameText
        {
            get => this.RoleName as string;
            set => this.RoleName = value;
        }

        /// <summary>
        /// A role played, performed or filled by a person or organization. For example, the team of creators for a comic book might fill the roles named 'inker', 'penciller', and 'letterer'; or an athlete in a SportsTeam might play in the position named 'Quarterback'.
        /// </summary>
        [IgnoreDataMember]
        public Uri RoleNameURL
        {
            get => this.RoleName as Uri;
            set => this.RoleName = value;
        }
    }
}
