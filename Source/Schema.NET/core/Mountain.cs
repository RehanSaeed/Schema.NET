namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A mountain, like Mount Whitney or Mount Everest.
    /// </summary>
    [DataContract]
    public partial class Mountain : Landform
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Mountain";
    }
}
