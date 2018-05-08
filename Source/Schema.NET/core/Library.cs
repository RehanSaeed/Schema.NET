namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A library.
    /// </summary>
    public partial interface ILibrary : ILocalBusiness
    {
    }

    /// <summary>
    /// A library.
    /// </summary>
    [DataContract]
    public partial class Library : LocalBusiness, ILibrary
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Library";
    }
}
