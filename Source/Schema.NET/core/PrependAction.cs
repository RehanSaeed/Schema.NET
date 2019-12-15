namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of inserting at the beginning if an ordered collection.
    /// </summary>
    public partial interface IPrependAction : IInsertAction
    {
    }

    /// <summary>
    /// The act of inserting at the beginning if an ordered collection.
    /// </summary>
    [DataContract]
    public partial class PrependAction : InsertAction, IPrependAction, IEquatable<PrependAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PrependAction";

        /// <inheritdoc/>
        public bool Equals(PrependAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as PrependAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
