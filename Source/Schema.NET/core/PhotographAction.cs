namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of capturing still images of objects using a camera.
    /// </summary>
    public partial interface IPhotographAction : ICreateAction
    {
    }

    /// <summary>
    /// The act of capturing still images of objects using a camera.
    /// </summary>
    [DataContract]
    public partial class PhotographAction : CreateAction, IPhotographAction, IEquatable<PhotographAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PhotographAction";
    }
}
