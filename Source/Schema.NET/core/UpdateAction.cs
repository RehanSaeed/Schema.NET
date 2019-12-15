namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of managing by changing/editing the state of the object.
    /// </summary>
    public partial interface IUpdateAction : IAction
    {
        /// <summary>
        /// A sub property of object. The collection target of the action.
        /// </summary>
        OneOrMany<IThing> TargetCollection { get; set; }
    }

    /// <summary>
    /// The act of managing by changing/editing the state of the object.
    /// </summary>
    [DataContract]
    public partial class UpdateAction : Action, IUpdateAction, IEquatable<UpdateAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "UpdateAction";

        /// <summary>
        /// A sub property of object. The collection target of the action.
        /// </summary>
        [DataMember(Name = "targetCollection", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> TargetCollection { get; set; }

        /// <inheritdoc/>
        public bool Equals(UpdateAction other)
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
                this.TargetCollection == other.TargetCollection &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as UpdateAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.TargetCollection)
            .And(base.GetHashCode());
    }
}
