namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of editing by adding an object to a collection.
    /// </summary>
    public partial interface IAddAction : IUpdateAction
    {
    }

    /// <summary>
    /// The act of editing by adding an object to a collection.
    /// </summary>
    [DataContract]
    public partial class AddAction : UpdateAction, IAddAction, IEquatable<AddAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AddAction";

        /// <inheritdoc/>
        public bool Equals(AddAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as AddAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
