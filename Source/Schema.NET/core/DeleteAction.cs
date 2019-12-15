namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of editing a recipient by removing one of its objects.
    /// </summary>
    public partial interface IDeleteAction : IUpdateAction
    {
    }

    /// <summary>
    /// The act of editing a recipient by removing one of its objects.
    /// </summary>
    [DataContract]
    public partial class DeleteAction : UpdateAction, IDeleteAction, IEquatable<DeleteAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DeleteAction";

        /// <inheritdoc/>
        public bool Equals(DeleteAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as DeleteAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
