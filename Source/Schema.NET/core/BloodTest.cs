namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A medical test performed on a sample of a patient's blood.
    /// </summary>
    public partial interface IBloodTest : IMedicalTest
    {
    }

    /// <summary>
    /// A medical test performed on a sample of a patient's blood.
    /// </summary>
    [DataContract]
    public partial class BloodTest : MedicalTest, IBloodTest, IEquatable<BloodTest>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BloodTest";

        /// <inheritdoc/>
        public bool Equals(BloodTest other)
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
        public override bool Equals(object obj) => this.Equals(obj as BloodTest);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
