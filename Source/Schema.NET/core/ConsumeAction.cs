namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of ingesting information/resources/food.
    /// </summary>
    public partial interface IConsumeAction : IAction
    {
        /// <summary>
        /// A set of requirements that a must be fulfilled in order to perform an Action. If more than one value is specied, fulfilling one set of requirements will allow the Action to be performed.
        /// </summary>
        OneOrMany<IActionAccessSpecification> ActionAccessibilityRequirement { get; set; }

        /// <summary>
        /// An Offer which must be accepted before the user can perform the Action. For example, the user may need to buy a movie before being able to watch it.
        /// </summary>
        OneOrMany<IOffer> ExpectsAcceptanceOf { get; set; }
    }

    /// <summary>
    /// The act of ingesting information/resources/food.
    /// </summary>
    [DataContract]
    public partial class ConsumeAction : Action, IConsumeAction, IEquatable<ConsumeAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ConsumeAction";

        /// <summary>
        /// A set of requirements that a must be fulfilled in order to perform an Action. If more than one value is specied, fulfilling one set of requirements will allow the Action to be performed.
        /// </summary>
        [DataMember(Name = "actionAccessibilityRequirement", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IActionAccessSpecification> ActionAccessibilityRequirement { get; set; }

        /// <summary>
        /// An Offer which must be accepted before the user can perform the Action. For example, the user may need to buy a movie before being able to watch it.
        /// </summary>
        [DataMember(Name = "expectsAcceptanceOf", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOffer> ExpectsAcceptanceOf { get; set; }

        /// <inheritdoc/>
        public bool Equals(ConsumeAction other)
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
                this.ActionAccessibilityRequirement == other.ActionAccessibilityRequirement &&
                this.ExpectsAcceptanceOf == other.ExpectsAcceptanceOf &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as ConsumeAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ActionAccessibilityRequirement)
            .And(this.ExpectsAcceptanceOf)
            .And(base.GetHashCode());
    }
}
