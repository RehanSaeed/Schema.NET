namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The term "story" is any indivisible, re-printable
    ///     unit of a comic, including the interior stories, covers, and backmatter...
    /// </summary>
    [DataContract]
    public partial class ComicStory : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ComicStory";
    }
}
