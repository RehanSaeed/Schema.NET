namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of dressing oneself in clothing.
    /// </summary>
    public partial interface IWearAction : IUseAction
    {
    }

    /// <summary>
    /// The act of dressing oneself in clothing.
    /// </summary>
    [DataContract]
    public partial class WearAction : UseAction, IWearAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WearAction";
    }
}
