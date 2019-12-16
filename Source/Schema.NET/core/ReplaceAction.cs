namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of editing a recipient by replacing an old object with a new object.
    /// </summary>
    public partial interface IReplaceAction : IUpdateAction
    {
        /// <summary>
        /// A sub property of object. The object that is being replaced.
        /// </summary>
        OneOrMany<IThing> Replacee { get; set; }

        /// <summary>
        /// A sub property of object. The object that replaces.
        /// </summary>
        OneOrMany<IThing> Replacer { get; set; }
    }

    /// <summary>
    /// The act of editing a recipient by replacing an old object with a new object.
    /// </summary>
    [DataContract]
    public partial class ReplaceAction : UpdateAction, IReplaceAction, IEquatable<ReplaceAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReplaceAction";

        /// <summary>
        /// A sub property of object. The object that is being replaced.
        /// </summary>
        [DataMember(Name = "replacee", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> Replacee { get; set; }

        /// <summary>
        /// A sub property of object. The object that replaces.
        /// </summary>
        [DataMember(Name = "replacer", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> Replacer { get; set; }

        /// <inheritdoc/>
        public bool Equals(ReplaceAction other)
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
                this.Replacee == other.Replacee &&
                this.Replacer == other.Replacer &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as ReplaceAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Replacee)
            .And(this.Replacer)
            .And(base.GetHashCode());
    }
}
