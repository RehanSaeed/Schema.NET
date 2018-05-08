namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A Catholic church.
    /// </summary>
    public partial interface ICatholicChurch : IPlaceOfWorship
    {
    }

    /// <summary>
    /// A Catholic church.
    /// </summary>
    [DataContract]
    public partial class CatholicChurch : PlaceOfWorship, ICatholicChurch
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CatholicChurch";
    }
}
