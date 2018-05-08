namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of editing a recipient by removing one of its objects.
    /// </summary>
    public partial interface IDeleteAction : IUpdateAction
    {
    }

    /// <summary>
    /// The act of editing a recipient by removing one of its objects.
    /// </summary>
    [DataContract]
    public partial class DeleteAction : UpdateAction, IDeleteAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DeleteAction";
    }
}
