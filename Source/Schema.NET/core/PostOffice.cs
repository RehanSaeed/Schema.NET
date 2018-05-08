namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A post office.
    /// </summary>
    public partial interface IPostOffice : IGovernmentOffice
    {
    }

    /// <summary>
    /// A post office.
    /// </summary>
    [DataContract]
    public partial class PostOffice : GovernmentOffice, IPostOffice
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PostOffice";
    }
}
