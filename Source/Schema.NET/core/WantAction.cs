namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of expressing a desire about the object. An agent wants an object.
    /// </summary>
    public partial interface IWantAction : IReactAction
    {
    }

    /// <summary>
    /// The act of expressing a desire about the object. An agent wants an object.
    /// </summary>
    [DataContract]
    public partial class WantAction : ReactAction, IWantAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WantAction";
    }
}
