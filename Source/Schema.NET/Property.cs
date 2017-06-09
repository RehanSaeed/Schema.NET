namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A property, used to indicate attributes and relationships of some Thing; equivalent to rdf:Property.
    /// </summary>
    [DataContract]
    public class Property : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Property";
    }
}
