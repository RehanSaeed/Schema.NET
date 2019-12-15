namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of producing a visual/graphical representation of an object, typically with a pen/pencil and paper as instruments.
    /// </summary>
    public partial interface IDrawAction : ICreateAction
    {
    }

    /// <summary>
    /// The act of producing a visual/graphical representation of an object, typically with a pen/pencil and paper as instruments.
    /// </summary>
    [DataContract]
    public partial class DrawAction : CreateAction, IDrawAction, IEquatable<DrawAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DrawAction";
    }
}
