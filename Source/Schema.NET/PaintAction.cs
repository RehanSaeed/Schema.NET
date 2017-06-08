namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of producing a painting, typically with paint and canvas as instruments.
    /// </summary>
    [DataContract]
    public class PaintAction : CreateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PaintAction";
    }
}
