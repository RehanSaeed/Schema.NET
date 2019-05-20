namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A self-storage facility.
    /// </summary>
    public partial interface ISelfStorage : ILocalBusiness
    {
    }

    /// <summary>
    /// A self-storage facility.
    /// </summary>
    [DataContract]
    public partial class SelfStorage : LocalBusiness, ISelfStorage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SelfStorage";
    }
}
