namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An office equipment store.
    /// </summary>
    public partial interface IOfficeEquipmentStore : IStore
    {
    }

    /// <summary>
    /// An office equipment store.
    /// </summary>
    [DataContract]
    public partial class OfficeEquipmentStore : Store, IOfficeEquipmentStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OfficeEquipmentStore";
    }
}
