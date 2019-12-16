namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A tool used (but not consumed) when performing instructions for how to achieve a result.
    /// </summary>
    public partial interface IHowToTool : IHowToItem
    {
    }

    /// <summary>
    /// A tool used (but not consumed) when performing instructions for how to achieve a result.
    /// </summary>
    [DataContract]
    public partial class HowToTool : HowToItem, IHowToTool, IEquatable<HowToTool>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HowToTool";

        /// <inheritdoc/>
        public bool Equals(HowToTool other)
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
        public override bool Equals(object obj) => this.Equals(obj as HowToTool);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
