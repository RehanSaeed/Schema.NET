namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of producing a painting, typically with paint and canvas as instruments.
    /// </summary>
    public partial interface IPaintAction : ICreateAction
    {
    }

    /// <summary>
    /// The act of producing a painting, typically with paint and canvas as instruments.
    /// </summary>
    [DataContract]
    public partial class PaintAction : CreateAction, IPaintAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PaintAction";
    }
}
