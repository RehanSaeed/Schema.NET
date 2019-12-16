namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of producing a painting, typically with paint and canvas as instruments.
    /// </summary>
    public partial interface IPaintAction : ICreateAction
    {
    }

    /// <summary>
    /// The act of producing a painting, typically with paint and canvas as instruments.
    /// </summary>
    [DataContract]
    public partial class PaintAction : CreateAction, IPaintAction, IEquatable<PaintAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PaintAction";

        /// <inheritdoc/>
        public bool Equals(PaintAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as PaintAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
