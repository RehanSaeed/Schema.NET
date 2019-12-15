namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of producing a visual/graphical representation of an object, typically with a pen/pencil and paper as instruments.
    /// </summary>
    public partial interface IDrawAction : ICreateAction
    {
    }

    /// <summary>
    /// The act of producing a visual/graphical representation of an object, typically with a pen/pencil and paper as instruments.
    /// </summary>
    [DataContract]
    public partial class DrawAction : CreateAction, IDrawAction, IEquatable<DrawAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DrawAction";

        /// <inheritdoc/>
        public bool Equals(DrawAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as DrawAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
