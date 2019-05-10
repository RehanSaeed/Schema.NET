namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A step in the instructions for how to achieve a result. It is an ordered list with HowToDirection and/or HowToTip items.
    /// </summary>
    public partial interface IHowToStep : ICreativeWorkAndItemListAndListItem
    {
    }

    /// <summary>
    /// A step in the instructions for how to achieve a result. It is an ordered list with HowToDirection and/or HowToTip items.
    /// </summary>
    [DataContract]
    public partial class HowToStep : CreativeWorkAndItemListAndListItem, IHowToStep
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HowToStep";
    }
}
