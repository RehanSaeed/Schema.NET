namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A gym.
    /// </summary>
    public partial interface IExerciseGym : ISportsActivityLocation
    {
    }

    /// <summary>
    /// A gym.
    /// </summary>
    [DataContract]
    public partial class ExerciseGym : SportsActivityLocation, IExerciseGym, IEquatable<ExerciseGym>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ExerciseGym";

        /// <inheritdoc/>
        public bool Equals(ExerciseGym other)
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
        public override bool Equals(object obj) => this.Equals(obj as ExerciseGym);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
