namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The artwork on the cover of a comic.
    /// </summary>
    [DataContract]
    public partial class ComicCoverArt : ComicStoryAndCoverArt
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ComicCoverArt";
    }
}
