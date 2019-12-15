namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of inserting at the end if an ordered collection.
    /// </summary>
    public partial interface IAppendAction : IInsertAction
    {
    }

    /// <summary>
    /// The act of inserting at the end if an ordered collection.
    /// </summary>
    [DataContract]
    public partial class AppendAction : InsertAction, IAppendAction, IEquatable<AppendAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AppendAction";

        /// <inheritdoc/>
        public bool Equals(AppendAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as AppendAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
