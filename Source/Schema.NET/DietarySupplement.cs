namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A product taken by mouth that contains a dietary ingredient intended to supplement the diet...
    /// </summary>
    [DataContract]
    public class DietarySupplement : Substance
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "DietarySupplement";
    }
}
