namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A computer store.
    /// </summary>
    public partial interface IComputerStore : IStore
    {
    }

    /// <summary>
    /// A computer store.
    /// </summary>
    [DataContract]
    public partial class ComputerStore : Store, IComputerStore, IEquatable<ComputerStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ComputerStore";
    }
}
