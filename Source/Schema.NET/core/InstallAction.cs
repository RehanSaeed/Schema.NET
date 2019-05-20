namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of installing an application.
    /// </summary>
    public partial interface IInstallAction : IConsumeAction
    {
    }

    /// <summary>
    /// The act of installing an application.
    /// </summary>
    [DataContract]
    public partial class InstallAction : ConsumeAction, IInstallAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InstallAction";
    }
}
