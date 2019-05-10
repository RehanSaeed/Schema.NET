namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A single or list of values which can be any of the specified types.
    /// </summary>
    /// <typeparam name="T1">The first type the values can take.</typeparam>
    /// <typeparam name="T2">The second type the values can take.</typeparam>
    /// <seealso cref="IValue" />
    public struct Values<T1, T2> : IEquatable<Values<T1, T2>>, IValue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1,T2}"/> struct.
        /// </summary>
        /// <param name="value">The value of type <typeparamref name="T1"/>.</param>
        public Values(OneOrMany<T1> value)
        {
            this.Value1 = value;
            this.Value2 = default;
            this.HasValue1 = true;
            this.HasValue2 = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T1,T2}"/> struct.
        /// </summary>
        /// <param name="value">The value of type <typeparamref name="T2"/>.</param>
        public Values(OneOrMany<T2> value)
        {
            this.Value1 = default;
            this.Value2 = value;
            this.HasValue1 = false;
            this.HasValue2 = true;
        }

        /// <summary>
        /// Gets whether the value of type <typeparamref name="T1" /> has a value.
        /// </summary>
        public bool HasValue1 { get; }

        /// <summary>
        /// Gets whether the value of type <typeparamref name="T2" /> has a value.
        /// </summary>
        public bool HasValue2 { get; }

        /// <summary>
        /// Gets the value of type <typeparamref name="T1" />.
        /// </summary>
        public OneOrMany<T1> Value1 { get; }

        /// <summary>
        /// Gets the value of type <typeparamref name="T2" />.
        /// </summary>
        public OneOrMany<T2> Value2 { get; }

        /// <summary>
        /// Gets the non-null object representing the instance.
        /// </summary>
        object IValue.Value
        {
            get
            {
                if (this.HasValue1)
                {
                    return ((IValue)this.Value1).Value;
                }
                else if (this.HasValue2)
                {
                    return ((IValue)this.Value2).Value;
                }

                return null;
            }
        }

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T1"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator Values<T1, T2>(T1 item) => new Values<T1, T2>(item);
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T2"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator Values<T1, T2>(T2 item) => new Values<T1, T2>(item);
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T1}"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator Values<T1, T2>(List<T1> list) => new Values<T1, T2>(list);
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T2}"/> to <see cref="Values{T1,T2}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator Values<T1, T2>(List<T2> list) => new Values<T1, T2>(list);
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="Values{T1, T2}"/> to <see cref="List{T1}"/>.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator List<T1>(Values<T1, T2> values) => values.Value1.ToList();
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="Values{T1, T2}"/> to an array of <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator T1[](Values<T1, T2> values) => values.Value1.ToArray();
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="Values{T1, T2}"/> to <see cref="List{T2}"/>.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator List<T2>(Values<T1, T2> values) => values.Value2.ToList();
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Performs an implicit conversion from <see cref="Values{T1, T2}"/> to an array of <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
#pragma warning disable CA2225 // Operator overloads have named alternates
        public static implicit operator T2[](Values<T1, T2> values) => values.Value2.ToArray();
#pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator ==(Values<T1, T2> left, Values<T1, T2> right) => left.Equals(right);

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator !=(Values<T1, T2> left, Values<T1, T2> right) => !(left == right);

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        public bool Equals(Values<T1, T2> other)
        {
            if (other.HasValue1)
            {
                if (this.HasValue1)
                {
                    return this.Value1.Equals(other.Value1);
                }
            }
            else if (other.HasValue2)
            {
                if (this.HasValue2)
                {
                    return this.Value2.Equals(other.Value2);
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether the specified <see cref="object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj) => obj is Values<T1, T2> ? this.Equals((Values<T1, T2>)obj) : false;

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            if (this.HasValue1)
            {
                return this.Value1.GetHashCode();
            }

            return this.Value2.GetHashCode();
        }
    }
}
