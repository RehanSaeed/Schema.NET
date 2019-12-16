namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of organizing tasks/objects/events by associating resources to it.
    /// </summary>
    public partial interface IAllocateAction : IOrganizeAction
    {
        /// <summary>
        /// A goal towards an action is taken. Can be concrete or abstract.
        /// </summary>
        Values<MedicalDevicePurpose?, IThing> Purpose { get; set; }
    }

    /// <summary>
    /// The act of organizing tasks/objects/events by associating resources to it.
    /// </summary>
    [DataContract]
    public partial class AllocateAction : OrganizeAction, IAllocateAction, IEquatable<AllocateAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AllocateAction";

        /// <summary>
        /// A goal towards an action is taken. Can be concrete or abstract.
        /// </summary>
        [DataMember(Name = "purpose", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<MedicalDevicePurpose?, IThing> Purpose { get; set; }

        /// <inheritdoc/>
        public bool Equals(AllocateAction other)
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
                this.Purpose == other.Purpose &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as AllocateAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Purpose)
            .And(base.GetHashCode());
    }
}
