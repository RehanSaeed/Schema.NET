namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A store that sells mobile phones and related accessories.
    /// </summary>
    [DataContract]
    public partial class MobilePhoneStore : Store
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MobilePhoneStore";
    }
}
