namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A department store.
    /// </summary>
    public partial interface IDepartmentStore : IStore
    {
    }

    /// <summary>
    /// A department store.
    /// </summary>
    [DataContract]
    public partial class DepartmentStore : Store, IDepartmentStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DepartmentStore";
    }
}
