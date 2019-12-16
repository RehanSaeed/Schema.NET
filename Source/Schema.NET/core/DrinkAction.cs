namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of swallowing liquids.
    /// </summary>
    public partial interface IDrinkAction : IConsumeAction
    {
    }

    /// <summary>
    /// The act of swallowing liquids.
    /// </summary>
    [DataContract]
    public partial class DrinkAction : ConsumeAction, IDrinkAction, IEquatable<DrinkAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DrinkAction";

        /// <inheritdoc/>
        public bool Equals(DrinkAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as DrinkAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
