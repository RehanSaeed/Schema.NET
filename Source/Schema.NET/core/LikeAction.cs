namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of expressing a positive sentiment about the object. An agent likes an object (a proposition, topic or theme) with participants.
    /// </summary>
    public partial interface ILikeAction : IReactAction
    {
    }

    /// <summary>
    /// The act of expressing a positive sentiment about the object. An agent likes an object (a proposition, topic or theme) with participants.
    /// </summary>
    [DataContract]
    public partial class LikeAction : ReactAction, ILikeAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LikeAction";
    }
}
