namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A movie rental store.
    /// </summary>
    public partial interface IMovieRentalStore : IStore
    {
    }

    /// <summary>
    /// A movie rental store.
    /// </summary>
    [DataContract]
    public partial class MovieRentalStore : Store, IMovieRentalStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MovieRentalStore";
    }
}
