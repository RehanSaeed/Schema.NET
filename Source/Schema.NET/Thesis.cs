namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A thesis or dissertation document submitted in support of candidature for an academic degree or professional qualification.
    /// </summary>
    [DataContract]
    public class Thesis : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Thesis";
    }
}
