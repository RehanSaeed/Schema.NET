namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A set of Category Code values.
    /// </summary>
    [DataContract]
    public class CategoryCodeSet : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "CategoryCodeSet";
    }
}
