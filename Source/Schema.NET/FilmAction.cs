namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of capturing sound and moving images on film, video, or digitally.
    /// </summary>
    [DataContract]
    public class FilmAction : CreateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "FilmAction";
    }
}
