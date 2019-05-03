namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A tool used (but not consumed) when performing instructions for how to achieve a result.
    /// </summary>
    [DataContract]
    public partial class HowToTool : HowToItem
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HowToTool";
    }
}
