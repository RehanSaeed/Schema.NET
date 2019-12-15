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
    public partial class FilmAction : CreateAction, IFilmAction, IEquatable<FilmAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FilmAction";

        /// <inheritdoc/>
        public bool Equals(FilmAction other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as FilmAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
