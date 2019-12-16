namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A process of care involving exercise, changes to diet, fitness routines, and other lifestyle changes aimed at improving a health condition.
    /// </summary>
    public partial interface ILifestyleModification : IMedicalEntity
    {
    }

    /// <summary>
    /// A process of care involving exercise, changes to diet, fitness routines, and other lifestyle changes aimed at improving a health condition.
    /// </summary>
    [DataContract]
    public partial class LifestyleModification : MedicalEntity, ILifestyleModification, IEquatable<LifestyleModification>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LifestyleModification";

        /// <inheritdoc/>
        public bool Equals(LifestyleModification other)
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
        public override bool Equals(object obj) => this.Equals(obj as LifestyleModification);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
