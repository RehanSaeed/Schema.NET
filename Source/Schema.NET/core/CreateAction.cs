namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of deliberately creating/producing/generating/building a result out of the agent.
    /// </summary>
    public partial interface ICreateAction : IAction
    {
    }

    /// <summary>
    /// The act of deliberately creating/producing/generating/building a result out of the agent.
    /// </summary>
    [DataContract]
    public partial class CreateAction : Action, ICreateAction, IEquatable<CreateAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CreateAction";

        /// <inheritdoc/>
        public bool Equals(CreateAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as CreateAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
