namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of editing by adding an object to a collection.
    /// </summary>
    public partial interface IAddAction : IUpdateAction
    {
    }

    /// <summary>
    /// The act of editing by adding an object to a collection.
    /// </summary>
    [DataContract]
    public partial class AddAction : UpdateAction, IAddAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AddAction";
    }
}
