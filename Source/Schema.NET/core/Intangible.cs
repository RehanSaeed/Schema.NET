namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A utility class that serves as the umbrella for a number of 'intangible' things such as quantities, structured values, etc.
    /// </summary>
    public partial interface IIntangible : IThing
    {
    }

    /// <summary>
    /// A utility class that serves as the umbrella for a number of 'intangible' things such as quantities, structured values, etc.
    /// </summary>
    [DataContract]
    public partial class Intangible : Thing, IIntangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Intangible";
    }
}
