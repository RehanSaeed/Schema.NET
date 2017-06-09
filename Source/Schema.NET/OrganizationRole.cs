namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A subclass of Role used to describe roles within organizations.
    /// </summary>
    [DataContract]
    public class OrganizationRole : Role
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OrganizationRole";

        /// <summary>
        /// A number associated with a role in an organization, for example, the number on an athlete's jersey.
        /// </summary>
        [DataMember(Name = "numberedPosition", Order = 2)]
        public double? NumberedPosition { get; set; }
    }
}
