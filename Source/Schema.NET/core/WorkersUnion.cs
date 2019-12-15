﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A Workers Union (also known as a Labor Union, Labour Union, or Trade Union) is an organization that promotes the interests of its worker members by collectively bargaining with management, organizing, and political lobbying.
    /// </summary>
    public partial interface IWorkersUnion : IOrganization
    {
    }

    /// <summary>
    /// A Workers Union (also known as a Labor Union, Labour Union, or Trade Union) is an organization that promotes the interests of its worker members by collectively bargaining with management, organizing, and political lobbying.
    /// </summary>
    [DataContract]
    public partial class WorkersUnion : Organization, IWorkersUnion, IEquatable<WorkersUnion>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WorkersUnion";

        /// <inheritdoc/>
        public bool Equals(WorkersUnion other)
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
        public override bool Equals(object obj) => this.Equals(obj as WorkersUnion);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
