namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A sub-grouping of steps in the instructions for how to achieve a result (e.g. steps for making a pie crust within a pie recipe).
    /// </summary>
    public partial interface IHowToSection : ICreativeWorkAndItemListAndListItem
    {
    }

    /// <summary>
    /// A sub-grouping of steps in the instructions for how to achieve a result (e.g. steps for making a pie crust within a pie recipe).
    /// </summary>
    [DataContract]
    public partial class HowToSection : CreativeWorkAndItemListAndListItem, IHowToSection
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HowToSection";
    }
}
