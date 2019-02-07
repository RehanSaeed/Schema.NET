namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A collection or bound volume of maps, charts, plates or tables, physical or in media form illustrating any subject.
    /// </summary>
    [DataContract]
    public partial class Atlas : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Atlas";
    }
}
