namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of capturing still images of objects using a camera.
    /// </summary>
    public partial interface IPhotographAction : ICreateAction
    {
    }

    /// <summary>
    /// The act of capturing still images of objects using a camera.
    /// </summary>
    [DataContract]
    public partial class PhotographAction : CreateAction, IPhotographAction, IEquatable<PhotographAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PhotographAction";

        /// <inheritdoc/>
        public bool Equals(PhotographAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as PhotographAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
