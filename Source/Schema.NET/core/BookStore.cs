namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A bookstore.
    /// </summary>
    public partial interface IBookStore : IStore
    {
    }

    /// <summary>
    /// A bookstore.
    /// </summary>
    [DataContract]
    public partial class BookStore : Store, IBookStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BookStore";
    }
}
