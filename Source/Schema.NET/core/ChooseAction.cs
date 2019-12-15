namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of expressing a preference from a set of options or a large or unbounded set of choices/options.
    /// </summary>
    public partial interface IChooseAction : IAssessAction
    {
        /// <summary>
        /// A sub property of object. The options subject to this action.
        /// </summary>
        Values<string, IThing> ActionOption { get; set; }
    }

    /// <summary>
    /// The act of expressing a preference from a set of options or a large or unbounded set of choices/options.
    /// </summary>
    [DataContract]
    public partial class ChooseAction : AssessAction, IChooseAction, IEquatable<ChooseAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ChooseAction";

        /// <summary>
        /// A sub property of object. The options subject to this action.
        /// </summary>
        [DataMember(Name = "actionOption", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IThing> ActionOption { get; set; }

        /// <inheritdoc/>
        public bool Equals(ChooseAction other)
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
                this.ActionOption == other.ActionOption &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as ChooseAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ActionOption)
            .And(base.GetHashCode());
    }
}
