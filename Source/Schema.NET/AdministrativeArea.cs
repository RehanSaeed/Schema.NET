namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A geographical region, typically under the jurisdiction of a particular government.
    /// </summary>
    [DataContract]
    public class AdministrativeArea : Place
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AdministrativeArea";
    }
}
