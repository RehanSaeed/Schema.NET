namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of capturing sound and moving images on film, video, or digitally.
    /// </summary>
    public partial interface IFilmAction : ICreateAction
    {
    }

    /// <summary>
    /// The act of capturing sound and moving images on film, video, or digitally.
    /// </summary>
    [DataContract]
    public partial class FilmAction : CreateAction, IFilmAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FilmAction";
    }
}
