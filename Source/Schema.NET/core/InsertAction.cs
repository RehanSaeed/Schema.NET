namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of adding at a specific location in an ordered collection.
    /// </summary>
    public partial interface IInsertAction : IAddAction
    {
        /// <summary>
        /// A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        OneOrMany<IPlace> ToLocation { get; set; }
    }

    /// <summary>
    /// The act of adding at a specific location in an ordered collection.
    /// </summary>
    [DataContract]
    public partial class InsertAction : AddAction, IInsertAction, IEquatable<InsertAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InsertAction";

        /// <summary>
        /// A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        [DataMember(Name = "toLocation", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> ToLocation { get; set; }

        /// <inheritdoc/>
        public bool Equals(InsertAction other)
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
                this.ToLocation == other.ToLocation &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as InsertAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ToLocation)
            .And(base.GetHashCode());
    }
}
