namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A diet restricted to certain foods or preparations for cultural, religious, health or lifestyle reasons.
    /// </summary>
    [DataContract]
    public class RestrictedDiet : Enumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "RestrictedDiet";
    }
}
