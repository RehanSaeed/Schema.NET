namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A resort is a place used for relaxation or recreation, attracting visitors for holidays or vacations...
    /// </summary>
    [DataContract]
    public partial class Resort : LodgingBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Resort";
    }
}
