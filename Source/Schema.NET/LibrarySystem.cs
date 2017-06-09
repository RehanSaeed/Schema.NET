namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A LibrarySystem is a collaborative system amongst several libraries.
    /// </summary>
    [DataContract]
    public class LibrarySystem : Organization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LibrarySystem";
    }
}
