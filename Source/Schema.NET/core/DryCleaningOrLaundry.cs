namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A dry-cleaning business.
    /// </summary>
    public partial interface IDryCleaningOrLaundry : ILocalBusiness
    {
    }

    /// <summary>
    /// A dry-cleaning business.
    /// </summary>
    [DataContract]
    public partial class DryCleaningOrLaundry : LocalBusiness, IDryCleaningOrLaundry
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DryCleaningOrLaundry";
    }
}
