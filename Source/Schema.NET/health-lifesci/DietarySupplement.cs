namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A product taken by mouth that contains a dietary ingredient intended to supplement the diet...
    /// </summary>
    [DataContract]
    public partial class DietarySupplement : Substance
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DietarySupplement";
    }
}
