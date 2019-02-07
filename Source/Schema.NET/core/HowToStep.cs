namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A step in the instructions for how to achieve a result. It is an ordered list with HowToDirection and/or HowToTip items.
    /// </summary>
    [DataContract]
    public partial class HowToStep : CreativeWorkAndItemListAndListItem
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HowToStep";
    }
}
